//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct exceptionstate32
        {
            // Constructors
            public exceptionstate32(NilType _)
            {
                this.trapno = default;
                this.err = default;
                this.faultvaddr = default;
            }

            public exceptionstate32(uint trapno = default, uint err = default, uint faultvaddr = default)
            {
                this.trapno = trapno;
                this.err = err;
                this.faultvaddr = faultvaddr;
            }

            // Enable comparisons between nil and exceptionstate32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(exceptionstate32 value, NilType nil) => value.Equals(default(exceptionstate32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(exceptionstate32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, exceptionstate32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, exceptionstate32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator exceptionstate32(NilType nil) => default(exceptionstate32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static exceptionstate32 exceptionstate32_cast(dynamic value)
        {
            return new exceptionstate32(value.trapno, value.err, value.faultvaddr);
        }
    }
}