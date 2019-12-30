// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    public partial class CompiledRazorAssemblyApplicationPartFactory : Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartFactory
    {
        public CompiledRazorAssemblyApplicationPartFactory() { }
        public override System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetApplicationParts(System.Reflection.Assembly assembly) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetDefaultApplicationParts(System.Reflection.Assembly assembly) { throw null; }
    }
    public partial class CompiledRazorAssemblyPart : Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart, Microsoft.AspNetCore.Mvc.ApplicationParts.IRazorCompiledItemProvider
    {
        public CompiledRazorAssemblyPart(System.Reflection.Assembly assembly) { }
        public System.Reflection.Assembly Assembly { get { throw null; } }
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem> Microsoft.AspNetCore.Mvc.ApplicationParts.IRazorCompiledItemProvider.CompiledItems { get { throw null; } }
        public override string Name { get { throw null; } }
    }
    public partial interface IRazorCompiledItemProvider
    {
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem> CompiledItems { get; }
    }
    internal partial class RazorCompiledItemFeatureProvider : Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider, Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider<Microsoft.AspNetCore.Mvc.Razor.Compilation.ViewsFeature>
    {
        public RazorCompiledItemFeatureProvider() { }
        public void PopulateFeature(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> parts, Microsoft.AspNetCore.Mvc.Razor.Compilation.ViewsFeature feature) { }
    }
}
namespace Microsoft.AspNetCore.Mvc.Diagnostics
{
    public sealed partial class AfterViewPageEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.Razor.AfterViewPage";
        public AfterViewPageEventData(Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.IRazorPage Page { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
    }
    public sealed partial class BeforeViewPageEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.Razor.BeforeViewPage";
        public BeforeViewPageEventData(Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.IRazorPage Page { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.Razor
{
    internal partial class DefaultTagHelperFactory : Microsoft.AspNetCore.Mvc.Razor.ITagHelperFactory
    {
        public DefaultTagHelperFactory(Microsoft.AspNetCore.Mvc.Razor.ITagHelperActivator activator) { }
        public TTagHelper CreateTagHelper<TTagHelper>(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
    }
    public partial class HelperResult : Microsoft.AspNetCore.Html.IHtmlContent
    {
        public HelperResult(System.Func<System.IO.TextWriter, System.Threading.Tasks.Task> asyncAction) { }
        public System.Func<System.IO.TextWriter, System.Threading.Tasks.Task> WriteAction { get { throw null; } }
        public virtual void WriteTo(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { }
    }
    internal partial interface IModelTypeProvider
    {
        System.Type GetModelType();
    }
    public partial interface IRazorPage
    {
        Microsoft.AspNetCore.Html.IHtmlContent BodyContent { get; set; }
        bool IsLayoutBeingRendered { get; set; }
        string Layout { get; set; }
        string Path { get; set; }
        System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> PreviousSectionWriters { get; set; }
        System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> SectionWriters { get; }
        Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
        void EnsureRenderedBodyOrSections();
        System.Threading.Tasks.Task ExecuteAsync();
    }
    public partial interface IRazorPageActivator
    {
        void Activate(Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext context);
    }
    public partial interface IRazorPageFactoryProvider
    {
        Microsoft.AspNetCore.Mvc.Razor.RazorPageFactoryResult CreateFactory(string relativePath);
    }
    public partial interface IRazorViewEngine : Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine
    {
        Microsoft.AspNetCore.Mvc.Razor.RazorPageResult FindPage(Microsoft.AspNetCore.Mvc.ActionContext context, string pageName);
        string GetAbsolutePath(string executingFilePath, string pagePath);
        Microsoft.AspNetCore.Mvc.Razor.RazorPageResult GetPage(string executingFilePath, string pagePath);
    }
    public partial interface ITagHelperActivator
    {
        TTagHelper Create<TTagHelper>(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper;
    }
    public partial interface ITagHelperFactory
    {
        TTagHelper CreateTagHelper<TTagHelper>(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper;
    }
    public partial interface ITagHelperInitializer<TTagHelper> where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper
    {
        void Initialize(TTagHelper helper, Microsoft.AspNetCore.Mvc.Rendering.ViewContext context);
    }
    public partial interface IViewLocationExpander
    {
        System.Collections.Generic.IEnumerable<string> ExpandViewLocations(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context, System.Collections.Generic.IEnumerable<string> viewLocations);
        void PopulateValues(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context);
    }
    public partial class LanguageViewLocationExpander : Microsoft.AspNetCore.Mvc.Razor.IViewLocationExpander
    {
        public LanguageViewLocationExpander() { }
        public LanguageViewLocationExpander(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat format) { }
        public virtual System.Collections.Generic.IEnumerable<string> ExpandViewLocations(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context, System.Collections.Generic.IEnumerable<string> viewLocations) { throw null; }
        public void PopulateValues(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context) { }
    }
    public enum LanguageViewLocationExpanderFormat
    {
        SubFolder = 0,
        Suffix = 1,
    }
    internal static partial class MvcRazorDiagnosticListenerExtensions
    {
        public static void AfterViewPage(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        public static void BeforeViewPage(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
    }
    internal static partial class MvcRazorLoggerExtensions
    {
        public static void GeneratedCodeToAssemblyCompilationEnd(this Microsoft.Extensions.Logging.ILogger logger, string filePath, long startTimestamp) { }
        public static void GeneratedCodeToAssemblyCompilationStart(this Microsoft.Extensions.Logging.ILogger logger, string filePath) { }
        public static void PrecompiledViewFound(this Microsoft.Extensions.Logging.ILogger logger, string relativePath) { }
        public static void TagHelperComponentInitialized(this Microsoft.Extensions.Logging.ILogger logger, string componentName) { }
        public static void TagHelperComponentProcessed(this Microsoft.Extensions.Logging.ILogger logger, string componentName) { }
        public static void ViewCompilerCouldNotFindFileAtPath(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void ViewCompilerEndCodeGeneration(this Microsoft.Extensions.Logging.ILogger logger, string filePath, long startTimestamp) { }
        public static void ViewCompilerFoundFileToCompile(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void ViewCompilerInvalidingCompiledFile(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void ViewCompilerLocatedCompiledView(this Microsoft.Extensions.Logging.ILogger logger, string view) { }
        public static void ViewCompilerLocatedCompiledViewForPath(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void ViewCompilerNoCompiledViewsFound(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ViewCompilerStartCodeGeneration(this Microsoft.Extensions.Logging.ILogger logger, string filePath) { }
        public static void ViewLookupCacheHit(this Microsoft.Extensions.Logging.ILogger logger, string viewName, string controllerName) { }
        public static void ViewLookupCacheMiss(this Microsoft.Extensions.Logging.ILogger logger, string viewName, string controllerName) { }
    }
    internal static partial class RazorFileHierarchy
    {
        public static System.Collections.Generic.IEnumerable<string> GetViewStartPaths(string path) { throw null; }
    }
    public abstract partial class RazorPage : Microsoft.AspNetCore.Mvc.Razor.RazorPageBase
    {
        protected RazorPage() { }
        public Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        public override void BeginContext(int position, int length, bool isLiteral) { }
        public override void DefineSection(string name, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate section) { }
        public override void EndContext() { }
        public override void EnsureRenderedBodyOrSections() { }
        public void IgnoreBody() { }
        public void IgnoreSection(string sectionName) { }
        public bool IsSectionDefined(string name) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent RenderBody() { throw null; }
        public Microsoft.AspNetCore.Html.HtmlString RenderSection(string name) { throw null; }
        public Microsoft.AspNetCore.Html.HtmlString RenderSection(string name, bool required) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.HtmlString> RenderSectionAsync(string name) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.HtmlString> RenderSectionAsync(string name, bool required) { throw null; }
    }
    public partial class RazorPageActivator : Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator
    {
        public RazorPageActivator(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory, Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper jsonHelper, System.Diagnostics.DiagnosticSource diagnosticSource, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider modelExpressionProvider) { }
        public void Activate(Microsoft.AspNetCore.Mvc.Razor.IRazorPage page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { }
        internal Microsoft.AspNetCore.Mvc.Razor.RazorPagePropertyActivator GetOrAddCacheEntry(Microsoft.AspNetCore.Mvc.Razor.IRazorPage page) { throw null; }
    }
    public abstract partial class RazorPageBase : Microsoft.AspNetCore.Mvc.Razor.IRazorPage
    {
        protected RazorPageBase() { }
        public Microsoft.AspNetCore.Html.IHtmlContent BodyContent { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public System.Diagnostics.DiagnosticSource DiagnosticSource { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } set { } }
        public bool IsLayoutBeingRendered { get { throw null; } set { } }
        public string Layout { get { throw null; } set { } }
        public virtual System.IO.TextWriter Output { get { throw null; } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> PreviousSectionWriters { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> SectionWriters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } }
        public virtual System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
        public dynamic ViewBag { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public void AddHtmlAttributeValue(string prefix, int prefixOffset, object value, int valueOffset, int valueLength, bool isLiteral) { }
        public void BeginAddHtmlAttributeValues(Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext executionContext, string attributeName, int attributeValuesCount, Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle attributeValueStyle) { }
        public abstract void BeginContext(int position, int length, bool isLiteral);
        public virtual void BeginWriteAttribute(string name, string prefix, int prefixOffset, string suffix, int suffixOffset, int attributeValuesCount) { }
        public void BeginWriteTagHelperAttribute() { }
        public TTagHelper CreateTagHelper<TTagHelper>() where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
        public virtual void DefineSection(string name, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate section) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected void DefineSection(string name, System.Func<object, System.Threading.Tasks.Task> section) { }
        public void EndAddHtmlAttributeValues(Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext executionContext) { }
        public abstract void EndContext();
        public Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent EndTagHelperWritingScope() { throw null; }
        public virtual void EndWriteAttribute() { }
        public string EndWriteTagHelperAttribute() { throw null; }
        public abstract void EnsureRenderedBodyOrSections();
        public abstract System.Threading.Tasks.Task ExecuteAsync();
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.HtmlString> FlushAsync() { throw null; }
        public virtual string Href(string contentPath) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string InvalidTagHelperIndexerAssignment(string attributeName, string tagHelperTypeName, string propertyName) { throw null; }
        protected internal virtual System.IO.TextWriter PopWriter() { throw null; }
        protected internal virtual void PushWriter(System.IO.TextWriter writer) { }
        public virtual Microsoft.AspNetCore.Html.HtmlString SetAntiforgeryCookieAndHeader() { throw null; }
        public void StartTagHelperWritingScope(System.Text.Encodings.Web.HtmlEncoder encoder) { }
        public virtual void Write(object value) { }
        public virtual void Write(string value) { }
        public void WriteAttributeValue(string prefix, int prefixOffset, object value, int valueOffset, int valueLength, bool isLiteral) { }
        public virtual void WriteLiteral(object value) { }
        public virtual void WriteLiteral(string value) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RazorPageFactoryResult
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RazorPageFactoryResult(Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor viewDescriptor, System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> razorPageFactory) { throw null; }
        public System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> RazorPageFactory { get { throw null; } }
        public bool Success { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor ViewDescriptor { get { throw null; } }
    }
    internal partial class RazorPagePropertyActivator
    {
        public RazorPagePropertyActivator(System.Type pageType, System.Type declaredModelType, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.Razor.RazorPagePropertyActivator.PropertyValueAccessors propertyValueAccessors) { }
        public void Activate(object page, Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { }
        internal Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary CreateViewDataDictionary(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { throw null; }
        public partial class PropertyValueAccessors
        {
            public PropertyValueAccessors() { }
            public System.Func<Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> DiagnosticSourceAccessor { get { throw null; } set { } }
            public System.Func<Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> HtmlEncoderAccessor { get { throw null; } set { } }
            public System.Func<Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> JsonHelperAccessor { get { throw null; } set { } }
            public System.Func<Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> ModelExpressionProviderAccessor { get { throw null; } set { } }
            public System.Func<Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> UrlHelperAccessor { get { throw null; } set { } }
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RazorPageResult
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RazorPageResult(string name, Microsoft.AspNetCore.Mvc.Razor.IRazorPage page) { throw null; }
        public RazorPageResult(string name, System.Collections.Generic.IEnumerable<string> searchedLocations) { throw null; }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.IRazorPage Page { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> SearchedLocations { get { throw null; } }
    }
    public abstract partial class RazorPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage
    {
        protected RazorPage() { }
        public TModel Model { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> ViewData { get { throw null; } set { } }
    }
    public partial class RazorView : Microsoft.AspNetCore.Mvc.ViewEngines.IView
    {
        public RazorView(Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine viewEngine, Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator pageActivator, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> viewStartPages, Microsoft.AspNetCore.Mvc.Razor.IRazorPage razorPage, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.Diagnostics.DiagnosticListener diagnosticListener) { }
        internal System.Action<Microsoft.AspNetCore.Mvc.Razor.IRazorPage, Microsoft.AspNetCore.Mvc.Rendering.ViewContext> OnAfterPageActivated { get { throw null; } set { } }
        public string Path { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.IRazorPage RazorPage { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> ViewStartPages { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task RenderAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { throw null; }
    }
    public partial class RazorViewEngine : Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine, Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine
    {
        public static readonly string ViewExtension;
        public RazorViewEngine(Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider pageFactory, Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator pageActivator, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions> optionsAccessor, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Diagnostics.DiagnosticListener diagnosticListener) { }
        protected Microsoft.Extensions.Caching.Memory.IMemoryCache ViewLookupCache { get { throw null; } }
        internal Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheResult CreateCacheResult(System.Collections.Generic.HashSet<Microsoft.Extensions.Primitives.IChangeToken> expirationTokens, string relativePath, bool isMainPage) { throw null; }
        public Microsoft.AspNetCore.Mvc.Razor.RazorPageResult FindPage(Microsoft.AspNetCore.Mvc.ActionContext context, string pageName) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult FindView(Microsoft.AspNetCore.Mvc.ActionContext context, string viewName, bool isMainPage) { throw null; }
        public string GetAbsolutePath(string executingFilePath, string pagePath) { throw null; }
        public static string GetNormalizedRouteValue(Microsoft.AspNetCore.Mvc.ActionContext context, string key) { throw null; }
        public Microsoft.AspNetCore.Mvc.Razor.RazorPageResult GetPage(string executingFilePath, string pagePath) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage) { throw null; }
        internal System.Collections.Generic.IEnumerable<string> GetViewLocationFormats(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context) { throw null; }
    }
    public partial class RazorViewEngineOptions
    {
        public RazorViewEngineOptions() { }
        public System.Collections.Generic.IList<string> AreaPageViewLocationFormats { get { throw null; } }
        public System.Collections.Generic.IList<string> AreaViewLocationFormats { get { throw null; } }
        public System.Collections.Generic.IList<string> PageViewLocationFormats { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Razor.IViewLocationExpander> ViewLocationExpanders { get { throw null; } }
        public System.Collections.Generic.IList<string> ViewLocationFormats { get { throw null; } }
    }
    internal partial class RazorViewEngineOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>
    {
        public RazorViewEngineOptionsSetup() { }
        public void Configure(Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions options) { }
    }
    public delegate System.Threading.Tasks.Task RenderAsyncDelegate();
    internal static partial class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string CompilationFailed { get { throw null; } }
        internal static string Compilation_MissingReferences { get { throw null; } }
        internal static string CompiledViewDescriptor_NoData { get { throw null; } }
        internal static string CouldNotResolveApplicationRelativeUrl_TagHelper { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string FileProvidersAreRequired { get { throw null; } }
        internal static string FlushPointCannotBeInvoked { get { throw null; } }
        internal static string GeneratedCodeFileName { get { throw null; } }
        internal static string LayoutCannotBeLocated { get { throw null; } }
        internal static string LayoutCannotBeRendered { get { throw null; } }
        internal static string LayoutHasCircularReference { get { throw null; } }
        internal static string PropertyMustBeSet { get { throw null; } }
        internal static string RazorPage_CannotFlushWhileInAWritingScope { get { throw null; } }
        internal static string RazorPage_InvalidTagHelperIndexerAssignment { get { throw null; } }
        internal static string RazorPage_MethodCannotBeCalled { get { throw null; } }
        internal static string RazorPage_NestingAttributeWritingScopesNotSupported { get { throw null; } }
        internal static string RazorPage_ThereIsNoActiveWritingScopeToEnd { get { throw null; } }
        internal static string RazorProject_PathMustStartWithForwardSlash { get { throw null; } }
        internal static string RazorViewCompiler_ViewPathsDifferOnlyInCase { get { throw null; } }
        internal static string RenderBodyNotCalled { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string SectionAlreadyDefined { get { throw null; } }
        internal static string SectionAlreadyRendered { get { throw null; } }
        internal static string SectionNotDefined { get { throw null; } }
        internal static string SectionsNotRendered { get { throw null; } }
        internal static string UnsupportedDebugInformationFormat { get { throw null; } }
        internal static string ViewContextMustBeSet { get { throw null; } }
        internal static string ViewLocationFormatsIsRequired { get { throw null; } }
        internal static string FormatCompilation_MissingReferences(object p0) { throw null; }
        internal static string FormatCompiledViewDescriptor_NoData(object p0, object p1) { throw null; }
        internal static string FormatCouldNotResolveApplicationRelativeUrl_TagHelper(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        internal static string FormatFileProvidersAreRequired(object p0, object p1, object p2) { throw null; }
        internal static string FormatFlushPointCannotBeInvoked(object p0) { throw null; }
        internal static string FormatLayoutCannotBeLocated(object p0, object p1) { throw null; }
        internal static string FormatLayoutCannotBeRendered(object p0, object p1) { throw null; }
        internal static string FormatLayoutHasCircularReference(object p0, object p1) { throw null; }
        internal static string FormatPropertyMustBeSet(object p0, object p1) { throw null; }
        internal static string FormatRazorPage_CannotFlushWhileInAWritingScope(object p0, object p1) { throw null; }
        internal static string FormatRazorPage_InvalidTagHelperIndexerAssignment(object p0, object p1, object p2) { throw null; }
        internal static string FormatRazorPage_MethodCannotBeCalled(object p0, object p1) { throw null; }
        internal static string FormatRenderBodyNotCalled(object p0, object p1, object p2) { throw null; }
        internal static string FormatSectionAlreadyDefined(object p0) { throw null; }
        internal static string FormatSectionAlreadyRendered(object p0, object p1, object p2) { throw null; }
        internal static string FormatSectionNotDefined(object p0, object p1, object p2) { throw null; }
        internal static string FormatSectionsNotRendered(object p0, object p1, object p2) { throw null; }
        internal static string FormatUnsupportedDebugInformationFormat(object p0) { throw null; }
        internal static string FormatViewContextMustBeSet(object p0, object p1) { throw null; }
        internal static string FormatViewLocationFormatsIsRequired(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    internal partial class ServiceBasedTagHelperActivator : Microsoft.AspNetCore.Mvc.Razor.ITagHelperActivator
    {
        public ServiceBasedTagHelperActivator() { }
        public TTagHelper Create<TTagHelper>(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
    }
    internal partial class TagHelperComponentManager : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager
    {
        public TagHelperComponentManager(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent> tagHelperComponents) { }
        public System.Collections.Generic.ICollection<Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent> Components { get { throw null; } }
    }
    public partial class TagHelperInitializer<TTagHelper> : Microsoft.AspNetCore.Mvc.Razor.ITagHelperInitializer<TTagHelper> where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper
    {
        public TagHelperInitializer(System.Action<TTagHelper, Microsoft.AspNetCore.Mvc.Rendering.ViewContext> action) { }
        public void Initialize(TTagHelper helper, Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ViewLocationCacheItem
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ViewLocationCacheItem(System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> razorPageFactory, string location) { throw null; }
        public string Location { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage> PageFactory { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ViewLocationCacheKey : System.IEquatable<Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheKey>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ViewLocationCacheKey(string viewName, bool isMainPage) { throw null; }
        public ViewLocationCacheKey(string viewName, string controllerName, string areaName, string pageName, bool isMainPage, System.Collections.Generic.IReadOnlyDictionary<string, string> values) { throw null; }
        public string AreaName { get { throw null; } }
        public string ControllerName { get { throw null; } }
        public bool IsMainPage { get { throw null; } }
        public string PageName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> ViewLocationExpanderValues { get { throw null; } }
        public string ViewName { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheKey y) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    internal partial class ViewLocationCacheResult
    {
        public ViewLocationCacheResult(Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheItem view, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheItem> viewStarts) { }
        public ViewLocationCacheResult(System.Collections.Generic.IEnumerable<string> searchedLocations) { }
        public System.Collections.Generic.IEnumerable<string> SearchedLocations { get { throw null; } }
        public bool Success { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheItem ViewEntry { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Razor.ViewLocationCacheItem> ViewStartEntries { get { throw null; } }
    }
    public partial class ViewLocationExpanderContext
    {
        public ViewLocationExpanderContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, string viewName, string controllerName, string areaName, string pageName, bool isMainPage) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public string AreaName { get { throw null; } }
        public string ControllerName { get { throw null; } }
        public bool IsMainPage { get { throw null; } }
        public string PageName { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Values { get { throw null; } set { } }
        public string ViewName { get { throw null; } }
    }
    internal static partial class ViewPath
    {
        public static string NormalizePath(string path) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Razor.Compilation
{
    public partial class CompiledViewDescriptor
    {
        public CompiledViewDescriptor() { }
        public CompiledViewDescriptor(Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem item) { }
        public CompiledViewDescriptor(Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem item, Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute attribute) { }
        public System.Collections.Generic.IList<Microsoft.Extensions.Primitives.IChangeToken> ExpirationTokens { get { throw null; } set { } }
        public Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem Item { get { throw null; } set { } }
        public string RelativePath { get { throw null; } set { } }
        public System.Type Type { get { throw null; } }
        [System.ObsoleteAttribute("Use Item instead. RazorViewAttribute has been superseded by RazorCompiledItem and will not be used by the runtime.")]
        public Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute ViewAttribute { get { throw null; } set { } }
    }
    internal partial class DefaultRazorPageFactoryProvider : Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider
    {
        public DefaultRazorPageFactoryProvider(Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompilerProvider viewCompilerProvider) { }
        public Microsoft.AspNetCore.Mvc.Razor.RazorPageFactoryResult CreateFactory(string relativePath) { throw null; }
    }
    internal partial class DefaultViewCompiler : Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompiler
    {
        public DefaultViewCompiler(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor> compiledViews, Microsoft.Extensions.Logging.ILogger logger) { }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor> CompileAsync(string relativePath) { throw null; }
    }
    internal partial class DefaultViewCompilerProvider : Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompilerProvider
    {
        public DefaultViewCompilerProvider(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager applicationPartManager, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompiler GetCompiler() { throw null; }
    }
    public partial interface IViewCompiler
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor> CompileAsync(string relativePath);
    }
    public partial interface IViewCompilerProvider
    {
        Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompiler GetCompiler();
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    [System.ObsoleteAttribute("This attribute has been superseded by RazorCompiledItem and will not be used by the runtime.")]
    public partial class RazorViewAttribute : System.Attribute
    {
        public RazorViewAttribute(string path, System.Type viewType) { }
        public string Path { get { throw null; } }
        public System.Type ViewType { get { throw null; } }
    }
    public partial class ViewsFeature
    {
        public ViewsFeature() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor> ViewDescriptors { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.Razor.Infrastructure
{
    internal static partial class CryptographyAlgorithms
    {
        public static System.Security.Cryptography.SHA256 CreateSHA256() { throw null; }
    }
    internal partial class DefaultFileVersionProvider : Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider
    {
        public DefaultFileVersionProvider(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, Microsoft.AspNetCore.Mvc.Razor.Infrastructure.TagHelperMemoryCacheProvider cacheProvider) { }
        public Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } }
        public string AddFileVersionToPath(Microsoft.AspNetCore.Http.PathString requestPathBase, string path) { throw null; }
    }
    internal partial class DefaultTagHelperActivator : Microsoft.AspNetCore.Mvc.Razor.ITagHelperActivator
    {
        public DefaultTagHelperActivator(Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache typeActivatorCache) { }
        public TTagHelper Create<TTagHelper>(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
    }
    public sealed partial class TagHelperMemoryCacheProvider
    {
        public TagHelperMemoryCacheProvider() { }
        public Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } internal set { } }
    }
}
namespace Microsoft.AspNetCore.Mvc.Razor.Internal
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class RazorInjectAttribute : System.Attribute
    {
        public RazorInjectAttribute() { }
    }
}
namespace Microsoft.AspNetCore.Mvc.Razor.TagHelpers
{
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("body")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class BodyTagHelper : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.TagHelperComponentTagHelper
    {
        public BodyTagHelper(Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager manager, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("head")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class HeadTagHelper : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.TagHelperComponentTagHelper
    {
        public HeadTagHelper(Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager manager, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
    }
    public partial interface ITagHelperComponentManager
    {
        System.Collections.Generic.ICollection<Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent> Components { get; }
    }
    public partial interface ITagHelperComponentPropertyActivator
    {
        void Activate(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context, Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent tagHelperComponent);
    }
    internal partial class TagHelperComponentPropertyActivator : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentPropertyActivator
    {
        public TagHelperComponentPropertyActivator() { }
        public void Activate(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context, Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent tagHelperComponent) { }
    }
    public abstract partial class TagHelperComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public TagHelperComponentTagHelper(Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentManager manager, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Razor.TagHelpers.ITagHelperComponentPropertyActivator PropertyActivator { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Init(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    public partial class TagHelperFeature
    {
        public TagHelperFeature() { }
        public System.Collections.Generic.IList<System.Reflection.TypeInfo> TagHelpers { get { throw null; } }
    }
    public partial class TagHelperFeatureProvider : Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider, Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider<Microsoft.AspNetCore.Mvc.Razor.TagHelpers.TagHelperFeature>
    {
        public TagHelperFeatureProvider() { }
        protected virtual bool IncludePart(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart part) { throw null; }
        protected virtual bool IncludeType(System.Reflection.TypeInfo type) { throw null; }
        public void PopulateFeature(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> parts, Microsoft.AspNetCore.Mvc.Razor.TagHelpers.TagHelperFeature feature) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("*", Attributes="[itemid^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="[href^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("applet", Attributes="[archive^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("area", Attributes="[href^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("audio", Attributes="[src^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("base", Attributes="[href^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("blockquote", Attributes="[cite^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="[formaction^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("del", Attributes="[cite^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("embed", Attributes="[src^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("form", Attributes="[action^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("html", Attributes="[manifest^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("iframe", Attributes="[src^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("img", Attributes="[src^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("img", Attributes="[srcset^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[formaction^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[src^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("ins", Attributes="[cite^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="[href^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("menuitem", Attributes="[icon^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("object", Attributes="[archive^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("object", Attributes="[data^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("q", Attributes="[cite^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="[src^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("source", Attributes="[src^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("source", Attributes="[srcset^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("track", Attributes="[src^='~/']", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("video", Attributes="[poster^='~/']")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("video", Attributes="[src^='~/']")]
    public partial class UrlResolutionTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public UrlResolutionTagHelper(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) { }
        protected System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } }
        public override int Order { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory UrlHelperFactory { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
        protected void ProcessUrlAttribute(string attributeName, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
        protected bool TryResolveUrl(string url, out Microsoft.AspNetCore.Html.IHtmlContent resolvedUrl) { throw null; }
        protected bool TryResolveUrl(string url, out string resolvedUrl) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MvcRazorMvcBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddRazorOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddTagHelpersAsServices(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder InitializeTagHelper<TTagHelper>(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<TTagHelper, Microsoft.AspNetCore.Mvc.Rendering.ViewContext> initialize) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
    }
    public static partial class MvcRazorMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddRazorViewEngine(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddRazorViewEngine(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions> setupAction) { throw null; }
        internal static void AddRazorViewEngineFeatureProviders(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager partManager) { }
        internal static void AddRazorViewEngineServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddTagHelpersAsServices(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder InitializeTagHelper<TTagHelper>(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<TTagHelper, Microsoft.AspNetCore.Mvc.Rendering.ViewContext> initialize) where TTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper { throw null; }
    }
    internal partial class MvcRazorMvcViewOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>
    {
        public MvcRazorMvcViewOptionsSetup(Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine razorViewEngine) { }
        public void Configure(Microsoft.AspNetCore.Mvc.MvcViewOptions options) { }
    }
    internal static partial class TagHelpersAsServices
    {
        public static void AddTagHelpersAsServices(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager manager, Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
    }
}
