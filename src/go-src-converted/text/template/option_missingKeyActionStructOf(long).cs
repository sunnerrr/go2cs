//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:35:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace text
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct missingKeyAction
        {
            // Value of the missingKeyAction struct
            private readonly long m_value;

            public missingKeyAction(long value) => m_value = value;

            // Enable implicit conversions between long and missingKeyAction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator missingKeyAction(long value) => new missingKeyAction(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(missingKeyAction value) => value.m_value;
            
            // Enable comparisons between nil and missingKeyAction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(missingKeyAction value, NilType nil) => value.Equals(default(missingKeyAction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(missingKeyAction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, missingKeyAction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, missingKeyAction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator missingKeyAction(NilType nil) => default(missingKeyAction);
        }
    }
}}