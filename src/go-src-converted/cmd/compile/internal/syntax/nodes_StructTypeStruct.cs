//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct StructType
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public StructType(NilType _)
            {
                this.FieldList = default;
                this.TagList = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public StructType(slice<ref Field> FieldList = default, slice<ref BasicLit> TagList = default, expr expr = default)
            {
                this.FieldList = FieldList;
                this.TagList = TagList;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and StructType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StructType value, NilType nil) => value.Equals(default(StructType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StructType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StructType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StructType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StructType(NilType nil) => default(StructType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static StructType StructType_cast(dynamic value)
        {
            return new StructType(value.FieldList, value.TagList, value.expr);
        }
    }
}}}}