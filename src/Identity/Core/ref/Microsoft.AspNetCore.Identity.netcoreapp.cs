// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Identity
{
    public partial class AspNetRoleManager<TRole> : Microsoft.AspNetCore.Identity.RoleManager<TRole>, System.IDisposable where TRole : class
    {
        public AspNetRoleManager(Microsoft.AspNetCore.Identity.IRoleStore<TRole> store, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IRoleValidator<TRole>> roleValidators, Microsoft.AspNetCore.Identity.ILookupNormalizer keyNormalizer, Microsoft.AspNetCore.Identity.IdentityErrorDescriber errors, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.RoleManager<TRole>> logger, Microsoft.AspNetCore.Http.IHttpContextAccessor contextAccessor) : base (default(Microsoft.AspNetCore.Identity.IRoleStore<TRole>), default(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IRoleValidator<TRole>>), default(Microsoft.AspNetCore.Identity.ILookupNormalizer), default(Microsoft.AspNetCore.Identity.IdentityErrorDescriber), default(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.RoleManager<TRole>>)) { }
        protected override System.Threading.CancellationToken CancellationToken { get { throw null; } }
    }
    public partial class AspNetUserManager<TUser> : Microsoft.AspNetCore.Identity.UserManager<TUser>, System.IDisposable where TUser : class
    {
        public AspNetUserManager(Microsoft.AspNetCore.Identity.IUserStore<TUser> store, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.IdentityOptions> optionsAccessor, Microsoft.AspNetCore.Identity.IPasswordHasher<TUser> passwordHasher, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IUserValidator<TUser>> userValidators, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IPasswordValidator<TUser>> passwordValidators, Microsoft.AspNetCore.Identity.ILookupNormalizer keyNormalizer, Microsoft.AspNetCore.Identity.IdentityErrorDescriber errors, System.IServiceProvider services, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.UserManager<TUser>> logger) : base (default(Microsoft.AspNetCore.Identity.IUserStore<TUser>), default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.IdentityOptions>), default(Microsoft.AspNetCore.Identity.IPasswordHasher<TUser>), default(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IUserValidator<TUser>>), default(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IPasswordValidator<TUser>>), default(Microsoft.AspNetCore.Identity.ILookupNormalizer), default(Microsoft.AspNetCore.Identity.IdentityErrorDescriber), default(System.IServiceProvider), default(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.UserManager<TUser>>)) { }
        protected override System.Threading.CancellationToken CancellationToken { get { throw null; } }
    }
    public partial class DataProtectionTokenProviderOptions
    {
        public DataProtectionTokenProviderOptions() { }
        public string Name { get { throw null; } set { } }
        public System.TimeSpan TokenLifespan { get { throw null; } set { } }
    }
    public partial class DataProtectorTokenProvider<TUser> : Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider<TUser> where TUser : class
    {
        public DataProtectorTokenProvider(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.DataProtectionTokenProviderOptions> options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.DataProtectorTokenProvider<TUser>> logger) { }
        public Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.DataProtectorTokenProvider<TUser>> Logger { get { throw null; } }
        public string Name { get { throw null; } }
        protected Microsoft.AspNetCore.Identity.DataProtectionTokenProviderOptions Options { get { throw null; } }
        protected Microsoft.AspNetCore.DataProtection.IDataProtector Protector { get { throw null; } }
        public virtual System.Threading.Tasks.Task<bool> CanGenerateTwoFactorTokenAsync(Microsoft.AspNetCore.Identity.UserManager<TUser> manager, TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<string> GenerateAsync(string purpose, Microsoft.AspNetCore.Identity.UserManager<TUser> manager, TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> ValidateAsync(string purpose, string token, Microsoft.AspNetCore.Identity.UserManager<TUser> manager, TUser user) { throw null; }
    }
    public partial class ExternalLoginInfo : Microsoft.AspNetCore.Identity.UserLoginInfo
    {
        public ExternalLoginInfo(System.Security.Claims.ClaimsPrincipal principal, string loginProvider, string providerKey, string displayName) : base (default(string), default(string), default(string)) { }
        public Microsoft.AspNetCore.Authentication.AuthenticationProperties AuthenticationProperties { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authentication.AuthenticationToken> AuthenticationTokens { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal Principal { get { throw null; } set { } }
    }
    public static partial class IdentityBuilderExtensions
    {
        public static Microsoft.AspNetCore.Identity.IdentityBuilder AddDefaultTokenProviders(this Microsoft.AspNetCore.Identity.IdentityBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.Identity.IdentityBuilder AddSignInManager(this Microsoft.AspNetCore.Identity.IdentityBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.Identity.IdentityBuilder AddSignInManager<TSignInManager>(this Microsoft.AspNetCore.Identity.IdentityBuilder builder) where TSignInManager : class { throw null; }
    }
    public partial class IdentityConstants
    {
        public static readonly string ApplicationScheme;
        public static readonly string ExternalScheme;
        public static readonly string TwoFactorRememberMeScheme;
        public static readonly string TwoFactorUserIdScheme;
        public IdentityConstants() { }
    }
    public static partial class IdentityCookieAuthenticationBuilderExtensions
    {
        public static Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> AddApplicationCookie(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder) { throw null; }
        public static Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> AddExternalCookie(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.Identity.IdentityCookiesBuilder AddIdentityCookies(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.Identity.IdentityCookiesBuilder AddIdentityCookies(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder, System.Action<Microsoft.AspNetCore.Identity.IdentityCookiesBuilder> configureCookies) { throw null; }
        public static Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> AddTwoFactorRememberMeCookie(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder) { throw null; }
        public static Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> AddTwoFactorUserIdCookie(this Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder) { throw null; }
    }
    public partial class IdentityCookiesBuilder
    {
        public IdentityCookiesBuilder() { }
        public Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> ApplicationCookie { get { throw null; } set { } }
        public Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> ExternalCookie { get { throw null; } set { } }
        public Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> TwoFactorRememberMeCookie { get { throw null; } set { } }
        public Microsoft.Extensions.Options.OptionsBuilder<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> TwoFactorUserIdCookie { get { throw null; } set { } }
    }
    public partial interface ISecurityStampValidator
    {
        System.Threading.Tasks.Task ValidateAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context);
    }
    public partial interface ITwoFactorSecurityStampValidator : Microsoft.AspNetCore.Identity.ISecurityStampValidator
    {
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string InvalidManagerType { get { throw null; } }
        internal static string InvalidPasswordHasherCompatibilityMode { get { throw null; } }
        internal static string InvalidPasswordHasherIterationCount { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string FormatInvalidManagerType(object p0, object p1, object p2) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public partial class SecurityStampRefreshingPrincipalContext
    {
        public SecurityStampRefreshingPrincipalContext() { }
        public System.Security.Claims.ClaimsPrincipal CurrentPrincipal { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal NewPrincipal { get { throw null; } set { } }
    }
    public static partial class SecurityStampValidator
    {
        public static System.Threading.Tasks.Task ValidateAsync<TValidator>(Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context) where TValidator : Microsoft.AspNetCore.Identity.ISecurityStampValidator { throw null; }
        public static System.Threading.Tasks.Task ValidatePrincipalAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context) { throw null; }
    }
    public partial class SecurityStampValidatorOptions
    {
        public SecurityStampValidatorOptions() { }
        public System.Func<Microsoft.AspNetCore.Identity.SecurityStampRefreshingPrincipalContext, System.Threading.Tasks.Task> OnRefreshingPrincipal { get { throw null; } set { } }
        public System.TimeSpan ValidationInterval { get { throw null; } set { } }
    }
    public partial class SecurityStampValidator<TUser> : Microsoft.AspNetCore.Identity.ISecurityStampValidator where TUser : class
    {
        public SecurityStampValidator(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.SecurityStampValidatorOptions> options, Microsoft.AspNetCore.Identity.SignInManager<TUser> signInManager, Microsoft.AspNetCore.Authentication.ISystemClock clock, Microsoft.Extensions.Logging.ILoggerFactory logger) { }
        public Microsoft.AspNetCore.Authentication.ISystemClock Clock { get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } set { } }
        public Microsoft.AspNetCore.Identity.SecurityStampValidatorOptions Options { get { throw null; } }
        public Microsoft.AspNetCore.Identity.SignInManager<TUser> SignInManager { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task SecurityStampVerified(TUser user, Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ValidateAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context) { throw null; }
        protected virtual System.Threading.Tasks.Task<TUser> VerifySecurityStamp(System.Security.Claims.ClaimsPrincipal principal) { throw null; }
    }
    public partial class SignInManager<TUser> where TUser : class
    {
        public SignInManager(Microsoft.AspNetCore.Identity.UserManager<TUser> userManager, Microsoft.AspNetCore.Http.IHttpContextAccessor contextAccessor, Microsoft.AspNetCore.Identity.IUserClaimsPrincipalFactory<TUser> claimsFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.IdentityOptions> optionsAccessor, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Identity.SignInManager<TUser>> logger, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider schemes, Microsoft.AspNetCore.Identity.IUserConfirmation<TUser> confirmation) { }
        public Microsoft.AspNetCore.Identity.IUserClaimsPrincipalFactory<TUser> ClaimsFactory { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } set { } }
        public virtual Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } set { } }
        public Microsoft.AspNetCore.Identity.IdentityOptions Options { get { throw null; } set { } }
        public Microsoft.AspNetCore.Identity.UserManager<TUser> UserManager { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> CanSignInAsync(TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> CheckPasswordSignInAsync(TUser user, string password, bool lockoutOnFailure) { throw null; }
        public virtual Microsoft.AspNetCore.Authentication.AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl, string userId = null) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<System.Security.Claims.ClaimsPrincipal> CreateUserPrincipalAsync(TUser user) { throw null; }
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent, bool bypassTwoFactor) { throw null; }
        public virtual System.Threading.Tasks.Task ForgetTwoFactorClientAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authentication.AuthenticationScheme>> GetExternalAuthenticationSchemesAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.ExternalLoginInfo> GetExternalLoginInfoAsync(string expectedXsrf = null) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<TUser> GetTwoFactorAuthenticationUserAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task<bool> IsLockedOut(TUser user) { throw null; }
        public virtual bool IsSignedIn(System.Security.Claims.ClaimsPrincipal principal) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> IsTwoFactorClientRememberedAsync(TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> LockedOut(TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> PasswordSignInAsync(TUser user, string password, bool isPersistent, bool lockoutOnFailure) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> PreSignInCheck(TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task RefreshSignInAsync(TUser user) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task RememberTwoFactorClientAsync(TUser user) { throw null; }
        protected virtual System.Threading.Tasks.Task ResetLockout(TUser user) { throw null; }
        public virtual System.Threading.Tasks.Task SignInAsync(TUser user, Microsoft.AspNetCore.Authentication.AuthenticationProperties authenticationProperties, string authenticationMethod = null) { throw null; }
        public virtual System.Threading.Tasks.Task SignInAsync(TUser user, bool isPersistent, string authenticationMethod = null) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> SignInOrTwoFactorAsync(TUser user, bool isPersistent, string loginProvider = null, bool bypassTwoFactor = false) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task SignInWithClaimsAsync(TUser user, Microsoft.AspNetCore.Authentication.AuthenticationProperties authenticationProperties, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> additionalClaims) { throw null; }
        public virtual System.Threading.Tasks.Task SignInWithClaimsAsync(TUser user, bool isPersistent, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> additionalClaims) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task SignOutAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<System.Security.Claims.ClaimsPrincipal> StoreRememberClient(TUser user) { throw null; }
        internal System.Security.Claims.ClaimsPrincipal StoreTwoFactorInfo(string userId, string loginProvider) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> TwoFactorAuthenticatorSignInAsync(string code, bool isPersistent, bool rememberClient) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> TwoFactorRecoveryCodeSignInAsync(string recoveryCode) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.SignInResult> TwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberClient) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Identity.IdentityResult> UpdateExternalAuthenticationTokensAsync(Microsoft.AspNetCore.Identity.ExternalLoginInfo externalLogin) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<TUser> ValidateSecurityStampAsync(System.Security.Claims.ClaimsPrincipal principal) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> ValidateSecurityStampAsync(TUser user, string securityStamp) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<TUser> ValidateTwoFactorSecurityStampAsync(System.Security.Claims.ClaimsPrincipal principal) { throw null; }
        internal partial class TwoFactorAuthenticationInfo
        {
            public TwoFactorAuthenticationInfo() { }
            public string LoginProvider { get { throw null; } set { } }
            public string UserId { get { throw null; } set { } }
        }
    }
    internal static partial class StreamExtensions
    {
        internal static readonly System.Text.Encoding DefaultEncoding;
        public static System.IO.BinaryReader CreateReader(this System.IO.Stream stream) { throw null; }
        public static System.IO.BinaryWriter CreateWriter(this System.IO.Stream stream) { throw null; }
        public static System.DateTimeOffset ReadDateTimeOffset(this System.IO.BinaryReader reader) { throw null; }
        public static void Write(this System.IO.BinaryWriter writer, System.DateTimeOffset value) { }
    }
    public partial class TwoFactorSecurityStampValidator<TUser> : Microsoft.AspNetCore.Identity.SecurityStampValidator<TUser>, Microsoft.AspNetCore.Identity.ISecurityStampValidator, Microsoft.AspNetCore.Identity.ITwoFactorSecurityStampValidator where TUser : class
    {
        public TwoFactorSecurityStampValidator(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.SecurityStampValidatorOptions> options, Microsoft.AspNetCore.Identity.SignInManager<TUser> signInManager, Microsoft.AspNetCore.Authentication.ISystemClock clock, Microsoft.Extensions.Logging.ILoggerFactory logger) : base (default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.SecurityStampValidatorOptions>), default(Microsoft.AspNetCore.Identity.SignInManager<TUser>), default(Microsoft.AspNetCore.Authentication.ISystemClock), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        protected override System.Threading.Tasks.Task SecurityStampVerified(TUser user, Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext context) { throw null; }
        protected override System.Threading.Tasks.Task<TUser> VerifySecurityStamp(System.Security.Claims.ClaimsPrincipal principal) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class IdentityServiceCollectionExtensions
    {
        public static Microsoft.AspNetCore.Identity.IdentityBuilder AddIdentity<TUser, TRole>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TUser : class where TRole : class { throw null; }
        public static Microsoft.AspNetCore.Identity.IdentityBuilder AddIdentity<TUser, TRole>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Identity.IdentityOptions> setupAction) where TUser : class where TRole : class { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureApplicationCookie(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> configure) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureExternalCookie(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions> configure) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging
{
    internal static partial class LoggingExtensions
    {
        public static void InvalidExpirationTime(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void PurposeNotEquals(this Microsoft.Extensions.Logging.ILogger logger, string actualPurpose, string expectedPurpose) { }
        public static void SecurityStampIsNotEmpty(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void SequrityStampNotEquals(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UnexpectedEndOfInput(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UnhandledException(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UserIdsNotEquals(this Microsoft.Extensions.Logging.ILogger logger) { }
    }
}
