//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using trace = go.@internal.trace_package;
using log = go.log_package;
using http = go.net.http_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ViewerEvent
        {
            // Constructors
            public ViewerEvent(NilType _)
            {
                this.Name = default;
                this.Phase = default;
                this.Scope = default;
                this.Time = default;
                this.Dur = default;
                this.Pid = default;
                this.Tid = default;
                this.ID = default;
                this.Stack = default;
                this.EndStack = default;
            }

            public ViewerEvent(@string Name = default, @string Phase = default, @string Scope = default, double Time = default, double Dur = default, ulong Pid = default, ulong Tid = default, ulong ID = default, long Stack = default, long EndStack = default)
            {
                this.Name = Name;
                this.Phase = Phase;
                this.Scope = Scope;
                this.Time = Time;
                this.Dur = Dur;
                this.Pid = Pid;
                this.Tid = Tid;
                this.ID = ID;
                this.Stack = Stack;
                this.EndStack = EndStack;
            }

            // Enable comparisons between nil and ViewerEvent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ViewerEvent value, NilType nil) => value.Equals(default(ViewerEvent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ViewerEvent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ViewerEvent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ViewerEvent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ViewerEvent(NilType nil) => default(ViewerEvent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ViewerEvent ViewerEvent_cast(dynamic value)
        {
            return new ViewerEvent(value.Name, value.Phase, value.Scope, value.Time, value.Dur, value.Pid, value.Tid, value.ID, value.Stack, value.EndStack);
        }
    }
}