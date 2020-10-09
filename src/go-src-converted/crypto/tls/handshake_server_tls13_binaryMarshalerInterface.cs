//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using crypto = go.crypto_package;
using hmac = go.crypto.hmac_package;
using rsa = go.crypto.rsa_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface binaryMarshaler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static binaryMarshaler As<T>(in T target) => (binaryMarshaler<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static binaryMarshaler As<T>(ptr<T> target_ptr) => (binaryMarshaler<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static binaryMarshaler? As(object target) =>
                typeof(binaryMarshaler<>).CreateInterfaceHandler<binaryMarshaler>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class binaryMarshaler<T> : binaryMarshaler
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public binaryMarshaler(in T target) => m_target = target;

            public binaryMarshaler(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error MarshalBinaryByPtr(ptr<T> value);
            private delegate error MarshalBinaryByVal(T value);

            private static readonly MarshalBinaryByPtr? s_MarshalBinaryByPtr;
            private static readonly MarshalBinaryByVal? s_MarshalBinaryByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error MarshalBinary()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_MarshalBinaryByPtr is null || !m_target_is_ptr)
                    return s_MarshalBinaryByVal!(target);

                return s_MarshalBinaryByPtr(m_target_ptr);
            }

            private delegate error UnmarshalBinaryByPtr(ptr<T> value, slice<byte> data);
            private delegate error UnmarshalBinaryByVal(T value, slice<byte> data);

            private static readonly UnmarshalBinaryByPtr? s_UnmarshalBinaryByPtr;
            private static readonly UnmarshalBinaryByVal? s_UnmarshalBinaryByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnmarshalBinary(slice<byte> data)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_UnmarshalBinaryByPtr is null || !m_target_is_ptr)
                    return s_UnmarshalBinaryByVal!(target, data);

                return s_UnmarshalBinaryByPtr(m_target_ptr, data);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static binaryMarshaler()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("MarshalBinary");

                if (!(extensionMethod is null))
                    s_MarshalBinaryByPtr = extensionMethod.CreateStaticDelegate(typeof(MarshalBinaryByPtr)) as MarshalBinaryByPtr;

                extensionMethod = targetType.GetExtensionMethod("MarshalBinary");

                if (!(extensionMethod is null))
                    s_MarshalBinaryByVal = extensionMethod.CreateStaticDelegate(typeof(MarshalBinaryByVal)) as MarshalBinaryByVal;

                if (s_MarshalBinaryByPtr is null && s_MarshalBinaryByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement binaryMarshaler.MarshalBinary method", new Exception("MarshalBinary"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("UnmarshalBinary");

                if (!(extensionMethod is null))
                    s_UnmarshalBinaryByPtr = extensionMethod.CreateStaticDelegate(typeof(UnmarshalBinaryByPtr)) as UnmarshalBinaryByPtr;

                extensionMethod = targetType.GetExtensionMethod("UnmarshalBinary");

                if (!(extensionMethod is null))
                    s_UnmarshalBinaryByVal = extensionMethod.CreateStaticDelegate(typeof(UnmarshalBinaryByVal)) as UnmarshalBinaryByVal;

                if (s_UnmarshalBinaryByPtr is null && s_UnmarshalBinaryByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement binaryMarshaler.UnmarshalBinary method", new Exception("UnmarshalBinary"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator binaryMarshaler<T>(in ptr<T> target_ptr) => new binaryMarshaler<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator binaryMarshaler<T>(in T target) => new binaryMarshaler<T>(target);

            // Enable comparisons between nil and binaryMarshaler<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(binaryMarshaler<T> value, NilType nil) => Activator.CreateInstance<binaryMarshaler<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(binaryMarshaler<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, binaryMarshaler<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, binaryMarshaler<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tls_binaryMarshalerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.crypto.tls_package.binaryMarshaler target)
        {
            try
            {
                return ((go.crypto.tls_package.binaryMarshaler<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.crypto.tls_package.binaryMarshaler target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.crypto.tls_package.binaryMarshaler target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.crypto.tls_package.binaryMarshaler<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.crypto.tls_package.binaryMarshaler target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}