//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:18 UTC
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
using syscall = go.syscall_package;
using go;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct result
        {
            // Constructors
            public result(NilType _)
            {
                this.n = default;
                this.err = default;
            }

            public result(long n = default, error err = default)
            {
                this.n = n;
                this.err = err;
            }

            // Enable comparisons between nil and result struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(result value, NilType nil) => value.Equals(default(result));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(result value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, result value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, result value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator result(NilType nil) => default(result);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static result result_cast(dynamic value)
        {
            return new result(value.n, value.err);
        }
    }
}}