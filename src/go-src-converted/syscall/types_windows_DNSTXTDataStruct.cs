//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:02:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DNSTXTData
        {
            // Constructors
            public DNSTXTData(NilType _)
            {
                this.StringCount = default;
                this.StringArray = default;
            }

            public DNSTXTData(ushort StringCount = default, array<ptr<ushort>> StringArray = default)
            {
                this.StringCount = StringCount;
                this.StringArray = StringArray;
            }

            // Enable comparisons between nil and DNSTXTData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DNSTXTData value, NilType nil) => value.Equals(default(DNSTXTData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DNSTXTData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DNSTXTData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DNSTXTData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DNSTXTData(NilType nil) => default(DNSTXTData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DNSTXTData DNSTXTData_cast(dynamic value)
        {
            return new DNSTXTData(value.StringCount, value.StringArray);
        }
    }
}