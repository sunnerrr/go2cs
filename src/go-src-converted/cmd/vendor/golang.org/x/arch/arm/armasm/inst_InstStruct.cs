//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Inst
        {
            // Constructors
            public Inst(NilType _)
            {
                this.Op = default;
                this.Enc = default;
                this.Len = default;
                this.Args = default;
            }

            public Inst(Op Op = default, uint Enc = default, long Len = default, Args Args = default)
            {
                this.Op = Op;
                this.Enc = Enc;
                this.Len = Len;
                this.Args = Args;
            }

            // Enable comparisons between nil and Inst struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Inst value, NilType nil) => value.Equals(default(Inst));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Inst value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Inst value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Inst value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Inst(NilType nil) => default(Inst);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Inst Inst_cast(dynamic value)
        {
            return new Inst(value.Op, value.Enc, value.Len, value.Args);
        }
    }
}}}}}}}