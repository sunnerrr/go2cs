//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Format
        {
            // Value of the Format struct
            private readonly long m_value;

            public Format(long value) => m_value = value;

            // Enable implicit conversions between long and Format struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Format(long value) => new Format(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Format value) => value.m_value;
            
            // Enable comparisons between nil and Format struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Format value, NilType nil) => value.Equals(default(Format));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Format value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Format value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Format value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Format(NilType nil) => default(Format);
        }
    }
}}
