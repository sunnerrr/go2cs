//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:51:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using elf = go.debug.elf_package;
using fmt = go.fmt_package;
using log = go.log_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InlinedCall
        {
            // Constructors
            public InlinedCall(NilType _)
            {
                this.Parent = default;
                this.File = default;
                this.Line = default;
                this.Func = default;
                this.ParentPC = default;
            }

            public InlinedCall(int Parent = default, ref ptr<Symbol> File = default, int Line = default, @string Func = default, int ParentPC = default)
            {
                this.Parent = Parent;
                this.File = File;
                this.Line = Line;
                this.Func = Func;
                this.ParentPC = ParentPC;
            }

            // Enable comparisons between nil and InlinedCall struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InlinedCall value, NilType nil) => value.Equals(default(InlinedCall));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InlinedCall value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InlinedCall value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InlinedCall value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InlinedCall(NilType nil) => default(InlinedCall);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InlinedCall InlinedCall_cast(dynamic value)
        {
            return new InlinedCall(value.Parent, ref value.File, value.Line, value.Func, value.ParentPC);
        }
    }
}}}}