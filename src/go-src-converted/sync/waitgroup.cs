// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package sync -- go2cs converted at 2020 August 29 08:36:45 UTC
// import "sync" ==> using sync = go.sync_package
// Original source: C:\Go\src\sync\waitgroup.go
using race = go.@internal.race_package;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class sync_package
    {
        // A WaitGroup waits for a collection of goroutines to finish.
        // The main goroutine calls Add to set the number of
        // goroutines to wait for. Then each of the goroutines
        // runs and calls Done when finished. At the same time,
        // Wait can be used to block until all goroutines have finished.
        //
        // A WaitGroup must not be copied after first use.
        public partial struct WaitGroup
        {
            public noCopy noCopy; // 64-bit value: high 32 bits are counter, low 32 bits are waiter count.
// 64-bit atomic operations require 64-bit alignment, but 32-bit
// compilers do not ensure it. So we allocate 12 bytes and then use
// the aligned 8 bytes in them as state.
            public array<byte> state1;
            public uint sema;
        }

        private static ref ulong state(this ref WaitGroup wg)
        {
            if (uintptr(@unsafe.Pointer(ref wg.state1)) % 8L == 0L)
            {
                return (uint64.Value)(@unsafe.Pointer(ref wg.state1));
            }
            else
            {
                return (uint64.Value)(@unsafe.Pointer(ref wg.state1[4L]));
            }
        }

        // Add adds delta, which may be negative, to the WaitGroup counter.
        // If the counter becomes zero, all goroutines blocked on Wait are released.
        // If the counter goes negative, Add panics.
        //
        // Note that calls with a positive delta that occur when the counter is zero
        // must happen before a Wait. Calls with a negative delta, or calls with a
        // positive delta that start when the counter is greater than zero, may happen
        // at any time.
        // Typically this means the calls to Add should execute before the statement
        // creating the goroutine or other event to be waited for.
        // If a WaitGroup is reused to wait for several independent sets of events,
        // new Add calls must happen after all previous Wait calls have returned.
        // See the WaitGroup example.
        private static void Add(this ref WaitGroup _wg, long delta) => func(_wg, (ref WaitGroup wg, Defer defer, Panic panic, Recover _) =>
        {
            var statep = wg.state();
            if (race.Enabled)
            {
                _ = statep.Value; // trigger nil deref early
                if (delta < 0L)
                { 
                    // Synchronize decrements with Wait.
                    race.ReleaseMerge(@unsafe.Pointer(wg));
                }
                race.Disable();
                defer(race.Enable());
            }
            var state = atomic.AddUint64(statep, uint64(delta) << (int)(32L));
            var v = int32(state >> (int)(32L));
            var w = uint32(state);
            if (race.Enabled && delta > 0L && v == int32(delta))
            { 
                // The first increment must be synchronized with Wait.
                // Need to model this as a read, because there can be
                // several concurrent wg.counter transitions from 0.
                race.Read(@unsafe.Pointer(ref wg.sema));
            }
            if (v < 0L)
            {
                panic("sync: negative WaitGroup counter");
            }
            if (w != 0L && delta > 0L && v == int32(delta))
            {
                panic("sync: WaitGroup misuse: Add called concurrently with Wait");
            }
            if (v > 0L || w == 0L)
            {
                return;
            } 
            // This goroutine has set counter to 0 when waiters > 0.
            // Now there can't be concurrent mutations of state:
            // - Adds must not happen concurrently with Wait,
            // - Wait does not increment waiters if it sees counter == 0.
            // Still do a cheap sanity check to detect WaitGroup misuse.
            if (statep != state.Value)
            {
                panic("sync: WaitGroup misuse: Add called concurrently with Wait");
            } 
            // Reset waiters count to 0.
            statep.Value = 0L;
            while (w != 0L)
            {
                runtime_Semrelease(ref wg.sema, false);
                w--;
            }

        });

        // Done decrements the WaitGroup counter by one.
        private static void Done(this ref WaitGroup wg)
        {
            wg.Add(-1L);
        }

        // Wait blocks until the WaitGroup counter is zero.
        private static void Wait(this ref WaitGroup _wg) => func(_wg, (ref WaitGroup wg, Defer _, Panic panic, Recover __) =>
        {
            var statep = wg.state();
            if (race.Enabled)
            {
                _ = statep.Value; // trigger nil deref early
                race.Disable();
            }
            while (true)
            {
                var state = atomic.LoadUint64(statep);
                var v = int32(state >> (int)(32L));
                var w = uint32(state);
                if (v == 0L)
                { 
                    // Counter is 0, no need to wait.
                    if (race.Enabled)
                    {
                        race.Enable();
                        race.Acquire(@unsafe.Pointer(wg));
                    }
                    return;
                } 
                // Increment waiters count.
                if (atomic.CompareAndSwapUint64(statep, state, state + 1L))
                {
                    if (race.Enabled && w == 0L)
                    { 
                        // Wait must be synchronized with the first Add.
                        // Need to model this is as a write to race with the read in Add.
                        // As a consequence, can do the write only for the first waiter,
                        // otherwise concurrent Waits will race with each other.
                        race.Write(@unsafe.Pointer(ref wg.sema));
                    }
                    runtime_Semacquire(ref wg.sema);
                    if (statep != 0L.Value)
                    {
                        panic("sync: WaitGroup is reused before previous Wait has returned");
                    }
                    if (race.Enabled)
                    {
                        race.Enable();
                        race.Acquire(@unsafe.Pointer(wg));
                    }
                    return;
                }
            }

        });
    }
}