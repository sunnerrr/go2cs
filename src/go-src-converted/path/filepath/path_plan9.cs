// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package filepath -- go2cs converted at 2020 October 09 04:49:46 UTC
// import "path/filepath" ==> using filepath = go.path.filepath_package
// Original source: C:\Go\src\path\filepath\path_plan9.go
using strings = go.strings_package;
using static go.builtin;

namespace go {
namespace path
{
    public static partial class filepath_package
    {
        // IsAbs reports whether the path is absolute.
        public static bool IsAbs(@string path)
        {
            return strings.HasPrefix(path, "/") || strings.HasPrefix(path, "#");
        }

        // volumeNameLen returns length of the leading volume name on Windows.
        // It returns 0 elsewhere.
        private static long volumeNameLen(@string path)
        {
            return 0L;
        }

        // HasPrefix exists for historical compatibility and should not be used.
        //
        // Deprecated: HasPrefix does not respect path boundaries and
        // does not ignore case when required.
        public static bool HasPrefix(@string p, @string prefix)
        {
            return strings.HasPrefix(p, prefix);
        }

        private static slice<@string> splitList(@string path)
        {
            if (path == "")
            {
                return new slice<@string>(new @string[] {  });
            }

            return strings.Split(path, string(ListSeparator));

        }

        private static (@string, error) abs(@string path)
        {
            @string _p0 = default;
            error _p0 = default!;

            return unixAbs(path);
        }

        private static @string join(slice<@string> elem)
        { 
            // If there's a bug here, fix the logic in ./path_unix.go too.
            foreach (var (i, e) in elem)
            {
                if (e != "")
                {
                    return Clean(strings.Join(elem[i..], string(Separator)));
                }

            }
            return "";

        }

        private static bool sameWord(@string a, @string b)
        {
            return a == b;
        }
    }
}}
