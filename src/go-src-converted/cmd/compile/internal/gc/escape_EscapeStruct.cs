//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:41:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using logopt = go.cmd.compile.@internal.logopt_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using math = go.math_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Escape
        {
            // Constructors
            public Escape(NilType _)
            {
                this.allLocs = default;
                this.curfn = default;
                this.loopDepth = default;
                this.heapLoc = default;
                this.blankLoc = default;
            }

            public Escape(slice<ptr<EscLocation>> allLocs = default, ref ptr<Node> curfn = default, long loopDepth = default, EscLocation heapLoc = default, EscLocation blankLoc = default)
            {
                this.allLocs = allLocs;
                this.curfn = curfn;
                this.loopDepth = loopDepth;
                this.heapLoc = heapLoc;
                this.blankLoc = blankLoc;
            }

            // Enable comparisons between nil and Escape struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Escape value, NilType nil) => value.Equals(default(Escape));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Escape value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Escape value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Escape value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Escape(NilType nil) => default(Escape);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Escape Escape_cast(dynamic value)
        {
            return new Escape(value.allLocs, ref value.curfn, value.loopDepth, value.heapLoc, value.blankLoc);
        }
    }
}}}}