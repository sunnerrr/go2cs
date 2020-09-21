//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using os = go.os_package;
using strconv = go.strconv_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
                this.arch = default;
                this.PtrSize = default;
                this.RegSize = default;
                this.Types = default;
                this.lowerBlock = default;
                this.lowerValue = default;
                this.registers = default;
                this.gpRegMask = default;
                this.fpRegMask = default;
                this.specialRegMask = default;
                this.FPReg = default;
                this.LinkReg = default;
                this.hasGReg = default;
                this.ctxt = default;
                this.optimize = default;
                this.noDuffDevice = default;
                this.useSSE = default;
                this.nacl = default;
                this.use387 = default;
                this.SoftFloat = default;
                this.NeedsFpScratch = default;
                this.BigEndian = default;
                this.sparsePhiCutoff = default;
            }

            public Config(@string arch = default, long PtrSize = default, long RegSize = default, Types Types = default, blockRewriter lowerBlock = default, valueRewriter lowerValue = default, slice<Register> registers = default, regMask gpRegMask = default, regMask fpRegMask = default, regMask specialRegMask = default, sbyte FPReg = default, sbyte LinkReg = default, bool hasGReg = default, ref ptr<obj.Link> ctxt = default, bool optimize = default, bool noDuffDevice = default, bool useSSE = default, bool nacl = default, bool use387 = default, bool SoftFloat = default, bool NeedsFpScratch = default, bool BigEndian = default, ulong sparsePhiCutoff = default)
            {
                this.arch = arch;
                this.PtrSize = PtrSize;
                this.RegSize = RegSize;
                this.Types = Types;
                this.lowerBlock = lowerBlock;
                this.lowerValue = lowerValue;
                this.registers = registers;
                this.gpRegMask = gpRegMask;
                this.fpRegMask = fpRegMask;
                this.specialRegMask = specialRegMask;
                this.FPReg = FPReg;
                this.LinkReg = LinkReg;
                this.hasGReg = hasGReg;
                this.ctxt = ctxt;
                this.optimize = optimize;
                this.noDuffDevice = noDuffDevice;
                this.useSSE = useSSE;
                this.nacl = nacl;
                this.use387 = use387;
                this.SoftFloat = SoftFloat;
                this.NeedsFpScratch = NeedsFpScratch;
                this.BigEndian = BigEndian;
                this.sparsePhiCutoff = sparsePhiCutoff;
            }

            // Enable comparisons between nil and Config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Config value, NilType nil) => value.Equals(default(Config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Config(NilType nil) => default(Config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Config Config_cast(dynamic value)
        {
            return new Config(value.arch, value.PtrSize, value.RegSize, value.Types, value.lowerBlock, value.lowerValue, value.registers, value.gpRegMask, value.fpRegMask, value.specialRegMask, value.FPReg, value.LinkReg, value.hasGReg, ref value.ctxt, value.optimize, value.noDuffDevice, value.useSSE, value.nacl, value.use387, value.SoftFloat, value.NeedsFpScratch, value.BigEndian, value.sparsePhiCutoff);
        }
    }
}}}}