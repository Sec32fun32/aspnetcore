// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ComponentParameter
    {
        private object _dummy;
        private int _dummyPrimitive;
        public string Assembly { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        public static (System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> parameterDefinitions, System.Collections.Generic.IList<object> parameterValues) FromParameterView(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ServerComponent
    {
        private object _dummy;
        private int _dummyPrimitive;
        public ServerComponent(int sequence, string assemblyName, string typeName, System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> parametersDefinitions, System.Collections.Generic.IList<object> parameterValues, System.Guid invocationId) { throw null; }
        public string AssemblyName { get { throw null; } set { } }
        public System.Guid InvocationId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> ParameterDefinitions { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> ParameterValues { get { throw null; } set { } }
        public int Sequence { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ServerComponentMarker
    {
        private object _dummy;
        private int _dummyPrimitive;
        public const string ServerMarkerType = "server";
        public string Descriptor { get { throw null; } set { } }
        public string PrerenderId { get { throw null; } set { } }
        public int? Sequence { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public Microsoft.AspNetCore.Components.ServerComponentMarker GetEndRecord() { throw null; }
        public static Microsoft.AspNetCore.Components.ServerComponentMarker NonPrerendered(int sequence, string descriptor) { throw null; }
        public static Microsoft.AspNetCore.Components.ServerComponentMarker Prerendered(int sequence, string descriptor) { throw null; }
    }
    internal static partial class ServerComponentSerializationSettings
    {
        public static readonly System.TimeSpan DataExpiration;
        public const string DataProtectionProviderPurpose = "Microsoft.AspNetCore.Components.ComponentDescriptorSerializer,V1";
        public static readonly System.Text.Json.JsonSerializerOptions JsonSerializationOptions;
    }
}
namespace Microsoft.AspNetCore.Components.Rendering
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ComponentRenderedText
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ComponentRenderedText(int componentId, System.Collections.Generic.IEnumerable<string> tokens) { throw null; }
        public int ComponentId { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Tokens { get { throw null; } }
    }
    internal partial class HtmlRenderer : Microsoft.AspNetCore.Components.RenderTree.Renderer
    {
        public HtmlRenderer(System.IServiceProvider serviceProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Func<string, string> htmlEncoder) : base (default(System.IServiceProvider), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public override Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get { throw null; } }
        protected override void HandleException(System.Exception exception) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Rendering.ComponentRenderedText> RenderComponentAsync(System.Type componentType, Microsoft.AspNetCore.Components.ParameterView initialParameters) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Rendering.ComponentRenderedText> RenderComponentAsync<TComponent>(Microsoft.AspNetCore.Components.ParameterView initialParameters) where TComponent : Microsoft.AspNetCore.Components.IComponent { throw null; }
        protected override System.Threading.Tasks.Task UpdateDisplayAsync(in Microsoft.AspNetCore.Components.RenderTree.RenderBatch renderBatch) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class AutoValidateAntiforgeryTokenAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public AutoValidateAntiforgeryTokenAttribute() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    public abstract partial class Controller : Microsoft.AspNetCore.Mvc.ControllerBase, Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, System.IDisposable
    {
        protected Controller() { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public dynamic ViewBag { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionaryAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.JsonResult Json(object data) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.JsonResult Json(object data, object serializerSettings) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual System.Threading.Tasks.Task OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate next) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult PartialView() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult PartialView(object model) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult PartialView(string viewName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PartialViewResult PartialView(string viewName, object model) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewResult View() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewResult View(object model) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewResult View(string viewName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewResult View(string viewName, object model) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(string componentName, object arguments) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ViewComponentResult ViewComponent(System.Type componentType, object arguments) { throw null; }
    }
    public partial class CookieTempDataProviderOptions
    {
        public CookieTempDataProviderOptions() { }
        public Microsoft.AspNetCore.Http.CookieBuilder Cookie { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class IgnoreAntiforgeryTokenAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.ViewFeatures.IAntiforgeryPolicy
    {
        public IgnoreAntiforgeryTokenAttribute() { }
        public int Order { get { throw null; } set { } }
    }
    public partial interface IViewComponentHelper
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(string name, object arguments);
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(System.Type componentType, object arguments);
    }
    public partial interface IViewComponentResult
    {
        void Execute(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
        System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
    }
    public partial class MvcViewOptions : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>, System.Collections.IEnumerable
    {
        public MvcViewOptions() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidatorProvider> ClientModelValidatorProviders { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions HtmlHelperOptions { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine> ViewEngines { get { throw null; } }
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class PageRemoteAttribute : Microsoft.AspNetCore.Mvc.RemoteAttributeBase
    {
        public PageRemoteAttribute() { }
        public string PageHandler { get { throw null; } set { } }
        public string PageName { get { throw null; } set { } }
        protected override string GetUrl(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientModelValidationContext context) { throw null; }
    }
    public partial class PartialViewResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public PartialViewResult() { }
        public string ContentType { get { throw null; } set { } }
        public object Model { get { throw null; } }
        public int? StatusCode { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine ViewEngine { get { throw null; } set { } }
        public string ViewName { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class RemoteAttribute : Microsoft.AspNetCore.Mvc.RemoteAttributeBase
    {
        protected RemoteAttribute() { }
        public RemoteAttribute(string routeName) { }
        public RemoteAttribute(string action, string controller) { }
        public RemoteAttribute(string action, string controller, string areaName) { }
        protected string RouteName { get { throw null; } set { } }
        protected override string GetUrl(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientModelValidationContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public abstract partial class RemoteAttributeBase : System.ComponentModel.DataAnnotations.ValidationAttribute, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidator
    {
        protected RemoteAttributeBase() { }
        public string AdditionalFields { get { throw null; } set { } }
        public string HttpMethod { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Routing.RouteValueDictionary RouteData { get { throw null; } }
        public virtual void AddValidation(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientModelValidationContext context) { }
        public string FormatAdditionalFieldsForClientValidation(string property) { throw null; }
        public override string FormatErrorMessage(string name) { throw null; }
        public static string FormatPropertyForClientValidation(string property) { throw null; }
        protected abstract string GetUrl(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientModelValidationContext context);
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class SkipStatusCodePagesAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter
    {
        public SkipStatusCodePagesAttribute() { }
        public void OnResourceExecuted(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext context) { }
        public void OnResourceExecuting(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, Inherited=true, AllowMultiple=false)]
    public sealed partial class TempDataAttribute : System.Attribute
    {
        public TempDataAttribute() { }
        public string Key { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class ValidateAntiForgeryTokenAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ValidateAntiForgeryTokenAttribute() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [Microsoft.AspNetCore.Mvc.ViewComponentAttribute]
    public abstract partial class ViewComponent
    {
        protected ViewComponent() { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get { throw null; } set { } }
        public System.Security.Principal.IPrincipal User { get { throw null; } }
        public System.Security.Claims.ClaimsPrincipal UserClaimsPrincipal { get { throw null; } }
        public dynamic ViewBag { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContextAttribute]
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext ViewComponentContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine ViewEngine { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ContentViewComponentResult Content(string content) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewViewComponentResult View() { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewViewComponentResult View(string viewName) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewViewComponentResult View<TModel>(string viewName, TModel model) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewViewComponentResult View<TModel>(TModel model) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class ViewComponentAttribute : System.Attribute
    {
        public ViewComponentAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    public partial class ViewComponentResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public ViewComponentResult() { }
        public object Arguments { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public object Model { get { throw null; } }
        public int? StatusCode { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public string ViewComponentName { get { throw null; } set { } }
        public System.Type ViewComponentType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, Inherited=true, AllowMultiple=false)]
    public sealed partial class ViewDataAttribute : System.Attribute
    {
        public ViewDataAttribute() { }
        public string Key { get { throw null; } set { } }
    }
    public partial class ViewResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public ViewResult() { }
        public string ContentType { get { throw null; } set { } }
        public object Model { get { throw null; } }
        public int? StatusCode { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine ViewEngine { get { throw null; } set { } }
        public string ViewName { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Diagnostics
{
    public sealed partial class AfterViewComponentEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterViewComponent";
        public AfterViewComponentEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext viewComponentContext, Microsoft.AspNetCore.Mvc.IViewComponentResult viewComponentResult, object viewComponent) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public object ViewComponent { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext ViewComponentContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IViewComponentResult ViewComponentResult { get { throw null; } }
    }
    public sealed partial class AfterViewEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterView";
        public AfterViewEventData(Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
    }
    public sealed partial class BeforeViewComponentEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeViewComponent";
        public BeforeViewComponentEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext viewComponentContext, object viewComponent) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public object ViewComponent { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext ViewComponentContext { get { throw null; } }
    }
    public sealed partial class BeforeViewEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeView";
        public BeforeViewEventData(Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
    }
    public sealed partial class ViewComponentAfterViewExecuteEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.ViewComponentAfterViewExecute";
        public ViewComponentAfterViewExecuteEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext viewComponentContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext ViewComponentContext { get { throw null; } }
    }
    public sealed partial class ViewComponentBeforeViewExecuteEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.ViewComponentBeforeViewExecute";
        public ViewComponentBeforeViewExecuteEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext viewComponentContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext ViewComponentContext { get { throw null; } }
    }
    public sealed partial class ViewFoundEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.ViewFound";
        public ViewFoundEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, bool isMainPage, Microsoft.AspNetCore.Mvc.ActionResult result, string viewName, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public bool IsMainPage { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ActionResult Result { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public string ViewName { get { throw null; } }
    }
    public sealed partial class ViewNotFoundEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.ViewNotFound";
        public ViewNotFoundEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, bool isMainPage, Microsoft.AspNetCore.Mvc.ActionResult result, string viewName, System.Collections.Generic.IEnumerable<string> searchedLocations) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public bool IsMainPage { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ActionResult Result { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> SearchedLocations { get { throw null; } }
        public string ViewName { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    public static partial class ModelStateDictionaryExtensions
    {
        public static void AddModelError<TModel>(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Linq.Expressions.Expression<System.Func<TModel, object>> expression, System.Exception exception, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { }
        public static void AddModelError<TModel>(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Linq.Expressions.Expression<System.Func<TModel, object>> expression, string errorMessage) { }
        public static void RemoveAll<TModel>(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Linq.Expressions.Expression<System.Func<TModel, object>> expression) { }
        public static bool Remove<TModel>(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Linq.Expressions.Expression<System.Func<TModel, object>> expression) { throw null; }
        public static void TryAddModelException<TModel>(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Linq.Expressions.Expression<System.Func<TModel, object>> expression, System.Exception exception) { }
    }
}
namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public enum FormMethod
    {
        Get = 0,
        Post = 1,
    }
    public enum Html5DateRenderingMode
    {
        Rfc3339 = 0,
        CurrentCulture = 1,
    }
    public static partial class HtmlHelperComponentExtensions
    {
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> RenderComponentAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, System.Type componentType, Microsoft.AspNetCore.Mvc.Rendering.RenderMode renderMode, object parameters) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> RenderComponentAsync<TComponent>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, Microsoft.AspNetCore.Mvc.Rendering.RenderMode renderMode) where TComponent : Microsoft.AspNetCore.Components.IComponent { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> RenderComponentAsync<TComponent>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, Microsoft.AspNetCore.Mvc.Rendering.RenderMode renderMode, object parameters) where TComponent : Microsoft.AspNetCore.Components.IComponent { throw null; }
    }
    public static partial class HtmlHelperDisplayExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent Display(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Display(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Display(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Display(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Display(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName, string htmlFieldName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, string htmlFieldName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName) { throw null; }
    }
    public static partial class HtmlHelperDisplayNameExtensions
    {
        public static string DisplayNameForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static string DisplayNameFor<TModelItem, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.IEnumerable<TModelItem>> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModelItem, TResult>> expression) { throw null; }
    }
    public static partial class HtmlHelperEditorExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent Editor(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Editor(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Editor(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Editor(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Editor(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string templateName, string htmlFieldName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, string htmlFieldName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, object additionalViewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName) { throw null; }
    }
    public static partial class HtmlHelperFormExtensions
    {
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, bool? antiforgery) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string actionName, string controllerName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string actionName, string controllerName, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string actionName, string controllerName, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object routeValues, bool? antiforgery) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName, bool? antiforgery) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string routeName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
    }
    public static partial class HtmlHelperInputExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent CheckBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent CheckBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, bool isChecked) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent CheckBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent CheckBoxFor<TModel>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Hidden(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Hidden(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent HiddenFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Password(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Password(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent PasswordFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RadioButton(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RadioButton(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value, bool isChecked) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RadioButton(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RadioButtonFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextArea(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextArea(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextArea(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextArea(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string value, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextAreaFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextAreaFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object value, string format) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBoxFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBoxFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TextBoxFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string format) { throw null; }
    }
    public static partial class HtmlHelperLabelExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent Label(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Label(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string labelText) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string labelText) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string labelText, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent LabelFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string labelText) { throw null; }
    }
    public static partial class HtmlHelperLinkExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName, object routeValues, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName, string controllerName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName, string controllerName, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ActionLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper helper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RouteLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string linkText, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RouteLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string linkText, object routeValues, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RouteLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string linkText, string routeName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RouteLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string linkText, string routeName, object routeValues) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent RouteLink(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string linkText, string routeName, object routeValues, object htmlAttributes) { throw null; }
    }
    public static partial class HtmlHelperNameExtensions
    {
        public static string IdForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static string NameForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
    }
    public static partial class HtmlHelperPartialExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent Partial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Partial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Partial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent Partial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> PartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> PartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> PartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model) { throw null; }
        public static void RenderPartial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName) { }
        public static void RenderPartial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { }
        public static void RenderPartial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model) { }
        public static void RenderPartial(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { }
        public static System.Threading.Tasks.Task RenderPartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName) { throw null; }
        public static System.Threading.Tasks.Task RenderPartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        public static System.Threading.Tasks.Task RenderPartialAsync(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string partialViewName, object model) { throw null; }
    }
    public static partial class HtmlHelperSelectExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownList(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownList(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownList(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownList(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownList(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string optionLabel) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownListFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownListFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DropDownListFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ListBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ListBox(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ListBoxFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList) { throw null; }
    }
    public static partial class HtmlHelperValidationExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string message) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string message, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression, string message, string tag) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string message) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string message, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string message, string tag) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, bool excludePropertyErrors) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, bool excludePropertyErrors, string message) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, bool excludePropertyErrors, string message, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, bool excludePropertyErrors, string message, string tag) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string message) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string message, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string message, object htmlAttributes, string tag) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string message, string tag) { throw null; }
    }
    public static partial class HtmlHelperValueExtensions
    {
        public static string Value(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string expression) { throw null; }
        public static string ValueForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static string ValueForModel(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string format) { throw null; }
        public static string ValueFor<TModel, TResult>(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
    }
    public partial interface IHtmlHelper
    {
        Microsoft.AspNetCore.Mvc.Rendering.Html5DateRenderingMode Html5DateRenderingMode { get; set; }
        string IdAttributeDotReplacement { get; }
        Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get; }
        Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get; }
        System.Text.Encodings.Web.UrlEncoder UrlEncoder { get; }
        dynamic ViewBag { get; }
        Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; }
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get; }
        Microsoft.AspNetCore.Html.IHtmlContent ActionLink(string linkText, string actionName, string controllerName, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent AntiForgeryToken();
        Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(string actionName, string controllerName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(string routeName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent CheckBox(string expression, bool? isChecked, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent Display(string expression, string templateName, string htmlFieldName, object additionalViewData);
        string DisplayName(string expression);
        string DisplayText(string expression);
        Microsoft.AspNetCore.Html.IHtmlContent DropDownList(string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent Editor(string expression, string templateName, string htmlFieldName, object additionalViewData);
        string Encode(object value);
        string Encode(string value);
        void EndForm();
        string FormatValue(object value, string format);
        string GenerateIdFromName(string fullName);
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumSelectList(System.Type enumType);
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumSelectList<TEnum>() where TEnum : struct;
        Microsoft.AspNetCore.Html.IHtmlContent Hidden(string expression, object value, object htmlAttributes);
        string Id(string expression);
        Microsoft.AspNetCore.Html.IHtmlContent Label(string expression, string labelText, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent ListBox(string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes);
        string Name(string expression);
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> PartialAsync(string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData);
        Microsoft.AspNetCore.Html.IHtmlContent Password(string expression, object value, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent RadioButton(string expression, object value, bool? isChecked, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent Raw(object value);
        Microsoft.AspNetCore.Html.IHtmlContent Raw(string value);
        System.Threading.Tasks.Task RenderPartialAsync(string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData);
        Microsoft.AspNetCore.Html.IHtmlContent RouteLink(string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent TextArea(string expression, string value, int rows, int columns, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent TextBox(string expression, object value, string format, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(string expression, string message, object htmlAttributes, string tag);
        Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(bool excludePropertyErrors, string message, object htmlAttributes, string tag);
        string Value(string expression, string format);
    }
    public partial interface IHtmlHelper<TModel> : Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper
    {
        new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> ViewData { get; }
        Microsoft.AspNetCore.Html.IHtmlContent CheckBoxFor(System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName, object additionalViewData);
        string DisplayNameForInnerType<TModelItem, TResult>(System.Linq.Expressions.Expression<System.Func<TModelItem, TResult>> expression);
        string DisplayNameFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression);
        string DisplayTextFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression);
        Microsoft.AspNetCore.Html.IHtmlContent DropDownListFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName, object additionalViewData);
        new string Encode(object value);
        new string Encode(string value);
        Microsoft.AspNetCore.Html.IHtmlContent HiddenFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes);
        string IdFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression);
        Microsoft.AspNetCore.Html.IHtmlContent LabelFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string labelText, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent ListBoxFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes);
        string NameFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression);
        Microsoft.AspNetCore.Html.IHtmlContent PasswordFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent RadioButtonFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object value, object htmlAttributes);
        new Microsoft.AspNetCore.Html.IHtmlContent Raw(object value);
        new Microsoft.AspNetCore.Html.IHtmlContent Raw(string value);
        Microsoft.AspNetCore.Html.IHtmlContent TextAreaFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, int rows, int columns, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent TextBoxFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string format, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string message, object htmlAttributes, string tag);
        string ValueFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string format);
    }
    public partial interface IJsonHelper
    {
        Microsoft.AspNetCore.Html.IHtmlContent Serialize(object value);
    }
    public partial class MultiSelectList : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>, System.Collections.IEnumerable
    {
        public MultiSelectList(System.Collections.IEnumerable items) { }
        public MultiSelectList(System.Collections.IEnumerable items, System.Collections.IEnumerable selectedValues) { }
        public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) { }
        public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, System.Collections.IEnumerable selectedValues) { }
        public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, System.Collections.IEnumerable selectedValues, string dataGroupField) { }
        public string DataGroupField { get { throw null; } }
        public string DataTextField { get { throw null; } }
        public string DataValueField { get { throw null; } }
        public System.Collections.IEnumerable Items { get { throw null; } }
        public System.Collections.IEnumerable SelectedValues { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MvcForm : System.IDisposable
    {
        public MvcForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) { }
        public void Dispose() { }
        public void EndForm() { }
        protected virtual void GenerateEndForm() { }
    }
    public enum RenderMode
    {
        Static = 1,
        Server = 2,
        ServerPrerendered = 3,
    }
    public partial class SelectList : Microsoft.AspNetCore.Mvc.Rendering.MultiSelectList
    {
        public SelectList(System.Collections.IEnumerable items) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, object selectedValue, string dataGroupField) : base (default(System.Collections.IEnumerable)) { }
        public object SelectedValue { get { throw null; } }
    }
    public partial class SelectListGroup
    {
        public SelectListGroup() { }
        public bool Disabled { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class SelectListItem
    {
        public SelectListItem() { }
        public SelectListItem(string text, string value) { }
        public SelectListItem(string text, string value, bool selected) { }
        public SelectListItem(string text, string value, bool selected, bool disabled) { }
        public bool Disabled { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Rendering.SelectListGroup Group { get { throw null; } set { } }
        public bool Selected { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    internal partial class SystemTextJsonHelper : Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper
    {
        public SystemTextJsonHelper(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.JsonOptions> options) { }
        public Microsoft.AspNetCore.Html.IHtmlContent Serialize(object value) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public partial class TagBuilder : Microsoft.AspNetCore.Html.IHtmlContent
    {
        public TagBuilder(string tagName) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.AttributeDictionary Attributes { get { throw null; } }
        public bool HasInnerHtml { get { throw null; } }
        public Microsoft.AspNetCore.Html.IHtmlContentBuilder InnerHtml { get { throw null; } }
        public string TagName { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.TagRenderMode TagRenderMode { get { throw null; } set { } }
        public void AddCssClass(string value) { }
        public static string CreateSanitizedId(string name, string invalidCharReplacement) { throw null; }
        public void GenerateId(string name, string invalidCharReplacement) { }
        public void MergeAttribute(string key, string value) { }
        public void MergeAttribute(string key, string value, bool replaceExisting) { }
        public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes) { }
        public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes, bool replaceExisting) { }
        public Microsoft.AspNetCore.Html.IHtmlContent RenderBody() { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RenderEndTag() { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RenderSelfClosingTag() { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RenderStartTag() { throw null; }
        public void WriteTo(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { }
    }
    public enum TagRenderMode
    {
        Normal = 0,
        StartTag = 1,
        EndTag = 2,
        SelfClosing = 3,
    }
    public static partial class ViewComponentHelperExtensions
    {
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(this Microsoft.AspNetCore.Mvc.IViewComponentHelper helper, string name) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(this Microsoft.AspNetCore.Mvc.IViewComponentHelper helper, System.Type componentType) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync<TComponent>(this Microsoft.AspNetCore.Mvc.IViewComponentHelper helper) { throw null; }
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync<TComponent>(this Microsoft.AspNetCore.Mvc.IViewComponentHelper helper, object arguments) { throw null; }
    }
    public partial class ViewContext : Microsoft.AspNetCore.Mvc.ActionContext
    {
        public ViewContext() { }
        public ViewContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, System.IO.TextWriter writer, Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions htmlHelperOptions) { }
        public ViewContext(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, System.IO.TextWriter writer) { }
        public bool ClientValidationEnabled { get { throw null; } set { } }
        public string ExecutingFilePath { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.ViewFeatures.FormContext FormContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Rendering.Html5DateRenderingMode Html5DateRenderingMode { get { throw null; } set { } }
        internal System.Collections.Generic.Dictionary<object, object> Items { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public string ValidationMessageElement { get { throw null; } set { } }
        public string ValidationSummaryMessageElement { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } set { } }
        public dynamic ViewBag { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public System.IO.TextWriter Writer { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.FormContext GetFormContextForClientValidation() { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewComponents
{
    public partial class ContentViewComponentResult : Microsoft.AspNetCore.Mvc.IViewComponentResult
    {
        public ContentViewComponentResult(string content) { }
        public string Content { get { throw null; } }
        public void Execute(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { }
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
    }
    internal partial class DefaultViewComponentActivator : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator
    {
        public DefaultViewComponentActivator(Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache typeActivatorCache) { }
        public object Create(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
        public void Release(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object viewComponent) { }
    }
    public partial class DefaultViewComponentDescriptorCollectionProvider : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider
    {
        public DefaultViewComponentDescriptorCollectionProvider(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider descriptorProvider) { }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptorCollection ViewComponents { get { throw null; } }
    }
    public partial class DefaultViewComponentDescriptorProvider : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider
    {
        public DefaultViewComponentDescriptorProvider(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager partManager) { }
        protected virtual System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> GetCandidateTypes() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor> GetViewComponents() { throw null; }
    }
    public partial class DefaultViewComponentFactory : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory
    {
        public DefaultViewComponentFactory(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator activator) { }
        public object CreateViewComponent(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
        public void ReleaseViewComponent(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object component) { }
    }
    public partial class DefaultViewComponentHelper : Microsoft.AspNetCore.Mvc.IViewComponentHelper, Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware
    {
        public DefaultViewComponentHelper(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider descriptorProvider, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector selector, Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory invokerFactory, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope viewBufferScope) { }
        public void Contextualize(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        internal System.Collections.Generic.IDictionary<string, object> GetArgumentDictionary(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor descriptor, object arguments) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(string name, object arguments) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> InvokeAsync(System.Type componentType, object arguments) { throw null; }
    }
    internal partial class DefaultViewComponentInvoker : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvoker
    {
        public DefaultViewComponentInvoker(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory viewComponentFactory, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentInvokerCache viewComponentInvokerCache, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILogger logger) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task InvokeAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
    }
    internal partial class DefaultViewComponentInvokerFactory : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory
    {
        public DefaultViewComponentInvokerFactory(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory viewComponentFactory, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentInvokerCache viewComponentInvokerCache, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvoker CreateInstance(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
    }
    public partial class DefaultViewComponentSelector : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector
    {
        public DefaultViewComponentSelector(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider descriptorProvider) { }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor SelectComponent(string componentName) { throw null; }
    }
    public partial class HtmlContentViewComponentResult : Microsoft.AspNetCore.Mvc.IViewComponentResult
    {
        public HtmlContentViewComponentResult(Microsoft.AspNetCore.Html.IHtmlContent encodedContent) { }
        public Microsoft.AspNetCore.Html.IHtmlContent EncodedContent { get { throw null; } }
        public void Execute(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { }
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
    }
    public partial interface IViewComponentActivator
    {
        object Create(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
        void Release(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object viewComponent);
    }
    public partial interface IViewComponentDescriptorCollectionProvider
    {
        Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptorCollection ViewComponents { get; }
    }
    public partial interface IViewComponentDescriptorProvider
    {
        System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor> GetViewComponents();
    }
    public partial interface IViewComponentFactory
    {
        object CreateViewComponent(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
        void ReleaseViewComponent(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object component);
    }
    public partial interface IViewComponentInvoker
    {
        System.Threading.Tasks.Task InvokeAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
    }
    public partial interface IViewComponentInvokerFactory
    {
        Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvoker CreateInstance(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context);
    }
    public partial interface IViewComponentSelector
    {
        Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor SelectComponent(string componentName);
    }
    public partial class ServiceBasedViewComponentActivator : Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator
    {
        public ServiceBasedViewComponentActivator() { }
        public object Create(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
        public virtual void Release(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object viewComponent) { }
    }
    public partial class ViewComponentContext
    {
        public ViewComponentContext() { }
        public ViewComponentContext(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor viewComponentDescriptor, System.Collections.Generic.IDictionary<string, object> arguments, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, System.IO.TextWriter writer) { }
        public System.Collections.Generic.IDictionary<string, object> Arguments { get { throw null; } set { } }
        public System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor ViewComponentDescriptor { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } }
        public System.IO.TextWriter Writer { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class ViewComponentContextAttribute : System.Attribute
    {
        public ViewComponentContextAttribute() { }
    }
    public static partial class ViewComponentConventions
    {
        public static readonly string ViewComponentSuffix;
        public static string GetComponentFullName(System.Reflection.TypeInfo componentType) { throw null; }
        public static string GetComponentName(System.Reflection.TypeInfo componentType) { throw null; }
        public static bool IsComponent(System.Reflection.TypeInfo typeInfo) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DisplayName}")]
    public partial class ViewComponentDescriptor
    {
        public ViewComponentDescriptor() { }
        public string DisplayName { get { throw null; } set { } }
        public string FullName { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<System.Reflection.ParameterInfo> Parameters { get { throw null; } set { } }
        public string ShortName { get { throw null; } set { } }
        public System.Reflection.TypeInfo TypeInfo { get { throw null; } set { } }
    }
    public partial class ViewComponentDescriptorCollection
    {
        public ViewComponentDescriptorCollection(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor> items, int version) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentDescriptor> Items { get { throw null; } }
        public int Version { get { throw null; } }
    }
    public partial class ViewComponentFeature
    {
        public ViewComponentFeature() { }
        public System.Collections.Generic.IList<System.Reflection.TypeInfo> ViewComponents { get { throw null; } }
    }
    public partial class ViewComponentFeatureProvider : Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider, Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider<Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentFeature>
    {
        public ViewComponentFeatureProvider() { }
        public void PopulateFeature(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> parts, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentFeature feature) { }
    }
    internal partial class ViewComponentInvokerCache
    {
        public ViewComponentInvokerCache(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider collectionProvider) { }
        internal Microsoft.Extensions.Internal.ObjectMethodExecutor GetViewComponentMethodExecutor(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext viewComponentContext) { throw null; }
    }
    public partial class ViewViewComponentResult : Microsoft.AspNetCore.Mvc.IViewComponentResult
    {
        public ViewViewComponentResult() { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine ViewEngine { get { throw null; } set { } }
        public string ViewName { get { throw null; } set { } }
        public void Execute(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewEngines
{
    public partial class CompositeViewEngine : Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine, Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine
    {
        public CompositeViewEngine(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> optionsAccessor) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine> ViewEngines { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult FindView(Microsoft.AspNetCore.Mvc.ActionContext context, string viewName, bool isMainPage) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage) { throw null; }
    }
    public partial interface ICompositeViewEngine : Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine
    {
        System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine> ViewEngines { get; }
    }
    public partial interface IView
    {
        string Path { get; }
        System.Threading.Tasks.Task RenderAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context);
    }
    public partial interface IViewEngine
    {
        Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult FindView(Microsoft.AspNetCore.Mvc.ActionContext context, string viewName, bool isMainPage);
        Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage);
    }
    public partial class ViewEngineResult
    {
        private ViewEngineResult() { }
        public System.Collections.Generic.IEnumerable<string> SearchedLocations { get { throw null; } }
        public bool Success { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.IView View { get { throw null; } }
        public string ViewName { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult EnsureSuccessful(System.Collections.Generic.IEnumerable<string> originalLocations) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult Found(string viewName, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult NotFound(string viewName, System.Collections.Generic.IEnumerable<string> searchedLocations) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
    public static partial class AntiforgeryExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent GetHtml(this Microsoft.AspNetCore.Antiforgery.IAntiforgery antiforgery, Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
    }
    public partial class AttributeDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IDictionary<string, string>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IReadOnlyDictionary<string, string>, System.Collections.IEnumerable
    {
        public AttributeDictionary() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public string this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<string> System.Collections.Generic.IReadOnlyDictionary<System.String,System.String>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<string> System.Collections.Generic.IReadOnlyDictionary<System.String,System.String>.Values { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, string> item) { }
        public void Add(string key, string value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, string> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, string>[] array, int arrayIndex) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.AttributeDictionary.Enumerator GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, string> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out string value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(Microsoft.AspNetCore.Mvc.ViewFeatures.AttributeDictionary attributes) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, string> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    internal static partial class CachedExpressionCompiler
    {
        public static System.Func<TModel, object> Process<TModel, TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
    }
    internal partial class ComponentHtmlContent : Microsoft.AspNetCore.Html.IHtmlContent
    {
        public ComponentHtmlContent(System.Collections.Generic.IEnumerable<string> componentResult) { }
        public ComponentHtmlContent(System.Collections.Generic.IEnumerable<string> preamble, System.Collections.Generic.IEnumerable<string> componentResult, System.Collections.Generic.IEnumerable<string> epilogue) { }
        public void WriteTo(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { }
    }
    internal partial class ComponentRenderer : Microsoft.AspNetCore.Mvc.ViewFeatures.IComponentRenderer
    {
        public ComponentRenderer(Microsoft.AspNetCore.Mvc.ViewFeatures.StaticComponentRenderer staticComponentRenderer, Microsoft.AspNetCore.Mvc.ViewFeatures.ServerComponentSerializer serverComponentSerializer) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> RenderComponentAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, System.Type componentType, Microsoft.AspNetCore.Mvc.Rendering.RenderMode renderMode, object parameters) { throw null; }
    }
    public partial class CookieTempDataProvider : Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider
    {
        public static readonly string CookieName;
        public CookieTempDataProvider(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.CookieTempDataProviderOptions> options, Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer tempDataSerializer) { }
        public System.Collections.Generic.IDictionary<string, object> LoadTempData(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public void SaveTempData(Microsoft.AspNetCore.Http.HttpContext context, System.Collections.Generic.IDictionary<string, object> values) { }
    }
    internal static partial class DefaultDisplayTemplates
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent BooleanTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent CollectionTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DecimalTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EmailAddressTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent HiddenInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent HtmlTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ObjectTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent StringTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        internal static System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> TriStateValues(bool? value) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent UrlTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
    }
    internal static partial class DefaultEditorTemplates
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent BooleanTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent CollectionTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DateInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DateTimeLocalInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DateTimeOffsetTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent DecimalTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent EmailAddressInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent FileCollectionInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent FileInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent HiddenInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent MonthInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent MultilineTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent NumberInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent ObjectTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent PasswordTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent PhoneNumberInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent StringTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent TimeInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent UrlInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
        public static Microsoft.AspNetCore.Html.IHtmlContent WeekInputTemplate(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper) { throw null; }
    }
    public partial class DefaultHtmlGenerator : Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator
    {
        public DefaultHtmlGenerator(Microsoft.AspNetCore.Antiforgery.IAntiforgery antiforgery, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> optionsAccessor, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ViewFeatures.ValidationHtmlAttributeProvider validationAttributeProvider) { }
        protected bool AllowRenderingMaxLengthAttribute { get { throw null; } }
        public string IdAttributeDotReplacement { get { throw null; } }
        protected virtual void AddMaxLengthAttribute(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.Rendering.TagBuilder tagBuilder, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression) { }
        protected virtual void AddPlaceholderAttribute(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.Rendering.TagBuilder tagBuilder, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression) { }
        protected virtual void AddValidationAttributes(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.Rendering.TagBuilder tagBuilder, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression) { }
        public string Encode(object value) { throw null; }
        public string Encode(string value) { throw null; }
        internal static string EvalString(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string key, string format) { throw null; }
        public string FormatValue(object value, string format) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateActionLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string actionName, string controllerName, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateAntiforgery(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateCheckBox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, bool? isChecked, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string actionName, string controllerName, object routeValues, string method, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateFormCore(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string action, string method, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent GenerateGroupsAndOptions(string optionLabel, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateHidden(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool useViewData, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateHiddenForCheckbox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateInput(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.InputType inputType, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool useViewData, bool isChecked, bool setId, bool isExplicitValue, string format, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateLabel(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string labelText, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateLink(string linkText, string url, object htmlAttributes) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateOption(Microsoft.AspNetCore.Mvc.Rendering.SelectListItem item, string text) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateOption(Microsoft.AspNetCore.Mvc.Rendering.SelectListItem item, string text, bool selected) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePageForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string pageName, string pageHandler, object routeValues, string fragment, string method, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePageLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string pageName, string pageHandler, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePassword(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRadioButton(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool? isChecked, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRouteForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string routeName, object routeValues, string method, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRouteLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateSelect(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string optionLabel, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, bool allowMultiple, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateSelect(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string optionLabel, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, System.Collections.Generic.ICollection<string> currentValues, bool allowMultiple, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateTextArea(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, int rows, int columns, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateTextBox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, string format, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateValidationMessage(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string message, string tag, object htmlAttributes) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateValidationSummary(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, bool excludePropertyErrors, string message, string headerTag, object htmlAttributes) { throw null; }
        public virtual System.Collections.Generic.ICollection<string> GetCurrentValues(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, bool allowMultiple) { throw null; }
        internal static object GetModelStateValue(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string key, System.Type destinationType) { throw null; }
    }
    public static partial class DefaultHtmlGeneratorExtensions
    {
        public static Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateForm(this Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string actionName, string controllerName, string fragment, object routeValues, string method, object htmlAttributes) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRouteForm(this Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string routeName, object routeValues, string fragment, string method, object htmlAttributes) { throw null; }
    }
    public partial class DefaultValidationHtmlAttributeProvider : Microsoft.AspNetCore.Mvc.ViewFeatures.ValidationHtmlAttributeProvider
    {
        public DefaultValidationHtmlAttributeProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> optionsAccessor, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorCache clientValidatorCache) { }
        public override void AddValidationAttributes(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, System.Collections.Generic.IDictionary<string, string> attributes) { }
    }
    internal partial class DynamicViewData : System.Dynamic.DynamicObject
    {
        public DynamicViewData(System.Func<Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary> viewDataFunc) { }
        public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames() { throw null; }
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) { throw null; }
        public override bool TrySetMember(System.Dynamic.SetMemberBinder binder, object value) { throw null; }
    }
    internal static partial class ExpressionHelper
    {
        public static string GetExpressionText(System.Linq.Expressions.LambdaExpression expression, System.Collections.Concurrent.ConcurrentDictionary<System.Linq.Expressions.LambdaExpression, string> expressionTextCache) { throw null; }
        public static string GetUncachedExpressionText(System.Linq.Expressions.LambdaExpression expression) { throw null; }
        public static bool IsSingleArgumentIndexer(System.Linq.Expressions.Expression expression) { throw null; }
    }
    internal static partial class ExpressionMetadataProvider
    {
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer FromLambdaExpression<TModel, TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> viewData, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer FromStringExpression(string expression, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider) { throw null; }
    }
    internal static partial class FormatWeekHelper
    {
        public static string GetFormattedWeek(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { throw null; }
    }
    public partial class FormContext
    {
        public FormContext() { }
        public bool CanRenderAtEndOfForm { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Html.IHtmlContent> EndOfFormContent { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> FormData { get { throw null; } }
        public bool HasAntiforgeryToken { get { throw null; } set { } }
        public bool HasEndOfFormContent { get { throw null; } }
        public bool HasFormData { get { throw null; } }
        public bool RenderedField(string fieldName) { throw null; }
        public void RenderedField(string fieldName, bool value) { }
    }
    internal partial class HtmlAttributePropertyHelper : Microsoft.Extensions.Internal.PropertyHelper
    {
        public HtmlAttributePropertyHelper(System.Reflection.PropertyInfo property) : base (default(System.Reflection.PropertyInfo)) { }
        public override string Name { get { throw null; } protected set { } }
        public static new Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Type type) { throw null; }
    }
    public partial class HtmlHelper : Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper, Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware
    {
        public static readonly string ValidationInputCssClassName;
        public static readonly string ValidationInputValidCssClassName;
        public static readonly string ValidationMessageCssClassName;
        public static readonly string ValidationMessageValidCssClassName;
        public static readonly string ValidationSummaryCssClassName;
        public static readonly string ValidationSummaryValidCssClassName;
        public HtmlHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator htmlGenerator, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope bufferScope, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.Text.Encodings.Web.UrlEncoder urlEncoder) { }
        public Microsoft.AspNetCore.Mvc.Rendering.Html5DateRenderingMode Html5DateRenderingMode { get { throw null; } set { } }
        public string IdAttributeDotReplacement { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary TempData { get { throw null; } }
        public System.Text.Encodings.Web.UrlEncoder UrlEncoder { get { throw null; } }
        public dynamic ViewBag { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } }
        public Microsoft.AspNetCore.Html.IHtmlContent ActionLink(string linkText, string actionName, string controllerName, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> AnonymousObjectToHtmlAttributes(object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent AntiForgeryToken() { throw null; }
        public Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginForm(string actionName, string controllerName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Mvc.Rendering.MvcForm BeginRouteForm(string routeName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent CheckBox(string expression, bool? isChecked, object htmlAttributes) { throw null; }
        public virtual void Contextualize(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.MvcForm CreateForm() { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Display(string expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public string DisplayName(string expression) { throw null; }
        public string DisplayText(string expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent DropDownList(string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Editor(string expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public string Encode(object value) { throw null; }
        public string Encode(string value) { throw null; }
        public void EndForm() { }
        public string FormatValue(object value, string format) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateCheckBox(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, bool? isChecked, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateDisplay(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string htmlFieldName, string templateName, object additionalViewData) { throw null; }
        protected virtual string GenerateDisplayName(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression) { throw null; }
        protected virtual string GenerateDisplayText(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { throw null; }
        protected Microsoft.AspNetCore.Html.IHtmlContent GenerateDropDown(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateEditor(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string htmlFieldName, string templateName, object additionalViewData) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.MvcForm GenerateForm(string actionName, string controllerName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateHidden(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool useViewData, object htmlAttributes) { throw null; }
        protected virtual string GenerateId(string expression) { throw null; }
        public string GenerateIdFromName(string fullName) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateLabel(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string labelText, object htmlAttributes) { throw null; }
        protected Microsoft.AspNetCore.Html.IHtmlContent GenerateListBox(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes) { throw null; }
        protected virtual string GenerateName(string expression) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GeneratePassword(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateRadioButton(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool? isChecked, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Rendering.MvcForm GenerateRouteForm(string routeName, object routeValues, Microsoft.AspNetCore.Mvc.Rendering.FormMethod method, bool? antiforgery, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateTextArea(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, int rows, int columns, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateTextBox(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, string format, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateValidationMessage(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string message, string tag, object htmlAttributes) { throw null; }
        protected virtual Microsoft.AspNetCore.Html.IHtmlContent GenerateValidationSummary(bool excludePropertyErrors, string message, object htmlAttributes, string tag) { throw null; }
        protected virtual string GenerateValue(string expression, object value, string format, bool useViewData) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumSelectList(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { throw null; }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumSelectList(System.Type enumType) { throw null; }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetEnumSelectList<TEnum>() where TEnum : struct { throw null; }
        public static string GetFormMethodString(Microsoft.AspNetCore.Mvc.Rendering.FormMethod method) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Hidden(string expression, object value, object htmlAttributes) { throw null; }
        public string Id(string expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Label(string expression, string labelText, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent ListBox(string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public string Name(string expression) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> ObjectToDictionary(object value) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> PartialAsync(string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Password(string expression, object value, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RadioButton(string expression, object value, bool? isChecked, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Raw(object value) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Raw(string value) { throw null; }
        public System.Threading.Tasks.Task RenderPartialAsync(string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected virtual System.Threading.Tasks.Task RenderPartialCoreAsync(string partialViewName, object model, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, System.IO.TextWriter writer) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RouteLink(string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent TextArea(string expression, string value, int rows, int columns, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent TextBox(string expression, object value, string format, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent ValidationMessage(string expression, string message, object htmlAttributes, string tag) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent ValidationSummary(bool excludePropertyErrors, string message, object htmlAttributes, string tag) { throw null; }
        public string Value(string expression, string format) { throw null; }
    }
    public partial class HtmlHelperOptions
    {
        public HtmlHelperOptions() { }
        public bool ClientValidationEnabled { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Rendering.Html5DateRenderingMode Html5DateRenderingMode { get { throw null; } set { } }
        public string IdAttributeDotReplacement { get { throw null; } set { } }
        public string ValidationMessageElement { get { throw null; } set { } }
        public string ValidationSummaryMessageElement { get { throw null; } set { } }
    }
    public partial class HtmlHelper<TModel> : Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper, Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper, Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TModel>
    {
        public HtmlHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator htmlGenerator, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope bufferScope, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.Text.Encodings.Web.UrlEncoder urlEncoder, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpressionProvider modelExpressionProvider) : base (default(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator), default(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope), default(System.Text.Encodings.Web.HtmlEncoder), default(System.Text.Encodings.Web.UrlEncoder)) { }
        public new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> ViewData { get { throw null; } }
        public Microsoft.AspNetCore.Html.IHtmlContent CheckBoxFor(System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression, object htmlAttributes) { throw null; }
        public override void Contextualize(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        public Microsoft.AspNetCore.Html.IHtmlContent DisplayFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public string DisplayNameForInnerType<TModelItem, TResult>(System.Linq.Expressions.Expression<System.Func<TModelItem, TResult>> expression) { throw null; }
        public string DisplayNameFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public string DisplayTextFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent DropDownListFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, string optionLabel, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent EditorFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        protected string GetExpressionName<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetModelExplorer<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent HiddenFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes) { throw null; }
        public string IdFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent LabelFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string labelText, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent ListBoxFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public string NameFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent PasswordFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent RadioButtonFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, object value, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent TextAreaFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, int rows, int columns, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent TextBoxFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string format, object htmlAttributes) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent ValidationMessageFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string message, object htmlAttributes, string tag) { throw null; }
        public string ValueFor<TResult>(System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression, string format) { throw null; }
    }
    internal partial class HttpNavigationManager : Microsoft.AspNetCore.Components.NavigationManager, Microsoft.AspNetCore.Components.Routing.IHostEnvironmentNavigationManager
    {
        public HttpNavigationManager() { }
        void Microsoft.AspNetCore.Components.Routing.IHostEnvironmentNavigationManager.Initialize(string baseUri, string uri) { }
        protected override void NavigateToCore(string uri, bool forceLoad) { }
    }
    public partial interface IAntiforgeryPolicy : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    internal partial interface IComponentRenderer
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> RenderComponentAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, System.Type componentType, Microsoft.AspNetCore.Mvc.Rendering.RenderMode renderMode, object parameters);
    }
    public partial interface IFileVersionProvider
    {
        string AddFileVersionToPath(Microsoft.AspNetCore.Http.PathString requestPathBase, string path);
    }
    public partial interface IHtmlGenerator
    {
        string IdAttributeDotReplacement { get; }
        string Encode(object value);
        string Encode(string value);
        string FormatValue(object value, string format);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateActionLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string actionName, string controllerName, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent GenerateAntiforgery(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateCheckBox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, bool? isChecked, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string actionName, string controllerName, object routeValues, string method, object htmlAttributes);
        Microsoft.AspNetCore.Html.IHtmlContent GenerateGroupsAndOptions(string optionLabel, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateHidden(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool useViewData, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateHiddenForCheckbox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateLabel(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string labelText, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePageForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string pageName, string pageHandler, object routeValues, string fragment, string method, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePageLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string pageName, string pageHandler, string protocol, string hostname, string fragment, object routeValues, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GeneratePassword(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRadioButton(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, bool? isChecked, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRouteForm(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string routeName, object routeValues, string method, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateRouteLink(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateSelect(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string optionLabel, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, bool allowMultiple, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateSelect(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string optionLabel, string expression, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> selectList, System.Collections.Generic.ICollection<string> currentValues, bool allowMultiple, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateTextArea(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, int rows, int columns, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateTextBox(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, object value, string format, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateValidationMessage(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, string message, string tag, object htmlAttributes);
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder GenerateValidationSummary(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, bool excludePropertyErrors, string message, string headerTag, object htmlAttributes);
        System.Collections.Generic.ICollection<string> GetCurrentValues(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, bool allowMultiple);
    }
    public partial interface IModelExpressionProvider
    {
        Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression CreateModelExpression<TModel, TValue>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> viewData, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression);
    }
    public enum InputType
    {
        CheckBox = 0,
        Hidden = 1,
        Password = 2,
        Radio = 3,
        Text = 4,
    }
    public partial interface ITempDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        void Keep();
        void Keep(string key);
        void Load();
        object Peek(string key);
        void Save();
    }
    public partial interface ITempDataDictionaryFactory
    {
        Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary GetTempData(Microsoft.AspNetCore.Http.HttpContext context);
    }
    public partial interface ITempDataProvider
    {
        System.Collections.Generic.IDictionary<string, object> LoadTempData(Microsoft.AspNetCore.Http.HttpContext context);
        void SaveTempData(Microsoft.AspNetCore.Http.HttpContext context, System.Collections.Generic.IDictionary<string, object> values);
    }
    public partial interface IViewContextAware
    {
        void Contextualize(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext);
    }
    internal partial class LambdaExpressionComparer : System.Collections.Generic.IEqualityComparer<System.Linq.Expressions.LambdaExpression>
    {
        public static readonly Microsoft.AspNetCore.Mvc.ViewFeatures.LambdaExpressionComparer Instance;
        public LambdaExpressionComparer() { }
        public bool Equals(System.Linq.Expressions.LambdaExpression lambdaExpression1, System.Linq.Expressions.LambdaExpression lambdaExpression2) { throw null; }
        public int GetHashCode(System.Linq.Expressions.LambdaExpression lambdaExpression) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct MemberExpressionCacheKey
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MemberExpressionCacheKey(System.Type modelType, System.Linq.Expressions.MemberExpression memberExpression) { throw null; }
        public MemberExpressionCacheKey(System.Type modelType, System.Reflection.MemberInfo[] members) { throw null; }
        public System.Linq.Expressions.MemberExpression MemberExpression { get { throw null; } }
        public System.Reflection.MemberInfo[] Members { get { throw null; } }
        public System.Type ModelType { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey.Enumerator GetEnumerator() { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey MakeCacheable() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(in Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey key) { throw null; }
            public System.Reflection.MemberInfo Current { get { throw null; } }
            public bool MoveNext() { throw null; }
        }
    }
    internal partial class MemberExpressionCacheKeyComparer : System.Collections.Generic.IEqualityComparer<Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey>
    {
        public static readonly Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKeyComparer Instance;
        public MemberExpressionCacheKeyComparer() { }
        public bool Equals(Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey x, Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey y) { throw null; }
        public int GetHashCode(Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKey obj) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("DeclaredType={Metadata.ModelType.Name} PropertyName={Metadata.PropertyName}")]
    public partial class ModelExplorer
    {
        public ModelExplorer(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object model) { }
        public ModelExplorer(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer container, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, System.Func<object, object> modelAccessor) { }
        public ModelExplorer(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer container, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object model) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer Container { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } }
        public object Model { get { throw null; } }
        public System.Type ModelType { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForExpression(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, System.Func<object, object> modelAccessor) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForExpression(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object model) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForExpression(System.Type modelType, System.Func<object, object> modelAccessor) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForExpression(System.Type modelType, object model) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForModel(object model) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForProperty(string name) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForProperty(string name, System.Func<object, object> modelAccessor) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetExplorerForProperty(string name, object model) { throw null; }
    }
    public static partial class ModelExplorerExtensions
    {
        public static string GetSimpleDisplayText(this Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { throw null; }
    }
    public sealed partial class ModelExpression
    {
        public ModelExpression(string name, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } }
        public object Model { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer ModelExplorer { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class ModelExpressionProvider : Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider
    {
        public ModelExpressionProvider(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression CreateModelExpression<TModel>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> viewData, string expression) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression CreateModelExpression<TModel, TValue>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TModel> viewData, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { throw null; }
        public string GetExpressionText<TModel, TValue>(System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { throw null; }
    }
    public static partial class ModelMetadataProviderExtensions
    {
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer GetModelExplorerForType(this Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider provider, System.Type modelType, object model) { throw null; }
    }
    internal static partial class MvcViewFeaturesDiagnosticListenerExtensions
    {
        public static void AfterView(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        public static void AfterViewComponent(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, Microsoft.AspNetCore.Mvc.IViewComponentResult result, object viewComponent) { }
        public static void BeforeView(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext) { }
        public static void BeforeViewComponent(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object viewComponent) { }
        public static void ViewComponentAfterViewExecute(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public static void ViewComponentBeforeViewExecute(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public static void ViewFound(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, bool isMainPage, Microsoft.AspNetCore.Mvc.ActionResult viewResult, string viewName, Microsoft.AspNetCore.Mvc.ViewEngines.IView view) { }
        public static void ViewNotFound(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, bool isMainPage, Microsoft.AspNetCore.Mvc.ActionResult viewResult, string viewName, System.Collections.Generic.IEnumerable<string> searchedLocations) { }
    }
    internal static partial class MvcViewFeaturesLoggerExtensions
    {
        public static void AntiforgeryTokenInvalid(this Microsoft.Extensions.Logging.ILogger logger, string message, System.Exception exception) { }
        public static void NotMostEffectiveFilter(this Microsoft.Extensions.Logging.ILogger logger, System.Type policyType) { }
        public static void PartialViewFound(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, System.TimeSpan timespan) { }
        public static void PartialViewNotFound(this Microsoft.Extensions.Logging.ILogger logger, string partialViewName, System.Collections.Generic.IEnumerable<string> searchedLocations) { }
        public static void PartialViewResultExecuted(this Microsoft.Extensions.Logging.ILogger logger, string partialViewName, System.TimeSpan timespan) { }
        public static void PartialViewResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string partialViewName) { }
        public static void TempDataCookieLoadFailure(this Microsoft.Extensions.Logging.ILogger logger, string cookieName, System.Exception exception) { }
        public static void TempDataCookieLoadSuccess(this Microsoft.Extensions.Logging.ILogger logger, string cookieName) { }
        public static void TempDataCookieNotFound(this Microsoft.Extensions.Logging.ILogger logger, string cookieName) { }
        public static void ViewComponentExecuted(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, System.TimeSpan timespan, object result) { }
        public static void ViewComponentExecuting(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext context, object[] arguments) { }
        public static void ViewComponentResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string viewComponentName) { }
        public static void ViewComponentResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, System.Type viewComponentType) { }
        public static void ViewFound(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, System.TimeSpan timespan) { }
        public static void ViewNotFound(this Microsoft.Extensions.Logging.ILogger logger, string viewName, System.Collections.Generic.IEnumerable<string> searchedLocations) { }
        public static void ViewResultExecuted(this Microsoft.Extensions.Logging.ILogger logger, string viewName, System.TimeSpan timespan) { }
        public static void ViewResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string viewName) { }
    }
    internal static partial class NameAndIdProvider
    {
        public static string CreateSanitizedId(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string fullName, string invalidCharReplacement) { throw null; }
        public static void GenerateId(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.Rendering.TagBuilder tagBuilder, string fullName, string invalidCharReplacement) { }
        public static string GetFullHtmlFieldName(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string expression) { throw null; }
    }
    internal partial class NullView : Microsoft.AspNetCore.Mvc.ViewEngines.IView
    {
        public static readonly Microsoft.AspNetCore.Mvc.ViewFeatures.NullView Instance;
        public NullView() { }
        public string Path { get { throw null; } }
        public System.Threading.Tasks.Task RenderAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext context) { throw null; }
    }
    public partial class PartialViewResultExecutor : Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.PartialViewResult>
    {
        public PartialViewResultExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> viewOptions, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) : base (default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), default(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory), default(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), default(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), default(System.Diagnostics.DiagnosticListener), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)) { }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.PartialViewResult result) { throw null; }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.PartialViewResult viewResult) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult FindView(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.PartialViewResult viewResult) { throw null; }
    }
    internal static partial class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string ArgumentPropertyUnexpectedType { get { throw null; } }
        internal static string Common_PartialViewNotFound { get { throw null; } }
        internal static string Common_PropertyNotFound { get { throw null; } }
        internal static string Common_TriState_False { get { throw null; } }
        internal static string Common_TriState_NotSet { get { throw null; } }
        internal static string Common_TriState_True { get { throw null; } }
        internal static string CreateModelExpression_NullModelMetadata { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string DeserializingTempData { get { throw null; } }
        internal static string Dictionary_DuplicateKey { get { throw null; } }
        internal static string DynamicViewData_ViewDataNull { get { throw null; } }
        internal static string ExpressionHelper_InvalidIndexerExpression { get { throw null; } }
        internal static string HtmlGenerator_FieldNameCannotBeNullOrEmpty { get { throw null; } }
        internal static string HtmlHelper_MissingSelectData { get { throw null; } }
        internal static string HtmlHelper_NotContextualized { get { throw null; } }
        internal static string HtmlHelper_NullModelMetadata { get { throw null; } }
        internal static string HtmlHelper_SelectExpressionNotEnumerable { get { throw null; } }
        internal static string HtmlHelper_TextAreaParameterOutOfRange { get { throw null; } }
        internal static string HtmlHelper_TypeNotSupported_ForGetEnumSelectList { get { throw null; } }
        internal static string HtmlHelper_WrongSelectDataType { get { throw null; } }
        internal static string PropertyOfTypeCannotBeNull { get { throw null; } }
        internal static string RemoteAttribute_NoUrlFound { get { throw null; } }
        internal static string RemoteAttribute_RemoteValidationFailed { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string SerializingTempData { get { throw null; } }
        internal static string TempDataProperties_InvalidType { get { throw null; } }
        internal static string TempDataProperties_PublicGetterSetter { get { throw null; } }
        internal static string TempData_CannotDeserializeType { get { throw null; } }
        internal static string TempData_CannotSerializeType { get { throw null; } }
        internal static string TemplatedExpander_PopulateValuesMustBeInvokedFirst { get { throw null; } }
        internal static string TemplatedExpander_ValueFactoryCannotReturnNull { get { throw null; } }
        internal static string TemplatedViewLocationExpander_NoReplacementToken { get { throw null; } }
        internal static string TemplateHelpers_NoTemplate { get { throw null; } }
        internal static string TemplateHelpers_TemplateLimitations { get { throw null; } }
        internal static string Templates_TypeMustImplementIEnumerable { get { throw null; } }
        internal static string TypeMethodMustReturnNotNullValue { get { throw null; } }
        internal static string TypeMustDeriveFromType { get { throw null; } }
        internal static string UnobtrusiveJavascript_ValidationParameterCannotBeEmpty { get { throw null; } }
        internal static string UnobtrusiveJavascript_ValidationParameterMustBeLegal { get { throw null; } }
        internal static string UnobtrusiveJavascript_ValidationTypeCannotBeEmpty { get { throw null; } }
        internal static string UnobtrusiveJavascript_ValidationTypeMustBeLegal { get { throw null; } }
        internal static string UnobtrusiveJavascript_ValidationTypeMustBeUnique { get { throw null; } }
        internal static string UnsupportedRenderMode { get { throw null; } }
        internal static string ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated { get { throw null; } }
        internal static string ViewComponentResult_NameOrTypeMustBeSet { get { throw null; } }
        internal static string ViewComponent_AmbiguousMethods { get { throw null; } }
        internal static string ViewComponent_AmbiguousTypeMatch { get { throw null; } }
        internal static string ViewComponent_AmbiguousTypeMatch_Item { get { throw null; } }
        internal static string ViewComponent_AsyncMethod_ShouldReturnTask { get { throw null; } }
        internal static string ViewComponent_CannotFindComponent { get { throw null; } }
        internal static string ViewComponent_CannotFindMethod { get { throw null; } }
        internal static string ViewComponent_InvalidReturnValue { get { throw null; } }
        internal static string ViewComponent_IViewComponentFactory_ReturnedNull { get { throw null; } }
        internal static string ViewComponent_MustReturnValue { get { throw null; } }
        internal static string ViewComponent_SyncMethod_CannotReturnTask { get { throw null; } }
        internal static string ViewComponent_SyncMethod_ShouldReturnValue { get { throw null; } }
        internal static string ViewData_ModelCannotBeNull { get { throw null; } }
        internal static string ViewData_WrongTModelType { get { throw null; } }
        internal static string ViewEnginesAreRequired { get { throw null; } }
        internal static string ViewEngine_PartialViewNotFound { get { throw null; } }
        internal static string ViewEngine_ViewNotFound { get { throw null; } }
        internal static string FormatArgumentPropertyUnexpectedType(object p0, object p1, object p2) { throw null; }
        internal static string FormatCommon_PartialViewNotFound(object p0, object p1) { throw null; }
        internal static string FormatCommon_PropertyNotFound(object p0, object p1) { throw null; }
        internal static string FormatCreateModelExpression_NullModelMetadata(object p0, object p1) { throw null; }
        internal static string FormatDictionary_DuplicateKey(object p0) { throw null; }
        internal static string FormatExpressionHelper_InvalidIndexerExpression(object p0, object p1) { throw null; }
        internal static string FormatHtmlGenerator_FieldNameCannotBeNullOrEmpty(object p0, object p1, object p2, object p3, object p4) { throw null; }
        internal static string FormatHtmlHelper_MissingSelectData(object p0, object p1) { throw null; }
        internal static string FormatHtmlHelper_NullModelMetadata(object p0) { throw null; }
        internal static string FormatHtmlHelper_SelectExpressionNotEnumerable(object p0) { throw null; }
        internal static string FormatHtmlHelper_TypeNotSupported_ForGetEnumSelectList(object p0, object p1, object p2) { throw null; }
        internal static string FormatHtmlHelper_WrongSelectDataType(object p0, object p1, object p2) { throw null; }
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) { throw null; }
        internal static string FormatRemoteAttribute_RemoteValidationFailed(object p0) { throw null; }
        internal static string FormatTempDataProperties_InvalidType(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatTempDataProperties_PublicGetterSetter(object p0, object p1, object p2) { throw null; }
        internal static string FormatTempData_CannotDeserializeType(object p0) { throw null; }
        internal static string FormatTempData_CannotSerializeType(object p0, object p1) { throw null; }
        internal static string FormatTemplatedExpander_PopulateValuesMustBeInvokedFirst(object p0, object p1) { throw null; }
        internal static string FormatTemplatedViewLocationExpander_NoReplacementToken(object p0) { throw null; }
        internal static string FormatTemplateHelpers_NoTemplate(object p0) { throw null; }
        internal static string FormatTemplates_TypeMustImplementIEnumerable(object p0, object p1, object p2) { throw null; }
        internal static string FormatTypeMethodMustReturnNotNullValue(object p0, object p1) { throw null; }
        internal static string FormatTypeMustDeriveFromType(object p0, object p1) { throw null; }
        internal static string FormatUnobtrusiveJavascript_ValidationParameterCannotBeEmpty(object p0) { throw null; }
        internal static string FormatUnobtrusiveJavascript_ValidationParameterMustBeLegal(object p0, object p1) { throw null; }
        internal static string FormatUnobtrusiveJavascript_ValidationTypeCannotBeEmpty(object p0) { throw null; }
        internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeLegal(object p0, object p1) { throw null; }
        internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeUnique(object p0) { throw null; }
        internal static string FormatUnsupportedRenderMode(object p0) { throw null; }
        internal static string FormatValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated(object p0, object p1) { throw null; }
        internal static string FormatViewComponentResult_NameOrTypeMustBeSet(object p0, object p1) { throw null; }
        internal static string FormatViewComponent_AmbiguousMethods(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_AmbiguousTypeMatch(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_AmbiguousTypeMatch_Item(object p0, object p1) { throw null; }
        internal static string FormatViewComponent_AsyncMethod_ShouldReturnTask(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_CannotFindComponent(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatViewComponent_CannotFindMethod(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_InvalidReturnValue(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_IViewComponentFactory_ReturnedNull(object p0) { throw null; }
        internal static string FormatViewComponent_SyncMethod_CannotReturnTask(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewComponent_SyncMethod_ShouldReturnValue(object p0, object p1) { throw null; }
        internal static string FormatViewData_ModelCannotBeNull(object p0) { throw null; }
        internal static string FormatViewData_WrongTModelType(object p0, object p1) { throw null; }
        internal static string FormatViewEnginesAreRequired(object p0, object p1, object p2) { throw null; }
        internal static string FormatViewEngine_PartialViewNotFound(object p0, object p1) { throw null; }
        internal static string FormatViewEngine_ViewNotFound(object p0, object p1) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class SaveTempDataAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public SaveTempDataAttribute() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    internal partial class ServerComponentInvocationSequence
    {
        public ServerComponentInvocationSequence() { }
        public System.Guid Value { get { throw null; } }
        public int Next() { throw null; }
    }
    internal partial class ServerComponentSerializer
    {
        public ServerComponentSerializer(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider) { }
        internal System.Collections.Generic.IEnumerable<string> GetEpilogue(Microsoft.AspNetCore.Components.ServerComponentMarker record) { throw null; }
        internal System.Collections.Generic.IEnumerable<string> GetPreamble(Microsoft.AspNetCore.Components.ServerComponentMarker record) { throw null; }
        public Microsoft.AspNetCore.Components.ServerComponentMarker SerializeInvocation(Microsoft.AspNetCore.Mvc.ViewFeatures.ServerComponentInvocationSequence invocationId, System.Type type, Microsoft.AspNetCore.Components.ParameterView parameters, bool prerendered) { throw null; }
    }
    public partial class SessionStateTempDataProvider : Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider
    {
        internal const string TempDataSessionStateKey = "__ControllerTempData";
        public SessionStateTempDataProvider(Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer tempDataSerializer) { }
        public virtual System.Collections.Generic.IDictionary<string, object> LoadTempData(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public virtual void SaveTempData(Microsoft.AspNetCore.Http.HttpContext context, System.Collections.Generic.IDictionary<string, object> values) { }
    }
    internal partial class StaticComponentRenderer
    {
        public StaticComponentRenderer(System.Text.Encodings.Web.HtmlEncoder encoder) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> PrerenderComponentAsync(Microsoft.AspNetCore.Components.ParameterView parameters, Microsoft.AspNetCore.Http.HttpContext httpContext, System.Type componentType) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    public partial class StringHtmlContent : Microsoft.AspNetCore.Html.IHtmlContent
    {
        public StringHtmlContent(string input) { }
        public void WriteTo(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { }
    }
    public partial class TempDataDictionary : Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public TempDataDictionary(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider provider) { }
        public int Count { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get { throw null; } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool ContainsKey(string key) { throw null; }
        public bool ContainsValue(object value) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        public void Keep() { }
        public void Keep(string key) { }
        public void Load() { }
        public object Peek(string key) { throw null; }
        public bool Remove(string key) { throw null; }
        public void Save() { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object value) { throw null; }
    }
    public partial class TempDataDictionaryFactory : Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory
    {
        public TempDataDictionaryFactory(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider provider) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary GetTempData(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    internal partial class TemplateBuilder
    {
        public TemplateBuilder(Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope bufferScope, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string htmlFieldName, string templateName, bool readOnly, object additionalViewData) { }
        public Microsoft.AspNetCore.Html.IHtmlContent Build() { throw null; }
    }
    public partial class TemplateInfo
    {
        public TemplateInfo() { }
        public TemplateInfo(Microsoft.AspNetCore.Mvc.ViewFeatures.TemplateInfo original) { }
        public object FormattedModelValue { get { throw null; } set { } }
        public string HtmlFieldPrefix { get { throw null; } set { } }
        public int TemplateDepth { get { throw null; } }
        public bool AddVisited(object value) { throw null; }
        public string GetFullHtmlFieldName(string partialFieldName) { throw null; }
        public bool Visited(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { throw null; }
    }
    internal partial class TemplateRenderer
    {
        public const string IEnumerableOfIFormFileName = "IEnumerable`IFormFile";
        public TemplateRenderer(Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope bufferScope, Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, string templateName, bool readOnly) { }
        public static System.Collections.Generic.IEnumerable<string> GetTypeNames(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, System.Type fieldType) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContent Render() { throw null; }
    }
    public delegate bool TryGetValueDelegate(object dictionary, string key, out object value);
    public static partial class TryGetValueProvider
    {
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.TryGetValueDelegate CreateInstance(System.Type targetType) { throw null; }
    }
    internal partial class UnsupportedJavaScriptRuntime : Microsoft.JSInterop.IJSRuntime
    {
        public UnsupportedJavaScriptRuntime() { }
        public System.Threading.Tasks.ValueTask<TValue> InvokeAsync<TValue>(string identifier, System.Threading.CancellationToken cancellationToken, object[] args) { throw null; }
        System.Threading.Tasks.ValueTask<TValue> Microsoft.JSInterop.IJSRuntime.InvokeAsync<TValue>(string identifier, object[] args) { throw null; }
    }
    internal sealed partial class UnsupportedNavigationInterception : Microsoft.AspNetCore.Components.Routing.INavigationInterception
    {
        public UnsupportedNavigationInterception() { }
        public System.Threading.Tasks.Task EnableNavigationInterceptionAsync() { throw null; }
    }
    internal static partial class ValidationHelpers
    {
        public static string GetModelErrorMessageOrDefault(Microsoft.AspNetCore.Mvc.ModelBinding.ModelError modelError) { throw null; }
        public static string GetModelErrorMessageOrDefault(Microsoft.AspNetCore.Mvc.ModelBinding.ModelError modelError, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry containingEntry, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateEntry> GetModelStateList(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, bool excludePropertyErrors) { throw null; }
    }
    public abstract partial class ValidationHtmlAttributeProvider
    {
        protected ValidationHtmlAttributeProvider() { }
        public virtual void AddAndTrackValidationAttributes(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, string expression, System.Collections.Generic.IDictionary<string, string> attributes) { }
        public abstract void AddValidationAttributes(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, System.Collections.Generic.IDictionary<string, string> attributes);
    }
    public partial class ViewComponentResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.ViewComponentResult>
    {
        [System.ObsoleteAttribute("This constructor is obsolete and will be removed in a future version.")]
        public ViewComponentResultExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> mvcHelperOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataDictionaryFactory) { }
        public ViewComponentResultExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> mvcHelperOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataDictionaryFactory, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.ViewComponentResult result) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class ViewContextAttribute : System.Attribute
    {
        public ViewContextAttribute() { }
    }
    public partial class ViewDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        internal ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider) { }
        public ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { }
        protected ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, System.Type declaredModelType) { }
        protected ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, System.Type declaredModelType) { }
        public ViewDataDictionary(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary source) { }
        protected ViewDataDictionary(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary source, object model, System.Type declaredModelType) { }
        protected ViewDataDictionary(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary source, System.Type declaredModelType) { }
        public int Count { get { throw null; } }
        internal System.Collections.Generic.IDictionary<string, object> Data { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public object this[string index] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public object Model { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer ModelExplorer { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.TemplateInfo TemplateInfo { get { throw null; } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, object> item) { }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        public object Eval(string expression) { throw null; }
        public string Eval(string expression, string format) { throw null; }
        public static string FormatValue(object value, string format) { throw null; }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataInfo GetViewDataInfo(string expression) { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        public bool Remove(string key) { throw null; }
        protected virtual void SetModel(object value) { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object value) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class ViewDataDictionaryAttribute : System.Attribute
    {
        public ViewDataDictionaryAttribute() { }
    }
    public partial class ViewDataDictionaryControllerPropertyActivator : Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator
    {
        public ViewDataDictionaryControllerPropertyActivator(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        public void Activate(Microsoft.AspNetCore.Mvc.ControllerContext actionContext, object controller) { }
        public System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> GetActivatorDelegate(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor) { throw null; }
    }
    internal static partial class ViewDataDictionaryFactory
    {
        public static System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary> CreateFactory(System.Reflection.TypeInfo modelType) { throw null; }
        public static System.Func<Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary> CreateNestedFactory(System.Reflection.TypeInfo modelType) { throw null; }
    }
    public partial class ViewDataDictionary<TModel> : Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary
    {
        internal ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)) { }
        public ViewDataDictionary(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)) { }
        public ViewDataDictionary(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary source) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)) { }
        public ViewDataDictionary(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary source, object model) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)) { }
        public new TModel Model { get { throw null; } set { } }
    }
    public static partial class ViewDataEvaluator
    {
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataInfo Eval(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, string expression) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataInfo Eval(object indexableObject, string expression) { throw null; }
    }
    public partial class ViewDataInfo
    {
        public ViewDataInfo(object container, object value) { }
        public ViewDataInfo(object container, System.Reflection.PropertyInfo propertyInfo) { }
        public ViewDataInfo(object container, System.Reflection.PropertyInfo propertyInfo, System.Func<object> valueAccessor) { }
        public object Container { get { throw null; } }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public object Value { get { throw null; } set { } }
    }
    public partial class ViewExecutor
    {
        public static readonly string DefaultContentType;
        protected ViewExecutor(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, System.Diagnostics.DiagnosticListener diagnosticListener) { }
        public ViewExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> viewOptions, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        protected System.Diagnostics.DiagnosticListener DiagnosticListener { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider ModelMetadataProvider { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory TempDataFactory { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ViewEngines.IViewEngine ViewEngine { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.MvcViewOptions ViewOptions { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory WriterFactory { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ViewEngines.IView view, Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, string contentType, int? statusCode) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.Rendering.ViewContext viewContext, string contentType, int? statusCode) { throw null; }
    }
    public partial class ViewResultExecutor : Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.ViewResult>
    {
        public ViewResultExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions> viewOptions, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) : base (default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), default(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory), default(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), default(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), default(System.Diagnostics.DiagnosticListener), default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)) { }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.ViewResult result) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult FindView(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ViewResult viewResult) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers
{
    internal partial class ArrayPoolBufferSource : Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ICharBufferSource
    {
        public ArrayPoolBufferSource(System.Buffers.ArrayPool<char> pool) { }
        public char[] Rent(int bufferSize) { throw null; }
        public void Return(char[] buffer) { }
    }
    internal partial class CharArrayBufferSource : Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ICharBufferSource
    {
        public static readonly Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.CharArrayBufferSource Instance;
        public CharArrayBufferSource() { }
        public char[] Rent(int bufferSize) { throw null; }
        public void Return(char[] buffer) { }
    }
    internal partial interface ICharBufferSource
    {
        char[] Rent(int bufferSize);
        void Return(char[] buffer);
    }
    public partial interface IViewBufferScope
    {
        System.IO.TextWriter CreateWriter(System.IO.TextWriter writer);
        Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] GetPage(int pageSize);
        void ReturnSegment(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] segment);
    }
    internal partial class MemoryPoolViewBufferScope : Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope, System.IDisposable
    {
        public static readonly int MinimumSize;
        public MemoryPoolViewBufferScope(System.Buffers.ArrayPool<Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue> viewBufferPool, System.Buffers.ArrayPool<char> charPool) { }
        public System.IO.TextWriter CreateWriter(System.IO.TextWriter writer) { throw null; }
        public void Dispose() { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] GetPage(int pageSize) { throw null; }
        public void ReturnSegment(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] segment) { }
    }
    internal partial class PagedBufferedTextWriter : System.IO.TextWriter
    {
        public PagedBufferedTextWriter(System.Buffers.ArrayPool<char> pool, System.IO.TextWriter inner) { }
        public override System.Text.Encoding Encoding { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync() { throw null; }
        public override void Write(char value) { }
        public override void Write(char[] buffer) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(string value) { }
        public override System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
    }
    internal partial class PagedCharBuffer : System.IDisposable
    {
        public const int PageSize = 1024;
        public PagedCharBuffer(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ICharBufferSource bufferSource) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ICharBufferSource BufferSource { get { throw null; } }
        public int Length { get { throw null; } }
        public System.Collections.Generic.List<char[]> Pages { get { throw null; } }
        public void Append(char value) { }
        public void Append(char[] buffer, int index, int count) { }
        public void Append(string value) { }
        public void Clear() { }
        public void Dispose() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    internal partial class ViewBuffer : Microsoft.AspNetCore.Html.IHtmlContent, Microsoft.AspNetCore.Html.IHtmlContentBuilder, Microsoft.AspNetCore.Html.IHtmlContentContainer
    {
        public static readonly int PartialViewPageSize;
        public static readonly int TagHelperPageSize;
        public static readonly int ViewComponentPageSize;
        public static readonly int ViewPageSize;
        public ViewBuffer(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope bufferScope, string name, int pageSize) { }
        public int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferPage this[int index] { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public Microsoft.AspNetCore.Html.IHtmlContentBuilder Append(string unencoded) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public Microsoft.AspNetCore.Html.IHtmlContentBuilder AppendHtml(Microsoft.AspNetCore.Html.IHtmlContent content) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public Microsoft.AspNetCore.Html.IHtmlContentBuilder AppendHtml(string encoded) { throw null; }
        public Microsoft.AspNetCore.Html.IHtmlContentBuilder Clear() { throw null; }
        public void CopyTo(Microsoft.AspNetCore.Html.IHtmlContentBuilder destination) { }
        public void MoveTo(Microsoft.AspNetCore.Html.IHtmlContentBuilder destination) { }
        public void WriteTo(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task WriteToAsync(System.IO.TextWriter writer, System.Text.Encodings.Web.HtmlEncoder encoder) { throw null; }
    }
    internal partial class ViewBufferPage
    {
        public ViewBufferPage(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] buffer) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue[] Buffer { get { throw null; } }
        public int Capacity { get { throw null; } }
        public int Count { get { throw null; } set { } }
        public bool IsFull { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Append(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBufferValue value) { }
    }
    internal partial class ViewBufferTextWriter : System.IO.TextWriter
    {
        public ViewBufferTextWriter(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBuffer buffer, System.Text.Encoding encoding) { }
        public ViewBufferTextWriter(Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBuffer buffer, System.Text.Encoding encoding, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.IO.TextWriter inner) { }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.ViewBuffer Buffer { get { throw null; } }
        public override System.Text.Encoding Encoding { get { throw null; } }
        public bool Flushed { get { throw null; } }
        public override void Flush() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task FlushAsync() { throw null; }
        public void Write(Microsoft.AspNetCore.Html.IHtmlContent value) { }
        public void Write(Microsoft.AspNetCore.Html.IHtmlContentContainer value) { }
        public override void Write(char value) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(object value) { }
        public override void Write(string value) { }
        public override System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
        public override void WriteLine() { }
        public override void WriteLine(object value) { }
        public override void WriteLine(string value) { }
        public override System.Threading.Tasks.Task WriteLineAsync() { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(char[] value, int start, int offset) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerToString()}")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ViewBufferValue
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ViewBufferValue(Microsoft.AspNetCore.Html.IHtmlContent content) { throw null; }
        public ViewBufferValue(string value) { throw null; }
        public object Value { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Filters
{
    internal partial class AutoValidateAntiforgeryTokenAuthorizationFilter : Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.ValidateAntiforgeryTokenAuthorizationFilter
    {
        public AutoValidateAntiforgeryTokenAuthorizationFilter(Microsoft.AspNetCore.Antiforgery.IAntiforgery antiforgery, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.AspNetCore.Antiforgery.IAntiforgery), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        protected override bool ShouldValidate(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
    }
    internal partial class ControllerSaveTempDataPropertyFilter : Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.SaveTempDataPropertyFilterBase, Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public ControllerSaveTempDataPropertyFilter(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory factory) : base (default(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory)) { }
        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
    }
    internal partial class ControllerSaveTempDataPropertyFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public ControllerSaveTempDataPropertyFilterFactory(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public bool IsReusable { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> TempDataProperties { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    internal partial class ControllerViewDataAttributeFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.IViewDataValuesProviderFeature
    {
        public ControllerViewDataAttributeFilter(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } }
        public object Subject { get { throw null; } set { } }
        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
        public void ProvideViewDataValues(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData) { }
    }
    internal partial class ControllerViewDataAttributeFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public ControllerViewDataAttributeFilterFactory(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> properties) { }
        public bool IsReusable { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    internal partial interface ISaveTempDataCallback : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void OnTempDataSaving(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData);
    }
    internal partial interface IViewDataValuesProviderFeature
    {
        void ProvideViewDataValues(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary viewData);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo, nq}")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct LifecycleProperty
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LifecycleProperty(System.Reflection.PropertyInfo propertyInfo, string key) { throw null; }
        public string Key { get { throw null; } }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public object GetValue(object instance) { throw null; }
        public void SetValue(object instance, object value) { }
    }
    internal partial class SaveTempDataFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
        internal static readonly object SaveTempDataFilterContextKey;
        public SaveTempDataFilter(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory factory) { }
        public void OnResourceExecuted(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext context) { }
        public void OnResourceExecuting(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context) { }
        public void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
        internal partial class SaveTempDataContext
        {
            public SaveTempDataContext() { }
            public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } set { } }
            public bool RequestHasUnhandledException { get { throw null; } set { } }
            public Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory TempDataDictionaryFactory { get { throw null; } set { } }
            public bool TempDataSaved { get { throw null; } set { } }
        }
    }
    internal abstract partial class SaveTempDataPropertyFilterBase : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.ISaveTempDataCallback
    {
        protected readonly Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory _tempDataFactory;
        public SaveTempDataPropertyFilterBase(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory tempDataFactory) { }
        public System.Collections.Generic.IDictionary<System.Reflection.PropertyInfo, object> OriginalValues { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> Properties { get { throw null; } set { } }
        public object Subject { get { throw null; } set { } }
        public static System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> GetTempDataProperties(Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer tempDataSerializer, System.Type type) { throw null; }
        public void OnTempDataSaving(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData) { }
        protected void SetPropertyValues(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData) { }
    }
    internal partial class TempDataApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public TempDataApplicationModelProvider(Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer tempDataSerializer) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    internal partial class ValidateAntiforgeryTokenAuthorizationFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.ViewFeatures.IAntiforgeryPolicy
    {
        public ValidateAntiforgeryTokenAuthorizationFilter(Microsoft.AspNetCore.Antiforgery.IAntiforgery antiforgery, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
        protected virtual bool ShouldValidate(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
    }
    internal partial class ViewDataAttributeApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public ViewDataAttributeApplicationModelProvider() { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    internal static partial class ViewDataAttributePropertyProvider
    {
        public static System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ViewFeatures.Filters.LifecycleProperty> GetViewDataProperties(System.Type type) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure
{
    internal sealed partial class ArrayBufferWriter<T> : System.Buffers.IBufferWriter<T>, System.IDisposable
    {
        public ArrayBufferWriter() { }
        public ArrayBufferWriter(int initialCapacity) { }
        public int Capacity { get { throw null; } }
        public int FreeCapacity { get { throw null; } }
        public int WrittenCount { get { throw null; } }
        public System.ReadOnlyMemory<T> WrittenMemory { get { throw null; } }
        public void Advance(int count) { }
        public void Clear() { }
        public void Dispose() { }
        public System.Memory<T> GetMemory(int sizeHint = 0) { throw null; }
        public System.Span<T> GetSpan(int sizeHint = 0) { throw null; }
    }
    internal partial class DefaultTempDataSerializer : Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure.TempDataSerializer
    {
        public DefaultTempDataSerializer() { }
        public override bool CanSerializeType(System.Type type) { throw null; }
        public override System.Collections.Generic.IDictionary<string, object> Deserialize(byte[] value) { throw null; }
        public override byte[] Serialize(System.Collections.Generic.IDictionary<string, object> values) { throw null; }
    }
    public abstract partial class TempDataSerializer
    {
        protected TempDataSerializer() { }
        public virtual bool CanSerializeType(System.Type type) { throw null; }
        public abstract System.Collections.Generic.IDictionary<string, object> Deserialize(byte[] unprotectedData);
        public abstract byte[] Serialize(System.Collections.Generic.IDictionary<string, object> values);
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MvcViewFeaturesMvcBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddCookieTempDataProvider(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddCookieTempDataProvider(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.CookieTempDataProviderOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddSessionStateTempDataProvider(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddViewComponentsAsServices(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddViewOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.MvcViewOptions> setupAction) { throw null; }
    }
    public static partial class MvcViewFeaturesMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCookieTempDataProvider(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCookieTempDataProvider(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.CookieTempDataProviderOptions> setupAction) { throw null; }
        internal static void AddViewComponentApplicationPartsProviders(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager manager) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddViews(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddViews(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.MvcViewOptions> setupAction) { throw null; }
        internal static void AddViewServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder ConfigureViews(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.MvcViewOptions> setupAction) { throw null; }
    }
    internal partial class MvcViewOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>
    {
        public MvcViewOptionsSetup(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.DataAnnotations.MvcDataAnnotationsLocalizationOptions> dataAnnotationLocalizationOptions, Microsoft.AspNetCore.Mvc.DataAnnotations.IValidationAttributeAdapterProvider validationAttributeAdapterProvider) { }
        public MvcViewOptionsSetup(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.DataAnnotations.MvcDataAnnotationsLocalizationOptions> dataAnnotationOptions, Microsoft.AspNetCore.Mvc.DataAnnotations.IValidationAttributeAdapterProvider validationAttributeAdapterProvider, Microsoft.Extensions.Localization.IStringLocalizerFactory stringLocalizerFactory) { }
        public void Configure(Microsoft.AspNetCore.Mvc.MvcViewOptions options) { }
    }
    internal partial class TempDataMvcOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcOptions>
    {
        public TempDataMvcOptionsSetup() { }
        public void Configure(Microsoft.AspNetCore.Mvc.MvcOptions options) { }
    }
}
