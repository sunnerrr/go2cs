//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using strings = go.strings_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nextProtoMsg
        {
            // Constructors
            public nextProtoMsg(NilType _)
            {
                this.raw = default;
                this.proto = default;
            }

            public nextProtoMsg(slice<byte> raw = default, @string proto = default)
            {
                this.raw = raw;
                this.proto = proto;
            }

            // Enable comparisons between nil and nextProtoMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nextProtoMsg value, NilType nil) => value.Equals(default(nextProtoMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nextProtoMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nextProtoMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nextProtoMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nextProtoMsg(NilType nil) => default(nextProtoMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nextProtoMsg nextProtoMsg_cast(dynamic value)
        {
            return new nextProtoMsg(value.raw, value.proto);
        }
    }
}}