// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.DataProtection
{
    internal static partial class BitHelpers
    {
        public static ulong ReadUInt64(byte[] buffer, int offset) { throw null; }
        public static void WriteUInt64(byte[] buffer, int offset, ulong value) { }
    }
    public static partial class DataProtectionAdvancedExtensions
    {
        public static byte[] Protect(this Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector protector, byte[] plaintext, System.TimeSpan lifetime) { throw null; }
        public static string Protect(this Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector protector, string plaintext, System.DateTimeOffset expiration) { throw null; }
        public static string Protect(this Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector protector, string plaintext, System.TimeSpan lifetime) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector ToTimeLimitedDataProtector(this Microsoft.AspNetCore.DataProtection.IDataProtector protector) { throw null; }
        public static string Unprotect(this Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector protector, string protectedData, out System.DateTimeOffset expiration) { throw null; }
    }
    public static partial class DataProtectionProvider
    {
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(System.IO.DirectoryInfo keyDirectory) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(System.IO.DirectoryInfo keyDirectory, System.Action<Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder> setupAction) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(System.IO.DirectoryInfo keyDirectory, System.Action<Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder> setupAction, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(System.IO.DirectoryInfo keyDirectory, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(string applicationName) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider Create(string applicationName, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        internal static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider CreateProvider(System.IO.DirectoryInfo keyDirectory, System.Action<Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder> setupAction, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
    }
    internal static partial class EncodingUtil
    {
        public static readonly System.Text.UTF8Encoding SecureUtf8Encoding;
    }
    internal static partial class ExceptionExtensions
    {
        public static bool RequiresHomogenization(this System.Exception ex) { throw null; }
    }
    public partial interface ITimeLimitedDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider, Microsoft.AspNetCore.DataProtection.IDataProtector
    {
        new Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector CreateProtector(string purpose);
        byte[] Protect(byte[] plaintext, System.DateTimeOffset expiration);
        byte[] Unprotect(byte[] protectedData, out System.DateTimeOffset expiration);
    }
    internal sealed partial class TimeLimitedDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider, Microsoft.AspNetCore.DataProtection.IDataProtector, Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector
    {
        public TimeLimitedDataProtector(Microsoft.AspNetCore.DataProtection.IDataProtector innerProtector) { }
        public Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector CreateProtector(string purpose) { throw null; }
        Microsoft.AspNetCore.DataProtection.IDataProtector Microsoft.AspNetCore.DataProtection.IDataProtectionProvider.CreateProtector(string purpose) { throw null; }
        byte[] Microsoft.AspNetCore.DataProtection.IDataProtector.Protect(byte[] plaintext) { throw null; }
        byte[] Microsoft.AspNetCore.DataProtection.IDataProtector.Unprotect(byte[] protectedData) { throw null; }
        public byte[] Protect(byte[] plaintext, System.DateTimeOffset expiration) { throw null; }
        public byte[] Unprotect(byte[] protectedData, out System.DateTimeOffset expiration) { throw null; }
        internal byte[] UnprotectCore(byte[] protectedData, System.DateTimeOffset now, out System.DateTimeOffset expiration) { throw null; }
    }
}
namespace Microsoft.AspNetCore.DataProtection.Extensions
{
    internal static partial class Resources
    {
        internal static string CryptCommon_GenericError { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string TimeLimitedDataProtector_PayloadExpired { get { throw null; } }
        internal static string TimeLimitedDataProtector_PayloadInvalid { get { throw null; } }
        internal static string FormatTimeLimitedDataProtector_PayloadExpired(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
