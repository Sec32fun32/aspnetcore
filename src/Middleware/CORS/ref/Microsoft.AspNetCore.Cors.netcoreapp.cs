// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class CorsEndpointConventionBuilderExtensions
    {
        public static TBuilder RequireCors<TBuilder>(this TBuilder builder, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder> configurePolicy) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
        public static TBuilder RequireCors<TBuilder>(this TBuilder builder, string policyName) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
    }
    public static partial class CorsMiddlewareExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseCors(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseCors(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder> configurePolicy) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseCors(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string policyName) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Cors
{
    internal static partial class CORSLoggerExtensions
    {
        public static void AccessControlMethodNotAllowed(this Microsoft.Extensions.Logging.ILogger logger, string accessControlMethod) { }
        public static void FailedToSetCorsHeaders(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void IsNotPreflightRequest(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void IsPreflightRequest(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoCorsPolicyFound(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void OriginNotAllowed(this Microsoft.Extensions.Logging.ILogger logger, string origin) { }
        public static void PolicyFailure(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void PolicySuccess(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void RequestDoesNotHaveOriginHeader(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void RequestHasOriginHeader(this Microsoft.Extensions.Logging.ILogger logger, string origin) { }
        public static void RequestHeaderNotAllowed(this Microsoft.Extensions.Logging.ILogger logger, string requestHeader) { }
    }
    public partial class CorsPolicyMetadata : Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata, Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyMetadata
    {
        public CorsPolicyMetadata(Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy) { }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy Policy { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=false)]
    public partial class DisableCorsAttribute : System.Attribute, Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata, Microsoft.AspNetCore.Cors.Infrastructure.IDisableCorsAttribute
    {
        public DisableCorsAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class EnableCorsAttribute : System.Attribute, Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata, Microsoft.AspNetCore.Cors.Infrastructure.IEnableCorsAttribute
    {
        public EnableCorsAttribute() { }
        public EnableCorsAttribute(string policyName) { }
        public string PolicyName { get { throw null; } set { } }
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string InsecureConfiguration { get { throw null; } }
        internal static string PreflightMaxAgeOutOfRange { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Cors.Infrastructure
{
    public static partial class CorsConstants
    {
        public static readonly string AccessControlAllowCredentials;
        public static readonly string AccessControlAllowHeaders;
        public static readonly string AccessControlAllowMethods;
        public static readonly string AccessControlAllowOrigin;
        public static readonly string AccessControlExposeHeaders;
        public static readonly string AccessControlMaxAge;
        public static readonly string AccessControlRequestHeaders;
        public static readonly string AccessControlRequestMethod;
        public static readonly string AnyOrigin;
        public static readonly string Origin;
        public static readonly string PreflightHttpMethod;
    }
    public partial class CorsMiddleware
    {
        public CorsMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Cors.Infrastructure.ICorsService corsService, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public CorsMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Cors.Infrastructure.ICorsService corsService, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public CorsMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Cors.Infrastructure.ICorsService corsService, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, string policyName) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider corsPolicyProvider) { throw null; }
    }
    public partial class CorsOptions
    {
        public CorsOptions() { }
        public string DefaultPolicyName { get { throw null; } set { } }
        internal System.Collections.Generic.IDictionary<string, (Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy, System.Threading.Tasks.Task<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy> policyTask)> PolicyMap { get { throw null; } }
        public void AddDefaultPolicy(Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy) { }
        public void AddDefaultPolicy(System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder> configurePolicy) { }
        public void AddPolicy(string name, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy) { }
        public void AddPolicy(string name, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder> configurePolicy) { }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy GetPolicy(string name) { throw null; }
    }
    public partial class CorsPolicy
    {
        public CorsPolicy() { }
        public bool AllowAnyHeader { get { throw null; } }
        public bool AllowAnyMethod { get { throw null; } }
        public bool AllowAnyOrigin { get { throw null; } }
        public System.Collections.Generic.IList<string> ExposedHeaders { get { throw null; } }
        public System.Collections.Generic.IList<string> Headers { get { throw null; } }
        public System.Func<string, bool> IsOriginAllowed { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Methods { get { throw null; } }
        public System.Collections.Generic.IList<string> Origins { get { throw null; } }
        public System.TimeSpan? PreflightMaxAge { get { throw null; } set { } }
        public bool SupportsCredentials { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class CorsPolicyBuilder
    {
        public CorsPolicyBuilder(Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy) { }
        public CorsPolicyBuilder(params string[] origins) { }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder AllowAnyHeader() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder AllowAnyMethod() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder AllowAnyOrigin() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder AllowCredentials() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy Build() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder DisallowCredentials() { throw null; }
        internal static string GetNormalizedOrigin(string origin) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder SetIsOriginAllowed(System.Func<string, bool> isOriginAllowed) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder SetIsOriginAllowedToAllowWildcardSubdomains() { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder SetPreflightMaxAge(System.TimeSpan preflightMaxAge) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder WithExposedHeaders(params string[] exposedHeaders) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder WithHeaders(params string[] headers) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder WithMethods(params string[] methods) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder WithOrigins(params string[] origins) { throw null; }
    }
    internal static partial class CorsPolicyExtensions
    {
        public static bool IsOriginAnAllowedSubdomain(this Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy, string origin) { throw null; }
    }
    public partial class CorsResult
    {
        public CorsResult() { }
        public System.Collections.Generic.IList<string> AllowedExposedHeaders { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedHeaders { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedMethods { get { throw null; } }
        public string AllowedOrigin { get { throw null; } set { } }
        public bool IsOriginAllowed { get { throw null; } set { } }
        public bool IsPreflightRequest { get { throw null; } set { } }
        public System.TimeSpan? PreflightMaxAge { get { throw null; } set { } }
        public bool SupportsCredentials { get { throw null; } set { } }
        public bool VaryByOrigin { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class CorsService : Microsoft.AspNetCore.Cors.Infrastructure.ICorsService
    {
        public CorsService(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public virtual void ApplyResult(Microsoft.AspNetCore.Cors.Infrastructure.CorsResult result, Microsoft.AspNetCore.Http.HttpResponse response) { }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsResult EvaluatePolicy(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy) { throw null; }
        public Microsoft.AspNetCore.Cors.Infrastructure.CorsResult EvaluatePolicy(Microsoft.AspNetCore.Http.HttpContext context, string policyName) { throw null; }
        public virtual void EvaluatePreflightRequest(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy, Microsoft.AspNetCore.Cors.Infrastructure.CorsResult result) { }
        public virtual void EvaluateRequest(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy, Microsoft.AspNetCore.Cors.Infrastructure.CorsResult result) { }
    }
    public partial class DefaultCorsPolicyProvider : Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider
    {
        public DefaultCorsPolicyProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions> options) { }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy> GetPolicyAsync(Microsoft.AspNetCore.Http.HttpContext context, string policyName) { throw null; }
    }
    public partial interface ICorsPolicyMetadata : Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata
    {
        Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy Policy { get; }
    }
    public partial interface ICorsPolicyProvider
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy> GetPolicyAsync(Microsoft.AspNetCore.Http.HttpContext context, string policyName);
    }
    public partial interface ICorsService
    {
        void ApplyResult(Microsoft.AspNetCore.Cors.Infrastructure.CorsResult result, Microsoft.AspNetCore.Http.HttpResponse response);
        Microsoft.AspNetCore.Cors.Infrastructure.CorsResult EvaluatePolicy(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy policy);
    }
    public partial interface IDisableCorsAttribute : Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata
    {
    }
    public partial interface IEnableCorsAttribute : Microsoft.AspNetCore.Cors.Infrastructure.ICorsMetadata
    {
        string PolicyName { get; set; }
    }
    internal static partial class UriHelpers
    {
        public static bool IsSubdomainOf(System.Uri subdomain, System.Uri domain) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class CorsServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddCors(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddCors(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions> setupAction) { throw null; }
    }
}
