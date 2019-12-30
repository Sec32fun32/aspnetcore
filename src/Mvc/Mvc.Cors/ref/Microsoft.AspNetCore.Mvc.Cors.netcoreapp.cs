// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.Cors
{
    internal partial class CorsApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public CorsApplicationModelProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    public partial class CorsAuthorizationFilter : Microsoft.AspNetCore.Mvc.Cors.ICorsAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public CorsAuthorizationFilter(Microsoft.AspNetCore.Cors.Infrastructure.ICorsService corsService, Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider policyProvider) { }
        public CorsAuthorizationFilter(Microsoft.AspNetCore.Cors.Infrastructure.ICorsService corsService, Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider policyProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public int Order { get { throw null; } }
        public string PolicyName { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
    }
    internal partial class CorsAuthorizationFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public CorsAuthorizationFilterFactory(string policyName) { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    internal partial class CorsHttpMethodActionConstraint : Microsoft.AspNetCore.Mvc.ActionConstraints.HttpMethodActionConstraint
    {
        public CorsHttpMethodActionConstraint(Microsoft.AspNetCore.Mvc.ActionConstraints.HttpMethodActionConstraint constraint) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public override bool Accept(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintContext context) { throw null; }
    }
    internal static partial class CorsLoggerExtensions
    {
        public static void NotMostEffectiveFilter(this Microsoft.Extensions.Logging.ILogger logger, System.Type policyType) { }
    }
    internal partial class DisableCorsAuthorizationFilter : Microsoft.AspNetCore.Mvc.Cors.ICorsAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public DisableCorsAuthorizationFilter() { }
        public int Order { get { throw null; } }
        public System.Threading.Tasks.Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
    }
    internal partial interface ICorsAuthorizationFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
    }
    internal static partial class Resources
    {
        internal static string CorsAuthorizationFilter_MissingCorsPolicy { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string FormatCorsAuthorizationFilter_MissingCorsPolicy(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MvcCorsMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCors(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCors(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions> setupAction) { throw null; }
        internal static void AddCorsServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder ConfigureCors(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions> setupAction) { throw null; }
    }
}
