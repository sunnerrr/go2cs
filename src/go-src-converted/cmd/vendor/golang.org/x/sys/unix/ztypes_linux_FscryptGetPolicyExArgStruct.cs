//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FscryptGetPolicyExArg
        {
            // Constructors
            public FscryptGetPolicyExArg(NilType _)
            {
                this.Size = default;
                this.Policy = default;
            }

            public FscryptGetPolicyExArg(ulong Size = default, array<byte> Policy = default)
            {
                this.Size = Size;
                this.Policy = Policy;
            }

            // Enable comparisons between nil and FscryptGetPolicyExArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FscryptGetPolicyExArg value, NilType nil) => value.Equals(default(FscryptGetPolicyExArg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FscryptGetPolicyExArg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FscryptGetPolicyExArg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FscryptGetPolicyExArg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FscryptGetPolicyExArg(NilType nil) => default(FscryptGetPolicyExArg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FscryptGetPolicyExArg FscryptGetPolicyExArg_cast(dynamic value)
        {
            return new FscryptGetPolicyExArg(value.Size, value.Policy);
        }
    }
}}}}}}