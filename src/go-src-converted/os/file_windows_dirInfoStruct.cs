//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:44:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using poll = go.@internal.poll_package;
using windows = go.@internal.syscall.windows_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dirInfo
        {
            // Constructors
            public dirInfo(NilType _)
            {
                this.data = default;
                this.needdata = default;
                this.path = default;
                this.isempty = default;
            }

            public dirInfo(syscall.Win32finddata data = default, bool needdata = default, @string path = default, bool isempty = default)
            {
                this.data = data;
                this.needdata = needdata;
                this.path = path;
                this.isempty = isempty;
            }

            // Enable comparisons between nil and dirInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dirInfo value, NilType nil) => value.Equals(default(dirInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dirInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dirInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dirInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dirInfo(NilType nil) => default(dirInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dirInfo dirInfo_cast(dynamic value)
        {
            return new dirInfo(value.data, value.needdata, value.path, value.isempty);
        }
    }
}