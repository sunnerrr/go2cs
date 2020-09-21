//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Frame
        {
            // Constructors
            public Frame(NilType _)
            {
                this.PC = default;
                this.Func = default;
                this.Function = default;
                this.File = default;
                this.Line = default;
                this.Entry = default;
            }

            public Frame(System.UIntPtr PC = default, ref ptr<Func> Func = default, @string Function = default, @string File = default, long Line = default, System.UIntPtr Entry = default)
            {
                this.PC = PC;
                this.Func = Func;
                this.Function = Function;
                this.File = File;
                this.Line = Line;
                this.Entry = Entry;
            }

            // Enable comparisons between nil and Frame struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Frame value, NilType nil) => value.Equals(default(Frame));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Frame value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Frame value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Frame value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Frame(NilType nil) => default(Frame);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Frame Frame_cast(dynamic value)
        {
            return new Frame(value.PC, ref value.Func, value.Function, value.File, value.Line, value.Entry);
        }
    }
}