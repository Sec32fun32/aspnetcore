// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class DefaultFilesExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDefaultFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDefaultFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.DefaultFilesOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDefaultFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string requestPath) { throw null; }
    }
    public partial class DefaultFilesOptions : Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptionsBase
    {
        public DefaultFilesOptions() : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public DefaultFilesOptions(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions sharedOptions) : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public System.Collections.Generic.IList<string> DefaultFileNames { get { throw null; } set { } }
    }
    public static partial class DirectoryBrowserExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDirectoryBrowser(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDirectoryBrowser(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.DirectoryBrowserOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseDirectoryBrowser(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string requestPath) { throw null; }
    }
    public partial class DirectoryBrowserOptions : Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptionsBase
    {
        public DirectoryBrowserOptions() : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public DirectoryBrowserOptions(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions sharedOptions) : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public Microsoft.AspNetCore.StaticFiles.IDirectoryFormatter Formatter { get { throw null; } set { } }
    }
    public static partial class FileServerExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseFileServer(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseFileServer(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.FileServerOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseFileServer(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, bool enableDirectoryBrowsing) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseFileServer(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string requestPath) { throw null; }
    }
    public partial class FileServerOptions : Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptionsBase
    {
        public FileServerOptions() : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public Microsoft.AspNetCore.Builder.DefaultFilesOptions DefaultFilesOptions { get { throw null; } }
        public Microsoft.AspNetCore.Builder.DirectoryBrowserOptions DirectoryBrowserOptions { get { throw null; } }
        public bool EnableDefaultFiles { get { throw null; } set { } }
        public bool EnableDirectoryBrowsing { get { throw null; } set { } }
        public Microsoft.AspNetCore.Builder.StaticFileOptions StaticFileOptions { get { throw null; } }
    }
    public static partial class StaticFileExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStaticFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStaticFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.StaticFileOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseStaticFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, string requestPath) { throw null; }
    }
    public partial class StaticFileOptions : Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptionsBase
    {
        public StaticFileOptions() : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public StaticFileOptions(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions sharedOptions) : base (default(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions)) { }
        public Microsoft.AspNetCore.StaticFiles.IContentTypeProvider ContentTypeProvider { get { throw null; } set { } }
        public string DefaultContentType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.Features.HttpsCompressionMode HttpsCompression { get { throw null; } set { } }
        public System.Action<Microsoft.AspNetCore.StaticFiles.StaticFileResponseContext> OnPrepareResponse { get { throw null; } set { } }
        public bool ServeUnknownFileTypes { get { throw null; } set { } }
    }
    public static partial class StaticFilesEndpointRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToFile(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string filePath) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToFile(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string filePath, Microsoft.AspNetCore.Builder.StaticFileOptions options) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToFile(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string filePath) { throw null; }
        public static Microsoft.AspNetCore.Builder.IEndpointConventionBuilder MapFallbackToFile(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, string filePath, Microsoft.AspNetCore.Builder.StaticFileOptions options) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Internal
{
    internal static partial class RangeHelper
    {
        internal static Microsoft.Net.Http.Headers.RangeItemHeaderValue NormalizeRange(Microsoft.Net.Http.Headers.RangeItemHeaderValue range, long length) { throw null; }
        public static (bool isRangeRequest, Microsoft.Net.Http.Headers.RangeItemHeaderValue range) ParseRange(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.Headers.RequestHeaders requestHeaders, long length, Microsoft.Extensions.Logging.ILogger logger) { throw null; }
    }
}
namespace Microsoft.AspNetCore.StaticFiles
{
    internal static partial class Constants
    {
        internal const string SendFileVersion = "1.0";
        internal const string SendFileVersionKey = "sendfile.Version";
        internal const string ServerCapabilitiesKey = "server.Capabilities";
        internal const int Status200Ok = 200;
        internal const int Status206PartialContent = 206;
        internal const int Status304NotModified = 304;
        internal const int Status412PreconditionFailed = 412;
        internal const int Status416RangeNotSatisfiable = 416;
    }
    public partial class DefaultFilesMiddleware
    {
        public DefaultFilesMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.DefaultFilesOptions> options) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class DirectoryBrowserMiddleware
    {
        public DirectoryBrowserMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.DirectoryBrowserOptions> options) { }
        public DirectoryBrowserMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv, System.Text.Encodings.Web.HtmlEncoder encoder, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.DirectoryBrowserOptions> options) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class FileExtensionContentTypeProvider : Microsoft.AspNetCore.StaticFiles.IContentTypeProvider
    {
        public FileExtensionContentTypeProvider() { }
        public FileExtensionContentTypeProvider(System.Collections.Generic.IDictionary<string, string> mapping) { }
        public System.Collections.Generic.IDictionary<string, string> Mappings { get { throw null; } }
        public bool TryGetContentType(string subpath, out string contentType) { throw null; }
    }
    internal static partial class Helpers
    {
        internal static bool IsGetOrHeadMethod(string method) { throw null; }
        internal static bool PathEndsInSlash(Microsoft.AspNetCore.Http.PathString path) { throw null; }
        internal static Microsoft.Extensions.FileProviders.IFileProvider ResolveFileProvider(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv) { throw null; }
        internal static bool TryMatchPath(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.PathString matchUrl, bool forDirectory, out Microsoft.AspNetCore.Http.PathString subpath) { throw null; }
    }
    public partial class HtmlDirectoryFormatter : Microsoft.AspNetCore.StaticFiles.IDirectoryFormatter
    {
        public HtmlDirectoryFormatter(System.Text.Encodings.Web.HtmlEncoder encoder) { }
        public virtual System.Threading.Tasks.Task GenerateContentAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo> contents) { throw null; }
    }
    public partial interface IContentTypeProvider
    {
        bool TryGetContentType(string subpath, out string contentType);
    }
    public partial interface IDirectoryFormatter
    {
        System.Threading.Tasks.Task GenerateContentAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo> contents);
    }
    internal static partial class LoggerExtensions
    {
        public static void CopyingFileRange(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Primitives.StringValues range, string path) { }
        public static void EndpointMatched(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void FileNotFound(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void FileNotModified(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void FileServed(this Microsoft.Extensions.Logging.ILogger logger, string virtualPath, string physicalPath) { }
        public static void FileTypeNotSupported(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void Handled(this Microsoft.Extensions.Logging.ILogger logger, int statusCode, string path) { }
        public static void PathMismatch(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void PreconditionFailed(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void RangeNotSatisfiable(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void RequestMethodNotSupported(this Microsoft.Extensions.Logging.ILogger logger, string method) { }
        public static void SendingFileRange(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Primitives.StringValues range, string path) { }
        public static void WriteCancelled(this Microsoft.Extensions.Logging.ILogger logger, System.Exception ex) { }
    }
    internal static partial class Resources
    {
        internal static string Args_NoFormatter { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string HtmlDir_IndexOf { get { throw null; } }
        internal static string HtmlDir_LastModified { get { throw null; } }
        internal static string HtmlDir_Modified { get { throw null; } }
        internal static string HtmlDir_Name { get { throw null; } }
        internal static string HtmlDir_Size { get { throw null; } }
        internal static string HtmlDir_TableSummary { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct StaticFileContext
    {
        private object _dummy;
        private int _dummyPrimitive;
        public StaticFileContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Builder.StaticFileOptions options, Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.FileProviders.IFileProvider fileProvider, string contentType, Microsoft.AspNetCore.Http.PathString subPath) { throw null; }
        public bool IsGetMethod { get { throw null; } }
        public bool IsHeadMethod { get { throw null; } }
        public bool IsRangeRequest { get { throw null; } }
        public string PhysicalPath { get { throw null; } }
        public string SubPath { get { throw null; } }
        public void ApplyResponseHeaders(int statusCode) { }
        public void ComprehendRequestHeaders() { }
        public Microsoft.AspNetCore.StaticFiles.StaticFileContext.PreconditionState GetPreconditionState() { throw null; }
        public bool LookupFileInfo() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task SendAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task SendRangeAsync() { throw null; }
        public System.Threading.Tasks.Task SendStatusAsync(int statusCode) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ServeStaticFile(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.RequestDelegate next) { throw null; }
        internal enum PreconditionState : byte
        {
            Unspecified = (byte)0,
            NotModified = (byte)1,
            ShouldProcess = (byte)2,
            PreconditionFailed = (byte)3,
        }
    }
    public partial class StaticFileMiddleware
    {
        public StaticFileMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.StaticFileOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        internal static bool LookupContentType(Microsoft.AspNetCore.StaticFiles.IContentTypeProvider contentTypeProvider, Microsoft.AspNetCore.Builder.StaticFileOptions options, Microsoft.AspNetCore.Http.PathString subPath, out string contentType) { throw null; }
        internal static bool ValidatePath(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.PathString matchUrl, out Microsoft.AspNetCore.Http.PathString subPath) { throw null; }
    }
    public partial class StaticFileResponseContext
    {
        [System.ObsoleteAttribute("Use the constructor that passes in the HttpContext and IFileInfo parameters: StaticFileResponseContext(HttpContext context, IFileInfo file)", false)]
        public StaticFileResponseContext() { }
        public StaticFileResponseContext(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.Extensions.FileProviders.IFileInfo file) { }
        public Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        public Microsoft.Extensions.FileProviders.IFileInfo File { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.StaticFiles.Infrastructure
{
    public partial class SharedOptions
    {
        public SharedOptions() { }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.PathString RequestPath { get { throw null; } set { } }
    }
    public abstract partial class SharedOptionsBase
    {
        protected SharedOptionsBase(Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions sharedOptions) { }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.PathString RequestPath { get { throw null; } set { } }
        protected Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions SharedOptions { get { throw null; } }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class DirectoryBrowserServiceExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDirectoryBrowser(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
}
