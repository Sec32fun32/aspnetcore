// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc
{
    public partial class ActionContext
    {
        public ActionContext() { }
        public ActionContext(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor) { }
        public ActionContext(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { }
        public ActionContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } set { } }
    }
    public partial interface IActionResult
    {
        System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context);
    }
    public partial interface IUrlHelper
    {
        Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get; }
        string Action(Microsoft.AspNetCore.Mvc.Routing.UrlActionContext actionContext);
        string Content(string contentPath);
        bool IsLocalUrl(string url);
        string Link(string routeName, object values);
        string RouteUrl(Microsoft.AspNetCore.Mvc.Routing.UrlRouteContext routeContext);
    }
}
namespace Microsoft.AspNetCore.Mvc.Abstractions
{
    public partial class ActionDescriptor
    {
        public ActionDescriptor() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata> ActionConstraints { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Routing.AttributeRouteInfo AttributeRouteInfo { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor> BoundProperties { get { throw null; } set { } }
        public virtual string DisplayName { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> EndpointMetadata { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor> FilterDescriptors { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor> Parameters { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } set { } }
    }
    public static partial class ActionDescriptorExtensions
    {
        public static T GetProperty<T>(this Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor) { throw null; }
        public static void SetProperty<T>(this Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, T value) { }
    }
    public partial class ActionDescriptorProviderContext
    {
        public ActionDescriptorProviderContext() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> Results { get { throw null; } }
    }
    public partial class ActionInvokerProviderContext
    {
        public ActionInvokerProviderContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Abstractions.IActionInvoker Result { get { throw null; } set { } }
    }
    public partial interface IActionDescriptorProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context);
    }
    public partial interface IActionInvoker
    {
        System.Threading.Tasks.Task InvokeAsync();
    }
    public partial interface IActionInvokerProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context);
    }
    public partial class ParameterDescriptor
    {
        public ParameterDescriptor() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo BindingInfo { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Type ParameterType { get { throw null; } set { } }
    }
    internal static partial class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string BinderType_MustBeIModelBinder { get { throw null; } }
        internal static string BindingSource_Body { get { throw null; } }
        internal static string BindingSource_CannotBeComposite { get { throw null; } }
        internal static string BindingSource_CannotBeGreedy { get { throw null; } }
        internal static string BindingSource_Custom { get { throw null; } }
        internal static string BindingSource_Form { get { throw null; } }
        internal static string BindingSource_FormFile { get { throw null; } }
        internal static string BindingSource_Header { get { throw null; } }
        internal static string BindingSource_ModelBinding { get { throw null; } }
        internal static string BindingSource_MustBeFromRequest { get { throw null; } }
        internal static string BindingSource_MustBeGreedy { get { throw null; } }
        internal static string BindingSource_Path { get { throw null; } }
        internal static string BindingSource_Query { get { throw null; } }
        internal static string BindingSource_Services { get { throw null; } }
        internal static string BindingSource_Special { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string ModelBindingContext_ModelMetadataMustBeSet { get { throw null; } }
        internal static string ModelStateDictionary_MaxModelStateErrors { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string Validation_InvalidFieldCannotBeReset { get { throw null; } }
        internal static string Validation_InvalidFieldCannotBeReset_ToSkipped { get { throw null; } }
        internal static string FormatBinderType_MustBeIModelBinder(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_CannotBeComposite(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_CannotBeGreedy(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_MustBeFromRequest(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_MustBeGreedy(object p0, object p1) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ActionConstraints
{
    public partial class ActionConstraintContext
    {
        public ActionConstraintContext() { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.ActionSelectorCandidate> Candidates { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ActionConstraints.ActionSelectorCandidate CurrentCandidate { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteContext RouteContext { get { throw null; } set { } }
    }
    public partial class ActionConstraintItem
    {
        public ActionConstraintItem(Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata metadata) { }
        public Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint Constraint { get { throw null; } set { } }
        public bool IsReusable { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata Metadata { get { throw null; } }
    }
    public partial class ActionConstraintProviderContext
    {
        public ActionConstraintProviderContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintItem> items) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor Action { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintItem> Results { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionSelectorCandidate
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionSelectorCandidate(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint> constraints) { throw null; }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor Action { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint> Constraints { get { throw null; } }
    }
    public partial interface IActionConstraint : Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata
    {
        int Order { get; }
        bool Accept(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintContext context);
    }
    public partial interface IActionConstraintFactory : Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata
    {
        bool IsReusable { get; }
        Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint CreateInstance(System.IServiceProvider services);
    }
    public partial interface IActionConstraintMetadata
    {
    }
    public partial interface IActionConstraintProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintProviderContext context);
    }
}
namespace Microsoft.AspNetCore.Mvc.ApiExplorer
{
    [System.Diagnostics.DebuggerDisplayAttribute("{ActionDescriptor.DisplayName,nq}")]
    public partial class ApiDescription
    {
        public ApiDescription() { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } set { } }
        public string GroupName { get { throw null; } set { } }
        public string HttpMethod { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiParameterDescription> ParameterDescriptions { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public string RelativePath { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiRequestFormat> SupportedRequestFormats { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiResponseType> SupportedResponseTypes { get { throw null; } }
    }
    public partial class ApiDescriptionProviderContext
    {
        public ApiDescriptionProviderContext(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> actions) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> Actions { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescription> Results { get { throw null; } }
    }
    public partial class ApiParameterDescription
    {
        public ApiParameterDescription() { }
        public object DefaultValue { get { throw null; } set { } }
        public bool IsRequired { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor ParameterDescriptor { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ApiExplorer.ApiParameterRouteInfo RouteInfo { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Source { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class ApiParameterRouteInfo
    {
        public ApiParameterRouteInfo() { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.IRouteConstraint> Constraints { get { throw null; } set { } }
        public object DefaultValue { get { throw null; } set { } }
        public bool IsOptional { get { throw null; } set { } }
    }
    public partial class ApiRequestFormat
    {
        public ApiRequestFormat() { }
        public Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter Formatter { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
    }
    public partial class ApiResponseFormat
    {
        public ApiResponseFormat() { }
        public Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter Formatter { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
    }
    public partial class ApiResponseType
    {
        public ApiResponseType() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiResponseFormat> ApiResponseFormats { get { throw null; } set { } }
        public bool IsDefaultResponse { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial interface IApiDescriptionProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionProviderContext context);
    }
}
namespace Microsoft.AspNetCore.Mvc.Authorization
{
    public partial interface IAllowAnonymousFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
}
namespace Microsoft.AspNetCore.Mvc.Filters
{
    public partial class ActionExecutedContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ActionExecutedContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, object controller) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual bool Canceled { get { throw null; } set { } }
        public virtual object Controller { get { throw null; } }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo ExceptionDispatchInfo { get { throw null; } set { } }
        public virtual bool ExceptionHandled { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public partial class ActionExecutingContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ActionExecutingContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, System.Collections.Generic.IDictionary<string, object> actionArguments, object controller) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual System.Collections.Generic.IDictionary<string, object> ActionArguments { get { throw null; } }
        public virtual object Controller { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public delegate System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext> ActionExecutionDelegate();
    public partial class AuthorizationFilterContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public AuthorizationFilterContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public partial class ExceptionContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ExceptionContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo ExceptionDispatchInfo { get { throw null; } set { } }
        public virtual bool ExceptionHandled { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public abstract partial class FilterContext : Microsoft.AspNetCore.Mvc.ActionContext
    {
        public FilterContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public virtual System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } }
        public TMetadata FindEffectivePolicy<TMetadata>() where TMetadata : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
        public bool IsEffectivePolicy<TMetadata>(TMetadata policy) where TMetadata : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Filter = {Filter.ToString(),nq}, Order = {Order}")]
    public partial class FilterDescriptor
    {
        public FilterDescriptor(Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter, int filterScope) { }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public int Scope { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("FilterItem: {Filter}")]
    public partial class FilterItem
    {
        public FilterItem(Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor descriptor) { }
        public FilterItem(Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor descriptor, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor Descriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } set { } }
        public bool IsReusable { get { throw null; } set { } }
    }
    public partial class FilterProviderContext
    {
        public FilterProviderContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.FilterItem> items) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.FilterItem> Results { get { throw null; } set { } }
    }
    public partial interface IActionFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context);
        void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context);
    }
    public partial interface IAlwaysRunResultFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
    }
    public partial interface IAsyncActionFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate next);
    }
    public partial interface IAsyncAlwaysRunResultFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    public partial interface IAsyncAuthorizationFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context);
    }
    public partial interface IAsyncExceptionFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnExceptionAsync(Microsoft.AspNetCore.Mvc.Filters.ExceptionContext context);
    }
    public partial interface IAsyncResourceFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnResourceExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutionDelegate next);
    }
    public partial interface IAsyncResultFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        System.Threading.Tasks.Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResultExecutionDelegate next);
    }
    public partial interface IAuthorizationFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context);
    }
    public partial interface IExceptionFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnException(Microsoft.AspNetCore.Mvc.Filters.ExceptionContext context);
    }
    public partial interface IFilterContainer
    {
        Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata FilterDefinition { get; set; }
    }
    public partial interface IFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        bool IsReusable { get; }
        Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider);
    }
    public partial interface IFilterMetadata
    {
    }
    public partial interface IFilterProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Filters.FilterProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Filters.FilterProviderContext context);
    }
    public partial interface IOrderedFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        int Order { get; }
    }
    public partial interface IResourceFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnResourceExecuted(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext context);
        void OnResourceExecuting(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context);
    }
    public partial interface IResultFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context);
        void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context);
    }
    public partial class ResourceExecutedContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ResourceExecutedContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual bool Canceled { get { throw null; } set { } }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo ExceptionDispatchInfo { get { throw null; } set { } }
        public virtual bool ExceptionHandled { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public partial class ResourceExecutingContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ResourceExecutingContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> valueProviderFactories) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> ValueProviderFactories { get { throw null; } }
    }
    public delegate System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext> ResourceExecutionDelegate();
    public partial class ResultExecutedContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ResultExecutedContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, Microsoft.AspNetCore.Mvc.IActionResult result, object controller) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual bool Canceled { get { throw null; } set { } }
        public virtual object Controller { get { throw null; } }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo ExceptionDispatchInfo { get { throw null; } set { } }
        public virtual bool ExceptionHandled { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } }
    }
    public partial class ResultExecutingContext : Microsoft.AspNetCore.Mvc.Filters.FilterContext
    {
        public ResultExecutingContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters, Microsoft.AspNetCore.Mvc.IActionResult result, object controller) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>)) { }
        public virtual bool Cancel { get { throw null; } set { } }
        public virtual object Controller { get { throw null; } }
        public virtual Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } set { } }
    }
    public delegate System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext> ResultExecutionDelegate();
}
namespace Microsoft.AspNetCore.Mvc.Formatters
{
    public partial class FormatterCollection<TFormatter> : System.Collections.ObjectModel.Collection<TFormatter>
    {
        public FormatterCollection() { }
        public FormatterCollection(System.Collections.Generic.IList<TFormatter> list) { }
        public void RemoveType(System.Type formatterType) { }
        public void RemoveType<T>() where T : TFormatter { }
    }
    public partial interface IInputFormatter
    {
        bool CanRead(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context);
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context);
    }
    public partial interface IInputFormatterExceptionPolicy
    {
        Microsoft.AspNetCore.Mvc.Formatters.InputFormatterExceptionPolicy ExceptionPolicy { get; }
    }
    public partial class InputFormatterContext
    {
        public InputFormatterContext(Microsoft.AspNetCore.Http.HttpContext httpContext, string modelName, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextReader> readerFactory) { }
        public InputFormatterContext(Microsoft.AspNetCore.Http.HttpContext httpContext, string modelName, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextReader> readerFactory, bool treatEmptyInputAsDefaultValue) { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } }
        public string ModelName { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public System.Type ModelType { get { throw null; } }
        public System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextReader> ReaderFactory { get { throw null; } }
        public bool TreatEmptyInputAsDefaultValue { get { throw null; } }
    }
    public partial class InputFormatterException : System.Exception
    {
        public InputFormatterException() { }
        public InputFormatterException(string message) { }
        public InputFormatterException(string message, System.Exception innerException) { }
    }
    public enum InputFormatterExceptionPolicy
    {
        AllExceptions = 0,
        MalformedInputExceptions = 1,
    }
    public partial class InputFormatterResult
    {
        private InputFormatterResult() { }
        public bool HasError { get { throw null; } }
        public bool IsModelSet { get { throw null; } }
        public object Model { get { throw null; } }
        public static Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult Failure() { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> FailureAsync() { throw null; }
        public static Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult NoValue() { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> NoValueAsync() { throw null; }
        public static Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult Success(object model) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> SuccessAsync(object model) { throw null; }
    }
    public partial interface IOutputFormatter
    {
        bool CanWriteResult(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context);
        System.Threading.Tasks.Task WriteAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context);
    }
    public abstract partial class OutputFormatterCanWriteContext
    {
        protected OutputFormatterCanWriteContext(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
        public virtual Microsoft.Extensions.Primitives.StringSegment ContentType { get { throw null; } set { } }
        public virtual bool ContentTypeIsServerDefined { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } protected set { } }
        public virtual object Object { get { throw null; } protected set { } }
        public virtual System.Type ObjectType { get { throw null; } protected set { } }
    }
    public partial class OutputFormatterWriteContext : Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext
    {
        public OutputFormatterWriteContext(Microsoft.AspNetCore.Http.HttpContext httpContext, System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextWriter> writerFactory, System.Type objectType, object @object) : base (default(Microsoft.AspNetCore.Http.HttpContext)) { }
        public virtual System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextWriter> WriterFactory { get { throw null; } protected set { } }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    public partial class BindingInfo
    {
        public BindingInfo() { }
        public BindingInfo(Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo other) { }
        public string BinderModelName { get { throw null; } set { } }
        public System.Type BinderType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider PropertyFilterProvider { get { throw null; } set { } }
        public System.Func<Microsoft.AspNetCore.Mvc.ActionContext, bool> RequestPredicate { get { throw null; } set { } }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo GetBindingInfo(System.Collections.Generic.IEnumerable<object> attributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo GetBindingInfo(System.Collections.Generic.IEnumerable<object> attributes, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { throw null; }
        public bool TryApplyBindingInfo(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Source: {DisplayName}")]
    public partial class BindingSource : System.IEquatable<Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource>
    {
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Body;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Custom;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Form;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource FormFile;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Header;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource ModelBinding;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Path;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Query;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Services;
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource Special;
        public BindingSource(string id, string displayName, bool isGreedy, bool isFromRequest) { }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public bool IsFromRequest { get { throw null; } }
        public bool IsGreedy { get { throw null; } }
        public virtual bool CanAcceptDataFrom(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource s1, Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource s2) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource s1, Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource s2) { throw null; }
    }
    public partial class CompositeBindingSource : Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource
    {
        private CompositeBindingSource() : base (default(string), default(string), default(bool), default(bool)) { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource> BindingSources { get { throw null; } }
        public override bool CanAcceptDataFrom(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.CompositeBindingSource Create(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource> bindingSources, string displayName) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnumGroupAndName
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnumGroupAndName(string group, System.Func<string> name) { throw null; }
        public EnumGroupAndName(string group, string name) { throw null; }
        public string Group { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial interface IBinderTypeProviderMetadata : Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata
    {
        System.Type BinderType { get; }
    }
    public partial interface IBindingSourceMetadata
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get; }
    }
    public partial interface IModelBinder
    {
        System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext);
    }
    public partial interface IModelBinderProvider
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context);
    }
    public partial interface IModelMetadataProvider
    {
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> GetMetadataForProperties(System.Type modelType);
        Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForType(System.Type modelType);
    }
    public partial interface IModelNameProvider
    {
        string Name { get; }
    }
    public partial interface IPropertyFilterProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> PropertyFilter { get; }
    }
    public partial interface IRequestPredicateProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.ActionContext, bool> RequestPredicate { get; }
    }
    public partial interface IValueProvider
    {
        bool ContainsPrefix(string prefix);
        Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key);
    }
    public partial interface IValueProviderFactory
    {
        System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context);
    }
    public abstract partial class ModelBinderProviderContext
    {
        protected ModelBinderProviderContext() { }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo BindingInfo { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get; }
        public virtual System.IServiceProvider Services { get { throw null; } }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder CreateBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata);
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder CreateBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo bindingInfo) { throw null; }
    }
    public abstract partial class ModelBindingContext
    {
        protected ModelBindingContext() { }
        public abstract Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get; set; }
        public abstract string BinderModelName { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get; set; }
        public abstract string FieldName { get; set; }
        public virtual Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public abstract bool IsTopLevelObject { get; set; }
        public abstract object Model { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get; set; }
        public abstract string ModelName { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get; set; }
        public virtual System.Type ModelType { get { throw null; } }
        public string OriginalModelName { get { throw null; } protected set { } }
        public abstract System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> PropertyFilter { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult Result { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary ValidationState { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider ValueProvider { get; set; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext.NestedScope EnterNestedScope();
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext.NestedScope EnterNestedScope(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, string fieldName, string modelName, object model);
        protected abstract void ExitNestedScope();
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct NestedScope : System.IDisposable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public NestedScope(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext context) { throw null; }
            public void Dispose() { }
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ModelBindingResult : System.IEquatable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public bool IsModelSet { get { throw null; } }
        public object Model { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult Failed() { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult x, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult y) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult x, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult y) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult Success(object model) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ModelError
    {
        public ModelError(System.Exception exception) { }
        public ModelError(System.Exception exception, string errorMessage) { }
        public ModelError(string errorMessage) { }
        public string ErrorMessage { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
    }
    public partial class ModelErrorCollection : System.Collections.ObjectModel.Collection<Microsoft.AspNetCore.Mvc.ModelBinding.ModelError>
    {
        public ModelErrorCollection() { }
        public void Add(System.Exception exception) { }
        public void Add(string errorMessage) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString(),nq}")]
    public abstract partial class ModelMetadata : Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider, System.IEquatable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata>
    {
        public static readonly int DefaultOrder;
        protected ModelMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity identity) { }
        public abstract System.Collections.Generic.IReadOnlyDictionary<object, object> AdditionalValues { get; }
        public abstract string BinderModelName { get; }
        public abstract System.Type BinderType { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get; }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ContainerMetadata { get { throw null; } }
        public System.Type ContainerType { get { throw null; } }
        public abstract bool ConvertEmptyStringToNull { get; }
        public abstract string DataTypeName { get; }
        public abstract string Description { get; }
        public abstract string DisplayFormatString { get; }
        public abstract string DisplayName { get; }
        public abstract string EditFormatString { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ElementMetadata { get; }
        public System.Type ElementType { get { throw null; } }
        public abstract System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.AspNetCore.Mvc.ModelBinding.EnumGroupAndName, string>> EnumGroupedDisplayNamesAndValues { get; }
        public abstract System.Collections.Generic.IReadOnlyDictionary<string, string> EnumNamesAndValues { get; }
        public abstract bool HasNonDefaultEditFormat { get; }
        public virtual bool? HasValidators { get { throw null; } }
        public abstract bool HideSurroundingHtml { get; }
        public abstract bool HtmlEncode { get; }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity Identity { get { throw null; } }
        public abstract bool IsBindingAllowed { get; }
        public abstract bool IsBindingRequired { get; }
        public bool IsCollectionType { get { throw null; } }
        public bool IsComplexType { get { throw null; } }
        public abstract bool IsEnum { get; }
        public bool IsEnumerableType { get { throw null; } }
        public abstract bool IsFlagsEnum { get; }
        public bool IsNullableValueType { get { throw null; } }
        public abstract bool IsReadOnly { get; }
        public bool IsReferenceOrNullableType { get { throw null; } }
        public abstract bool IsRequired { get; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataKind MetadataKind { get { throw null; } }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelBindingMessageProvider ModelBindingMessageProvider { get; }
        public System.Type ModelType { get { throw null; } }
        public string Name { get { throw null; } }
        public abstract string NullDisplayText { get; }
        public abstract int Order { get; }
        public string ParameterName { get { throw null; } }
        public abstract string Placeholder { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelPropertyCollection Properties { get; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider PropertyFilterProvider { get; }
        public abstract System.Func<object, object> PropertyGetter { get; }
        public string PropertyName { get { throw null; } }
        public abstract System.Action<object, object> PropertySetter { get; }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IPropertyValidationFilter PropertyValidationFilter { get { throw null; } }
        public abstract bool ShowForDisplay { get; }
        public abstract bool ShowForEdit { get; }
        public abstract string SimpleDisplayProperty { get; }
        public abstract string TemplateHint { get; }
        public System.Type UnderlyingOrModelType { get { throw null; } }
        public abstract bool ValidateChildren { get; }
        public abstract System.Collections.Generic.IReadOnlyList<object> ValidatorMetadata { get; }
        public bool Equals(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public string GetDisplayName() { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> GetMetadataForProperties(System.Type modelType) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForType(System.Type modelType) { throw null; }
    }
    public abstract partial class ModelMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider
    {
        protected ModelMetadataProvider() { }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForParameter(System.Reflection.ParameterInfo parameter);
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForParameter(System.Reflection.ParameterInfo parameter, System.Type modelType) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> GetMetadataForProperties(System.Type modelType);
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForProperty(System.Reflection.PropertyInfo propertyInfo, System.Type modelType) { throw null; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForType(System.Type modelType);
    }
    public partial class ModelPropertyCollection : System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata>
    {
        public ModelPropertyCollection(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> properties) : base (default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata>)) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata this[string propertyName] { get { throw null; } }
    }
    public partial class ModelStateDictionary : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>, System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>, System.Collections.IEnumerable
    {
        public static readonly int DefaultMaxAllowedErrors;
        public ModelStateDictionary() { }
        public ModelStateDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary) { }
        public ModelStateDictionary(int maxAllowedErrors) { }
        public int Count { get { throw null; } }
        public int ErrorCount { get { throw null; } }
        public bool HasReachedMaxErrors { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry this[string key] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.KeyEnumerable Keys { get { throw null; } }
        public int MaxAllowedErrors { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry Root { get { throw null; } }
        System.Collections.Generic.IEnumerable<string> System.Collections.Generic.IReadOnlyDictionary<System.String,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry> System.Collections.Generic.IReadOnlyDictionary<System.String,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>.Values { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState ValidationState { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.ValueEnumerable Values { get { throw null; } }
        public void AddModelError(string key, System.Exception exception, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { }
        public void AddModelError(string key, string errorMessage) { }
        public void Clear() { }
        public void ClearValidationState(string key) { }
        public bool ContainsKey(string key) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.PrefixEnumerable FindKeysWithPrefix(string prefix) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.Enumerator GetEnumerator() { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState GetFieldValidationState(string key) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState GetValidationState(string key) { throw null; }
        public void MarkFieldSkipped(string key) { }
        public void MarkFieldValid(string key) { }
        public void Merge(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary) { }
        public bool Remove(string key) { throw null; }
        public void SetModelValue(string key, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult valueProviderResult) { }
        public void SetModelValue(string key, object rawValue, string attemptedValue) { }
        public static bool StartsWithPrefix(string prefix, string key) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryAddModelError(string key, System.Exception exception, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { throw null; }
        public bool TryAddModelError(string key, string errorMessage) { throw null; }
        public bool TryAddModelException(string key, System.Exception exception) { throw null; }
        public bool TryGetValue(string key, out Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary, string prefix) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct KeyEnumerable : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public KeyEnumerable(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary) { throw null; }
            public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.KeyEnumerator GetEnumerator() { throw null; }
            System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { throw null; }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct KeyEnumerator : System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public KeyEnumerator(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary, string prefix) { throw null; }
            public string Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct PrefixEnumerable : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>, System.Collections.IEnumerable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public PrefixEnumerable(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary, string prefix) { throw null; }
            public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.Enumerator GetEnumerator() { throw null; }
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>>.GetEnumerator() { throw null; }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct ValueEnumerable : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>, System.Collections.IEnumerable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public ValueEnumerable(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary) { throw null; }
            public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary.ValueEnumerator GetEnumerator() { throw null; }
            System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>.GetEnumerator() { throw null; }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct ValueEnumerator : System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public ValueEnumerator(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary dictionary, string prefix) { throw null; }
            public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public abstract partial class ModelStateEntry
    {
        protected ModelStateEntry() { }
        public string AttemptedValue { get { throw null; } set { } }
        public abstract System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry> Children { get; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelErrorCollection Errors { get { throw null; } }
        public abstract bool IsContainerNode { get; }
        public object RawValue { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState ValidationState { get { throw null; } set { } }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry GetModelStateForProperty(string propertyName);
    }
    public enum ModelValidationState
    {
        Unvalidated = 0,
        Invalid = 1,
        Valid = 2,
        Skipped = 3,
    }
    public partial class TooManyModelErrorsException : System.Exception
    {
        public TooManyModelErrorsException(string message) { }
    }
    public sealed partial class ValueProviderException : System.Exception
    {
        public ValueProviderException(string message) { }
        public ValueProviderException(string message, System.Exception innerException) { }
    }
    public partial class ValueProviderFactoryContext
    {
        public ValueProviderFactoryContext(Microsoft.AspNetCore.Mvc.ActionContext context) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider> ValueProviders { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ValueProviderResult : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.IEquatable<Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult None;
        public ValueProviderResult(Microsoft.Extensions.Primitives.StringValues values) { throw null; }
        public ValueProviderResult(Microsoft.Extensions.Primitives.StringValues values, System.Globalization.CultureInfo culture) { throw null; }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public string FirstValue { get { throw null; } }
        public int Length { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringValues Values { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public System.Collections.Generic.IEnumerator<string> GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult x, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult y) { throw null; }
        public static explicit operator string (Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult result) { throw null; }
        public static explicit operator string[] (Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult result) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult x, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult y) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding.Metadata
{
    public abstract partial class ModelBindingMessageProvider
    {
        protected ModelBindingMessageProvider() { }
        public virtual System.Func<string, string, string> AttemptedValueIsInvalidAccessor { get { throw null; } }
        public virtual System.Func<string, string> MissingBindRequiredValueAccessor { get { throw null; } }
        public virtual System.Func<string> MissingKeyOrValueAccessor { get { throw null; } }
        public virtual System.Func<string> MissingRequestBodyRequiredValueAccessor { get { throw null; } }
        public virtual System.Func<string, string> NonPropertyAttemptedValueIsInvalidAccessor { get { throw null; } }
        public virtual System.Func<string> NonPropertyUnknownValueIsInvalidAccessor { get { throw null; } }
        public virtual System.Func<string> NonPropertyValueMustBeANumberAccessor { get { throw null; } }
        public virtual System.Func<string, string> UnknownValueIsInvalidAccessor { get { throw null; } }
        public virtual System.Func<string, string> ValueIsInvalidAccessor { get { throw null; } }
        public virtual System.Func<string, string> ValueMustBeANumberAccessor { get { throw null; } }
        public virtual System.Func<string, string> ValueMustNotBeNullAccessor { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ModelMetadataIdentity : System.IEquatable<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public System.Type ContainerType { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataKind MetadataKind { get { throw null; } }
        public System.Type ModelType { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity ForParameter(System.Reflection.ParameterInfo parameter) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity ForParameter(System.Reflection.ParameterInfo parameter, System.Type modelType) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity ForProperty(System.Reflection.PropertyInfo propertyInfo, System.Type modelType, System.Type containerType) { throw null; }
        [System.ObsoleteAttribute("This API is obsolete and may be removed in a future release.")]
        public static Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity ForProperty(System.Type modelType, string name, System.Type containerType) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity ForType(System.Type modelType) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum ModelMetadataKind
    {
        Type = 0,
        Property = 1,
        Parameter = 2,
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding.Validation
{
    public partial class ClientModelValidationContext : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidationContextBase
    {
        public ClientModelValidationContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, System.Collections.Generic.IDictionary<string, string> attributes) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)) { }
        public System.Collections.Generic.IDictionary<string, string> Attributes { get { throw null; } }
    }
    public partial class ClientValidatorItem
    {
        public ClientValidatorItem() { }
        public ClientValidatorItem(object validatorMetadata) { }
        public bool IsReusable { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidator Validator { get { throw null; } set { } }
        public object ValidatorMetadata { get { throw null; } }
    }
    public partial class ClientValidatorProviderContext
    {
        public ClientValidatorProviderContext(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorItem> items) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorItem> Results { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> ValidatorMetadata { get { throw null; } }
    }
    public partial interface IClientModelValidator
    {
        void AddValidation(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientModelValidationContext context);
    }
    public partial interface IClientModelValidatorProvider
    {
        void CreateValidators(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorProviderContext context);
    }
    public partial interface IModelValidator
    {
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidationResult> Validate(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidationContext context);
    }
    public partial interface IModelValidatorProvider
    {
        void CreateValidators(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidatorProviderContext context);
    }
    public partial interface IPropertyValidationFilter
    {
        bool ShouldValidateEntry(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry entry, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry parentEntry);
    }
    public partial interface IValidationStrategy
    {
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry> GetChildren(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model);
    }
    public partial class ModelValidationContext : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidationContextBase
    {
        public ModelValidationContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, object container, object model) : base (default(Microsoft.AspNetCore.Mvc.ActionContext), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)) { }
        public object Container { get { throw null; } }
        public object Model { get { throw null; } }
    }
    public partial class ModelValidationContextBase
    {
        public ModelValidationContextBase(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } }
    }
    public partial class ModelValidationResult
    {
        public ModelValidationResult(string memberName, string message) { }
        public string MemberName { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class ModelValidatorProviderContext
    {
        public ModelValidatorProviderContext(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorItem> items) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorItem> Results { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> ValidatorMetadata { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ValidationEntry
    {
        private object _dummy;
        private int _dummyPrimitive;
        public ValidationEntry(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, System.Func<object> modelAccessor) { throw null; }
        public ValidationEntry(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
        public string Key { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } }
        public object Model { get { throw null; } }
    }
    public partial class ValidationStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>>, System.Collections.Generic.IDictionary<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>>, System.Collections.Generic.IReadOnlyDictionary<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>, System.Collections.IEnumerable
    {
        public ValidationStateDictionary() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry this[object key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<object> Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<object> System.Collections.Generic.IReadOnlyDictionary<System.Object,Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry> System.Collections.Generic.IReadOnlyDictionary<System.Object,Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>.Values { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry> item) { }
        public void Add(object key, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry> item) { throw null; }
        public bool ContainsKey(object key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry>> GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<object, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry> item) { throw null; }
        public bool Remove(object key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(object key, out Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry value) { throw null; }
    }
    public partial class ValidationStateEntry
    {
        public ValidationStateEntry() { }
        public string Key { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy Strategy { get { throw null; } set { } }
        public bool SuppressValidation { get { throw null; } set { } }
    }
    public partial class ValidatorItem
    {
        public ValidatorItem() { }
        public ValidatorItem(object validatorMetadata) { }
        public bool IsReusable { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidator Validator { get { throw null; } set { } }
        public object ValidatorMetadata { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.Routing
{
    public partial class AttributeRouteInfo
    {
        public AttributeRouteInfo() { }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public bool SuppressLinkGeneration { get { throw null; } set { } }
        public bool SuppressPathMatching { get { throw null; } set { } }
        public string Template { get { throw null; } set { } }
    }
    public partial class UrlActionContext
    {
        public UrlActionContext() { }
        public string Action { get { throw null; } set { } }
        public string Controller { get { throw null; } set { } }
        public string Fragment { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Protocol { get { throw null; } set { } }
        public object Values { get { throw null; } set { } }
    }
    public partial class UrlRouteContext
    {
        public UrlRouteContext() { }
        public string Fragment { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Protocol { get { throw null; } set { } }
        public string RouteName { get { throw null; } set { } }
        public object Values { get { throw null; } set { } }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal static partial class ClosedGenericMatcher
    {
        public static System.Type ExtractGenericInterface(System.Type queryType, System.Type interfaceType) { throw null; }
    }
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
}
