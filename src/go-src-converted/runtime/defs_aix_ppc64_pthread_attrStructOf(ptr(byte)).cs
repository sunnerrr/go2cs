//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pthread_attr
        {
            // Value of the pthread_attr struct
            private readonly ptr<byte> m_value;

            public pthread_attr(ptr<byte> value) => m_value = value;

            // Enable implicit conversions between ptr<byte> and pthread_attr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthread_attr(ptr<byte> value) => new pthread_attr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptr<byte>(pthread_attr value) => value.m_value;
            
            // Enable comparisons between nil and pthread_attr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthread_attr value, NilType nil) => value.Equals(default(pthread_attr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthread_attr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthread_attr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthread_attr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthread_attr(NilType nil) => default(pthread_attr);
        }
    }
}
