//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
using modfile = go.golang.org.x.mod.modfile_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class expect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tokens
        {
            // Constructors
            public tokens(NilType _)
            {
                this.scanner = default;
                this.current = default;
                this.err = default;
                this.@base = default;
            }

            public tokens(scanner.Scanner scanner = default, int current = default, error err = default, token.Pos @base = default)
            {
                this.scanner = scanner;
                this.current = current;
                this.err = err;
                this.@base = @base;
            }

            // Enable comparisons between nil and tokens struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tokens value, NilType nil) => value.Equals(default(tokens));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tokens value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tokens value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tokens value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tokens(NilType nil) => default(tokens);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tokens tokens_cast(dynamic value)
        {
            return new tokens(value.scanner, value.current, value.err, value.@base);
        }
    }
}}}}}