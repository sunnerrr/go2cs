//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

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
        public partial struct TIPCEvent
        {
            // Constructors
            public TIPCEvent(NilType _)
            {
                this.Event = default;
                this.Lower = default;
                this.Upper = default;
                this.Port = default;
                this.S = default;
            }

            public TIPCEvent(uint Event = default, uint Lower = default, uint Upper = default, TIPCSocketAddr Port = default, TIPCSubscr S = default)
            {
                this.Event = Event;
                this.Lower = Lower;
                this.Upper = Upper;
                this.Port = Port;
                this.S = S;
            }

            // Enable comparisons between nil and TIPCEvent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TIPCEvent value, NilType nil) => value.Equals(default(TIPCEvent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TIPCEvent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TIPCEvent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TIPCEvent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TIPCEvent(NilType nil) => default(TIPCEvent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TIPCEvent TIPCEvent_cast(dynamic value)
        {
            return new TIPCEvent(value.Event, value.Lower, value.Upper, value.Port, value.S);
        }
    }
}}}}}}