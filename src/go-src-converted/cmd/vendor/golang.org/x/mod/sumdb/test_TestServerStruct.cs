//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using fmt = go.fmt_package;
using sync = go.sync_package;
using module = go.golang.org.x.mod.module_package;
using note = go.golang.org.x.mod.sumdb.note_package;
using tlog = go.golang.org.x.mod.sumdb.tlog_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TestServer
        {
            // Constructors
            public TestServer(NilType _)
            {
                this.signer = default;
                this.gosum = default;
                this.mu = default;
                this.hashes = default;
                this.records = default;
                this.lookup = default;
            }

            public TestServer(@string signer = default, Func<@string, @string, (slice<byte>, error)> gosum = default, sync.Mutex mu = default, testHashes hashes = default, slice<slice<byte>> records = default, map<@string, long> lookup = default)
            {
                this.signer = signer;
                this.gosum = gosum;
                this.mu = mu;
                this.hashes = hashes;
                this.records = records;
                this.lookup = lookup;
            }

            // Enable comparisons between nil and TestServer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TestServer value, NilType nil) => value.Equals(default(TestServer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TestServer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TestServer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TestServer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TestServer(NilType nil) => default(TestServer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TestServer TestServer_cast(dynamic value)
        {
            return new TestServer(value.signer, value.gosum, value.mu, value.hashes, value.records, value.lookup);
        }
    }
}}}}}}