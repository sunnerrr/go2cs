//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T6a
        {
            // Value of the T6a struct
            private readonly channel<long> m_value;

            public T6a(channel<long> value) => m_value = value;

            // Enable implicit conversions between channel<long> and T6a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6a(channel<long> value) => new T6a(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator channel<long>(T6a value) => value.m_value;
            
            // Enable comparisons between nil and T6a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T6a value, NilType nil) => value.Equals(default(T6a));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T6a value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T6a value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T6a value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6a(NilType nil) => default(T6a);
        }
    }
}}}}}}