//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm64
{
    public static partial class arm64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct instArg
        {
            // Value of the instArg struct
            private readonly ushort m_value;

            public instArg(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and instArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArg(ushort value) => new instArg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(instArg value) => value.m_value;
            
            // Enable comparisons between nil and instArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(instArg value, NilType nil) => value.Equals(default(instArg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(instArg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, instArg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, instArg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArg(NilType nil) => default(instArg);
        }
    }
}}}}}}}