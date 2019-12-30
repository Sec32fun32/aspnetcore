// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class DeveloperExceptionPageExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDeveloperExceptionPage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDeveloperExceptionPage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.DeveloperExceptionPageOptions options) { throw null; }
    }
    public partial class DeveloperExceptionPageOptions
    {
        public DeveloperExceptionPageOptions() { }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } set { } }
        public int SourceCodeLineCount { get { throw null; } set { } }
    }
    public static partial class ExceptionHandlerExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseExceptionHandler(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseExceptionHandler(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.ExceptionHandlerOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseExceptionHandler(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configure) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseExceptionHandler(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string errorHandlingPath) { throw null; }
    }
    public partial class ExceptionHandlerOptions
    {
        public ExceptionHandlerOptions() { }
        public Microsoft.AspNetCore.Http.RequestDelegate ExceptionHandler { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.PathString ExceptionHandlingPath { get { throw null; } set { } }
    }
    public static partial class StatusCodePagesExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePages(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePages(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.StatusCodePagesOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePages(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configuration) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePages(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Func<Microsoft.AspNetCore.Diagnostics.StatusCodeContext, System.Threading.Tasks.Task> handler) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePages(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string contentType, string bodyFormat) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePagesWithRedirects(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string locationFormat) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStatusCodePagesWithReExecute(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string pathFormat, string queryFormat = null) { throw null; }
    }
    public partial class StatusCodePagesOptions
    {
        public StatusCodePagesOptions() { }
        public System.Func<Microsoft.AspNetCore.Diagnostics.StatusCodeContext, System.Threading.Tasks.Task> HandleAsync { get { throw null; } set { } }
    }
    public static partial class WelcomePageExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWelcomePage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWelcomePage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.WelcomePageOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWelcomePage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Http.PathString path) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWelcomePage(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string path) { throw null; }
    }
    public partial class WelcomePageOptions
    {
        public WelcomePageOptions() { }
        public Microsoft.AspNetCore.Http.PathString Path { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Diagnostics
{
    public partial class DeveloperExceptionPageMiddleware
    {
        public DeveloperExceptionPageMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.DeveloperExceptionPageOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, System.Diagnostics.DiagnosticSource diagnosticSource, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Diagnostics.IDeveloperPageExceptionFilter> filters) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    internal static partial class DiagnosticsLoggerExtensions
    {
        public static void DisplayErrorPageException(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ErrorHandlerException(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ResponseStartedErrorHandler(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ResponseStartedErrorPageMiddleware(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UnhandledException(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
    }
    public partial class ExceptionHandlerFeature : Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature, Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature
    {
        public ExceptionHandlerFeature() { }
        public System.Exception Error { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
    }
    public partial class ExceptionHandlerMiddleware
    {
        public ExceptionHandlerMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.ExceptionHandlerOptions> options, System.Diagnostics.DiagnosticListener diagnosticListener) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string DiagnosticsPageHtml_Information { get { throw null; } }
        internal static string DiagnosticsPageHtml_TestErrorMessage { get { throw null; } }
        internal static string DiagnosticsPageHtml_TestErrorSection { get { throw null; } }
        internal static string DiagnosticsPageHtml_Title { get { throw null; } }
        internal static string ErrorPageHtml_CompilationException { get { throw null; } }
        internal static string ErrorPageHtml_CookiesButton { get { throw null; } }
        internal static string ErrorPageHtml_Endpoint { get { throw null; } }
        internal static string ErrorPageHtml_EndpointDisplayName { get { throw null; } }
        internal static string ErrorPageHtml_EndpointRouteHttpMethod { get { throw null; } }
        internal static string ErrorPageHtml_EndpointRouteOrder { get { throw null; } }
        internal static string ErrorPageHtml_EndpointRoutePattern { get { throw null; } }
        internal static string ErrorPageHtml_HeadersButton { get { throw null; } }
        internal static string ErrorPageHtml_NameColumn { get { throw null; } }
        internal static string ErrorPageHtml_NoCookieData { get { throw null; } }
        internal static string ErrorPageHtml_NoEndpoint { get { throw null; } }
        internal static string ErrorPageHtml_NoHeaderData { get { throw null; } }
        internal static string ErrorPageHtml_NoQueryStringData { get { throw null; } }
        internal static string ErrorPageHtml_NoRouteValues { get { throw null; } }
        internal static string ErrorPageHtml_QueryButton { get { throw null; } }
        internal static string ErrorPageHtml_RouteValues { get { throw null; } }
        internal static string ErrorPageHtml_RoutingButton { get { throw null; } }
        internal static string ErrorPageHtml_StackButton { get { throw null; } }
        internal static string ErrorPageHtml_Title { get { throw null; } }
        internal static string ErrorPageHtml_UnhandledException { get { throw null; } }
        internal static string ErrorPageHtml_UnknownLocation { get { throw null; } }
        internal static string ErrorPageHtml_ValueColumn { get { throw null; } }
        internal static string ErrorPageHtml_VariableColumn { get { throw null; } }
        internal static string ExceptionHandlerOptions_NotConfiguredCorrectly { get { throw null; } }
        internal static string Exception_PathMustStartWithSlash { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string RuntimeInfoPage_Environment { get { throw null; } }
        internal static string RuntimeInfoPage_OperatingSystem { get { throw null; } }
        internal static string RuntimeInfoPage_OperatingSystemFail { get { throw null; } }
        internal static string RuntimeInfoPage_PackageNameColumnName { get { throw null; } }
        internal static string RuntimeInfoPage_PackagePathColumnName { get { throw null; } }
        internal static string RuntimeInfoPage_Packages { get { throw null; } }
        internal static string RuntimeInfoPage_PackagesFail { get { throw null; } }
        internal static string RuntimeInfoPage_PackageVersionColumnName { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeArchitecture { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeArchitectureFail { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeType { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeTypeFail { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeVersion { get { throw null; } }
        internal static string RuntimeInfoPage_RuntimeVersionFail { get { throw null; } }
        internal static string RuntimeInfoPage_Title { get { throw null; } }
        internal static string WelcomeHeader { get { throw null; } }
        internal static string WelcomeLearnMicrosoftAspNet { get { throw null; } }
        internal static string WelcomePageImageText_Browser { get { throw null; } }
        internal static string WelcomePageImageText_LearnMore { get { throw null; } }
        internal static string WelcomePageImageText_LightBulb { get { throw null; } }
        internal static string WelcomePageImageText_Skyline { get { throw null; } }
        internal static string WelcomeStarted { get { throw null; } }
        internal static string WelcomeTitle { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public partial class StatusCodeContext
    {
        public StatusCodeContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Builder.StatusCodePagesOptions options, Microsoft.AspNetCore.Http.RequestDelegate next) { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Http.RequestDelegate Next { get { throw null; } }
        public Microsoft.AspNetCore.Builder.StatusCodePagesOptions Options { get { throw null; } }
    }
    public partial class StatusCodePagesFeature : Microsoft.AspNetCore.Diagnostics.IStatusCodePagesFeature
    {
        public StatusCodePagesFeature() { }
        public bool Enabled { get { throw null; } set { } }
    }
    public partial class StatusCodePagesMiddleware
    {
        public StatusCodePagesMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.StatusCodePagesOptions> options) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class StatusCodeReExecuteFeature : Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature
    {
        public StatusCodeReExecuteFeature() { }
        public string OriginalPath { get { throw null; } set { } }
        public string OriginalPathBase { get { throw null; } set { } }
        public string OriginalQueryString { get { throw null; } set { } }
    }
    public partial class WelcomePageMiddleware
    {
        public WelcomePageMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.WelcomePageOptions> options) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Diagnostics.RazorViews
{
    internal partial class CompilationErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
        public CompilationErrorPage() { }
        public Microsoft.AspNetCore.Diagnostics.RazorViews.CompilationErrorPageModel Model { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
    internal partial class CompilationErrorPageModel
    {
        public CompilationErrorPageModel() { }
        public System.Collections.Generic.IList<string> CompiledContent { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> ErrorDetails { get { throw null; } }
        public Microsoft.AspNetCore.Builder.DeveloperExceptionPageOptions Options { get { throw null; } set { } }
    }
    internal partial class EndpointModel
    {
        public EndpointModel() { }
        public string DisplayName { get { throw null; } set { } }
        public string HttpMethods { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
        public string RoutePattern { get { throw null; } set { } }
    }
    internal partial class ErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
        public ErrorPage(Microsoft.AspNetCore.Diagnostics.RazorViews.ErrorPageModel model) { }
        public Microsoft.AspNetCore.Diagnostics.RazorViews.ErrorPageModel Model { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
    internal partial class ErrorPageModel
    {
        public ErrorPageModel() { }
        public Microsoft.AspNetCore.Http.IRequestCookieCollection Cookies { get { throw null; } set { } }
        public Microsoft.AspNetCore.Diagnostics.RazorViews.EndpointModel Endpoint { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> ErrorDetails { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> Headers { get { throw null; } set { } }
        public Microsoft.AspNetCore.Builder.DeveloperExceptionPageOptions Options { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IQueryCollection Query { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
    }
    internal partial class WelcomePage : Microsoft.Extensions.RazorViews.BaseView
    {
        public WelcomePage() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
}
namespace Microsoft.AspNetCore.Diagnostics.Views
{
    internal partial class WelcomePage : Microsoft.AspNetCore.DiagnosticsViewPage.Views.BaseView
    {
        public WelcomePage() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
}
namespace Microsoft.AspNetCore.DiagnosticsViewPage.Views
{
    internal partial class AttributeValue
    {
        public AttributeValue(string prefix, object value, bool literal) { }
        public bool Literal { get { throw null; } }
        public string Prefix { get { throw null; } }
        public object Value { get { throw null; } }
        public static Microsoft.AspNetCore.DiagnosticsViewPage.Views.AttributeValue FromTuple(System.Tuple<string, object, bool> value) { throw null; }
        public static Microsoft.AspNetCore.DiagnosticsViewPage.Views.AttributeValue FromTuple(System.Tuple<string, string, bool> value) { throw null; }
        public static implicit operator Microsoft.AspNetCore.DiagnosticsViewPage.Views.AttributeValue (System.Tuple<string, object, bool> value) { throw null; }
    }
    internal abstract partial class BaseView
    {
        protected BaseView() { }
        protected Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        protected System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } set { } }
        protected System.Text.Encodings.Web.JavaScriptEncoder JavaScriptEncoder { get { throw null; } set { } }
        protected System.IO.StreamWriter Output { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        protected System.Text.Encodings.Web.UrlEncoder UrlEncoder { get { throw null; } set { } }
        protected void BeginWriteAttribute(string name, string begining, int startPosition, string ending, int endPosition, int thingy) { }
        protected void EndWriteAttribute() { }
        public abstract System.Threading.Tasks.Task ExecuteAsync();
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        protected string HtmlEncodeAndReplaceLineBreaks(string input) { throw null; }
        protected void Write(Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult result) { }
        protected void Write(object value) { }
        protected void Write(string value) { }
        protected void WriteAttributeTo(System.IO.TextWriter writer, string name, string leader, string trailer, params Microsoft.AspNetCore.DiagnosticsViewPage.Views.AttributeValue[] values) { }
        protected void WriteAttributeValue(string thingy, int startPostion, object value, int endValue, int dealyo, bool yesno) { }
        protected void WriteLiteral(object value) { }
        protected void WriteLiteral(string value) { }
        protected void WriteLiteralTo(System.IO.TextWriter writer, object value) { }
        protected void WriteLiteralTo(System.IO.TextWriter writer, string value) { }
        protected void WriteTo(System.IO.TextWriter writer, object value) { }
        protected void WriteTo(System.IO.TextWriter writer, string value) { }
    }
    internal partial class HelperResult
    {
        public HelperResult(System.Action<System.IO.TextWriter> action) { }
        public System.Action<System.IO.TextWriter> WriteAction { get { throw null; } }
        public void WriteTo(System.IO.TextWriter writer) { }
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
