//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct envItem
        {
            // Constructors
            public envItem(NilType _)
            {
                this.name = default;
                this.value = default;
                this.nvalue = default;
            }

            public envItem(ref ptr<byte> name = default, ref ptr<byte> value = default, long nvalue = default)
            {
                this.name = name;
                this.value = value;
                this.nvalue = nvalue;
            }

            // Enable comparisons between nil and envItem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(envItem value, NilType nil) => value.Equals(default(envItem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(envItem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, envItem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, envItem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator envItem(NilType nil) => default(envItem);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static envItem envItem_cast(dynamic value)
        {
            return new envItem(ref value.name, ref value.value, value.nvalue);
        }
    }
}