//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sparseDatas
        {
            // Value of the sparseDatas struct
            private readonly slice<sparseEntry> m_value;

            public sparseDatas(slice<sparseEntry> value) => m_value = value;

            // Enable implicit conversions between slice<sparseEntry> and sparseDatas struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sparseDatas(slice<sparseEntry> value) => new sparseDatas(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<sparseEntry>(sparseDatas value) => value.m_value;
            
            // Enable comparisons between nil and sparseDatas struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sparseDatas value, NilType nil) => value.Equals(default(sparseDatas));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sparseDatas value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sparseDatas value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sparseDatas value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sparseDatas(NilType nil) => default(sparseDatas);
        }
    }
}}