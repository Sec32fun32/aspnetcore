// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.DataProtection
{
    internal static partial class CryptoUtil
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Exception Fail(string message) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static T Fail<T>(string message) where T : class { throw null; }
    }
    public static partial class DataProtectionCommonExtensions
    {
        public static Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(this Microsoft.AspNetCore.DataProtection.IDataProtectionProvider provider, System.Collections.Generic.IEnumerable<string> purposes) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(this Microsoft.AspNetCore.DataProtection.IDataProtectionProvider provider, string purpose, params string[] subPurposes) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider GetDataProtectionProvider(this System.IServiceProvider services) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtector GetDataProtector(this System.IServiceProvider services, System.Collections.Generic.IEnumerable<string> purposes) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtector GetDataProtector(this System.IServiceProvider services, string purpose, params string[] subPurposes) { throw null; }
        public static string Protect(this Microsoft.AspNetCore.DataProtection.IDataProtector protector, string plaintext) { throw null; }
        public static string Unprotect(this Microsoft.AspNetCore.DataProtection.IDataProtector protector, string protectedData) { throw null; }
    }
    internal static partial class EncodingUtil
    {
        public static readonly System.Text.UTF8Encoding SecureUtf8Encoding;
    }
    internal static partial class Error
    {
        public static System.Security.Cryptography.CryptographicException CryptCommon_GenericError(System.Exception inner = null) { throw null; }
        public static System.Security.Cryptography.CryptographicException CryptCommon_PayloadInvalid() { throw null; }
    }
    internal static partial class ExceptionExtensions
    {
        public static bool RequiresHomogenization(this System.Exception ex) { throw null; }
    }
    public partial interface IDataProtectionProvider
    {
        Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(string purpose);
    }
    public partial interface IDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider
    {
        byte[] Protect(byte[] plaintext);
        byte[] Unprotect(byte[] protectedData);
    }
}
namespace Microsoft.AspNetCore.DataProtection.Abstractions
{
    internal static partial class Resources
    {
        internal static string CryptCommon_GenericError { get { throw null; } }
        internal static string CryptCommon_PayloadInvalid { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string DataProtectionExtensions_NoService { get { throw null; } }
        internal static string DataProtectionExtensions_NullPurposesCollection { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string FormatDataProtectionExtensions_NoService(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.DataProtection.Infrastructure
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial interface IApplicationDiscriminator
    {
        string Discriminator { get; }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal static partial class WebEncoders
    {
        public static byte[] Base64UrlDecode(string input) { throw null; }
        public static byte[] Base64UrlDecode(string input, int offset, char[] buffer, int bufferOffset, int count) { throw null; }
        public static byte[] Base64UrlDecode(string input, int offset, int count) { throw null; }
        public static string Base64UrlEncode(byte[] input) { throw null; }
        public static int Base64UrlEncode(byte[] input, int offset, char[] output, int outputOffset, int count) { throw null; }
        public static string Base64UrlEncode(byte[] input, int offset, int count) { throw null; }
        public static string Base64UrlEncode(System.ReadOnlySpan<byte> input) { throw null; }
        public static int GetArraySizeRequiredToDecode(int count) { throw null; }
        public static int GetArraySizeRequiredToEncode(int count) { throw null; }
    }
}
namespace Microsoft.Extensions.WebEncoders.Sources
{
    internal static partial class EncoderResources
    {
        internal static readonly string WebEncoders_InvalidCountOffsetOrLength;
        internal static readonly string WebEncoders_MalformedInput;
        internal static string FormatWebEncoders_InvalidCountOffsetOrLength(object p0, object p1, object p2) { throw null; }
        internal static string FormatWebEncoders_MalformedInput(object p0) { throw null; }
    }
}
