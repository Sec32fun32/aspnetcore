// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public sealed partial class ConnectionEndpointRouteBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder
    {
        internal ConnectionEndpointRouteBuilder(Microsoft.AspNetCore.Builder.IEndpointConventionBuilder endpointConventionBuilder) { }
        public void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention) { }
    }
    public static partial class ConnectionEndpointRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder MapConnectionHandler<TConnectionHandler>(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern) where TConnectionHandler : Microsoft.AspNetCore.Connections.ConnectionHandler { throw null; }
        public static Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder MapConnectionHandler<TConnectionHandler>(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, System.Action<Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions> configureOptions) where TConnectionHandler : Microsoft.AspNetCore.Connections.ConnectionHandler { throw null; }
        public static Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder MapConnections(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions options, System.Action<Microsoft.AspNetCore.Connections.IConnectionBuilder> configure) { throw null; }
        public static Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder MapConnections(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string pattern, System.Action<Microsoft.AspNetCore.Connections.IConnectionBuilder> configure) { throw null; }
    }
    public static partial class ConnectionsAppBuilderExtensions
    {
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future version. The recommended alternative is to use MapConnections or MapConnectionHandler<TConnectionHandler> inside Microsoft.AspNetCore.Builder.UseEndpoints(...).")]
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseConnections(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Action<Microsoft.AspNetCore.Http.Connections.ConnectionsRouteBuilder> configure) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Http.Connections
{
    public partial class ConnectionOptions
    {
        public ConnectionOptions() { }
        public System.TimeSpan? DisconnectTimeout { get { throw null; } set { } }
    }
    public partial class ConnectionOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Http.Connections.ConnectionOptions>
    {
        public static System.TimeSpan DefaultDisconectTimeout;
        public ConnectionOptionsSetup() { }
        public void Configure(Microsoft.AspNetCore.Http.Connections.ConnectionOptions options) { }
    }
    [System.ObsoleteAttribute("This class is obsolete and will be removed in a future version. The recommended alternative is to use MapConnection and MapConnectionHandler<TConnectionHandler> inside Microsoft.AspNetCore.Builder.UseEndpoints(...).")]
    public partial class ConnectionsRouteBuilder
    {
        internal ConnectionsRouteBuilder(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints) { }
        public void MapConnectionHandler<TConnectionHandler>(Microsoft.AspNetCore.Http.PathString path) where TConnectionHandler : Microsoft.AspNetCore.Connections.ConnectionHandler { }
        public void MapConnectionHandler<TConnectionHandler>(Microsoft.AspNetCore.Http.PathString path, System.Action<Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions> configureOptions) where TConnectionHandler : Microsoft.AspNetCore.Connections.ConnectionHandler { }
        public void MapConnections(Microsoft.AspNetCore.Http.PathString path, Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions options, System.Action<Microsoft.AspNetCore.Connections.IConnectionBuilder> configure) { }
        public void MapConnections(Microsoft.AspNetCore.Http.PathString path, System.Action<Microsoft.AspNetCore.Connections.IConnectionBuilder> configure) { }
    }
    public static partial class HttpConnectionContextExtensions
    {
        public static Microsoft.AspNetCore.Http.HttpContext GetHttpContext(this Microsoft.AspNetCore.Connections.ConnectionContext connection) { throw null; }
    }
    public partial class HttpConnectionDispatcherOptions
    {
        public HttpConnectionDispatcherOptions() { }
        public long ApplicationMaxBufferSize { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Authorization.IAuthorizeData> AuthorizationData { get { throw null; } }
        public Microsoft.AspNetCore.Http.Connections.LongPollingOptions LongPolling { get { throw null; } }
        public int MinimumProtocolVersion { get { throw null; } set { } }
        public long TransportMaxBufferSize { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.Connections.HttpTransportType Transports { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.Connections.WebSocketOptions WebSockets { get { throw null; } }
    }
    public partial class LongPollingOptions
    {
        public LongPollingOptions() { }
        public System.TimeSpan PollTimeout { get { throw null; } set { } }
    }
    public partial class NegotiateMetadata
    {
        public NegotiateMetadata() { }
    }
    internal static partial class ServerSentEventsMessageFormatter
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task WriteMessageAsync(System.Buffers.ReadOnlySequence<byte> payload, System.IO.Stream output, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class WebSocketOptions
    {
        public WebSocketOptions() { }
        public System.TimeSpan CloseTimeout { get { throw null; } set { } }
        public System.Func<System.Collections.Generic.IList<string>, string> SubProtocolSelector { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Http.Connections.Features
{
    public partial interface IHttpContextFeature
    {
        Microsoft.AspNetCore.Http.HttpContext HttpContext { get; set; }
    }
    public partial interface IHttpTransportFeature
    {
        Microsoft.AspNetCore.Http.Connections.HttpTransportType TransportType { get; }
    }
}
namespace Microsoft.AspNetCore.Http.Connections.Internal
{
    internal partial class ConnectionLogScope : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public ConnectionLogScope(string connectionId) { }
        public string ConnectionId { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    internal partial class HttpConnectionContext : Microsoft.AspNetCore.Connections.ConnectionContext, Microsoft.AspNetCore.Connections.Features.IConnectionHeartbeatFeature, Microsoft.AspNetCore.Connections.Features.IConnectionIdFeature, Microsoft.AspNetCore.Connections.Features.IConnectionInherentKeepAliveFeature, Microsoft.AspNetCore.Connections.Features.IConnectionItemsFeature, Microsoft.AspNetCore.Connections.Features.IConnectionTransportFeature, Microsoft.AspNetCore.Connections.Features.IConnectionUserFeature, Microsoft.AspNetCore.Connections.Features.ITransferFormatFeature, Microsoft.AspNetCore.Http.Connections.Features.IHttpContextFeature, Microsoft.AspNetCore.Http.Connections.Features.IHttpTransportFeature
    {
        internal HttpConnectionContext(string id, System.IO.Pipelines.IDuplexPipe transport, System.IO.Pipelines.IDuplexPipe application, Microsoft.Extensions.Logging.ILogger logger = null) { }
        public HttpConnectionContext(string connectionId, string connectionToken, Microsoft.Extensions.Logging.ILogger logger) { }
        public Microsoft.AspNetCore.Connections.TransferFormat ActiveFormat { get { throw null; } set { } }
        public System.IO.Pipelines.IDuplexPipe Application { get { throw null; } set { } }
        internal System.IO.Pipelines.PipeWriterStream ApplicationStream { get { throw null; } }
        public System.Threading.Tasks.Task ApplicationTask { get { throw null; } set { } }
        public System.Threading.CancellationTokenSource Cancellation { get { throw null; } set { } }
        public override string ConnectionId { get { throw null; } set { } }
        internal string ConnectionToken { get { throw null; } set { } }
        internal System.Threading.Tasks.Task DisposeAndRemoveTask { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        public bool HasInherentKeepAlive { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.HttpContext HttpContext { get { throw null; } set { } }
        public override System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } set { } }
        public System.DateTime LastSeenUtc { get { throw null; } set { } }
        public System.DateTime? LastSeenUtcIfInactive { get { throw null; } }
        public System.Threading.Tasks.Task PreviousPollTask { get { throw null; } set { } }
        internal System.Threading.CancellationToken SendingToken { get { throw null; } }
        public Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionStatus Status { get { throw null; } set { } }
        public Microsoft.AspNetCore.Connections.TransferFormat SupportedFormats { get { throw null; } set { } }
        public override System.IO.Pipelines.IDuplexPipe Transport { get { throw null; } set { } }
        public System.Threading.Tasks.Task TransportTask { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.Connections.HttpTransportType TransportType { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } set { } }
        public System.Threading.SemaphoreSlim WriteLock { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<bool> CancelPreviousPoll(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task DisposeAsync(bool closeGracefully = false) { throw null; }
        public void MarkInactive() { }
        public void OnHeartbeat(System.Action<object> action, object state) { }
        internal void StartSendCancellation() { }
        internal void StopSendCancellation() { }
        public void TickHeartbeat() { }
        public bool TryActivateLongPollingConnection(Microsoft.AspNetCore.Connections.ConnectionDelegate connectionDelegate, Microsoft.AspNetCore.Http.HttpContext nonClonedContext, System.TimeSpan pollTimeout, System.Threading.Tasks.Task currentRequestTask, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Logging.ILogger dispatcherLogger) { throw null; }
        internal bool TryActivatePersistentConnection(Microsoft.AspNetCore.Connections.ConnectionDelegate connectionDelegate, Microsoft.AspNetCore.Http.Connections.Internal.Transports.IHttpTransport transport, Microsoft.Extensions.Logging.ILogger dispatcherLogger) { throw null; }
        internal void TryCancelSend(long currentTicks) { }
    }
    internal partial class HttpConnectionDispatcher
    {
        public HttpConnectionDispatcher(Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionManager manager, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions options, Microsoft.AspNetCore.Connections.ConnectionDelegate connectionDelegate) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteNegotiateAsync(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions options) { throw null; }
        internal static partial class Log
        {
            public static void CannotChangeTransport(Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Http.Connections.HttpTransportType transport, Microsoft.AspNetCore.Http.Connections.HttpTransportType requestTransport) { }
            public static void ConnectionAlreadyActive(Microsoft.Extensions.Logging.ILogger logger, string connectionId, string requestId) { }
            public static void ConnectionDisposed(Microsoft.Extensions.Logging.ILogger logger, string connectionId) { }
            public static void ConnectionDisposedWhileWriteInProgress(Microsoft.Extensions.Logging.ILogger logger, string connectionId, System.Exception ex) { }
            public static void EstablishedConnection(Microsoft.Extensions.Logging.ILogger logger) { }
            public static void FailedToReadHttpRequestBody(Microsoft.Extensions.Logging.ILogger logger, string connectionId, System.Exception ex) { }
            public static void InvalidNegotiateProtocolVersion(Microsoft.Extensions.Logging.ILogger logger, string requestedProtocolVersion) { }
            public static void NegotiateProtocolVersionMismatch(Microsoft.Extensions.Logging.ILogger logger, int clientProtocolVersion) { }
            public static void NegotiationRequest(Microsoft.Extensions.Logging.ILogger logger) { }
            public static void PollCanceled(Microsoft.Extensions.Logging.ILogger logger, string connectionId, string requestId) { }
            public static void PostNotAllowedForWebSockets(Microsoft.Extensions.Logging.ILogger logger) { }
            public static void ReceivedBytes(Microsoft.Extensions.Logging.ILogger logger, long count) { }
            public static void ReceivedDeleteRequestForUnsupportedTransport(Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Http.Connections.HttpTransportType transportType) { }
            public static void ResumingConnection(Microsoft.Extensions.Logging.ILogger logger) { }
            public static void TerminatingConection(Microsoft.Extensions.Logging.ILogger logger) { }
            public static void TransportNotSupported(Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Http.Connections.HttpTransportType transport) { }
        }
    }
    internal partial class HttpConnectionManager
    {
        public HttpConnectionManager(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Hosting.IHostApplicationLifetime appLifetime) { }
        public HttpConnectionManager(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Hosting.IHostApplicationLifetime appLifetime, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Http.Connections.ConnectionOptions> connectionOptions) { }
        public void CloseConnections() { }
        internal Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext CreateConnection() { throw null; }
        internal Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext CreateConnection(System.IO.Pipelines.PipeOptions transportPipeOptions, System.IO.Pipelines.PipeOptions appPipeOptions, int negotiateVersion = 0) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task DisposeAndRemoveAsync(Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext connection, bool closeGracefully) { throw null; }
        public void RemoveConnection(string id) { }
        public void Scan() { }
        public void Start() { }
        internal bool TryGetConnection(string id, out Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext connection) { throw null; }
    }
    internal partial class HttpConnectionsEventSource : System.Diagnostics.Tracing.EventSource
    {
        public static readonly Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionsEventSource Log;
        internal HttpConnectionsEventSource() { }
        internal HttpConnectionsEventSource(string eventSourceName) { }
        [System.Diagnostics.Tracing.EventAttribute(1, Level=System.Diagnostics.Tracing.EventLevel.Informational, Message="Started connection '{0}'.")]
        public Microsoft.Extensions.Internal.ValueStopwatch ConnectionStart(string connectionId) { throw null; }
        [System.Diagnostics.Tracing.NonEventAttribute]
        public void ConnectionStop(string connectionId, Microsoft.Extensions.Internal.ValueStopwatch timer) { }
        [System.Diagnostics.Tracing.EventAttribute(3, Level=System.Diagnostics.Tracing.EventLevel.Informational, Message="Connection '{0}' timed out.")]
        public void ConnectionTimedOut(string connectionId) { }
        protected override void OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs command) { }
    }
    internal enum HttpConnectionStatus
    {
        Inactive = 0,
        Active = 1,
        Disposed = 2,
    }
}
namespace Microsoft.AspNetCore.Http.Connections.Internal.Transports
{
    internal partial interface IHttpTransport
    {
        System.Threading.Tasks.Task ProcessRequestAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Threading.CancellationToken token);
    }
    internal partial class LongPollingServerTransport : Microsoft.AspNetCore.Http.Connections.Internal.Transports.IHttpTransport
    {
        public LongPollingServerTransport(System.Threading.CancellationToken timeoutToken, System.IO.Pipelines.PipeReader application, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public LongPollingServerTransport(System.Threading.CancellationToken timeoutToken, System.IO.Pipelines.PipeReader application, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext connection) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ProcessRequestAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Threading.CancellationToken token) { throw null; }
    }
    internal partial class ServerSentEventsServerTransport : Microsoft.AspNetCore.Http.Connections.Internal.Transports.IHttpTransport
    {
        public ServerSentEventsServerTransport(System.IO.Pipelines.PipeReader application, string connectionId, Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext connection, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public ServerSentEventsServerTransport(System.IO.Pipelines.PipeReader application, string connectionId, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ProcessRequestAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Threading.CancellationToken token) { throw null; }
    }
    internal partial class WebSocketsServerTransport : Microsoft.AspNetCore.Http.Connections.Internal.Transports.IHttpTransport
    {
        public WebSocketsServerTransport(Microsoft.AspNetCore.Http.Connections.WebSocketOptions options, System.IO.Pipelines.IDuplexPipe application, Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext connection, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ProcessRequestAsync(Microsoft.AspNetCore.Http.HttpContext context, System.Threading.CancellationToken token) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ProcessSocketAsync(System.Net.WebSockets.WebSocket socket) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Internal
{
    internal static partial class AwaitableThreadPool
    {
        public static Microsoft.AspNetCore.Internal.AwaitableThreadPool.Awaitable Yield() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
        public readonly partial struct Awaitable : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            public bool IsCompleted { get { throw null; } }
            public Microsoft.AspNetCore.Internal.AwaitableThreadPool.Awaitable GetAwaiter() { throw null; }
            public void GetResult() { }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    internal sealed partial class MemoryBufferWriter : System.IO.Stream, System.Buffers.IBufferWriter<byte>
    {
        public MemoryBufferWriter(int minimumSegmentSize = 4096) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public void Advance(int count) { }
        public void CopyTo(System.Buffers.IBufferWriter<byte> destination) { }
        public void CopyTo(System.Span<byte> span) { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public static Microsoft.AspNetCore.Internal.MemoryBufferWriter Get() { throw null; }
        public System.Memory<byte> GetMemory(int sizeHint = 0) { throw null; }
        public System.Span<byte> GetSpan(int sizeHint = 0) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public void Reset() { }
        public static void Return(Microsoft.AspNetCore.Internal.MemoryBufferWriter writer) { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public byte[] ToArray() { throw null; }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> span) { }
        public override void WriteByte(byte value) { }
    }
    internal static partial class TaskCache
    {
        public static readonly System.Threading.Tasks.Task<bool> False;
        public static readonly System.Threading.Tasks.Task<bool> True;
    }
    internal partial class TimerAwaitable : System.IDisposable, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        public TimerAwaitable(System.TimeSpan dueTime, System.TimeSpan period) { }
        public bool IsCompleted { get { throw null; } }
        public Microsoft.AspNetCore.Internal.TimerAwaitable GetAwaiter() { throw null; }
        public bool GetResult() { throw null; }
        public void OnCompleted(System.Action continuation) { }
        public void Start() { }
        public void Stop() { }
        void System.IDisposable.Dispose() { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    internal static partial class ValueTaskExtensions
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Threading.Tasks.Task GetAsTask(this in System.Threading.Tasks.ValueTask<System.IO.Pipelines.FlushResult> valueTask) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ConnectionsDependencyInjectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddConnections(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddConnections(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Http.Connections.ConnectionOptions> options) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal static partial class SecurityHelper
    {
        public static System.Security.Claims.ClaimsPrincipal MergeUserPrincipal(System.Security.Claims.ClaimsPrincipal existingPrincipal, System.Security.Claims.ClaimsPrincipal additionalPrincipal) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ValueStopwatch
    {
        private int _dummyPrimitive;
        public bool IsActive { get { throw null; } }
        public System.TimeSpan GetElapsedTime() { throw null; }
        public static Microsoft.Extensions.Internal.ValueStopwatch StartNew() { throw null; }
    }
    internal static partial class WebEncoders
    {
        public static byte[] Base64UrlDecode(string input) { throw null; }
        public static byte[] Base64UrlDecode(string input, int offset, char[] buffer, int bufferOffset, int count) { throw null; }
        public static byte[] Base64UrlDecode(string input, int offset, int count) { throw null; }
        public static string Base64UrlEncode(byte[] input) { throw null; }
        public static int Base64UrlEncode(byte[] input, int offset, char[] output, int outputOffset, int count) { throw null; }
        public static string Base64UrlEncode(byte[] input, int offset, int count) { throw null; }
        public static string Base64UrlEncode(System.ReadOnlySpan<byte> input) { throw null; }
        public static int GetArraySizeRequiredToDecode(int count) { throw null; }
        public static int GetArraySizeRequiredToEncode(int count) { throw null; }
    }
}
namespace Microsoft.Extensions.WebEncoders.Sources
{
    internal static partial class EncoderResources
    {
        internal static readonly string WebEncoders_InvalidCountOffsetOrLength;
        internal static readonly string WebEncoders_MalformedInput;
        internal static string FormatWebEncoders_InvalidCountOffsetOrLength(object p0, object p1, object p2) { throw null; }
        internal static string FormatWebEncoders_MalformedInput(object p0) { throw null; }
    }
}
namespace System.IO
{
    internal static partial class StreamExtensions
    {
        public static System.Threading.Tasks.ValueTask WriteAsync(this System.IO.Stream stream, System.Buffers.ReadOnlySequence<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace System.IO.Pipelines
{
    internal partial class DuplexPipe : System.IO.Pipelines.IDuplexPipe
    {
        public DuplexPipe(System.IO.Pipelines.PipeReader reader, System.IO.Pipelines.PipeWriter writer) { }
        public System.IO.Pipelines.PipeReader Input { get { throw null; } }
        public System.IO.Pipelines.PipeWriter Output { get { throw null; } }
        public static System.IO.Pipelines.DuplexPipe.DuplexPipePair CreateConnectionPair(System.IO.Pipelines.PipeOptions inputOptions, System.IO.Pipelines.PipeOptions outputOptions) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct DuplexPipePair
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public DuplexPipePair(System.IO.Pipelines.IDuplexPipe transport, System.IO.Pipelines.IDuplexPipe application) { throw null; }
            public System.IO.Pipelines.IDuplexPipe Application { get { throw null; } }
            public System.IO.Pipelines.IDuplexPipe Transport { get { throw null; } }
        }
    }
    internal partial class PipeWriterStream : System.IO.Stream
    {
        public PipeWriterStream(System.IO.Pipelines.PipeWriter pipeWriter) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public void Reset() { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace System.Net.WebSockets
{
    internal static partial class WebSocketExtensions
    {
        public static System.Threading.Tasks.ValueTask SendAsync(this System.Net.WebSockets.WebSocket webSocket, System.Buffers.ReadOnlySequence<byte> buffer, System.Net.WebSockets.WebSocketMessageType webSocketMessageType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace System.Threading.Tasks
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct NoThrowAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NoThrowAwaiter(System.Threading.Tasks.Task task) { throw null; }
        public bool IsCompleted { get { throw null; } }
        public System.Threading.Tasks.NoThrowAwaiter GetAwaiter() { throw null; }
        public void GetResult() { }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    internal static partial class TaskExtensions
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task NoThrow(this System.Threading.Tasks.Task task) { throw null; }
    }
}
