// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.ApiExplorer
{
    public static partial class ApiDescriptionExtensions
    {
        public static T GetProperty<T>(this Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescription apiDescription) { throw null; }
        public static void SetProperty<T>(this Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescription apiDescription, T value) { }
    }
    public partial class ApiDescriptionGroup
    {
        public ApiDescriptionGroup(string groupName, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescription> items) { }
        public string GroupName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescription> Items { get { throw null; } }
    }
    public partial class ApiDescriptionGroupCollection
    {
        public ApiDescriptionGroupCollection(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroup> items, int version) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroup> Items { get { throw null; } }
        public int Version { get { throw null; } }
    }
    public partial class ApiDescriptionGroupCollectionProvider : Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionGroupCollectionProvider
    {
        public ApiDescriptionGroupCollectionProvider(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider> apiDescriptionProviders) { }
        public Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroupCollection ApiDescriptionGroups { get { throw null; } }
    }
    internal partial class ApiParameterContext
    {
        public ApiParameterContext(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider metadataProvider, Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor actionDescriptor, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Template.TemplatePart> routeParameters) { }
        public Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor ActionDescriptor { get { throw null; } }
        public Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider MetadataProvider { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiParameterDescription> Results { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Routing.Template.TemplatePart> RouteParameters { get { throw null; } }
    }
    internal partial class ApiResponseTypeProvider
    {
        public ApiResponseTypeProvider(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.MvcOptions mvcOptions) { }
        public System.Collections.Generic.ICollection<Microsoft.AspNetCore.Mvc.ApiExplorer.ApiResponseType> GetApiResponseTypes(Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor action) { throw null; }
    }
    public partial class DefaultApiDescriptionProvider : Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider
    {
        public DefaultApiDescriptionProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions> optionsAccessor, Microsoft.AspNetCore.Routing.IInlineConstraintResolver constraintResolver, Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider modelMetadataProvider, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions> routeOptions) { }
        public int Order { get { throw null; } }
        public void OnProvidersExecuted(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionProviderContext context) { }
        public void OnProvidersExecuting(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionProviderContext context) { }
        internal static void ProcessIsRequired(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiParameterContext context) { }
        internal static void ProcessParameterDefaultValue(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiParameterContext context) { }
    }
    public partial interface IApiDescriptionGroupCollectionProvider
    {
        Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroupCollection ApiDescriptionGroups { get; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MvcApiExplorerMvcCoreBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddApiExplorer(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        internal static void AddApiExplorerServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
    }
}
