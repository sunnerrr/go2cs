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
        public partial struct Tpacket3Hdr
        {
            // Constructors
            public Tpacket3Hdr(NilType _)
            {
                this.Next_offset = default;
                this.Sec = default;
                this.Nsec = default;
                this.Snaplen = default;
                this.Len = default;
                this.Status = default;
                this.Mac = default;
                this.Net = default;
                this.Hv1 = default;
                this._ = default;
            }

            public Tpacket3Hdr(uint Next_offset = default, uint Sec = default, uint Nsec = default, uint Snaplen = default, uint Len = default, uint Status = default, ushort Mac = default, ushort Net = default, TpacketHdrVariant1 Hv1 = default, array<byte> _ = default)
            {
                this.Next_offset = Next_offset;
                this.Sec = Sec;
                this.Nsec = Nsec;
                this.Snaplen = Snaplen;
                this.Len = Len;
                this.Status = Status;
                this.Mac = Mac;
                this.Net = Net;
                this.Hv1 = Hv1;
                this._ = _;
            }

            // Enable comparisons between nil and Tpacket3Hdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tpacket3Hdr value, NilType nil) => value.Equals(default(Tpacket3Hdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tpacket3Hdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tpacket3Hdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tpacket3Hdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tpacket3Hdr(NilType nil) => default(Tpacket3Hdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tpacket3Hdr Tpacket3Hdr_cast(dynamic value)
        {
            return new Tpacket3Hdr(value.Next_offset, value.Sec, value.Nsec, value.Snaplen, value.Len, value.Status, value.Mac, value.Net, value.Hv1, value._);
        }
    }
}}}}}}