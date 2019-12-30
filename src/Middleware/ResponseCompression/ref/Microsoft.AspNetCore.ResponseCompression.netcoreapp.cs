// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class ResponseCompressionBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseResponseCompression(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder) { throw null; }
    }
    public static partial class ResponseCompressionServicesExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResponseCompression(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResponseCompression(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.ResponseCompression.ResponseCompressionOptions> configureOptions) { throw null; }
    }
}
namespace Microsoft.AspNetCore.ResponseCompression
{
    public partial class BrotliCompressionProvider : Microsoft.AspNetCore.ResponseCompression.ICompressionProvider
    {
        public BrotliCompressionProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.BrotliCompressionProviderOptions> options) { }
        public string EncodingName { get { throw null; } }
        public bool SupportsFlush { get { throw null; } }
        public System.IO.Stream CreateStream(System.IO.Stream outputStream) { throw null; }
    }
    public partial class BrotliCompressionProviderOptions : Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.BrotliCompressionProviderOptions>
    {
        public BrotliCompressionProviderOptions() { }
        public System.IO.Compression.CompressionLevel Level { get { throw null; } set { } }
        Microsoft.AspNetCore.ResponseCompression.BrotliCompressionProviderOptions Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.BrotliCompressionProviderOptions>.Value { get { throw null; } }
    }
    public partial class CompressionProviderCollection : System.Collections.ObjectModel.Collection<Microsoft.AspNetCore.ResponseCompression.ICompressionProvider>
    {
        public CompressionProviderCollection() { }
        public void Add(System.Type providerType) { }
        public void Add<TCompressionProvider>() where TCompressionProvider : Microsoft.AspNetCore.ResponseCompression.ICompressionProvider { }
    }
    internal partial class CompressionProviderFactory : Microsoft.AspNetCore.ResponseCompression.ICompressionProvider
    {
        public CompressionProviderFactory(System.Type providerType) { }
        string Microsoft.AspNetCore.ResponseCompression.ICompressionProvider.EncodingName { get { throw null; } }
        bool Microsoft.AspNetCore.ResponseCompression.ICompressionProvider.SupportsFlush { get { throw null; } }
        public Microsoft.AspNetCore.ResponseCompression.ICompressionProvider CreateInstance(System.IServiceProvider serviceProvider) { throw null; }
        System.IO.Stream Microsoft.AspNetCore.ResponseCompression.ICompressionProvider.CreateStream(System.IO.Stream outputStream) { throw null; }
    }
    public partial class GzipCompressionProvider : Microsoft.AspNetCore.ResponseCompression.ICompressionProvider
    {
        public GzipCompressionProvider(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.GzipCompressionProviderOptions> options) { }
        public string EncodingName { get { throw null; } }
        public bool SupportsFlush { get { throw null; } }
        public System.IO.Stream CreateStream(System.IO.Stream outputStream) { throw null; }
    }
    public partial class GzipCompressionProviderOptions : Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.GzipCompressionProviderOptions>
    {
        public GzipCompressionProviderOptions() { }
        public System.IO.Compression.CompressionLevel Level { get { throw null; } set { } }
        Microsoft.AspNetCore.ResponseCompression.GzipCompressionProviderOptions Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.GzipCompressionProviderOptions>.Value { get { throw null; } }
    }
    public partial interface ICompressionProvider
    {
        string EncodingName { get; }
        bool SupportsFlush { get; }
        System.IO.Stream CreateStream(System.IO.Stream outputStream);
    }
    public partial interface IResponseCompressionProvider
    {
        bool CheckRequestAcceptsCompression(Microsoft.AspNetCore.Http.HttpContext context);
        Microsoft.AspNetCore.ResponseCompression.ICompressionProvider GetCompressionProvider(Microsoft.AspNetCore.Http.HttpContext context);
        bool ShouldCompressResponse(Microsoft.AspNetCore.Http.HttpContext context);
    }
    internal partial class ResponseCompressionBody : System.IO.Stream, Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature, Microsoft.AspNetCore.Http.Features.IHttpsCompressionFeature
    {
        internal ResponseCompressionBody(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.ResponseCompression.IResponseCompressionProvider provider, Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature innerBodyFeature) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        Microsoft.AspNetCore.Http.Features.HttpsCompressionMode Microsoft.AspNetCore.Http.Features.IHttpsCompressionFeature.Mode { get { throw null; } set { } }
        public override long Position { get { throw null; } set { } }
        public System.IO.Stream Stream { get { throw null; } }
        public System.IO.Pipelines.PipeWriter Writer { get { throw null; } }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task CompleteAsync() { throw null; }
        public void DisableBuffering() { }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task FinishCompressionAsync() { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public System.Threading.Tasks.Task SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancellation) { throw null; }
        public override void SetLength(long value) { }
        public System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class ResponseCompressionDefaults
    {
        public static readonly System.Collections.Generic.IEnumerable<string> MimeTypes;
        public ResponseCompressionDefaults() { }
    }
    internal static partial class ResponseCompressionLoggingExtensions
    {
        public static void CompressingWith(this Microsoft.Extensions.Logging.ILogger logger, string provider) { }
        public static void NoAcceptEncoding(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoCompressionDueToHeader(this Microsoft.Extensions.Logging.ILogger logger, string header) { }
        public static void NoCompressionForContentType(this Microsoft.Extensions.Logging.ILogger logger, string header) { }
        public static void NoCompressionForHttps(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void NoCompressionProvider(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void RequestAcceptsCompression(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ShouldCompressResponse(this Microsoft.Extensions.Logging.ILogger logger) { }
    }
    public partial class ResponseCompressionMiddleware
    {
        public ResponseCompressionMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.ResponseCompression.IResponseCompressionProvider provider) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class ResponseCompressionOptions
    {
        public ResponseCompressionOptions() { }
        public bool EnableForHttps { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> ExcludedMimeTypes { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> MimeTypes { get { throw null; } set { } }
        public Microsoft.AspNetCore.ResponseCompression.CompressionProviderCollection Providers { get { throw null; } }
    }
    public partial class ResponseCompressionProvider : Microsoft.AspNetCore.ResponseCompression.IResponseCompressionProvider
    {
        public ResponseCompressionProvider(System.IServiceProvider services, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCompression.ResponseCompressionOptions> options) { }
        public bool CheckRequestAcceptsCompression(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public virtual Microsoft.AspNetCore.ResponseCompression.ICompressionProvider GetCompressionProvider(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public virtual bool ShouldCompressResponse(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
}
