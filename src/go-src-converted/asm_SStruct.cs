//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace asmdecl {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct S
        {
            // Constructors
            public S(NilType _)
            {
                this.i = default;
                this.b = default;
                this.s = default;
            }

            public S(int i = default, bool b = default, @string s = default)
            {
                this.i = i;
                this.b = b;
                this.s = s;
            }

            // Enable comparisons between nil and S struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S value, NilType nil) => value.Equals(default(S));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S(NilType nil) => default(S);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S S_cast(dynamic value)
        {
            return new S(value.i, value.b, value.s);
        }
    }
}}}}}}}}}}