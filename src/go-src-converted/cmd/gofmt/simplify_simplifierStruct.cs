//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:02:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using reflect = go.reflect_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct simplifier
        {
            // Constructors
            public simplifier(NilType _)
            {
            }
            // Enable comparisons between nil and simplifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(simplifier value, NilType nil) => value.Equals(default(simplifier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(simplifier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, simplifier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, simplifier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator simplifier(NilType nil) => default(simplifier);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static simplifier simplifier_cast(dynamic value)
        {
            return new simplifier();
        }
    }
}