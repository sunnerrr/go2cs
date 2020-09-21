// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package rand implements a cryptographically secure
// pseudorandom number generator.
// package rand -- go2cs converted at 2020 August 29 08:30:49 UTC
// import "crypto/rand" ==> using rand = go.crypto.rand_package
// Original source: C:\Go\src\crypto\rand\rand.go
using io = go.io_package;
using static go.builtin;

namespace go {
namespace crypto
{
    public static partial class rand_package
    {
        // Reader is a global, shared instance of a cryptographically
        // strong pseudo-random generator.
        //
        // On Linux, Reader uses getrandom(2) if available, /dev/urandom otherwise.
        // On OpenBSD, Reader uses getentropy(2).
        // On other Unix-like systems, Reader reads from /dev/urandom.
        // On Windows systems, Reader uses the CryptGenRandom API.
        public static io.Reader Reader = default;

        // Read is a helper function that calls Reader.Read using io.ReadFull.
        // On return, n == len(b) if and only if err == nil.
        public static (long, error) Read(slice<byte> b)
        {
            return io.ReadFull(Reader, b);
        }
    }
}}