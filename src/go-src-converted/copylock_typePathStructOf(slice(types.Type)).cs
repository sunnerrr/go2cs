//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:57 UTC
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
namespace analysis {
namespace passes
{
    public static partial class copylock_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typePath
        {
            // Value of the typePath struct
            private readonly slice<types.Type> m_value;

            public typePath(slice<types.Type> value) => m_value = value;

            // Enable implicit conversions between slice<types.Type> and typePath struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typePath(slice<types.Type> value) => new typePath(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<types.Type>(typePath value) => value.m_value;
            
            // Enable comparisons between nil and typePath struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typePath value, NilType nil) => value.Equals(default(typePath));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typePath value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typePath value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typePath value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typePath(NilType nil) => default(typePath);
        }
    }
}}}}}}}