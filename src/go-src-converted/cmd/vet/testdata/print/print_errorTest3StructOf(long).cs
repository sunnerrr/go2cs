//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorTest3
        {
            // Value of the errorTest3 struct
            private readonly long m_value;

            public errorTest3(long value) => m_value = value;

            // Enable implicit conversions between long and errorTest3 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorTest3(long value) => new errorTest3(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(errorTest3 value) => value.m_value;
            
            // Enable comparisons between nil and errorTest3 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorTest3 value, NilType nil) => value.Equals(default(errorTest3));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorTest3 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorTest3 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorTest3 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorTest3(NilType nil) => default(errorTest3);
        }
    }
}}}}