// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Hosting
{
    internal static partial class ActivityExtensions
    {
        public static string GetParentId(this System.Diagnostics.Activity activity) { throw null; }
        public static string GetSpanId(this System.Diagnostics.Activity activity) { throw null; }
        public static string GetTraceId(this System.Diagnostics.Activity activity) { throw null; }
    }
    internal partial class ApplicationLifetime : Microsoft.AspNetCore.Hosting.IApplicationLifetime, Microsoft.Extensions.Hosting.IApplicationLifetime, Microsoft.Extensions.Hosting.IHostApplicationLifetime
    {
        public ApplicationLifetime(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Hosting.ApplicationLifetime> logger) { }
        public System.Threading.CancellationToken ApplicationStarted { get { throw null; } }
        public System.Threading.CancellationToken ApplicationStopped { get { throw null; } }
        public System.Threading.CancellationToken ApplicationStopping { get { throw null; } }
        public void NotifyStarted() { }
        public void NotifyStopped() { }
        public void StopApplication() { }
    }
    internal partial class ConfigureBuilder
    {
        public ConfigureBuilder(System.Reflection.MethodInfo configure) { }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> Build(object instance) { throw null; }
    }
    internal partial class ConfigureContainerBuilder
    {
        public ConfigureContainerBuilder(System.Reflection.MethodInfo configureContainerMethod) { }
        public System.Func<System.Action<object>, System.Action<object>> ConfigureContainerFilters { get { throw null; } set { } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public System.Action<object> Build(object instance) { throw null; }
        public System.Type GetContainerType() { throw null; }
    }
    internal partial class ConfigureServicesBuilder
    {
        public ConfigureServicesBuilder(System.Reflection.MethodInfo configureServices) { }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public System.Func<System.Func<Microsoft.Extensions.DependencyInjection.IServiceCollection, System.IServiceProvider>, System.Func<Microsoft.Extensions.DependencyInjection.IServiceCollection, System.IServiceProvider>> StartupServiceFilters { get { throw null; } set { } }
        public System.Func<Microsoft.Extensions.DependencyInjection.IServiceCollection, System.IServiceProvider> Build(object instance) { throw null; }
    }
    internal partial class ConventionBasedStartup : Microsoft.AspNetCore.Hosting.IStartup
    {
        public ConventionBasedStartup(Microsoft.AspNetCore.Hosting.StartupMethods methods) { }
        public void Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder app) { }
        public System.IServiceProvider ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
    public partial class DelegateStartup : Microsoft.AspNetCore.Hosting.StartupBase<Microsoft.Extensions.DependencyInjection.IServiceCollection>
    {
        public DelegateStartup(Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<Microsoft.Extensions.DependencyInjection.IServiceCollection> factory, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configureApp) : base (default(Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<Microsoft.Extensions.DependencyInjection.IServiceCollection>)) { }
        public override void Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder app) { }
    }
    internal partial class GenericWebHostApplicationLifetime : Microsoft.AspNetCore.Hosting.IApplicationLifetime
    {
        public GenericWebHostApplicationLifetime(Microsoft.Extensions.Hosting.IHostApplicationLifetime applicationLifetime) { }
        public System.Threading.CancellationToken ApplicationStarted { get { throw null; } }
        public System.Threading.CancellationToken ApplicationStopped { get { throw null; } }
        public System.Threading.CancellationToken ApplicationStopping { get { throw null; } }
        public void StopApplication() { }
    }
    internal partial class GenericWebHostBuilder : Microsoft.AspNetCore.Hosting.ISupportsStartup, Microsoft.AspNetCore.Hosting.ISupportsUseDefaultServiceProvider, Microsoft.AspNetCore.Hosting.IWebHostBuilder
    {
        public GenericWebHostBuilder(Microsoft.Extensions.Hosting.IHostBuilder builder) { }
        public Microsoft.AspNetCore.Hosting.IWebHost Build() { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder Configure(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.AspNetCore.Builder.IApplicationBuilder> configure) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureAppConfiguration(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public string GetSetting(string key) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseDefaultServiceProvider(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.ServiceProviderOptions> configure) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseSetting(string key, string value) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStartup(System.Type startupType) { throw null; }
    }
    internal partial class GenericWebHostService : Microsoft.Extensions.Hosting.IHostedService
    {
        public GenericWebHostService(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Hosting.GenericWebHostServiceOptions> options, Microsoft.AspNetCore.Hosting.Server.IServer server, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Http.IHttpContextFactory httpContextFactory, Microsoft.AspNetCore.Hosting.Builder.IApplicationBuilderFactory applicationBuilderFactory, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Hosting.IStartupFilter> startupFilters, Microsoft.Extensions.Configuration.IConfiguration configuration, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) { }
        public Microsoft.AspNetCore.Hosting.Builder.IApplicationBuilderFactory ApplicationBuilderFactory { get { throw null; } }
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get { throw null; } }
        public System.Diagnostics.DiagnosticListener DiagnosticListener { get { throw null; } }
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get { throw null; } }
        public Microsoft.AspNetCore.Http.IHttpContextFactory HttpContextFactory { get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger LifetimeLogger { get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        public Microsoft.AspNetCore.Hosting.GenericWebHostServiceOptions Options { get { throw null; } }
        public Microsoft.AspNetCore.Hosting.Server.IServer Server { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Hosting.IStartupFilter> StartupFilters { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class GenericWebHostServiceOptions
    {
        public GenericWebHostServiceOptions() { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> ConfigureApplication { get { throw null; } set { } }
        public System.AggregateException HostingStartupExceptions { get { throw null; } set { } }
        public Microsoft.AspNetCore.Hosting.WebHostOptions WebHostOptions { get { throw null; } set { } }
    }
    internal partial class HostedServiceExecutor
    {
        public HostedServiceExecutor(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Hosting.HostedServiceExecutor> logger, System.Collections.Generic.IEnumerable<Microsoft.Extensions.Hosting.IHostedService> services) { }
        public System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken token) { throw null; }
    }
    internal partial class HostingApplication : Microsoft.AspNetCore.Hosting.Server.IHttpApplication<Microsoft.AspNetCore.Hosting.HostingApplication.Context>
    {
        public HostingApplication(Microsoft.AspNetCore.Http.RequestDelegate application, Microsoft.Extensions.Logging.ILogger logger, System.Diagnostics.DiagnosticListener diagnosticSource, Microsoft.AspNetCore.Http.IHttpContextFactory httpContextFactory) { }
        public Microsoft.AspNetCore.Hosting.HostingApplication.Context CreateContext(Microsoft.AspNetCore.Http.Features.IFeatureCollection contextFeatures) { throw null; }
        public void DisposeContext(Microsoft.AspNetCore.Hosting.HostingApplication.Context context, System.Exception exception) { }
        public System.Threading.Tasks.Task ProcessRequestAsync(Microsoft.AspNetCore.Hosting.HostingApplication.Context context) { throw null; }
        internal partial class Context
        {
            public Context() { }
            public System.Diagnostics.Activity Activity { get { throw null; } set { } }
            public bool EventLogEnabled { get { throw null; } set { } }
            internal bool HasDiagnosticListener { get { throw null; } set { } }
            public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } set { } }
            public System.IDisposable Scope { get { throw null; } set { } }
            public long StartTimestamp { get { throw null; } set { } }
            public void Reset() { }
        }
    }
    internal partial class HostingApplicationDiagnostics
    {
        public HostingApplicationDiagnostics(Microsoft.Extensions.Logging.ILogger logger, System.Diagnostics.DiagnosticListener diagnosticListener) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void BeginRequest(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Hosting.HostingApplication.Context context) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void ContextDisposed(Microsoft.AspNetCore.Hosting.HostingApplication.Context context) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void RequestEnd(Microsoft.AspNetCore.Http.HttpContext httpContext, System.Exception exception, Microsoft.AspNetCore.Hosting.HostingApplication.Context context) { }
    }
    internal partial class HostingEnvironment : Microsoft.AspNetCore.Hosting.IHostingEnvironment, Microsoft.AspNetCore.Hosting.IWebHostEnvironment, Microsoft.Extensions.Hosting.IHostEnvironment, Microsoft.Extensions.Hosting.IHostingEnvironment
    {
        public HostingEnvironment() { }
        public string ApplicationName { get { throw null; } set { } }
        public Microsoft.Extensions.FileProviders.IFileProvider ContentRootFileProvider { get { throw null; } set { } }
        public string ContentRootPath { get { throw null; } set { } }
        public string EnvironmentName { get { throw null; } set { } }
        public Microsoft.Extensions.FileProviders.IFileProvider WebRootFileProvider { get { throw null; } set { } }
        public string WebRootPath { get { throw null; } set { } }
    }
    internal static partial class HostingEnvironmentExtensions
    {
        internal static void Initialize(this Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, string contentRootPath, Microsoft.AspNetCore.Hosting.WebHostOptions options) { }
        internal static void Initialize(this Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, string contentRootPath, Microsoft.AspNetCore.Hosting.WebHostOptions options) { }
    }
    internal sealed partial class HostingEventSource : System.Diagnostics.Tracing.EventSource
    {
        public static readonly Microsoft.AspNetCore.Hosting.HostingEventSource Log;
        internal HostingEventSource() { }
        internal HostingEventSource(string eventSourceName) { }
        [System.Diagnostics.Tracing.EventAttribute(1, Level=System.Diagnostics.Tracing.EventLevel.Informational)]
        public void HostStart() { }
        [System.Diagnostics.Tracing.EventAttribute(2, Level=System.Diagnostics.Tracing.EventLevel.Informational)]
        public void HostStop() { }
        protected override void OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs command) { }
        internal void RequestFailed() { }
        [System.Diagnostics.Tracing.EventAttribute(3, Level=System.Diagnostics.Tracing.EventLevel.Informational)]
        public void RequestStart(string method, string path) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Diagnostics.Tracing.EventAttribute(4, Level=System.Diagnostics.Tracing.EventLevel.Informational)]
        public void RequestStop() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Diagnostics.Tracing.EventAttribute(5, Level=System.Diagnostics.Tracing.EventLevel.Error)]
        public void UnhandledException() { }
    }
    internal static partial class HostingLoggerExtensions
    {
        public static void ApplicationError(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, System.Exception exception) { }
        public static void ApplicationError(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void HostingStartupAssemblyError(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static System.IDisposable RequestScope(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Http.HttpContext httpContext, System.Diagnostics.Activity activity) { throw null; }
        public static void ServerShutdownException(this Microsoft.Extensions.Logging.ILogger logger, System.Exception ex) { }
        public static void Shutdown(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void Started(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void Starting(this Microsoft.Extensions.Logging.ILogger logger) { }
    }
    internal partial class HostingRequestFinishedLog : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        internal static readonly System.Func<object, System.Exception, string> Callback;
        public HostingRequestFinishedLog(Microsoft.AspNetCore.Http.HttpContext httpContext, System.TimeSpan elapsed) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    internal partial class HostingRequestStartingLog : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        internal static readonly System.Func<object, System.Exception, string> Callback;
        public HostingRequestStartingLog(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    internal partial class HostingStartupWebHostBuilder : Microsoft.AspNetCore.Hosting.ISupportsStartup, Microsoft.AspNetCore.Hosting.ISupportsUseDefaultServiceProvider, Microsoft.AspNetCore.Hosting.IWebHostBuilder
    {
        public HostingStartupWebHostBuilder(Microsoft.AspNetCore.Hosting.GenericWebHostBuilder builder) { }
        public Microsoft.AspNetCore.Hosting.IWebHost Build() { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder Configure(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.AspNetCore.Builder.IApplicationBuilder> configure) { throw null; }
        public void ConfigureAppConfiguration(Microsoft.AspNetCore.Hosting.WebHostBuilderContext context, Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureAppConfiguration(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate) { throw null; }
        public void ConfigureServices(Microsoft.AspNetCore.Hosting.WebHostBuilderContext context, Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public string GetSetting(string key) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseDefaultServiceProvider(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.ServiceProviderOptions> configure) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseSetting(string key, string value) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStartup(System.Type startupType) { throw null; }
    }
    internal partial interface ISupportsStartup
    {
        Microsoft.AspNetCore.Hosting.IWebHostBuilder Configure(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.AspNetCore.Builder.IApplicationBuilder> configure);
        Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStartup(System.Type startupType);
    }
    internal partial interface ISupportsUseDefaultServiceProvider
    {
        Microsoft.AspNetCore.Hosting.IWebHostBuilder UseDefaultServiceProvider(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.ServiceProviderOptions> configure);
    }
    internal static partial class LoggerEventIds
    {
        public const int ApplicationStartupException = 6;
        public const int ApplicationStoppedException = 8;
        public const int ApplicationStoppingException = 7;
        public const int HostedServiceStartException = 9;
        public const int HostedServiceStopException = 10;
        public const int HostingStartupAssemblyException = 11;
        public const int RequestFinished = 2;
        public const int RequestStarting = 1;
        public const int ServerShutdownException = 12;
        public const int Shutdown = 5;
        public const int Started = 4;
        public const int Starting = 3;
    }
    internal static partial class MethodInfoExtensions
    {
        public static object InvokeWithoutWrappingExceptions(this System.Reflection.MethodInfo methodInfo, object obj, object[] parameters) { throw null; }
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string WebHostBuilder_SingleInstance { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    internal static partial class ServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection Clone(this Microsoft.Extensions.DependencyInjection.IServiceCollection serviceCollection) { throw null; }
    }
    public abstract partial class StartupBase : Microsoft.AspNetCore.Hosting.IStartup
    {
        protected StartupBase() { }
        public abstract void Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder app);
        public virtual void ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public virtual System.IServiceProvider CreateServiceProvider(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        System.IServiceProvider Microsoft.AspNetCore.Hosting.IStartup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
    public abstract partial class StartupBase<TBuilder> : Microsoft.AspNetCore.Hosting.StartupBase
    {
        public StartupBase(Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<TBuilder> factory) { }
        public virtual void ConfigureContainer(TBuilder builder) { }
        public override System.IServiceProvider CreateServiceProvider(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
    internal partial class StartupLoader
    {
        public StartupLoader() { }
        internal static Microsoft.AspNetCore.Hosting.ConfigureContainerBuilder FindConfigureContainerDelegate(System.Type startupType, string environmentName) { throw null; }
        internal static Microsoft.AspNetCore.Hosting.ConfigureBuilder FindConfigureDelegate(System.Type startupType, string environmentName) { throw null; }
        internal static Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder FindConfigureServicesDelegate(System.Type startupType, string environmentName) { throw null; }
        public static System.Type FindStartupType(string startupAssemblyName, string environmentName) { throw null; }
        internal static bool HasConfigureServicesIServiceProviderDelegate(System.Type startupType, string environmentName) { throw null; }
        public static Microsoft.AspNetCore.Hosting.StartupMethods LoadMethods(System.IServiceProvider hostingServiceProvider, System.Type startupType, string environmentName) { throw null; }
    }
    internal partial class StartupMethods
    {
        public StartupMethods(object instance, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configure, System.Func<Microsoft.Extensions.DependencyInjection.IServiceCollection, System.IServiceProvider> configureServices) { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> ConfigureDelegate { get { throw null; } }
        public System.Func<Microsoft.Extensions.DependencyInjection.IServiceCollection, System.IServiceProvider> ConfigureServicesDelegate { get { throw null; } }
        public object StartupInstance { get { throw null; } }
    }
    internal partial class WebHost : Microsoft.AspNetCore.Hosting.IWebHost, System.IAsyncDisposable, System.IDisposable
    {
        public WebHost(Microsoft.Extensions.DependencyInjection.IServiceCollection appServices, System.IServiceProvider hostingServiceProvider, Microsoft.AspNetCore.Hosting.WebHostOptions options, Microsoft.Extensions.Configuration.IConfiguration config, System.AggregateException hostingStartupErrors) { }
        internal Microsoft.AspNetCore.Hosting.WebHostOptions Options { get { throw null; } }
        public Microsoft.AspNetCore.Http.Features.IFeatureCollection ServerFeatures { get { throw null; } }
        public System.IServiceProvider Services { get { throw null; } }
        public void Dispose() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public void Initialize() { }
        public void Start() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WebHostBuilder : Microsoft.AspNetCore.Hosting.IWebHostBuilder
    {
        public WebHostBuilder() { }
        public Microsoft.AspNetCore.Hosting.IWebHost Build() { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureAppConfiguration(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureServices(System.Action<Microsoft.Extensions.DependencyInjection.IServiceCollection> configureServices) { throw null; }
        public string GetSetting(string key) { throw null; }
        public Microsoft.AspNetCore.Hosting.IWebHostBuilder UseSetting(string key, string value) { throw null; }
    }
    public static partial class WebHostBuilderExtensions
    {
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder Configure(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configureApp) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder Configure(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.AspNetCore.Builder.IApplicationBuilder> configureApp) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureAppConfiguration(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureLogging(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.Logging.ILoggingBuilder> configureLogging) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder ConfigureLogging(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.Extensions.Logging.ILoggingBuilder> configureLogging) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseDefaultServiceProvider(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Hosting.WebHostBuilderContext, Microsoft.Extensions.DependencyInjection.ServiceProviderOptions> configure) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseDefaultServiceProvider(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.Extensions.DependencyInjection.ServiceProviderOptions> configure) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStartup(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Type startupType) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStartup<TStartup>(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder) where TStartup : class { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseStaticWebAssets(this Microsoft.AspNetCore.Hosting.IWebHostBuilder builder) { throw null; }
    }
    public static partial class WebHostExtensions
    {
        public static void Run(this Microsoft.AspNetCore.Hosting.IWebHost host) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task RunAsync(this Microsoft.AspNetCore.Hosting.IWebHost host, System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task StopAsync(this Microsoft.AspNetCore.Hosting.IWebHost host, System.TimeSpan timeout) { throw null; }
        public static void WaitForShutdown(this Microsoft.AspNetCore.Hosting.IWebHost host) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task WaitForShutdownAsync(this Microsoft.AspNetCore.Hosting.IWebHost host, System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class WebHostLifetime : System.IDisposable
    {
        public WebHostLifetime(System.Threading.CancellationTokenSource cts, System.Threading.ManualResetEventSlim resetEvent, string shutdownMessage) { }
        public void Dispose() { }
        internal void SetExitedGracefully() { }
    }
    internal partial class WebHostOptions
    {
        public WebHostOptions() { }
        public WebHostOptions(Microsoft.Extensions.Configuration.IConfiguration configuration) { }
        public WebHostOptions(Microsoft.Extensions.Configuration.IConfiguration configuration, string applicationNameFallback) { }
        public string ApplicationName { get { throw null; } set { } }
        public bool CaptureStartupErrors { get { throw null; } set { } }
        public string ContentRootPath { get { throw null; } set { } }
        public bool DetailedErrors { get { throw null; } set { } }
        public string Environment { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> HostingStartupAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> HostingStartupExcludeAssemblies { get { throw null; } set { } }
        public bool PreventHostingStartup { get { throw null; } set { } }
        public System.TimeSpan ShutdownTimeout { get { throw null; } set { } }
        public string StartupAssembly { get { throw null; } set { } }
        public bool SuppressStatusMessages { get { throw null; } set { } }
        public string WebRoot { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> GetFinalHostingStartupAssemblies() { throw null; }
    }
    internal partial class WebHostUtilities
    {
        public WebHostUtilities() { }
        public static bool ParseBool(Microsoft.Extensions.Configuration.IConfiguration configuration, string key) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Hosting.Builder
{
    public partial class ApplicationBuilderFactory : Microsoft.AspNetCore.Hosting.Builder.IApplicationBuilderFactory
    {
        public ApplicationBuilderFactory(System.IServiceProvider serviceProvider) { }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder CreateBuilder(Microsoft.AspNetCore.Http.Features.IFeatureCollection serverFeatures) { throw null; }
    }
    public partial interface IApplicationBuilderFactory
    {
        Microsoft.AspNetCore.Builder.IApplicationBuilder CreateBuilder(Microsoft.AspNetCore.Http.Features.IFeatureCollection serverFeatures);
    }
}
namespace Microsoft.AspNetCore.Hosting.Server.Features
{
    public partial class ServerAddressesFeature : Microsoft.AspNetCore.Hosting.Server.Features.IServerAddressesFeature
    {
        public ServerAddressesFeature() { }
        public System.Collections.Generic.ICollection<string> Addresses { get { throw null; } }
        public bool PreferHostingUrls { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Hosting.StaticWebAssets
{
    internal partial class StaticWebAssetsFileProvider : Microsoft.Extensions.FileProviders.IFileProvider
    {
        public StaticWebAssetsFileProvider(string pathPrefix, string contentRoot) { }
        public Microsoft.AspNetCore.Http.PathString BasePath { get { throw null; } }
        public Microsoft.Extensions.FileProviders.PhysicalFileProvider InnerProvider { get { throw null; } }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string filter) { throw null; }
    }
    public partial class StaticWebAssetsLoader
    {
        internal const string StaticWebAssetsManifestName = "Microsoft.AspNetCore.StaticWebAssets.xml";
        public StaticWebAssetsLoader() { }
        internal static string GetAssemblyLocation(System.Reflection.Assembly assembly) { throw null; }
        internal static System.IO.Stream ResolveManifest(Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment, Microsoft.Extensions.Configuration.IConfiguration configuration) { throw null; }
        public static void UseStaticWebAssets(Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment, Microsoft.Extensions.Configuration.IConfiguration configuration) { }
        internal static void UseStaticWebAssetsCore(Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment, System.IO.Stream manifest) { }
    }
    internal static partial class StaticWebAssetsReader
    {
        internal static System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Hosting.StaticWebAssets.StaticWebAssetsReader.ContentRootMapping> Parse(System.IO.Stream manifest) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal readonly partial struct ContentRootMapping
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public ContentRootMapping(string basePath, string path) { throw null; }
            public string BasePath { get { throw null; } }
            public string Path { get { throw null; } }
        }
    }
}
namespace Microsoft.AspNetCore.Hosting.Views
{
    internal partial class ErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
        public ErrorPage(Microsoft.AspNetCore.Hosting.Views.ErrorPageModel model) { }
        public Microsoft.AspNetCore.Hosting.Views.ErrorPageModel Model { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
    internal partial class ErrorPageModel
    {
        public ErrorPageModel() { }
        public string ClrVersion { get { throw null; } set { } }
        public string CurrentAssemblyVesion { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> ErrorDetails { get { throw null; } set { } }
        public string OperatingSystemDescription { get { throw null; } set { } }
        public string RuntimeArchitecture { get { throw null; } set { } }
        public string RuntimeDisplayName { get { throw null; } set { } }
        public bool ShowRuntimeDetails { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Http
{
    public partial class DefaultHttpContextFactory : Microsoft.AspNetCore.Http.IHttpContextFactory
    {
        public DefaultHttpContextFactory(System.IServiceProvider serviceProvider) { }
        internal Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext Create(Microsoft.AspNetCore.Http.Features.IFeatureCollection featureCollection) { throw null; }
        internal void Dispose(Microsoft.AspNetCore.Http.DefaultHttpContext httpContext) { }
        public void Dispose(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal void Initialize(Microsoft.AspNetCore.Http.DefaultHttpContext httpContext, Microsoft.AspNetCore.Http.Features.IFeatureCollection featureCollection) { }
    }
}
namespace Microsoft.Extensions.Hosting
{
    public static partial class GenericHostWebHostBuilderExtensions
    {
        public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureWebHost(this Microsoft.Extensions.Hosting.IHostBuilder builder, System.Action<Microsoft.AspNetCore.Hosting.IWebHostBuilder> configure) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal partial class TypeNameHelper
    {
        public TypeNameHelper() { }
        public static string GetTypeDisplayName(object item, bool fullName = true) { throw null; }
        public static string GetTypeDisplayName(System.Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+') { throw null; }
    }
}
namespace Microsoft.Extensions.RazorViews
{
    internal partial class AttributeValue
    {
        public AttributeValue(string prefix, object value, bool literal) { }
        public bool Literal { get { throw null; } }
        public string Prefix { get { throw null; } }
        public object Value { get { throw null; } }
        public static Microsoft.Extensions.RazorViews.AttributeValue FromTuple(System.Tuple<string, object, bool> value) { throw null; }
        public static Microsoft.Extensions.RazorViews.AttributeValue FromTuple(System.Tuple<string, string, bool> value) { throw null; }
        public static implicit operator Microsoft.Extensions.RazorViews.AttributeValue (System.Tuple<string, object, bool> value) { throw null; }
    }
    internal abstract partial class BaseView
    {
        protected BaseView() { }
        protected Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        protected System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } set { } }
        protected System.Text.Encodings.Web.JavaScriptEncoder JavaScriptEncoder { get { throw null; } set { } }
        protected System.IO.TextWriter Output { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        protected System.Text.Encodings.Web.UrlEncoder UrlEncoder { get { throw null; } set { } }
        protected void BeginWriteAttribute(string name, string begining, int startPosition, string ending, int endPosition, int thingy) { }
        protected void EndWriteAttribute() { }
        public abstract System.Threading.Tasks.Task ExecuteAsync();
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(System.IO.Stream stream) { throw null; }
        protected string HtmlEncodeAndReplaceLineBreaks(string input) { throw null; }
        protected virtual System.IO.TextWriter PopWriter() { throw null; }
        protected virtual void PushWriter(System.IO.TextWriter writer) { }
        protected void Write(Microsoft.Extensions.RazorViews.HelperResult result) { }
        protected void Write(object value) { }
        protected void Write(string value) { }
        protected void WriteAttribute(string name, string leader, string trailer, params Microsoft.Extensions.RazorViews.AttributeValue[] values) { }
        protected void WriteAttributeValue(string thingy, int startPostion, object value, int endValue, int dealyo, bool yesno) { }
        protected void WriteLiteral(object value) { }
        protected void WriteLiteral(string value) { }
    }
    internal partial class HelperResult
    {
        public HelperResult(System.Action<System.IO.TextWriter> action) { }
        public System.Action<System.IO.TextWriter> WriteAction { get { throw null; } }
        public void WriteTo(System.IO.TextWriter writer) { }
    }
}
namespace Microsoft.Extensions.StackTrace.Sources
{
    internal partial class ExceptionDetails
    {
        public ExceptionDetails() { }
        public System.Exception Error { get { throw null; } set { } }
        public string ErrorMessage { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo> StackFrames { get { throw null; } set { } }
    }
    internal partial class ExceptionDetailsProvider
    {
        public ExceptionDetailsProvider(Microsoft.Extensions.FileProviders.IFileProvider fileProvider, int sourceCodeLineCount) { }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> GetDetails(System.Exception exception) { throw null; }
        internal Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo GetStackFrameSourceCodeInfo(string method, string filePath, int lineNumber) { throw null; }
        internal void ReadFrameContent(Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo frame, System.Collections.Generic.IEnumerable<string> allLines, int errorStartLineNumberInFile, int errorEndLineNumberInFile) { }
    }
    internal partial class MethodDisplayInfo
    {
        public MethodDisplayInfo() { }
        public string DeclaringTypeName { get { throw null; } set { } }
        public string GenericArguments { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ParameterDisplayInfo> Parameters { get { throw null; } set { } }
        public string SubMethod { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    internal partial class ParameterDisplayInfo
    {
        public ParameterDisplayInfo() { }
        public string Name { get { throw null; } set { } }
        public string Prefix { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    internal partial class PortablePdbReader : System.IDisposable
    {
        public PortablePdbReader() { }
        public void Dispose() { }
        public void PopulateStackFrame(Microsoft.Extensions.StackTrace.Sources.StackFrameInfo frameInfo, System.Reflection.MethodBase method, int IlOffset) { }
    }
    internal partial class StackFrameInfo
    {
        public StackFrameInfo() { }
        public string FilePath { get { throw null; } set { } }
        public int LineNumber { get { throw null; } set { } }
        public Microsoft.Extensions.StackTrace.Sources.MethodDisplayInfo MethodDisplayInfo { get { throw null; } set { } }
        public System.Diagnostics.StackFrame StackFrame { get { throw null; } set { } }
    }
    internal partial class StackFrameSourceCodeInfo
    {
        public StackFrameSourceCodeInfo() { }
        public System.Collections.Generic.IEnumerable<string> ContextCode { get { throw null; } set { } }
        public string ErrorDetails { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string Function { get { throw null; } set { } }
        public int Line { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> PostContextCode { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> PreContextCode { get { throw null; } set { } }
        public int PreContextLine { get { throw null; } set { } }
    }
    internal partial class StackTraceHelper
    {
        public StackTraceHelper() { }
        public static System.Collections.Generic.IList<Microsoft.Extensions.StackTrace.Sources.StackFrameInfo> GetFrames(System.Exception exception) { throw null; }
        internal static Microsoft.Extensions.StackTrace.Sources.MethodDisplayInfo GetMethodDisplayString(System.Reflection.MethodBase method) { throw null; }
    }
}
