//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:23 UTC
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
using types = go.go.types_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct blank
        {
            // Constructors
            public blank(NilType _)
            {
            }
            // Enable comparisons between nil and blank struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(blank value, NilType nil) => value.Equals(default(blank));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(blank value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, blank value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, blank value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator blank(NilType nil) => default(blank);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static blank blank_cast(dynamic value)
        {
            return new blank();
        }
    }
}}}}}