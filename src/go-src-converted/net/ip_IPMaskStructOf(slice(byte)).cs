//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IPMask
        {
            // Value of the IPMask struct
            private readonly slice<byte> m_value;

            public IPMask(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and IPMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPMask(slice<byte> value) => new IPMask(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(IPMask value) => value.m_value;
            
            // Enable comparisons between nil and IPMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPMask value, NilType nil) => value.Equals(default(IPMask));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPMask value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPMask value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPMask value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPMask(NilType nil) => default(IPMask);
        }
    }
}