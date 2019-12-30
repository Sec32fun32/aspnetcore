// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public enum ValidationSummary
    {
        None = 0,
        ModelOnly = 1,
        All = 2,
    }
}
namespace Microsoft.AspNetCore.Mvc.TagHelpers
{
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-action")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-all-route-data")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-area")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-controller")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-fragment")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-host")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-page")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-page-handler")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-protocol")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-route")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("a", Attributes="asp-route-*")]
    public partial class AnchorTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public AnchorTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-action")]
        public string Action { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-area")]
        public string Area { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-controller")]
        public string Controller { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fragment")]
        public string Fragment { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-host")]
        public string Host { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page")]
        public string Page { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page-handler")]
        public string PageHandler { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-protocol")]
        public string Protocol { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-route")]
        public string Route { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-all-route-data", DictionaryAttributePrefix="asp-route-")]
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    internal static partial class AttributeMatcher
    {
        public static bool TryDetermineMode<TMode>(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Mvc.TagHelpers.ModeAttributes<TMode>> modeInfos, System.Func<TMode, TMode, int> compare, out TMode result) { throw null; }
    }
    public partial class CacheTagHelper : Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperBase
    {
        public static readonly string CacheKeyPrefix;
        public CacheTagHelper(Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperMemoryCacheFactory factory, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) : base (default(System.Text.Encodings.Web.HtmlEncoder)) { }
        protected Microsoft.Extensions.Caching.Memory.IMemoryCache MemoryCache { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("priority")]
        public Microsoft.Extensions.Caching.Memory.CacheItemPriority? Priority { get { throw null; } set { } }
        internal Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions GetMemoryCacheEntryOptions() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    public abstract partial class CacheTagHelperBase : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public static readonly System.TimeSpan DefaultExpiration;
        public CacheTagHelperBase(System.Text.Encodings.Web.HtmlEncoder htmlEncoder) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("enabled")]
        public bool Enabled { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("expires-after")]
        public System.TimeSpan? ExpiresAfter { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("expires-on")]
        public System.DateTimeOffset? ExpiresOn { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("expires-sliding")]
        public System.TimeSpan? ExpiresSliding { get { throw null; } set { } }
        protected System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by")]
        public string VaryBy { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-cookie")]
        public string VaryByCookie { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-culture")]
        public bool VaryByCulture { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-header")]
        public string VaryByHeader { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-query")]
        public string VaryByQuery { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-route")]
        public string VaryByRoute { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("vary-by-user")]
        public bool VaryByUser { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
    }
    public partial class CacheTagHelperMemoryCacheFactory
    {
        internal CacheTagHelperMemoryCacheFactory(Microsoft.Extensions.Caching.Memory.IMemoryCache cache) { }
        public CacheTagHelperMemoryCacheFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperOptions> options) { }
        public Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
    }
    public partial class CacheTagHelperOptions
    {
        public CacheTagHelperOptions() { }
        public long SizeLimit { get { throw null; } set { } }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("component", Attributes="type", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public sealed partial class ComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public ComponentTagHelper() { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("type")]
        public System.Type ComponentType { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("params", DictionaryAttributePrefix="param-")]
        public System.Collections.Generic.IDictionary<string, object> Parameters { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("render-mode")]
        public Microsoft.AspNetCore.Mvc.Rendering.RenderMode RenderMode { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    internal partial class CurrentValues
    {
        public CurrentValues(System.Collections.Generic.ICollection<string> values) { }
        public System.Collections.Generic.ICollection<string> Values { get { throw null; } }
        public System.Collections.Generic.ICollection<string> ValuesAndEncodedValues { get { throw null; } set { } }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("distributed-cache", Attributes="name")]
    public partial class DistributedCacheTagHelper : Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperBase
    {
        public static readonly string CacheKeyPrefix;
        public DistributedCacheTagHelper(Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperService distributedCacheService, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) : base (default(System.Text.Encodings.Web.HtmlEncoder)) { }
        protected Microsoft.Extensions.Caching.Memory.IMemoryCache MemoryCache { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("name")]
        public string Name { get { throw null; } set { } }
        internal Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions GetDistributedCacheEntryOptions() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    public partial class EnvironmentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public EnvironmentTagHelper(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) { }
        public string Exclude { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get { throw null; } }
        public string Include { get { throw null; } set { } }
        public string Names { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    internal partial class FileProviderGlobbingDirectory : Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase
    {
        public FileProviderGlobbingDirectory(Microsoft.Extensions.FileProviders.IFileProvider fileProvider, Microsoft.Extensions.FileProviders.IFileInfo fileInfo, Microsoft.AspNetCore.Mvc.TagHelpers.FileProviderGlobbingDirectory parent) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
        public string RelativePath { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos() { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string path) { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string path) { throw null; }
    }
    internal partial class FileProviderGlobbingFile : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase
    {
        public FileProviderGlobbingFile(Microsoft.Extensions.FileProviders.IFileInfo fileInfo, Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase parent) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-action")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-all-route-data")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-area")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-controller")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-fragment")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-page")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-page-handler")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-route")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("button", Attributes="asp-route-*")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-action", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-all-route-data", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-area", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-controller", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-fragment", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-page", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-page-handler", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-route", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=image], asp-route-*", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-action", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-all-route-data", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-area", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-controller", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-fragment", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-page", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-page-handler", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-route", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="[type=submit], asp-route-*", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public partial class FormActionTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public FormActionTagHelper(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-action")]
        public string Action { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-area")]
        public string Area { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-controller")]
        public string Controller { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fragment")]
        public string Fragment { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page")]
        public string Page { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page-handler")]
        public string PageHandler { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-route")]
        public string Route { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-all-route-data", DictionaryAttributePrefix="asp-route-")]
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory UrlHelperFactory { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("form")]
    public partial class FormTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public FormTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-action")]
        public string Action { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-antiforgery")]
        public bool? Antiforgery { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-area")]
        public string Area { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-controller")]
        public string Controller { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fragment")]
        public string Fragment { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string Method { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page")]
        public string Page { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-page-handler")]
        public string PageHandler { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-route")]
        public string Route { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-all-route-data", DictionaryAttributePrefix="asp-route-")]
        public System.Collections.Generic.IDictionary<string, string> RouteValues { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    public partial class GlobbingUrlBuilder
    {
        public GlobbingUrlBuilder(Microsoft.Extensions.FileProviders.IFileProvider fileProvider, Microsoft.Extensions.Caching.Memory.IMemoryCache cache, Microsoft.AspNetCore.Http.PathString requestPathBase) { }
        public Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } }
        internal System.Func<Microsoft.Extensions.FileSystemGlobbing.Matcher> MatcherBuilder { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.PathString RequestPathBase { get { throw null; } }
        public virtual System.Collections.Generic.IReadOnlyList<string> BuildUrlList(string staticUrl, string includePattern, string excludePattern) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("img", Attributes="asp-append-version,src", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public partial class ImageTagHelper : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper
    {
        [System.ObsoleteAttribute("This constructor is obsolete and will be removed in a future version.")]
        public ImageTagHelper(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, Microsoft.AspNetCore.Mvc.Razor.Infrastructure.TagHelperMemoryCacheProvider cacheProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider fileVersionProvider, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) : base (default(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory), default(System.Text.Encodings.Web.HtmlEncoder)) { }
        [Microsoft.Extensions.DependencyInjection.ActivatorUtilitiesConstructorAttribute]
        public ImageTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider fileVersionProvider, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) : base (default(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory), default(System.Text.Encodings.Web.HtmlEncoder)) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-append-version")]
        public bool AppendVersion { get { throw null; } set { } }
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future version.")]
        protected internal Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
        internal Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider FileVersionProvider { get { throw null; } }
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future version.")]
        protected internal Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("src")]
        public string Src { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("input", Attributes="asp-for", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public partial class InputTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public InputTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-format")]
        public string Format { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("type")]
        public string InputTypeName { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        public string Value { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        protected string GetInputType(Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExplorer modelExplorer, out string inputTypeHint) { throw null; }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    internal static partial class JavaScriptResources
    {
        public static string GetEmbeddedJavaScript(string resourceName) { throw null; }
        internal static string GetEmbeddedJavaScript(string resourceName, System.Func<string, System.IO.Stream> getManifestResourceStream, System.Collections.Concurrent.ConcurrentDictionary<string, string> cache) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("label", Attributes="asp-for")]
    public partial class LabelTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public LabelTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-append-version", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-href", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-href-exclude", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-href-include", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-test-class", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-test-property", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-fallback-test-value", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-href-exclude", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("link", Attributes="asp-href-include", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public partial class LinkTagHelper : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper
    {
        public LinkTagHelper(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, Microsoft.AspNetCore.Mvc.Razor.Infrastructure.TagHelperMemoryCacheProvider cacheProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider fileVersionProvider, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.Text.Encodings.Web.JavaScriptEncoder javaScriptEncoder, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) : base (default(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory), default(System.Text.Encodings.Web.HtmlEncoder)) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-append-version")]
        public bool? AppendVersion { get { throw null; } set { } }
        protected internal Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-href")]
        public string FallbackHref { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-href-exclude")]
        public string FallbackHrefExclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-href-include")]
        public string FallbackHrefInclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-test-class")]
        public string FallbackTestClass { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-test-property")]
        public string FallbackTestProperty { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-test-value")]
        public string FallbackTestValue { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider FileVersionProvider { get { throw null; } }
        protected internal Microsoft.AspNetCore.Mvc.TagHelpers.GlobbingUrlBuilder GlobbingUrlBuilder { get { throw null; } set { } }
        protected internal Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("href")]
        public string Href { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-href-exclude")]
        public string HrefExclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-href-include")]
        public string HrefInclude { get { throw null; } set { } }
        protected System.Text.Encodings.Web.JavaScriptEncoder JavaScriptEncoder { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-suppress-fallback-integrity")]
        public bool SuppressFallbackIntegrity { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    internal partial class ModeAttributes<TMode>
    {
        public ModeAttributes(TMode mode, string[] attributes) { }
        public string[] Attributes { get { throw null; } }
        public TMode Mode { get { throw null; } }
    }
    internal static partial class MvcTagHelperLoggerExtensions
    {
        public static void DistributedFormatterDeserializationException(this Microsoft.Extensions.Logging.ILogger logger, string key, System.Exception exception) { }
    }
    public partial class OptionTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public OptionTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        public override int Order { get { throw null; } }
        public string Value { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("partial", Attributes="name", TagStructure=Microsoft.AspNetCore.Razor.TagHelpers.TagStructure.WithoutEndTag)]
    public partial class PartialTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public PartialTagHelper(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine viewEngine, Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers.IViewBufferScope viewBufferScope) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("fallback-name")]
        public string FallbackName { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("model")]
        public object Model { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("optional")]
        public bool Optional { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary ViewData { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
        internal object ResolveModel() { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("form")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class RenderAtEndOfFormTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public RenderAtEndOfFormTagHelper() { }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Init(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    internal static partial class Resources
    {
        internal static string AnchorTagHelper_CannotOverrideHref { get { throw null; } }
        internal static string ArgumentCannotContainHtmlSpace { get { throw null; } }
        internal static string AttributeIsRequired { get { throw null; } }
        internal static string CannotDetermineAttributeFor { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string FormActionTagHelper_CannotOverrideFormAction { get { throw null; } }
        internal static string FormTagHelper_CannotOverrideAction { get { throw null; } }
        internal static string InputTagHelper_InvalidExpressionResult { get { throw null; } }
        internal static string InputTagHelper_InvalidStringResult { get { throw null; } }
        internal static string InputTagHelper_ValueRequired { get { throw null; } }
        internal static string InvalidEnumArgument { get { throw null; } }
        internal static string PartialTagHelper_InvalidModelAttributes { get { throw null; } }
        internal static string PropertyOfTypeCannotBeNull { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string TagHelperOutput_AttributeDoesNotExist { get { throw null; } }
        internal static string TagHelpers_NoProvidedMetadata { get { throw null; } }
        internal static string ViewEngine_FallbackViewNotFound { get { throw null; } }
        internal static string ViewEngine_PartialViewNotFound { get { throw null; } }
        internal static string FormatAnchorTagHelper_CannotOverrideHref(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10, object p11) { throw null; }
        internal static string FormatAttributeIsRequired(object p0, object p1) { throw null; }
        internal static string FormatCannotDetermineAttributeFor(object p0, object p1) { throw null; }
        internal static string FormatFormActionTagHelper_CannotOverrideFormAction(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9) { throw null; }
        internal static string FormatFormTagHelper_CannotOverrideAction(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9) { throw null; }
        internal static string FormatInputTagHelper_InvalidExpressionResult(object p0, object p1, object p2, object p3, object p4, object p5, object p6) { throw null; }
        internal static string FormatInputTagHelper_InvalidStringResult(object p0, object p1, object p2) { throw null; }
        internal static string FormatInputTagHelper_ValueRequired(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatInvalidEnumArgument(object p0, object p1, object p2) { throw null; }
        internal static string FormatPartialTagHelper_InvalidModelAttributes(object p0, object p1, object p2) { throw null; }
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) { throw null; }
        internal static string FormatTagHelperOutput_AttributeDoesNotExist(object p0, object p1) { throw null; }
        internal static string FormatTagHelpers_NoProvidedMetadata(object p0, object p1, object p2, object p3) { throw null; }
        internal static string FormatViewEngine_FallbackViewNotFound(object p0, object p1) { throw null; }
        internal static string FormatViewEngine_PartialViewNotFound(object p0, object p1) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-append-version")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-fallback-src")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-fallback-src-exclude")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-fallback-src-include")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-fallback-test")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-src-exclude")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("script", Attributes="asp-src-include")]
    public partial class ScriptTagHelper : Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper
    {
        public ScriptTagHelper(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, Microsoft.AspNetCore.Mvc.Razor.Infrastructure.TagHelperMemoryCacheProvider cacheProvider, Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider fileVersionProvider, System.Text.Encodings.Web.HtmlEncoder htmlEncoder, System.Text.Encodings.Web.JavaScriptEncoder javaScriptEncoder, Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory urlHelperFactory) : base (default(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory), default(System.Text.Encodings.Web.HtmlEncoder)) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-append-version")]
        public bool? AppendVersion { get { throw null; } set { } }
        protected internal Microsoft.Extensions.Caching.Memory.IMemoryCache Cache { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-src")]
        public string FallbackSrc { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-src-exclude")]
        public string FallbackSrcExclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-src-include")]
        public string FallbackSrcInclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-fallback-test")]
        public string FallbackTestExpression { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Mvc.ViewFeatures.IFileVersionProvider FileVersionProvider { get { throw null; } }
        protected internal Microsoft.AspNetCore.Mvc.TagHelpers.GlobbingUrlBuilder GlobbingUrlBuilder { get { throw null; } set { } }
        protected internal Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get { throw null; } }
        protected System.Text.Encodings.Web.JavaScriptEncoder JavaScriptEncoder { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("src")]
        public string Src { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-src-exclude")]
        public string SrcExclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-src-include")]
        public string SrcInclude { get { throw null; } set { } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-suppress-fallback-integrity")]
        public bool SuppressFallbackIntegrity { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("select", Attributes="asp-for")]
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("select", Attributes="asp-items")]
    public partial class SelectTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public SelectTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-items")]
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Items { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Init(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context) { }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    public static partial class TagHelperOutputExtensions
    {
        public static void AddClass(this Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput tagHelperOutput, string classValue, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) { }
        public static void CopyHtmlAttribute(this Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput tagHelperOutput, string attributeName, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context) { }
        public static void MergeAttributes(this Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput tagHelperOutput, Microsoft.AspNetCore.Mvc.Rendering.TagBuilder tagBuilder) { }
        public static void RemoveClass(this Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput tagHelperOutput, string classValue, System.Text.Encodings.Web.HtmlEncoder htmlEncoder) { }
        public static void RemoveRange(this Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput tagHelperOutput, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute> attributes) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("textarea", Attributes="asp-for")]
    public partial class TextAreaTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public TextAreaTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("span", Attributes="asp-validation-for")]
    public partial class ValidationMessageTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public ValidationMessageTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-validation-for")]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression For { get { throw null; } set { } }
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { throw null; }
    }
    [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("div", Attributes="asp-validation-summary")]
    public partial class ValidationSummaryTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public ValidationSummaryTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator) { }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        protected Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator Generator { get { throw null; } }
        public override int Order { get { throw null; } }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNameAttribute("asp-validation-summary")]
        public Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary ValidationSummary { get { throw null; } set { } }
        [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get { throw null; } set { } }
        public override void Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output) { }
    }
}
namespace Microsoft.AspNetCore.Mvc.TagHelpers.Cache
{
    public partial class CacheTagKey : System.IEquatable<Microsoft.AspNetCore.Mvc.TagHelpers.Cache.CacheTagKey>
    {
        public CacheTagKey(Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper tagHelper, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context) { }
        public CacheTagKey(Microsoft.AspNetCore.Mvc.TagHelpers.DistributedCacheTagHelper tagHelper) { }
        internal string Key { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Mvc.TagHelpers.Cache.CacheTagKey other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public string GenerateHashedKey() { throw null; }
        public string GenerateKey() { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class DistributedCacheTagHelperFormatter : Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperFormatter
    {
        public DistributedCacheTagHelperFormatter() { }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.HtmlString> DeserializeAsync(byte[] value) { throw null; }
        public System.Threading.Tasks.Task<byte[]> SerializeAsync(Microsoft.AspNetCore.Mvc.TagHelpers.Cache.DistributedCacheTagHelperFormattingContext context) { throw null; }
    }
    public partial class DistributedCacheTagHelperFormattingContext
    {
        public DistributedCacheTagHelperFormattingContext() { }
        public Microsoft.AspNetCore.Html.HtmlString Html { get { throw null; } set { } }
    }
    public partial class DistributedCacheTagHelperService : Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperService
    {
        public DistributedCacheTagHelperService(Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperStorage storage, Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperFormatter formatter, System.Text.Encodings.Web.HtmlEncoder HtmlEncoder, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> ProcessContentAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output, Microsoft.AspNetCore.Mvc.TagHelpers.Cache.CacheTagKey key, Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions options) { throw null; }
    }
    public partial class DistributedCacheTagHelperStorage : Microsoft.AspNetCore.Mvc.TagHelpers.Cache.IDistributedCacheTagHelperStorage
    {
        public DistributedCacheTagHelperStorage(Microsoft.Extensions.Caching.Distributed.IDistributedCache distributedCache) { }
        public System.Threading.Tasks.Task<byte[]> GetAsync(string key) { throw null; }
        public System.Threading.Tasks.Task SetAsync(string key, byte[] value, Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions options) { throw null; }
    }
    public partial interface IDistributedCacheTagHelperFormatter
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.HtmlString> DeserializeAsync(byte[] value);
        System.Threading.Tasks.Task<byte[]> SerializeAsync(Microsoft.AspNetCore.Mvc.TagHelpers.Cache.DistributedCacheTagHelperFormattingContext context);
    }
    public partial interface IDistributedCacheTagHelperService
    {
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Html.IHtmlContent> ProcessContentAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output, Microsoft.AspNetCore.Mvc.TagHelpers.Cache.CacheTagKey key, Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions options);
    }
    public partial interface IDistributedCacheTagHelperStorage
    {
        System.Threading.Tasks.Task<byte[]> GetAsync(string key);
        System.Threading.Tasks.Task SetAsync(string key, byte[] value, Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions options);
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class TagHelperServicesExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCacheTagHelper(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddCacheTagHelperLimits(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperOptions> configure) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder AddCacheTagHelperLimits(this Microsoft.Extensions.DependencyInjection.IMvcCoreBuilder builder, System.Action<Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelperOptions> configure) { throw null; }
        internal static void AddCacheTagHelperServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
    }
}
