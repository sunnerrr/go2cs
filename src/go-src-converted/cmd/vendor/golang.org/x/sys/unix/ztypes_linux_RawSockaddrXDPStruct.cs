//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
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
        public partial struct RawSockaddrXDP
        {
            // Constructors
            public RawSockaddrXDP(NilType _)
            {
                this.Family = default;
                this.Flags = default;
                this.Ifindex = default;
                this.Queue_id = default;
                this.Shared_umem_fd = default;
            }

            public RawSockaddrXDP(ushort Family = default, ushort Flags = default, uint Ifindex = default, uint Queue_id = default, uint Shared_umem_fd = default)
            {
                this.Family = Family;
                this.Flags = Flags;
                this.Ifindex = Ifindex;
                this.Queue_id = Queue_id;
                this.Shared_umem_fd = Shared_umem_fd;
            }

            // Enable comparisons between nil and RawSockaddrXDP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrXDP value, NilType nil) => value.Equals(default(RawSockaddrXDP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrXDP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrXDP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrXDP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrXDP(NilType nil) => default(RawSockaddrXDP);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrXDP RawSockaddrXDP_cast(dynamic value)
        {
            return new RawSockaddrXDP(value.Family, value.Flags, value.Ifindex, value.Queue_id, value.Shared_umem_fd);
        }
    }
}}}}}}