// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Antiforgery
{
    internal partial class AntiforgeryFeature : Microsoft.AspNetCore.Antiforgery.IAntiforgeryFeature
    {
        public AntiforgeryFeature() { }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken CookieToken { get { throw null; } set { } }
        public bool HaveDeserializedCookieToken { get { throw null; } set { } }
        public bool HaveDeserializedRequestToken { get { throw null; } set { } }
        public bool HaveGeneratedNewCookieToken { get { throw null; } set { } }
        public bool HaveStoredNewCookieToken { get { throw null; } set { } }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken NewCookieToken { get { throw null; } set { } }
        public string NewCookieTokenString { get { throw null; } set { } }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken NewRequestToken { get { throw null; } set { } }
        public string NewRequestTokenString { get { throw null; } set { } }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken RequestToken { get { throw null; } set { } }
    }
    internal static partial class AntiforgeryLoggerExtensions
    {
        public static void FailedToDeserialzeTokens(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void MissingCookieToken(this Microsoft.Extensions.Logging.ILogger logger, string cookieName) { }
        public static void MissingRequestToken(this Microsoft.Extensions.Logging.ILogger logger, string formFieldName, string headerName) { }
        public static void NewCookieToken(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ResponseCacheHeadersOverridenToNoCache(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ReusedCookieToken(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void TokenDeserializeException(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ValidatedAntiforgeryToken(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ValidationFailed(this Microsoft.Extensions.Logging.ILogger logger, string message) { }
    }
    public partial class AntiforgeryOptions
    {
        public static readonly string DefaultCookiePrefix;
        public AntiforgeryOptions() { }
        public Microsoft.AspNetCore.Http.CookieBuilder Cookie { get { throw null; } set { } }
        public string FormFieldName { get { throw null; } set { } }
        public string HeaderName { get { throw null; } set { } }
        public bool SuppressXFrameOptionsHeader { get { throw null; } set { } }
    }
    internal partial class AntiforgeryOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>
    {
        public AntiforgeryOptionsSetup(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.DataProtectionOptions> dataProtectionOptions) { }
        public void Configure(Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions options) { }
    }
    internal partial class AntiforgerySerializationContext
    {
        public AntiforgerySerializationContext() { }
        public System.IO.BinaryReader Reader { get { throw null; } }
        public System.Security.Cryptography.SHA256 Sha256 { get { throw null; } }
        public System.IO.MemoryStream Stream { get { throw null; } }
        public System.IO.BinaryWriter Writer { get { throw null; } }
        public char[] GetChars(int count) { throw null; }
        public void Reset() { }
    }
    internal partial class AntiforgerySerializationContextPooledObjectPolicy : Microsoft.Extensions.ObjectPool.IPooledObjectPolicy<Microsoft.AspNetCore.Antiforgery.AntiforgerySerializationContext>
    {
        public AntiforgerySerializationContextPooledObjectPolicy() { }
        public Microsoft.AspNetCore.Antiforgery.AntiforgerySerializationContext Create() { throw null; }
        public bool Return(Microsoft.AspNetCore.Antiforgery.AntiforgerySerializationContext obj) { throw null; }
    }
    internal sealed partial class AntiforgeryToken
    {
        internal const int ClaimUidBitLength = 256;
        internal const int SecurityTokenBitLength = 128;
        public AntiforgeryToken() { }
        public string AdditionalData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Antiforgery.BinaryBlob ClaimUid { get { throw null; } set { } }
        public bool IsCookieToken { get { throw null; } set { } }
        public Microsoft.AspNetCore.Antiforgery.BinaryBlob SecurityToken { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public partial class AntiforgeryTokenSet
    {
        public AntiforgeryTokenSet(string requestToken, string cookieToken, string formFieldName, string headerName) { }
        public string CookieToken { get { throw null; } }
        public string FormFieldName { get { throw null; } }
        public string HeaderName { get { throw null; } }
        public string RequestToken { get { throw null; } }
    }
    public partial class AntiforgeryValidationException : System.Exception
    {
        public AntiforgeryValidationException(string message) { }
        public AntiforgeryValidationException(string message, System.Exception innerException) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerString}")]
    internal sealed partial class BinaryBlob : System.IEquatable<Microsoft.AspNetCore.Antiforgery.BinaryBlob>
    {
        public BinaryBlob(int bitLength) { }
        public BinaryBlob(int bitLength, byte[] data) { }
        public int BitLength { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Antiforgery.BinaryBlob other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public byte[] GetData() { throw null; }
        public override int GetHashCode() { throw null; }
    }
    internal static partial class CryptographyAlgorithms
    {
        public static System.Security.Cryptography.SHA256 CreateSHA256() { throw null; }
    }
    internal partial class DefaultAntiforgery : Microsoft.AspNetCore.Antiforgery.IAntiforgery
    {
        public DefaultAntiforgery(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions> antiforgeryOptionsAccessor, Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenGenerator tokenGenerator, Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenSerializer tokenSerializer, Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenStore tokenStore, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet GetAndStoreTokens(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet GetTokens(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> IsRequestValidAsync(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        public void SetCookieTokenAndHeader(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        protected virtual void SetDoNotCacheHeaders(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ValidateRequestAsync(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    internal partial class DefaultAntiforgeryAdditionalDataProvider : Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider
    {
        public DefaultAntiforgeryAdditionalDataProvider() { }
        public string GetAdditionalData(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public bool ValidateAdditionalData(Microsoft.AspNetCore.Http.HttpContext context, string additionalData) { throw null; }
    }
    internal partial class DefaultAntiforgeryTokenGenerator : Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenGenerator
    {
        public DefaultAntiforgeryTokenGenerator(Microsoft.AspNetCore.Antiforgery.IClaimUidExtractor claimUidExtractor, Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider additionalDataProvider) { }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken GenerateCookieToken() { throw null; }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken GenerateRequestToken(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken) { throw null; }
        public bool IsCookieTokenValid(Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken) { throw null; }
        public bool TryValidateTokenSet(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken requestToken, out string message) { throw null; }
    }
    internal partial class DefaultAntiforgeryTokenSerializer : Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenSerializer
    {
        public DefaultAntiforgeryTokenSerializer(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider provider, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.AntiforgerySerializationContext> pool) { }
        public Microsoft.AspNetCore.Antiforgery.AntiforgeryToken Deserialize(string serializedToken) { throw null; }
        public string Serialize(Microsoft.AspNetCore.Antiforgery.AntiforgeryToken token) { throw null; }
    }
    internal partial class DefaultAntiforgeryTokenStore : Microsoft.AspNetCore.Antiforgery.IAntiforgeryTokenStore
    {
        public DefaultAntiforgeryTokenStore(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions> optionsAccessor) { }
        public string GetCookieToken(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet> GetRequestTokensAsync(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        public void SaveCookieToken(Microsoft.AspNetCore.Http.HttpContext httpContext, string token) { }
    }
    internal partial class DefaultClaimUidExtractor : Microsoft.AspNetCore.Antiforgery.IClaimUidExtractor
    {
        public DefaultClaimUidExtractor(Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.AntiforgerySerializationContext> pool) { }
        public string ExtractClaimUid(System.Security.Claims.ClaimsPrincipal claimsPrincipal) { throw null; }
        public static System.Collections.Generic.IList<string> GetUniqueIdentifierParameters(System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity> claimsIdentities) { throw null; }
    }
    public partial interface IAntiforgery
    {
        Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet GetAndStoreTokens(Microsoft.AspNetCore.Http.HttpContext httpContext);
        Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet GetTokens(Microsoft.AspNetCore.Http.HttpContext httpContext);
        System.Threading.Tasks.Task<bool> IsRequestValidAsync(Microsoft.AspNetCore.Http.HttpContext httpContext);
        void SetCookieTokenAndHeader(Microsoft.AspNetCore.Http.HttpContext httpContext);
        System.Threading.Tasks.Task ValidateRequestAsync(Microsoft.AspNetCore.Http.HttpContext httpContext);
    }
    public partial interface IAntiforgeryAdditionalDataProvider
    {
        string GetAdditionalData(Microsoft.AspNetCore.Http.HttpContext context);
        bool ValidateAdditionalData(Microsoft.AspNetCore.Http.HttpContext context, string additionalData);
    }
    internal partial interface IAntiforgeryFeature
    {
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken CookieToken { get; set; }
        bool HaveDeserializedCookieToken { get; set; }
        bool HaveDeserializedRequestToken { get; set; }
        bool HaveGeneratedNewCookieToken { get; set; }
        bool HaveStoredNewCookieToken { get; set; }
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken NewCookieToken { get; set; }
        string NewCookieTokenString { get; set; }
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken NewRequestToken { get; set; }
        string NewRequestTokenString { get; set; }
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken RequestToken { get; set; }
    }
    internal partial interface IAntiforgeryTokenGenerator
    {
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken GenerateCookieToken();
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken GenerateRequestToken(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken);
        bool IsCookieTokenValid(Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken);
        bool TryValidateTokenSet(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken cookieToken, Microsoft.AspNetCore.Antiforgery.AntiforgeryToken requestToken, out string message);
    }
    internal partial interface IAntiforgeryTokenSerializer
    {
        Microsoft.AspNetCore.Antiforgery.AntiforgeryToken Deserialize(string serializedToken);
        string Serialize(Microsoft.AspNetCore.Antiforgery.AntiforgeryToken token);
    }
    internal partial interface IAntiforgeryTokenStore
    {
        string GetCookieToken(Microsoft.AspNetCore.Http.HttpContext httpContext);
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet> GetRequestTokensAsync(Microsoft.AspNetCore.Http.HttpContext httpContext);
        void SaveCookieToken(Microsoft.AspNetCore.Http.HttpContext httpContext, string token);
    }
    internal partial interface IClaimUidExtractor
    {
        string ExtractClaimUid(System.Security.Claims.ClaimsPrincipal claimsPrincipal);
    }
    internal static partial class Resources
    {
        internal static string AntiforgeryTokenValidator_AuthenticatedUserWithoutUsername { get { throw null; } }
        internal static string AntiforgeryToken_AdditionalDataCheckFailed { get { throw null; } }
        internal static string AntiforgeryToken_ClaimUidMismatch { get { throw null; } }
        internal static string AntiforgeryToken_DeserializationFailed { get { throw null; } }
        internal static string AntiforgeryToken_SecurityTokenMismatch { get { throw null; } }
        internal static string AntiforgeryToken_TokensSwapped { get { throw null; } }
        internal static string AntiforgeryToken_UsernameMismatch { get { throw null; } }
        internal static string Antiforgery_CookieToken_IsInvalid { get { throw null; } }
        internal static string Antiforgery_CookieToken_MustBeProvided { get { throw null; } }
        internal static string Antiforgery_CookieToken_MustBeProvided_Generic { get { throw null; } }
        internal static string Antiforgery_FormToken_MustBeProvided { get { throw null; } }
        internal static string Antiforgery_HeaderToken_MustBeProvided { get { throw null; } }
        internal static string Antiforgery_RequestToken_MustBeProvided { get { throw null; } }
        internal static string Antiforgery_RequestToken_MustBeProvided_Generic { get { throw null; } }
        internal static string Antiforgery_RequiresSSL { get { throw null; } }
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string FormatAntiforgeryTokenValidator_AuthenticatedUserWithoutUsername(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        internal static string FormatAntiforgeryToken_UsernameMismatch(object p0, object p1) { throw null; }
        internal static string FormatAntiforgery_CookieToken_MustBeProvided(object p0) { throw null; }
        internal static string FormatAntiforgery_FormToken_MustBeProvided(object p0) { throw null; }
        internal static string FormatAntiforgery_HeaderToken_MustBeProvided(object p0) { throw null; }
        internal static string FormatAntiforgery_RequestToken_MustBeProvided(object p0, object p1) { throw null; }
        internal static string FormatAntiforgery_RequiresSSL(object optionName, object value) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class AntiforgeryServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddAntiforgery(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddAntiforgery(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions> setupAction) { throw null; }
    }
}
