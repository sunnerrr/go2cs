//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IPv6MTUInfo
        {
            // Constructors
            public IPv6MTUInfo(NilType _)
            {
                this.Addr = default;
                this.Mtu = default;
            }

            public IPv6MTUInfo(RawSockaddrInet6 Addr = default, uint Mtu = default)
            {
                this.Addr = Addr;
                this.Mtu = Mtu;
            }

            // Enable comparisons between nil and IPv6MTUInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPv6MTUInfo value, NilType nil) => value.Equals(default(IPv6MTUInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPv6MTUInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPv6MTUInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPv6MTUInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPv6MTUInfo(NilType nil) => default(IPv6MTUInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPv6MTUInfo IPv6MTUInfo_cast(dynamic value)
        {
            return new IPv6MTUInfo(value.Addr, value.Mtu);
        }
    }
}