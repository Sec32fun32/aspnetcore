// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public sealed partial class PageActionEndpointConventionBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder
    {
        internal PageActionEndpointConventionBuilder(object @lock, System.Collections.Generic.List<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { }
        public void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention) { }
    }
    public static partial class RazorPagesEndpointRouteBuilderExtensions
    {
        public static void MapDynamicPageRoute<TTransformer>(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern) where TTransformer : Microsoft.AspNetCore.Mvc.Routing.DynamicRouteValueTransformer { }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToAreaPage(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string page, string area) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToAreaPage(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string page, string area) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToPage(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string page) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToPage(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string page) { throw null; }
        public static Microsoft.AspNetCore.Builder.PageActionEndpointConventionBuilder MapRazorPages(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ApplicationModels
{
    internal partial class AuthorizationPageApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public AuthorizationPageApplicationModelProvider(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider policyProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
    }
    internal partial class AutoValidateAntiforgeryPageApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public AutoValidateAntiforgeryPageApplicationModelProvider() { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
    }
    internal static partial class CompiledPageActionDescriptorBuilder
    {
        public static Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor Build(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel applicationModel, Microsoft.AspNetCore.Mvc.Filters.FilterCollection globalFilters) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageBoundPropertyDescriptor[] CreateBoundProperties(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel applicationModel) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor[] CreateHandlerMethods(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel applicationModel) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerParameterDescriptor[] CreateHandlerParameters(Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel handlerModel) { throw null; }
    }
    internal partial class CompiledPageRouteModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelProvider
    {
        public CompiledPageRouteModelProvider(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager applicationManager, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> pagesOptionsAccessor, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.ApplicationModels.CompiledPageRouteModelProvider> logger) { }
        public int Order { get { throw null; } }
        internal static string GetRouteTemplate(Microsoft.AspNetCore.Mvc.Razor.Compilation.CompiledViewDescriptor viewDescriptor) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Razor.Compilation.ViewsFeature GetViewFeature(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager applicationManager) { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModelProviderContext context) { }
    }
    internal partial class DefaultPageApplicationModelPartsProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelPartsProvider
    {
        public DefaultPageApplicationModelPartsProvider(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel CreateHandlerModel(System.Reflection.MethodInfo method) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageParameterModel CreateParameterModel(System.Reflection.ParameterInfo parameter) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PagePropertyModel CreatePropertyModel(System.Reflection.PropertyInfo property) { throw null; }
        public bool IsHandler(System.Reflection.MethodInfo methodInfo) { throw null; }
        internal static bool TryParseHandlerMethod(string methodName, out string httpMethod, out string handler) { throw null; }
    }
    internal partial class DefaultPageApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public DefaultPageApplicationModelProvider(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> razorPagesOptions, Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelPartsProvider pageApplicationModelPartsProvider) { }
        public int Order { get { throw null; } }
        protected virtual Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel CreateModel(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor, System.Reflection.TypeInfo pageTypeInfo) { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        internal void PopulateFilters(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel pageModel) { }
        internal void PopulateHandlerMethods(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel pageModel) { }
        internal void PopulateHandlerProperties(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel pageModel) { }
    }
    public partial interface IPageApplicationModelConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel model);
    }
    public partial interface IPageApplicationModelPartsProvider
    {
        Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel CreateHandlerModel(System.Reflection.MethodInfo method);
        Microsoft.AspNetCore.Mvc.ApplicationModels.PageParameterModel CreateParameterModel(System.Reflection.ParameterInfo parameter);
        Microsoft.AspNetCore.Mvc.ApplicationModels.PagePropertyModel CreatePropertyModel(System.Reflection.PropertyInfo property);
        bool IsHandler(System.Reflection.MethodInfo methodInfo);
    }
    public partial interface IPageApplicationModelProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context);
    }
    public partial interface IPageConvention
    {
    }
    public partial interface IPageHandlerModelConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel model);
    }
    public partial interface IPageRouteModelConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel model);
    }
    public partial interface IPageRouteModelProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModelProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModelProviderContext context);
    }
    public partial class PageApplicationModel
    {
        public PageApplicationModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel other) { }
        public PageApplicationModel(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor, System.Reflection.TypeInfo handlerType, System.Collections.Generic.IReadOnlyList<object> handlerAttributes) { }
        public PageApplicationModel(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor, System.Reflection.TypeInfo declaredModelType, System.Reflection.TypeInfo handlerType, System.Collections.Generic.IReadOnlyList<object> handlerAttributes) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor ActionDescriptor { get { throw null; } }
        public string AreaName { get { throw null; } }
        public System.Reflection.TypeInfo DeclaredModelType { get { throw null; } }
        public System.Collections.Generic.IList<object> EndpointMetadata { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel> HandlerMethods { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PagePropertyModel> HandlerProperties { get { throw null; } }
        public System.Reflection.TypeInfo HandlerType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> HandlerTypeAttributes { get { throw null; } }
        public System.Reflection.TypeInfo ModelType { get { throw null; } set { } }
        public System.Reflection.TypeInfo PageType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public string RelativePath { get { throw null; } }
        public string RouteTemplate { get { throw null; } }
        public string ViewEnginePath { get { throw null; } }
    }
    public partial class PageApplicationModelProviderContext
    {
        public PageApplicationModelProviderContext(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor descriptor, System.Reflection.TypeInfo pageTypeInfo) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel PageApplicationModel { get { throw null; } set { } }
        public System.Reflection.TypeInfo PageType { get { throw null; } }
    }
    public partial class PageConventionCollection : System.Collections.ObjectModel.Collection<Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention>
    {
        public PageConventionCollection() { }
        public PageConventionCollection(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention> conventions) { }
        internal PageConventionCollection(System.IServiceProvider serviceProvider) { }
        internal Microsoft.AspNetCore.Mvc.MvcOptions MvcOptions { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelConvention AddAreaFolderApplicationModelConvention(string areaName, string folderPath, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention AddAreaFolderRouteModelConvention(string areaName, string folderPath, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelConvention AddAreaPageApplicationModelConvention(string areaName, string pageName, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention AddAreaPageRouteModelConvention(string areaName, string pageName, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelConvention AddFolderApplicationModelConvention(string folderPath, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention AddFolderRouteModelConvention(string folderPath, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelConvention AddPageApplicationModelConvention(string pageName, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel> action) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention AddPageRouteModelConvention(string pageName, System.Action<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> action) { throw null; }
        internal static void EnsureValidFolderPath(string folderPath) { }
        internal static void EnsureValidPageName(string pageName, string argumentName = "pageName") { }
        internal static bool PathBelongsToFolder(string folderPath, string viewEnginePath) { throw null; }
        public void RemoveType(System.Type pageConventionType) { }
        public void RemoveType<TPageConvention>() where TPageConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PageHandlerModel: Name={Name}")]
    public partial class PageHandlerModel : Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public PageHandlerModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel other) { }
        public PageHandlerModel(System.Reflection.MethodInfo handlerMethod, System.Collections.Generic.IReadOnlyList<object> attributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public string HandlerName { get { throw null; } set { } }
        public string HttpMethod { get { throw null; } set { } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel Page { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PageParameterModel> Parameters { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PageParameterModel: Name={ParameterName}")]
    public partial class PageParameterModel : Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase, Microsoft.AspNetCore.Mvc.ApplicationModels.IBindingModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public PageParameterModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PageParameterModel other) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public PageParameterModel(System.Reflection.ParameterInfo parameterInfo, System.Collections.Generic.IReadOnlyList<object> attributes) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageHandlerModel Handler { get { throw null; } set { } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } }
        public string ParameterName { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PagePropertyModel: Name={PropertyName}")]
    public partial class PagePropertyModel : Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public PagePropertyModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PagePropertyModel other) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public PagePropertyModel(System.Reflection.PropertyInfo propertyInfo, System.Collections.Generic.IReadOnlyList<object> attributes) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel Page { get { throw null; } set { } }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public string PropertyName { get { throw null; } set { } }
    }
    public sealed partial class PageRouteMetadata
    {
        public PageRouteMetadata(string pageRoute, string routeTemplate) { }
        public string PageRoute { get { throw null; } }
        public string RouteTemplate { get { throw null; } }
    }
    public partial class PageRouteModel
    {
        public PageRouteModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel other) { }
        public PageRouteModel(string relativePath, string viewEnginePath) { }
        public PageRouteModel(string relativePath, string viewEnginePath, string areaName) { }
        public string AreaName { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public string RelativePath { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IOutboundParameterTransformer RouteParameterTransformer { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel> Selectors { get { throw null; } }
        public string ViewEnginePath { get { throw null; } }
    }
    internal partial class PageRouteModelFactory
    {
        public PageRouteModelFactory(Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions options, Microsoft.Extensions.Logging.ILogger logger) { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel CreateAreaRouteModel(string relativePath, string routeTemplate) { throw null; }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel CreateRouteModel(string relativePath, string routeTemplate) { throw null; }
        internal bool TryParseAreaPath(string relativePath, out (string areaName, string viewEnginePath) result) { throw null; }
    }
    public partial class PageRouteModelProviderContext
    {
        public PageRouteModelProviderContext() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> RouteModels { get { throw null; } }
    }
    public partial class PageRouteTransformerConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageConvention, Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention
    {
        public PageRouteTransformerConvention(Microsoft.AspNetCore.Routing.IOutboundParameterTransformer parameterTransformer) { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel model) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel action) { throw null; }
    }
    internal partial class ResponseCacheFilterApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public ResponseCacheFilterApplicationModelProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptionsAccessor, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
    }
    internal partial class TempDataFilterPageApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public TempDataFilterPageApplicationModelProvider(Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer tempDataSerializer) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
    }
    internal partial class ViewDataAttributePageApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider
    {
        public ViewDataAttributePageApplicationModelProvider() { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModelProviderContext context) { }
    }
}
namespace Microsoft.AspNetCore.Mvc.Diagnostics
{
    public sealed partial class AfterHandlerMethodEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterHandlerMethod";
        public AfterHandlerMethodEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> arguments, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethodDescriptor, object instance, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Arguments { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor HandlerMethodDescriptor { get { throw null; } }
        public object Instance { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } }
    }
    public sealed partial class AfterPageFilterOnPageHandlerExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnPageHandlerExecuted";
        public AfterPageFilterOnPageHandlerExecutedEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext HandlerExecutedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterPageFilterOnPageHandlerExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnPageHandlerExecuting";
        public AfterPageFilterOnPageHandlerExecutingEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext HandlerExecutingContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterPageFilterOnPageHandlerExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnPageHandlerExecution";
        public AfterPageFilterOnPageHandlerExecutionEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext HandlerExecutedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterPageFilterOnPageHandlerSelectedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnPageHandlerSelected";
        public AfterPageFilterOnPageHandlerSelectedEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext HandlerSelectedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterPageFilterOnPageHandlerSelectionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnPageHandlerSelection";
        public AfterPageFilterOnPageHandlerSelectionEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext HandlerSelectedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeHandlerMethodEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeHandlerMethod";
        public BeforeHandlerMethodEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> arguments, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethodDescriptor, object instance) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Arguments { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor HandlerMethodDescriptor { get { throw null; } }
        public object Instance { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforePageFilterOnPageHandlerExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnPageHandlerExecuted";
        public BeforePageFilterOnPageHandlerExecutedEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext HandlerExecutedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforePageFilterOnPageHandlerExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnPageHandlerExecuting";
        public BeforePageFilterOnPageHandlerExecutingEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext HandlerExecutingContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforePageFilterOnPageHandlerExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnPageHandlerExecution";
        public BeforePageFilterOnPageHandlerExecutionEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutionContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext HandlerExecutionContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforePageFilterOnPageHandlerSelectedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnPageHandlerSelected";
        public BeforePageFilterOnPageHandlerSelectedEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext HandlerSelectedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforePageFilterOnPageHandlerSelectionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnPageHandlerSelection";
        public BeforePageFilterOnPageHandlerSelectionEventData(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter Filter { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext HandlerSelectedContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.Filters
{
    public partial interface IAsyncPageFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnPageHandlerExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutionDelegate next);
        System.Threading.Tasks.Task OnPageHandlerSelectionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context);
    }
    public partial interface IPageFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context);
        void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context);
        void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context);
    }
    public partial class PageHandlerExecutedContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public PageHandlerExecutedContext(Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethod, object handlerInstance) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual new Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        public virtual bool Canceled { get { throw null; } set { } }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo ExceptionDispatchInfo { get { throw null; } set { } }
        public virtual bool ExceptionHandled { get { throw null; } set { } }
        public virtual object HandlerInstance { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor HandlerMethod { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public partial class PageHandlerExecutingContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public PageHandlerExecutingContext(Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethod, System.Collections.Generic.IDictionary<string, object> handlerArguments, object handlerInstance) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual new Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        public virtual System.Collections.Generic.IDictionary<string, object> HandlerArguments { get { throw null; } }
        public virtual object HandlerInstance { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor HandlerMethod { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public delegate System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext> PageHandlerExecutionDelegate();
    internal partial class PageHandlerPageFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public PageHandlerPageFilter() { }
        public int Order { get { throw null; } }
        public System.Threading.Tasks.Task OnPageHandlerExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutionDelegate next) { throw null; }
        public System.Threading.Tasks.Task OnPageHandlerSelectionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { throw null; }
    }
    internal partial class PageHandlerResultFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public PageHandlerResultFilter() { }
        public int Order { get { throw null; } }
        public System.Threading.Tasks.Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResultExecutionDelegate next) { throw null; }
    }
    public partial class PageHandlerSelectedContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public PageHandlerSelectedContext(Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, object handlerInstance) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual new Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        public virtual object HandlerInstance { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor HandlerMethod { get { throw null; } set { } }
    }
    internal partial class PageResponseCacheFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IPageFilter, Microsoft.AspNetCore.Mvc.Filters.IResponseCacheFilter
    {
        public PageResponseCacheFilter(Microsoft.AspNetCore.Mvc.CacheProfile cacheProfile, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public int Duration { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ResponseCacheLocation Location { get { throw null; } set { } }
        public bool NoStore { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
        public void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context) { }
        public void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context) { }
        public void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { }
    }
    internal partial class PageSaveTempDataPropertyFilter : Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.SaveTempDataPropertyFilterBase, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IPageFilter
    {
        public PageSaveTempDataPropertyFilter(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory factory) : base (default(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory)) { }
        public void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context) { }
        public void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context) { }
        public void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { }
    }
    internal partial class PageSaveTempDataPropertyFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public PageSaveTempDataPropertyFilterFactory(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public bool IsReusable { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    internal partial class PageViewDataAttributeFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IPageFilter, Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.IViewDataValuesProviderFeature
    {
        public PageViewDataAttributeFilter(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } }
        public object Subject { get { throw null; } set { } }
        public void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context) { }
        public void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context) { }
        public void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { }
        public void ProvideViewDataValues(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { }
    }
    internal partial class PageViewDataAttributeFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public PageViewDataAttributeFilterFactory(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public bool IsReusable { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    public partial class CompiledPageActionDescriptor : Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor
    {
        public CompiledPageActionDescriptor() { }
        public CompiledPageActionDescriptor(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor) { }
        public System.Reflection.TypeInfo DeclaredModelTypeInfo { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.Endpoint Endpoint { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor> HandlerMethods { get { throw null; } set { } }
        public System.Reflection.TypeInfo HandlerTypeInfo { get { throw null; } set { } }
        public System.Reflection.TypeInfo ModelTypeInfo { get { throw null; } set { } }
        public System.Reflection.TypeInfo PageTypeInfo { get { throw null; } set { } }
    }
    public partial interface IPageActivatorProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
        System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
    }
    public partial interface IPageFactoryProvider
    {
        System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreatePageDisposer(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
        System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreatePageFactory(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
    }
    public partial interface IPageModelActivatorProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
        System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
    }
    public partial interface IPageModelFactoryProvider
    {
        System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateModelDisposer(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
        System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateModelFactory(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor);
    }
    internal static partial class MvcRazorPagesDiagnosticListenerExtensions
    {
        public static void AfterHandlerMethod(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethodDescriptor, System.Collections.Generic.IReadOnlyDictionary<string, object> arguments, object instance, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void AfterOnPageHandlerExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void AfterOnPageHandlerExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void AfterOnPageHandlerExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public static void AfterOnPageHandlerSelected(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void AfterOnPageHandlerSelection(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public static void BeforeHandlerMethod(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerMethodDescriptor, System.Collections.Generic.IReadOnlyDictionary<string, object> arguments, object instance) { }
        public static void BeforeOnPageHandlerExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext handlerExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void BeforeOnPageHandlerExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void BeforeOnPageHandlerExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext handlerExecutionContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
        public static void BeforeOnPageHandlerSelected(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IPageFilter filter) { }
        public static void BeforeOnPageHandlerSelection(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext handlerSelectedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter filter) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class NonHandlerAttribute : System.Attribute
    {
        public NonHandlerAttribute() { }
    }
    public abstract partial class Page : Microsoft.AspNetCore.Mvc.RazorPages.PageBase
    {
        protected Page() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString,nq}")]
    public partial class PageActionDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor
    {
        public PageActionDescriptor() { }
        public PageActionDescriptor(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor other) { }
        public string AreaName { get { throw null; } set { } }
        public override string DisplayName { get { throw null; } set { } }
        public string RelativePath { get { throw null; } set { } }
        public string ViewEnginePath { get { throw null; } set { } }
    }
    public abstract partial class PageBase : Microsoft.AspNetCore.Mvc.Razor.RazorPageBase
    {
        protected PageBase() { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.PageContext PageContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestResult BadRequest() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest(object error) { throw null; }
        public override void BeginContext(int position, int length, bool isLiteral) { }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding) { throw null; }
        public override void EndContext() { }
        public override void EnsureRenderedBodyOrSections() { }
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirect(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanent(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanentPreserveMethod(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPreserveMethod(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.NotFoundResult NotFound() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.NotFoundObjectResult NotFound(object value) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RazorPages.PageResult Page() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult Partial(string viewName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult Partial(string viewName, object model) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult Redirect(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanent(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanentPreserveMethod(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPreserveMethod(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanentPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanentPreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanentPreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, string authenticationScheme) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, string authenticationScheme) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.StatusCodeResult StatusCode(int statusCode) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ObjectResult StatusCode(int statusCode, object value) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix) { throw null; }
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) { throw null; }
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix) where TModel : class { throw null; }
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider) where TModel : class { throw null; }
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        public virtual bool TryValidateModel(object model) { throw null; }
        public virtual bool TryValidateModel(object model, string prefix) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.UnauthorizedResult Unauthorized() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName, object arguments) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType, object arguments) { throw null; }
    }
    public partial class PageContext : Microsoft.AspNetCore.Mvc.ActionContext
    {
        public PageContext() { }
        public PageContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext) { }
        public virtual new Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } set { } }
        public virtual System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> ValueProviderFactories { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public virtual System.Collections.Generic.IList<System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage>> ViewStartFactories { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class PageContextAttribute : System.Attribute
    {
        public PageContextAttribute() { }
    }
    internal static partial class PageLoggerExtensions
    {
        public const string PageFilter = "Page Filter";
        public static void AfterExecutingMethodOnFilter(this Microsoft.Extensions.Logging.ILogger logger, string filterType, string methodName, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void BeforeExecutingMethodOnFilter(this Microsoft.Extensions.Logging.ILogger logger, string filterType, string methodName, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void ExecutedHandlerMethod(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handler, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void ExecutedImplicitHandlerMethod(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void ExecutedPageFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { }
        public static void ExecutedPageModelFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { }
        public static void ExecutingHandlerMethod(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handler, object[] arguments) { }
        public static void ExecutingImplicitHandlerMethod(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { }
        public static void ExecutingPageFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { }
        public static void ExecutingPageModelFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { }
        public static void NotMostEffectiveFilter(this Microsoft.Extensions.Logging.ILogger logger, System.Type policyType) { }
        public static void PageFilterShortCircuited(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
    }
    [Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageModelAttribute]
    public abstract partial class PageModel : Microsoft.AspNetCore.Mvc.Filters.IAsyncPageFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IPageFilter
    {
        protected PageModel() { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.RazorPages.PageContextAttribute]
        public Microsoft.AspNetCore.Mvc.RazorPages.PageContext PageContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestResult BadRequest() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest(object error) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirect(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanent(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanentPreserveMethod(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPreserveMethod(string localUrl) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.NotFoundResult NotFound() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.NotFoundObjectResult NotFound(object value) { throw null; }
        public virtual void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context) { }
        public virtual void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task OnPageHandlerExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutionDelegate next) { throw null; }
        public virtual void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { }
        public virtual System.Threading.Tasks.Task OnPageHandlerSelectionAsync(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RazorPages.PageResult Page() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult Partial(string viewName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult Partial(string viewName, object model) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName) { throw null; }
        protected internal Microsoft.AspNetCore.Mvc.RedirectResult Redirect(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanent(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanentPreserveMethod(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPreserveMethod(string url) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanentPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanentPreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, string fragment) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanentPreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, string authenticationScheme) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, string authenticationScheme) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(params string[] authenticationSchemes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.StatusCodeResult StatusCode(int statusCode) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ObjectResult StatusCode(int statusCode, object value) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string name) { throw null; }
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string name, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) { throw null; }
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name) where TModel : class { throw null; }
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected internal System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string name, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        public virtual bool TryValidateModel(object model) { throw null; }
        public virtual bool TryValidateModel(object model, string name) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.UnauthorizedResult Unauthorized() { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName, object arguments) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType, object arguments) { throw null; }
    }
    public partial class PageResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public PageResult() { }
        public string ContentType { get { throw null; } set { } }
        public object Model { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.PageBase Page { get { throw null; } set { } }
        public int? StatusCode { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class RazorPagesOptions : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>, System.Collections.IEnumerable
    {
        public RazorPagesOptions() { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection Conventions { get { throw null; } internal set { } }
        public string RootDirectory { get { throw null; } set { } }
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    internal static partial class Resources
    {
        internal static string ActivatedInstance_MustBeAnInstanceOf { get { throw null; } }
        internal static string AmbiguousHandler { get { throw null; } }
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string AsyncPageFilter_InvalidShortCircuit { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string InvalidActionDescriptorModelType { get { throw null; } }
        internal static string InvalidPageType_NoModelProperty { get { throw null; } }
        internal static string InvalidPageType_WrongBase { get { throw null; } }
        internal static string InvalidValidPageName { get { throw null; } }
        internal static string PageViewResult_ContextIsInvalid { get { throw null; } }
        internal static string PathMustBeRootRelativePath { get { throw null; } }
        internal static string PropertyOfTypeCannotBeNull { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string UnsupportedHandlerMethodType { get { throw null; } }
        internal static string FormatActivatedInstance_MustBeAnInstanceOf(object p0, object p1) { throw null; }
        internal static string FormatAmbiguousHandler(object p0, object p1) { throw null; }
        internal static string FormatAsyncPageFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatInvalidActionDescriptorModelType(object p0, object p1, object p2) { throw null; }
        internal static string FormatInvalidPageType_NoModelProperty(object p0, object p1) { throw null; }
        internal static string FormatInvalidPageType_WrongBase(object p0, object p1) { throw null; }
        internal static string FormatInvalidValidPageName(object p0) { throw null; }
        internal static string FormatPageViewResult_ContextIsInvalid(object p0, object p1, object p2) { throw null; }
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) { throw null; }
        internal static string FormatUnsupportedHandlerMethodType(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure
{
    internal partial class DefaultPageActivatorProvider : Microsoft.AspNetCore.Mvc.RazorPages.IPageActivatorProvider
    {
        public DefaultPageActivatorProvider() { }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
    }
    internal partial class DefaultPageFactoryProvider : Microsoft.AspNetCore.Mvc.RazorPages.IPageFactoryProvider
    {
        public DefaultPageFactoryProvider(Microsoft.AspNetCore.Mvc.RazorPages.IPageActivatorProvider pageActivator, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory, Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper jsonHelper, System.Diagnostics.DiagnosticListener diagnosticListener, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider modelExpressionProvider) { }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreatePageDisposer(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> CreatePageFactory(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
    }
    internal partial class DefaultPageHandlerMethodSelector : Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageHandlerMethodSelector
    {
        public DefaultPageHandlerMethodSelector() { }
        public Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor Select(Microsoft.AspNetCore.Mvc.RazorPages.PageContext context) { throw null; }
    }
    internal partial class DefaultPageLoader : Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageLoader
    {
        public DefaultPageLoader(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelProvider> applicationModelProviders, Microsoft.AspNetCore.Mvc.Razor.Compilation.IViewCompilerProvider viewCompilerProvider, Microsoft.AspNetCore.Mvc.Routing.ActionEndpointFactory endpointFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> pageOptions, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        internal static void ApplyConventions(Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel pageApplicationModel) { }
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor> LoadAsync(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor) { throw null; }
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor> LoadAsync(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.EndpointMetadataCollection endpointMetadata) { throw null; }
    }
    internal partial class DefaultPageModelActivatorProvider : Microsoft.AspNetCore.Mvc.RazorPages.IPageModelActivatorProvider
    {
        public DefaultPageModelActivatorProvider() { }
        public virtual System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
        public virtual System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
    }
    internal partial class DefaultPageModelFactoryProvider : Microsoft.AspNetCore.Mvc.RazorPages.IPageModelFactoryProvider
    {
        public DefaultPageModelFactoryProvider(Microsoft.AspNetCore.Mvc.RazorPages.IPageModelActivatorProvider modelActivator) { }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateModelDisposer(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateModelFactory(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
    }
    internal partial class DynamicPageEndpointMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy
    {
        public DynamicPageEndpointMatcherPolicy(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.DynamicPageEndpointSelector selector, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageLoader loader, Microsoft.AspNetCore.Routing.Matching.EndpointMetadataComparer comparer) { }
        public override int Order { get { throw null; } }
        public bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
    }
    internal partial class DynamicPageEndpointSelector : System.IDisposable
    {
        public DynamicPageEndpointSelector(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageActionEndpointDataSource dataSource) { }
        protected DynamicPageEndpointSelector(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource) { }
        public void Dispose() { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> SelectEndpoints(Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
    }
    internal partial class DynamicPageMetadata : Microsoft.AspNetCore.Routing.IDynamicEndpointMetadata
    {
        public DynamicPageMetadata(Microsoft.AspNetCore.Routing.RouteValueDictionary values) { }
        public bool IsDynamic { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Values { get { throw null; } }
    }
    internal partial class DynamicPageRouteValueTransformerMetadata : Microsoft.AspNetCore.Routing.IDynamicEndpointMetadata
    {
        public DynamicPageRouteValueTransformerMetadata(System.Type selectorType) { }
        public bool IsDynamic { get { throw null; } }
        public System.Type SelectorType { get { throw null; } }
    }
    internal static partial class ExecutorFactory
    {
        public static Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerExecutorDelegate CreateExecutor(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handlerDescriptor) { throw null; }
    }
    internal sealed partial class HandleOptionsRequestsPageFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.Filters.IPageFilter
    {
        public HandleOptionsRequestsPageFilter() { }
        public int Order { get { throw null; } }
        public void OnPageHandlerExecuted(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutedContext context) { }
        public void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context) { }
        public void OnPageHandlerSelected(Microsoft.AspNetCore.Mvc.Filters.PageHandlerSelectedContext context) { }
    }
    public partial class HandlerMethodDescriptor
    {
        public HandlerMethodDescriptor() { }
        public string HttpMethod { get { throw null; } set { } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerParameterDescriptor> Parameters { get { throw null; } set { } }
    }
    public partial class HandlerParameterDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor, Microsoft.AspNetCore.Mvc.Infrastructure.IParameterInfoParameterDescriptor
    {
        public HandlerParameterDescriptor() { }
        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } set { } }
    }
    public partial interface IPageHandlerMethodSelector
    {
        Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor Select(Microsoft.AspNetCore.Mvc.RazorPages.PageContext context);
    }
    [System.ObsoleteAttribute("This type is obsolete. Use PageLoader instead.")]
    public partial interface IPageLoader
    {
        Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor Load(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor);
    }
    public partial class PageActionDescriptorProvider : Microsoft.AspNetCore.Mvc.Abstractions.IActionDescriptorProvider
    {
        public PageActionDescriptorProvider(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelProvider> pageRouteModelProviders, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptionsAccessor, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> pagesOptionsAccessor) { }
        public int Order { get { throw null; } set { } }
        protected System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel> BuildModel() { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context) { }
    }
    internal partial class PageActionEndpointDataSource : Microsoft.AspNetCore.Mvc.Routing.ActionEndpointDataSourceBase
    {
        public PageActionEndpointDataSource(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actions, Microsoft.AspNetCore.Mvc.Routing.ActionEndpointFactory endpointFactory) : base (default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)) { }
        public bool CreateInertEndpoints { get { throw null; } set { } }
        public Microsoft.AspNetCore.Builder.PageActionEndpointConventionBuilder DefaultBuilder { get { throw null; } }
        protected override System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> CreateEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> actions, System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { throw null; }
    }
    internal partial class PageActionInvoker : Microsoft.AspNetCore.Mvc.Abstractions.IActionInvoker
    {
        public PageActionInvoker(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageHandlerMethodSelector handlerMethodSelector, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor actionContextAccessor, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filterMetadata, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageActionInvokerCacheEntry cacheEntry, Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions htmlHelperOptions) : base (default(System.Diagnostics.DiagnosticListener), default(Microsoft.Extensions.Logging.ILogger), default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor), default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper), default(Microsoft.AspNetCore.Mvc.ActionContext), default(Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[]), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory>)) { }
        internal Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageActionInvokerCacheEntry CacheEntry { get { throw null; } }
        internal Microsoft.AspNetCore.Mvc.RazorPages.PageContext PageContext { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected override System.Threading.Tasks.Task InvokeInnerFilterAsync() { throw null; }
        protected override System.Threading.Tasks.Task InvokeResultAsync(Microsoft.AspNetCore.Mvc.IActionResult result) { throw null; }
        protected override void ReleaseResources() { }
    }
    internal partial class PageActionInvokerCacheEntry
    {
        public PageActionInvokerCacheEntry(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary> viewDataFactory, System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> pageFactory, System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> releasePage, System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> modelFactory, System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> releaseModel, System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object, System.Threading.Tasks.Task> propertyBinder, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerExecutorDelegate[] handlerExecutors, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerBinderDelegate[] handlerBinders, System.Collections.Generic.IReadOnlyList<System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage>> viewStartFactories, Microsoft.AspNetCore.Mvc.Filters.FilterItem[] cacheableFilters) { }
        public Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.FilterItem[] CacheableFilters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerBinderDelegate[] HandlerBinders { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerExecutorDelegate[] HandlerExecutors { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> ModelFactory { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> PageFactory { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object, System.Threading.Tasks.Task> PropertyBinder { get { throw null; } }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> ReleaseModel { get { throw null; } }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, Microsoft.AspNetCore.Mvc.Rendering.ViewContext, object> ReleasePage { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary> ViewDataFactory { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage>> ViewStartFactories { get { throw null; } }
    }
    internal partial class PageActionInvokerProvider : Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider
    {
        public PageActionInvokerProvider(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageLoader loader, Microsoft.AspNetCore.Mvc.RazorPages.IPageFactoryProvider pageFactoryProvider, Microsoft.AspNetCore.Mvc.RazorPages.IPageModelFactoryProvider modelFactoryProvider, Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider razorPageFactoryProvider, Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider collectionProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider> filterProviders, Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> mvcViewOptions, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageHandlerMethodSelector selector, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper) { }
        public PageActionInvokerProvider(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageLoader loader, Microsoft.AspNetCore.Mvc.RazorPages.IPageFactoryProvider pageFactoryProvider, Microsoft.AspNetCore.Mvc.RazorPages.IPageModelFactoryProvider modelFactoryProvider, Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider razorPageFactoryProvider, Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider collectionProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider> filterProviders, Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> mvcViewOptions, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageHandlerMethodSelector selector, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor actionContextAccessor) { }
        public int Order { get { throw null; } }
        internal System.Collections.Generic.List<System.Func<Microsoft.AspNetCore.Mvc.Razor.IRazorPage>> GetViewStartFactories(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context) { }
        internal partial class InnerCache
        {
            public InnerCache(int version) { }
            public System.Collections.Concurrent.ConcurrentDictionary<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageActionInvokerCacheEntry> Entries { get { throw null; } }
            public int Version { get { throw null; } }
        }
    }
    internal static partial class PageBinderFactory
    {
        internal static readonly Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerBinderDelegate NullHandlerBinder;
        internal static readonly System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object, System.Threading.Tasks.Task> NullPropertyBinder;
        public static Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageHandlerBinderDelegate CreateHandlerBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.HandlerMethodDescriptor handler, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) { throw null; }
        public static System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object, System.Threading.Tasks.Task> CreatePropertyBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor actionDescriptor) { throw null; }
    }
    public partial class PageBoundPropertyDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor, Microsoft.AspNetCore.Mvc.Infrastructure.IPropertyInfoParameterDescriptor
    {
        public PageBoundPropertyDescriptor() { }
        System.Reflection.PropertyInfo Microsoft.AspNetCore.Mvc.Infrastructure.IPropertyInfoParameterDescriptor.PropertyInfo { get { throw null; } }
        public System.Reflection.PropertyInfo Property { get { throw null; } set { } }
    }
    internal delegate System.Threading.Tasks.Task PageHandlerBinderDelegate(Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, System.Collections.Generic.IDictionary<string, object> arguments);
    internal delegate System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> PageHandlerExecutorDelegate(object handler, object[] arguments);
    public abstract partial class PageLoader : Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageLoader
    {
        protected PageLoader() { }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor> LoadAsync(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor);
        Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.IPageLoader.Load(Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor actionDescriptor) { throw null; }
    }
    internal partial class PageLoaderMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy
    {
        public PageLoaderMatcherPolicy(Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.PageLoader loader) { }
        public override int Order { get { throw null; } }
        public bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class PageModelAttribute : System.Attribute
    {
        public PageModelAttribute() { }
    }
    public partial class PageResultExecutor : Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor
    {
        public PageResultExecutor(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine compositeViewEngine, Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine razorViewEngine, Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator razorPageActivator, System.Diagnostics.DiagnosticListener diagnosticListener, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) : base (default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), default(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory), default(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), default(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), default(System.Diagnostics.DiagnosticListener), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.RazorPages.PageContext pageContext, Microsoft.AspNetCore.Mvc.RazorPages.PageResult result) { throw null; }
    }
    public partial class PageViewLocationExpander : Microsoft.AspNetCore.Mvc.Razor.IViewLocationExpander
    {
        public PageViewLocationExpander() { }
        public System.Collections.Generic.IEnumerable<string> ExpandViewLocations(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context, System.Collections.Generic.IEnumerable<string> viewLocations) { throw null; }
        public void PopulateValues(Microsoft.AspNetCore.Mvc.Razor.ViewLocationExpanderContext context) { }
    }
    public partial class RazorPageAdapter : Microsoft.AspNetCore.Mvc.Razor.IModelTypeProvider, Microsoft.AspNetCore.Mvc.Razor.IRazorPage
    {
        public RazorPageAdapter(Microsoft.AspNetCore.Mvc.Razor.RazorPageBase page, System.Type modelType) { }
        public Microsoft.AspNetCore.Html.IHtmlContent BodyContent { get { throw null; } set { } }
        public bool IsLayoutBeingRendered { get { throw null; } set { } }
        public string Layout { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> PreviousSectionWriters { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate> SectionWriters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public void EnsureRenderedBodyOrSections() { }
        public System.Threading.Tasks.Task ExecuteAsync() { throw null; }
        System.Type Microsoft.AspNetCore.Mvc.Razor.IModelTypeProvider.GetModelType() { throw null; }
    }
    [System.ObsoleteAttribute("This attribute has been superseded by RazorCompiledItem and will not be used by the runtime.")]
    public partial class RazorPageAttribute : Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute
    {
        public RazorPageAttribute(string path, System.Type viewType, string routeTemplate) : base (default(string), default(System.Type)) { }
        public string RouteTemplate { get { throw null; } }
    }
    public partial class ServiceBasedPageModelActivatorProvider : Microsoft.AspNetCore.Mvc.RazorPages.IPageModelActivatorProvider
    {
        public ServiceBasedPageModelActivatorProvider() { }
        public System.Func<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
        public System.Action<Microsoft.AspNetCore.Mvc.RazorPages.PageContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.RazorPages.CompiledPageActionDescriptor descriptor) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MvcRazorPagesMvcBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddRazorPagesOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder WithRazorPagesAtContentRoot(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder WithRazorPagesRoot(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, string rootDirectory) { throw null; }
    }
    public static partial class MvcRazorPagesMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddRazorPages(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddRazorPages(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> setupAction) { throw null; }
        internal static void AddRazorPagesServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder WithRazorPagesRoot(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, string rootDirectory) { throw null; }
    }
    public static partial class PageConventionCollectionExtensions
    {
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection Add(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.IParameterModelBaseConvention convention) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AddAreaPageRoute(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string pageName, string route) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AddPageRoute(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string pageName, string route) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AllowAnonymousToAreaFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string folderPath) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AllowAnonymousToAreaPage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string pageName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AllowAnonymousToFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string folderPath) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AllowAnonymousToPage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string pageName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeAreaFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string folderPath) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeAreaFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string folderPath, string policy) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeAreaPage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string pageName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeAreaPage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string areaName, string pageName, string policy) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string folderPath) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizeFolder(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string folderPath, string policy) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizePage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string pageName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection AuthorizePage(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, string pageName, string policy) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection ConfigureFilter(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.IPageApplicationModelConvention ConfigureFilter(this Microsoft.AspNetCore.Mvc.ApplicationModels.PageConventionCollection conventions, System.Func<Microsoft.AspNetCore.Mvc.ApplicationModels.PageApplicationModel, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> factory) { throw null; }
    }
    internal partial class RazorPagesOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions>
    {
        public RazorPagesOptionsSetup(System.IServiceProvider serviceProvider) { }
        public void Configure(Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions options) { }
    }
    internal partial class RazorPagesRazorViewEngineOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>
    {
        public RazorPagesRazorViewEngineOptionsSetup(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.RazorPages.RazorPagesOptions> pagesOptions) { }
        public void Configure(Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions options) { }
    }
}
