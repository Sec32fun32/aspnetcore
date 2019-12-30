// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public partial class ApplicationBuilder : Microsoft.AspNetCore.Builder.IApplicationBuilder
    {
        public ApplicationBuilder(System.IServiceProvider serviceProvider) { }
        public ApplicationBuilder(System.IServiceProvider serviceProvider, object server) { }
        public System.IServiceProvider ApplicationServices { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public Microsoft.AspNetCore.Http.Features.IFeatureCollection ServerFeatures { get { throw null; } }
        public Microsoft.AspNetCore.Http.RequestDelegate Build() { throw null; }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder New() { throw null; }
        public Microsoft.AspNetCore.Builder.IApplicationBuilder Use(System.Func<Microsoft.AspNetCore.Http.RequestDelegate, Microsoft.AspNetCore.Http.RequestDelegate> middleware) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Http
{
    public partial class BindingAddress
    {
        public BindingAddress() { }
        public string Host { get { throw null; } }
        public bool IsUnixPipe { get { throw null; } }
        public string PathBase { get { throw null; } }
        public int Port { get { throw null; } internal set { } }
        public string Scheme { get { throw null; } }
        public string UnixPipePath { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.AspNetCore.Http.BindingAddress Parse(string address) { throw null; }
        public override string ToString() { throw null; }
    }
    internal static partial class BufferingHelper
    {
        internal const int DefaultBufferThreshold = 30720;
        public static Microsoft.AspNetCore.Http.HttpRequest EnableRewind(this Microsoft.AspNetCore.Http.HttpRequest request, int bufferThreshold = 30720, long? bufferLimit = default(long?)) { throw null; }
        public static Microsoft.AspNetCore.WebUtilities.MultipartSection EnableRewind(this Microsoft.AspNetCore.WebUtilities.MultipartSection section, System.Action<System.IDisposable> registerForDispose, int bufferThreshold = 30720, long? bufferLimit = default(long?)) { throw null; }
    }
    internal sealed partial class DefaultConnectionInfo : Microsoft.AspNetCore.Http.ConnectionInfo
    {
        public DefaultConnectionInfo(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public override System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate { get { throw null; } set { } }
        public override string Id { get { throw null; } set { } }
        public override System.Net.IPAddress LocalIpAddress { get { throw null; } set { } }
        public override int LocalPort { get { throw null; } set { } }
        public override System.Net.IPAddress RemoteIpAddress { get { throw null; } set { } }
        public override int RemotePort { get { throw null; } set { } }
        public override System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public void Initialize(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public void Initialize(Microsoft.AspNetCore.Http.Features.IFeatureCollection features, int revision) { }
        public void Uninitialize() { }
    }
    public sealed partial class DefaultHttpContext : Microsoft.AspNetCore.Http.HttpContext
    {
        public DefaultHttpContext() { }
        public DefaultHttpContext(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public override Microsoft.AspNetCore.Http.ConnectionInfo Connection { get { throw null; } }
        public override Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        public Microsoft.AspNetCore.Http.Features.FormOptions FormOptions { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public override System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        public override System.Threading.CancellationToken RequestAborted { get { throw null; } set { } }
        public override System.IServiceProvider RequestServices { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        public Microsoft.Extensions.DependencyInjection.IServiceScopeFactory ServiceScopeFactory { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.ISession Session { get { throw null; } set { } }
        public override string TraceIdentifier { get { throw null; } set { } }
        public override System.Security.Claims.ClaimsPrincipal User { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.WebSocketManager WebSockets { get { throw null; } }
        public override void Abort() { }
        public void Initialize(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public void Uninitialize() { }
    }
    internal sealed partial class DefaultHttpRequest : Microsoft.AspNetCore.Http.HttpRequest
    {
        public DefaultHttpRequest(Microsoft.AspNetCore.Http.DefaultHttpContext context) { }
        public override System.IO.Stream Body { get { throw null; } set { } }
        public override System.IO.Pipelines.PipeReader BodyReader { get { throw null; } }
        public override long? ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.IRequestCookieCollection Cookies { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.IFormCollection Form { get { throw null; } set { } }
        public override bool HasFormContentType { get { throw null; } }
        public override Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } }
        public override Microsoft.AspNetCore.Http.HostString Host { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public override bool IsHttps { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.PathString Path { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.PathString PathBase { get { throw null; } set { } }
        public override string Protocol { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.IQueryCollection Query { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.QueryString QueryString { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public override string Scheme { get { throw null; } set { } }
        public void Initialize() { }
        public void Initialize(int revision) { }
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.IFormCollection> ReadFormAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Uninitialize() { }
    }
    internal sealed partial class DefaultHttpResponse : Microsoft.AspNetCore.Http.HttpResponse
    {
        public DefaultHttpResponse(Microsoft.AspNetCore.Http.DefaultHttpContext context) { }
        public override System.IO.Stream Body { get { throw null; } set { } }
        public override System.IO.Pipelines.PipeWriter BodyWriter { get { throw null; } }
        public override long? ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.IResponseCookies Cookies { get { throw null; } }
        public override bool HasStarted { get { throw null; } }
        public override Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } }
        public override Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } }
        public override int StatusCode { get { throw null; } set { } }
        public override System.Threading.Tasks.Task CompleteAsync() { throw null; }
        public void Initialize() { }
        public void Initialize(int revision) { }
        public override void OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public override void OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public override void Redirect(string location, bool permanent) { }
        public override System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public void Uninitialize() { }
    }
    internal sealed partial class DefaultWebSocketManager : Microsoft.AspNetCore.Http.WebSocketManager
    {
        public DefaultWebSocketManager(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public override bool IsWebSocketRequest { get { throw null; } }
        public override System.Collections.Generic.IList<string> WebSocketRequestedProtocols { get { throw null; } }
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocket> AcceptWebSocketAsync(string subProtocol) { throw null; }
        public void Initialize(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public void Initialize(Microsoft.AspNetCore.Http.Features.IFeatureCollection features, int revision) { }
        public void Uninitialize() { }
    }
    public partial class FormCollection : Microsoft.AspNetCore.Http.IFormCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        public static readonly Microsoft.AspNetCore.Http.FormCollection Empty;
        public FormCollection(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> fields, Microsoft.AspNetCore.Http.IFormFileCollection files = null) { }
        public int Count { get { throw null; } }
        public Microsoft.AspNetCore.Http.IFormFileCollection Files { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public bool ContainsKey(string key) { throw null; }
        public Microsoft.AspNetCore.Http.FormCollection.Enumerator GetEnumerator() { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>.Enumerator dictionaryEnumerator) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    public partial class FormFile : Microsoft.AspNetCore.Http.IFormFile
    {
        public FormFile(System.IO.Stream baseStream, long baseStreamOffset, long length, string name, string fileName) { }
        public string ContentDisposition { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public string FileName { get { throw null; } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } set { } }
        public long Length { get { throw null; } }
        public string Name { get { throw null; } }
        public void CopyTo(System.IO.Stream target) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream target, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.IO.Stream OpenReadStream() { throw null; }
    }
    public partial class FormFileCollection : System.Collections.Generic.List<Microsoft.AspNetCore.Http.IFormFile>, Microsoft.AspNetCore.Http.IFormFileCollection, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.IFormFile>, System.Collections.Generic.IReadOnlyCollection<Microsoft.AspNetCore.Http.IFormFile>, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.IFormFile>, System.Collections.IEnumerable
    {
        public FormFileCollection() { }
        public Microsoft.AspNetCore.Http.IFormFile this[string name] { get { throw null; } }
        public Microsoft.AspNetCore.Http.IFormFile GetFile(string name) { throw null; }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Http.IFormFile> GetFiles(string name) { throw null; }
    }
    public partial class HeaderDictionary : Microsoft.AspNetCore.Http.IHeaderDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        public HeaderDictionary() { }
        public HeaderDictionary(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> store) { }
        public HeaderDictionary(int capacity) { }
        public long? ContentLength { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        Microsoft.Extensions.Primitives.StringValues System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringValues> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { }
        public void Add(string key, Microsoft.Extensions.Primitives.StringValues value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>[] array, int arrayIndex) { }
        public Microsoft.AspNetCore.Http.HeaderDictionary.Enumerator GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>.Enumerator dictionaryEnumerator) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    public partial class HttpContextAccessor : Microsoft.AspNetCore.Http.IHttpContextAccessor
    {
        public HttpContextAccessor() { }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } set { } }
    }
    [System.ObsoleteAttribute("This is obsolete and will be removed in a future version. Use DefaultHttpContextFactory instead.")]
    public partial class HttpContextFactory : Microsoft.AspNetCore.Http.IHttpContextFactory
    {
        public HttpContextFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Http.Features.FormOptions> formOptions) { }
        public HttpContextFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Http.Features.FormOptions> formOptions, Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor) { }
        public HttpContextFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Http.Features.FormOptions> formOptions, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory serviceScopeFactory) { }
        public HttpContextFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Http.Features.FormOptions> formOptions, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory serviceScopeFactory, Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor) { }
        public Microsoft.AspNetCore.Http.HttpContext Create(Microsoft.AspNetCore.Http.Features.IFeatureCollection featureCollection) { throw null; }
        public void Dispose(Microsoft.AspNetCore.Http.HttpContext httpContext) { }
    }
    public static partial class HttpRequestRewindExtensions
    {
        public static void EnableBuffering(this Microsoft.AspNetCore.Http.HttpRequest request) { }
        public static void EnableBuffering(this Microsoft.AspNetCore.Http.HttpRequest request, int bufferThreshold) { }
        public static void EnableBuffering(this Microsoft.AspNetCore.Http.HttpRequest request, int bufferThreshold, long bufferLimit) { }
        public static void EnableBuffering(this Microsoft.AspNetCore.Http.HttpRequest request, long bufferLimit) { }
    }
    internal partial class ItemsDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.Generic.IDictionary<object, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
    {
        public ItemsDictionary() { }
        public ItemsDictionary(System.Collections.Generic.IDictionary<object, object> items) { }
        public System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } }
        int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.IsReadOnly { get { throw null; } }
        object System.Collections.Generic.IDictionary<System.Object,System.Object>.this[object key] { get { throw null; } set { } }
        System.Collections.Generic.ICollection<object> System.Collections.Generic.IDictionary<System.Object,System.Object>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<object> System.Collections.Generic.IDictionary<System.Object,System.Object>.Values { get { throw null; } }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Add(System.Collections.Generic.KeyValuePair<object, object> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<object, object> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<object, object>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<object, object> item) { throw null; }
        void System.Collections.Generic.IDictionary<System.Object,System.Object>.Add(object key, object value) { }
        bool System.Collections.Generic.IDictionary<System.Object,System.Object>.ContainsKey(object key) { throw null; }
        bool System.Collections.Generic.IDictionary<System.Object,System.Object>.Remove(object key) { throw null; }
        bool System.Collections.Generic.IDictionary<System.Object,System.Object>.TryGetValue(object key, out object value) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MiddlewareFactory : Microsoft.AspNetCore.Http.IMiddlewareFactory
    {
        public MiddlewareFactory(System.IServiceProvider serviceProvider) { }
        public Microsoft.AspNetCore.Http.IMiddleware Create(System.Type middlewareType) { throw null; }
        public void Release(Microsoft.AspNetCore.Http.IMiddleware middleware) { }
    }
    public partial class QueryCollection : Microsoft.AspNetCore.Http.IQueryCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        public static readonly Microsoft.AspNetCore.Http.QueryCollection Empty;
        public QueryCollection() { }
        public QueryCollection(Microsoft.AspNetCore.Http.QueryCollection store) { }
        public QueryCollection(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> store) { }
        public QueryCollection(int capacity) { }
        public int Count { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public bool ContainsKey(string key) { throw null; }
        public Microsoft.AspNetCore.Http.QueryCollection.Enumerator GetEnumerator() { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>.Enumerator dictionaryEnumerator) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    internal sealed partial class ReferenceReadStream : System.IO.Stream
    {
        public ReferenceReadStream(System.IO.Stream inner, long offset, long length) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class RequestCookieCollection : Microsoft.AspNetCore.Http.IRequestCookieCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        public static readonly Microsoft.AspNetCore.Http.RequestCookieCollection Empty;
        public RequestCookieCollection() { }
        public RequestCookieCollection(System.Collections.Generic.Dictionary<string, string> store) { }
        public RequestCookieCollection(int capacity) { }
        public int Count { get { throw null; } }
        public string this[string key] { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public bool ContainsKey(string key) { throw null; }
        public Microsoft.AspNetCore.Http.RequestCookieCollection.Enumerator GetEnumerator() { throw null; }
        public static Microsoft.AspNetCore.Http.RequestCookieCollection Parse(System.Collections.Generic.IList<string> values) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out string value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(System.Collections.Generic.Dictionary<string, string>.Enumerator dictionaryEnumerator) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, string> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public static partial class RequestFormReaderExtensions
    {
        public static System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.IFormCollection> ReadFormAsync(this Microsoft.AspNetCore.Http.HttpRequest request, Microsoft.AspNetCore.Http.Features.FormOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class ResponseCookies : Microsoft.AspNetCore.Http.IResponseCookies
    {
        public ResponseCookies(Microsoft.AspNetCore.Http.IHeaderDictionary headers, Microsoft.Extensions.ObjectPool.ObjectPool<System.Text.StringBuilder> builderPool) { }
        public void Append(string key, string value) { }
        public void Append(string key, string value, Microsoft.AspNetCore.Http.CookieOptions options) { }
        public void Delete(string key) { }
        public void Delete(string key, Microsoft.AspNetCore.Http.CookieOptions options) { }
    }
    public static partial class SendFileFallback
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task SendFileAsync(System.IO.Stream destination, string filePath, long offset, long? count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal static partial class StreamCopyOperationInternal
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task CopyToAsync(System.IO.Stream source, System.IO.Stream destination, long? count, int bufferSize, System.Threading.CancellationToken cancel) { throw null; }
        public static System.Threading.Tasks.Task CopyToAsync(System.IO.Stream source, System.IO.Stream destination, long? count, System.Threading.CancellationToken cancel) { throw null; }
    }
    public partial class StreamResponseBodyFeature : Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature
    {
        public StreamResponseBodyFeature(System.IO.Stream stream) { }
        public StreamResponseBodyFeature(System.IO.Stream stream, Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature priorFeature) { }
        public Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature PriorFeature { get { throw null; } }
        public System.IO.Stream Stream { get { throw null; } }
        public System.IO.Pipelines.PipeWriter Writer { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task CompleteAsync() { throw null; }
        public virtual void DisableBuffering() { }
        public void Dispose() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Http.Features
{
    public partial class DefaultSessionFeature : Microsoft.AspNetCore.Http.Features.ISessionFeature
    {
        public DefaultSessionFeature() { }
        public Microsoft.AspNetCore.Http.ISession Session { get { throw null; } set { } }
    }
    public partial class FormFeature : Microsoft.AspNetCore.Http.Features.IFormFeature
    {
        public FormFeature(Microsoft.AspNetCore.Http.HttpRequest request) { }
        public FormFeature(Microsoft.AspNetCore.Http.HttpRequest request, Microsoft.AspNetCore.Http.Features.FormOptions options) { }
        public FormFeature(Microsoft.AspNetCore.Http.IFormCollection form) { }
        public Microsoft.AspNetCore.Http.IFormCollection Form { get { throw null; } set { } }
        public bool HasFormContentType { get { throw null; } }
        public Microsoft.AspNetCore.Http.IFormCollection ReadForm() { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.IFormCollection> ReadFormAsync() { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.IFormCollection> ReadFormAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class FormOptions
    {
        internal static readonly Microsoft.AspNetCore.Http.Features.FormOptions Default;
        public const int DefaultBufferBodyLengthLimit = 134217728;
        public const int DefaultMemoryBufferThreshold = 65536;
        public const long DefaultMultipartBodyLengthLimit = (long)134217728;
        public const int DefaultMultipartBoundaryLengthLimit = 128;
        public FormOptions() { }
        public bool BufferBody { get { throw null; } set { } }
        public long BufferBodyLengthLimit { get { throw null; } set { } }
        public int KeyLengthLimit { get { throw null; } set { } }
        public int MemoryBufferThreshold { get { throw null; } set { } }
        public long MultipartBodyLengthLimit { get { throw null; } set { } }
        public int MultipartBoundaryLengthLimit { get { throw null; } set { } }
        public int MultipartHeadersCountLimit { get { throw null; } set { } }
        public int MultipartHeadersLengthLimit { get { throw null; } set { } }
        public int ValueCountLimit { get { throw null; } set { } }
        public int ValueLengthLimit { get { throw null; } set { } }
    }
    public partial class HttpConnectionFeature : Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature
    {
        public HttpConnectionFeature() { }
        public string ConnectionId { get { throw null; } set { } }
        public System.Net.IPAddress LocalIpAddress { get { throw null; } set { } }
        public int LocalPort { get { throw null; } set { } }
        public System.Net.IPAddress RemoteIpAddress { get { throw null; } set { } }
        public int RemotePort { get { throw null; } set { } }
    }
    public partial class HttpRequestFeature : Microsoft.AspNetCore.Http.Features.IHttpRequestFeature
    {
        public HttpRequestFeature() { }
        public System.IO.Stream Body { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string PathBase { get { throw null; } set { } }
        public string Protocol { get { throw null; } set { } }
        public string QueryString { get { throw null; } set { } }
        public string RawTarget { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
    }
    public partial class HttpRequestIdentifierFeature : Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature
    {
        public HttpRequestIdentifierFeature() { }
        public string TraceIdentifier { get { throw null; } set { } }
    }
    public partial class HttpRequestLifetimeFeature : Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature
    {
        public HttpRequestLifetimeFeature() { }
        public System.Threading.CancellationToken RequestAborted { get { throw null; } set { } }
        public void Abort() { }
    }
    public partial class HttpResponseFeature : Microsoft.AspNetCore.Http.Features.IHttpResponseFeature
    {
        public HttpResponseFeature() { }
        public System.IO.Stream Body { get { throw null; } set { } }
        public virtual bool HasStarted { get { throw null; } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get { throw null; } set { } }
        public string ReasonPhrase { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        public virtual void OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public virtual void OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
    }
    public partial class ItemsFeature : Microsoft.AspNetCore.Http.Features.IItemsFeature
    {
        public ItemsFeature() { }
        public System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } set { } }
    }
    public partial class QueryFeature : Microsoft.AspNetCore.Http.Features.IQueryFeature
    {
        public QueryFeature(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public QueryFeature(Microsoft.AspNetCore.Http.IQueryCollection query) { }
        public Microsoft.AspNetCore.Http.IQueryCollection Query { get { throw null; } set { } }
    }
    public partial class RequestBodyPipeFeature : Microsoft.AspNetCore.Http.Features.IRequestBodyPipeFeature
    {
        public RequestBodyPipeFeature(Microsoft.AspNetCore.Http.HttpContext context) { }
        public System.IO.Pipelines.PipeReader Reader { get { throw null; } }
    }
    public partial class RequestCookiesFeature : Microsoft.AspNetCore.Http.Features.IRequestCookiesFeature
    {
        public RequestCookiesFeature(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public RequestCookiesFeature(Microsoft.AspNetCore.Http.IRequestCookieCollection cookies) { }
        public Microsoft.AspNetCore.Http.IRequestCookieCollection Cookies { get { throw null; } set { } }
    }
    public partial class RequestServicesFeature : Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature, System.IAsyncDisposable, System.IDisposable
    {
        public RequestServicesFeature(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory) { }
        public System.IServiceProvider RequestServices { get { throw null; } set { } }
        public void Dispose() { }
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
    }
    public partial class ResponseCookiesFeature : Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature
    {
        public ResponseCookiesFeature(Microsoft.AspNetCore.Http.Features.IFeatureCollection features) { }
        public ResponseCookiesFeature(Microsoft.AspNetCore.Http.Features.IFeatureCollection features, Microsoft.Extensions.ObjectPool.ObjectPool<System.Text.StringBuilder> builderPool) { }
        public Microsoft.AspNetCore.Http.IResponseCookies Cookies { get { throw null; } }
    }
    public partial class RouteValuesFeature : Microsoft.AspNetCore.Http.Features.IRouteValuesFeature
    {
        public RouteValuesFeature() { }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
    }
    public partial class ServiceProvidersFeature : Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature
    {
        public ServiceProvidersFeature() { }
        public System.IServiceProvider RequestServices { get { throw null; } set { } }
    }
    public partial class TlsConnectionFeature : Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature
    {
        public TlsConnectionFeature() { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate { get { throw null; } set { } }
        public System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Http.Features.Authentication
{
    public partial class HttpAuthenticationFeature : Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature
    {
        public HttpAuthenticationFeature() { }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Internal
{
    internal static partial class AspNetCoreTempDirectory
    {
        public static string TempDirectory { get { throw null; } }
        public static System.Func<string> TempDirectoryFactory { get { throw null; } }
    }
    internal static partial class ValueTaskExtensions
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Threading.Tasks.Task GetAsTask(this in System.Threading.Tasks.ValueTask<System.IO.Pipelines.FlushResult> valueTask) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class HttpServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHttpContextAccessor(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
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
}
