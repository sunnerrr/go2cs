//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:52 UTC
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct QUERY_SERVICE_CONFIG
        {
            // Constructors
            public QUERY_SERVICE_CONFIG(NilType _)
            {
                this.ServiceType = default;
                this.StartType = default;
                this.ErrorControl = default;
                this.BinaryPathName = default;
                this.LoadOrderGroup = default;
                this.TagId = default;
                this.Dependencies = default;
                this.ServiceStartName = default;
                this.DisplayName = default;
            }

            public QUERY_SERVICE_CONFIG(uint ServiceType = default, uint StartType = default, uint ErrorControl = default, ref ptr<ushort> BinaryPathName = default, ref ptr<ushort> LoadOrderGroup = default, uint TagId = default, ref ptr<ushort> Dependencies = default, ref ptr<ushort> ServiceStartName = default, ref ptr<ushort> DisplayName = default)
            {
                this.ServiceType = ServiceType;
                this.StartType = StartType;
                this.ErrorControl = ErrorControl;
                this.BinaryPathName = BinaryPathName;
                this.LoadOrderGroup = LoadOrderGroup;
                this.TagId = TagId;
                this.Dependencies = Dependencies;
                this.ServiceStartName = ServiceStartName;
                this.DisplayName = DisplayName;
            }

            // Enable comparisons between nil and QUERY_SERVICE_CONFIG struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(QUERY_SERVICE_CONFIG value, NilType nil) => value.Equals(default(QUERY_SERVICE_CONFIG));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(QUERY_SERVICE_CONFIG value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, QUERY_SERVICE_CONFIG value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, QUERY_SERVICE_CONFIG value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator QUERY_SERVICE_CONFIG(NilType nil) => default(QUERY_SERVICE_CONFIG);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static QUERY_SERVICE_CONFIG QUERY_SERVICE_CONFIG_cast(dynamic value)
        {
            return new QUERY_SERVICE_CONFIG(value.ServiceType, value.StartType, value.ErrorControl, ref value.BinaryPathName, ref value.LoadOrderGroup, value.TagId, ref value.Dependencies, ref value.ServiceStartName, ref value.DisplayName);
        }
    }
}}}}}}