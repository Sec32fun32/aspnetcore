// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public sealed partial class ControllerActionEndpointConventionBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder
    {
        internal ControllerActionEndpointConventionBuilder(object @lock, System.Collections.Generic.List<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { }
        public void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention) { }
    }
    public static partial class ControllerEndpointRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder MapAreaControllerRoute(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string name, string areaName, string pattern, object defaults = null, object constraints = null, object dataTokens = null) { throw null; }
        public static Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder MapControllerRoute(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string name, string pattern, object defaults = null, object constraints = null, object dataTokens = null) { throw null; }
        public static Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder MapControllers(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints) { throw null; }
        public static Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder MapDefaultControllerRoute(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints) { throw null; }
        public static void MapDynamicControllerRoute<TTransformer>(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern) where TTransformer : Microsoft.AspNetCore.Mvc.Routing.DynamicRouteValueTransformer { }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToAreaController(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string action, string controller, string area) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToAreaController(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string action, string controller, string area) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToController(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string action, string controller) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToController(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string action, string controller) { throw null; }
    }
    public static partial class MvcApplicationBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseMvc(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseMvc(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Microsoft.AspNetCore.Routing.IRouteBuilder> configureRoutes) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseMvcWithDefaultRoute(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
    }
    public static partial class MvcAreaRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapAreaRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string areaName, string template) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapAreaRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string areaName, string template, object defaults) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapAreaRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string areaName, string template, object defaults, object constraints) { throw null; }
        public static Microsoft.AspNetCore.Routing.IRouteBuilder MapAreaRoute(this Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder, string name, string areaName, string template, object defaults, object constraints, object dataTokens) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Internal
{
    internal partial class ChunkingCookieManager
    {
        public const int DefaultChunkSize = 4050;
        public ChunkingCookieManager() { }
        public int? ChunkSize { get { throw null; } set { } }
        public bool ThrowForPartialCookies { get { throw null; } set { } }
        public void AppendResponseCookie(Microsoft.AspNetCore.Http.HttpContext context, string key, string value, Microsoft.AspNetCore.Http.CookieOptions options) { }
        public void DeleteCookie(Microsoft.AspNetCore.Http.HttpContext context, string key, Microsoft.AspNetCore.Http.CookieOptions options) { }
        public string GetRequestCookie(Microsoft.AspNetCore.Http.HttpContext context, string key) { throw null; }
    }
    internal static partial class RangeHelper
    {
        internal static Microsoft.Net.Http.Headers.RangeItemHeaderValue NormalizeRange(Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long length) { throw null; }
        public static (bool isRangeRequest, Microsoft.Net.Http.Headers.RangeItemHeaderValue range) ParseRange(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.Headers.RequestHeaders requestHeaders, long length, Microsoft.Extensions.Logging.ILogger logger) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc
{
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(202)]
    public partial class AcceptedAtActionResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public AcceptedAtActionResult(string actionName, string controllerName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public string ActionName { get { throw null; } set { } }
        public string ControllerName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(202)]
    public partial class AcceptedAtRouteResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public AcceptedAtRouteResult(object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public AcceptedAtRouteResult(string routeName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public string RouteName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(202)]
    public partial class AcceptedResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public AcceptedResult() : base (default(object)) { }
        public AcceptedResult(string location, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public AcceptedResult(System.Uri locationUri, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public string Location { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public sealed partial class AcceptVerbsAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Routing.IActionHttpMethodProvider, Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider
    {
        public AcceptVerbsAttribute(string method) { }
        public AcceptVerbsAttribute(params string[] methods) { }
        public System.Collections.Generic.IEnumerable<string> HttpMethods { get { throw null; } }
        int? Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider.Order { get { throw null; } }
        string Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider.Template { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public string Route { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class ActionContextAttribute : System.Attribute
    {
        public ActionContextAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed partial class ActionNameAttribute : System.Attribute
    {
        public ActionNameAttribute(string name) { }
        public string Name { get { throw null; } }
    }
    public abstract partial class ActionResult : Microsoft.AspNetCore.Mvc.IActionResult
    {
        protected ActionResult() { }
        public virtual void ExecuteResult(Microsoft.AspNetCore.Mvc.ActionContext context) { }
        public virtual System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public sealed partial class ActionResult<TValue> : Microsoft.AspNetCore.Mvc.Infrastructure.IConvertToActionResult
    {
        public ActionResult(Microsoft.AspNetCore.Mvc.ActionResult result) { }
        public ActionResult(TValue value) { }
        public Microsoft.AspNetCore.Mvc.ActionResult Result { get { throw null; } }
        public TValue Value { get { throw null; } }
        Microsoft.AspNetCore.Mvc.IActionResult Microsoft.AspNetCore.Mvc.Infrastructure.IConvertToActionResult.Convert() { throw null; }
        public static implicit operator Microsoft.AspNetCore.Mvc.ActionResult<TValue> (Microsoft.AspNetCore.Mvc.ActionResult result) { throw null; }
        public static implicit operator Microsoft.AspNetCore.Mvc.ActionResult<TValue> (TValue value) { throw null; }
    }
    public partial class AntiforgeryValidationFailedResult : Microsoft.AspNetCore.Mvc.BadRequestResult, Microsoft.AspNetCore.Mvc.Core.Infrastructure.IAntiforgeryValidationFailedResult, Microsoft.AspNetCore.Mvc.IActionResult
    {
        public AntiforgeryValidationFailedResult() { }
    }
    public partial class ApiBehaviorOptions : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>, System.Collections.IEnumerable
    {
        public ApiBehaviorOptions() { }
        public System.Collections.Generic.IDictionary<int, Microsoft.AspNetCore.Mvc.ClientErrorData> ClientErrorMapping { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.ActionContext, Microsoft.AspNetCore.Mvc.IActionResult> InvalidModelStateResponseFactory { get { throw null; } set { } }
        public bool SuppressConsumesConstraintForFormFileParameters { get { throw null; } set { } }
        public bool SuppressInferBindingSourcesForParameters { get { throw null; } set { } }
        public bool SuppressMapClientErrors { get { throw null; } set { } }
        public bool SuppressModelStateInvalidFilter { get { throw null; } set { } }
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class ApiControllerAttribute : Microsoft.AspNetCore.Mvc.ControllerAttribute, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Infrastructure.IApiBehaviorMetadata
    {
        public ApiControllerAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed partial class ApiConventionMethodAttribute : System.Attribute
    {
        public ApiConventionMethodAttribute(System.Type conventionType, string methodName) { }
        public System.Type ConventionType { get { throw null; } }
        internal System.Reflection.MethodInfo Method { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class ApiConventionTypeAttribute : System.Attribute
    {
        public ApiConventionTypeAttribute(System.Type conventionType) { }
        public System.Type ConventionType { get { throw null; } }
        internal static void EnsureValid(System.Type conventionType) { }
    }
    public partial class ApiDescriptionActionData
    {
        public ApiDescriptionActionData() { }
        public string GroupName { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class ApiExplorerSettingsAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionGroupNameProvider, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionVisibilityProvider
    {
        public ApiExplorerSettingsAttribute() { }
        public string GroupName { get { throw null; } set { } }
        public bool IgnoreApi { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class AreaAttribute : Microsoft.AspNetCore.Mvc.Routing.RouteValueAttribute
    {
        public AreaAttribute(string areaName) : base (default(string), default(string)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(400)]
    public partial class BadRequestObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public BadRequestObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) : base (default(object)) { }
        public BadRequestObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(400)]
    public partial class BadRequestResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public BadRequestResult() : base (default(int)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Parameter, AllowMultiple=false, Inherited=true)]
    public partial class BindAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider
    {
        public BindAttribute(params string[] include) { }
        public string[] Include { get { throw null; } }
        string Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider.Name { get { throw null; } }
        public string Prefix { get { throw null; } set { } }
        public System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> PropertyFilter { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class BindPropertiesAttribute : System.Attribute
    {
        public BindPropertiesAttribute() { }
        public bool SupportsGet { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class BindPropertyAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBinderTypeProviderMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IRequestPredicateProvider
    {
        public BindPropertyAttribute() { }
        public System.Type BinderType { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } protected set { } }
        System.Func<Microsoft.AspNetCore.Mvc.ActionContext, bool> Microsoft.AspNetCore.Mvc.ModelBinding.IRequestPredicateProvider.RequestPredicate { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public bool SupportsGet { get { throw null; } set { } }
    }
    public partial class CacheProfile
    {
        public CacheProfile() { }
        public int? Duration { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ResponseCacheLocation? Location { get { throw null; } set { } }
        public bool? NoStore { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
    }
    public partial class ChallengeResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public ChallengeResult() { }
        public ChallengeResult(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public ChallengeResult(System.Collections.Generic.IList<string> authenticationSchemes) { }
        public ChallengeResult(System.Collections.Generic.IList<string> authenticationSchemes, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public ChallengeResult(string authenticationScheme) { }
        public ChallengeResult(string authenticationScheme, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public System.Collections.Generic.IList<string> AuthenticationSchemes { get { throw null; } set { } }
        public Microsoft.AspNetCore.Authentication.AuthenticationProperties Properties { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class ClientErrorData
    {
        public ClientErrorData() { }
        public string Link { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
    }
    public enum CompatibilityVersion
    {
        [System.ObsoleteAttribute("This CompatibilityVersion value is obsolete. The recommended alternatives are Version_3_0 or later.")]
        Version_2_0 = 0,
        [System.ObsoleteAttribute("This CompatibilityVersion value is obsolete. The recommended alternatives are Version_3_0 or later.")]
        Version_2_1 = 1,
        [System.ObsoleteAttribute("This CompatibilityVersion value is obsolete. The recommended alternatives are Version_3_0 or later.")]
        Version_2_2 = 2,
        Version_3_0 = 3,
        Latest = 2147483647,
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(409)]
    public partial class ConflictObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public ConflictObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) : base (default(object)) { }
        public ConflictObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(409)]
    public partial class ConflictResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public ConflictResult() : base (default(int)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class ConsumesAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata, Microsoft.AspNetCore.Mvc.ActionConstraints.IConsumesActionConstraint, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiRequestMetadataProvider, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter
    {
        public static readonly int ConsumesActionConstraintOrder;
        public ConsumesAttribute(string contentType, params string[] otherContentTypes) { }
        public Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection ContentTypes { get { throw null; } set { } }
        int Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint.Order { get { throw null; } }
        public bool Accept(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintContext context) { throw null; }
        public void OnResourceExecuted(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext context) { }
        public void OnResourceExecuting(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context) { }
        public void SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { }
    }
    public partial class ContentResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public ContentResult() { }
        public string Content { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public int? StatusCode { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class ControllerAttribute : System.Attribute
    {
        public ControllerAttribute() { }
    }
    [Microsoft.AspNetCore.Mvc.ControllerAttribute]
    public abstract partial class ControllerBase
    {
        protected ControllerBase() { }
        [Microsoft.AspNetCore.Mvc.ControllerContextAttribute]
        public Microsoft.AspNetCore.Mvc.ControllerContext ControllerContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory ModelBinderFactory { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator ObjectValidator { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsFactory ProblemDetailsFactory { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted(string uri) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted(string uri, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted(System.Uri uri) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedResult Accepted(System.Uri uri, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult AcceptedAtRoute([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult AcceptedAtRoute(object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult AcceptedAtRoute(string routeName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult AcceptedAtRoute(string routeName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult AcceptedAtRoute(string routeName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.BadRequestResult BadRequest() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.BadRequestObjectResult BadRequest([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ChallengeResult Challenge(params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ConflictResult Conflict() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ConflictObjectResult Conflict([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ConflictObjectResult Conflict([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedResult Created(string uri, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedResult Created(System.Uri uri, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtActionResult CreatedAtAction(string actionName, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtActionResult CreatedAtAction(string actionName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtActionResult CreatedAtAction(string actionName, string controllerName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtRouteResult CreatedAtRoute(object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtRouteResult CreatedAtRoute(string routeName, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.CreatedAtRouteResult CreatedAtRoute(string routeName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ForbidResult Forbid(params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirect(string localUrl) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanent(string localUrl) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPermanentPreserveMethod(string localUrl) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.LocalRedirectResult LocalRedirectPreserveMethod(string localUrl) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.NoContentResult NoContent() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.NotFoundResult NotFound() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.NotFoundObjectResult NotFound([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.OkResult Ok() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.OkObjectResult Ok([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, System.DateTimeOffset? lastModified, Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag, bool enableRangeProcessing) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ObjectResult Problem(string detail = null, string instance = null, int? statusCode = default(int?), string title = null, string type = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult Redirect(string url) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanent(string url) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPermanentPreserveMethod(string url) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectResult RedirectPreserveMethod(string url) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToAction(string actionName, string controllerName, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPermanentPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPage(string pageName, string pageHandler, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePermanentPreserveMethod(string pageName, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToPageResult RedirectToPagePreserveMethod(string pageName, string pageHandler = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, string fragment) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePermanentPreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRoutePreserveMethod(string routeName = null, object routeValues = null, string fragment = null) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, string authenticationScheme) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.SignInResult SignIn(System.Security.Claims.ClaimsPrincipal principal, string authenticationScheme) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties, params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.SignOutResult SignOut(params string[] authenticationSchemes) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.StatusCodeResult StatusCode([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultStatusCodeAttribute] int statusCode) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ObjectResult StatusCode([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultStatusCodeAttribute] int statusCode, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual bool TryValidateModel(object model) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual bool TryValidateModel(object model, string prefix) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.UnauthorizedResult Unauthorized() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.UnauthorizedObjectResult Unauthorized([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.UnprocessableEntityResult UnprocessableEntity() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.UnprocessableEntityObjectResult UnprocessableEntity([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.UnprocessableEntityObjectResult UnprocessableEntity([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ActionResult ValidationProblem() { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ActionResult ValidationProblem([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelStateDictionary) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ActionResult ValidationProblem([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ValidationProblemDetails descriptor) { throw null; }
        [Microsoft.AspNetCore.Mvc.NonActionAttribute]
        public virtual Microsoft.AspNetCore.Mvc.ActionResult ValidationProblem(string detail = null, string instance = null, int? statusCode = default(int?), string title = null, string type = null, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelStateDictionary = null) { throw null; }
    }
    public partial class ControllerContext : Microsoft.AspNetCore.Mvc.ActionContext
    {
        public ControllerContext() { }
        public ControllerContext(Microsoft.AspNetCore.Mvc.ActionContext context) { }
        public new Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor ActionDescriptor { get { throw null; } set { } }
        public virtual System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> ValueProviderFactories { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class ControllerContextAttribute : System.Attribute
    {
        public ControllerContextAttribute() { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(201)]
    public partial class CreatedAtActionResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public CreatedAtActionResult(string actionName, string controllerName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public string ActionName { get { throw null; } set { } }
        public string ControllerName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(201)]
    public partial class CreatedAtRouteResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public CreatedAtRouteResult(object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public CreatedAtRouteResult(string routeName, object routeValues, [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
        public string RouteName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(201)]
    public partial class CreatedResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public CreatedResult(string location, object value) : base (default(object)) { }
        public CreatedResult(System.Uri location, object value) : base (default(object)) { }
        public string Location { get { throw null; } set { } }
        public override void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    public static partial class DefaultApiConventions
    {
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(201)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        public static void Create([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Any), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object model) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(200)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Delete([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(204)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Edit([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id, [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Any), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object model) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(200)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Find([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(200)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Get([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(201)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        public static void Post([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Any), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object model) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(204)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Put([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id, [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Any), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object model) { }
        [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
        [Microsoft.AspNetCore.Mvc.ProducesDefaultResponseTypeAttribute]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(204)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(400)]
        [Microsoft.AspNetCore.Mvc.ProducesResponseTypeAttribute(404)]
        public static void Update([Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Suffix), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object id, [Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Any), Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior.Any)] object model) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class DisableRequestSizeLimitAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public DisableRequestSizeLimitAttribute() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class EmptyResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public EmptyResult() { }
        public override void ExecuteResult(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    public partial class FileContentResult : Microsoft.AspNetCore.Mvc.FileResult
    {
        public FileContentResult(byte[] fileContents, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) : base (default(string)) { }
        public FileContentResult(byte[] fileContents, string contentType) : base (default(string)) { }
        public byte[] FileContents { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public abstract partial class FileResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        protected FileResult(string contentType) { }
        public string ContentType { get { throw null; } }
        public bool EnableRangeProcessing { get { throw null; } set { } }
        public Microsoft.Net.Http.Headers.EntityTagHeaderValue EntityTag { get { throw null; } set { } }
        public string FileDownloadName { get { throw null; } set { } }
        public System.DateTimeOffset? LastModified { get { throw null; } set { } }
    }
    public partial class FileStreamResult : Microsoft.AspNetCore.Mvc.FileResult
    {
        public FileStreamResult(System.IO.Stream fileStream, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) : base (default(string)) { }
        public FileStreamResult(System.IO.Stream fileStream, string contentType) : base (default(string)) { }
        public System.IO.Stream FileStream { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class ForbidResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public ForbidResult() { }
        public ForbidResult(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public ForbidResult(System.Collections.Generic.IList<string> authenticationSchemes) { }
        public ForbidResult(System.Collections.Generic.IList<string> authenticationSchemes, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public ForbidResult(string authenticationScheme) { }
        public ForbidResult(string authenticationScheme, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public System.Collections.Generic.IList<string> AuthenticationSchemes { get { throw null; } set { } }
        public Microsoft.AspNetCore.Authentication.AuthenticationProperties Properties { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class FormatFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public FormatFilterAttribute() { }
        public bool IsReusable { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class FromBodyAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata
    {
        public FromBodyAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class FromFormAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider
    {
        public FromFormAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class FromHeaderAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider
    {
        public FromHeaderAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class FromQueryAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider
    {
        public FromQueryAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class FromRouteAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider
    {
        public FromRouteAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, AllowMultiple=false, Inherited=true)]
    public partial class FromServicesAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata
    {
        public FromServicesAttribute() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
    }
    public partial class HttpDeleteAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpDeleteAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpDeleteAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpGetAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpGetAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpGetAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpHeadAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpHeadAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpHeadAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpOptionsAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpOptionsAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpOptionsAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpPatchAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpPatchAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpPatchAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpPostAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpPostAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpPostAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial class HttpPutAttribute : Microsoft.AspNetCore.Mvc.Routing.HttpMethodAttribute
    {
        public HttpPutAttribute() : base (default(System.Collections.Generic.IEnumerable<string>)) { }
        public HttpPutAttribute(string template) : base (default(System.Collections.Generic.IEnumerable<string>)) { }
    }
    public partial interface IDesignTimeMvcBuilderConfiguration
    {
        void ConfigureMvc(Microsoft.Extensions.DependencyInjection.IMvcBuilder builder);
    }
    public partial interface IRequestFormLimitsPolicy : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    public partial interface IRequestSizePolicy : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    public partial class JsonOptions
    {
        public JsonOptions() { }
        public System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get { throw null; } }
    }
    public partial class JsonResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public JsonResult(object value) { }
        public JsonResult(object value, object serializerSettings) { }
        public string ContentType { get { throw null; } set { } }
        public object SerializerSettings { get { throw null; } set { } }
        public int? StatusCode { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class LocalRedirectResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public LocalRedirectResult(string localUrl) { }
        public LocalRedirectResult(string localUrl, bool permanent) { }
        public LocalRedirectResult(string localUrl, bool permanent, bool preserveMethod) { }
        public bool Permanent { get { throw null; } set { } }
        public bool PreserveMethod { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public partial class MiddlewareFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public MiddlewareFilterAttribute(System.Type configurationType) { }
        public System.Type ConfigurationType { get { throw null; } }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Enum | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=true)]
    public partial class ModelBinderAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.IBinderTypeProviderMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelNameProvider
    {
        public ModelBinderAttribute() { }
        public ModelBinderAttribute(System.Type binderType) { }
        public System.Type BinderType { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } protected set { } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class ModelMetadataTypeAttribute : System.Attribute
    {
        public ModelMetadataTypeAttribute(System.Type type) { }
        public System.Type MetadataType { get { throw null; } }
    }
    internal static partial class MvcCoreDiagnosticListenerExtensions
    {
        public static void AfterAction(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData) { }
        public static void AfterActionResult(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void AfterControllerActionMethod(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> actionArguments, object controller, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void AfterOnActionExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IActionFilter filter) { }
        public static void AfterOnActionExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IActionFilter filter) { }
        public static void AfterOnActionExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter filter) { }
        public static void AfterOnAuthorization(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter filter) { }
        public static void AfterOnAuthorizationAsync(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter filter) { }
        public static void AfterOnException(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter filter) { }
        public static void AfterOnExceptionAsync(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncExceptionFilter filter) { }
        public static void AfterOnResourceExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter filter) { }
        public static void AfterOnResourceExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter filter) { }
        public static void AfterOnResourceExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncResourceFilter filter) { }
        public static void AfterOnResultExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IResultFilter filter) { }
        public static void AfterOnResultExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IResultFilter filter) { }
        public static void AfterOnResultExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter filter) { }
        public static void BeforeAction(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData) { }
        public static void BeforeActionResult(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public static void BeforeControllerActionMethod(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> actionArguments, object controller) { }
        public static void BeforeOnActionExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IActionFilter filter) { }
        public static void BeforeOnActionExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IActionFilter filter) { }
        public static void BeforeOnActionExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter filter) { }
        public static void BeforeOnAuthorization(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter filter) { }
        public static void BeforeOnAuthorizationAsync(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter filter) { }
        public static void BeforeOnException(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter filter) { }
        public static void BeforeOnExceptionAsync(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncExceptionFilter filter) { }
        public static void BeforeOnResourceExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter filter) { }
        public static void BeforeOnResourceExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter filter) { }
        public static void BeforeOnResourceExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncResourceFilter filter) { }
        public static void BeforeOnResultExecuted(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IResultFilter filter) { }
        public static void BeforeOnResultExecuting(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IResultFilter filter) { }
        public static void BeforeOnResultExecution(this System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter filter) { }
    }
    internal static partial class MvcCoreLoggerExtensions
    {
        public const string ActionFilter = "Action Filter";
        public static void ActionDoesNotExplicitlySpecifyContentTypes(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ActionDoesNotSupportFormatFilterContentType(this Microsoft.Extensions.Logging.ILogger logger, string format, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection supportedMediaTypes) { }
        public static void ActionFiltersExecutionPlan(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public static void ActionFilterShortCircuited(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void ActionMethodExecuted(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ControllerContext context, Microsoft.AspNetCore.Mvc.IActionResult result, System.TimeSpan timeSpan) { }
        public static void ActionMethodExecuting(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ControllerContext context, object[] arguments) { }
        public static void AfterExecutingActionResult(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.IActionResult actionResult) { }
        public static void AfterExecutingMethodOnFilter(this Microsoft.Extensions.Logging.ILogger logger, string filterType, string methodName, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void AmbiguousActions(this Microsoft.Extensions.Logging.ILogger logger, string actionNames) { }
        public static void AppliedRequestFormLimits(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void AttemptingToBindCollectionUsingIndices(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void AttemptingToBindModel(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void AttemptingToBindParameterOrProperty(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { }
        public static void AttemptingToValidateParameterOrProperty(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { }
        public static void AuthorizationFailure(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void AuthorizationFiltersExecutionPlan(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public static void BeforeExecutingActionResult(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.IActionResult actionResult) { }
        public static void BeforeExecutingMethodOnFilter(this Microsoft.Extensions.Logging.ILogger logger, string filterType, string methodName, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void CannotApplyFormatFilterContentType(this Microsoft.Extensions.Logging.ILogger logger, string format) { }
        public static void CannotApplyRequestFormLimits(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void CannotBindToComplexType(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void CannotBindToFilesCollectionDueToUnsupportedContentType(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void CannotCreateHeaderModelBinder(this Microsoft.Extensions.Logging.ILogger logger, System.Type modelType) { }
        public static void CannotCreateHeaderModelBinderCompatVersion_2_0(this Microsoft.Extensions.Logging.ILogger logger, System.Type modelType) { }
        public static void ChallengeResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IList<string> schemes) { }
        public static void ConstraintMismatch(this Microsoft.Extensions.Logging.ILogger logger, string actionName, string actionId, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint actionConstraint) { }
        public static void ContentResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string contentType) { }
        public static void DoneAttemptingToBindModel(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void DoneAttemptingToBindParameterOrProperty(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { }
        public static void DoneAttemptingToValidateParameterOrProperty(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { }
        public static void ExceptionFiltersExecutionPlan(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public static void ExceptionFilterShortCircuited(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void ExecutedAction(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action, System.TimeSpan timeSpan) { }
        public static void ExecutedControllerFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ControllerContext context) { }
        public static void ExecutingAction(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action) { }
        public static void ExecutingControllerFactory(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ControllerContext context) { }
        public static void ExecutingFileResult(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.FileResult fileResult) { }
        public static void ExecutingFileResult(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.FileResult fileResult, string fileName) { }
        public static void FeatureIsReadOnly(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void FeatureNotFound(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ForbidResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IList<string> authenticationSchemes) { }
        public static void FormatterSelected(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter outputFormatter, Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context) { }
        public static void FoundNoValueInRequest(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void HttpStatusCodeResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, int statusCode) { }
        public static void IfMatchPreconditionFailed(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Net.Http.Headers.EntityTagHeaderValue etag) { }
        public static void IfRangeETagPreconditionFailed(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Net.Http.Headers.EntityTagHeaderValue currentETag, Microsoft.Net.Http.Headers.EntityTagHeaderValue ifRangeTag) { }
        public static void IfRangeLastModifiedPreconditionFailed(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset? lastModified, System.DateTimeOffset? ifRangeLastModifiedDate) { }
        public static void IfUnmodifiedSincePreconditionFailed(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset? lastModified, System.DateTimeOffset? ifUnmodifiedSinceDate) { }
        public static void InferredParameterBindingSource(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel parameterModel, Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { }
        public static void InputFormatterRejected(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter inputFormatter, Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext formatterContext) { }
        public static void InputFormatterSelected(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter inputFormatter, Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext formatterContext) { }
        public static void LocalRedirectResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string destination) { }
        public static void MaxRequestBodySizeSet(this Microsoft.Extensions.Logging.ILogger logger, string requestSize) { }
        public static void ModelStateInvalidFilterExecuting(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoAcceptForNegotiation(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoActionsMatched(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IDictionary<string, object> routeValueDictionary) { }
        public static void NoFilesFoundInRequest(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoFormatter(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { }
        public static void NoFormatterFromNegotiation(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality> acceptTypes) { }
        public static void NoInputFormatterSelected(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext formatterContext) { }
        public static void NoKeyValueFormatForDictionaryModelBinder(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void NoNonIndexBasedFormatFoundForCollection(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void NoPublicSettableProperties(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        public static void NotEnabledForRangeProcessing(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NotMostEffectiveFilter(this Microsoft.Extensions.Logging.ILogger logger, System.Type overridenFilter, System.Type overridingFilter, System.Type policyType) { }
        public static void ObjectResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, object value) { }
        public static void ParameterBinderRequestPredicateShortCircuit(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata) { }
        public static void RedirectResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string destination) { }
        public static void RedirectToActionResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string destination) { }
        public static void RedirectToPageResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string page) { }
        public static void RedirectToRouteResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string destination, string routeName) { }
        public static void RegisteredModelBinderProviders(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider[] providers) { }
        public static void RegisteredOutputFormatters(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter> outputFormatters) { }
        public static void RequestBodySizeLimitDisabled(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ResourceFiltersExecutionPlan(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public static void ResourceFilterShortCircuited(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void ResultFiltersExecutionPlan(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> filters) { }
        public static void ResultFilterShortCircuited(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public static void SelectFirstCanWriteFormatter(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void SelectingOutputFormatterUsingAcceptHeader(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality> acceptHeader) { }
        public static void SelectingOutputFormatterUsingAcceptHeaderAndExplicitContentTypes(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality> acceptHeader, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection mediaTypeCollection) { }
        public static void SelectingOutputFormatterUsingContentTypes(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection mediaTypeCollection) { }
        public static void SelectingOutputFormatterWithoutUsingContentTypes(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void SignInResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, string authenticationScheme, System.Security.Claims.ClaimsPrincipal principal) { }
        public static void SignOutResultExecuting(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IList<string> authenticationSchemes) { }
        public static void SkippedContentNegotiation(this Microsoft.Extensions.Logging.ILogger logger, string contentType) { }
        public static void TransformingClientError(this Microsoft.Extensions.Logging.ILogger logger, System.Type initialType, System.Type replacedType, int? statusCode) { }
        public static void UnsupportedFormatFilterContentType(this Microsoft.Extensions.Logging.ILogger logger, string format) { }
        public static void WritingRangeToBody(this Microsoft.Extensions.Logging.ILogger logger) { }
    }
    internal partial class MvcCoreMvcOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcOptions>, Microsoft.Extensions.Options.IPostConfigureOptions<Microsoft.AspNetCore.Mvc.MvcOptions>
    {
        public MvcCoreMvcOptionsSetup(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory) { }
        public MvcCoreMvcOptionsSetup(Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.JsonOptions> jsonOptions) { }
        public void Configure(Microsoft.AspNetCore.Mvc.MvcOptions options) { }
        internal static void ConfigureAdditionalModelMetadataDetailsProviders(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider> modelMetadataDetailsProviders) { }
        public void PostConfigure(string name, Microsoft.AspNetCore.Mvc.MvcOptions options) { }
    }
    public partial class MvcOptions : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>, System.Collections.IEnumerable
    {
        internal const int DefaultMaxModelBindingCollectionSize = 1024;
        internal const int DefaultMaxModelBindingRecursionDepth = 32;
        public MvcOptions() { }
        public bool AllowEmptyInputInBodyModelBinding { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.AspNetCore.Mvc.CacheProfile> CacheProfiles { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> Conventions { get { throw null; } }
        public bool EnableEndpointRouting { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.FilterCollection Filters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Formatters.FormatterMappings FormatterMappings { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Formatters.FormatterCollection<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> InputFormatters { get { throw null; } }
        public int MaxIAsyncEnumerableBufferLimit { get { throw null; } set { } }
        public int MaxModelBindingCollectionSize { get { throw null; } set { } }
        public int MaxModelBindingRecursionDepth { get { throw null; } set { } }
        public int MaxModelValidationErrors { get { throw null; } set { } }
        public int? MaxValidationDepth { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider> ModelBinderProviders { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelBindingMessageProvider ModelBindingMessageProvider { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider> ModelMetadataDetailsProviders { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> ModelValidatorProviders { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Formatters.FormatterCollection<Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter> OutputFormatters { get { throw null; } }
        public bool RequireHttpsPermanent { get { throw null; } set { } }
        public bool RespectBrowserAcceptHeader { get { throw null; } set { } }
        public bool ReturnHttpNotAcceptable { get { throw null; } set { } }
        public int? SslPort { get { throw null; } set { } }
        public bool SuppressAsyncSuffixInActionNames { get { throw null; } set { } }
        public bool SuppressImplicitRequiredAttributeForNonNullableReferenceTypes { get { throw null; } set { } }
        public bool SuppressInputFormatterBuffering { get { throw null; } set { } }
        public bool SuppressOutputFormatterBuffering { get { throw null; } set { } }
        public bool ValidateComplexTypesIfChildValidationFails { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> ValueProviderFactories { get { throw null; } }
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(204)]
    public partial class NoContentResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public NoContentResult() : base (default(int)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed partial class NonActionAttribute : System.Attribute
    {
        public NonActionAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class NonControllerAttribute : System.Attribute
    {
        public NonControllerAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public partial class NonViewComponentAttribute : System.Attribute
    {
        public NonViewComponentAttribute() { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(404)]
    public partial class NotFoundObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public NotFoundObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(404)]
    public partial class NotFoundResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public NotFoundResult() : base (default(int)) { }
    }
    public partial class ObjectResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public ObjectResult(object value) { }
        public Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection ContentTypes { get { throw null; } set { } }
        public System.Type DeclaredType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Formatters.FormatterCollection<Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter> Formatters { get { throw null; } set { } }
        public int? StatusCode { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute]
        public object Value { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
        public virtual void OnFormatting(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(200)]
    public partial class OkObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public OkObjectResult(object value) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(200)]
    public partial class OkResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public OkResult() : base (default(int)) { }
    }
    public partial class PhysicalFileResult : Microsoft.AspNetCore.Mvc.FileResult
    {
        public PhysicalFileResult(string fileName, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) : base (default(string)) { }
        public PhysicalFileResult(string fileName, string contentType) : base (default(string)) { }
        public string FileName { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsJsonConverter))]
    public partial class ProblemDetails
    {
        public ProblemDetails() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("detail")]
        public string Detail { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> Extensions { get { throw null; } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instance")]
        public string Instance { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public int? Status { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("title")]
        public string Title { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class ProducesAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
        public ProducesAttribute(string contentType, params string[] additionalContentTypes) { }
        public ProducesAttribute(System.Type type) { }
        public Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection ContentTypes { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public int StatusCode { get { throw null; } }
        public System.Type Type { get { throw null; } set { } }
        public virtual void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public virtual void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
        public void SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed partial class ProducesDefaultResponseTypeAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDefaultResponseMetadataProvider, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public ProducesDefaultResponseTypeAttribute() { }
        public ProducesDefaultResponseTypeAttribute(System.Type type) { }
        public int StatusCode { get { throw null; } }
        public System.Type Type { get { throw null; } }
        void Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider.SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed partial class ProducesErrorResponseTypeAttribute : System.Attribute
    {
        public ProducesErrorResponseTypeAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public partial class ProducesResponseTypeAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public ProducesResponseTypeAttribute(int statusCode) { }
        public ProducesResponseTypeAttribute(System.Type type, int statusCode) { }
        public int StatusCode { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
        void Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider.SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { }
    }
    public partial class RedirectResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.ViewFeatures.IKeepTempDataResult
    {
        public RedirectResult(string url) { }
        public RedirectResult(string url, bool permanent) { }
        public RedirectResult(string url, bool permanent, bool preserveMethod) { }
        public bool Permanent { get { throw null; } set { } }
        public bool PreserveMethod { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class RedirectToActionResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.ViewFeatures.IKeepTempDataResult
    {
        public RedirectToActionResult(string actionName, string controllerName, object routeValues) { }
        public RedirectToActionResult(string actionName, string controllerName, object routeValues, bool permanent) { }
        public RedirectToActionResult(string actionName, string controllerName, object routeValues, bool permanent, bool preserveMethod) { }
        public RedirectToActionResult(string actionName, string controllerName, object routeValues, bool permanent, bool preserveMethod, string fragment) { }
        public RedirectToActionResult(string actionName, string controllerName, object routeValues, bool permanent, string fragment) { }
        public RedirectToActionResult(string actionName, string controllerName, object routeValues, string fragment) { }
        public string ActionName { get { throw null; } set { } }
        public string ControllerName { get { throw null; } set { } }
        public string Fragment { get { throw null; } set { } }
        public bool Permanent { get { throw null; } set { } }
        public bool PreserveMethod { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class RedirectToPageResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.ViewFeatures.IKeepTempDataResult
    {
        public RedirectToPageResult(string pageName) { }
        public RedirectToPageResult(string pageName, object routeValues) { }
        public RedirectToPageResult(string pageName, string pageHandler) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues, bool permanent) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues, bool permanent, bool preserveMethod) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues, bool permanent, bool preserveMethod, string fragment) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues, bool permanent, string fragment) { }
        public RedirectToPageResult(string pageName, string pageHandler, object routeValues, string fragment) { }
        public string Fragment { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string PageHandler { get { throw null; } set { } }
        public string PageName { get { throw null; } set { } }
        public bool Permanent { get { throw null; } set { } }
        public bool PreserveMethod { get { throw null; } set { } }
        public string Protocol { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class RedirectToRouteResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.ViewFeatures.IKeepTempDataResult
    {
        public RedirectToRouteResult(object routeValues) { }
        public RedirectToRouteResult(string routeName, object routeValues) { }
        public RedirectToRouteResult(string routeName, object routeValues, bool permanent) { }
        public RedirectToRouteResult(string routeName, object routeValues, bool permanent, bool preserveMethod) { }
        public RedirectToRouteResult(string routeName, object routeValues, bool permanent, bool preserveMethod, string fragment) { }
        public RedirectToRouteResult(string routeName, object routeValues, bool permanent, string fragment) { }
        public RedirectToRouteResult(string routeName, object routeValues, string fragment) { }
        public string Fragment { get { throw null; } set { } }
        public bool Permanent { get { throw null; } set { } }
        public bool PreserveMethod { get { throw null; } set { } }
        public string RouteName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.IUrlHelper UrlHelper { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class RequestFormLimitsAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public RequestFormLimitsAttribute() { }
        public bool BufferBody { get { throw null; } set { } }
        public long BufferBodyLengthLimit { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Http.Features.FormOptions FormOptions { get { throw null; } }
        public bool IsReusable { get { throw null; } }
        public int KeyLengthLimit { get { throw null; } set { } }
        public int MemoryBufferThreshold { get { throw null; } set { } }
        public long MultipartBodyLengthLimit { get { throw null; } set { } }
        public int MultipartBoundaryLengthLimit { get { throw null; } set { } }
        public int MultipartHeadersCountLimit { get { throw null; } set { } }
        public int MultipartHeadersLengthLimit { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public int ValueCountLimit { get { throw null; } set { } }
        public int ValueLengthLimit { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class RequestSizeLimitAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public RequestSizeLimitAttribute(long bytes) { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, Inherited=true, AllowMultiple=false)]
    public partial class RequireHttpsAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public RequireHttpsAttribute() { }
        public int Order { get { throw null; } set { } }
        public bool Permanent { get { throw null; } set { } }
        protected virtual void HandleNonHttpsRequest(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext filterContext) { }
        public virtual void OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext filterContext) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class ResponseCacheAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ResponseCacheAttribute() { }
        public string CacheProfileName { get { throw null; } set { } }
        public int Duration { get { throw null; } set { } }
        public bool IsReusable { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ResponseCacheLocation Location { get { throw null; } set { } }
        public bool NoStore { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
        public Microsoft.AspNetCore.Mvc.CacheProfile GetCacheProfile(Microsoft.AspNetCore.Mvc.MvcOptions options) { throw null; }
    }
    public enum ResponseCacheLocation
    {
        Any = 0,
        Client = 1,
        None = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public partial class RouteAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider
    {
        public RouteAttribute(string template) { }
        int? Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider.Order { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public string Template { get { throw null; } }
    }
    public sealed partial class SerializableError : System.Collections.Generic.Dictionary<string, object>
    {
        public SerializableError() { }
        public SerializableError(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    [System.Diagnostics.DebuggerDisplayAttribute("ServiceFilter: Type={ServiceType} Order={Order}")]
    public partial class ServiceFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ServiceFilterAttribute(System.Type type) { }
        public bool IsReusable { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public System.Type ServiceType { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class SignInResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public SignInResult(string authenticationScheme, System.Security.Claims.ClaimsPrincipal principal) { }
        public SignInResult(string authenticationScheme, System.Security.Claims.ClaimsPrincipal principal, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public string AuthenticationScheme { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal Principal { get { throw null; } set { } }
        public Microsoft.AspNetCore.Authentication.AuthenticationProperties Properties { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class SignOutResult : Microsoft.AspNetCore.Mvc.ActionResult
    {
        public SignOutResult() { }
        public SignOutResult(System.Collections.Generic.IList<string> authenticationSchemes) { }
        public SignOutResult(System.Collections.Generic.IList<string> authenticationSchemes, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public SignOutResult(string authenticationScheme) { }
        public SignOutResult(string authenticationScheme, Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { }
        public System.Collections.Generic.IList<string> AuthenticationSchemes { get { throw null; } set { } }
        public Microsoft.AspNetCore.Authentication.AuthenticationProperties Properties { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public partial class StatusCodeResult : Microsoft.AspNetCore.Mvc.ActionResult, Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
        public StatusCodeResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultStatusCodeAttribute] int statusCode) { }
        int? Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult.StatusCode { get { throw null; } }
        public int StatusCode { get { throw null; } }
        public override void ExecuteResult(Microsoft.AspNetCore.Mvc.ActionContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    [System.Diagnostics.DebuggerDisplayAttribute("TypeFilter: Type={ImplementationType} Order={Order}")]
    public partial class TypeFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public TypeFilterAttribute(System.Type type) { }
        public object[] Arguments { get { throw null; } set { } }
        public System.Type ImplementationType { get { throw null; } }
        public bool IsReusable { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(401)]
    public partial class UnauthorizedObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public UnauthorizedObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object value) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(401)]
    public partial class UnauthorizedResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public UnauthorizedResult() : base (default(int)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(422)]
    public partial class UnprocessableEntityObjectResult : Microsoft.AspNetCore.Mvc.ObjectResult
    {
        public UnprocessableEntityObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) : base (default(object)) { }
        public UnprocessableEntityObjectResult([Microsoft.AspNetCore.Mvc.Infrastructure.ActionResultObjectValueAttribute] object error) : base (default(object)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(422)]
    public partial class UnprocessableEntityResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public UnprocessableEntityResult() : base (default(int)) { }
    }
    [Microsoft.AspNetCore.Mvc.Infrastructure.DefaultStatusCodeAttribute(415)]
    public partial class UnsupportedMediaTypeResult : Microsoft.AspNetCore.Mvc.StatusCodeResult
    {
        public UnsupportedMediaTypeResult() : base (default(int)) { }
    }
    public static partial class UrlHelperExtensions
    {
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, object values) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, string controller) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, string controller, object values) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, string controller, object values, string protocol) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, string controller, object values, string protocol, string host) { throw null; }
        public static string Action(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action, string controller, object values, string protocol, string host, string fragment) { throw null; }
        public static string ActionLink(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string action = null, string controller = null, object values = null, string protocol = null, string host = null, string fragment = null) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, object values) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, string pageHandler) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, string pageHandler, object values) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, string pageHandler, object values, string protocol) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, string pageHandler, object values, string protocol, string host) { throw null; }
        public static string Page(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName, string pageHandler, object values, string protocol, string host, string fragment) { throw null; }
        public static string PageLink(this Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, string pageName = null, string pageHandler = null, object values = null, string protocol = null, string host = null, string fragment = null) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, object values) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string routeName) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string routeName, object values) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string routeName, object values, string protocol) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string routeName, object values, string protocol, string host) { throw null; }
        public static string RouteUrl(this Microsoft.AspNetCore.Mvc.IUrlHelper helper, string routeName, object values, string protocol, string host, string fragment) { throw null; }
    }
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.ValidationProblemDetailsJsonConverter))]
    public partial class ValidationProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails
    {
        public ValidationProblemDetails() { }
        public ValidationProblemDetails(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState) { }
        public ValidationProblemDetails(System.Collections.Generic.IDictionary<string, string[]> errors) { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("errors")]
        public System.Collections.Generic.IDictionary<string, string[]> Errors { get { throw null; } }
    }
    public partial class VirtualFileResult : Microsoft.AspNetCore.Mvc.FileResult
    {
        public VirtualFileResult(string fileName, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) : base (default(string)) { }
        public VirtualFileResult(string fileName, string contentType) : base (default(string)) { }
        public string FileName { get { throw null; } set { } }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } set { } }
        public override System.Threading.Tasks.Task ExecuteResultAsync(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ActionConstraints
{
    internal partial class ActionConstraintCache
    {
        public ActionConstraintCache(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider collectionProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider> actionConstraintProviders) { }
        internal Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintCache.InnerCache CurrentCache { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint> GetActionConstraints(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal readonly partial struct CacheEntry
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public CacheEntry(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint> actionConstraints) { throw null; }
            public CacheEntry(System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintItem> items) { throw null; }
            public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint> ActionConstraints { get { throw null; } }
            public System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintItem> Items { get { throw null; } }
        }
        internal partial class InnerCache
        {
            public InnerCache(Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection actions) { }
            public System.Collections.Concurrent.ConcurrentDictionary<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor, Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintCache.CacheEntry> Entries { get { throw null; } }
            public int Version { get { throw null; } }
        }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public abstract partial class ActionMethodSelectorAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata
    {
        protected ActionMethodSelectorAttribute() { }
        public int Order { get { throw null; } set { } }
        public bool Accept(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintContext context) { throw null; }
        public abstract bool IsValidForRequest(Microsoft.AspNetCore.Routing.RouteContext routeContext, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action);
    }
    internal partial class DefaultActionConstraintProvider : Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider
    {
        public DefaultActionConstraintProvider() { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintProviderContext context) { }
    }
    public partial class HttpMethodActionConstraint : Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata
    {
        public static readonly int HttpMethodConstraintOrder;
        public HttpMethodActionConstraint(System.Collections.Generic.IEnumerable<string> httpMethods) { }
        public System.Collections.Generic.IEnumerable<string> HttpMethods { get { throw null; } }
        public int Order { get { throw null; } }
        public virtual bool Accept(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintContext context) { throw null; }
    }
    internal partial interface IConsumesActionConstraint : Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraint, Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata
    {
    }
}
namespace Microsoft.AspNetCore.Mvc.ApiExplorer
{
    internal static partial class ApiConventionMatcher
    {
        internal static Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior GetNameMatchBehavior(System.Reflection.ICustomAttributeProvider attributeProvider) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior GetTypeMatchBehavior(System.Reflection.ICustomAttributeProvider attributeProvider) { throw null; }
        internal static bool IsMatch(System.Reflection.MethodInfo methodInfo, System.Reflection.MethodInfo conventionMethod) { throw null; }
        internal static bool IsNameMatch(string name, string conventionName, Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior nameMatchBehavior) { throw null; }
        internal static bool IsTypeMatch(System.Type type, System.Type conventionType, Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior typeMatchBehavior) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter, AllowMultiple=false, Inherited=false)]
    public sealed partial class ApiConventionNameMatchAttribute : System.Attribute
    {
        public ApiConventionNameMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior matchBehavior) { }
        public Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior MatchBehavior { get { throw null; } }
    }
    public enum ApiConventionNameMatchBehavior
    {
        Any = 0,
        Exact = 1,
        Prefix = 2,
        Suffix = 3,
    }
    public sealed partial class ApiConventionResult
    {
        public ApiConventionResult(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider> responseMetadataProviders) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider> ResponseMetadataProviders { get { throw null; } }
        internal static bool TryGetApiConvention(System.Reflection.MethodInfo method, Microsoft.AspNetCore.Mvc.ApiConventionTypeAttribute[] apiConventionAttributes, out Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionResult result) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, AllowMultiple=false, Inherited=false)]
    public sealed partial class ApiConventionTypeMatchAttribute : System.Attribute
    {
        public ApiConventionTypeMatchAttribute(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior matchBehavior) { }
        public Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionTypeMatchBehavior MatchBehavior { get { throw null; } }
    }
    public enum ApiConventionTypeMatchBehavior
    {
        Any = 0,
        AssignableFrom = 1,
    }
    public partial interface IApiDefaultResponseMetadataProvider : Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseMetadataProvider, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    public partial interface IApiDescriptionGroupNameProvider
    {
        string GroupName { get; }
    }
    public partial interface IApiDescriptionVisibilityProvider
    {
        bool IgnoreApi { get; }
    }
    public partial interface IApiRequestFormatMetadataProvider
    {
        System.Collections.Generic.IReadOnlyList<string> GetSupportedContentTypes(string contentType, System.Type objectType);
    }
    public partial interface IApiRequestMetadataProvider : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        void SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes);
    }
    public partial interface IApiResponseMetadataProvider : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        int StatusCode { get; }
        System.Type Type { get; }
        void SetContentTypes(Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes);
    }
    public partial interface IApiResponseTypeMetadataProvider
    {
        System.Collections.Generic.IReadOnlyList<string> GetSupportedContentTypes(string contentType, System.Type objectType);
    }
}
namespace Microsoft.AspNetCore.Mvc.ApplicationModels
{
    internal static partial class ActionAttributeRouteModel
    {
        public static System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel> FlattenSelectors(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel actionModel) { throw null; }
        public static System.Collections.Generic.IEnumerable<(Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel route, Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel actionSelector, Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel controllerSelector)> GetAttributeRoutes(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel actionModel) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DisplayName}")]
    public partial class ActionModel : Microsoft.AspNetCore.Mvc.ApplicationModels.IApiExplorerModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IFilterModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public ActionModel(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel other) { }
        public ActionModel(System.Reflection.MethodInfo actionMethod, System.Collections.Generic.IReadOnlyList<object> attributes) { }
        public System.Reflection.MethodInfo ActionMethod { get { throw null; } }
        public string ActionName { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApiExplorerModel ApiExplorer { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel Controller { get { throw null; } set { } }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        string Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.Name { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel> Parameters { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Routing.IOutboundParameterTransformer RouteParameterTransformer { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel> Selectors { get { throw null; } }
    }
    internal partial class ApiBehaviorApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public ApiBehaviorApplicationModelProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions> apiBehaviorOptions, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorFactory clientErrorFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention> ActionModelConventions { get { throw null; } }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    public partial class ApiConventionApplicationModelConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public ApiConventionApplicationModelConvention(Microsoft.AspNetCore.Mvc.ProducesErrorResponseTypeAttribute defaultErrorResponseType) { }
        public Microsoft.AspNetCore.Mvc.ProducesErrorResponseTypeAttribute DefaultErrorResponseType { get { throw null; } }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    public partial class ApiExplorerModel
    {
        public ApiExplorerModel() { }
        public ApiExplorerModel(Microsoft.AspNetCore.Mvc.ApplicationModels.ApiExplorerModel other) { }
        public string GroupName { get { throw null; } set { } }
        public bool? IsVisible { get { throw null; } set { } }
    }
    public partial class ApiVisibilityConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public ApiVisibilityConvention() { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ApplicationModel: Controllers: {Controllers.Count}, Filters: {Filters.Count}")]
    public partial class ApplicationModel : Microsoft.AspNetCore.Mvc.ApplicationModels.IApiExplorerModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IFilterModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public ApplicationModel() { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApiExplorerModel ApiExplorer { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel> Controllers { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
    }
    internal static partial class ApplicationModelConventions
    {
        public static void ApplyConventions(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel applicationModel, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> conventions) { }
    }
    internal partial class ApplicationModelFactory
    {
        public ApplicationModelFactory(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider> applicationModelProviders, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> options) { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel CreateApplicationModel(System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> controllerTypes) { throw null; }
        public static System.Collections.Generic.List<TResult> Flatten<TResult>(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel application, System.Func<Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel, Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel, TResult> flattener) { throw null; }
    }
    public partial class ApplicationModelProviderContext
    {
        public ApplicationModelProviderContext(System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> controllerTypes) { }
        public System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> ControllerTypes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel Result { get { throw null; } }
    }
    public partial class AttributeRouteModel
    {
        public AttributeRouteModel() { }
        public AttributeRouteModel(Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel other) { }
        public AttributeRouteModel(Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider templateProvider) { }
        public Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider Attribute { get { throw null; } }
        public bool IsAbsoluteTemplate { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
        public bool SuppressLinkGeneration { get { throw null; } set { } }
        public bool SuppressPathMatching { get { throw null; } set { } }
        public string Template { get { throw null; } set { } }
        public static Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel CombineAttributeRouteModel(Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel left, Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel right) { throw null; }
        public static string CombineTemplates(string prefix, string template) { throw null; }
        public static bool IsOverridePattern(string template) { throw null; }
        public static string ReplaceTokens(string template, System.Collections.Generic.IDictionary<string, string> values) { throw null; }
        public static string ReplaceTokens(string template, System.Collections.Generic.IDictionary<string, string> values, Microsoft.AspNetCore.Routing.IOutboundParameterTransformer routeTokenTransformer) { throw null; }
    }
    internal partial class AuthorizationApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public AuthorizationApplicationModelProvider(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider policyProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        public int Order { get { throw null; } }
        public static Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter GetFilter(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider policyProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizeData> authData) { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    public partial class ClientErrorResultFilterConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public ClientErrorResultFilterConvention() { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    public partial class ConsumesConstraintForFormFileParameterConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public ConsumesConstraintForFormFileParameterConvention() { }
        internal void AddMultipartFormDataConsumesAttribute(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    internal static partial class ControllerActionDescriptorBuilder
    {
        public static void AddRouteValues(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel controller, Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        public static System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor> Build(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel application) { throw null; }
    }
    internal partial class ControllerActionDescriptorProvider : Microsoft.AspNetCore.Mvc.Abstractions.IActionDescriptorProvider
    {
        public ControllerActionDescriptorProvider(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager partManager, Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelFactory applicationModelFactory) { }
        public int Order { get { throw null; } }
        internal System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor> GetDescriptors() { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptorProviderContext context) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DisplayName}")]
    public partial class ControllerModel : Microsoft.AspNetCore.Mvc.ApplicationModels.IApiExplorerModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IFilterModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public ControllerModel(Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel other) { }
        public ControllerModel(System.Reflection.TypeInfo controllerType, System.Collections.Generic.IReadOnlyList<object> attributes) { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel> Actions { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApiExplorerModel ApiExplorer { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel Application { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public string ControllerName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.PropertyModel> ControllerProperties { get { throw null; } }
        public System.Reflection.TypeInfo ControllerType { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get { throw null; } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        string Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.Name { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel> Selectors { get { throw null; } }
    }
    internal partial class DefaultApplicationModelProvider : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider
    {
        public DefaultApplicationModelProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptionsAccessor, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        public int Order { get { throw null; } }
        internal Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel CreateActionModel(System.Reflection.TypeInfo typeInfo, System.Reflection.MethodInfo methodInfo) { throw null; }
        internal Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel CreateControllerModel(System.Reflection.TypeInfo typeInfo) { throw null; }
        internal Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel CreateParameterModel(System.Reflection.ParameterInfo parameterInfo) { throw null; }
        internal Microsoft.AspNetCore.Mvc.ApplicationModels.PropertyModel CreatePropertyModel(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        internal bool IsAction(System.Reflection.TypeInfo typeInfo, System.Reflection.MethodInfo methodInfo) { throw null; }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context) { }
    }
    public partial interface IActionModelConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action);
    }
    public partial interface IApiExplorerModel
    {
        Microsoft.AspNetCore.Mvc.ApplicationModels.ApiExplorerModel ApiExplorer { get; set; }
    }
    public partial interface IApplicationModelConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel application);
    }
    public partial interface IApplicationModelProvider
    {
        int Order { get; }
        void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context);
        void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelProviderContext context);
    }
    public partial interface IBindingModel
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo BindingInfo { get; set; }
    }
    public partial interface ICommonModel : Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        System.Collections.Generic.IReadOnlyList<object> Attributes { get; }
        System.Reflection.MemberInfo MemberInfo { get; }
        string Name { get; }
    }
    public partial interface IControllerModelConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel controller);
    }
    public partial interface IFilterModel
    {
        System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata> Filters { get; }
    }
    public partial class InferParameterBindingInfoConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public InferParameterBindingInfoConvention(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider) { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        internal Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource InferBindingSourceForParameter(Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel parameter) { throw null; }
        internal void InferParameterBindingSources(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    public partial class InvalidModelStateFilterConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public InvalidModelStateFilterConvention() { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    public partial interface IParameterModelBaseConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase parameter);
    }
    public partial interface IParameterModelConvention
    {
        void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel parameter);
    }
    public partial interface IPropertyModel
    {
        System.Collections.Generic.IDictionary<object, object> Properties { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ParameterModel: Name={ParameterName}")]
    public partial class ParameterModel : Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public ParameterModel(Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModel other) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public ParameterModel(System.Reflection.ParameterInfo parameterInfo, System.Collections.Generic.IReadOnlyList<object> attributes) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel Action { get { throw null; } set { } }
        public new System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public string DisplayName { get { throw null; } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } }
        public string ParameterName { get { throw null; } set { } }
        public new System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
    }
    public abstract partial class ParameterModelBase : Microsoft.AspNetCore.Mvc.ApplicationModels.IBindingModel
    {
        protected ParameterModelBase(Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase other) { }
        protected ParameterModelBase(System.Type parameterType, System.Collections.Generic.IReadOnlyList<object> attributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo BindingInfo { get { throw null; } set { } }
        public string Name { get { throw null; } protected set { } }
        public System.Type ParameterType { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PropertyModel: Name={PropertyName}")]
    public partial class PropertyModel : Microsoft.AspNetCore.Mvc.ApplicationModels.ParameterModelBase, Microsoft.AspNetCore.Mvc.ApplicationModels.IBindingModel, Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel, Microsoft.AspNetCore.Mvc.ApplicationModels.IPropertyModel
    {
        public PropertyModel(Microsoft.AspNetCore.Mvc.ApplicationModels.PropertyModel other) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public PropertyModel(System.Reflection.PropertyInfo propertyInfo, System.Collections.Generic.IReadOnlyList<object> attributes) : base (default(System.Type), default(System.Collections.Generic.IReadOnlyList<object>)) { }
        public new System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerModel Controller { get { throw null; } set { } }
        System.Reflection.MemberInfo Microsoft.AspNetCore.Mvc.ApplicationModels.ICommonModel.MemberInfo { get { throw null; } }
        public new System.Collections.Generic.IDictionary<object, object> Properties { get { throw null; } }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public string PropertyName { get { throw null; } set { } }
    }
    public partial class RouteTokenTransformerConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention
    {
        public RouteTokenTransformerConvention(Microsoft.AspNetCore.Routing.IOutboundParameterTransformer parameterTransformer) { }
        public void Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { }
        protected virtual bool ShouldApply(Microsoft.AspNetCore.Mvc.ApplicationModels.ActionModel action) { throw null; }
    }
    public partial class SelectorModel
    {
        public SelectorModel() { }
        public SelectorModel(Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel other) { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintMetadata> ActionConstraints { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel AttributeRouteModel { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> EndpointMetadata { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    public abstract partial class ApplicationPart
    {
        protected ApplicationPart() { }
        public abstract string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    public sealed partial class ApplicationPartAttribute : System.Attribute
    {
        public ApplicationPartAttribute(string assemblyName) { }
        public string AssemblyName { get { throw null; } }
    }
    public abstract partial class ApplicationPartFactory
    {
        protected ApplicationPartFactory() { }
        public static Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartFactory GetApplicationPartFactory(System.Reflection.Assembly assembly) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetApplicationParts(System.Reflection.Assembly assembly);
    }
    public partial class ApplicationPartManager
    {
        public ApplicationPartManager() { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> ApplicationParts { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider> FeatureProviders { get { throw null; } }
        internal void PopulateDefaultParts(string entryAssemblyName) { }
        public void PopulateFeature<TFeature>(TFeature feature) { }
    }
    public partial class AssemblyPart : Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart, Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationPartTypeProvider
    {
        public AssemblyPart(System.Reflection.Assembly assembly) { }
        public System.Reflection.Assembly Assembly { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> Types { get { throw null; } }
    }
    public partial class DefaultApplicationPartFactory : Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartFactory
    {
        public DefaultApplicationPartFactory() { }
        public static Microsoft.AspNetCore.Mvc.ApplicationParts.DefaultApplicationPartFactory Instance { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetApplicationParts(System.Reflection.Assembly assembly) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetDefaultApplicationParts(System.Reflection.Assembly assembly) { throw null; }
    }
    public partial interface IApplicationFeatureProvider
    {
    }
    public partial interface IApplicationFeatureProvider<TFeature> : Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider
    {
        void PopulateFeature(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> parts, TFeature feature);
    }
    public partial interface IApplicationPartTypeProvider
    {
        System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> Types { get; }
    }
    public partial interface ICompilationReferencesProvider
    {
        System.Collections.Generic.IEnumerable<string> GetReferencePaths();
    }
    public partial class NullApplicationPartFactory : Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartFactory
    {
        public NullApplicationPartFactory() { }
        public override System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> GetApplicationParts(System.Reflection.Assembly assembly) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false)]
    public sealed partial class ProvideApplicationPartFactoryAttribute : System.Attribute
    {
        public ProvideApplicationPartFactoryAttribute(string factoryTypeName) { }
        public ProvideApplicationPartFactoryAttribute(System.Type factoryType) { }
        public System.Type GetFactoryType() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    public sealed partial class RelatedAssemblyAttribute : System.Attribute
    {
        public RelatedAssemblyAttribute(string assemblyFileName) { }
        public string AssemblyFileName { get { throw null; } }
        internal static string GetAssemblyLocation(System.Reflection.Assembly assembly) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<System.Reflection.Assembly> GetRelatedAssemblies(System.Reflection.Assembly assembly, bool throwOnError) { throw null; }
        internal static System.Collections.Generic.IReadOnlyList<System.Reflection.Assembly> GetRelatedAssemblies(System.Reflection.Assembly assembly, bool throwOnError, System.Func<string, bool> fileExists, System.Func<string, System.Reflection.Assembly> loadFile) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Authorization
{
    public partial class AllowAnonymousFilter : Microsoft.AspNetCore.Mvc.Authorization.IAllowAnonymousFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public AllowAnonymousFilter() { }
    }
    public partial class AuthorizeFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public AuthorizeFilter() { }
        public AuthorizeFilter(Microsoft.AspNetCore.Authorization.AuthorizationPolicy policy) { }
        public AuthorizeFilter(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider policyProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizeData> authorizeData) { }
        public AuthorizeFilter(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizeData> authorizeData) { }
        public AuthorizeFilter(string policy) { }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizeData> AuthorizeData { get { throw null; } }
        bool Microsoft.AspNetCore.Mvc.Filters.IFilterFactory.IsReusable { get { throw null; } }
        public Microsoft.AspNetCore.Authorization.AuthorizationPolicy Policy { get { throw null; } }
        public Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider PolicyProvider { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Authorization.AuthorizationPolicy> GetEffectivePolicyAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
        Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Microsoft.AspNetCore.Mvc.Filters.IFilterFactory.CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Controllers
{
    [System.Diagnostics.DebuggerDisplayAttribute("{DisplayName}")]
    public partial class ControllerActionDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor
    {
        public ControllerActionDescriptor() { }
        public virtual string ActionName { get { throw null; } set { } }
        public string ControllerName { get { throw null; } set { } }
        public System.Reflection.TypeInfo ControllerTypeInfo { get { throw null; } set { } }
        public override string DisplayName { get { throw null; } set { } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } set { } }
    }
    public partial class ControllerActivatorProvider : Microsoft.AspNetCore.Mvc.Controllers.IControllerActivatorProvider
    {
        public ControllerActivatorProvider(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator controllerActivator) { }
        public System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor) { throw null; }
        public System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor) { throw null; }
    }
    internal delegate System.Threading.Tasks.Task ControllerBinderDelegate(Microsoft.AspNetCore.Mvc.ControllerContext controllerContext, object controller, System.Collections.Generic.Dictionary<string, object> arguments);
    internal static partial class ControllerBinderDelegateProvider
    {
        public static Microsoft.AspNetCore.Mvc.Controllers.ControllerBinderDelegate CreateBinderDelegate(Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) { throw null; }
    }
    public partial class ControllerBoundPropertyDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor, Microsoft.AspNetCore.Mvc.Infrastructure.IPropertyInfoParameterDescriptor
    {
        public ControllerBoundPropertyDescriptor() { }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } set { } }
    }
    internal partial class ControllerFactoryProvider : Microsoft.AspNetCore.Mvc.Controllers.IControllerFactoryProvider
    {
        public ControllerFactoryProvider(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivatorProvider activatorProvider, Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory controllerFactory, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator> propertyActivators) { }
        public System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateControllerFactory(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor) { throw null; }
        public System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateControllerReleaser(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor) { throw null; }
    }
    public partial class ControllerFeature
    {
        public ControllerFeature() { }
        public System.Collections.Generic.IList<System.Reflection.TypeInfo> Controllers { get { throw null; } }
    }
    public partial class ControllerFeatureProvider : Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider, Microsoft.AspNetCore.Mvc.ApplicationParts.IApplicationFeatureProvider<Microsoft.AspNetCore.Mvc.Controllers.ControllerFeature>
    {
        public ControllerFeatureProvider() { }
        protected virtual bool IsController(System.Reflection.TypeInfo typeInfo) { throw null; }
        public void PopulateFeature(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPart> parts, Microsoft.AspNetCore.Mvc.Controllers.ControllerFeature feature) { }
    }
    public partial class ControllerParameterDescriptor : Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor, Microsoft.AspNetCore.Mvc.Infrastructure.IParameterInfoParameterDescriptor
    {
        public ControllerParameterDescriptor() { }
        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } set { } }
    }
    internal partial class DefaultControllerActivator : Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator
    {
        public DefaultControllerActivator(Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache typeActivatorCache) { }
        public object Create(Microsoft.AspNetCore.Mvc.ControllerContext controllerContext) { throw null; }
        public void Release(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller) { }
    }
    internal partial class DefaultControllerFactory : Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory
    {
        public DefaultControllerFactory(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator controllerActivator, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator> propertyActivators) { }
        public object CreateController(Microsoft.AspNetCore.Mvc.ControllerContext context) { throw null; }
        public void ReleaseController(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller) { }
    }
    internal partial class DefaultControllerPropertyActivator : Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator
    {
        public DefaultControllerPropertyActivator() { }
        public void Activate(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller) { }
        public System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> GetActivatorDelegate(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor) { throw null; }
    }
    public partial interface IControllerActivator
    {
        object Create(Microsoft.AspNetCore.Mvc.ControllerContext context);
        void Release(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller);
    }
    public partial interface IControllerActivatorProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateActivator(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor);
        System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateReleaser(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor);
    }
    public partial interface IControllerFactory
    {
        object CreateController(Microsoft.AspNetCore.Mvc.ControllerContext context);
        void ReleaseController(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller);
    }
    public partial interface IControllerFactoryProvider
    {
        System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateControllerFactory(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor);
        System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> CreateControllerReleaser(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor descriptor);
    }
    internal partial interface IControllerPropertyActivator
    {
        void Activate(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller);
        System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> GetActivatorDelegate(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor);
    }
    public partial class ServiceBasedControllerActivator : Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator
    {
        public ServiceBasedControllerActivator() { }
        public object Create(Microsoft.AspNetCore.Mvc.ControllerContext actionContext) { throw null; }
        public virtual void Release(Microsoft.AspNetCore.Mvc.ControllerContext context, object controller) { }
    }
}
namespace Microsoft.AspNetCore.Mvc.Core
{
    internal static partial class Resources
    {
        internal static string AcceptHeaderParser_ParseAcceptHeader_InvalidValues { get { throw null; } }
        internal static string ActionDescriptorMustBeBasedOnControllerAction { get { throw null; } }
        internal static string ActionExecutor_UnexpectedTaskInstance { get { throw null; } }
        internal static string ActionExecutor_WrappedTaskInstance { get { throw null; } }
        internal static string ActionInvokerFactory_CouldNotCreateInvoker { get { throw null; } }
        internal static string ActionResult_ActionReturnValueCannotBeNull { get { throw null; } }
        internal static string ApiController_AttributeRouteRequired { get { throw null; } }
        internal static string ApiController_MultipleBodyParametersFound { get { throw null; } }
        internal static string ApiConventionMethod_AmbiguousMethodName { get { throw null; } }
        internal static string ApiConventionMethod_NoMethodFound { get { throw null; } }
        internal static string ApiConventionMustBeStatic { get { throw null; } }
        internal static string ApiConventions_Title_400 { get { throw null; } }
        internal static string ApiConventions_Title_401 { get { throw null; } }
        internal static string ApiConventions_Title_403 { get { throw null; } }
        internal static string ApiConventions_Title_404 { get { throw null; } }
        internal static string ApiConventions_Title_406 { get { throw null; } }
        internal static string ApiConventions_Title_409 { get { throw null; } }
        internal static string ApiConventions_Title_415 { get { throw null; } }
        internal static string ApiConventions_Title_422 { get { throw null; } }
        internal static string ApiConventions_Title_500 { get { throw null; } }
        internal static string ApiConvention_UnsupportedAttributesOnConvention { get { throw null; } }
        internal static string ApiExplorer_UnsupportedAction { get { throw null; } }
        internal static string ApplicationAssembliesProvider_DuplicateRelatedAssembly { get { throw null; } }
        internal static string ApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional { get { throw null; } }
        internal static string ApplicationPartFactory_InvalidFactoryType { get { throw null; } }
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string Argument_InvalidOffsetLength { get { throw null; } }
        internal static string AsyncActionFilter_InvalidShortCircuit { get { throw null; } }
        internal static string AsyncResourceFilter_InvalidShortCircuit { get { throw null; } }
        internal static string AsyncResultFilter_InvalidShortCircuit { get { throw null; } }
        internal static string AttributeRoute_AggregateErrorMessage { get { throw null; } }
        internal static string AttributeRoute_AggregateErrorMessage_ErrorNumber { get { throw null; } }
        internal static string AttributeRoute_CannotContainParameter { get { throw null; } }
        internal static string AttributeRoute_DuplicateNames { get { throw null; } }
        internal static string AttributeRoute_DuplicateNames_Item { get { throw null; } }
        internal static string AttributeRoute_IndividualErrorMessage { get { throw null; } }
        internal static string AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod { get { throw null; } }
        internal static string AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item { get { throw null; } }
        internal static string AttributeRoute_NullTemplateRepresentation { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_EmptyTokenNotAllowed { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_ImbalancedSquareBrackets { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_InvalidSyntax { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_ReplacementValueNotFound { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_UnclosedToken { get { throw null; } }
        internal static string AttributeRoute_TokenReplacement_UnescapedBraceInToken { get { throw null; } }
        internal static string AuthorizeFilter_AuthorizationPolicyCannotBeCreated { get { throw null; } }
        internal static string BinderType_MustBeIModelBinder { get { throw null; } }
        internal static string BindingSource_CannotBeComposite { get { throw null; } }
        internal static string BindingSource_CannotBeGreedy { get { throw null; } }
        internal static string CacheProfileNotFound { get { throw null; } }
        internal static string CandidateResolver_DifferentCasedReference { get { throw null; } }
        internal static string Common_PropertyNotFound { get { throw null; } }
        internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForParameter { get { throw null; } }
        internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForProperty { get { throw null; } }
        internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForType { get { throw null; } }
        internal static string CouldNotCreateIModelBinder { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string DefaultActionSelector_AmbiguousActions { get { throw null; } }
        internal static string FailedToReadRequestForm { get { throw null; } }
        internal static string FileResult_InvalidPath { get { throw null; } }
        internal static string FileResult_PathNotRooted { get { throw null; } }
        internal static string FilterFactoryAttribute_TypeMustImplementIFilter { get { throw null; } }
        internal static string FormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat { get { throw null; } }
        internal static string FormatterMappings_NotValidMediaType { get { throw null; } }
        internal static string Formatter_NoMediaTypes { get { throw null; } }
        internal static string Format_NotValid { get { throw null; } }
        internal static string FormCollectionModelBinder_CannotBindToFormCollection { get { throw null; } }
        internal static string HtmlGeneration_NonPropertyValueMustBeNumber { get { throw null; } }
        internal static string HtmlGeneration_ValueIsInvalid { get { throw null; } }
        internal static string HtmlGeneration_ValueMustBeNumber { get { throw null; } }
        internal static string InputFormatterNoEncoding { get { throw null; } }
        internal static string InputFormattersAreRequired { get { throw null; } }
        internal static string InvalidTypeTForActionResultOfT { get { throw null; } }
        internal static string Invalid_IncludePropertyExpression { get { throw null; } }
        internal static string JQueryFormValueProviderFactory_MissingClosingBracket { get { throw null; } }
        internal static string KeyValuePair_BothKeyAndValueMustBePresent { get { throw null; } }
        internal static string MatchAllContentTypeIsNotAllowed { get { throw null; } }
        internal static string MiddewareFilter_ConfigureMethodOverload { get { throw null; } }
        internal static string MiddewareFilter_NoConfigureMethod { get { throw null; } }
        internal static string MiddlewareFilterBuilder_NoMiddlewareFeature { get { throw null; } }
        internal static string MiddlewareFilterBuilder_NullApplicationBuilder { get { throw null; } }
        internal static string MiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType { get { throw null; } }
        internal static string MiddlewareFilter_InvalidConfigureReturnType { get { throw null; } }
        internal static string MiddlewareFilter_ServiceResolutionFail { get { throw null; } }
        internal static string ModelBinderProvidersAreRequired { get { throw null; } }
        internal static string ModelBinderUtil_ModelCannotBeNull { get { throw null; } }
        internal static string ModelBinderUtil_ModelInstanceIsWrong { get { throw null; } }
        internal static string ModelBinderUtil_ModelMetadataCannotBeNull { get { throw null; } }
        internal static string ModelBinding_ExceededMaxModelBindingCollectionSize { get { throw null; } }
        internal static string ModelBinding_ExceededMaxModelBindingRecursionDepth { get { throw null; } }
        internal static string ModelBinding_MissingBindRequiredMember { get { throw null; } }
        internal static string ModelBinding_MissingRequestBodyRequiredMember { get { throw null; } }
        internal static string ModelBinding_NullValueNotValid { get { throw null; } }
        internal static string ModelState_AttemptedValueIsInvalid { get { throw null; } }
        internal static string ModelState_NonPropertyAttemptedValueIsInvalid { get { throw null; } }
        internal static string ModelState_NonPropertyUnknownValueIsInvalid { get { throw null; } }
        internal static string ModelState_UnknownValueIsInvalid { get { throw null; } }
        internal static string ModelType_WrongType { get { throw null; } }
        internal static string NoRoutesMatched { get { throw null; } }
        internal static string NoRoutesMatchedForPage { get { throw null; } }
        internal static string ObjectResultExecutor_MaxEnumerationExceeded { get { throw null; } }
        internal static string ObjectResult_MatchAllContentType { get { throw null; } }
        internal static string OutputFormatterNoMediaType { get { throw null; } }
        internal static string OutputFormattersAreRequired { get { throw null; } }
        internal static string PropertyOfTypeCannotBeNull { get { throw null; } }
        internal static string Property_MustBeInstanceOfType { get { throw null; } }
        internal static string ReferenceToNewtonsoftJsonRequired { get { throw null; } }
        internal static string RelatedAssemblyAttribute_AssemblyCannotReferenceSelf { get { throw null; } }
        internal static string RelatedAssemblyAttribute_CouldNotBeFound { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string ResponseCache_SpecifyDuration { get { throw null; } }
        internal static string SerializableError_DefaultError { get { throw null; } }
        internal static string TextInputFormatter_SupportedEncodingsMustNotBeEmpty { get { throw null; } }
        internal static string TextOutputFormatter_SupportedEncodingsMustNotBeEmpty { get { throw null; } }
        internal static string TextOutputFormatter_WriteResponseBodyAsyncNotSupported { get { throw null; } }
        internal static string TypeMethodMustReturnNotNullValue { get { throw null; } }
        internal static string TypeMustDeriveFromType { get { throw null; } }
        internal static string UnableToFindServices { get { throw null; } }
        internal static string UnexpectedJsonEnd { get { throw null; } }
        internal static string UnsupportedContentType { get { throw null; } }
        internal static string UrlHelper_RelativePagePathIsNotSupported { get { throw null; } }
        internal static string UrlNotLocal { get { throw null; } }
        internal static string ValidationProblemDescription_Title { get { throw null; } }
        internal static string ValidationVisitor_ExceededMaxDepth { get { throw null; } }
        internal static string ValidationVisitor_ExceededMaxDepthFix { get { throw null; } }
        internal static string ValidationVisitor_ExceededMaxPropertyDepth { get { throw null; } }
        internal static string ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated { get { throw null; } }
        internal static string ValueProviderResult_NoConverterExists { get { throw null; } }
        internal static string VaryByQueryKeys_Requires_ResponseCachingMiddleware { get { throw null; } }
        internal static string VirtualFileResultExecutor_NoFileProviderConfigured { get { throw null; } }
        internal static string FormatAcceptHeaderParser_ParseAcceptHeader_InvalidValues(object p0) { throw null; }
        internal static string FormatActionDescriptorMustBeBasedOnControllerAction(object p0) { throw null; }
        internal static string FormatActionExecutor_UnexpectedTaskInstance(object p0, object p1) { throw null; }
        internal static string FormatActionExecutor_WrappedTaskInstance(object p0, object p1, object p2) { throw null; }
        internal static string FormatActionInvokerFactory_CouldNotCreateInvoker(object p0) { throw null; }
        internal static string FormatActionResult_ActionReturnValueCannotBeNull(object p0) { throw null; }
        internal static string FormatApiController_AttributeRouteRequired(object p0, object p1) { throw null; }
        internal static string FormatApiController_MultipleBodyParametersFound(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatApiConventionMethod_AmbiguousMethodName(object p0, object p1) { throw null; }
        internal static string FormatApiConventionMethod_NoMethodFound(object p0, object p1) { throw null; }
        internal static string FormatApiConventionMustBeStatic(object p0) { throw null; }
        internal static string FormatApiConvention_UnsupportedAttributesOnConvention(object p0, object p1, object p2) { throw null; }
        internal static string FormatApiExplorer_UnsupportedAction(object p0) { throw null; }
        internal static string FormatApplicationAssembliesProvider_DuplicateRelatedAssembly(object p0) { throw null; }
        internal static string FormatApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional(object p0, object p1) { throw null; }
        internal static string FormatApplicationPartFactory_InvalidFactoryType(object p0, object p1, object p2) { throw null; }
        internal static string FormatArgument_InvalidOffsetLength(object p0, object p1) { throw null; }
        internal static string FormatAsyncActionFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatAsyncResourceFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatAsyncResultFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatAttributeRoute_AggregateErrorMessage(object p0, object p1) { throw null; }
        internal static string FormatAttributeRoute_AggregateErrorMessage_ErrorNumber(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_CannotContainParameter(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_DuplicateNames(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_DuplicateNames_Item(object p0, object p1) { throw null; }
        internal static string FormatAttributeRoute_IndividualErrorMessage(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item(object p0, object p1, object p2) { throw null; }
        internal static string FormatAttributeRoute_TokenReplacement_InvalidSyntax(object p0, object p1) { throw null; }
        internal static string FormatAttributeRoute_TokenReplacement_ReplacementValueNotFound(object p0, object p1, object p2) { throw null; }
        internal static string FormatAuthorizeFilter_AuthorizationPolicyCannotBeCreated(object p0, object p1) { throw null; }
        internal static string FormatBinderType_MustBeIModelBinder(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_CannotBeComposite(object p0, object p1) { throw null; }
        internal static string FormatBindingSource_CannotBeGreedy(object p0, object p1) { throw null; }
        internal static string FormatCacheProfileNotFound(object p0) { throw null; }
        internal static string FormatCandidateResolver_DifferentCasedReference(object p0) { throw null; }
        internal static string FormatCommon_PropertyNotFound(object p0, object p1) { throw null; }
        internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForParameter(object p0, object p1) { throw null; }
        internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForProperty(object p0, object p1, object p2) { throw null; }
        internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForType(object p0) { throw null; }
        internal static string FormatCouldNotCreateIModelBinder(object p0) { throw null; }
        internal static string FormatDefaultActionSelector_AmbiguousActions(object p0, object p1) { throw null; }
        internal static string FormatFailedToReadRequestForm(object p0) { throw null; }
        internal static string FormatFileResult_InvalidPath(object p0) { throw null; }
        internal static string FormatFileResult_PathNotRooted(object p0) { throw null; }
        internal static string FormatFilterFactoryAttribute_TypeMustImplementIFilter(object p0, object p1) { throw null; }
        internal static string FormatFormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat(object p0) { throw null; }
        internal static string FormatFormatterMappings_NotValidMediaType(object p0) { throw null; }
        internal static string FormatFormatter_NoMediaTypes(object p0, object p1) { throw null; }
        internal static string FormatFormat_NotValid(object p0) { throw null; }
        internal static string FormatFormCollectionModelBinder_CannotBindToFormCollection(object p0, object p1, object p2) { throw null; }
        internal static string FormatHtmlGeneration_ValueIsInvalid(object p0) { throw null; }
        internal static string FormatHtmlGeneration_ValueMustBeNumber(object p0) { throw null; }
        internal static string FormatInputFormatterNoEncoding(object p0) { throw null; }
        internal static string FormatInputFormattersAreRequired(object p0, object p1, object p2) { throw null; }
        internal static string FormatInvalidTypeTForActionResultOfT(object p0, object p1) { throw null; }
        internal static string FormatInvalid_IncludePropertyExpression(object p0) { throw null; }
        internal static string FormatJQueryFormValueProviderFactory_MissingClosingBracket(object p0) { throw null; }
        internal static string FormatMatchAllContentTypeIsNotAllowed(object p0) { throw null; }
        internal static string FormatMiddewareFilter_ConfigureMethodOverload(object p0) { throw null; }
        internal static string FormatMiddewareFilter_NoConfigureMethod(object p0, object p1) { throw null; }
        internal static string FormatMiddlewareFilterBuilder_NoMiddlewareFeature(object p0) { throw null; }
        internal static string FormatMiddlewareFilterBuilder_NullApplicationBuilder(object p0) { throw null; }
        internal static string FormatMiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType(object p0, object p1) { throw null; }
        internal static string FormatMiddlewareFilter_InvalidConfigureReturnType(object p0, object p1, object p2) { throw null; }
        internal static string FormatMiddlewareFilter_ServiceResolutionFail(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatModelBinderProvidersAreRequired(object p0, object p1, object p2) { throw null; }
        internal static string FormatModelBinderUtil_ModelCannotBeNull(object p0) { throw null; }
        internal static string FormatModelBinderUtil_ModelInstanceIsWrong(object p0, object p1) { throw null; }
        internal static string FormatModelBinding_ExceededMaxModelBindingCollectionSize(object p0, object p1, object p2, object p3, object p4) { throw null; }
        internal static string FormatModelBinding_ExceededMaxModelBindingRecursionDepth(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatModelBinding_MissingBindRequiredMember(object p0) { throw null; }
        internal static string FormatModelBinding_NullValueNotValid(object p0) { throw null; }
        internal static string FormatModelState_AttemptedValueIsInvalid(object p0, object p1) { throw null; }
        internal static string FormatModelState_NonPropertyAttemptedValueIsInvalid(object p0) { throw null; }
        internal static string FormatModelState_UnknownValueIsInvalid(object p0) { throw null; }
        internal static string FormatModelType_WrongType(object p0, object p1) { throw null; }
        internal static string FormatNoRoutesMatchedForPage(object p0) { throw null; }
        internal static string FormatObjectResultExecutor_MaxEnumerationExceeded(object p0, object p1) { throw null; }
        internal static string FormatObjectResult_MatchAllContentType(object p0, object p1) { throw null; }
        internal static string FormatOutputFormatterNoMediaType(object p0) { throw null; }
        internal static string FormatOutputFormattersAreRequired(object p0, object p1, object p2) { throw null; }
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) { throw null; }
        internal static string FormatProperty_MustBeInstanceOfType(object p0, object p1, object p2) { throw null; }
        internal static string FormatReferenceToNewtonsoftJsonRequired(object p0, object p1, object p2, object p3, object p4) { throw null; }
        internal static string FormatRelatedAssemblyAttribute_AssemblyCannotReferenceSelf(object p0, object p1) { throw null; }
        internal static string FormatRelatedAssemblyAttribute_CouldNotBeFound(object p0, object p1, object p2) { throw null; }
        internal static string FormatResponseCache_SpecifyDuration(object p0, object p1) { throw null; }
        internal static string FormatTextInputFormatter_SupportedEncodingsMustNotBeEmpty(object p0) { throw null; }
        internal static string FormatTextOutputFormatter_SupportedEncodingsMustNotBeEmpty(object p0) { throw null; }
        internal static string FormatTextOutputFormatter_WriteResponseBodyAsyncNotSupported(object p0, object p1, object p2) { throw null; }
        internal static string FormatTypeMethodMustReturnNotNullValue(object p0, object p1) { throw null; }
        internal static string FormatTypeMustDeriveFromType(object p0, object p1) { throw null; }
        internal static string FormatUnableToFindServices(object p0, object p1, object p2) { throw null; }
        internal static string FormatUnsupportedContentType(object p0) { throw null; }
        internal static string FormatUrlHelper_RelativePagePathIsNotSupported(object p0, object p1, object p2) { throw null; }
        internal static string FormatValidationVisitor_ExceededMaxDepth(object p0, object p1, object p2) { throw null; }
        internal static string FormatValidationVisitor_ExceededMaxDepthFix(object p0, object p1) { throw null; }
        internal static string FormatValidationVisitor_ExceededMaxPropertyDepth(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated(object p0, object p1) { throw null; }
        internal static string FormatValueProviderResult_NoConverterExists(object p0, object p1) { throw null; }
        internal static string FormatVaryByQueryKeys_Requires_ResponseCachingMiddleware(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Core.Infrastructure
{
    public partial interface IAntiforgeryValidationFailedResult : Microsoft.AspNetCore.Mvc.IActionResult
    {
    }
}
namespace Microsoft.AspNetCore.Mvc.Diagnostics
{
    public sealed partial class AfterActionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterAction";
        public AfterActionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
    }
    public sealed partial class AfterActionFilterOnActionExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnActionExecuted";
        public AfterActionFilterOnActionExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext ActionExecutedContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterActionFilterOnActionExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnActionExecuting";
        public AfterActionFilterOnActionExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext ActionExecutingContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterActionFilterOnActionExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnActionExecution";
        public AfterActionFilterOnActionExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext ActionExecutedContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterActionResultEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterActionResult";
        public AfterActionResultEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } }
    }
    public sealed partial class AfterAuthorizationFilterOnAuthorizationEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnAuthorization";
        public AfterAuthorizationFilterOnAuthorizationEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext AuthorizationContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterControllerActionMethodEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterControllerActionMethod";
        public AfterControllerActionMethodEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> arguments, object controller, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Arguments { get { throw null; } }
        public object Controller { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } }
    }
    public sealed partial class AfterExceptionFilterOnExceptionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnException";
        public AfterExceptionFilterOnExceptionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ExceptionContext ExceptionContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class AfterResourceFilterOnResourceExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResourceExecuted";
        public AfterResourceFilterOnResourceExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext ResourceExecutedContext { get { throw null; } }
    }
    public sealed partial class AfterResourceFilterOnResourceExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResourceExecuting";
        public AfterResourceFilterOnResourceExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext ResourceExecutingContext { get { throw null; } }
    }
    public sealed partial class AfterResourceFilterOnResourceExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResourceExecution";
        public AfterResourceFilterOnResourceExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext ResourceExecutedContext { get { throw null; } }
    }
    public sealed partial class AfterResultFilterOnResultExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResultExecuted";
        public AfterResultFilterOnResultExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext ResultExecutedContext { get { throw null; } }
    }
    public sealed partial class AfterResultFilterOnResultExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResultExecuting";
        public AfterResultFilterOnResultExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext ResultExecutingContext { get { throw null; } }
    }
    public sealed partial class AfterResultFilterOnResultExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.AfterOnResultExecution";
        public AfterResultFilterOnResultExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext ResultExecutedContext { get { throw null; } }
    }
    public sealed partial class BeforeActionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeAction";
        public BeforeActionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteData routeData) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteData RouteData { get { throw null; } }
    }
    public sealed partial class BeforeActionFilterOnActionExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnActionExecuted";
        public BeforeActionFilterOnActionExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext actionExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext ActionExecutedContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeActionFilterOnActionExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnActionExecuting";
        public BeforeActionFilterOnActionExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext ActionExecutingContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeActionFilterOnActionExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnActionExecution";
        public BeforeActionFilterOnActionExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext actionExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext ActionExecutingContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeActionResultEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeActionResult";
        public BeforeActionResultEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.IActionResult result) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.IActionResult Result { get { throw null; } }
    }
    public sealed partial class BeforeAuthorizationFilterOnAuthorizationEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnAuthorization";
        public BeforeAuthorizationFilterOnAuthorizationEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext authorizationContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext AuthorizationContext { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeControllerActionMethodEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeControllerActionMethod";
        public BeforeControllerActionMethodEventData(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IReadOnlyDictionary<string, object> actionArguments, object controller) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> ActionArguments { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        public object Controller { get { throw null; } }
        protected sealed override int Count { get { throw null; } }
        protected sealed override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeExceptionFilterOnException : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnException";
        public BeforeExceptionFilterOnException(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ExceptionContext exceptionContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ExceptionContext ExceptionContext { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
    }
    public sealed partial class BeforeResourceFilterOnResourceExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResourceExecuted";
        public BeforeResourceFilterOnResourceExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext resourceExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext ResourceExecutedContext { get { throw null; } }
    }
    public sealed partial class BeforeResourceFilterOnResourceExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResourceExecuting";
        public BeforeResourceFilterOnResourceExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext ResourceExecutingContext { get { throw null; } }
    }
    public sealed partial class BeforeResourceFilterOnResourceExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResourceExecution";
        public BeforeResourceFilterOnResourceExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext resourceExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext ResourceExecutingContext { get { throw null; } }
    }
    public sealed partial class BeforeResultFilterOnResultExecutedEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResultExecuted";
        public BeforeResultFilterOnResultExecutedEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext resultExecutedContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext ResultExecutedContext { get { throw null; } }
    }
    public sealed partial class BeforeResultFilterOnResultExecutingEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResultExecuting";
        public BeforeResultFilterOnResultExecutingEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext ResultExecutingContext { get { throw null; } }
    }
    public sealed partial class BeforeResultFilterOnResultExecutionEventData : Microsoft.AspNetCore.Mvc.Diagnostics.EventData
    {
        public const string EventName = "Microsoft.AspNetCore.Mvc.BeforeOnResultExecution";
        public BeforeResultFilterOnResultExecutionEventData(Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor actionDescriptor, Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext resultExecutingContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filter) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor ActionDescriptor { get { throw null; } }
        protected override int Count { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Filter { get { throw null; } }
        protected override System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext ResultExecutingContext { get { throw null; } }
    }
    public abstract partial class EventData : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        protected const string EventNamespace = "Microsoft.AspNetCore.Mvc.";
        protected EventData() { }
        protected abstract int Count { get; }
        protected abstract System.Collections.Generic.KeyValuePair<string, object> this[int index] { get; }
        int System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get { throw null; } }
        System.Collections.Generic.KeyValuePair<string, object> System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.this[int index] { get { throw null; } }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(Microsoft.AspNetCore.Mvc.Diagnostics.EventData eventData) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, object> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
}
namespace Microsoft.AspNetCore.Mvc.Filters
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public abstract partial class ActionFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter, Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
        protected ActionFilterAttribute() { }
        public int Order { get { throw null; } set { } }
        public virtual void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public virtual void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate next) { throw null; }
        public virtual void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public virtual void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResultExecutionDelegate next) { throw null; }
    }
    internal partial class ControllerActionFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ControllerActionFilter() { }
        public int Order { get { throw null; } set { } }
        public System.Threading.Tasks.Task OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate next) { throw null; }
    }
    internal partial class ControllerResultFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ControllerResultFilter() { }
        public int Order { get { throw null; } set { } }
        public System.Threading.Tasks.Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResultExecutionDelegate next) { throw null; }
    }
    internal partial class DefaultFilterProvider : Microsoft.AspNetCore.Mvc.Filters.IFilterProvider
    {
        public DefaultFilterProvider() { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Filters.FilterProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Filters.FilterProviderContext context) { }
        public void ProvideFilter(Microsoft.AspNetCore.Mvc.Filters.FilterProviderContext context, Microsoft.AspNetCore.Mvc.Filters.FilterItem filterItem) { }
    }
    internal partial class DisableRequestSizeLimitFilter : Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.IRequestSizePolicy
    {
        public DisableRequestSizeLimitFilter(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public void OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public abstract partial class ExceptionFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IAsyncExceptionFilter, Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        protected ExceptionFilterAttribute() { }
        public int Order { get { throw null; } set { } }
        public virtual void OnException(Microsoft.AspNetCore.Mvc.Filters.ExceptionContext context) { }
        public virtual System.Threading.Tasks.Task OnExceptionAsync(Microsoft.AspNetCore.Mvc.Filters.ExceptionContext context) { throw null; }
    }
    public partial class FilterCollection : System.Collections.ObjectModel.Collection<Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata>
    {
        public FilterCollection() { }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Add(System.Type filterType) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Add(System.Type filterType, int order) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata AddService(System.Type filterType) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata AddService(System.Type filterType, int order) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata AddService<TFilterType>() where TFilterType : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata AddService<TFilterType>(int order) where TFilterType : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Add<TFilterType>() where TFilterType : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata Add<TFilterType>(int order) where TFilterType : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct FilterCursor
    {
        private object _dummy;
        private int _dummyPrimitive;
        public FilterCursor(Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filters) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.FilterCursorItem<TFilter, TFilterAsync> GetNextFilter<TFilter, TFilterAsync>() where TFilter : class where TFilterAsync : class { throw null; }
        public void Reset() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct FilterCursorItem<TFilter, TFilterAsync>
    {
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly TFilter _Filter_k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly TFilterAsync _FilterAsync_k__BackingField;
        public FilterCursorItem(TFilter filter, TFilterAsync filterAsync) { throw null; }
        public TFilter Filter { get { throw null; } }
        public TFilterAsync FilterAsync { get { throw null; } }
    }
    internal partial class FilterDescriptorOrderComparer : System.Collections.Generic.IComparer<Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor>
    {
        public FilterDescriptorOrderComparer() { }
        public static Microsoft.AspNetCore.Mvc.Filters.FilterDescriptorOrderComparer Comparer { get { throw null; } }
        public int Compare(Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor x, Microsoft.AspNetCore.Mvc.Filters.FilterDescriptor y) { throw null; }
    }
    internal static partial class FilterFactory
    {
        public static Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] CreateUncachedFilters(Microsoft.AspNetCore.Mvc.Filters.IFilterProvider[] filterProviders, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.Filters.FilterItem[] cachedFilterItems) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Filters.FilterFactoryResult GetAllFilters(Microsoft.AspNetCore.Mvc.Filters.IFilterProvider[] filterProviders, Microsoft.AspNetCore.Mvc.ActionContext actionContext) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct FilterFactoryResult
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FilterFactoryResult(Microsoft.AspNetCore.Mvc.Filters.FilterItem[] cacheableFilters, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filters) { throw null; }
        public Microsoft.AspNetCore.Mvc.Filters.FilterItem[] CacheableFilters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] Filters { get { throw null; } }
    }
    public static partial class FilterScope
    {
        public static readonly int Action;
        public static readonly int Controller;
        public static readonly int First;
        public static readonly int Global;
        public static readonly int Last;
    }
    internal partial interface IMiddlewareFilterFeature
    {
        Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext ResourceExecutingContext { get; }
        Microsoft.AspNetCore.Mvc.Filters.ResourceExecutionDelegate ResourceExecutionDelegate { get; }
    }
    internal partial interface IResponseCacheFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    internal partial class MiddlewareFilter : Microsoft.AspNetCore.Mvc.Filters.IAsyncResourceFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        public MiddlewareFilter(Microsoft.AspNetCore.Http.RequestDelegate middlewarePipeline) { }
        public System.Threading.Tasks.Task OnResourceExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResourceExecutionDelegate next) { throw null; }
    }
    internal partial class MiddlewareFilterBuilder
    {
        public MiddlewareFilterBuilder(Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterConfigurationProvider configurationProvider) { }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder ApplicationBuilder { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.RequestDelegate GetPipeline(System.Type configurationType) { throw null; }
    }
    internal partial class MiddlewareFilterBuilderStartupFilter : Microsoft.AspNetCore.Hosting.IStartupFilter
    {
        public MiddlewareFilterBuilderStartupFilter() { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> Configure(System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> next) { throw null; }
    }
    internal partial class MiddlewareFilterConfigurationProvider
    {
        public MiddlewareFilterConfigurationProvider() { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> CreateConfigureDelegate(System.Type configurationType) { throw null; }
    }
    internal partial class MiddlewareFilterFeature : Microsoft.AspNetCore.Mvc.Filters.IMiddlewareFilterFeature
    {
        public MiddlewareFilterFeature() { }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext ResourceExecutingContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.Filters.ResourceExecutionDelegate ResourceExecutionDelegate { get { throw null; } set { } }
    }
    internal partial class RequestFormLimitsFilter : Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.IRequestFormLimitsPolicy
    {
        public RequestFormLimitsFilter(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Http.Features.FormOptions FormOptions { get { throw null; } set { } }
        public void OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { }
    }
    internal partial class RequestSizeLimitFilter : Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.IRequestSizePolicy
    {
        public RequestSizeLimitFilter(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public long Bytes { get { throw null; } set { } }
        public void OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context) { }
    }
    internal partial class ResponseCacheFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResponseCacheFilter
    {
        public ResponseCacheFilter(Microsoft.AspNetCore.Mvc.CacheProfile cacheProfile, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public int Duration { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ResponseCacheLocation Location { get { throw null; } set { } }
        public bool NoStore { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
    }
    internal partial class ResponseCacheFilterExecutor
    {
        public ResponseCacheFilterExecutor(Microsoft.AspNetCore.Mvc.CacheProfile cacheProfile) { }
        public int Duration { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ResponseCacheLocation Location { get { throw null; } set { } }
        public bool NoStore { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
        public void Execute(Microsoft.AspNetCore.Mvc.Filters.FilterContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public abstract partial class ResultFilterAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IAsyncResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
        protected ResultFilterAttribute() { }
        public int Order { get { throw null; } set { } }
        public virtual void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public virtual void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, Microsoft.AspNetCore.Mvc.Filters.ResultExecutionDelegate next) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Formatters
{
    internal static partial class AcceptHeaderParser
    {
        public static System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality> ParseAcceptHeader(System.Collections.Generic.IList<string> acceptHeaders) { throw null; }
        public static void ParseAcceptHeader(System.Collections.Generic.IList<string> acceptHeaders, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality> parsedValues) { }
    }
    public partial class FormatFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter, Microsoft.AspNetCore.Mvc.Formatters.IFormatFilter
    {
        public FormatFilter(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public virtual string GetFormat(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
        public void OnResourceExecuted(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutedContext context) { }
        public void OnResourceExecuting(Microsoft.AspNetCore.Mvc.Filters.ResourceExecutingContext context) { }
        public void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
    }
    public partial class FormatterMappings
    {
        public FormatterMappings() { }
        public bool ClearMediaTypeMappingForFormat(string format) { throw null; }
        public string GetMediaTypeMappingForFormat(string format) { throw null; }
        public void SetMediaTypeMappingForFormat(string format, Microsoft.Net.Http.Headers.MediaTypeHeaderValue contentType) { }
        public void SetMediaTypeMappingForFormat(string format, string contentType) { }
    }
    public partial class HttpNoContentOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter
    {
        public HttpNoContentOutputFormatter() { }
        public bool TreatNullValueAsNoContent { get { throw null; } set { } }
        public bool CanWriteResult(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context) { throw null; }
        public System.Threading.Tasks.Task WriteAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
    }
    internal enum HttpParseResult
    {
        Parsed = 0,
        NotParsed = 1,
        InvalidFormat = 2,
    }
    internal static partial class HttpTokenParsingRules
    {
        internal const char CR = '\r';
        internal static readonly System.Text.Encoding DefaultHttpEncoding;
        internal const char LF = '\n';
        internal const int MaxInt32Digits = 10;
        internal const int MaxInt64Digits = 19;
        internal const char SP = ' ';
        internal const char Tab = '\t';
        internal static Microsoft.AspNetCore.Mvc.Formatters.HttpParseResult GetQuotedPairLength(string input, int startIndex, out int length) { throw null; }
        internal static Microsoft.AspNetCore.Mvc.Formatters.HttpParseResult GetQuotedStringLength(string input, int startIndex, out int length) { throw null; }
        internal static int GetTokenLength(string input, int startIndex) { throw null; }
        internal static int GetWhitespaceLength(string input, int startIndex) { throw null; }
        internal static bool IsTokenChar(char character) { throw null; }
    }
    internal partial interface IFormatFilter : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
        string GetFormat(Microsoft.AspNetCore.Mvc.ActionContext context);
    }
    public abstract partial class InputFormatter : Microsoft.AspNetCore.Mvc.ApiExplorer.IApiRequestFormatMetadataProvider, Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter
    {
        protected InputFormatter() { }
        public Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection SupportedMediaTypes { get { throw null; } }
        public virtual bool CanRead(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context) { throw null; }
        protected virtual bool CanReadType(System.Type type) { throw null; }
        protected virtual object GetDefaultValueForType(System.Type modelType) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<string> GetSupportedContentTypes(string contentType, System.Type objectType) { throw null; }
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context) { throw null; }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadRequestBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaType
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaType(Microsoft.Extensions.Primitives.StringSegment mediaType) { throw null; }
        public MediaType(string mediaType) { throw null; }
        public MediaType(string mediaType, int offset, int? length) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment Charset { get { throw null; } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public bool HasWildcard { get { throw null; } }
        public bool MatchesAllSubTypes { get { throw null; } }
        public bool MatchesAllSubTypesWithoutSuffix { get { throw null; } }
        public bool MatchesAllTypes { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment SubType { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment SubTypeSuffix { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment SubTypeWithoutSuffix { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Type { get { throw null; } }
        public static Microsoft.AspNetCore.Mvc.Formatters.MediaTypeSegmentWithQuality CreateMediaTypeSegmentWithQuality(string mediaType, int start) { throw null; }
        public static System.Text.Encoding GetEncoding(Microsoft.Extensions.Primitives.StringSegment mediaType) { throw null; }
        public static System.Text.Encoding GetEncoding(string mediaType) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment GetParameter(Microsoft.Extensions.Primitives.StringSegment parameterName) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment GetParameter(string parameterName) { throw null; }
        public bool IsSubsetOf(Microsoft.AspNetCore.Mvc.Formatters.MediaType @set) { throw null; }
        public static string ReplaceEncoding(Microsoft.Extensions.Primitives.StringSegment mediaType, System.Text.Encoding encoding) { throw null; }
        public static string ReplaceEncoding(string mediaType, System.Text.Encoding encoding) { throw null; }
    }
    public partial class MediaTypeCollection : System.Collections.ObjectModel.Collection<string>
    {
        public MediaTypeCollection() { }
        public void Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue item) { }
        public void Insert(int index, Microsoft.Net.Http.Headers.MediaTypeHeaderValue item) { }
        public bool Remove(Microsoft.Net.Http.Headers.MediaTypeHeaderValue item) { throw null; }
    }
    internal static partial class MediaTypeHeaderValues
    {
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue ApplicationAnyJsonSyntax;
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue ApplicationAnyXmlSyntax;
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue ApplicationJson;
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue ApplicationXml;
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue TextJson;
        public static readonly Microsoft.Net.Http.Headers.MediaTypeHeaderValue TextXml;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaTypeSegmentWithQuality
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaTypeSegmentWithQuality(Microsoft.Extensions.Primitives.StringSegment mediaType, double quality) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment MediaType { get { throw null; } }
        public double Quality { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class OutputFormatter : Microsoft.AspNetCore.Mvc.ApiExplorer.IApiResponseTypeMetadataProvider, Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter
    {
        protected OutputFormatter() { }
        public Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection SupportedMediaTypes { get { throw null; } }
        public virtual bool CanWriteResult(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context) { throw null; }
        protected virtual bool CanWriteType(System.Type type) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<string> GetSupportedContentTypes(string contentType, System.Type objectType) { throw null; }
        public virtual System.Threading.Tasks.Task WriteAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
        public abstract System.Threading.Tasks.Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context);
        public virtual void WriteResponseHeaders(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { }
    }
    internal static partial class ResponseContentTypeHelper
    {
        public static void ResolveContentTypeAndEncoding(string actionResultContentType, string httpResponseContentType, string defaultContentType, out string resolvedContentType, out System.Text.Encoding resolvedContentTypeEncoding) { throw null; }
    }
    public partial class StreamOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter
    {
        public StreamOutputFormatter() { }
        public bool CanWriteResult(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task WriteAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
    }
    public partial class StringOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.TextOutputFormatter
    {
        public StringOutputFormatter() { }
        public override bool CanWriteResult(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context) { throw null; }
        public override System.Threading.Tasks.Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context, System.Text.Encoding encoding) { throw null; }
    }
    public partial class SystemTextJsonInputFormatter : Microsoft.AspNetCore.Mvc.Formatters.TextInputFormatter, Microsoft.AspNetCore.Mvc.Formatters.IInputFormatterExceptionPolicy
    {
        public SystemTextJsonInputFormatter(Microsoft.AspNetCore.Mvc.JsonOptions options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter> logger) { }
        Microsoft.AspNetCore.Mvc.Formatters.InputFormatterExceptionPolicy Microsoft.AspNetCore.Mvc.Formatters.IInputFormatterExceptionPolicy.ExceptionPolicy { get { throw null; } }
        public System.Text.Json.JsonSerializerOptions SerializerOptions { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public sealed override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadRequestBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context, System.Text.Encoding encoding) { throw null; }
    }
    public partial class SystemTextJsonOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.TextOutputFormatter
    {
        public SystemTextJsonOutputFormatter(System.Text.Json.JsonSerializerOptions jsonSerializerOptions) { }
        public System.Text.Json.JsonSerializerOptions SerializerOptions { get { throw null; } }
        internal static Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter CreateFormatter(Microsoft.AspNetCore.Mvc.JsonOptions jsonOptions) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public sealed override System.Threading.Tasks.Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context, System.Text.Encoding selectedEncoding) { throw null; }
    }
    public abstract partial class TextInputFormatter : Microsoft.AspNetCore.Mvc.Formatters.InputFormatter
    {
        protected static readonly System.Text.Encoding UTF16EncodingLittleEndian;
        protected static readonly System.Text.Encoding UTF8EncodingWithoutBOM;
        protected TextInputFormatter() { }
        public System.Collections.Generic.IList<System.Text.Encoding> SupportedEncodings { get { throw null; } }
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadRequestBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context) { throw null; }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.Formatters.InputFormatterResult> ReadRequestBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context, System.Text.Encoding encoding);
        protected System.Text.Encoding SelectCharacterEncoding(Microsoft.AspNetCore.Mvc.Formatters.InputFormatterContext context) { throw null; }
    }
    public abstract partial class TextOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.OutputFormatter
    {
        protected TextOutputFormatter() { }
        public System.Collections.Generic.IList<System.Text.Encoding> SupportedEncodings { get { throw null; } }
        internal static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue> GetAcceptCharsetHeaderValues(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
        public virtual System.Text.Encoding SelectCharacterEncoding(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
        public sealed override System.Threading.Tasks.Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context) { throw null; }
        public abstract System.Threading.Tasks.Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context, System.Text.Encoding selectedEncoding);
    }
}
namespace Microsoft.AspNetCore.Mvc.Formatters.Json
{
    internal sealed partial class TranscodingReadStream : System.IO.Stream
    {
        internal const int MaxByteBufferSize = 4096;
        internal const int MaxCharBufferSize = 12288;
        public TranscodingReadStream(System.IO.Stream input, System.Text.Encoding sourceEncoding) { }
        internal int ByteBufferCount { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        internal int CharBufferCount { get { throw null; } }
        public override long Length { get { throw null; } }
        internal int OverflowCount { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    internal sealed partial class TranscodingWriteStream : System.IO.Stream
    {
        internal const int MaxByteBufferSize = 16384;
        internal const int MaxCharBufferSize = 4096;
        public TranscodingWriteStream(System.IO.Stream stream, System.Text.Encoding targetEncoding) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task FinalWriteAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Flush() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Infrastructure
{
    public partial class ActionContextAccessor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor
    {
        internal static readonly Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor Null;
        public ActionContextAccessor() { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } set { } }
    }
    public partial class ActionDescriptorCollection
    {
        public ActionDescriptorCollection(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> items, int version) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> Items { get { throw null; } }
        public int Version { get { throw null; } }
    }
    public abstract partial class ActionDescriptorCollectionProvider : Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider
    {
        protected ActionDescriptorCollectionProvider() { }
        public abstract Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection ActionDescriptors { get; }
        public abstract Microsoft.Extensions.Primitives.IChangeToken GetChangeToken();
    }
    internal partial class ActionInvokerFactory : Microsoft.AspNetCore.Mvc.Infrastructure.IActionInvokerFactory
    {
        public ActionInvokerFactory(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider> actionInvokerProviders) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.IActionInvoker CreateInvoker(Microsoft.AspNetCore.Mvc.ActionContext actionContext) { throw null; }
    }
    internal abstract partial class ActionMethodExecutor
    {
        protected ActionMethodExecutor() { }
        protected abstract bool CanExecute(Microsoft.Extensions.Internal.ObjectMethodExecutor executor);
        public abstract System.Threading.Tasks.ValueTask<Microsoft.AspNetCore.Mvc.IActionResult> Execute(Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.Extensions.Internal.ObjectMethodExecutor executor, object controller, object[] arguments);
        public static Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor GetExecutor(Microsoft.Extensions.Internal.ObjectMethodExecutor executor) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=false)]
    public sealed partial class ActionResultObjectValueAttribute : System.Attribute
    {
        public ActionResultObjectValueAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, AllowMultiple=false, Inherited=false)]
    public sealed partial class ActionResultStatusCodeAttribute : System.Attribute
    {
        public ActionResultStatusCodeAttribute() { }
    }
    internal partial class ActionResultTypeMapper : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper
    {
        public ActionResultTypeMapper() { }
        public Microsoft.AspNetCore.Mvc.IActionResult Convert(object value, System.Type returnType) { throw null; }
        public System.Type GetResultDataType(System.Type returnType) { throw null; }
    }
    internal partial class ActionSelectionTable<TItem>
    {
        private ActionSelectionTable() { }
        public int Version { get { throw null; } }
        public static Microsoft.AspNetCore.Mvc.Infrastructure.ActionSelectionTable<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> Create(Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection actions) { throw null; }
        public static Microsoft.AspNetCore.Mvc.Infrastructure.ActionSelectionTable<Microsoft.AspNetCore.Http.Endpoint> Create(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        public System.Collections.Generic.IReadOnlyList<TItem> Select(Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
    }
    internal partial class ActionSelector : Microsoft.AspNetCore.Mvc.Infrastructure.IActionSelector
    {
        public ActionSelector(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintCache actionConstraintCache, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor SelectBestCandidate(Microsoft.AspNetCore.Routing.RouteContext context, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> candidates) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> SelectCandidates(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    public partial class AmbiguousActionException : System.InvalidOperationException
    {
        protected AmbiguousActionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AmbiguousActionException(string message) { }
    }
    internal sealed partial class AsyncEnumerableReader
    {
        public AsyncEnumerableReader(Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) { }
        public bool TryGetReader(System.Type type, out System.Func<object, System.Threading.Tasks.Task<System.Collections.ICollection>> reader) { throw null; }
    }
    internal partial class ClientErrorResultFilter : Microsoft.AspNetCore.Mvc.Filters.IAlwaysRunResultFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter, Microsoft.AspNetCore.Mvc.Filters.IResultFilter
    {
        internal const int FilterOrder = -2000;
        public ClientErrorResultFilter(Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorFactory clientErrorFactory, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Infrastructure.ClientErrorResultFilter> logger) { }
        public int Order { get { throw null; } }
        public void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) { }
        public void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) { }
    }
    internal sealed partial class ClientErrorResultFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ClientErrorResultFilterFactory() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class CompatibilitySwitch<TValue> : Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch where TValue : struct
    {
        public CompatibilitySwitch(string name) { }
        public CompatibilitySwitch(string name, TValue initialValue) { }
        public bool IsValueSet { get { throw null; } }
        object Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch.Value { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public TValue Value { get { throw null; } set { } }
    }
    public abstract partial class ConfigureCompatibilityOptions<TOptions> : Microsoft.Extensions.Options.IPostConfigureOptions<TOptions> where TOptions : class, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch>
    {
        protected ConfigureCompatibilityOptions(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Infrastructure.MvcCompatibilityOptions> compatibilityOptions) { }
        protected abstract System.Collections.Generic.IReadOnlyDictionary<string, object> DefaultValues { get; }
        protected Microsoft.AspNetCore.Mvc.CompatibilityVersion Version { get { throw null; } }
        public virtual void PostConfigure(string name, TOptions options) { }
    }
    public partial class ContentResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.ContentResult>
    {
        public ContentResultExecutor(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Infrastructure.ContentResultExecutor> logger, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory httpResponseStreamWriterFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.ContentResult result) { throw null; }
    }
    internal partial class ControllerActionInvoker : Microsoft.AspNetCore.Mvc.Abstractions.IActionInvoker
    {
        internal ControllerActionInvoker(Microsoft.Extensions.Logging.ILogger logger, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor actionContextAccessor, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.ControllerContext controllerContext, Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCacheEntry cacheEntry, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filters) : base (default(System.Diagnostics.DiagnosticListener), default(Microsoft.Extensions.Logging.ILogger), default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor), default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper), default(Microsoft.AspNetCore.Mvc.ActionContext), default(Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[]), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory>)) { }
        internal Microsoft.AspNetCore.Mvc.ControllerContext ControllerContext { get { throw null; } }
        protected override System.Threading.Tasks.Task InvokeInnerFilterAsync() { throw null; }
        protected override void ReleaseResources() { }
    }
    internal partial class ControllerActionInvokerCache
    {
        public ControllerActionInvokerCache(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider collectionProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder parameterBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider> filterProviders, Microsoft.AspNetCore.Mvc.Controllers.IControllerFactoryProvider factoryProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        public (Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCacheEntry cacheEntry, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filters) GetCachedResult(Microsoft.AspNetCore.Mvc.ControllerContext controllerContext) { throw null; }
    }
    internal partial class ControllerActionInvokerCacheEntry
    {
        internal ControllerActionInvokerCacheEntry(Microsoft.AspNetCore.Mvc.Filters.FilterItem[] cachedFilters, System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> controllerFactory, System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> controllerReleaser, Microsoft.AspNetCore.Mvc.Controllers.ControllerBinderDelegate controllerBinderDelegate, Microsoft.Extensions.Internal.ObjectMethodExecutor objectMethodExecutor, Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor actionMethodExecutor) { }
        internal Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor ActionMethodExecutor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.FilterItem[] CachedFilters { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Controllers.ControllerBinderDelegate ControllerBinderDelegate { get { throw null; } }
        public System.Func<Microsoft.AspNetCore.Mvc.ControllerContext, object> ControllerFactory { get { throw null; } }
        public System.Action<Microsoft.AspNetCore.Mvc.ControllerContext, object> ControllerReleaser { get { throw null; } }
        internal Microsoft.Extensions.Internal.ObjectMethodExecutor ObjectMethodExecutor { get { throw null; } }
    }
    internal partial class ControllerActionInvokerProvider : Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider
    {
        public ControllerActionInvokerProvider(Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCache controllerActionInvokerCache, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> optionsAccessor, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper) { }
        public ControllerActionInvokerProvider(Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCache controllerActionInvokerCache, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> optionsAccessor, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor actionContextAccessor) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.Abstractions.ActionInvokerProviderContext context) { }
    }
    internal partial class CopyOnWriteList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    {
        public CopyOnWriteList(System.Collections.Generic.IReadOnlyList<T> source) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { throw null; }
        public void RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    internal partial class DefaultActionDescriptorCollectionProvider : Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollectionProvider
    {
        public DefaultActionDescriptorCollectionProvider(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Abstractions.IActionDescriptorProvider> actionDescriptorProviders, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorChangeProvider> actionDescriptorChangeProviders) { }
        public override Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection ActionDescriptors { get { throw null; } }
        public override Microsoft.Extensions.Primitives.IChangeToken GetChangeToken() { throw null; }
    }
    public partial class DefaultOutputFormatterSelector : Microsoft.AspNetCore.Mvc.Infrastructure.OutputFormatterSelector
    {
        public DefaultOutputFormatterSelector(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public override Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter SelectFormatter(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter> formatters, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection contentTypes) { throw null; }
    }
    internal sealed partial class DefaultProblemDetailsFactory : Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsFactory
    {
        public DefaultProblemDetailsFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions> options) { }
        public override Microsoft.AspNetCore.Mvc.ProblemDetails CreateProblemDetails(Microsoft.AspNetCore.Http.HttpContext httpContext, int? statusCode = default(int?), string title = null, string type = null, string detail = null, string instance = null) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ValidationProblemDetails CreateValidationProblemDetails(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelStateDictionary, int? statusCode = default(int?), string title = null, string type = null, string detail = null, string instance = null) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class DefaultStatusCodeAttribute : System.Attribute
    {
        public DefaultStatusCodeAttribute(int statusCode) { }
        public int StatusCode { get { throw null; } }
    }
    public partial class FileContentResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.FileResultExecutorBase, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.FileContentResult>
    {
        public FileContentResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.Extensions.Logging.ILogger)) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.FileContentResult result) { throw null; }
        protected virtual System.Threading.Tasks.Task WriteFileAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.FileContentResult result, Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength) { throw null; }
    }
    public partial class FileResultExecutorBase
    {
        protected const int BufferSize = 65536;
        public FileResultExecutorBase(Microsoft.Extensions.Logging.ILogger logger) { }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        protected static Microsoft.Extensions.Logging.ILogger CreateLogger<T>(Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
        internal Microsoft.AspNetCore.Mvc.Infrastructure.FileResultExecutorBase.PreconditionState GetPreconditionState(Microsoft.AspNetCore.Http.Headers.RequestHeaders httpRequestHeaders, System.DateTimeOffset? lastModified = default(System.DateTimeOffset?), Microsoft.Net.Http.Headers.EntityTagHeaderValue etag = null) { throw null; }
        internal bool IfRangeValid(Microsoft.AspNetCore.Http.Headers.RequestHeaders httpRequestHeaders, System.DateTimeOffset? lastModified = default(System.DateTimeOffset?), Microsoft.Net.Http.Headers.EntityTagHeaderValue etag = null) { throw null; }
        protected virtual (Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength, bool serveBody) SetHeadersAndLog(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.FileResult result, long? fileLength, bool enableRangeProcessing, System.DateTimeOffset? lastModified = default(System.DateTimeOffset?), Microsoft.Net.Http.Headers.EntityTagHeaderValue etag = null) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected static System.Threading.Tasks.Task WriteFileAsync(Microsoft.AspNetCore.Http.HttpContext context, System.IO.Stream fileStream, Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength) { throw null; }
        internal enum PreconditionState
        {
            Unspecified = 0,
            NotModified = 1,
            ShouldProcess = 2,
            PreconditionFailed = 3,
        }
    }
    public partial class FileStreamResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.FileResultExecutorBase, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.FileStreamResult>
    {
        public FileStreamResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.Extensions.Logging.ILogger)) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.FileStreamResult result) { throw null; }
        protected virtual System.Threading.Tasks.Task WriteFileAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.FileStreamResult result, Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength) { throw null; }
    }
    public partial interface IActionContextAccessor
    {
        Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get; set; }
    }
    public partial interface IActionDescriptorChangeProvider
    {
        Microsoft.Extensions.Primitives.IChangeToken GetChangeToken();
    }
    public partial interface IActionDescriptorCollectionProvider
    {
        Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection ActionDescriptors { get; }
    }
    public partial interface IActionInvokerFactory
    {
        Microsoft.AspNetCore.Mvc.Abstractions.IActionInvoker CreateInvoker(Microsoft.AspNetCore.Mvc.ActionContext actionContext);
    }
    public partial interface IActionResultExecutor<in TResult> where TResult : Microsoft.AspNetCore.Mvc.IActionResult
    {
        System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, TResult result);
    }
    public partial interface IActionResultTypeMapper
    {
        Microsoft.AspNetCore.Mvc.IActionResult Convert(object value, System.Type returnType);
        System.Type GetResultDataType(System.Type returnType);
    }
    public partial interface IActionSelector
    {
        Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor SelectBestCandidate(Microsoft.AspNetCore.Routing.RouteContext context, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> candidates);
        System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> SelectCandidates(Microsoft.AspNetCore.Routing.RouteContext context);
    }
    public partial interface IApiBehaviorMetadata : Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
    {
    }
    public partial interface IClientErrorActionResult : Microsoft.AspNetCore.Mvc.IActionResult, Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
    {
    }
    public partial interface IClientErrorFactory
    {
        Microsoft.AspNetCore.Mvc.IActionResult GetClientError(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorActionResult clientError);
    }
    public partial interface ICompatibilitySwitch
    {
        bool IsValueSet { get; }
        string Name { get; }
        object Value { get; set; }
    }
    public partial interface IConvertToActionResult
    {
        Microsoft.AspNetCore.Mvc.IActionResult Convert();
    }
    public partial interface IHttpRequestStreamReaderFactory
    {
        System.IO.TextReader CreateReader(System.IO.Stream stream, System.Text.Encoding encoding);
    }
    public partial interface IHttpResponseStreamWriterFactory
    {
        System.IO.TextWriter CreateWriter(System.IO.Stream stream, System.Text.Encoding encoding);
    }
    public partial interface IParameterInfoParameterDescriptor
    {
        System.Reflection.ParameterInfo ParameterInfo { get; }
    }
    public partial interface IPropertyInfoParameterDescriptor
    {
        System.Reflection.PropertyInfo PropertyInfo { get; }
    }
    public partial interface IStatusCodeActionResult : Microsoft.AspNetCore.Mvc.IActionResult
    {
        int? StatusCode { get; }
    }
    internal partial interface ITypeActivatorCache
    {
        TInstance CreateInstance<TInstance>(System.IServiceProvider serviceProvider, System.Type optionType);
    }
    public partial class LocalRedirectResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.LocalRedirectResult>
    {
        public LocalRedirectResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.LocalRedirectResult result) { throw null; }
    }
    internal partial class MemoryPoolHttpRequestStreamReaderFactory : Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory
    {
        public static readonly int DefaultBufferSize;
        public MemoryPoolHttpRequestStreamReaderFactory(System.Buffers.ArrayPool<byte> bytePool, System.Buffers.ArrayPool<char> charPool) { }
        public System.IO.TextReader CreateReader(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
    }
    internal partial class MemoryPoolHttpResponseStreamWriterFactory : Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory
    {
        public static readonly int DefaultBufferSize;
        public MemoryPoolHttpResponseStreamWriterFactory(System.Buffers.ArrayPool<byte> bytePool, System.Buffers.ArrayPool<char> charPool) { }
        public System.IO.TextWriter CreateWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
    }
    public partial class ModelStateInvalidFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        internal const int FilterOrder = -2000;
        public ModelStateInvalidFilter(Microsoft.AspNetCore.Mvc.ApiBehaviorOptions apiBehaviorOptions, Microsoft.Extensions.Logging.ILogger logger) { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } }
        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
    }
    internal partial class ModelStateInvalidFilterFactory : Microsoft.AspNetCore.Mvc.Filters.IFilterFactory, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public ModelStateInvalidFilterFactory() { }
        public bool IsReusable { get { throw null; } }
        public int Order { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class MvcCompatibilityOptions
    {
        public MvcCompatibilityOptions() { }
        public Microsoft.AspNetCore.Mvc.CompatibilityVersion CompatibilityVersion { get { throw null; } set { } }
    }
    internal partial class MvcOptionsConfigureCompatibilityOptions : Microsoft.AspNetCore.Mvc.Infrastructure.ConfigureCompatibilityOptions<Microsoft.AspNetCore.Mvc.MvcOptions>
    {
        public MvcOptionsConfigureCompatibilityOptions(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Infrastructure.MvcCompatibilityOptions> compatibilityOptions) : base (default(Microsoft.Extensions.Logging.ILoggerFactory), default(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Infrastructure.MvcCompatibilityOptions>)) { }
        protected override System.Collections.Generic.IReadOnlyDictionary<string, object> DefaultValues { get { throw null; } }
    }
    internal partial class NonDisposableStream : System.IO.Stream
    {
        public NonDisposableStream(System.IO.Stream innerStream) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void Close() { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    internal partial class NullableCompatibilitySwitch<TValue> : Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch where TValue : struct
    {
        public NullableCompatibilitySwitch(string name) { }
        public bool IsValueSet { get { throw null; } }
        object Microsoft.AspNetCore.Mvc.Infrastructure.ICompatibilitySwitch.Value { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public TValue? Value { get { throw null; } set { } }
    }
    public partial class ObjectResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.ObjectResult>
    {
        [System.ObsoleteAttribute("This constructor is obsolete and will be removed in a future release.")]
        public ObjectResultExecutor(Microsoft.AspNetCore.Mvc.Infrastructure.OutputFormatterSelector formatterSelector, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public ObjectResultExecutor(Microsoft.AspNetCore.Mvc.Infrastructure.OutputFormatterSelector formatterSelector, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory writerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        protected Microsoft.AspNetCore.Mvc.Infrastructure.OutputFormatterSelector FormatterSelector { get { throw null; } }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        protected System.Func<System.IO.Stream, System.Text.Encoding, System.IO.TextWriter> WriterFactory { get { throw null; } }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.ObjectResult result) { throw null; }
    }
    public abstract partial class OutputFormatterSelector
    {
        protected OutputFormatterSelector() { }
        public abstract Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter SelectFormatter(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterCanWriteContext context, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IOutputFormatter> formatters, Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection mediaTypes);
    }
    internal static partial class ParameterDefaultValues
    {
        public static object[] GetParameterDefaultValues(System.Reflection.MethodInfo methodInfo) { throw null; }
        public static bool TryGetDeclaredParameterDefaultValue(System.Reflection.ParameterInfo parameterInfo, out object defaultValue) { throw null; }
    }
    public partial class PhysicalFileResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.FileResultExecutorBase, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.PhysicalFileResult>
    {
        public PhysicalFileResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.Extensions.Logging.ILogger)) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.PhysicalFileResult result) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.Infrastructure.PhysicalFileResultExecutor.FileMetadata GetFileInfo(string path) { throw null; }
        [System.ObsoleteAttribute("This API is no longer called.")]
        protected virtual System.IO.Stream GetFileStream(string path) { throw null; }
        protected virtual System.Threading.Tasks.Task WriteFileAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.PhysicalFileResult result, Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength) { throw null; }
        protected partial class FileMetadata
        {
            public FileMetadata() { }
            public bool Exists { get { throw null; } set { } }
            public System.DateTimeOffset LastModified { get { throw null; } set { } }
            public long Length { get { throw null; } set { } }
        }
    }
    internal partial class ProblemDetailsClientErrorFactory : Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorFactory
    {
        public ProblemDetailsClientErrorFactory(Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsFactory problemDetailsFactory) { }
        public Microsoft.AspNetCore.Mvc.IActionResult GetClientError(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorActionResult clientError) { throw null; }
    }
    public abstract partial class ProblemDetailsFactory
    {
        protected ProblemDetailsFactory() { }
        public abstract Microsoft.AspNetCore.Mvc.ProblemDetails CreateProblemDetails(Microsoft.AspNetCore.Http.HttpContext httpContext, int? statusCode = default(int?), string title = null, string type = null, string detail = null, string instance = null);
        public abstract Microsoft.AspNetCore.Mvc.ValidationProblemDetails CreateValidationProblemDetails(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelStateDictionary, int? statusCode = default(int?), string title = null, string type = null, string detail = null, string instance = null);
    }
    internal partial class ProblemDetailsJsonConverter : System.Text.Json.Serialization.JsonConverter<Microsoft.AspNetCore.Mvc.ProblemDetails>
    {
        public ProblemDetailsJsonConverter() { }
        public override Microsoft.AspNetCore.Mvc.ProblemDetails Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options) { throw null; }
        internal static void ReadValue(ref System.Text.Json.Utf8JsonReader reader, Microsoft.AspNetCore.Mvc.ProblemDetails value, System.Text.Json.JsonSerializerOptions options) { }
        internal static bool TryReadStringProperty(ref System.Text.Json.Utf8JsonReader reader, System.Text.Json.JsonEncodedText propertyName, out string value) { throw null; }
        public override void Write(System.Text.Json.Utf8JsonWriter writer, Microsoft.AspNetCore.Mvc.ProblemDetails value, System.Text.Json.JsonSerializerOptions options) { }
        internal static void WriteProblemDetails(System.Text.Json.Utf8JsonWriter writer, Microsoft.AspNetCore.Mvc.ProblemDetails value, System.Text.Json.JsonSerializerOptions options) { }
    }
    public partial class RedirectResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.RedirectResult>
    {
        public RedirectResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.RedirectResult result) { throw null; }
    }
    public partial class RedirectToActionResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.RedirectToActionResult>
    {
        public RedirectToActionResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.RedirectToActionResult result) { throw null; }
    }
    public partial class RedirectToPageResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.RedirectToPageResult>
    {
        public RedirectToPageResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.RedirectToPageResult result) { throw null; }
    }
    public partial class RedirectToRouteResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.RedirectToRouteResult>
    {
        public RedirectToRouteResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.RedirectToRouteResult result) { throw null; }
    }
    internal partial class StringArrayComparer : System.Collections.Generic.IEqualityComparer<string[]>
    {
        private StringArrayComparer() { }
        public static readonly Microsoft.AspNetCore.Mvc.Infrastructure.StringArrayComparer Ordinal;
        public static readonly Microsoft.AspNetCore.Mvc.Infrastructure.StringArrayComparer OrdinalIgnoreCase;
        public bool Equals(string[] x, string[] y) { throw null; }
        public int GetHashCode(string[] obj) { throw null; }
    }
    internal sealed partial class SystemTextJsonResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.JsonResult>
    {
        public SystemTextJsonResultExecutor(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.JsonOptions> options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Infrastructure.SystemTextJsonResultExecutor> logger, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.JsonResult result) { throw null; }
    }
    internal partial class TypeActivatorCache : Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache
    {
        public TypeActivatorCache() { }
        public TInstance CreateInstance<TInstance>(System.IServiceProvider serviceProvider, System.Type implementationType) { throw null; }
    }
    internal partial class ValidationProblemDetailsJsonConverter : System.Text.Json.Serialization.JsonConverter<Microsoft.AspNetCore.Mvc.ValidationProblemDetails>
    {
        public ValidationProblemDetailsJsonConverter() { }
        public override Microsoft.AspNetCore.Mvc.ValidationProblemDetails Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options) { throw null; }
        public override void Write(System.Text.Json.Utf8JsonWriter writer, Microsoft.AspNetCore.Mvc.ValidationProblemDetails value, System.Text.Json.JsonSerializerOptions options) { }
    }
    public partial class VirtualFileResultExecutor : Microsoft.AspNetCore.Mvc.Infrastructure.FileResultExecutorBase, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<Microsoft.AspNetCore.Mvc.VirtualFileResult>
    {
        public VirtualFileResultExecutor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) : base (default(Microsoft.Extensions.Logging.ILogger)) { }
        public virtual System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.VirtualFileResult result) { throw null; }
        [System.ObsoleteAttribute("This API is no longer called.")]
        protected virtual System.IO.Stream GetFileStream(Microsoft.Extensions.FileProviders.IFileInfo fileInfo) { throw null; }
        protected virtual System.Threading.Tasks.Task WriteFileAsync(Microsoft.AspNetCore.Mvc.ActionContext context, Microsoft.AspNetCore.Mvc.VirtualFileResult result, Microsoft.Extensions.FileProviders.IFileInfo fileInfo, Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long rangeLength) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    public enum BindingBehavior
    {
        Optional = 0,
        Never = 1,
        Required = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public partial class BindingBehaviorAttribute : System.Attribute
    {
        public BindingBehaviorAttribute(Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehavior behavior) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehavior Behavior { get { throw null; } }
    }
    public abstract partial class BindingSourceValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public BindingSourceValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public abstract bool ContainsPrefix(string prefix);
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { throw null; }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class BindNeverAttribute : Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehaviorAttribute
    {
        public BindNeverAttribute() : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehavior)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class BindRequiredAttribute : Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehaviorAttribute
    {
        public BindRequiredAttribute() : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingBehavior)) { }
    }
    public partial class CompositeValueProvider : System.Collections.ObjectModel.Collection<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider>, Microsoft.AspNetCore.Mvc.ModelBinding.IBindingSourceValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IEnumerableValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IKeyRewriterValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public CompositeValueProvider() { }
        public CompositeValueProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider> valueProviders) { }
        public virtual bool ContainsPrefix(string prefix) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.CompositeValueProvider> CreateAsync(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> factories) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.CompositeValueProvider> CreateAsync(Microsoft.AspNetCore.Mvc.ControllerContext controllerContext) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter() { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix) { throw null; }
        public virtual Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
        protected override void InsertItem(int index, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider item) { }
        protected override void SetItem(int index, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider item) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal static System.Threading.Tasks.ValueTask<(bool success, Microsoft.AspNetCore.Mvc.ModelBinding.CompositeValueProvider valueProvider)> TryCreateAsync(Microsoft.AspNetCore.Mvc.ActionContext actionContext, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> factories) { throw null; }
    }
    public partial class DefaultModelBindingContext : Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext
    {
        public DefaultModelBindingContext() { }
        public override Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } set { } }
        public override string BinderModelName { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } set { } }
        public override string FieldName { get { throw null; } set { } }
        public override bool IsTopLevelObject { get { throw null; } set { } }
        public override object Model { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ModelMetadata { get { throw null; } set { } }
        public override string ModelName { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider OriginalValueProvider { get { throw null; } set { } }
        public override System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> PropertyFilter { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult Result { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary ValidationState { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider ValueProvider { get { throw null; } set { } }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext CreateBindingContext(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo bindingInfo, string modelName) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext.NestedScope EnterNestedScope() { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext.NestedScope EnterNestedScope(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, string fieldName, string modelName, object model) { throw null; }
        protected override void ExitNestedScope() { }
    }
    public partial class DefaultPropertyFilterProvider<TModel> : Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider where TModel : class
    {
        public DefaultPropertyFilterProvider() { }
        public virtual string Prefix { get { throw null; } }
        public virtual System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> PropertyFilter { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression<System.Func<TModel, object>>> PropertyIncludeExpressions { get { throw null; } }
    }
    internal partial class ElementalValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public ElementalValueProvider(string key, string value, System.Globalization.CultureInfo culture) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public string Key { get { throw null; } }
        public string Value { get { throw null; } }
        public bool ContainsPrefix(string prefix) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class EmptyModelMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelMetadataProvider
    {
        public EmptyModelMetadataProvider() : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider)) { }
    }
    public sealed partial class FormFileValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public FormFileValueProvider(Microsoft.AspNetCore.Http.IFormFileCollection files) { }
        public bool ContainsPrefix(string prefix) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public sealed partial class FormFileValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public FormFileValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    public partial class FormValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.BindingSourceValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IEnumerableValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public FormValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, Microsoft.AspNetCore.Http.IFormCollection values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource)) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.PrefixContainer PrefixContainer { get { throw null; } }
        public override bool ContainsPrefix(string prefix) { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class FormValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public FormValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    public partial interface IBindingSourceValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource);
    }
    public partial interface ICollectionModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        bool CanCreateInstance(System.Type targetType);
    }
    public partial interface IEnumerableValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix);
    }
    public partial interface IKeyRewriterValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter();
    }
    public partial interface IModelBinderFactory
    {
        Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder CreateBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderFactoryContext context);
    }
    public partial class JQueryFormValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.JQueryValueProvider
    {
        public JQueryFormValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource), default(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>), default(System.Globalization.CultureInfo)) { }
    }
    public partial class JQueryFormValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public JQueryFormValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    internal static partial class JQueryKeyValuePairNormalizer
    {
        public static System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> GetValues(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> originalValues, int valueCount) { throw null; }
    }
    public partial class JQueryQueryStringValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.JQueryValueProvider
    {
        public JQueryQueryStringValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource), default(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>), default(System.Globalization.CultureInfo)) { }
    }
    public partial class JQueryQueryStringValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public JQueryQueryStringValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    public abstract partial class JQueryValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.BindingSourceValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IEnumerableValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IKeyRewriterValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        protected JQueryValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource)) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.PrefixContainer PrefixContainer { get { throw null; } }
        public override bool ContainsPrefix(string prefix) { throw null; }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider Filter() { throw null; }
        public System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class ModelAttributes
    {
        internal ModelAttributes(System.Collections.Generic.IEnumerable<object> typeAttributes, System.Collections.Generic.IEnumerable<object> propertyAttributes, System.Collections.Generic.IEnumerable<object> parameterAttributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> ParameterAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> PropertyAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> TypeAttributes { get { throw null; } }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes GetAttributesForParameter(System.Reflection.ParameterInfo parameterInfo) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes GetAttributesForParameter(System.Reflection.ParameterInfo parameterInfo, System.Type modelType) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes GetAttributesForProperty(System.Type type, System.Reflection.PropertyInfo property) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes GetAttributesForProperty(System.Type containerType, System.Reflection.PropertyInfo property, System.Type modelType) { throw null; }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes GetAttributesForType(System.Type type) { throw null; }
    }
    public partial class ModelBinderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory
    {
        public ModelBinderFactory(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> options, System.IServiceProvider serviceProvider) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder CreateBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderFactoryContext context) { throw null; }
    }
    public partial class ModelBinderFactoryContext
    {
        public ModelBinderFactoryContext() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingInfo BindingInfo { get { throw null; } set { } }
        public object CacheToken { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } set { } }
    }
    public static partial class ModelBinderProviderExtensions
    {
        public static void RemoveType(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider> list, System.Type type) { }
        public static void RemoveType<TModelBinderProvider>(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider> list) where TModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider { }
    }
    internal static partial class ModelBindingHelper
    {
        public static bool CanGetCompatibleCollection<T>(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        internal static TModel CastOrDefault<TModel>(object model) { throw null; }
        public static void ClearValidationStateForModel(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata modelMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, string modelKey) { }
        public static void ClearValidationStateForModel(System.Type modelType, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, string modelKey) { }
        public static object ConvertTo(object value, System.Type type, System.Globalization.CultureInfo culture) { throw null; }
        public static T ConvertTo<T>(object value, System.Globalization.CultureInfo culture) { throw null; }
        public static System.Collections.Generic.ICollection<T> GetCompatibleCollection<T>(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        public static System.Collections.Generic.ICollection<T> GetCompatibleCollection<T>(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, int capacity) { throw null; }
        public static System.Linq.Expressions.Expression<System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool>> GetPropertyFilterExpression<TModel>(System.Linq.Expressions.Expression<System.Func<TModel, object>>[] expressions) { throw null; }
        internal static string GetPropertyName(System.Linq.Expressions.Expression expression) { throw null; }
        public static System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator objectModelValidator) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task<bool> TryUpdateModelAsync(object model, System.Type modelType, string prefix, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator objectModelValidator, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) { throw null; }
        public static System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator objectModelValidator) where TModel : class { throw null; }
        public static System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator objectModelValidator, System.Func<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, bool> propertyFilter) where TModel : class { throw null; }
        public static System.Threading.Tasks.Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator objectModelValidator, params System.Linq.Expressions.Expression<System.Func<TModel, object>>[] includeExpressions) where TModel : class { throw null; }
    }
    public static partial class ModelMetadataProviderExtensions
    {
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForProperty(this Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider provider, System.Type containerType, string propertyName) { throw null; }
    }
    public static partial class ModelNames
    {
        public static string CreateIndexModelName(string parentName, int index) { throw null; }
        public static string CreateIndexModelName(string parentName, string index) { throw null; }
        public static string CreatePropertyModelName(string prefix, string propertyName) { throw null; }
    }
    internal partial class NoOpBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder Instance;
        public NoOpBinder() { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public abstract partial class ObjectModelValidator : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator
    {
        public ObjectModelValidator(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> validatorProviders) { }
        public abstract Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationVisitor GetValidationVisitor(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider validatorProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorCache validatorCache, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState);
        public virtual void Validate(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState, string prefix, object model) { }
        public virtual void Validate(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState, string prefix, object model, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { }
    }
    public partial class ParameterBinder
    {
        public ParameterBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory modelBinderFactory, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator validator, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> mvcOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult> BindModelAsync(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder modelBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider valueProvider, Microsoft.AspNetCore.Mvc.Abstractions.ParameterDescriptor parameter, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object value) { throw null; }
    }
    internal partial class PlaceholderBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public PlaceholderBinder() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder Inner { get { throw null; } set { } }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class PrefixContainer
    {
        public PrefixContainer(System.Collections.Generic.ICollection<string> values) { }
        public bool ContainsPrefix(string prefix) { throw null; }
        public System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix) { throw null; }
    }
    internal static partial class PropertyValueSetter
    {
        public static void SetValue(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object instance, object value) { }
    }
    public partial class QueryStringValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.BindingSourceValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IEnumerableValueProvider, Microsoft.AspNetCore.Mvc.ModelBinding.IValueProvider
    {
        public QueryStringValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, Microsoft.AspNetCore.Http.IQueryCollection values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource)) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.PrefixContainer PrefixContainer { get { throw null; } }
        public override bool ContainsPrefix(string prefix) { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetKeysFromPrefix(string prefix) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class QueryStringValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public QueryStringValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    internal partial class ReferenceEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
    {
        public ReferenceEqualityComparer() { }
        public static Microsoft.AspNetCore.Mvc.ModelBinding.ReferenceEqualityComparer Instance { get { throw null; } }
        public new bool Equals(object x, object y) { throw null; }
        public int GetHashCode(object obj) { throw null; }
    }
    public partial class RouteValueProvider : Microsoft.AspNetCore.Mvc.ModelBinding.BindingSourceValueProvider
    {
        public RouteValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, Microsoft.AspNetCore.Routing.RouteValueDictionary values) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource)) { }
        public RouteValueProvider(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource, Microsoft.AspNetCore.Routing.RouteValueDictionary values, System.Globalization.CultureInfo culture) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource)) { }
        protected System.Globalization.CultureInfo Culture { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.PrefixContainer PrefixContainer { get { throw null; } }
        public override bool ContainsPrefix(string key) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class RouteValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory
    {
        public RouteValueProviderFactory() { }
        public System.Threading.Tasks.Task CreateValueProviderAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderFactoryContext context) { throw null; }
    }
    public partial class SuppressChildValidationMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
        public SuppressChildValidationMetadataProvider(string fullTypeName) { }
        public SuppressChildValidationMetadataProvider(System.Type type) { }
        public string FullTypeName { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public void CreateValidationMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadataProviderContext context) { }
    }
    public partial class UnsupportedContentTypeException : System.Exception
    {
        public UnsupportedContentTypeException(string message) { }
    }
    public partial class UnsupportedContentTypeFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata, Microsoft.AspNetCore.Mvc.Filters.IOrderedFilter
    {
        public UnsupportedContentTypeFilter() { }
        public int Order { get { throw null; } set { } }
        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context) { }
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context) { }
    }
    public static partial class ValueProviderFactoryExtensions
    {
        public static void RemoveType(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> list, System.Type type) { }
        public static void RemoveType<TValueProviderFactory>(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> list) where TValueProviderFactory : Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory { }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding.Binders
{
    public partial class ArrayModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public ArrayModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class ArrayModelBinder<TElement> : Microsoft.AspNetCore.Mvc.ModelBinding.Binders.CollectionModelBinder<TElement>
    {
        public ArrayModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public ArrayModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public ArrayModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public override bool CanCreateInstance(System.Type targetType) { throw null; }
        protected override object ConvertToCollectionType(System.Type targetType, System.Collections.Generic.IEnumerable<TElement> collection) { throw null; }
        protected override void CopyToModel(object target, System.Collections.Generic.IEnumerable<TElement> sourceCollection) { }
        protected override object CreateEmptyCollection(System.Type targetType) { throw null; }
    }
    public partial class BinderTypeModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public BinderTypeModelBinder(System.Type binderType) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class BinderTypeModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public BinderTypeModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class BodyModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public BodyModelBinder(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory) { }
        public BodyModelBinder(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public BodyModelBinder(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.MvcOptions options) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class BodyModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public BodyModelBinderProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory) { }
        public BodyModelBinderProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public BodyModelBinderProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.Formatters.IInputFormatter> formatters, Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory readerFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.MvcOptions options) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class ByteArrayModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public ByteArrayModelBinder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class ByteArrayModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public ByteArrayModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class CancellationTokenModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public CancellationTokenModelBinder() { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class CancellationTokenModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public CancellationTokenModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class CollectionModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public CollectionModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class CollectionModelBinder<TElement> : Microsoft.AspNetCore.Mvc.ModelBinding.ICollectionModelBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public CollectionModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public CollectionModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes) { }
        public CollectionModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder elementBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) { }
        internal bool AllowValidatingTopLevelNodes { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder ElementBinder { get { throw null; } }
        protected Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        protected void AddErrorIfBindingRequired(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.Binders.CollectionModelBinder<TElement>.CollectionResult> BindComplexCollectionFromIndexes(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, System.Collections.Generic.IEnumerable<string> indexNames) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.Binders.CollectionModelBinder<TElement>.CollectionResult> BindSimpleCollection(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult values) { throw null; }
        public virtual bool CanCreateInstance(System.Type targetType) { throw null; }
        protected virtual object ConvertToCollectionType(System.Type targetType, System.Collections.Generic.IEnumerable<TElement> collection) { throw null; }
        protected virtual void CopyToModel(object target, System.Collections.Generic.IEnumerable<TElement> sourceCollection) { }
        protected virtual object CreateEmptyCollection(System.Type targetType) { throw null; }
        protected object CreateInstance(System.Type targetType) { throw null; }
        internal partial class CollectionResult
        {
            public CollectionResult() { }
            public System.Collections.Generic.IEnumerable<TElement> Model { get { throw null; } set { } }
            public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy ValidationStrategy { get { throw null; } set { } }
        }
    }
    public partial class ComplexTypeModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        internal const int GreedyPropertiesMayHaveData = 1;
        internal const int NoDataAvailable = 0;
        internal const int ValueProviderDataAvailable = 2;
        public ComplexTypeModelBinder(System.Collections.Generic.IDictionary<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder> propertyBinders, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public ComplexTypeModelBinder(System.Collections.Generic.IDictionary<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder> propertyBinders, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        protected virtual System.Threading.Tasks.Task BindProperty(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        protected virtual bool CanBindProperty(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata propertyMetadata) { throw null; }
        internal int CanCreateModel(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        internal static bool CanUpdatePropertyInternal(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata propertyMetadata) { throw null; }
        protected virtual object CreateModel(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        protected virtual void SetProperty(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, string modelName, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata propertyMetadata, Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult result) { }
    }
    public partial class ComplexTypeModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public ComplexTypeModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class DecimalModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public DecimalModelBinder(System.Globalization.NumberStyles supportedStyles, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class DictionaryModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public DictionaryModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class DictionaryModelBinder<TKey, TValue> : Microsoft.AspNetCore.Mvc.ModelBinding.Binders.CollectionModelBinder<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    {
        public DictionaryModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder keyBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder valueBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public DictionaryModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder keyBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder valueBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public DictionaryModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder keyBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder valueBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, bool allowValidatingTopLevelNodes, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        public override bool CanCreateInstance(System.Type targetType) { throw null; }
        protected override object ConvertToCollectionType(System.Type targetType, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection) { throw null; }
        protected override object CreateEmptyCollection(System.Type targetType) { throw null; }
    }
    public partial class DoubleModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public DoubleModelBinder(System.Globalization.NumberStyles supportedStyles, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class EnumTypeModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.Binders.SimpleTypeModelBinder
    {
        public EnumTypeModelBinder(bool suppressBindingUndefinedValueToEnumType, System.Type modelType, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(System.Type), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        protected override void CheckModel(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult valueProviderResult, object model) { }
    }
    public partial class EnumTypeModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public EnumTypeModelBinderProvider(Microsoft.AspNetCore.Mvc.MvcOptions options) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class FloatingPointTypeModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        internal static readonly System.Globalization.NumberStyles SupportedStyles;
        public FloatingPointTypeModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class FloatModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public FloatModelBinder(System.Globalization.NumberStyles supportedStyles, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class FormCollectionModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public FormCollectionModelBinder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class FormCollectionModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public FormCollectionModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class FormFileModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public FormFileModelBinder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class FormFileModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public FormFileModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class HeaderModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public HeaderModelBinder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public HeaderModelBinder(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder innerModelBinder) { }
        internal Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder InnerModelBinder { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class HeaderModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public HeaderModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class KeyValuePairModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public KeyValuePairModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class KeyValuePairModelBinder<TKey, TValue> : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public KeyValuePairModelBinder(Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder keyBinder, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder valueBinder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingResult> TryBindStrongModel<TModel>(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder binder, string propertyName, string propertyModelName) { throw null; }
    }
    public partial class ServicesModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public ServicesModelBinder() { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
    }
    public partial class ServicesModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public ServicesModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
    public partial class SimpleTypeModelBinder : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
    {
        public SimpleTypeModelBinder(System.Type type, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext) { throw null; }
        protected virtual void CheckModel(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext bindingContext, Microsoft.AspNetCore.Mvc.ModelBinding.ValueProviderResult valueProviderResult, object model) { }
    }
    public partial class SimpleTypeModelBinderProvider : Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
    {
        public SimpleTypeModelBinderProvider() { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding.Metadata
{
    public partial class BindingMetadata
    {
        public BindingMetadata() { }
        public string BinderModelName { get { throw null; } set { } }
        public System.Type BinderType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } set { } }
        public bool IsBindingAllowed { get { throw null; } set { } }
        public bool IsBindingRequired { get { throw null; } set { } }
        public bool? IsReadOnly { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelBindingMessageProvider ModelBindingMessageProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider PropertyFilterProvider { get { throw null; } set { } }
    }
    public partial class BindingMetadataProviderContext
    {
        public BindingMetadataProviderContext(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key, Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes attributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadata BindingMetadata { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity Key { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> ParameterAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> PropertyAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> TypeAttributes { get { throw null; } }
    }
    public partial class BindingSourceMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IBindingMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        public BindingSourceMetadataProvider(System.Type type, Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource bindingSource) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public void CreateBindingMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadataProviderContext context) { }
    }
    internal partial class DefaultBindingMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IBindingMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        public DefaultBindingMetadataProvider() { }
        public void CreateBindingMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadataProviderContext context) { }
    }
    internal partial class DefaultCompositeMetadataDetailsProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IBindingMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IDisplayMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
        public DefaultCompositeMetadataDetailsProvider(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider> providers) { }
        public void CreateBindingMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadataProviderContext context) { }
        public void CreateDisplayMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DisplayMetadataProviderContext context) { }
        public void CreateValidationMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadataProviderContext context) { }
    }
    public partial class DefaultMetadataDetails
    {
        public DefaultMetadataDetails(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key, Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes attributes) { }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadata BindingMetadata { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ContainerMetadata { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DisplayMetadata DisplayMetadata { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity Key { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes ModelAttributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata[] Properties { get { throw null; } set { } }
        public System.Func<object, object> PropertyGetter { get { throw null; } set { } }
        public System.Action<object, object> PropertySetter { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadata ValidationMetadata { get { throw null; } set { } }
    }
    public partial class DefaultModelBindingMessageProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelBindingMessageProvider
    {
        public DefaultModelBindingMessageProvider() { }
        public DefaultModelBindingMessageProvider(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelBindingMessageProvider originalProvider) { }
        public override System.Func<string, string, string> AttemptedValueIsInvalidAccessor { get { throw null; } }
        public override System.Func<string, string> MissingBindRequiredValueAccessor { get { throw null; } }
        public override System.Func<string> MissingKeyOrValueAccessor { get { throw null; } }
        public override System.Func<string> MissingRequestBodyRequiredValueAccessor { get { throw null; } }
        public override System.Func<string, string> NonPropertyAttemptedValueIsInvalidAccessor { get { throw null; } }
        public override System.Func<string> NonPropertyUnknownValueIsInvalidAccessor { get { throw null; } }
        public override System.Func<string> NonPropertyValueMustBeANumberAccessor { get { throw null; } }
        public override System.Func<string, string> UnknownValueIsInvalidAccessor { get { throw null; } }
        public override System.Func<string, string> ValueIsInvalidAccessor { get { throw null; } }
        public override System.Func<string, string> ValueMustBeANumberAccessor { get { throw null; } }
        public override System.Func<string, string> ValueMustNotBeNullAccessor { get { throw null; } }
        public void SetAttemptedValueIsInvalidAccessor(System.Func<string, string, string> attemptedValueIsInvalidAccessor) { }
        public void SetMissingBindRequiredValueAccessor(System.Func<string, string> missingBindRequiredValueAccessor) { }
        public void SetMissingKeyOrValueAccessor(System.Func<string> missingKeyOrValueAccessor) { }
        public void SetMissingRequestBodyRequiredValueAccessor(System.Func<string> missingRequestBodyRequiredValueAccessor) { }
        public void SetNonPropertyAttemptedValueIsInvalidAccessor(System.Func<string, string> nonPropertyAttemptedValueIsInvalidAccessor) { }
        public void SetNonPropertyUnknownValueIsInvalidAccessor(System.Func<string> nonPropertyUnknownValueIsInvalidAccessor) { }
        public void SetNonPropertyValueMustBeANumberAccessor(System.Func<string> nonPropertyValueMustBeANumberAccessor) { }
        public void SetUnknownValueIsInvalidAccessor(System.Func<string, string> unknownValueIsInvalidAccessor) { }
        public void SetValueIsInvalidAccessor(System.Func<string, string> valueIsInvalidAccessor) { }
        public void SetValueMustBeANumberAccessor(System.Func<string, string> valueMustBeANumberAccessor) { }
        public void SetValueMustNotBeNullAccessor(System.Func<string, string> valueMustNotBeNullAccessor) { }
    }
    public partial class DefaultModelMetadata : Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata
    {
        public DefaultModelMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider provider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider detailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails details) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity)) { }
        public DefaultModelMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider provider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider detailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails details, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelBindingMessageProvider modelBindingMessageProvider) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity)) { }
        public override System.Collections.Generic.IReadOnlyDictionary<object, object> AdditionalValues { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes Attributes { get { throw null; } }
        public override string BinderModelName { get { throw null; } }
        public override System.Type BinderType { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadata BindingMetadata { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource BindingSource { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ContainerMetadata { get { throw null; } }
        public override bool ConvertEmptyStringToNull { get { throw null; } }
        public override string DataTypeName { get { throw null; } }
        public override string Description { get { throw null; } }
        public override string DisplayFormatString { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DisplayMetadata DisplayMetadata { get { throw null; } }
        public override string DisplayName { get { throw null; } }
        public override string EditFormatString { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata ElementMetadata { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.AspNetCore.Mvc.ModelBinding.EnumGroupAndName, string>> EnumGroupedDisplayNamesAndValues { get { throw null; } }
        public override System.Collections.Generic.IReadOnlyDictionary<string, string> EnumNamesAndValues { get { throw null; } }
        public override bool HasNonDefaultEditFormat { get { throw null; } }
        public override bool? HasValidators { get { throw null; } }
        public override bool HideSurroundingHtml { get { throw null; } }
        public override bool HtmlEncode { get { throw null; } }
        public override bool IsBindingAllowed { get { throw null; } }
        public override bool IsBindingRequired { get { throw null; } }
        public override bool IsEnum { get { throw null; } }
        public override bool IsFlagsEnum { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsRequired { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelBindingMessageProvider ModelBindingMessageProvider { get { throw null; } }
        public override string NullDisplayText { get { throw null; } }
        public override int Order { get { throw null; } }
        public override string Placeholder { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelPropertyCollection Properties { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.IPropertyFilterProvider PropertyFilterProvider { get { throw null; } }
        public override System.Func<object, object> PropertyGetter { get { throw null; } }
        public override System.Action<object, object> PropertySetter { get { throw null; } }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IPropertyValidationFilter PropertyValidationFilter { get { throw null; } }
        public override bool ShowForDisplay { get { throw null; } }
        public override bool ShowForEdit { get { throw null; } }
        public override string SimpleDisplayProperty { get { throw null; } }
        public override string TemplateHint { get { throw null; } }
        public override bool ValidateChildren { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadata ValidationMetadata { get { throw null; } }
        public override System.Collections.Generic.IReadOnlyList<object> ValidatorMetadata { get { throw null; } }
        internal static bool CalculateHasValidators(System.Collections.Generic.HashSet<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelMetadata> visited, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata) { throw null; }
        public override System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> GetMetadataForProperties(System.Type modelType) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForType(System.Type modelType) { throw null; }
    }
    public partial class DefaultModelMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadataProvider
    {
        public DefaultModelMetadataProvider(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider detailsProvider) { }
        public DefaultModelMetadataProvider(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider detailsProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> optionsAccessor) { }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider DetailsProvider { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelBindingMessageProvider ModelBindingMessageProvider { get { throw null; } }
        protected virtual Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata CreateModelMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails entry) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails CreateParameterDetails(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails[] CreatePropertyDetails(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key) { throw null; }
        protected virtual Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultMetadataDetails CreateTypeDetails(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForParameter(System.Reflection.ParameterInfo parameter) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForParameter(System.Reflection.ParameterInfo parameter, System.Type modelType) { throw null; }
        public override System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata> GetMetadataForProperties(System.Type modelType) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForProperty(System.Reflection.PropertyInfo propertyInfo, System.Type modelType) { throw null; }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata GetMetadataForType(System.Type modelType) { throw null; }
    }
    internal partial class DefaultValidationMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
        public DefaultValidationMetadataProvider() { }
        public void CreateValidationMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadataProviderContext context) { }
    }
    public partial class DisplayMetadata
    {
        public DisplayMetadata() { }
        public System.Collections.Generic.IDictionary<object, object> AdditionalValues { get { throw null; } }
        public bool ConvertEmptyStringToNull { get { throw null; } set { } }
        public string DataTypeName { get { throw null; } set { } }
        public System.Func<string> Description { get { throw null; } set { } }
        public string DisplayFormatString { get { throw null; } set { } }
        public System.Func<string> DisplayFormatStringProvider { get { throw null; } set { } }
        public System.Func<string> DisplayName { get { throw null; } set { } }
        public string EditFormatString { get { throw null; } set { } }
        public System.Func<string> EditFormatStringProvider { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.AspNetCore.Mvc.ModelBinding.EnumGroupAndName, string>> EnumGroupedDisplayNamesAndValues { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> EnumNamesAndValues { get { throw null; } set { } }
        public bool HasNonDefaultEditFormat { get { throw null; } set { } }
        public bool HideSurroundingHtml { get { throw null; } set { } }
        public bool HtmlEncode { get { throw null; } set { } }
        public bool IsEnum { get { throw null; } set { } }
        public bool IsFlagsEnum { get { throw null; } set { } }
        public string NullDisplayText { get { throw null; } set { } }
        public System.Func<string> NullDisplayTextProvider { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public System.Func<string> Placeholder { get { throw null; } set { } }
        public bool ShowForDisplay { get { throw null; } set { } }
        public bool ShowForEdit { get { throw null; } set { } }
        public string SimpleDisplayProperty { get { throw null; } set { } }
        public string TemplateHint { get { throw null; } set { } }
    }
    public partial class DisplayMetadataProviderContext
    {
        public DisplayMetadataProviderContext(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key, Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes attributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DisplayMetadata DisplayMetadata { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity Key { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> PropertyAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> TypeAttributes { get { throw null; } }
    }
    public partial class ExcludeBindingMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IBindingMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        public ExcludeBindingMetadataProvider(System.Type type) { }
        public void CreateBindingMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadataProviderContext context) { }
    }
    public partial interface IBindingMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        void CreateBindingMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.BindingMetadataProviderContext context);
    }
    public partial interface ICompositeMetadataDetailsProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IBindingMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IDisplayMetadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
    }
    public partial interface IDisplayMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        void CreateDisplayMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DisplayMetadataProviderContext context);
    }
    public partial interface IMetadataDetailsProvider
    {
    }
    public partial interface IValidationMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider
    {
        void CreateValidationMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadataProviderContext context);
    }
    public static partial class MetadataDetailsProviderExtensions
    {
        public static void RemoveType(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider> list, System.Type type) { }
        public static void RemoveType<TMetadataDetailsProvider>(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider> list) where TMetadataDetailsProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider { }
    }
    public partial class ValidationMetadata
    {
        public ValidationMetadata() { }
        public bool? HasValidators { get { throw null; } set { } }
        public bool? IsRequired { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IPropertyValidationFilter PropertyValidationFilter { get { throw null; } set { } }
        public bool? ValidateChildren { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> ValidatorMetadata { get { throw null; } }
    }
    public partial class ValidationMetadataProviderContext
    {
        public ValidationMetadataProviderContext(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity key, Microsoft.AspNetCore.Mvc.ModelBinding.ModelAttributes attributes) { }
        public System.Collections.Generic.IReadOnlyList<object> Attributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ModelMetadataIdentity Key { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> ParameterAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> PropertyAttributes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> TypeAttributes { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadata ValidationMetadata { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Mvc.ModelBinding.Validation
{
    public partial class ClientValidatorCache
    {
        public ClientValidatorCache() { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidator> GetValidators(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidatorProvider validatorProvider) { throw null; }
    }
    public partial class CompositeClientModelValidatorProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidatorProvider
    {
        public CompositeClientModelValidatorProvider(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidatorProvider> providers) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IClientModelValidatorProvider> ValidatorProviders { get { throw null; } }
        public void CreateValidators(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorProviderContext context) { }
    }
    public partial class CompositeModelValidatorProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider
    {
        public CompositeModelValidatorProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> providers) { }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> ValidatorProviders { get { throw null; } }
        public void CreateValidators(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidatorProviderContext context) { }
    }
    internal partial class DefaultCollectionValidationStrategy : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy
    {
        private DefaultCollectionValidationStrategy() { }
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.Validation.DefaultCollectionValidationStrategy Instance;
        public System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry> GetChildren(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
        public System.Collections.IEnumerator GetEnumeratorForElementType(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object model) { throw null; }
    }
    internal partial class DefaultComplexObjectValidationStrategy : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy
    {
        private DefaultComplexObjectValidationStrategy() { }
        public static readonly Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy Instance;
        public System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry> GetChildren(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
    }
    internal partial class DefaultModelValidatorProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IMetadataBasedModelValidatorProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider
    {
        public DefaultModelValidatorProvider() { }
        public void CreateValidators(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ModelValidatorProviderContext context) { }
        public bool HasValidators(System.Type modelType, System.Collections.Generic.IList<object> validatorMetadata) { throw null; }
    }
    internal partial class DefaultObjectValidator : Microsoft.AspNetCore.Mvc.ModelBinding.ObjectModelValidator
    {
        public DefaultObjectValidator(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> validatorProviders, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) : base (default(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), default(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider>)) { }
        public override Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationVisitor GetValidationVisitor(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider validatorProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorCache validatorCache, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState) { throw null; }
    }
    internal partial class ExplicitIndexCollectionValidationStrategy : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy
    {
        public ExplicitIndexCollectionValidationStrategy(System.Collections.Generic.IEnumerable<string> elementKeys) { }
        public System.Collections.Generic.IEnumerable<string> ElementKeys { get { throw null; } }
        public System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry> GetChildren(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
    }
    internal partial class HasValidatorsValidationMetadataProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IMetadataDetailsProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
        public HasValidatorsValidationMetadataProvider(System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> modelValidatorProviders) { }
        public void CreateValidationMetadata(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ValidationMetadataProviderContext context) { }
    }
    public partial interface IMetadataBasedModelValidatorProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider
    {
        bool HasValidators(System.Type modelType, System.Collections.Generic.IList<object> validatorMetadata);
    }
    public partial interface IObjectModelValidator
    {
        void Validate(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState, string prefix, object model);
    }
    public static partial class ModelValidatorProviderExtensions
    {
        public static void RemoveType(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> list, System.Type type) { }
        public static void RemoveType<TModelValidatorProvider>(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider> list) where TModelValidatorProvider : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider { }
    }
    internal partial class ShortFormDictionaryValidationStrategy<TKey, TValue> : Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy
    {
        public ShortFormDictionaryValidationStrategy(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, TKey>> keyMappings, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata valueMetadata) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, TKey>> KeyMappings { get { throw null; } }
        public System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry> GetChildren(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class ValidateNeverAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IPropertyValidationFilter
    {
        public ValidateNeverAttribute() { }
        public bool ShouldValidateEntry(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry entry, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationEntry parentEntry) { throw null; }
    }
    internal partial class ValidationStack
    {
        internal const int CutOff = 20;
        public ValidationStack() { }
        public int Count { get { throw null; } }
        internal System.Collections.Generic.HashSet<object> HashSet { get { throw null; } set { } }
        internal System.Collections.Generic.List<object> List { get { throw null; } }
        public void Pop(object model) { }
        public bool Push(object model) { throw null; }
    }
    public partial class ValidationVisitor
    {
        public ValidationVisitor(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider validatorProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorCache validatorCache, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary validationState) { }
        [System.ObsoleteAttribute("This property is deprecated and is no longer used by the runtime.")]
        public bool AllowShortCircuitingValidationWhenNoValidatorsArePresent { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidatorCache Cache { get { throw null; } }
        protected object Container { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ActionContext Context { get { throw null; } }
        protected string Key { get { throw null; } set { } }
        public int? MaxValidationDepth { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata Metadata { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } }
        protected object Model { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary ModelState { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy Strategy { get { throw null; } set { } }
        public bool ValidateComplexTypesIfChildValidationFails { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateDictionary ValidationState { get { throw null; } }
        protected Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider ValidatorProvider { get { throw null; } }
        protected virtual Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationStateEntry GetValidationEntry(object model) { throw null; }
        protected virtual void SuppressValidation(string key) { }
        public bool Validate(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
        public virtual bool Validate(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model, bool alwaysValidateAtTopLevel) { throw null; }
        protected virtual bool ValidateNode() { throw null; }
        protected virtual bool Visit(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, string key, object model) { throw null; }
        protected virtual bool VisitChildren(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy strategy) { throw null; }
        protected virtual bool VisitComplexType(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy defaultStrategy) { throw null; }
        protected virtual bool VisitSimpleType() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        protected readonly partial struct StateManager : System.IDisposable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public StateManager(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationVisitor visitor, object newModel) { throw null; }
            public void Dispose() { }
            public static Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationVisitor.StateManager Recurse(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidationVisitor visitor, string key, Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, object model, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IValidationStrategy strategy) { throw null; }
        }
    }
    public partial class ValidatorCache
    {
        public ValidatorCache() { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidator> GetValidators(Microsoft.AspNetCore.Mvc.ModelBinding.ModelMetadata metadata, Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IModelValidatorProvider validatorProvider) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.Routing
{
    internal partial class ActionConstraintMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy
    {
        internal static readonly Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor NonAction;
        public ActionConstraintMatcherPolicy(Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintCache actionConstraintCache) { }
        public override int Order { get { throw null; } }
        public bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidateSet) { throw null; }
    }
    internal abstract partial class ActionEndpointDataSourceBase : Microsoft.AspNetCore.Routing.EndpointDataSource, System.IDisposable
    {
        protected readonly System.Collections.Generic.List<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> Conventions;
        protected readonly object Lock;
        public ActionEndpointDataSourceBase(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actions) { }
        public override System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> Endpoints { get { throw null; } }
        protected abstract System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> CreateEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> actions, System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions);
        public void Dispose() { }
        public override Microsoft.Extensions.Primitives.IChangeToken GetChangeToken() { throw null; }
        protected void Subscribe() { }
    }
    internal partial class ActionEndpointFactory
    {
        public ActionEndpointFactory(Microsoft.AspNetCore.Routing.Patterns.RoutePatternTransformer routePatternTransformer) { }
        public void AddConventionalLinkGenerationRoute(System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> endpoints, System.Collections.Generic.HashSet<string> routeNames, System.Collections.Generic.HashSet<string> keys, Microsoft.AspNetCore.Mvc.Routing.ConventionalRouteEntry route, System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { }
        public void AddEndpoints(System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> endpoints, System.Collections.Generic.HashSet<string> routeNames, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Routing.ConventionalRouteEntry> routes, System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions, bool createInertEndpoints) { }
    }
    internal partial class AttributeRoute : Microsoft.AspNetCore.Routing.IRouter
    {
        public AttributeRoute(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, System.IServiceProvider services, System.Func<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor[], Microsoft.AspNetCore.Routing.IRouter> handlerFactory) { }
        internal void AddEntries(Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder builder, Microsoft.AspNetCore.Mvc.Infrastructure.ActionDescriptorCollection actions) { }
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    internal static partial class AttributeRouting
    {
        public static Microsoft.AspNetCore.Routing.IRouter CreateAttributeMegaRoute(System.IServiceProvider services) { throw null; }
    }
    internal partial class ConsumesMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy, Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy
    {
        internal const string AnyContentType = "*/*";
        internal const string Http415EndpointDisplayName = "415 HTTP Unsupported Media Type";
        public ConsumesMatcherPolicy() { }
        public System.Collections.Generic.IComparer<Microsoft.AspNetCore.Http.Endpoint> Comparer { get { throw null; } }
        public override int Order { get { throw null; } }
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
        public Microsoft.AspNetCore.Routing.Matching.PolicyJumpTable BuildJumpTable(int exitDestination, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyJumpTableEdge> edges) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Matching.PolicyNodeEdge> GetEdges(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        bool Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy.AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
    }
    internal partial class ConsumesMetadata : Microsoft.AspNetCore.Mvc.Routing.IConsumesMetadata
    {
        public ConsumesMetadata(string[] contentTypes) { }
        public System.Collections.Generic.IReadOnlyList<string> ContentTypes { get { throw null; } }
    }
    internal partial class ControllerActionEndpointDataSource : Microsoft.AspNetCore.Mvc.Routing.ActionEndpointDataSourceBase
    {
        public ControllerActionEndpointDataSource(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actions, Microsoft.AspNetCore.Mvc.Routing.ActionEndpointFactory endpointFactory) : base (default(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)) { }
        public bool CreateInertEndpoints { get { throw null; } set { } }
        public Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder DefaultBuilder { get { throw null; } }
        public Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder AddRoute(string routeName, string pattern, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IDictionary<string, object> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary dataTokens) { throw null; }
        protected override System.Collections.Generic.List<Microsoft.AspNetCore.Http.Endpoint> CreateEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor> actions, System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ConventionalRouteEntry
    {
        public readonly System.Collections.Generic.IReadOnlyList<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> Conventions;
        public readonly Microsoft.AspNetCore.Routing.RouteValueDictionary DataTokens;
        public readonly int Order;
        public readonly Microsoft.AspNetCore.Routing.Patterns.RoutePattern Pattern;
        public readonly string RouteName;
        public ConventionalRouteEntry(string routeName, string pattern, Microsoft.AspNetCore.Routing.RouteValueDictionary defaults, System.Collections.Generic.IDictionary<string, object> constraints, Microsoft.AspNetCore.Routing.RouteValueDictionary dataTokens, int order, System.Collections.Generic.List<System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder>> conventions) { throw null; }
    }
    internal partial class DynamicControllerEndpointMatcherPolicy : Microsoft.AspNetCore.Routing.MatcherPolicy, Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy
    {
        public DynamicControllerEndpointMatcherPolicy(Microsoft.AspNetCore.Mvc.Routing.DynamicControllerEndpointSelector selector, Microsoft.AspNetCore.Routing.Matching.EndpointMetadataComparer comparer) { }
        public override int Order { get { throw null; } }
        public bool AppliesToEndpoints(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> endpoints) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ApplyAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.Matching.CandidateSet candidates) { throw null; }
    }
    internal partial class DynamicControllerEndpointSelector : System.IDisposable
    {
        public DynamicControllerEndpointSelector(Microsoft.AspNetCore.Mvc.Routing.ControllerActionEndpointDataSource dataSource) { }
        protected DynamicControllerEndpointSelector(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource) { }
        public void Dispose() { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint> SelectEndpoints(Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
    }
    internal partial class DynamicControllerMetadata : Microsoft.AspNetCore.Routing.IDynamicEndpointMetadata
    {
        public DynamicControllerMetadata(Microsoft.AspNetCore.Routing.RouteValueDictionary values) { }
        public bool IsDynamic { get { throw null; } }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary Values { get { throw null; } }
    }
    internal partial class DynamicControllerRouteValueTransformerMetadata : Microsoft.AspNetCore.Routing.IDynamicEndpointMetadata
    {
        public DynamicControllerRouteValueTransformerMetadata(System.Type selectorType) { }
        public bool IsDynamic { get { throw null; } }
        public System.Type SelectorType { get { throw null; } }
    }
    public abstract partial class DynamicRouteValueTransformer
    {
        protected DynamicRouteValueTransformer() { }
        public abstract System.Threading.Tasks.ValueTask<Microsoft.AspNetCore.Routing.RouteValueDictionary> TransformAsync(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.RouteValueDictionary values);
    }
    internal partial class EndpointRoutingUrlHelper : Microsoft.AspNetCore.Mvc.Routing.UrlHelperBase
    {
        public EndpointRoutingUrlHelper(Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Routing.LinkGenerator linkGenerator, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Routing.EndpointRoutingUrlHelper> logger) : base (default(Microsoft.AspNetCore.Mvc.ActionContext)) { }
        public override string Action(Microsoft.AspNetCore.Mvc.Routing.UrlActionContext urlActionContext) { throw null; }
        public override string RouteUrl(Microsoft.AspNetCore.Mvc.Routing.UrlRouteContext routeContext) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public abstract partial class HttpMethodAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Routing.IActionHttpMethodProvider, Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider
    {
        public HttpMethodAttribute(System.Collections.Generic.IEnumerable<string> httpMethods) { }
        public HttpMethodAttribute(System.Collections.Generic.IEnumerable<string> httpMethods, string template) { }
        public System.Collections.Generic.IEnumerable<string> HttpMethods { get { throw null; } }
        int? Microsoft.AspNetCore.Mvc.Routing.IRouteTemplateProvider.Order { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public string Template { get { throw null; } }
    }
    public partial interface IActionHttpMethodProvider
    {
        System.Collections.Generic.IEnumerable<string> HttpMethods { get; }
    }
    internal partial interface IConsumesMetadata
    {
        System.Collections.Generic.IReadOnlyList<string> ContentTypes { get; }
    }
    public partial interface IRouteTemplateProvider
    {
        string Name { get; }
        int? Order { get; }
        string Template { get; }
    }
    public partial interface IRouteValueProvider
    {
        string RouteKey { get; }
        string RouteValue { get; }
    }
    public partial interface IUrlHelperFactory
    {
        Microsoft.AspNetCore.Mvc.IUrlHelper GetUrlHelper(Microsoft.AspNetCore.Mvc.ActionContext context);
    }
    public partial class KnownRouteValueConstraint : Microsoft.AspNetCore.Routing.IParameterPolicy, Microsoft.AspNetCore.Routing.IRouteConstraint
    {
        public KnownRouteValueConstraint(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actionDescriptorCollectionProvider) { }
        public bool Match(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.AspNetCore.Routing.IRouter route, string routeKey, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteDirection routeDirection) { throw null; }
    }
    internal partial class MvcAttributeRouteHandler : Microsoft.AspNetCore.Routing.IRouter
    {
        public MvcAttributeRouteHandler(Microsoft.AspNetCore.Mvc.Infrastructure.IActionInvokerFactory actionInvokerFactory, Microsoft.AspNetCore.Mvc.Infrastructure.IActionSelector actionSelector, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor[] Actions { get { throw null; } set { } }
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    internal partial class MvcRouteHandler : Microsoft.AspNetCore.Routing.IRouter
    {
        public MvcRouteHandler(Microsoft.AspNetCore.Mvc.Infrastructure.IActionInvokerFactory actionInvokerFactory, Microsoft.AspNetCore.Mvc.Infrastructure.IActionSelector actionSelector, System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    internal static partial class NormalizedRouteValue
    {
        public static string GetNormalizedRouteValue(Microsoft.AspNetCore.Mvc.ActionContext context, string key) { throw null; }
    }
    internal partial class NullRouter : Microsoft.AspNetCore.Routing.IRouter
    {
        private NullRouter() { }
        public static Microsoft.AspNetCore.Routing.IRouter Instance;
        public Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPath(Microsoft.AspNetCore.Routing.VirtualPathContext context) { throw null; }
        public System.Threading.Tasks.Task RouteAsync(Microsoft.AspNetCore.Routing.RouteContext context) { throw null; }
    }
    internal static partial class RoutePatternWriter
    {
        public static void WriteString(System.Text.StringBuilder sb, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment> routeSegments) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public abstract partial class RouteValueAttribute : System.Attribute, Microsoft.AspNetCore.Mvc.Routing.IRouteValueProvider
    {
        protected RouteValueAttribute(string routeKey, string routeValue) { }
        public string RouteKey { get { throw null; } }
        public string RouteValue { get { throw null; } }
    }
    public partial class UrlHelper : Microsoft.AspNetCore.Mvc.Routing.UrlHelperBase
    {
        public UrlHelper(Microsoft.AspNetCore.Mvc.ActionContext actionContext) : base (default(Microsoft.AspNetCore.Mvc.ActionContext)) { }
        protected Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        protected Microsoft.AspNetCore.Routing.IRouter Router { get { throw null; } }
        public override string Action(Microsoft.AspNetCore.Mvc.Routing.UrlActionContext actionContext) { throw null; }
        protected virtual string GenerateUrl(string protocol, string host, Microsoft.AspNetCore.Routing.VirtualPathData pathData, string fragment) { throw null; }
        protected virtual Microsoft.AspNetCore.Routing.VirtualPathData GetVirtualPathData(string routeName, Microsoft.AspNetCore.Routing.RouteValueDictionary values) { throw null; }
        public override string RouteUrl(Microsoft.AspNetCore.Mvc.Routing.UrlRouteContext routeContext) { throw null; }
    }
    public abstract partial class UrlHelperBase : Microsoft.AspNetCore.Mvc.IUrlHelper
    {
        protected UrlHelperBase(Microsoft.AspNetCore.Mvc.ActionContext actionContext) { }
        public Microsoft.AspNetCore.Mvc.ActionContext ActionContext { get { throw null; } }
        protected Microsoft.AspNetCore.Routing.RouteValueDictionary AmbientValues { get { throw null; } }
        public abstract string Action(Microsoft.AspNetCore.Mvc.Routing.UrlActionContext actionContext);
        internal static void AppendPathAndFragment(System.Text.StringBuilder builder, Microsoft.AspNetCore.Http.PathString pathBase, string virtualPath, string fragment) { }
        public virtual string Content(string contentPath) { throw null; }
        protected string GenerateUrl(string protocol, string host, string path) { throw null; }
        protected string GenerateUrl(string protocol, string host, string virtualPath, string fragment) { throw null; }
        protected Microsoft.AspNetCore.Routing.RouteValueDictionary GetValuesDictionary(object values) { throw null; }
        public virtual bool IsLocalUrl(string url) { throw null; }
        public virtual string Link(string routeName, object values) { throw null; }
        internal static void NormalizeRouteValuesForAction(string action, string controller, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues) { }
        internal static void NormalizeRouteValuesForPage(Microsoft.AspNetCore.Mvc.ActionContext context, string page, string handler, Microsoft.AspNetCore.Routing.RouteValueDictionary values, Microsoft.AspNetCore.Routing.RouteValueDictionary ambientValues) { }
        public abstract string RouteUrl(Microsoft.AspNetCore.Mvc.Routing.UrlRouteContext routeContext);
    }
    public partial class UrlHelperFactory : Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory
    {
        public UrlHelperFactory() { }
        public Microsoft.AspNetCore.Mvc.IUrlHelper GetUrlHelper(Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    internal static partial class ViewEnginePath
    {
        public static readonly char[] PathSeparators;
        public static string CombinePath(string first, string second) { throw null; }
        public static string ResolvePath(string path) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
    public partial interface IKeepTempDataResult : Microsoft.AspNetCore.Mvc.IActionResult
    {
    }
}
namespace Microsoft.AspNetCore.Routing
{
    public static partial class ControllerLinkGeneratorExtensions
    {
        public static string GetPathByAction(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string action = null, string controller = null, object values = null, Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetPathByAction(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string action, string controller, object values = null, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByAction(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string action = null, string controller = null, object values = null, string scheme = null, Microsoft.AspNetCore.Http.HostString? host = default(Microsoft.AspNetCore.Http.HostString?), Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByAction(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string action, string controller, object values, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
    }
    internal sealed partial class DataSourceDependentCache<T> : System.IDisposable where T : class
    {
        public DataSourceDependentCache(Microsoft.AspNetCore.Routing.EndpointDataSource dataSource, System.Func<System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.Endpoint>, T> initialize) { }
        public T Value { get { throw null; } }
        public void Dispose() { }
        public T EnsureInitialized() { throw null; }
    }
    public static partial class PageLinkGeneratorExtensions
    {
        public static string GetPathByPage(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string page = null, string handler = null, object values = null, Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetPathByPage(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string page, string handler = null, object values = null, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByPage(this Microsoft.AspNetCore.Routing.LinkGenerator generator, Microsoft.AspNetCore.Http.HttpContext httpContext, string page = null, string handler = null, object values = null, string scheme = null, Microsoft.AspNetCore.Http.HostString? host = default(Microsoft.AspNetCore.Http.HostString?), Microsoft.AspNetCore.Http.PathString? pathBase = default(Microsoft.AspNetCore.Http.PathString?), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
        public static string GetUriByPage(this Microsoft.AspNetCore.Routing.LinkGenerator generator, string page, string handler, object values, string scheme, Microsoft.AspNetCore.Http.HostString host, Microsoft.AspNetCore.Http.PathString pathBase = default(Microsoft.AspNetCore.Http.PathString), Microsoft.AspNetCore.Http.FragmentString fragment = default(Microsoft.AspNetCore.Http.FragmentString), Microsoft.AspNetCore.Routing.LinkOptions options = null) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    internal partial class ApiBehaviorOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions>
    {
        public ApiBehaviorOptionsSetup() { }
        public void Configure(Microsoft.AspNetCore.Mvc.ApiBehaviorOptions options) { }
        internal static void ConfigureClientErrorMapping(Microsoft.AspNetCore.Mvc.ApiBehaviorOptions options) { }
        internal static Microsoft.AspNetCore.Mvc.IActionResult ProblemDetailsInvalidModelStateResponse(Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsFactory problemDetailsFactory, Microsoft.AspNetCore.Mvc.ActionContext context) { throw null; }
    }
    public static partial class ApplicationModelConventionExtensions
    {
        public static void Add(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.IActionModelConvention actionModelConvention) { }
        public static void Add(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.IControllerModelConvention controllerModelConvention) { }
        public static void Add(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.IParameterModelBaseConvention parameterModelConvention) { }
        public static void Add(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> conventions, Microsoft.AspNetCore.Mvc.ApplicationModels.IParameterModelConvention parameterModelConvention) { }
        public static void RemoveType(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> list, System.Type type) { }
        public static void RemoveType<TApplicationModelConvention>(this System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention> list) where TApplicationModelConvention : Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention { }
    }
    public partial interface IMvcBuilder
    {
        Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager PartManager { get; }
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
    public partial interface IMvcCoreBuilder
    {
        Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager PartManager { get; }
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
    internal partial class MvcBuilder : Microsoft.Extensions.DependencyInjection.IMvcBuilder
    {
        public MvcBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager manager) { }
        public Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager PartManager { get { throw null; } }
        public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get { throw null; } }
    }
    internal partial class MvcCoreBuilder : Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder
    {
        public MvcCoreBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager manager) { }
        public Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager PartManager { get { throw null; } }
        public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get { throw null; } }
    }
    public static partial class MvcCoreMvcBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddApplicationPart(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Reflection.Assembly assembly) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddControllersAsServices(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddFormatterMappings(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.Formatters.FormatterMappings> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddJsonOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.JsonOptions> configure) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddMvcOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.MvcOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder ConfigureApiBehaviorOptions(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder ConfigureApplicationPartManager(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder SetCompatibilityVersion(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, Microsoft.AspNetCore.Mvc.CompatibilityVersion version) { throw null; }
    }
    public static partial class MvcCoreMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddApplicationPart(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Reflection.Assembly assembly) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddAuthorization(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddAuthorization(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Authorization.AuthorizationOptions> setupAction) { throw null; }
        internal static void AddAuthorizationServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddControllersAsServices(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddFormatterMappings(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddFormatterMappings(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.Formatters.FormatterMappings> setupAction) { throw null; }
        internal static void AddFormatterMappingsServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddJsonOptions(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.JsonOptions> configure) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddMvcOptions(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.MvcOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder ConfigureApiBehaviorOptions(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder ConfigureApplicationPartManager(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager> setupAction) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder SetCompatibilityVersion(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, Microsoft.AspNetCore.Mvc.CompatibilityVersion version) { throw null; }
    }
    internal partial class MvcCoreRouteOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Routing.RouteOptions>
    {
        public MvcCoreRouteOptionsSetup() { }
        public void Configure(Microsoft.AspNetCore.Routing.RouteOptions options) { }
    }
    public static partial class MvcCoreServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddMvcCore(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddMvcCore(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Mvc.MvcOptions> setupAction) { throw null; }
        internal static void AddMvcCoreServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
    }
    internal partial class MvcMarkerService
    {
        public MvcMarkerService() { }
    }
}
namespace Microsoft.Extensions.Internal
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct AwaitableInfo
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AwaitableInfo(System.Type awaiterType, System.Reflection.PropertyInfo awaiterIsCompletedProperty, System.Reflection.MethodInfo awaiterGetResultMethod, System.Reflection.MethodInfo awaiterOnCompletedMethod, System.Reflection.MethodInfo awaiterUnsafeOnCompletedMethod, System.Type resultType, System.Reflection.MethodInfo getAwaiterMethod) { throw null; }
        public System.Reflection.MethodInfo AwaiterGetResultMethod { get { throw null; } }
        public System.Reflection.PropertyInfo AwaiterIsCompletedProperty { get { throw null; } }
        public System.Reflection.MethodInfo AwaiterOnCompletedMethod { get { throw null; } }
        public System.Type AwaiterType { get { throw null; } }
        public System.Reflection.MethodInfo AwaiterUnsafeOnCompletedMethod { get { throw null; } }
        public System.Reflection.MethodInfo GetAwaiterMethod { get { throw null; } }
        public System.Type ResultType { get { throw null; } }
        public static bool IsTypeAwaitable(System.Type type, out Microsoft.Extensions.Internal.AwaitableInfo awaitableInfo) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CoercedAwaitableInfo
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CoercedAwaitableInfo(Microsoft.Extensions.Internal.AwaitableInfo awaitableInfo) { throw null; }
        public CoercedAwaitableInfo(System.Linq.Expressions.Expression coercerExpression, System.Type coercerResultType, Microsoft.Extensions.Internal.AwaitableInfo coercedAwaitableInfo) { throw null; }
        public Microsoft.Extensions.Internal.AwaitableInfo AwaitableInfo { get { throw null; } }
        public System.Linq.Expressions.Expression CoercerExpression { get { throw null; } }
        public System.Type CoercerResultType { get { throw null; } }
        public bool RequiresCoercion { get { throw null; } }
        public static bool IsTypeAwaitable(System.Type type, out Microsoft.Extensions.Internal.CoercedAwaitableInfo info) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct CopyOnWriteDictionaryHolder<TKey, TValue>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public CopyOnWriteDictionaryHolder(Microsoft.Extensions.Internal.CopyOnWriteDictionaryHolder<TKey, TValue> source) { throw null; }
        public CopyOnWriteDictionaryHolder(System.Collections.Generic.Dictionary<TKey, TValue> source) { throw null; }
        public int Count { get { throw null; } }
        public bool HasBeenCopied { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public TValue this[TKey key] { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection Keys { get { throw null; } }
        public System.Collections.Generic.Dictionary<TKey, TValue> ReadDictionary { get { throw null; } }
        public System.Collections.Generic.Dictionary<TKey, TValue>.ValueCollection Values { get { throw null; } }
        public System.Collections.Generic.Dictionary<TKey, TValue> WriteDictionary { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        public bool ContainsKey(TKey key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        public System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        public bool Remove(TKey key) { throw null; }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
    }
    internal partial class CopyOnWriteDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    {
        public CopyOnWriteDictionary(System.Collections.Generic.IDictionary<TKey, TValue> sourceDictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual TValue this[TKey key] { get { throw null; } set { } }
        public virtual System.Collections.Generic.ICollection<TKey> Keys { get { throw null; } }
        public virtual System.Collections.Generic.ICollection<TValue> Values { get { throw null; } }
        public virtual void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public virtual void Add(TKey key, TValue value) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        public virtual bool ContainsKey(TKey key) { throw null; }
        public virtual void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        public virtual bool Remove(TKey key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public virtual bool TryGetValue(TKey key, out TValue value) { throw null; }
    }
    internal partial class ObjectMethodExecutor
    {
        private ObjectMethodExecutor() { }
        public System.Type AsyncResultType { get { throw null; } }
        public bool IsMethodAsync { get { throw null; } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public System.Reflection.ParameterInfo[] MethodParameters { get { throw null; } }
        public System.Type MethodReturnType { get { throw null; } internal set { } }
        public System.Reflection.TypeInfo TargetTypeInfo { get { throw null; } }
        public static Microsoft.Extensions.Internal.ObjectMethodExecutor Create(System.Reflection.MethodInfo methodInfo, System.Reflection.TypeInfo targetTypeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.ObjectMethodExecutor Create(System.Reflection.MethodInfo methodInfo, System.Reflection.TypeInfo targetTypeInfo, object[] parameterDefaultValues) { throw null; }
        public object Execute(object target, object[] parameters) { throw null; }
        public Microsoft.Extensions.Internal.ObjectMethodExecutorAwaitable ExecuteAsync(object target, object[] parameters) { throw null; }
        public object GetDefaultValueForParameter(int index) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ObjectMethodExecutorAwaitable
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ObjectMethodExecutorAwaitable(object customAwaitable, System.Func<object, object> getAwaiterMethod, System.Func<object, bool> isCompletedMethod, System.Func<object, object> getResultMethod, System.Action<object, System.Action> onCompletedMethod, System.Action<object, System.Action> unsafeOnCompletedMethod) { throw null; }
        public Microsoft.Extensions.Internal.ObjectMethodExecutorAwaitable.Awaiter GetAwaiter() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public Awaiter(object customAwaiter, System.Func<object, bool> isCompletedMethod, System.Func<object, object> getResultMethod, System.Action<object, System.Action> onCompletedMethod, System.Action<object, System.Action> unsafeOnCompletedMethod) { throw null; }
            public bool IsCompleted { get { throw null; } }
            public object GetResult() { throw null; }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    internal static partial class ObjectMethodExecutorFSharpSupport
    {
        public static bool TryBuildCoercerFromFSharpAsyncToAwaitable(System.Type possibleFSharpAsyncType, out System.Linq.Expressions.Expression coerceToAwaitableExpression, out System.Type awaitableType) { throw null; }
    }
    internal partial class ParameterDefaultValue
    {
        public ParameterDefaultValue() { }
        public static bool TryGetDefaultValue(System.Reflection.ParameterInfo parameter, out object defaultValue) { throw null; }
    }
    internal partial class PropertyActivator<TContext>
    {
        public PropertyActivator(System.Reflection.PropertyInfo propertyInfo, System.Func<TContext, object> valueAccessor) { }
        public System.Reflection.PropertyInfo PropertyInfo { get { throw null; } }
        public object Activate(object instance, TContext context) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyActivator<TContext>[] GetPropertiesToActivate(System.Type type, System.Type activateAttributeType, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyActivator<TContext>> createActivateInfo) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyActivator<TContext>[] GetPropertiesToActivate(System.Type type, System.Type activateAttributeType, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyActivator<TContext>> createActivateInfo, bool includeNonPublic) { throw null; }
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
    internal static partial class SecurityHelper
    {
        public static System.Security.Claims.ClaimsPrincipal MergeUserPrincipal(System.Security.Claims.ClaimsPrincipal existingPrincipal, System.Security.Claims.ClaimsPrincipal additionalPrincipal) { throw null; }
    }
    internal partial class TypeNameHelper
    {
        public TypeNameHelper() { }
        public static string GetTypeDisplayName(object item, bool fullName = true) { throw null; }
        public static string GetTypeDisplayName(System.Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+') { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ValueStopwatch
    {
        private int _dummyPrimitive;
        public bool IsActive { get { throw null; } }
        public System.TimeSpan GetElapsedTime() { throw null; }
        public static Microsoft.Extensions.Internal.ValueStopwatch StartNew() { throw null; }
    }
}
namespace System.Text.Json
{
    internal static partial class JsonSerializerOptionsCopyConstructor
    {
        public static System.Text.Json.JsonSerializerOptions Copy(this System.Text.Json.JsonSerializerOptions serializerOptions, System.Text.Encodings.Web.JavaScriptEncoder encoder) { throw null; }
    }
}
