//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:55:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct desiredState
        {
            // Constructors
            public desiredState(NilType _)
            {
                this.entries = default;
                this.avoid = default;
            }

            public desiredState(slice<desiredStateEntry> entries = default, regMask avoid = default)
            {
                this.entries = entries;
                this.avoid = avoid;
            }

            // Enable comparisons between nil and desiredState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(desiredState value, NilType nil) => value.Equals(default(desiredState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(desiredState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, desiredState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, desiredState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator desiredState(NilType nil) => default(desiredState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static desiredState desiredState_cast(dynamic value)
        {
            return new desiredState(value.entries, value.avoid);
        }
    }
}}}}