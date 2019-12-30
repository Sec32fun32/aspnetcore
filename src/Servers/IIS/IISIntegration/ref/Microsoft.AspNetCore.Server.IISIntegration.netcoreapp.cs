// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public partial class IISOptions
    {
        public IISOptions() { }
        public string AuthenticationDisplayName { get { throw null; } set { } }
        public bool AutomaticAuthentication { get { throw null; } set { } }
        public bool ForwardClientCertificate { get { throw null; } set { } }
        internal bool ForwardWindowsAuthentication { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Hosting
{
    public static partial class WebHostBuilderIISExtensions
    {
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseIISIntegration(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Server.IISIntegration
{
    internal partial class AuthenticationHandler : Microsoft.AspNetCore.Authentication.IAuthenticationHandler
    {
        public AuthenticationHandler() { }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Authentication.AuthenticateResult> AuthenticateAsync() { throw null; }
        public System.Threading.Tasks.Task ChallengeAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task ForbidAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task InitializeAsync(Microsoft.AspNetCore.Authentication.AuthenticationScheme scheme, Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    internal partial class ForwardedTlsConnectionFeature : Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature
    {
        public ForwardedTlsConnectionFeature(Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Primitives.StringValues header) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate { get { throw null; } set { } }
        public System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class IISDefaults
    {
        public const string AuthenticationScheme = "Windows";
        public const string Negotiate = "Negotiate";
        public const string Ntlm = "NTLM";
        public IISDefaults() { }
    }
    public partial class IISHostingStartup : Microsoft.AspNetCore.Hosting.IHostingStartup
    {
        public IISHostingStartup() { }
        public void Configure(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder) { }
    }
    public partial class IISMiddleware
    {
        public IISMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.IISOptions> options, string pairingToken, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider authentication, Microsoft.Extensions.Hosting.IHostApplicationLifetime applicationLifetime) { }
        public IISMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.IISOptions> options, string pairingToken, bool isWebsocketsSupported, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider authentication, Microsoft.Extensions.Hosting.IHostApplicationLifetime applicationLifetime) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    internal partial class IISSetupFilter : Microsoft.AspNetCore.Hosting.IStartupFilter
    {
        internal IISSetupFilter(string pairingToken, Microsoft.AspNetCore.Http.PathString pathBase, bool isWebsocketsSupported) { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> Configure(System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> next) { throw null; }
    }
    internal static partial class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern bool CloseHandle(System.IntPtr handle);
    }
}
