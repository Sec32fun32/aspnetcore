// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class ResponseCachingExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseResponseCaching(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
    }
}
namespace Microsoft.AspNetCore.ResponseCaching
{
    internal partial class CachedResponse : Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry
    {
        public CachedResponse() { }
        public System.IO.Stream Body { get { throw null; } set { } }
        public System.DateTimeOffset Created { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
    }
    internal partial class CachedVaryByRules : Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry
    {
        public CachedVaryByRules() { }
        public Microsoft.Extensions.Primitives.StringValues Headers { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringValues QueryKeys { get { throw null; } set { } }
        public string VaryByKeyPrefix { get { throw null; } set { } }
    }
    internal static partial class CacheEntryHelpers
    {
        internal static long EstimateCachedResponseSize(Microsoft.AspNetCore.ResponseCaching.CachedResponse cachedResponse) { throw null; }
        internal static long EstimateCachedVaryByRulesySize(Microsoft.AspNetCore.ResponseCaching.CachedVaryByRules cachedVaryByRules) { throw null; }
        internal static long EstimateStringValuesSize(Microsoft.Extensions.Primitives.StringValues stringValues) { throw null; }
    }
    internal partial class FastGuid
    {
        internal FastGuid(long id) { }
        internal string IdString { get { throw null; } }
        internal long IdValue { get { throw null; } }
        internal static Microsoft.AspNetCore.ResponseCaching.FastGuid NewGuid() { throw null; }
    }
    internal partial interface IResponseCache
    {
        Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry Get(string key);
        System.Threading.Tasks.Task<Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry> GetAsync(string key);
        void Set(string key, Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry entry, System.TimeSpan validFor);
        System.Threading.Tasks.Task SetAsync(string key, Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry entry, System.TimeSpan validFor);
    }
    internal partial interface IResponseCacheEntry
    {
    }
    internal partial interface IResponseCachingKeyProvider
    {
        string CreateBaseKey(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        System.Collections.Generic.IEnumerable<string> CreateLookupVaryByKeys(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        string CreateStorageVaryByKey(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
    }
    internal partial interface IResponseCachingPolicyProvider
    {
        bool AllowCacheLookup(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        bool AllowCacheStorage(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        bool AttemptResponseCaching(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        bool IsCachedEntryFresh(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
        bool IsResponseCacheable(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context);
    }
    internal partial interface ISystemClock
    {
        System.DateTimeOffset UtcNow { get; }
    }
    internal static partial class LoggerExtensions
    {
        internal static void CachedResponseServed(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ExpirationExpiresExceeded(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset responseTime, System.DateTimeOffset expires) { }
        internal static void ExpirationInfiniteMaxStaleSatisfied(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan age, System.TimeSpan maxAge) { }
        internal static void ExpirationMaxAgeExceeded(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan age, System.TimeSpan sharedMaxAge) { }
        internal static void ExpirationMaxStaleSatisfied(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan age, System.TimeSpan maxAge, System.TimeSpan maxStale) { }
        internal static void ExpirationMinFreshAdded(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan duration) { }
        internal static void ExpirationMustRevalidate(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan age, System.TimeSpan maxAge) { }
        internal static void ExpirationSharedMaxAgeExceeded(this Microsoft.Extensions.Logging.ILogger logger, System.TimeSpan age, System.TimeSpan sharedMaxAge) { }
        internal static void GatewayTimeoutServed(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void LogResponseNotCached(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void NoResponseServed(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void NotModifiedIfModifiedSinceSatisfied(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset lastModified, System.DateTimeOffset ifModifiedSince) { }
        internal static void NotModifiedIfNoneMatchMatched(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Net.Http.Headers.EntityTagHeaderValue etag) { }
        internal static void NotModifiedIfNoneMatchStar(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void NotModifiedServed(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void RequestMethodNotCacheable(this Microsoft.Extensions.Logging.ILogger logger, string method) { }
        internal static void RequestWithAuthorizationNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void RequestWithNoCacheNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void RequestWithPragmaNoCacheNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseCached(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseContentLengthMismatchNotCached(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithNoCacheNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithNoStoreNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithoutPublicNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithPrivateNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithSetCookieNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void ResponseWithUnsuccessfulStatusCodeNotCacheable(this Microsoft.Extensions.Logging.ILogger logger, int statusCode) { }
        internal static void ResponseWithVaryStarNotCacheable(this Microsoft.Extensions.Logging.ILogger logger) { }
        internal static void VaryByRulesUpdated(this Microsoft.Extensions.Logging.ILogger logger, string headers, string queryKeys) { }
    }
    internal partial class MemoryCachedResponse
    {
        public MemoryCachedResponse() { }
        public long BodyLength { get { throw null; } set { } }
        public System.Collections.Generic.List<byte[]> BodySegments { get { throw null; } set { } }
        public System.DateTimeOffset Created { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
    }
    internal partial class MemoryResponseCache : Microsoft.AspNetCore.ResponseCaching.IResponseCache
    {
        internal MemoryResponseCache(Microsoft.Extensions.Caching.Memory.IMemoryCache cache) { }
        public Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry Get(string key) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry> GetAsync(string key) { throw null; }
        public void Set(string key, Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry entry, System.TimeSpan validFor) { }
        public System.Threading.Tasks.Task SetAsync(string key, Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry entry, System.TimeSpan validFor) { throw null; }
    }
    internal partial class ResponseCachingContext
    {
        internal ResponseCachingContext(Microsoft.AspNetCore.Http.HttpContext httpContext, Microsoft.Extensions.Logging.ILogger logger) { }
        internal string BaseKey { get { throw null; } set { } }
        public System.TimeSpan? CachedEntryAge { get { throw null; } internal set { } }
        internal Microsoft.AspNetCore.ResponseCaching.CachedResponse CachedResponse { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Http.IHeaderDictionary CachedResponseHeaders { get { throw null; } set { } }
        internal System.TimeSpan CachedResponseValidFor { get { throw null; } set { } }
        public Microsoft.AspNetCore.ResponseCaching.CachedVaryByRules CachedVaryByRules { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        internal Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        internal System.IO.Stream OriginalResponseStream { get { throw null; } set { } }
        internal Microsoft.AspNetCore.ResponseCaching.ResponseCachingStream ResponseCachingStream { get { throw null; } set { } }
        internal System.DateTimeOffset? ResponseDate { get { throw null; } set { } }
        internal System.DateTimeOffset? ResponseExpires { get { throw null; } }
        internal System.TimeSpan? ResponseMaxAge { get { throw null; } }
        internal System.TimeSpan? ResponseSharedMaxAge { get { throw null; } }
        internal bool ResponseStarted { get { throw null; } set { } }
        public System.DateTimeOffset? ResponseTime { get { throw null; } internal set { } }
        internal bool ShouldCacheResponse { get { throw null; } set { } }
        internal string StorageVaryKey { get { throw null; } set { } }
    }
    public partial class ResponseCachingFeature : Microsoft.AspNetCore.ResponseCaching.IResponseCachingFeature
    {
        public ResponseCachingFeature() { }
        public string[] VaryByQueryKeys { get { throw null; } set { } }
    }
    internal partial class ResponseCachingKeyProvider : Microsoft.AspNetCore.ResponseCaching.IResponseCachingKeyProvider
    {
        internal ResponseCachingKeyProvider(Microsoft.Extensions.ObjectPool.ObjectPoolProvider poolProvider, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCaching.ResponseCachingOptions> options) { }
        public string CreateBaseKey(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public System.Collections.Generic.IEnumerable<string> CreateLookupVaryByKeys(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public string CreateStorageVaryByKey(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
    }
    public partial class ResponseCachingMiddleware
    {
        internal ResponseCachingMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCaching.ResponseCachingOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.ResponseCaching.IResponseCachingPolicyProvider policyProvider, Microsoft.AspNetCore.ResponseCaching.IResponseCache cache, Microsoft.AspNetCore.ResponseCaching.IResponseCachingKeyProvider keyProvider) { }
        public ResponseCachingMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.ResponseCaching.ResponseCachingOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.ObjectPool.ObjectPoolProvider poolProvider) { }
        internal static void AddResponseCachingFeature(Microsoft.AspNetCore.Http.HttpContext context) { }
        internal static bool ContentIsNotModified(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task FinalizeCacheBodyAsync(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        internal void FinalizeCacheHeaders(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { }
        internal System.Threading.Tasks.Task FinalizeCacheHeadersAsync(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        internal static Microsoft.Extensions.Primitives.StringValues GetOrderCasingNormalizedStringValues(Microsoft.Extensions.Primitives.StringValues stringValues) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext) { throw null; }
        internal static void RemoveResponseCachingFeature(Microsoft.AspNetCore.Http.HttpContext context) { }
        internal void ShimResponseStream(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { }
        internal void StartResponse(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { }
        internal System.Threading.Tasks.Task StartResponseAsync(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<bool> TryServeCachedResponseAsync(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context, Microsoft.AspNetCore.ResponseCaching.IResponseCacheEntry cacheEntry) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<bool> TryServeFromCacheAsync(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        internal static void UnshimResponseStream(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { }
    }
    public partial class ResponseCachingOptions
    {
        public ResponseCachingOptions() { }
        public long MaximumBodySize { get { throw null; } set { } }
        public long SizeLimit { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        internal Microsoft.AspNetCore.ResponseCaching.ISystemClock SystemClock { get { throw null; } set { } }
        public bool UseCaseSensitivePaths { get { throw null; } set { } }
    }
    internal partial class ResponseCachingPolicyProvider : Microsoft.AspNetCore.ResponseCaching.IResponseCachingPolicyProvider
    {
        public ResponseCachingPolicyProvider() { }
        public virtual bool AllowCacheLookup(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public virtual bool AllowCacheStorage(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public virtual bool AttemptResponseCaching(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public virtual bool IsCachedEntryFresh(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
        public virtual bool IsResponseCacheable(Microsoft.AspNetCore.ResponseCaching.ResponseCachingContext context) { throw null; }
    }
    internal partial class ResponseCachingStream : System.IO.Stream
    {
        internal ResponseCachingStream(System.IO.Stream innerStream, long maxBufferSize, int segmentSize, System.Action startResponseCallback, System.Func<System.Threading.Tasks.Task> startResponseCallbackAsync) { }
        internal bool BufferingEnabled { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        internal void DisableBuffering() { }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        internal System.IO.Stream GetBufferStream() { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    internal partial class SegmentReadStream : System.IO.Stream
    {
        internal SegmentReadStream(System.Collections.Generic.List<byte[]> segments, long length) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    internal partial class SegmentWriteStream : System.IO.Stream
    {
        internal SegmentWriteStream(int segmentSize) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        internal System.Collections.Generic.List<byte[]> GetSegments() { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    internal static partial class StreamUtilities
    {
        internal static int BodySegmentSize { get { throw null; } set { } }
        internal static System.IAsyncResult ToIAsyncResult(System.Threading.Tasks.Task task, System.AsyncCallback callback, object state) { throw null; }
    }
    internal static partial class StringBuilderExtensions
    {
        internal static System.Text.StringBuilder AppendUpperInvariant(this System.Text.StringBuilder builder, string value) { throw null; }
    }
    internal partial class SystemClock : Microsoft.AspNetCore.ResponseCaching.ISystemClock
    {
        public SystemClock() { }
        public System.DateTimeOffset UtcNow { get { throw null; } }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ResponseCachingServicesExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResponseCaching(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResponseCaching(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.ResponseCaching.ResponseCachingOptions> configureOptions) { throw null; }
    }
}
