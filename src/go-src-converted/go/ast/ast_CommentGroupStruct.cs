//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CommentGroup
        {
            // Constructors
            public CommentGroup(NilType _)
            {
                this.List = default;
            }

            public CommentGroup(slice<ptr<Comment>> List = default)
            {
                this.List = List;
            }

            // Enable comparisons between nil and CommentGroup struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CommentGroup value, NilType nil) => value.Equals(default(CommentGroup));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CommentGroup value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CommentGroup value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CommentGroup value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommentGroup(NilType nil) => default(CommentGroup);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CommentGroup CommentGroup_cast(dynamic value)
        {
            return new CommentGroup(value.List);
        }
    }
}}