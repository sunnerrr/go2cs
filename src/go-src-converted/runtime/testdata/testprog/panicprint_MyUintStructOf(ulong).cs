//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyUint
        {
            // Value of the MyUint struct
            private readonly ulong m_value;

            public MyUint(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and MyUint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyUint(ulong value) => new MyUint(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(MyUint value) => value.m_value;
            
            // Enable comparisons between nil and MyUint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyUint value, NilType nil) => value.Equals(default(MyUint));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyUint value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyUint value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyUint value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyUint(NilType nil) => default(MyUint);
        }
    }
}