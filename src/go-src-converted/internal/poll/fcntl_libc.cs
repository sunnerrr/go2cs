// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build aix darwin solaris

// package poll -- go2cs converted at 2020 October 09 04:51:01 UTC
// import "internal/poll" ==> using poll = go.@internal.poll_package
// Original source: C:\Go\src\internal\poll\fcntl_libc.go
using _@unsafe_ = go.@unsafe_package;
using static go.builtin;

namespace go {
namespace @internal
{
    public static partial class poll_package
    { // for go:linkname

        // Implemented in the syscall package.
        //go:linkname fcntl syscall.fcntl
        private static (long, error) fcntl(long fd, long cmd, long arg)
;
    }
}}
