// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Connections
{
    internal static partial class CorrelationIdGenerator
    {
        public static string GetNextId() { throw null; }
    }
    internal abstract partial class TransportConnection : Microsoft.AspNetCore.Connections.ConnectionContext, Microsoft.AspNetCore.Connections.Features.IConnectionIdFeature, Microsoft.AspNetCore.Connections.Features.IConnectionItemsFeature, Microsoft.AspNetCore.Connections.Features.IConnectionLifetimeFeature, Microsoft.AspNetCore.Connections.Features.IConnectionTransportFeature, Microsoft.AspNetCore.Connections.Features.IMemoryPoolFeature, Microsoft.AspNetCore.Http.Features.IFeatureCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, object>>, System.Collections.IEnumerable
    {
        public TransportConnection() { }
        public System.IO.Pipelines.IDuplexPipe Application { get { throw null; } set { } }
        public override System.Threading.CancellationToken ConnectionClosed { get { throw null; } set { } }
        public override string ConnectionId { get { throw null; } set { } }
        public override Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        public override System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } set { } }
        public override System.Net.EndPoint LocalEndPoint { get { throw null; } set { } }
        public virtual System.Buffers.MemoryPool<byte> MemoryPool { get { throw null; } }
        System.Collections.Generic.IDictionary<object, object> Microsoft.AspNetCore.Connections.Features.IConnectionItemsFeature.Items { get { throw null; } set { } }
        System.Threading.CancellationToken Microsoft.AspNetCore.Connections.Features.IConnectionLifetimeFeature.ConnectionClosed { get { throw null; } set { } }
        System.IO.Pipelines.IDuplexPipe Microsoft.AspNetCore.Connections.Features.IConnectionTransportFeature.Transport { get { throw null; } set { } }
        System.Buffers.MemoryPool<byte> Microsoft.AspNetCore.Connections.Features.IMemoryPoolFeature.MemoryPool { get { throw null; } }
        bool Microsoft.AspNetCore.Http.Features.IFeatureCollection.IsReadOnly { get { throw null; } }
        object Microsoft.AspNetCore.Http.Features.IFeatureCollection.this[System.Type key] { get { throw null; } set { } }
        int Microsoft.AspNetCore.Http.Features.IFeatureCollection.Revision { get { throw null; } }
        public override System.Net.EndPoint RemoteEndPoint { get { throw null; } set { } }
        public override System.IO.Pipelines.IDuplexPipe Transport { get { throw null; } set { } }
        public override void Abort(Microsoft.AspNetCore.Connections.ConnectionAbortedException abortReason) { }
        void Microsoft.AspNetCore.Connections.Features.IConnectionLifetimeFeature.Abort() { }
        TFeature Microsoft.AspNetCore.Http.Features.IFeatureCollection.Get<TFeature>() { throw null; }
        void Microsoft.AspNetCore.Http.Features.IFeatureCollection.Set<TFeature>(TFeature feature) { }
        internal void ResetFeatureCollection() { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
namespace Microsoft.AspNetCore.Hosting
{
    public static partial class WebHostBuilderSocketExtensions
    {
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseSockets(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseSockets(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.SocketTransportOptions> configureOptions) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
    internal sealed partial class SocketConnectionListener : Microsoft.AspNetCore.Connections.IConnectionListener, System.IAsyncDisposable
    {
        internal SocketConnectionListener(System.Net.EndPoint endpoint, Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.SocketTransportOptions options, Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.ISocketsTrace trace) { }
        public System.Net.EndPoint EndPoint { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask<Microsoft.AspNetCore.Connections.ConnectionContext> AcceptAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        internal void Bind() { }
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public System.Threading.Tasks.ValueTask UnbindAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal static partial class SocketsStrings
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string OnlyIPEndPointsSupported { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string TransportAlreadyBound { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public sealed partial class SocketTransportFactory : Microsoft.AspNetCore.Connections.IConnectionListenerFactory
    {
        public SocketTransportFactory(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.SocketTransportOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.ValueTask<Microsoft.AspNetCore.Connections.IConnectionListener> BindAsync(System.Net.EndPoint endpoint, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SocketTransportOptions
    {
        public SocketTransportOptions() { }
        public int IOQueueCount { get { throw null; } set { } }
        public long? MaxReadBufferSize { get { throw null; } set { } }
        public long? MaxWriteBufferSize { get { throw null; } set { } }
        internal System.Func<System.Buffers.MemoryPool<byte>> MemoryPoolFactory { get { throw null; } set { } }
        public bool NoDelay { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
    internal static partial class BufferExtensions
    {
        public static System.ArraySegment<byte> GetArray(this System.Memory<byte> memory) { throw null; }
        public static System.ArraySegment<byte> GetArray(this System.ReadOnlyMemory<byte> memory) { throw null; }
    }
    internal partial class IOQueue : System.IO.Pipelines.PipeScheduler, System.Threading.IThreadPoolWorkItem
    {
        public IOQueue() { }
        public override void Schedule(System.Action<object> action, object state) { }
        void System.Threading.IThreadPoolWorkItem.Execute() { }
    }
    internal partial interface ISocketsTrace : Microsoft.Extensions.Logging.ILogger
    {
        void ConnectionError(string connectionId, System.Exception ex);
        void ConnectionPause(string connectionId);
        void ConnectionReadFin(string connectionId);
        void ConnectionReset(string connectionId);
        void ConnectionResume(string connectionId);
        void ConnectionWriteFin(string connectionId, string reason);
    }
    internal partial class SocketAwaitableEventArgs : System.Net.Sockets.SocketAsyncEventArgs, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        public SocketAwaitableEventArgs(System.IO.Pipelines.PipeScheduler ioScheduler) { }
        public bool IsCompleted { get { throw null; } }
        public void Complete() { }
        public Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketAwaitableEventArgs GetAwaiter() { throw null; }
        public int GetResult() { throw null; }
        public void OnCompleted(System.Action continuation) { }
        protected override void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    internal sealed partial class SocketConnection : Microsoft.AspNetCore.Connections.TransportConnection
    {
        internal SocketConnection(System.Net.Sockets.Socket socket, System.Buffers.MemoryPool<byte> memoryPool, System.IO.Pipelines.PipeScheduler scheduler, Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.ISocketsTrace trace, long? maxReadBufferSize = default(long?), long? maxWriteBufferSize = default(long?)) { }
        public System.IO.Pipelines.PipeWriter Input { get { throw null; } }
        public override System.Buffers.MemoryPool<byte> MemoryPool { get { throw null; } }
        public System.IO.Pipelines.PipeReader Output { get { throw null; } }
        public override void Abort(Microsoft.AspNetCore.Connections.ConnectionAbortedException abortReason) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public void Start() { }
    }
    internal sealed partial class SocketReceiver : Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketSenderReceiverBase
    {
        public SocketReceiver(System.Net.Sockets.Socket socket, System.IO.Pipelines.PipeScheduler scheduler) : base (default(System.Net.Sockets.Socket), default(System.IO.Pipelines.PipeScheduler)) { }
        public Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketAwaitableEventArgs ReceiveAsync(System.Memory<byte> buffer) { throw null; }
        public Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketAwaitableEventArgs WaitForDataAsync() { throw null; }
    }
    internal sealed partial class SocketSender : Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketSenderReceiverBase
    {
        public SocketSender(System.Net.Sockets.Socket socket, System.IO.Pipelines.PipeScheduler scheduler) : base (default(System.Net.Sockets.Socket), default(System.IO.Pipelines.PipeScheduler)) { }
        public Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketAwaitableEventArgs SendAsync(in System.Buffers.ReadOnlySequence<byte> buffers) { throw null; }
    }
    internal abstract partial class SocketSenderReceiverBase : System.IDisposable
    {
        protected readonly Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.SocketAwaitableEventArgs _awaitableEventArgs;
        protected readonly System.Net.Sockets.Socket _socket;
        protected SocketSenderReceiverBase(System.Net.Sockets.Socket socket, System.IO.Pipelines.PipeScheduler scheduler) { }
        public void Dispose() { }
    }
    internal partial class SocketsTrace : Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal.ISocketsTrace, Microsoft.Extensions.Logging.ILogger
    {
        public SocketsTrace(Microsoft.Extensions.Logging.ILogger logger) { }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public void ConnectionError(string connectionId, System.Exception ex) { }
        public void ConnectionPause(string connectionId) { }
        public void ConnectionRead(string connectionId, int count) { }
        public void ConnectionReadFin(string connectionId) { }
        public void ConnectionReset(string connectionId) { }
        public void ConnectionResume(string connectionId) { }
        public void ConnectionWrite(string connectionId, int count) { }
        public void ConnectionWriteCallback(string connectionId, int status) { }
        public void ConnectionWriteFin(string connectionId, string reason) { }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
}
namespace System.Buffers
{
    internal partial class DiagnosticMemoryPool : System.Buffers.MemoryPool<byte>
    {
        public DiagnosticMemoryPool(System.Buffers.MemoryPool<byte> pool, bool allowLateReturn = false, bool rentTracking = false) { }
        public bool IsDisposed { get { throw null; } }
        public override int MaxBufferSize { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override System.Buffers.IMemoryOwner<byte> Rent(int size = -1) { throw null; }
        internal void ReportException(System.Exception exception) { }
        internal void Return(System.Buffers.DiagnosticPoolBlock block) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task WhenAllBlocksReturnedAsync(System.TimeSpan timeout) { throw null; }
    }
    internal sealed partial class DiagnosticPoolBlock : System.Buffers.MemoryManager<byte>
    {
        internal DiagnosticPoolBlock(System.Buffers.DiagnosticMemoryPool pool, System.Buffers.IMemoryOwner<byte> memoryOwner) { }
        public System.Diagnostics.StackTrace Leaser { get { throw null; } set { } }
        public override System.Memory<byte> Memory { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override System.Span<byte> GetSpan() { throw null; }
        public override System.Buffers.MemoryHandle Pin(int byteOffset = 0) { throw null; }
        public void Track() { }
        protected override bool TryGetArray(out System.ArraySegment<byte> segment) { throw null; }
        public override void Unpin() { }
    }
    internal sealed partial class MemoryPoolBlock : System.Buffers.IMemoryOwner<byte>, System.IDisposable
    {
        internal MemoryPoolBlock(System.Buffers.SlabMemoryPool pool, System.Buffers.MemoryPoolSlab slab, int offset, int length) { }
        public System.Memory<byte> Memory { get { throw null; } }
        public System.Buffers.SlabMemoryPool Pool { get { throw null; } }
        public System.Buffers.MemoryPoolSlab Slab { get { throw null; } }
        public void Dispose() { }
        ~MemoryPoolBlock() { }
        public void Lease() { }
    }
    internal partial class MemoryPoolSlab : System.IDisposable
    {
        public MemoryPoolSlab(byte[] data) { }
        public byte[] Array { get { throw null; } }
        public bool IsActive { get { throw null; } }
        public System.IntPtr NativePointer { get { throw null; } }
        public static System.Buffers.MemoryPoolSlab Create(int length) { throw null; }
        public void Dispose() { }
        protected void Dispose(bool disposing) { }
        ~MemoryPoolSlab() { }
    }
    internal partial class MemoryPoolThrowHelper
    {
        public MemoryPoolThrowHelper() { }
        public static void ThrowArgumentOutOfRangeException(int sourceLength, int offset) { }
        public static void ThrowArgumentOutOfRangeException_BufferRequestTooLarge(int maxSize) { }
        public static void ThrowInvalidOperationException_BlockDoubleDispose(System.Buffers.DiagnosticPoolBlock block) { }
        public static void ThrowInvalidOperationException_BlockIsBackedByDisposedSlab(System.Buffers.DiagnosticPoolBlock block) { }
        public static void ThrowInvalidOperationException_BlockReturnedToDisposedPool(System.Buffers.DiagnosticPoolBlock block) { }
        public static void ThrowInvalidOperationException_BlocksWereNotReturnedInTime(int returned, int total, System.Buffers.DiagnosticPoolBlock[] blocks) { }
        public static void ThrowInvalidOperationException_DisposingPoolWithActiveBlocks(int returned, int total, System.Buffers.DiagnosticPoolBlock[] blocks) { }
        public static void ThrowInvalidOperationException_DoubleDispose() { }
        public static void ThrowInvalidOperationException_PinCountZero(System.Buffers.DiagnosticPoolBlock block) { }
        public static void ThrowInvalidOperationException_ReturningPinnedBlock(System.Buffers.DiagnosticPoolBlock block) { }
        public static void ThrowObjectDisposedException(System.Buffers.MemoryPoolThrowHelper.ExceptionArgument argument) { }
        internal enum ExceptionArgument
        {
            size = 0,
            offset = 1,
            length = 2,
            MemoryPoolBlock = 3,
            MemoryPool = 4,
        }
    }
    internal sealed partial class SlabMemoryPool : System.Buffers.MemoryPool<byte>
    {
        public SlabMemoryPool() { }
        public static int BlockSize { get { throw null; } }
        public override int MaxBufferSize { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        internal void RefreshBlock(System.Buffers.MemoryPoolSlab slab, int offset, int length) { }
        public override System.Buffers.IMemoryOwner<byte> Rent(int size = -1) { throw null; }
        internal void Return(System.Buffers.MemoryPoolBlock block) { }
    }
    internal static partial class SlabMemoryPoolFactory
    {
        public static System.Buffers.MemoryPool<byte> Create() { throw null; }
        public static System.Buffers.MemoryPool<byte> CreateSlabMemoryPool() { throw null; }
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
}
