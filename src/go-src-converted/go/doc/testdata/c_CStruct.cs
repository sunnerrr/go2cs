//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using a = go.a_package;
using go;

namespace go {
namespace go
{
    public static partial class c_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct C
        {
            // Constructors
            public C(NilType _)
            {
            }
            // Enable comparisons between nil and C struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(C value, NilType nil) => value.Equals(default(C));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(C value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, C value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, C value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator C(NilType nil) => default(C);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static C C_cast(dynamic value)
        {
            return new C();
        }
    }
}}