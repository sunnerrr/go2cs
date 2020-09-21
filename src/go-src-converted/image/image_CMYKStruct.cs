//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using color = go.image.color_package;

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CMYK
        {
            // Constructors
            public CMYK(NilType _)
            {
                this.Pix = default;
                this.Stride = default;
                this.Rect = default;
            }

            public CMYK(slice<byte> Pix = default, long Stride = default, Rectangle Rect = default)
            {
                this.Pix = Pix;
                this.Stride = Stride;
                this.Rect = Rect;
            }

            // Enable comparisons between nil and CMYK struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CMYK value, NilType nil) => value.Equals(default(CMYK));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CMYK value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CMYK value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CMYK value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CMYK(NilType nil) => default(CMYK);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CMYK CMYK_cast(dynamic value)
        {
            return new CMYK(value.Pix, value.Stride, value.Rect);
        }
    }
}