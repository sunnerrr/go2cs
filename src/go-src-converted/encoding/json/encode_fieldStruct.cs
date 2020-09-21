//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:35:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using encoding = go.encoding_package;
using base64 = go.encoding.base64_package;
using fmt = go.fmt_package;
using math = go.math_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct field
        {
            // Constructors
            public field(NilType _)
            {
                this.name = default;
                this.nameBytes = default;
                this.equalFold = default;
                this.tag = default;
                this.index = default;
                this.typ = default;
                this.omitEmpty = default;
                this.quoted = default;
            }

            public field(@string name = default, slice<byte> nameBytes = default, Func<slice<byte>, slice<byte>, bool> equalFold = default, bool tag = default, slice<long> index = default, reflect.Type typ = default, bool omitEmpty = default, bool quoted = default)
            {
                this.name = name;
                this.nameBytes = nameBytes;
                this.equalFold = equalFold;
                this.tag = tag;
                this.index = index;
                this.typ = typ;
                this.omitEmpty = omitEmpty;
                this.quoted = quoted;
            }

            // Enable comparisons between nil and field struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(field value, NilType nil) => value.Equals(default(field));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(field value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, field value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, field value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator field(NilType nil) => default(field);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static field field_cast(dynamic value)
        {
            return new field(value.name, value.nameBytes, value.equalFold, value.tag, value.index, value.typ, value.omitEmpty, value.quoted);
        }
    }
}}