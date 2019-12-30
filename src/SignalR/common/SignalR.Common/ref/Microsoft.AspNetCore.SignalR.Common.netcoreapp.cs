// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Internal
{
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
    internal sealed partial class ReusableUtf8JsonWriter
    {
        public ReusableUtf8JsonWriter(System.Buffers.IBufferWriter<byte> stream) { }
        public static Microsoft.AspNetCore.Internal.ReusableUtf8JsonWriter Get(System.Buffers.IBufferWriter<byte> stream) { throw null; }
        public System.Text.Json.Utf8JsonWriter GetJsonWriter() { throw null; }
        public static void Return(Microsoft.AspNetCore.Internal.ReusableUtf8JsonWriter writer) { }
    }
    internal static partial class SystemTextJsonExtensions
    {
        public static bool CheckRead(this ref System.Text.Json.Utf8JsonReader reader) { throw null; }
        public static void EnsureArrayStart(this ref System.Text.Json.Utf8JsonReader reader) { }
        public static void EnsureObjectStart(this ref System.Text.Json.Utf8JsonReader reader) { }
        public static string GetTokenString(System.Text.Json.JsonTokenType tokenType) { throw null; }
        public static string GetTokenString(this ref System.Text.Json.Utf8JsonReader reader) { throw null; }
        public static bool ReadAsBoolean(this ref System.Text.Json.Utf8JsonReader reader, string propertyName) { throw null; }
        public static int? ReadAsInt32(this ref System.Text.Json.Utf8JsonReader reader, string propertyName) { throw null; }
        public static string ReadAsString(this ref System.Text.Json.Utf8JsonReader reader, string propertyName) { throw null; }
    }
    internal static partial class TextMessageFormatter
    {
        public static readonly byte RecordSeparator;
        public static void WriteRecordSeparator(System.Buffers.IBufferWriter<byte> output) { }
    }
    internal static partial class TextMessageParser
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool TryParseMessage(ref System.Buffers.ReadOnlySequence<byte> buffer, out System.Buffers.ReadOnlySequence<byte> payload) { throw null; }
    }
    internal sealed partial class Utf8BufferTextWriter : System.IO.TextWriter
    {
        public Utf8BufferTextWriter() { }
        public override System.Text.Encoding Encoding { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public static Microsoft.AspNetCore.Internal.Utf8BufferTextWriter Get(System.Buffers.IBufferWriter<byte> bufferWriter) { throw null; }
        public static void Return(Microsoft.AspNetCore.Internal.Utf8BufferTextWriter writer) { }
        public void SetWriter(System.Buffers.IBufferWriter<byte> bufferWriter) { }
        public override void Write(char value) { }
        public override void Write(char[] buffer) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(string value) { }
    }
}
namespace Microsoft.AspNetCore.SignalR
{
    public partial class HubException : System.Exception
    {
        public HubException() { }
        public HubException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public HubException(string message) { }
        public HubException(string message, System.Exception innerException) { }
    }
    public partial interface IInvocationBinder
    {
        System.Collections.Generic.IReadOnlyList<System.Type> GetParameterTypes(string methodName);
        System.Type GetReturnType(string invocationId);
        System.Type GetStreamItemType(string streamId);
    }
    public partial interface ISignalRBuilder
    {
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
}
namespace Microsoft.AspNetCore.SignalR.Internal
{
    internal sealed partial class Utf8BufferTextReader : System.IO.TextReader
    {
        public Utf8BufferTextReader() { }
        public static Microsoft.AspNetCore.SignalR.Internal.Utf8BufferTextReader Get(in System.Buffers.ReadOnlySequence<byte> utf8Buffer) { throw null; }
        public override int Read(char[] buffer, int index, int count) { throw null; }
        public static void Return(Microsoft.AspNetCore.SignalR.Internal.Utf8BufferTextReader reader) { }
        public void SetBuffer(in System.Buffers.ReadOnlySequence<byte> utf8Buffer) { }
    }
}
namespace Microsoft.AspNetCore.SignalR.Protocol
{
    public partial class CancelInvocationMessage : Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage
    {
        public CancelInvocationMessage(string invocationId) : base (default(string)) { }
    }
    public partial class CloseMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        public static readonly Microsoft.AspNetCore.SignalR.Protocol.CloseMessage Empty;
        public CloseMessage(string error) { }
        public CloseMessage(string error, bool allowReconnect) { }
        public bool AllowReconnect { get { throw null; } }
        public string Error { get { throw null; } }
    }
    public partial class CompletionMessage : Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage
    {
        public CompletionMessage(string invocationId, string error, object result, bool hasResult) : base (default(string)) { }
        public string Error { get { throw null; } }
        public bool HasResult { get { throw null; } }
        public object Result { get { throw null; } }
        public static Microsoft.AspNetCore.SignalR.Protocol.CompletionMessage Empty(string invocationId) { throw null; }
        public override string ToString() { throw null; }
        public static Microsoft.AspNetCore.SignalR.Protocol.CompletionMessage WithError(string invocationId, string error) { throw null; }
        public static Microsoft.AspNetCore.SignalR.Protocol.CompletionMessage WithResult(string invocationId, object payload) { throw null; }
    }
    public static partial class HandshakeProtocol
    {
        public static System.ReadOnlySpan<byte> GetSuccessfulHandshake(Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol protocol) { throw null; }
        public static bool TryParseRequestMessage(ref System.Buffers.ReadOnlySequence<byte> buffer, out Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage requestMessage) { throw null; }
        public static bool TryParseResponseMessage(ref System.Buffers.ReadOnlySequence<byte> buffer, out Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage responseMessage) { throw null; }
        public static void WriteRequestMessage(Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage requestMessage, System.Buffers.IBufferWriter<byte> output) { }
        public static void WriteResponseMessage(Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage responseMessage, System.Buffers.IBufferWriter<byte> output) { }
    }
    public partial class HandshakeRequestMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        public HandshakeRequestMessage(string protocol, int version) { }
        public string Protocol { get { throw null; } }
        public int Version { get { throw null; } }
    }
    public partial class HandshakeResponseMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        public static readonly Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage Empty;
        public HandshakeResponseMessage(string error) { }
        public string Error { get { throw null; } }
    }
    public abstract partial class HubInvocationMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        protected HubInvocationMessage(string invocationId) { }
        public System.Collections.Generic.IDictionary<string, string> Headers { get { throw null; } set { } }
        public string InvocationId { get { throw null; } }
    }
    public abstract partial class HubMessage
    {
        protected HubMessage() { }
    }
    public abstract partial class HubMethodInvocationMessage : Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage
    {
        protected HubMethodInvocationMessage(string invocationId, string target, object[] arguments) : base (default(string)) { }
        protected HubMethodInvocationMessage(string invocationId, string target, object[] arguments, string[] streamIds) : base (default(string)) { }
        public object[] Arguments { get { throw null; } }
        public string[] StreamIds { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public static partial class HubProtocolConstants
    {
        public const int CancelInvocationMessageType = 5;
        public const int CloseMessageType = 7;
        public const int CompletionMessageType = 3;
        public const int InvocationMessageType = 1;
        public const int PingMessageType = 6;
        public const int StreamInvocationMessageType = 4;
        public const int StreamItemMessageType = 2;
    }
    public static partial class HubProtocolExtensions
    {
        public static byte[] GetMessageBytes(this Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol hubProtocol, Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { throw null; }
    }
    public partial interface IHubProtocol
    {
        string Name { get; }
        Microsoft.AspNetCore.Connections.TransferFormat TransferFormat { get; }
        int Version { get; }
        System.ReadOnlyMemory<byte> GetMessageBytes(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message);
        bool IsVersionSupported(int version);
        bool TryParseMessage(ref System.Buffers.ReadOnlySequence<byte> input, Microsoft.AspNetCore.SignalR.IInvocationBinder binder, out Microsoft.AspNetCore.SignalR.Protocol.HubMessage message);
        void WriteMessage(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message, System.Buffers.IBufferWriter<byte> output);
    }
    public partial class InvocationBindingFailureMessage : Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage
    {
        public InvocationBindingFailureMessage(string invocationId, string target, System.Runtime.ExceptionServices.ExceptionDispatchInfo bindingFailure) : base (default(string)) { }
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo BindingFailure { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public partial class InvocationMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMethodInvocationMessage
    {
        public InvocationMessage(string target, object[] arguments) : base (default(string), default(string), default(object[]), default(string[])) { }
        public InvocationMessage(string invocationId, string target, object[] arguments) : base (default(string), default(string), default(object[]), default(string[])) { }
        public InvocationMessage(string invocationId, string target, object[] arguments, string[] streamIds) : base (default(string), default(string), default(object[]), default(string[])) { }
        public override string ToString() { throw null; }
    }
    public partial class PingMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        private PingMessage() { }
        public static readonly Microsoft.AspNetCore.SignalR.Protocol.PingMessage Instance;
    }
    public partial class StreamBindingFailureMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMessage
    {
        public StreamBindingFailureMessage(string id, System.Runtime.ExceptionServices.ExceptionDispatchInfo bindingFailure) { }
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo BindingFailure { get { throw null; } }
        public string Id { get { throw null; } }
    }
    public partial class StreamInvocationMessage : Microsoft.AspNetCore.SignalR.Protocol.HubMethodInvocationMessage
    {
        public StreamInvocationMessage(string invocationId, string target, object[] arguments) : base (default(string), default(string), default(object[]), default(string[])) { }
        public StreamInvocationMessage(string invocationId, string target, object[] arguments, string[] streamIds) : base (default(string), default(string), default(object[]), default(string[])) { }
        public override string ToString() { throw null; }
    }
    public partial class StreamItemMessage : Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage
    {
        public StreamItemMessage(string invocationId, object item) : base (default(string)) { }
        public object Item { get { throw null; } }
        public override string ToString() { throw null; }
    }
}
