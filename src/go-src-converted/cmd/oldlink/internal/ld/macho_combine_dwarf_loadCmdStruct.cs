//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using zlib = go.compress.zlib_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct loadCmd
        {
            // Constructors
            public loadCmd(NilType _)
            {
                this.Cmd = default;
                this.Len = default;
            }

            public loadCmd(macho.LoadCmd Cmd = default, uint Len = default)
            {
                this.Cmd = Cmd;
                this.Len = Len;
            }

            // Enable comparisons between nil and loadCmd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loadCmd value, NilType nil) => value.Equals(default(loadCmd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loadCmd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loadCmd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loadCmd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loadCmd(NilType nil) => default(loadCmd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static loadCmd loadCmd_cast(dynamic value)
        {
            return new loadCmd(value.Cmd, value.Len);
        }
    }
}}}}