// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class CookiePolicyAppBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseCookiePolicy(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseCookiePolicy(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.CookiePolicyOptions options) { throw null; }
    }
    public partial class CookiePolicyOptions
    {
        public CookiePolicyOptions() { }
        public System.Func<Microsoft.AspNetCore.Http.HttpContext, bool> CheckConsentNeeded { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.CookieBuilder ConsentCookie { get { throw null; } set { } }
        public Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy HttpOnly { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.SameSiteMode MinimumSameSitePolicy { get { throw null; } set { } }
        public System.Action<Microsoft.AspNetCore.CookiePolicy.AppendCookieContext> OnAppendCookie { get { throw null; } set { } }
        public System.Action<Microsoft.AspNetCore.CookiePolicy.DeleteCookieContext> OnDeleteCookie { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.CookieSecurePolicy Secure { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.CookiePolicy
{
    public partial class AppendCookieContext
    {
        public AppendCookieContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.CookieOptions options, string name, string value) { }
        public Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        public string CookieName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.CookieOptions CookieOptions { get { throw null; } }
        public string CookieValue { get { throw null; } set { } }
        public bool HasConsent { get { throw null; } }
        public bool IsConsentNeeded { get { throw null; } }
        public bool IssueCookie { get { throw null; } set { } }
    }
    public partial class CookiePolicyMiddleware
    {
        public CookiePolicyMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.CookiePolicyOptions> options) { }
        public CookiePolicyMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.CookiePolicyOptions> options, Microsoft.Extensions.Logging.ILoggerFactory factory) { }
        public Microsoft.AspNetCore.Builder.CookiePolicyOptions Options { get { throw null; } set { } }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class DeleteCookieContext
    {
        public DeleteCookieContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.CookieOptions options, string name) { }
        public Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        public string CookieName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.CookieOptions CookieOptions { get { throw null; } }
        public bool HasConsent { get { throw null; } }
        public bool IsConsentNeeded { get { throw null; } }
        public bool IssueCookie { get { throw null; } set { } }
    }
    public enum HttpOnlyPolicy
    {
        None = 0,
        Always = 1,
    }
}
