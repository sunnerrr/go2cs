//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace syscall
{
    public static partial class js_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ValueError
        {
            // Constructors
            public ValueError(NilType _)
            {
                this.Method = default;
                this.Type = default;
            }

            public ValueError(@string Method = default, Type Type = default)
            {
                this.Method = Method;
                this.Type = Type;
            }

            // Enable comparisons between nil and ValueError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ValueError value, NilType nil) => value.Equals(default(ValueError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ValueError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ValueError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ValueError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValueError(NilType nil) => default(ValueError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ValueError ValueError_cast(dynamic value)
        {
            return new ValueError(value.Method, value.Type);
        }
    }
}}