//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:57:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PtraceRegsArm
        {
            // Constructors
            public PtraceRegsArm(NilType _)
            {
                this.Uregs = default;
            }

            public PtraceRegsArm(array<uint> Uregs = default)
            {
                this.Uregs = Uregs;
            }

            // Enable comparisons between nil and PtraceRegsArm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PtraceRegsArm value, NilType nil) => value.Equals(default(PtraceRegsArm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PtraceRegsArm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PtraceRegsArm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PtraceRegsArm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PtraceRegsArm(NilType nil) => default(PtraceRegsArm);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PtraceRegsArm PtraceRegsArm_cast(dynamic value)
        {
            return new PtraceRegsArm(value.Uregs);
        }
    }
}}}}}}