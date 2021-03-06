//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:59:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using base64 = go.encoding.base64_package;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf16 = go.unicode.utf16_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct decodeState
        {
            // Constructors
            public decodeState(NilType _)
            {
                this.data = default;
                this.off = default;
                this.opcode = default;
                this.scan = default;
                this.savedError = default;
                this.useNumber = default;
                this.disallowUnknownFields = default;
            }

            public decodeState(slice<byte> data = default, long off = default, long opcode = default, scanner scan = default, error savedError = default, bool useNumber = default, bool disallowUnknownFields = default)
            {
                this.data = data;
                this.off = off;
                this.opcode = opcode;
                this.scan = scan;
                this.savedError = savedError;
                this.useNumber = useNumber;
                this.disallowUnknownFields = disallowUnknownFields;
            }

            // Enable comparisons between nil and decodeState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(decodeState value, NilType nil) => value.Equals(default(decodeState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(decodeState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, decodeState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, decodeState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator decodeState(NilType nil) => default(decodeState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static decodeState decodeState_cast(dynamic value)
        {
            return new decodeState(value.data, value.off, value.opcode, value.scan, value.savedError, value.useNumber, value.disallowUnknownFields);
        }
    }
}}