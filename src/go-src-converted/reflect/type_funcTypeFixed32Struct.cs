//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(funcType))]
        private partial struct funcTypeFixed32
        {
            // funcType structure promotion - sourced from value copy
            private readonly ptr<funcType> m_funcTypeRef;

            private ref funcType funcType_val => ref m_funcTypeRef.Value;

            public ref ushort inCount => ref m_funcTypeRef.Value.inCount;

            public ref ushort outCount => ref m_funcTypeRef.Value.outCount;

            // Constructors
            public funcTypeFixed32(NilType _)
            {
                this.m_funcTypeRef = new ptr<funcType>(new funcType(nil));
                this.args = default;
            }

            public funcTypeFixed32(funcType funcType = default, array<ref rtype> args = default)
            {
                this.m_funcTypeRef = new ptr<funcType>(funcType);
                this.args = args;
            }

            // Enable comparisons between nil and funcTypeFixed32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(funcTypeFixed32 value, NilType nil) => value.Equals(default(funcTypeFixed32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(funcTypeFixed32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, funcTypeFixed32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, funcTypeFixed32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator funcTypeFixed32(NilType nil) => default(funcTypeFixed32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static funcTypeFixed32 funcTypeFixed32_cast(dynamic value)
        {
            return new funcTypeFixed32(value.funcType, value.args);
        }
    }
}