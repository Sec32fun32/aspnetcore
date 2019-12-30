// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class EndpointRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder Map(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder Map(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapDelete(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapGet(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapMethods(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, System.Collections.Generic.IEnumerable<string> httpMethods, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapPost(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapPut(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
    }
    public static partial class EndpointRoutingApplicationBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseEndpoints(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder, System.Action<Microsoft.AspNetCore.Routing.IEndpointRouteBuilder> configure) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseRouting(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder) { throw null; }
    }
    public static partial class FallbackEndpointRouteBuilderExtensions
    {
        public static readonly string DefaultPattern;
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallback(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallback(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { throw null; }
    }
    public static partial class MapRouteRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string template) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string template, object defaults) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string template, object defaults, object constraints) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string template, object defaults, object constraints, object dataTokens) { throw null; }
    }
    public partial class RouterMiddleware
    {
        public RouterMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Routing.IRouter router) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    public static partial class RoutingBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseRouter(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder, Microsoft.AspNetCore.Routing.IRouter router) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseRouter(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder, System.Action<Microsoft.AspNetCore.Routing.IRouteBuilder> action) { throw null; }
    }
    public static partial class RoutingEndpointConventionBuilderExtensions
    {
        public static TBuilder RequireHost<TBuilder>(this TBuilder builder, params string[] hosts) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
        public static TBuilder WithDisplayName<TBuilder>(this TBuilder builder, System.Func<Microsoft.AspNetCore.Builder.EndpointBuilder, string> func) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
        public static TBuilder WithDisplayName<TBuilder>(this TBuilder builder, string displayName) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
        public static TBuilder WithMetadata<TBuilder>(this TBuilder builder, params object[] items) where TBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder { throw null; }
    }
}
namespace Microsoft.AspNetCore.Routing
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ArrayBuilder<T>
    {
        private T[] _array;
        private object _dummy;
        private int _dummyPrimitive;
        public ArrayBuilder(int capacity) { throw null; }
        public T[] Buffer { get { throw null; } }
        public int Capacity { get { throw null; } }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public void Add(T item) { }
        public T First() { throw null; }
        public T Last() { throw null; }
        public T[] ToArray() { throw null; }
        public void UncheckedAdd(T item) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString,nq}")]
    public sealed partial class CompositeEndpointDataSource : Microsoft.AspNetCore.Routing.EndpointDataSource
    {
        public CompositeEndpointDataSource(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.EndpointDataSource> endpointDataSources) { }
        internal CompositeEndpointDataSource(System.Collections.ObjectModel.ObservableCollection<Microsoft.AspNetCore.Routing.EndpointDataSource> dataSources) { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.EndpointDataSource> DataSources { get { throw null; } }
        public override System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get { throw null; } }
        public override Microsoft.Extensions.Primitives.IChangeToken GetChangeToken() { throw null; }
    }
    internal sealed partial class DataSourceDependentCache<T> : System.IDisposable where T : class
    {
        public DataSourceDependentCache(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, System.Func<System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint>, T> initialize) { }
        public T Value { get { throw null; } }
        public void Dispose() { }
        public T EnsureInitialized() { throw null; }
    }
    public sealed partial class DataTokensMetadata : Microsoft.AspNetCore.Routing.IDataTokensMetadata
    {
        public DataTokensMetadata(System.Collections.Generic.IReadOnlyDictionary<string, object> dataTokens) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> DataTokens { get { throw null; } }
    }
    internal partial class DefaultEndpointConventionBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder
    {
        public DefaultEndpointConventionBuilder(Microsoft.AspNetCore.Builder.EndpointBuilder endpointBuilder) { }
        internal Microsoft.AspNetCore.Builder.EndpointBuilder EndpointBuilder { get { throw null; } }
        public void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention) { }
        public Microsoft.AspNetCore.Http.Endpoint Build() { throw null; }
    }
    public sealed partial class DefaultEndpointDataSource : Microsoft.AspNetCore.Routing.EndpointDataSource
    {
        public DefaultEndpointDataSource(params Microsoft.AspNetCore.Http.Endpoint[] endpoints) { }
        public DefaultEndpointDataSource(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> endpoints) { }
        public override System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get { throw null; } }
        public override Microsoft.Extensions.Primitives.IChangeToken GetChangeToken() { throw null; }
    }
    internal partial class DefaultEndpointRouteBuilder : Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
    {
        public DefaultEndpointRouteBuilder(Microsoft.AspNetCore.Builder.IApplicationBuilder applicationBuilder) { }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder ApplicationBuilder { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.AspNetCore.Routing.EndpointDataSource> DataSources { get { throw null; } }
        public System.IServiceProvider ServiceProvider { get { throw null; } }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder CreateApplicationBuilder() { throw null; }
    }
    public partial class DefaultInlineConstraintResolver : Microsoft.AspNetCore.Routing.IInlineConstraintResolver
    {
        public DefaultInlineConstraintResolver(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions> routeOptions, System.IServiceProvider serviceProvider) { }
        public virtual Microsoft.AspNetCore.Routing.IRouteConstraint ResolveConstraint(string inlineConstraint) { throw null; }
    }
    internal sealed partial class DefaultLinkGenerator : Microsoft.AspNetCore.Routing.LinkGenerator, System.IDisposable
    {
        public DefaultLinkGenerator(Microsoft.AspNetCore.Routing.ParameterPolicyFactory parameterPolicyFactory, Microsoft.AspNetCore.Routing.Template.TemplateBinderFactory binderFactory, Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions> routeOptions, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Routing.DefaultLinkGenerator> logger, System.IServiceProvider serviceProvider) { }
        public void Dispose() { }
        public static Microsoft.AspNetCore.Routing.RouteValueDictionary GetAmbientValues(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        public override string GetPathByAddress<TAddress>(Microsoft.AspNetCore.Http.HttpContext httpContext, TAddress address, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues = null, Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public override string GetPathByAddress<TAddress>(TAddress address, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        internal Microsoft.AspNetCore.Routing.Template.TemplateBinder GetTemplateBinder(Microsoft.AspNetCore.Routing.RouteEndpoint endpoint) { throw null; }
        public override string GetUriByAddress<TAddress>(Microsoft.AspNetCore.Http.HttpContext httpContext, TAddress address, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues = null, string scheme = null, Microsoft.AspNetCore.Http.HostString? host = default(Microsoft.AspNetCore.Http.HostString?), Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public override string GetUriByAddress<TAddress>(TAddress address, Microsoft.AspNetCore.Routing.RouteValueDictionary values, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public string GetUriByEndpoints(System.Collections.Generic.List<Microsoft.AspNetCore.Routing.RouteEndpoint> endpoints, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase, Microsoft.AspNetCore.Http.FragmentString fragment, Microsoft.AspNetCore.Routing.LinkOptions options) { throw null; }
        internal bool TryProcessTemplate(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteEndpoint endpoint, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues, Microsoft.AspNetCore.Routing.LinkOptions options, out (Microsoft.AspNetCore.Http.PathString path, Microsoft.AspNetCore.Http.QueryString query) result) { throw null; }
    }
    internal partial class DefaultLinkParser : Microsoft.AspNetCore.Routing.LinkParser, System.IDisposable
    {
        public DefaultLinkParser(Microsoft.AspNetCore.Routing.ParameterPolicyFactory parameterPolicyFactory, Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Routing.DefaultLinkParser> logger, System.IServiceProvider serviceProvider) { }
        public void Dispose() { }
        internal Microsoft.AspNetCore.Routing.DefaultLinkParser.MatcherState GetMatcherState(Microsoft.AspNetCore.Routing.RouteEndpoint endpoint) { throw null; }
        public override Microsoft.AspNetCore.Routing.RouteValueDictionary ParsePathByAddress<TAddress>(TAddress address, Microsoft.AspNetCore.Http.PathString path) { throw null; }
        internal bool TryParse(Microsoft.AspNetCore.Routing.RouteEndpoint endpoint, Microsoft.AspNetCore.Http.PathString path, out Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal readonly partial struct MatcherState
        {
            public readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.IRouteConstraint>> Constraints;
            public readonly Microsoft.AspNetCore.Routing.RoutePatternMatcher Matcher;
            public MatcherState(Microsoft.AspNetCore.Routing.RoutePatternMatcher matcher, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.IRouteConstraint>> constraints) { throw null; }
            public void Deconstruct(out Microsoft.AspNetCore.Routing.RoutePatternMatcher matcher, out System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.IRouteConstraint>> constraints) { throw null; }
        }
    }
    internal partial class DefaultParameterPolicyFactory : Microsoft.AspNetCore.Routing.ParameterPolicyFactory
    {
        public DefaultParameterPolicyFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions> options, System.IServiceProvider serviceProvider) { }
        public override Microsoft.AspNetCore.Routing.IParameterPolicy Create(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart parameter, Microsoft.AspNetCore.Routing.IParameterPolicy parameterPolicy) { throw null; }
        public override Microsoft.AspNetCore.Routing.IParameterPolicy Create(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart parameter, string inlineText) { throw null; }
    }
    public abstract partial class EndpointDataSource
    {
        protected EndpointDataSource() { }
        public abstract System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get; }
        public abstract Microsoft.Extensions.Primitives.IChangeToken GetChangeToken();
    }
    internal sealed partial class EndpointMiddleware
    {
        internal const string AuthorizationMiddlewareInvokedKey = "__AuthorizationMiddlewareWithEndpointInvoked";
        internal const string CorsMiddlewareInvokedKey = "__CorsMiddlewareWithEndpointInvoked";
        public EndpointMiddleware(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Routing.EndpointMiddleware> logger, Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions> routeOptions) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    internal sealed partial class EndpointNameAddressScheme : Microsoft.AspNetCore.Routing.IEndpointAddressScheme<string>, System.IDisposable
    {
        public EndpointNameAddressScheme(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource) { }
        internal System.Collections.Generic.Dictionary<string, Microsoft.AspNetCore.Http.Endpoint[]> Entries { get { throw null; } }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> FindEndpoints(string address) { throw null; }
    }
    public partial class EndpointNameMetadata : Microsoft.AspNetCore.Routing.IEndpointNameMetadata
    {
        public EndpointNameMetadata(string endpointName) { }
        public string EndpointName { get { throw null; } }
    }
    internal sealed partial class EndpointRoutingMiddleware
    {
        public EndpointRoutingMiddleware(Microsoft.AspNetCore.Routing.Matching.MatcherFactory matcherFactory, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware> logger, Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpointRouteBuilder, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Http.RequestDelegate next) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=false)]
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public sealed partial class HostAttribute : System.Attribute, Microsoft.AspNetCore.Routing.IHostMetadata
    {
        public HostAttribute(string host) { }
        public HostAttribute(params string[] hosts) { }
        public System.Collections.Generic.IReadOnlyList<string> Hosts { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public sealed partial class HttpMethodMetadata : Microsoft.AspNetCore.Routing.IHttpMethodMetadata
    {
        public HttpMethodMetadata(System.Collections.Generic.IEnumerable<string> httpMethods) { }
        public HttpMethodMetadata(System.Collections.Generic.IEnumerable<string> httpMethods, bool acceptCorsPreflight) { }
        public bool AcceptCorsPreflight { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> HttpMethods { get { throw null; } }
    }
    public partial interface IDataTokensMetadata
    {
        System.Collections.Generic.IReadOnlyDictionary<string, object> DataTokens { get; }
    }
    public partial interface IDynamicEndpointMetadata
    {
        bool IsDynamic { get; }
    }
    public partial interface IEndpointAddressScheme<TAddress>
    {
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> FindEndpoints(TAddress address);
    }
    public partial interface IEndpointNameMetadata
    {
        string EndpointName { get; }
    }
    public partial interface IEndpointRouteBuilder
    {
        System.Collections.Generic.ICollection<Microsoft.AspNetCore.Routing.EndpointDataSource> DataSources { get; }
        System.IServiceProvider ServiceProvider { get; }
        Microsoft.AspNetCore.Builder.IApplicationBuilder CreateApplicationBuilder();
    }
    public partial interface IHostMetadata
    {
        System.Collections.Generic.IReadOnlyList<string> Hosts { get; }
    }
    public partial interface IHttpMethodMetadata
    {
        bool AcceptCorsPreflight { get; }
        System.Collections.Generic.IReadOnlyList<string> HttpMethods { get; }
    }
    public partial interface IInlineConstraintResolver
    {
        Microsoft.AspNetCore.Routing.IRouteConstraint ResolveConstraint(string inlineConstraint);
    }
    public partial interface INamedRouter : Microsoft.AspNetCore.Routing.IRouter
    {
        string Name { get; }
    }
    public static partial class InlineRouteParameterParser
    {
        public static Microsoft.AspNetCore.Routing.Template.TemplatePart ParseRouteParameter(string routeParameter) { throw null; }
    }
    public partial interface IRouteBuilder
    {
        Microsoft.AspNetCore.Builder.IApplicationBuilder ApplicationBuilder { get; }
        Microsoft.AspNetCore.Routing.IRouter DefaultHandler { get; set; }
        System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.IRouter> Routes { get; }
        System.IServiceProvider ServiceProvider { get; }
        Microsoft.AspNetCore.Routing.IRouter Build();
    }
    public partial interface IRouteCollection : Microsoft.AspNetCore.Routing.IRouter
    {
        void Add(Microsoft.AspNetCore.Routing.IRouter router);
    }
    public partial interface IRouteNameMetadata
    {
        string RouteName { get; }
    }
    public partial interface ISuppressLinkGenerationMetadata
    {
        bool SuppressLinkGeneration { get; }
    }
    public partial interface ISuppressMatchingMetadata
    {
        bool SuppressMatching { get; }
    }
    public static partial class LinkGeneratorEndpointNameAddressExtensions
    {
        public static string GetPathByName(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string endpointName, object values, Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetPathByName(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string endpointName, object values, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByName(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string endpointName, object values, string scheme = null, Microsoft.AspNetCore.Http.HostString? host = default(Microsoft.AspNetCore.Http.HostString?), Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByName(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string endpointName, object values, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
    }
    public static partial class LinkGeneratorRouteValuesAddressExtensions
    {
        public static string GetPathByRouteValues(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string routeName, object values, Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetPathByRouteValues(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string routeName, object values, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByRouteValues(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string routeName, object values, string scheme = null, Microsoft.AspNetCore.Http.HostString? host = default(Microsoft.AspNetCore.Http.HostString?), Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByRouteValues(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string routeName, object values, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
    }
    public abstract partial class LinkParser
    {
        protected LinkParser() { }
        public abstract Microsoft.AspNetCore.Routing.RouteValueDictionary ParsePathByAddress<TAddress>(TAddress address, Microsoft.AspNetCore.Http.PathString path);
    }
    public static partial class LinkParserEndpointNameAddressExtensions
    {
        public static Microsoft.AspNetCore.Routing.RouteValueDictionary ParsePathByEndpointName(this Microsoft.AspNetCore.Routing.LinkParser parser, string endpointName, Microsoft.AspNetCore.Http.PathString path) { throw null; }
    }
    public abstract partial class MatcherPolicy
    {
        protected MatcherPolicy() { }
        public abstract int Order { get; }
        protected static bool ContainsDynamicEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
    }
    internal partial class ModelEndpointDataSource : Microsoft.AspNetCore.Routing.EndpointDataSource
    {
        public ModelEndpointDataSource() { }
        internal System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Builder.EndpointBuilder> EndpointBuilders { get { throw null; } }
        public override System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get { throw null; } }
        public Microsoft.AspNetCore.Builder.IEndpointConventionBuilder AddEndpointBuilder(Microsoft.AspNetCore.Builder.EndpointBuilder endpointBuilder) { throw null; }
        public override Microsoft.Extensions.Primitives.IChangeToken GetChangeToken() { throw null; }
    }
    internal partial class NullRouter : Microsoft.AspNetCore.Routing.IRouter
    {
        private NullRouter() { }
        public static readonly Microsoft.AspNetCore.Routing.NullRouter Instance;
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    internal static partial class ParameterPolicyActivator
    {
        public static T ResolveParameterPolicy<T>(System.Collections.Generic.IDictionary<string, System.Type> inlineParameterPolicyMap, System.IServiceProvider serviceProvider, string inlineParameterPolicy, out string parameterPolicyKey) where T : Microsoft.AspNetCore.Routing.IParameterPolicy { throw null; }
    }
    public abstract partial class ParameterPolicyFactory
    {
        protected ParameterPolicyFactory() { }
        public abstract Microsoft.AspNetCore.Routing.IParameterPolicy Create(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart parameter, Microsoft.AspNetCore.Routing.IParameterPolicy parameterPolicy);
        public Microsoft.AspNetCore.Routing.IParameterPolicy Create(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart parameter, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference reference) { throw null; }
        public abstract Microsoft.AspNetCore.Routing.IParameterPolicy Create(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart parameter, string inlineText);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct PathTokenizer : System.Collections.Generic.IEnumerable<Microsoft.Extensions.Primitives.StringSegment>, System.Collections.Generic.IReadOnlyCollection<Microsoft.Extensions.Primitives.StringSegment>, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.Primitives.StringSegment>, System.Collections.IEnumerable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public PathTokenizer(Microsoft.AspNetCore.Http.PathString path) { throw null; }
        public int Count { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Routing.PathTokenizer.Enumerator GetEnumerator() { throw null; }
        System.Collections.Generic.IEnumerator<Microsoft.Extensions.Primitives.StringSegment> System.Collections.Generic.IEnumerable<Microsoft.Extensions.Primitives.StringSegment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<Microsoft.Extensions.Primitives.StringSegment>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(Microsoft.AspNetCore.Routing.PathTokenizer tokenizer) { throw null; }
            public Microsoft.Extensions.Primitives.StringSegment Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public static partial class RequestDelegateRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapDelete(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapDelete(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Func<Microsoft.AspNetCore.Http.HttpRequest, Microsoft.AspNetCore.Http.HttpResponse, Microsoft.AspNetCore.Routing.RouteData, System.Threading.Tasks.Task> handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapGet(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapGet(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Func<Microsoft.AspNetCore.Http.HttpRequest, Microsoft.AspNetCore.Http.HttpResponse, Microsoft.AspNetCore.Routing.RouteData, System.Threading.Tasks.Task> handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewareDelete(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewareGet(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewarePost(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewarePut(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewareRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapMiddlewareVerb(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string verb, string template, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> action) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapPost(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapPost(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Func<Microsoft.AspNetCore.Http.HttpRequest, Microsoft.AspNetCore.Http.HttpResponse, Microsoft.AspNetCore.Routing.RouteData, System.Threading.Tasks.Task> handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapPut(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapPut(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, System.Func<Microsoft.AspNetCore.Http.HttpRequest, Microsoft.AspNetCore.Http.HttpResponse, Microsoft.AspNetCore.Routing.RouteData, System.Threading.Tasks.Task> handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapVerb(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string verb, string template, Microsoft.AspNetCore.Http.RequestDelegate handler) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapVerb(this Microsoft.AspNetCore.Routing.IRouteBuilder builder, string verb, string template, System.Func<Microsoft.AspNetCore.Http.HttpRequest, Microsoft.AspNetCore.Http.HttpResponse, Microsoft.AspNetCore.Routing.RouteData, System.Threading.Tasks.Task> handler) { throw null; }
    }
    internal static partial class Resources
    {
        internal static string AmbiguousEndpoints { get { throw null; } }
        internal static string ArgumentMustBeGreaterThanOrEqualTo { get { throw null; } }
        internal static string Argument_NullOrEmpty { get { throw null; } }
        internal static string AttributeRoute_DifferentLinkGenerationEntries_SameName { get { throw null; } }
        internal static string ConstraintMustBeStringOrConstraint { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string DefaultHandler_MustBeSet { get { throw null; } }
        internal static string DefaultInlineConstraintResolver_AmbiguousCtors { get { throw null; } }
        internal static string DefaultInlineConstraintResolver_CouldNotFindCtor { get { throw null; } }
        internal static string DefaultInlineConstraintResolver_TypeNotConstraint { get { throw null; } }
        internal static string DuplicateEndpointNameEntry { get { throw null; } }
        internal static string DuplicateEndpointNameHeader { get { throw null; } }
        internal static string NamedRoutes_AmbiguousRoutesFound { get { throw null; } }
        internal static string PropertyOfTypeCannotBeNull { get { throw null; } }
        internal static string RangeConstraint_MinShouldBeLessThanOrEqualToMax { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string RouteConstraintBuilder_CouldNotResolveConstraint { get { throw null; } }
        internal static string RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint { get { throw null; } }
        internal static string RoutePatternBuilder_CollectionCannotBeEmpty { get { throw null; } }
        internal static string RoutePattern_ConstraintReferenceNotFound { get { throw null; } }
        internal static string RoutePattern_InvalidConstraintReference { get { throw null; } }
        internal static string RoutePattern_InvalidParameterConstraintReference { get { throw null; } }
        internal static string RoutePattern_InvalidStringConstraintReference { get { throw null; } }
        internal static string TemplateRoute_CannotHaveCatchAllInMultiSegment { get { throw null; } }
        internal static string TemplateRoute_CannotHaveConsecutiveParameters { get { throw null; } }
        internal static string TemplateRoute_CannotHaveConsecutiveSeparators { get { throw null; } }
        internal static string TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly { get { throw null; } }
        internal static string TemplateRoute_CatchAllCannotBeOptional { get { throw null; } }
        internal static string TemplateRoute_CatchAllMustBeLast { get { throw null; } }
        internal static string TemplateRoute_Exception { get { throw null; } }
        internal static string TemplateRoute_InvalidLiteral { get { throw null; } }
        internal static string TemplateRoute_InvalidParameterName { get { throw null; } }
        internal static string TemplateRoute_InvalidRouteTemplate { get { throw null; } }
        internal static string TemplateRoute_MismatchedParameter { get { throw null; } }
        internal static string TemplateRoute_OptionalCannotHaveDefaultValue { get { throw null; } }
        internal static string TemplateRoute_OptionalParameterCanbBePrecededByPeriod { get { throw null; } }
        internal static string TemplateRoute_OptionalParameterHasTobeTheLast { get { throw null; } }
        internal static string TemplateRoute_RepeatedParameter { get { throw null; } }
        internal static string TemplateRoute_UnescapedBrace { get { throw null; } }
        internal static string UnableToFindServices { get { throw null; } }
        internal static string FormatAmbiguousEndpoints(object p0, object p1) { throw null; }
        internal static string FormatArgumentMustBeGreaterThanOrEqualTo(object p0) { throw null; }
        internal static string FormatAttributeRoute_DifferentLinkGenerationEntries_SameName(object p0) { throw null; }
        internal static string FormatConstraintMustBeStringOrConstraint(object p0, object p1, object p2) { throw null; }
        internal static string FormatDefaultHandler_MustBeSet(object p0) { throw null; }
        internal static string FormatDefaultInlineConstraintResolver_AmbiguousCtors(object p0, object p1) { throw null; }
        internal static string FormatDefaultInlineConstraintResolver_CouldNotFindCtor(object p0, object p1) { throw null; }
        internal static string FormatDefaultInlineConstraintResolver_TypeNotConstraint(object p0, object p1, object p2) { throw null; }
        internal static string FormatDuplicateEndpointNameEntry(object p0) { throw null; }
        internal static string FormatNamedRoutes_AmbiguousRoutesFound(object p0) { throw null; }
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) { throw null; }
        internal static string FormatRangeConstraint_MinShouldBeLessThanOrEqualToMax(object p0, object p1) { throw null; }
        internal static string FormatRouteConstraintBuilder_CouldNotResolveConstraint(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatRouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatRoutePattern_ConstraintReferenceNotFound(object p0, object p1, object p2) { throw null; }
        internal static string FormatRoutePattern_InvalidConstraintReference(object p0, object p1) { throw null; }
        internal static string FormatRoutePattern_InvalidParameterConstraintReference(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatRoutePattern_InvalidStringConstraintReference(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatTemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly(object p0) { throw null; }
        internal static string FormatTemplateRoute_Exception(object p0, object p1) { throw null; }
        internal static string FormatTemplateRoute_InvalidLiteral(object p0) { throw null; }
        internal static string FormatTemplateRoute_InvalidParameterName(object p0) { throw null; }
        internal static string FormatTemplateRoute_OptionalParameterCanbBePrecededByPeriod(object p0, object p1, object p2) { throw null; }
        internal static string FormatTemplateRoute_OptionalParameterHasTobeTheLast(object p0, object p1, object p2) { throw null; }
        internal static string FormatTemplateRoute_RepeatedParameter(object p0) { throw null; }
        internal static string FormatUnableToFindServices(object p0, object p1, object p2) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public partial class Route : Microsoft.AspNetCore.Routing.RouteBase
    {
        public Route(Microsoft.AspNetCore.Routing.IRouter target, string routeTemplate, Microsoft.AspNetCore.Routing.IInlineConstraintResolver inlineConstraintResolver) : base (default(string), default(string), default(Microsoft.AspNetCore.Routing.IInlineConstraintResolver), default(Microsoft.AspNetCore.Routing.RouteValueDictionary), default(System.Collections.Generic.IDictionary<string, object>), default(Microsoft.AspNetCore.Routing.RouteValueDictionary)) { }
        public Route(Microsoft.AspNetCore.Routing.IRouter target, string routeTemplate, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IDictionary<string, object> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary dataTokens, Microsoft.AspNetCore.Routing.IInlineConstraintResolver inlineConstraintResolver) : base (default(string), default(string), default(Microsoft.AspNetCore.Routing.IInlineConstraintResolver), default(Microsoft.AspNetCore.Routing.RouteValueDictionary), default(System.Collections.Generic.IDictionary<string, object>), default(Microsoft.AspNetCore.Routing.RouteValueDictionary)) { }
        public Route(Microsoft.AspNetCore.Routing.IRouter target, string routeName, string routeTemplate, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IDictionary<string, object> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary dataTokens, Microsoft.AspNetCore.Routing.IInlineConstraintResolver inlineConstraintResolver) : base (default(string), default(string), default(Microsoft.AspNetCore.Routing.IInlineConstraintResolver), default(Microsoft.AspNetCore.Routing.RouteValueDictionary), default(System.Collections.Generic.IDictionary<string, object>), default(Microsoft.AspNetCore.Routing.RouteValueDictionary)) { }
        public string RouteTemplate { get { throw null; } }
        protected override System.Threading.Tasks.Task OnRouteMatched(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
        protected override Microsoft.AspNetCore.Routing.VirtualPathData OnVirtualPathGenerated(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
    }
    public abstract partial class RouteBase : Microsoft.AspNetCore.Routing.INamedRouter, Microsoft.AspNetCore.Routing.IRouter
    {
        public RouteBase(string template, string name, Microsoft.AspNetCore.Routing.IInlineConstraintResolver constraintResolver, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IDictionary<string, object> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary dataTokens) { }
        protected virtual Microsoft.AspNetCore.Routing.IInlineConstraintResolver ConstraintResolver { get { throw null; } set { } }
        public virtual System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> Constraints { get { throw null; } protected set { } }
        public virtual Microsoft.AspNetCore.Routing.RouteValueDictionary DataTokens { get { throw null; } protected set { } }
        public virtual Microsoft.AspNetCore.Routing.RouteValueDictionary Defaults { get { throw null; } protected set { } }
        public virtual string Name { get { throw null; } protected set { } }
        public virtual Microsoft.AspNetCore.Routing.Template.RouteTemplate ParsedTemplate { get { throw null; } protected set { } }
        protected static System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> GetConstraints(Microsoft.AspNetCore.Routing.IInlineConstraintResolver inlineConstraintResolver, Microsoft.AspNetCore.Routing.Template.RouteTemplate parsedTemplate, System.Collections.Generic.IDictionary<string, object> constraints) { throw null; }
        protected static Microsoft.AspNetCore.Routing.RouteValueDictionary GetDefaults(Microsoft.AspNetCore.Routing.Template.RouteTemplate parsedTemplate, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults) { throw null; }
        public virtual Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        protected abstract System.Threading.Tasks.Task OnRouteMatched(Microsoft.AspNetCore.Routing.RouteContext context);
        protected abstract Microsoft.AspNetCore.Routing.VirtualPathData OnVirtualPathGenerated(Microsoft.AspNetCore.Routing.VirtualPathContext context);
        public virtual System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RouteBuilder : Microsoft.AspNetCore.Routing.IRouteBuilder
    {
        public RouteBuilder(Microsoft.AspNetCore.Builder.IApplicationBuilder applicationBuilder) { }
        public RouteBuilder(Microsoft.AspNetCore.Builder.IApplicationBuilder applicationBuilder, Microsoft.AspNetCore.Routing.IRouter defaultHandler) { }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder ApplicationBuilder { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IRouter DefaultHandler { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.IRouter> Routes { get { throw null; } }
        public System.IServiceProvider ServiceProvider { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IRouter Build() { throw null; }
    }
    public partial class RouteCollection : Microsoft.AspNetCore.Routing.IRouteCollection, Microsoft.AspNetCore.Routing.IRouter
    {
        public RouteCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IRouter this[int index] { get { throw null; } }
        public void Add(Microsoft.AspNetCore.Routing.IRouter router) { }
        public virtual Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    public partial class RouteConstraintBuilder
    {
        public RouteConstraintBuilder(Microsoft.AspNetCore.Routing.IInlineConstraintResolver inlineConstraintResolver, string displayName) { }
        public void AddConstraint(string key, object value) { }
        public void AddResolvedConstraint(string key, string constraintText) { }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> Build() { throw null; }
        public void SetOptional(string key) { }
    }
    public static partial class RouteConstraintMatcher
    {
        public static bool Match(System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary routeValues, Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, Microsoft.AspNetCore.Routing.RouteDirection routeDirection, Microsoft.Extensions.Logging.ILogger logger) { throw null; }
    }
    public partial class RouteCreationException : System.Exception
    {
        public RouteCreationException(string message) { }
        public RouteCreationException(string message, System.Exception innerException) { }
    }
    public sealed partial class RouteEndpoint : Microsoft.AspNetCore.Http.Endpoint
    {
        public RouteEndpoint(Microsoft.AspNetCore.Http.RequestDelegate requestDelegate, Microsoft.AspNetCore.Routing.Patterns.RoutePattern routePattern, int order, Microsoft.AspNetCore.Http.EndpointMetadataCollection metadata, string displayName) : base (default(Microsoft.AspNetCore.Http.RequestDelegate), default(Microsoft.AspNetCore.Http.EndpointMetadataCollection), default(string)) { }
        public int Order { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePattern RoutePattern { get { throw null; } }
    }
    public sealed partial class RouteEndpointBuilder : Microsoft.AspNetCore.Builder.EndpointBuilder
    {
        public RouteEndpointBuilder(Microsoft.AspNetCore.Http.RequestDelegate requestDelegate, Microsoft.AspNetCore.Routing.Patterns.RoutePattern routePattern, int order) { }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePattern RoutePattern { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.Endpoint Build() { throw null; }
    }
    public partial class RouteHandler : Microsoft.AspNetCore.Routing.IRouteHandler, Microsoft.AspNetCore.Routing.IRouter
    {
        public RouteHandler(Microsoft.AspNetCore.Http.RequestDelegate requestDelegate) { }
        public Microsoft.AspNetCore.Http.RequestDelegate GetRequestHandler(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData) { throw null; }
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public sealed partial class RouteNameMetadata : Microsoft.AspNetCore.Routing.IRouteNameMetadata
    {
        public RouteNameMetadata(string routeName) { }
        public string RouteName { get { throw null; } }
        internal string DebuggerToString() { throw null; }
    }
    public partial class RouteOptions
    {
        public RouteOptions() { }
        public bool AppendTrailingSlash { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.Type> ConstraintMap { get { throw null; } set { } }
        internal System.Collections.Generic.ICollection<Microsoft.AspNetCore.Routing.EndpointDataSource> EndpointDataSources { get { throw null; } set { } }
        public bool LowercaseQueryStrings { get { throw null; } set { } }
        public bool LowercaseUrls { get { throw null; } set { } }
        public bool SuppressCheckForUnhandledSecurityMetadata { get { throw null; } set { } }
    }
    internal partial class RoutePatternMatcher
    {
        public RoutePatternMatcher(Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults) { }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Defaults { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePattern RoutePattern { get { throw null; } }
        internal static bool MatchComplexSegment(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment routeSegment, System.ReadOnlySpan<char> requestSegment, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
        public bool TryMatch(Microsoft.AspNetCore.Http.PathString path, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
    }
    public partial class RouteValueEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
    {
        public static readonly Microsoft.AspNetCore.Routing.RouteValueEqualityComparer Default;
        public RouteValueEqualityComparer() { }
        public new bool Equals(object x, object y) { throw null; }
        public int GetHashCode(object obj) { throw null; }
    }
    public partial class RouteValuesAddress
    {
        public RouteValuesAddress() { }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary AmbientValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary ExplicitValues { get { throw null; } set { } }
        public string RouteName { get { throw null; } set { } }
    }
    internal sealed partial class RouteValuesAddressScheme : Microsoft.AspNetCore.Routing.IEndpointAddressScheme<Microsoft.AspNetCore.Routing.RouteValuesAddress>, System.IDisposable
    {
        public RouteValuesAddressScheme(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource) { }
        internal Microsoft.AspNetCore.Routing.RouteValuesAddressScheme.StateEntry State { get { throw null; } }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> FindEndpoints(Microsoft.AspNetCore.Routing.RouteValuesAddress address) { throw null; }
        internal partial class StateEntry
        {
            public readonly System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Tree.OutboundMatch> AllMatches;
            public readonly Microsoft.AspNetCore.Routing.Tree.LinkGenerationDecisionTree AllMatchesLinkGenerationTree;
            public readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Tree.OutboundMatchResult>> NamedMatches;
            public StateEntry(System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Tree.OutboundMatch> allMatches, Microsoft.AspNetCore.Routing.Tree.LinkGenerationDecisionTree allMatchesLinkGenerationTree, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Tree.OutboundMatchResult>> namedMatches) { }
        }
    }
    public partial class RoutingFeature : Microsoft.AspNetCore.Routing.IRoutingFeature
    {
        public RoutingFeature() { }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } set { } }
    }
    internal partial class RoutingMarkerService
    {
        public RoutingMarkerService() { }
    }
    internal enum SegmentState
    {
        Beginning = 0,
        Inside = 1,
    }
    public sealed partial class SuppressLinkGenerationMetadata : Microsoft.AspNetCore.Routing.ISuppressLinkGenerationMetadata
    {
        public SuppressLinkGenerationMetadata() { }
        public bool SuppressLinkGeneration { get { throw null; } }
    }
    public sealed partial class SuppressMatchingMetadata : Microsoft.AspNetCore.Routing.ISuppressMatchingMetadata
    {
        public SuppressMatchingMetadata() { }
        public bool SuppressMatching { get { throw null; } }
    }
    internal partial class UriBuilderContextPooledObjectPolicy : Microsoft.Extensions.ObjectPool.IPooledObjectPolicy<Microsoft.AspNetCore.Routing.UriBuildingContext>
    {
        public UriBuilderContextPooledObjectPolicy() { }
        public Microsoft.AspNetCore.Routing.UriBuildingContext Create() { throw null; }
        public bool Return(Microsoft.AspNetCore.Routing.UriBuildingContext obj) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    internal partial class UriBuildingContext
    {
        public UriBuildingContext(System.Text.Encodings.Web.UrlEncoder urlEncoder) { }
        public bool AppendTrailingSlash { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.SegmentState BufferState { get { throw null; } }
        public bool LowercaseQueryStrings { get { throw null; } set { } }
        public bool LowercaseUrls { get { throw null; } set { } }
        public System.IO.TextWriter PathWriter { get { throw null; } }
        public System.IO.TextWriter QueryWriter { get { throw null; } }
        public Microsoft.AspNetCore.Routing.SegmentState UriState { get { throw null; } }
        public bool Accept(string value) { throw null; }
        public bool Accept(string value, bool encodeSlashes) { throw null; }
        public bool Buffer(string value) { throw null; }
        public void Clear() { }
        internal void EncodeValue(string value, int start, int characterCount, bool encodeSlashes) { }
        public void EndSegment() { }
        public void Remove(string literal) { }
        public Microsoft.AspNetCore.Http.PathString ToPathString() { throw null; }
        public Microsoft.AspNetCore.Http.QueryString ToQueryString() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace Microsoft.AspNetCore.Routing.Constraints
{
    public partial class AlphaRouteConstraint : Microsoft.AspNetCore.Routing.Constraints.RegexRouteConstraint
    {
        public AlphaRouteConstraint() : base (default(System.Text.RegularExpressions.Regex)) { }
    }
    public partial class BoolRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public BoolRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class CompositeRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public CompositeRouteConstraint(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.IRouteConstraint> constraints) { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.IRouteConstraint> Constraints { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class DateTimeRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public DateTimeRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class DecimalRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public DecimalRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class DoubleRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public DoubleRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class FileNameRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public FileNameRouteConstraint() { }
        internal static bool IsFileName(System.ReadOnlySpan<char> value) { throw null; }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class FloatRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public FloatRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class GuidRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public GuidRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class HttpMethodRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public HttpMethodRouteConstraint(params string[] allowedMethods) { }
        public System.Collections.Generic.IList<string> AllowedMethods { get { throw null; } }
        public virtual bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class IntRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public IntRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class LengthRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public LengthRouteConstraint(int length) { }
        public LengthRouteConstraint(int minLength, int maxLength) { }
        public int MaxLength { get { throw null; } }
        public int MinLength { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class LongRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public LongRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class MaxLengthRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public MaxLengthRouteConstraint(int maxLength) { }
        public int MaxLength { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class MaxRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public MaxRouteConstraint(long max) { }
        public long Max { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class MinLengthRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public MinLengthRouteConstraint(int minLength) { }
        public int MinLength { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class MinRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public MinRouteConstraint(long min) { }
        public long Min { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class NonFileNameRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public NonFileNameRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    internal partial class NullRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        private NullRouteConstraint() { }
        public static readonly Microsoft.AspNetCore.Routing.Constraints.NullRouteConstraint Instance;
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class OptionalRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public OptionalRouteConstraint(Microsoft.AspNetCore.Routing.IRouteConstraint innerConstraint) { }
        public Microsoft.AspNetCore.Routing.IRouteConstraint InnerConstraint { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class RangeRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public RangeRouteConstraint(long min, long max) { }
        public long Max { get { throw null; } }
        public long Min { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class RegexInlineRouteConstraint : Microsoft.AspNetCore.Routing.Constraints.RegexRouteConstraint
    {
        public RegexInlineRouteConstraint(string regexPattern) : base (default(System.Text.RegularExpressions.Regex)) { }
    }
    public partial class RegexRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public RegexRouteConstraint(string regexPattern) { }
        public RegexRouteConstraint(System.Text.RegularExpressions.Regex regex) { }
        public System.Text.RegularExpressions.Regex Constraint { get { throw null; } }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class RequiredRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public RequiredRouteConstraint() { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    public partial class StringRouteConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public StringRouteConstraint(string value) { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Routing.DecisionTree
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct DecisionCriterionValue
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DecisionCriterionValue(object value) { throw null; }
        public object Value { get { throw null; } }
    }
    internal partial class DecisionCriterionValueEqualityComparer : System.Collections.Generic.IEqualityComparer<Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue>
    {
        public DecisionCriterionValueEqualityComparer(System.Collections.Generic.IEqualityComparer<object> innerComparer) { }
        public System.Collections.Generic.IEqualityComparer<object> InnerComparer { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue x, Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue y) { throw null; }
        public int GetHashCode(Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue obj) { throw null; }
    }
    internal partial class DecisionCriterion<TItem>
    {
        public DecisionCriterion() { }
        public System.Collections.Generic.Dictionary<object, Microsoft.AspNetCore.Routing.DecisionTree.DecisionTreeNode<TItem>> Branches { get { throw null; } set { } }
        public string Key { get { throw null; } set { } }
    }
    internal static partial class DecisionTreeBuilder<TItem>
    {
        public static Microsoft.AspNetCore.Routing.DecisionTree.DecisionTreeNode<TItem> GenerateTree(System.Collections.Generic.IReadOnlyList<TItem> items, Microsoft.AspNetCore.Routing.DecisionTree.IClassifier<TItem> classifier) { throw null; }
    }
    internal partial class DecisionTreeNode<TItem>
    {
        public DecisionTreeNode() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterion<TItem>> Criteria { get { throw null; } set { } }
        public System.Collections.Generic.IList<TItem> Matches { get { throw null; } set { } }
    }
    internal partial interface IClassifier<TItem>
    {
        System.Collections.Generic.IEqualityComparer<object> ValueComparer { get; }
        System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue> GetCriteria(TItem item);
    }
    internal partial class ItemDescriptor<TItem>
    {
        public ItemDescriptor() { }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.DecisionTree.DecisionCriterionValue> Criteria { get { throw null; } set { } }
        public int Index { get { throw null; } set { } }
        public TItem Item { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Routing.Internal
{
    public partial class DfaGraphWriter
    {
        public DfaGraphWriter(System.IServiceProvider services) { }
        public void Write(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, System.IO.TextWriter writer) { }
    }
}
namespace Microsoft.AspNetCore.Routing.Logging
{
    internal static partial class RouteConstraintMatcherExtensions
    {
        public static void ConstraintNotMatched(this Microsoft.Extensions.Logging.ILogger logger, object routeValue, string routeKey, Microsoft.AspNetCore.Routing.IRouteConstraint routeConstraint) { }
    }
    internal static partial class RouterMiddlewareLoggerExtensions
    {
        public static void RequestNotMatched(this Microsoft.Extensions.Logging.ILogger logger) { }
    }
    internal static partial class TreeRouterLoggerExtensions
    {
        public static void RequestMatchedRoute(this Microsoft.Extensions.Logging.ILogger logger, string routeName, string routeTemplate) { }
    }
}
namespace Microsoft.AspNetCore.Routing.Matching
{
    internal partial class AmbiguousMatchException : System.Exception
    {
        protected AmbiguousMatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AmbiguousMatchException(string message) { }
    }
    internal static partial class Ascii
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool AsciiIgnoreCaseEquals(char charA, char charB) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool AsciiIgnoreCaseEquals(System.ReadOnlySpan<char> a, System.ReadOnlySpan<char> b, int length) { throw null; }
        public static bool IsAscii(string text) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct Candidate
    {
        public readonly (string parameterName, int segmentIndex, int slotIndex)[] Captures;
        public readonly (string parameterName, int segmentIndex, int slotIndex) CatchAll;
        public readonly (Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment pathSegment, int segmentIndex)[] ComplexSegments;
        public readonly System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Routing.IRouteConstraint>[] Constraints;
        public readonly Microsoft.AspNetCore.Http.Endpoint Endpoint;
        public readonly Microsoft.AspNetCore.Routing.Matching.Candidate.CandidateFlags Flags;
        public readonly int Score;
        public readonly System.Collections.Generic.KeyValuePair<string, object>[] Slots;
        public Candidate(Microsoft.AspNetCore.Http.Endpoint endpoint) { throw null; }
        public Candidate(Microsoft.AspNetCore.Http.Endpoint endpoint, int score, System.Collections.Generic.KeyValuePair<string, object>[] slots, (string parameterName, int segmentIndex, int slotIndex)[] captures, in (string parameterName, int segmentIndex, int slotIndex) catchAll, (Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment pathSegment, int segmentIndex)[] complexSegments, System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Routing.IRouteConstraint>[] constraints) { throw null; }
        [System.FlagsAttribute]
        public enum CandidateFlags
        {
            None = 0,
            HasDefaults = 1,
            HasCaptures = 2,
            HasCatchAll = 4,
            HasSlots = 7,
            HasComplexSegments = 8,
            HasConstraints = 16,
        }
    }
    public sealed partial class CandidateSet
    {
        internal Microsoft.AspNetCore.Routing.Matching.CandidateState[] Candidates;
        public CandidateSet(Microsoft.AspNetCore.Http.Endpoint[] endpoints, Microsoft.AspNetCore.Routing.RouteValueDictionary[] values, int[] scores) { }
        internal CandidateSet(Microsoft.AspNetCore.Routing.Matching.CandidateState[] candidates) { }
        internal CandidateSet(Microsoft.AspNetCore.Routing.Matching.Candidate[] candidates) { }
        public int Count { get { throw null; } }
        public ref Microsoft.AspNetCore.Routing.Matching.CandidateState this[int index] { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]get { throw null; } }
        public void ExpandEndpoint(int index, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints, System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> comparer) { }
        internal static bool IsValidCandidate(ref Microsoft.AspNetCore.Routing.Matching.CandidateState candidate) { throw null; }
        public bool IsValidCandidate(int index) { throw null; }
        public void ReplaceEndpoint(int index, Microsoft.AspNetCore.Http.Endpoint endpoint, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { }
        internal static void SetValidity(ref Microsoft.AspNetCore.Routing.Matching.CandidateState candidate, bool value) { }
        public void SetValidity(int index, bool value) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CandidateState
    {
        private object _dummy;
        private int _dummyPrimitive;
        internal CandidateState(Microsoft.AspNetCore.Http.Endpoint endpoint, Microsoft.AspNetCore.Routing.RouteValueDictionary values, int score) { throw null; }
        internal CandidateState(Microsoft.AspNetCore.Http.Endpoint endpoint, int score) { throw null; }
        public Microsoft.AspNetCore.Http.Endpoint Endpoint { get { throw null; } }
        public int Score { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Values { get { throw null; } internal set { } }
    }
    internal sealed partial class DataSourceDependentMatcher : Microsoft.AspNetCore.Routing.Matching.Matcher
    {
        public DataSourceDependentMatcher(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, Microsoft.AspNetCore.Routing.Matching.DataSourceDependentMatcher.Lifetime lifetime, System.Func<Microsoft.AspNetCore.Routing.Matching.MatcherBuilder> matcherBuilderFactory) { }
        internal Microsoft.AspNetCore.Routing.Matching.Matcher CurrentMatcher { get { throw null; } }
        public override System.Threading.Tasks.Task MatchAsync(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        public sealed partial class Lifetime : System.IDisposable
        {
            public Lifetime() { }
            public Microsoft.AspNetCore.Routing.DataSourceDependentCache<Microsoft.AspNetCore.Routing.Matching.Matcher> Cache { get { throw null; } set { } }
            public void Dispose() { }
        }
    }
    internal sealed partial class DefaultEndpointSelector : Microsoft.AspNetCore.Routing.Matching.EndpointSelector
    {
        public DefaultEndpointSelector() { }
        internal static void Select(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateState[] candidateState) { }
        public override System.Threading.Tasks.Task SelectAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidateSet) { throw null; }
    }
    internal sealed partial class DfaMatcher : Microsoft.AspNetCore.Routing.Matching.Matcher
    {
        public DfaMatcher(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Routing.Matching.DfaMatcher> logger, Microsoft.AspNetCore.Routing.Matching.EndpointSelector selector, Microsoft.AspNetCore.Routing.Matching.DfaState[] states, int maxSegmentCount) { }
        internal (Microsoft.AspNetCore.Routing.Matching.Candidate[] candidates, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy[] policies) FindCandidateSet(Microsoft.AspNetCore.Http.HttpContext httpContext, string path, System.ReadOnlySpan<Microsoft.AspNetCore.Routing.Matching.PathSegment> segments) { throw null; }
        public sealed override System.Threading.Tasks.Task MatchAsync(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        internal static partial class EventIds
        {
            public static readonly Microsoft.Extensions.Logging.EventId CandidateNotValid;
            public static readonly Microsoft.Extensions.Logging.EventId CandidateRejectedByComplexSegment;
            public static readonly Microsoft.Extensions.Logging.EventId CandidateRejectedByConstraint;
            public static readonly Microsoft.Extensions.Logging.EventId CandidatesFound;
            public static readonly Microsoft.Extensions.Logging.EventId CandidatesNotFound;
            public static readonly Microsoft.Extensions.Logging.EventId CandidateValid;
        }
    }
    internal partial class DfaMatcherBuilder : Microsoft.AspNetCore.Routing.Matching.MatcherBuilder
    {
        public DfaMatcherBuilder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Routing.ParameterPolicyFactory parameterPolicyFactory, Microsoft.AspNetCore.Routing.Matching.EndpointSelector selector, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.MatcherPolicy> policies) { }
        public override void AddEndpoint(Microsoft.AspNetCore.Routing.RouteEndpoint endpoint) { }
        public override Microsoft.AspNetCore.Routing.Matching.Matcher Build() { throw null; }
        public Microsoft.AspNetCore.Routing.Matching.DfaNode BuildDfaTree(bool includeLabel = false) { throw null; }
        internal Microsoft.AspNetCore.Routing.Matching.Candidate CreateCandidate(Microsoft.AspNetCore.Http.Endpoint endpoint, int score) { throw null; }
        internal Microsoft.AspNetCore.Routing.Matching.Candidate[] CreateCandidates(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
    }
    internal partial class DfaMatcherFactory : Microsoft.AspNetCore.Routing.Matching.MatcherFactory
    {
        public DfaMatcherFactory(System.IServiceProvider services) { }
        public override Microsoft.AspNetCore.Routing.Matching.Matcher CreateMatcher(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    internal partial class DfaNode
    {
        public DfaNode() { }
        public Microsoft.AspNetCore.Routing.Matching.DfaNode CatchAll { get { throw null; } set { } }
        public string Label { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, Microsoft.AspNetCore.Routing.Matching.DfaNode> Literals { get { throw null; } }
        public System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> Matches { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy NodeBuilder { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Matching.DfaNode Parameters { get { throw null; } set { } }
        public int PathDepth { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<object, Microsoft.AspNetCore.Routing.Matching.DfaNode> PolicyEdges { get { throw null; } }
        public void AddLiteral(string literal, Microsoft.AspNetCore.Routing.Matching.DfaNode node) { }
        public void AddMatch(Microsoft.AspNetCore.Http.Endpoint endpoint) { }
        public void AddMatches(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> endpoints) { }
        public void AddPolicyEdge(object state, Microsoft.AspNetCore.Routing.Matching.DfaNode node) { }
        public void Visit(System.Action<Microsoft.AspNetCore.Routing.Matching.DfaNode> visitor) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct DfaState
    {
        public readonly Microsoft.AspNetCore.Routing.Matching.Candidate[] Candidates;
        public readonly Microsoft.AspNetCore.Routing.Matching.JumpTable PathTransitions;
        public readonly Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy[] Policies;
        public readonly Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable PolicyTransitions;
        public DfaState(Microsoft.AspNetCore.Routing.Matching.Candidate[] candidates, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy[] policies, Microsoft.AspNetCore.Routing.Matching.JumpTable pathTransitions, Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable policyTransitions) { throw null; }
        public string DebuggerToString() { throw null; }
    }
    internal partial class DictionaryJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        public DictionaryJumpTable(int defaultDestination, int exitDestination, (string text, int destination)[] entries) { }
        public override string DebuggerToString() { throw null; }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
    }
    internal partial class EndpointComparer : System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint>, System.Collections.Generic.IEqualityComparer<Microsoft.AspNetCore.Http.Endpoint>
    {
        public EndpointComparer(Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy[] policies) { }
        public int Compare(Microsoft.AspNetCore.Http.Endpoint x, Microsoft.AspNetCore.Http.Endpoint y) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Http.Endpoint x, Microsoft.AspNetCore.Http.Endpoint y) { throw null; }
        public int GetHashCode(Microsoft.AspNetCore.Http.Endpoint obj) { throw null; }
    }
    public sealed partial class EndpointMetadataComparer : System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint>
    {
        internal EndpointMetadataComparer(System.IServiceProvider services) { }
        int System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint>.Compare(Microsoft.AspNetCore.Http.Endpoint x, Microsoft.AspNetCore.Http.Endpoint y) { throw null; }
    }
    public abstract partial class EndpointMetadataComparer<TMetadata> : System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> where TMetadata : class
    {
        public static readonly Microsoft.AspNetCore.Routing.Matching.EndpointMetadataComparer<TMetadata> Default;
        protected EndpointMetadataComparer() { }
        public int Compare(Microsoft.AspNetCore.Http.Endpoint x, Microsoft.AspNetCore.Http.Endpoint y) { throw null; }
        protected virtual int CompareMetadata(TMetadata x, TMetadata y) { throw null; }
        protected virtual TMetadata GetMetadata(Microsoft.AspNetCore.Http.Endpoint endpoint) { throw null; }
    }
    public abstract partial class EndpointSelector
    {
        protected EndpointSelector() { }
        public abstract System.Threading.Tasks.Task SelectAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates);
    }
    internal static partial class FastPathTokenizer
    {
        public static int Tokenize(string path, System.Span<Microsoft.AspNetCore.Routing.Matching.PathSegment> segments) { throw null; }
    }
    public sealed partial class HostMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy, Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy
    {
        public HostMatcherPolicy() { }
        public System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> Comparer { get { throw null; } }
        public override int Order { get { throw null; } }
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
        public Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable BuildJumpTable(int exitDestination, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyJumpTableEdge> edges) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyNodeEdge> GetEdges(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
    }
    public sealed partial class HttpMethodMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy, Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy
    {
        internal static readonly string AccessControlRequestMethod;
        internal const string AnyMethod = "*";
        internal const string Http405EndpointDisplayName = "405 HTTP Method Not Supported";
        internal static readonly string OriginHeader;
        internal static readonly string PreflightHttpMethod;
        public HttpMethodMatcherPolicy() { }
        public System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> Comparer { get { throw null; } }
        public override int Order { get { throw null; } }
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
        public Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable BuildJumpTable(int exitDestination, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyJumpTableEdge> edges) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyNodeEdge> GetEdges(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal readonly partial struct EdgeKey : System.IComparable, System.IComparable<Microsoft.AspNetCore.Routing.Matching.HttpMethodMatcherPolicy.EdgeKey>, System.IEquatable<Microsoft.AspNetCore.Routing.Matching.HttpMethodMatcherPolicy.EdgeKey>
        {
            public readonly string HttpMethod;
            public readonly bool IsCorsPreflightRequest;
            public EdgeKey(string httpMethod, bool isCorsPreflightRequest) { throw null; }
            public int CompareTo(Microsoft.AspNetCore.Routing.Matching.HttpMethodMatcherPolicy.EdgeKey other) { throw null; }
            public int CompareTo(object obj) { throw null; }
            public bool Equals(Microsoft.AspNetCore.Routing.Matching.HttpMethodMatcherPolicy.EdgeKey other) { throw null; }
            public override bool Equals(object obj) { throw null; }
            public override int GetHashCode() { throw null; }
            public override string ToString() { throw null; }
        }
    }
    public partial interface IEndpointComparerPolicy
    {
        System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> Comparer { get; }
    }
    public partial interface IEndpointSelectorPolicy
    {
        bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints);
        System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates);
    }
    internal static partial class ILEmitTrieFactory
    {
        public const int NotAscii = -2147483648;
        public static System.Func<string, int, int, int> Create(int defaultDestination, int exitDestination, (string text, int destination)[] entries, bool? vectorize) { throw null; }
        public static void EmitReturnDestination(System.Reflection.Emit.ILGenerator il, (string text, int destination)[] entries) { }
        internal static bool ShouldVectorize((string text, int destination)[] entries) { throw null; }
    }
    internal partial class ILEmitTrieJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        internal System.Func<string, Microsoft.AspNetCore.Routing.Matching.PathSegment, int> _getDestination;
        public ILEmitTrieJumpTable(int defaultDestination, int exitDestination, (string text, int destination)[] entries, bool? vectorize, Microsoft.AspNetCore.Routing.Matching.JumpTable fallback) { }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
        internal void InitializeILDelegate() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task InitializeILDelegateAsync() { throw null; }
    }
    public partial interface INodeBuilderPolicy
    {
        bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints);
        Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable BuildJumpTable(int exitDestination, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyJumpTableEdge> edges);
        System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyNodeEdge> GetEdges(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    internal abstract partial class JumpTable
    {
        protected JumpTable() { }
        public virtual string DebuggerToString() { throw null; }
        public abstract int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment);
    }
    internal static partial class JumpTableBuilder
    {
        public static readonly int InvalidDestination;
        public static Microsoft.AspNetCore.Routing.Matching.JumpTable Build(int defaultDestination, int exitDestination, (string text, int destination)[] pathEntries) { throw null; }
    }
    internal partial class LinearSearchJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        public LinearSearchJumpTable(int defaultDestination, int exitDestination, (string text, int destination)[] entries) { }
        public override string DebuggerToString() { throw null; }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
    }
    internal abstract partial class Matcher
    {
        protected Matcher() { }
        public abstract System.Threading.Tasks.Task MatchAsync(Microsoft.AspNetCore.Http.HttpContext httpContext);
    }
    internal abstract partial class MatcherBuilder
    {
        protected MatcherBuilder() { }
        public abstract void AddEndpoint(Microsoft.AspNetCore.Routing.RouteEndpoint endpoint);
        public abstract Microsoft.AspNetCore.Routing.Matching.Matcher Build();
    }
    internal abstract partial class MatcherFactory
    {
        protected MatcherFactory() { }
        public abstract Microsoft.AspNetCore.Routing.Matching.Matcher CreateMatcher(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct PathSegment : System.IEquatable<Microsoft.AspNetCore.Routing.Matching.PathSegment>
    {
        public readonly int Length;
        public readonly int Start;
        public PathSegment(int start, int length) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Routing.Matching.PathSegment other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class PolicyJumpTable
    {
        protected PolicyJumpTable() { }
        internal virtual string DebuggerToString() { throw null; }
        public abstract int GetDestination(Microsoft.AspNetCore.Http.HttpContext httpContext);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyJumpTableEdge
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyJumpTableEdge(object state, int destination) { throw null; }
        public int Destination { get { throw null; } }
        public object State { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyNodeEdge
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyNodeEdge(object state, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get { throw null; } }
        public object State { get { throw null; } }
    }
    internal partial class SingleEntryAsciiJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        public SingleEntryAsciiJumpTable(int defaultDestination, int exitDestination, string text, int destination) { }
        public override string DebuggerToString() { throw null; }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
    }
    internal partial class SingleEntryJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        public SingleEntryJumpTable(int defaultDestination, int exitDestination, string text, int destination) { }
        public override string DebuggerToString() { throw null; }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
    }
    internal partial class ZeroEntryJumpTable : Microsoft.AspNetCore.Routing.Matching.JumpTable
    {
        public ZeroEntryJumpTable(int defaultDestination, int exitDestination) { }
        public override string DebuggerToString() { throw null; }
        public override int GetDestination(string path, Microsoft.AspNetCore.Routing.Matching.PathSegment segment) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Routing.Patterns
{
    internal partial class DefaultRoutePatternTransformer : Microsoft.AspNetCore.Routing.Patterns.RoutePatternTransformer
    {
        public DefaultRoutePatternTransformer(Microsoft.AspNetCore.Routing.ParameterPolicyFactory policyFactory) { }
        public override Microsoft.AspNetCore.Routing.Patterns.RoutePattern SubstituteRequiredValues(Microsoft.AspNetCore.Routing.Patterns.RoutePattern original, object requiredValues) { throw null; }
    }
    internal static partial class RouteParameterParser
    {
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParseRouteParameter(string parameter) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePattern
    {
        public static readonly object RequiredValueAny;
        internal RoutePattern(string rawText, System.Collections.Generic.IReadOnlyDictionary<string, object> defaults, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference>> parameterPolicies, System.Collections.Generic.IReadOnlyDictionary<string, object> requiredValues, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart> parameters, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> pathSegments) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Defaults { get { throw null; } }
        public decimal InboundPrecedence { get { throw null; } }
        public decimal OutboundPrecedence { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference>> ParameterPolicies { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart> Parameters { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> PathSegments { get { throw null; } }
        public string RawText { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> RequiredValues { get { throw null; } }
        internal string DebuggerToString() { throw null; }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart GetParameter(string name) { throw null; }
        internal static bool IsRequiredValueAny(object value) { throw null; }
    }
    public sealed partial class RoutePatternException : System.Exception
    {
        public RoutePatternException(string pattern, string message) { }
        public string Pattern { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public static partial class RoutePatternFactory
    {
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference Constraint(Microsoft.AspNetCore.Routing.IRouteConstraint constraint) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference Constraint(object constraint) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference Constraint(string constraint) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternLiteralPart LiteralPart(string content) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParameterPart(string parameterName) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParameterPart(string parameterName, object @default) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParameterPart(string parameterName, object @default, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind parameterKind) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParameterPart(string parameterName, object @default, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind parameterKind, params Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference[] parameterPolicies) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart ParameterPart(string parameterName, object @default, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind parameterKind, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference> parameterPolicies) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference ParameterPolicy(Microsoft.AspNetCore.Routing.IParameterPolicy parameterPolicy) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference ParameterPolicy(string parameterPolicy) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Parse(string pattern) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Parse(string pattern, object defaults, object parameterPolicies) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Parse(string pattern, object defaults, object parameterPolicies, object requiredValues) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(params Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment[] segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(object defaults, object parameterPolicies, params Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment[] segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(object defaults, object parameterPolicies, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(string rawText, params Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment[] segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(string rawText, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(string rawText, object defaults, object parameterPolicies, params Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment[] segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern(string rawText, object defaults, object parameterPolicies, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> segments) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment Segment(params Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart[] parts) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment Segment(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart> parts) { throw null; }
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePatternSeparatorPart SeparatorPart(string content) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePatternLiteralPart : Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart
    {
        internal RoutePatternLiteralPart(string content) : base (default(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind)) { }
        public string Content { get { throw null; } }
        internal override string DebuggerToString() { throw null; }
    }
    public enum RoutePatternParameterKind
    {
        Standard = 0,
        Optional = 1,
        CatchAll = 2,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePatternParameterPart : Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart
    {
        internal RoutePatternParameterPart(string parameterName, object @default, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind parameterKind, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference[] parameterPolicies) : base (default(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind)) { }
        internal RoutePatternParameterPart(string parameterName, object @default, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind parameterKind, Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference[] parameterPolicies, bool encodeSlashes) : base (default(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind)) { }
        public object Default { get { throw null; } }
        public bool EncodeSlashes { get { throw null; } }
        public bool IsCatchAll { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind ParameterKind { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference> ParameterPolicies { get { throw null; } }
        internal override string DebuggerToString() { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePatternParameterPolicyReference
    {
        internal RoutePatternParameterPolicyReference(Microsoft.AspNetCore.Routing.IParameterPolicy parameterPolicy) { }
        internal RoutePatternParameterPolicyReference(string content) { }
        public string Content { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IParameterPolicy ParameterPolicy { get { throw null; } }
    }
    internal static partial class RoutePatternParser
    {
        internal static readonly char[] InvalidParameterNameChars;
        public static Microsoft.AspNetCore.Routing.Patterns.RoutePattern Parse(string pattern) { throw null; }
    }
    public abstract partial class RoutePatternPart
    {
        private protected RoutePatternPart(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind partKind) { }
        public bool IsLiteral { get { throw null; } }
        public bool IsParameter { get { throw null; } }
        public bool IsSeparator { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind PartKind { get { throw null; } }
        internal abstract string DebuggerToString();
    }
    public enum RoutePatternPartKind
    {
        Literal = 0,
        Parameter = 1,
        Separator = 2,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePatternPathSegment
    {
        internal RoutePatternPathSegment(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart> parts) { }
        public bool IsSimple { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart> Parts { get { throw null; } }
        internal string DebuggerToString() { throw null; }
        internal static string DebuggerToString(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart> parts) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public sealed partial class RoutePatternSeparatorPart : Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart
    {
        internal RoutePatternSeparatorPart(string content) : base (default(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind)) { }
        public string Content { get { throw null; } }
        internal override string DebuggerToString() { throw null; }
    }
    public abstract partial class RoutePatternTransformer
    {
        protected RoutePatternTransformer() { }
        public abstract Microsoft.AspNetCore.Routing.Patterns.RoutePattern SubstituteRequiredValues(Microsoft.AspNetCore.Routing.Patterns.RoutePattern original, object requiredValues);
    }
}
namespace Microsoft.AspNetCore.Routing.Template
{
    internal sealed partial class DefaultTemplateBinderFactory : Microsoft.AspNetCore.Routing.Template.TemplateBinderFactory
    {
        public DefaultTemplateBinderFactory(Microsoft.AspNetCore.Routing.ParameterPolicyFactory policyFactory, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> pool) { }
        public override Microsoft.AspNetCore.Routing.Template.TemplateBinder Create(Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern) { throw null; }
        public override Microsoft.AspNetCore.Routing.Template.TemplateBinder Create(Microsoft.AspNetCore.Routing.Template.RouteTemplate template, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults) { throw null; }
    }
    public partial class InlineConstraint
    {
        public InlineConstraint(Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference other) { }
        public InlineConstraint(string constraint) { }
        public string Constraint { get { throw null; } }
    }
    public static partial class RoutePrecedence
    {
        internal static decimal ComputeInbound(Microsoft.AspNetCore.Routing.Patterns.RoutePattern routePattern) { throw null; }
        public static decimal ComputeInbound(Microsoft.AspNetCore.Routing.Template.RouteTemplate template) { throw null; }
        internal static decimal ComputeOutbound(Microsoft.AspNetCore.Routing.Patterns.RoutePattern routePattern) { throw null; }
        public static decimal ComputeOutbound(Microsoft.AspNetCore.Routing.Template.RouteTemplate template) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public partial class RouteTemplate
    {
        public RouteTemplate(Microsoft.AspNetCore.Routing.Patterns.RoutePattern other) { }
        public RouteTemplate(string template, System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Template.TemplateSegment> segments) { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.Template.TemplatePart> Parameters { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.Template.TemplateSegment> Segments { get { throw null; } }
        public string TemplateText { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Template.TemplatePart GetParameter(string name) { throw null; }
        public Microsoft.AspNetCore.Routing.Template.TemplateSegment GetSegment(int index) { throw null; }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePattern ToRoutePattern() { throw null; }
    }
    public partial class TemplateBinder
    {
        internal TemplateBinder(System.Text.Encodings.Web.UrlEncoder urlEncoder, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> pool, Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IEnumerable<string> requiredKeys, System.Collections.Generic.IEnumerable<(string parameterName, Microsoft.AspNetCore.Routing.IParameterPolicy policy)> parameterPolicies) { }
        internal TemplateBinder(System.Text.Encodings.Web.UrlEncoder urlEncoder, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> pool, Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern, System.Collections.Generic.IEnumerable<(string parameterName, Microsoft.AspNetCore.Routing.IParameterPolicy policy)> parameterPolicies) { }
        internal TemplateBinder(System.Text.Encodings.Web.UrlEncoder urlEncoder, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> pool, Microsoft.AspNetCore.Routing.Template.RouteTemplate template, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults) { }
        public string BindValues(Microsoft.AspNetCore.Routing.RouteValueDictionary acceptedValues) { throw null; }
        public Microsoft.AspNetCore.Routing.Template.TemplateValuesResult GetValues(Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
        public static bool RoutePartsEqual(object a, object b) { throw null; }
        internal bool TryBindValues(Microsoft.AspNetCore.Routing.RouteValueDictionary acceptedValues, Microsoft.AspNetCore.Routing.LinkOptions options, Microsoft.AspNetCore.Routing.LinkOptions globalOptions, out (Microsoft.AspNetCore.Http.PathString path, Microsoft.AspNetCore.Http.QueryString query) result) { throw null; }
        public bool TryProcessConstraints(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteValueDictionary combinedValues, out string parameterName, out Microsoft.AspNetCore.Routing.IRouteConstraint constraint) { throw null; }
    }
    public abstract partial class TemplateBinderFactory
    {
        protected TemplateBinderFactory() { }
        public abstract Microsoft.AspNetCore.Routing.Template.TemplateBinder Create(Microsoft.AspNetCore.Routing.Patterns.RoutePattern pattern);
        public abstract Microsoft.AspNetCore.Routing.Template.TemplateBinder Create(Microsoft.AspNetCore.Routing.Template.RouteTemplate template, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults);
    }
    public partial class TemplateMatcher
    {
        public TemplateMatcher(Microsoft.AspNetCore.Routing.Template.RouteTemplate template, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults) { }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Defaults { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Template.RouteTemplate Template { get { throw null; } }
        public bool TryMatch(Microsoft.AspNetCore.Http.PathString path, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
    }
    public static partial class TemplateParser
    {
        public static Microsoft.AspNetCore.Routing.Template.RouteTemplate Parse(string routeTemplate) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public partial class TemplatePart
    {
        public TemplatePart() { }
        public TemplatePart(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart other) { }
        public object DefaultValue { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Template.InlineConstraint> InlineConstraints { get { throw null; } }
        public bool IsCatchAll { get { throw null; } }
        public bool IsLiteral { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public bool IsOptionalSeperator { get { throw null; } set { } }
        public bool IsParameter { get { throw null; } }
        public string Name { get { throw null; } }
        public string Text { get { throw null; } }
        public static Microsoft.AspNetCore.Routing.Template.TemplatePart CreateLiteral(string text) { throw null; }
        public static Microsoft.AspNetCore.Routing.Template.TemplatePart CreateParameter(string name, bool isCatchAll, bool isOptional, object defaultValue, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Template.InlineConstraint> inlineConstraints) { throw null; }
        internal string DebuggerToString() { throw null; }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart ToRoutePatternPart() { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public partial class TemplateSegment
    {
        public TemplateSegment() { }
        public TemplateSegment(Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment other) { }
        public bool IsSimple { get { throw null; } }
        public System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Template.TemplatePart> Parts { get { throw null; } }
        internal string DebuggerToString() { throw null; }
        public Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment ToRoutePatternPathSegment() { throw null; }
    }
    public partial class TemplateValuesResult
    {
        public TemplateValuesResult() { }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary AcceptedValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary CombinedValues { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Routing.Tree
{
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public partial class InboundMatch
    {
        public InboundMatch() { }
        public Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry Entry { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Template.TemplateMatcher TemplateMatcher { get { throw null; } set { } }
    }
    public partial class InboundRouteEntry
    {
        public InboundRouteEntry() { }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> Constraints { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Defaults { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.IRouter Handler { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public decimal Precedence { get { throw null; } set { } }
        public string RouteName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Template.RouteTemplate RouteTemplate { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString,nq}")]
    internal partial class LinkGenerationDecisionTree
    {
        public LinkGenerationDecisionTree(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Tree.OutboundMatch> entries) { }
        internal string DebuggerDisplayString { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.Tree.OutboundMatchResult> GetMatches(Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues) { throw null; }
    }
    public partial class OutboundMatch
    {
        public OutboundMatch() { }
        public Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry Entry { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Template.TemplateBinder TemplateBinder { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct OutboundMatchResult
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OutboundMatchResult(Microsoft.AspNetCore.Routing.Tree.OutboundMatch match, bool isFallbackMatch) { throw null; }
        public bool IsFallbackMatch { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Tree.OutboundMatch Match { get { throw null; } }
    }
    public partial class OutboundRouteEntry
    {
        public OutboundRouteEntry() { }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Routing.IRouteConstraint> Constraints { get { throw null; } set { } }
        public object Data { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Defaults { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.IRouter Handler { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public decimal Precedence { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RequiredLinkValues { get { throw null; } set { } }
        public string RouteName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Template.RouteTemplate RouteTemplate { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct TreeEnumerator : System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode>, System.Collections.IEnumerator, System.IDisposable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public TreeEnumerator(Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode root, Microsoft.AspNetCore.Routing.PathTokenizer tokenizer) { throw null; }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Dispose() { }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public partial class TreeRouteBuilder
    {
        internal TreeRouteBuilder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> objectPool, Microsoft.AspNetCore.Routing.IInlineConstraintResolver constraintResolver) { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry> InboundEntries { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry> OutboundEntries { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Tree.TreeRouter Build() { throw null; }
        public Microsoft.AspNetCore.Routing.Tree.TreeRouter Build(int version) { throw null; }
        public void Clear() { }
        public Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry MapInbound(Microsoft.AspNetCore.Routing.IRouter handler, Microsoft.AspNetCore.Routing.Template.RouteTemplate routeTemplate, string routeName, int order) { throw null; }
        public Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry MapOutbound(Microsoft.AspNetCore.Routing.IRouter handler, Microsoft.AspNetCore.Routing.Template.RouteTemplate routeTemplate, Microsoft.AspNetCore.Routing.RouteValueDictionary requiredLinkValues, string routeName, int order) { throw null; }
    }
    public partial class TreeRouter : Microsoft.AspNetCore.Routing.IRouter
    {
        public static readonly string RouteGroupKey;
        internal TreeRouter(Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree[] trees, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry> linkGenerationEntries, System.Text.Encodings.Web.UrlEncoder urlEncoder, Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Routing.UriBuildingContext> objectPool, Microsoft.Extensions.Logging.ILogger routeLogger, Microsoft.Extensions.Logging.ILogger constraintLogger, int version) { }
        internal System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree> MatchingTrees { get { throw null; } }
        public int Version { get { throw null; } }
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public partial class UrlMatchingNode
    {
        public UrlMatchingNode(int length) { }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode CatchAlls { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode ConstrainedCatchAlls { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode ConstrainedParameters { get { throw null; } set { } }
        public int Depth { get { throw null; } }
        public bool IsCatchAll { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode> Literals { get { throw null; } }
        public System.Collections.Generic.List<Microsoft.AspNetCore.Routing.Tree.InboundMatch> Matches { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode Parameters { get { throw null; } set { } }
    }
    public partial class UrlMatchingTree
    {
        public UrlMatchingTree(int order) { }
        public int Order { get { throw null; } }
        public Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode Root { get { throw null; } }
        internal void AddEntry(Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry entry) { }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    internal partial class ConfigureRouteOptions : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Routing.RouteOptions>
    {
        public ConfigureRouteOptions(System.Collections.Generic.ICollection<Microsoft.AspNetCore.Routing.EndpointDataSource> dataSources) { }
        public void Configure(Microsoft.AspNetCore.Routing.RouteOptions options) { }
    }
    public static partial class RoutingServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddRouting(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddRouting(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Routing.RouteOptions> configureOptions) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct HashCodeCombiner
    {
        private int _dummyPrimitive;
        public int CombinedHash { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(System.Collections.IEnumerable e) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(int i) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(object o) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(string s) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add<TValue>(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static implicit operator int (Microsoft.Extensions.Internal.HashCodeCombiner self) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static Microsoft.Extensions.Internal.HashCodeCombiner Start() { throw null; }
    }
    internal partial class PropertyHelper
    {
        public PropertyHelper(System.Reflection.PropertyInfo property) { }
        public virtual string Name { get { throw null; } protected set { } }
        public System.Reflection.PropertyInfo Property { get { throw null; } }
        public System.Func<object, object> ValueGetter { get { throw null; } }
        public System.Action<object, object> ValueSetter { get { throw null; } }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Reflection.TypeInfo typeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Type type) { throw null; }
        protected static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Type type, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyHelper> createPropertyHelper, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> cache) { throw null; }
        public object GetValue(object instance) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Reflection.TypeInfo typeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Type type) { throw null; }
        protected static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Type type, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyHelper> createPropertyHelper, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> allPropertiesCache, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> visiblePropertiesCache) { throw null; }
        public static System.Func<object, object> MakeFastPropertyGetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Action<object, object> MakeFastPropertySetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Func<object, object> MakeNullSafeFastPropertyGetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> ObjectToDictionary(object value) { throw null; }
        public void SetValue(object instance, object value) { }
    }
}
