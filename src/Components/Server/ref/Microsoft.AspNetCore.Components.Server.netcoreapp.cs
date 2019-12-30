// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace MessagePack
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal ref partial struct BufferWriter
    {
        private object _dummy;
        private int _dummyPrimitive;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal BufferWriter(MessagePack.SequencePool sequencePool, byte[] array) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public BufferWriter(System.Buffers.IBufferWriter<byte> output) { throw null; }
        public long BytesCommitted { get { throw null; } }
        internal MessagePack.SequencePool.Rental SequenceRental { get { throw null; } }
        public System.Span<byte> Span { get { throw null; } }
        internal System.Buffers.IBufferWriter<byte> UnderlyingWriter { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Advance(int count) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Commit() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Ensure(int count = 1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public ref byte GetPointer(int sizeHint) { throw null; }
        public System.Span<byte> GetSpan(int sizeHint) { throw null; }
        internal bool TryGetUncommittedSpan(out System.ReadOnlySpan<byte> span) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Write(System.ReadOnlySpan<byte> source) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ExtensionHeader
    {
        private int _dummyPrimitive;
        public ExtensionHeader(sbyte typeCode, int length) { throw null; }
        public ExtensionHeader(sbyte typeCode, uint length) { throw null; }
        public uint Length { get { throw null; } }
        public sbyte TypeCode { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ExtensionResult
    {
        private object _dummy;
        private int _dummyPrimitive;
        public ExtensionResult(sbyte typeCode, System.Buffers.ReadOnlySequence<byte> data) { throw null; }
        public ExtensionResult(sbyte typeCode, System.Memory<byte> data) { throw null; }
        public System.Buffers.ReadOnlySequence<byte> Data { get { throw null; } }
        public MessagePack.ExtensionHeader Header { get { throw null; } }
        public sbyte TypeCode { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    internal partial struct Float32Bits
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly byte Byte0;
        [System.Runtime.InteropServices.FieldOffsetAttribute(1)]
        public readonly byte Byte1;
        [System.Runtime.InteropServices.FieldOffsetAttribute(2)]
        public readonly byte Byte2;
        [System.Runtime.InteropServices.FieldOffsetAttribute(3)]
        public readonly byte Byte3;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly float Value;
        public Float32Bits(System.ReadOnlySpan<byte> bigEndianBytes) { throw null; }
        public Float32Bits(float value) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    internal partial struct Float64Bits
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly byte Byte0;
        [System.Runtime.InteropServices.FieldOffsetAttribute(1)]
        public readonly byte Byte1;
        [System.Runtime.InteropServices.FieldOffsetAttribute(2)]
        public readonly byte Byte2;
        [System.Runtime.InteropServices.FieldOffsetAttribute(3)]
        public readonly byte Byte3;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public readonly byte Byte4;
        [System.Runtime.InteropServices.FieldOffsetAttribute(5)]
        public readonly byte Byte5;
        [System.Runtime.InteropServices.FieldOffsetAttribute(6)]
        public readonly byte Byte6;
        [System.Runtime.InteropServices.FieldOffsetAttribute(7)]
        public readonly byte Byte7;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly double Value;
        public Float64Bits(double value) { throw null; }
        public Float64Bits(System.ReadOnlySpan<byte> bigEndianBytes) { throw null; }
    }
    internal static partial class MessagePackCode
    {
        public const byte Array16 = (byte)220;
        public const byte Array32 = (byte)221;
        public const byte Bin16 = (byte)197;
        public const byte Bin32 = (byte)198;
        public const byte Bin8 = (byte)196;
        public const byte Ext16 = (byte)200;
        public const byte Ext32 = (byte)201;
        public const byte Ext8 = (byte)199;
        public const byte False = (byte)194;
        public const byte FixExt1 = (byte)212;
        public const byte FixExt16 = (byte)216;
        public const byte FixExt2 = (byte)213;
        public const byte FixExt4 = (byte)214;
        public const byte FixExt8 = (byte)215;
        public const byte Float32 = (byte)202;
        public const byte Float64 = (byte)203;
        public const byte Int16 = (byte)209;
        public const byte Int32 = (byte)210;
        public const byte Int64 = (byte)211;
        public const byte Int8 = (byte)208;
        public const byte Map16 = (byte)222;
        public const byte Map32 = (byte)223;
        public const byte MaxFixArray = (byte)159;
        public const byte MaxFixInt = (byte)127;
        public const byte MaxFixMap = (byte)143;
        public const byte MaxFixStr = (byte)191;
        public const byte MaxNegativeFixInt = (byte)255;
        public const byte MinFixArray = (byte)144;
        public const byte MinFixInt = (byte)0;
        public const byte MinFixMap = (byte)128;
        public const byte MinFixStr = (byte)160;
        public const byte MinNegativeFixInt = (byte)224;
        public const byte NeverUsed = (byte)193;
        public const byte Nil = (byte)192;
        public const byte Str16 = (byte)218;
        public const byte Str32 = (byte)219;
        public const byte Str8 = (byte)217;
        public const byte True = (byte)195;
        public const byte UInt16 = (byte)205;
        public const byte UInt32 = (byte)206;
        public const byte UInt64 = (byte)207;
        public const byte UInt8 = (byte)204;
        public static bool IsSignedInteger(byte code) { throw null; }
        public static string ToFormatName(byte code) { throw null; }
        public static MessagePack.MessagePackType ToMessagePackType(byte code) { throw null; }
    }
    internal static partial class MessagePackRange
    {
        public const int MaxFixArrayCount = 15;
        public const int MaxFixMapCount = 15;
        public const int MaxFixNegativeInt = -1;
        public const int MaxFixPositiveInt = 127;
        public const int MaxFixStringLength = 31;
        public const int MinFixNegativeInt = -32;
        public const int MinFixStringLength = 0;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal ref partial struct MessagePackReader
    {
        private object _dummy;
        private int _dummyPrimitive;
        public MessagePackReader(System.Buffers.ReadOnlySequence<byte> readOnlySequence) { throw null; }
        public MessagePackReader(System.ReadOnlyMemory<byte> memory) { throw null; }
        public long Consumed { get { throw null; } }
        public bool End { get { throw null; } }
        public bool IsNil { get { throw null; } }
        public byte NextCode { get { throw null; } }
        public MessagePack.MessagePackType NextMessagePackType { get { throw null; } }
        public System.SequencePosition Position { get { throw null; } }
        public System.Buffers.ReadOnlySequence<byte> Sequence { get { throw null; } }
        public MessagePack.MessagePackReader Clone(System.Buffers.ReadOnlySequence<byte> readOnlySequence) { throw null; }
        public MessagePack.MessagePackReader CreatePeekReader() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public int ReadArrayHeader() { throw null; }
        public bool ReadBoolean() { throw null; }
        public byte ReadByte() { throw null; }
        public System.Buffers.ReadOnlySequence<byte> ReadBytes() { throw null; }
        public char ReadChar() { throw null; }
        public System.DateTime ReadDateTime() { throw null; }
        internal System.DateTime ReadDateTime(MessagePack.ExtensionHeader header) { throw null; }
        public double ReadDouble() { throw null; }
        public MessagePack.ExtensionResult ReadExtensionFormat() { throw null; }
        public MessagePack.ExtensionHeader ReadExtensionFormatHeader() { throw null; }
        public short ReadInt16() { throw null; }
        public int ReadInt32() { throw null; }
        public long ReadInt64() { throw null; }
        public int ReadMapHeader() { throw null; }
        public MessagePack.Nil ReadNil() { throw null; }
        public System.Buffers.ReadOnlySequence<byte> ReadRaw(long length) { throw null; }
        public sbyte ReadSByte() { throw null; }
        public float ReadSingle() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public string ReadString() { throw null; }
        public System.Buffers.ReadOnlySequence<byte> ReadStringSegment() { throw null; }
        public ushort ReadUInt16() { throw null; }
        public uint ReadUInt32() { throw null; }
        public ulong ReadUInt64() { throw null; }
        public void Skip() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public bool TryReadNil() { throw null; }
    }
    internal enum MessagePackType : byte
    {
        Unknown = (byte)0,
        Integer = (byte)1,
        Nil = (byte)2,
        Boolean = (byte)3,
        Float = (byte)4,
        String = (byte)5,
        Binary = (byte)6,
        Array = (byte)7,
        Map = (byte)8,
        Extension = (byte)9,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal ref partial struct MessagePackWriter
    {
        private object _dummy;
        private int _dummyPrimitive;
        internal MessagePackWriter(MessagePack.SequencePool sequencePool, byte[] array) { throw null; }
        public MessagePackWriter(System.Buffers.IBufferWriter<byte> writer) { throw null; }
        public bool OldSpec { get { throw null; } set { } }
        internal void Advance(int length) { }
        public MessagePack.MessagePackWriter Clone(System.Buffers.IBufferWriter<byte> writer) { throw null; }
        public void Flush() { }
        internal byte[] FlushAndGetArray() { throw null; }
        internal System.Span<byte> GetSpan(int length) { throw null; }
        public void Write(bool value) { }
        public void Write(System.Buffers.ReadOnlySequence<byte> src) { }
        public void Write(byte value) { }
        public void Write(char value) { }
        public void Write(System.DateTime dateTime) { }
        public void Write(double value) { }
        public void Write(short value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Write(int value) { }
        public void Write(long value) { }
        public void Write(System.ReadOnlySpan<byte> src) { }
        public void Write(System.ReadOnlySpan<char> value) { }
        public void Write(sbyte value) { }
        public void Write(float value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Write(string value) { }
        public void Write(ushort value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Write(uint value) { }
        public void Write(ulong value) { }
        public void WriteArrayHeader(int count) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void WriteArrayHeader(uint count) { }
        internal void WriteBigEndian(ushort value) { }
        internal void WriteBigEndian(uint value) { }
        internal void WriteBigEndian(ulong value) { }
        public void WriteExtensionFormat(MessagePack.ExtensionResult extensionData) { }
        public void WriteExtensionFormatHeader(MessagePack.ExtensionHeader extensionHeader) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void WriteFixedArrayHeaderUnsafe(uint count) { }
        public void WriteInt16(short value) { }
        public void WriteInt32(int value) { }
        public void WriteInt64(long value) { }
        public void WriteInt8(sbyte value) { }
        public void WriteMapHeader(int count) { }
        public void WriteMapHeader(uint count) { }
        public void WriteNil() { }
        public void WriteRaw(System.Buffers.ReadOnlySequence<byte> rawMessagePackBlock) { }
        public void WriteRaw(System.ReadOnlySpan<byte> rawMessagePackBlock) { }
        public void WriteString(System.Buffers.ReadOnlySequence<byte> utf8stringBytes) { }
        public void WriteString(System.ReadOnlySpan<byte> utf8stringBytes) { }
        public void WriteUInt16(ushort value) { }
        public void WriteUInt32(uint value) { }
        public void WriteUInt64(ulong value) { }
        public void WriteUInt8(byte value) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    internal partial struct Nil : System.IEquatable<MessagePack.Nil>
    {
        public static readonly MessagePack.Nil Default;
        public bool Equals(MessagePack.Nil other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    internal static partial class ReservedMessagePackExtensionTypeCode
    {
        public const sbyte DateTime = (sbyte)-1;
    }
    internal partial class SequencePool
    {
        internal SequencePool(int maxSize) { }
        internal MessagePack.SequencePool.Rental Rent() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct Rental : System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Rental(MessagePack.SequencePool owner, Nerdbank.Streams.Sequence<byte> value) { throw null; }
            public Nerdbank.Streams.Sequence<byte> Value { get { throw null; } }
            public void Dispose() { }
        }
    }
    internal static partial class StringEncoding
    {
        internal static readonly System.Text.Encoding UTF8;
        internal static string GetString(this System.Text.Encoding encoding, System.ReadOnlySpan<byte> bytes) { throw null; }
    }
}
namespace MessagePack.Internal
{
    internal static partial class DateTimeConstants
    {
        internal const long BclSecondsAtUnixEpoch = (long)62135596800;
        internal const int NanosecondsPerTick = 100;
        internal static readonly System.DateTime UnixEpoch;
    }
}
namespace Microsoft.AspNetCore.Builder
{
    public sealed partial class ComponentEndpointConventionBuilder : Microsoft.AspNetCore.Builder.IEndpointConventionBuilder, Microsoft.AspNetCore.Builder.IHubEndpointConventionBuilder
    {
        internal ComponentEndpointConventionBuilder(Microsoft.AspNetCore.Builder.IEndpointConventionBuilder hubEndpoint, Microsoft.AspNetCore.Builder.IEndpointConventionBuilder disconnectEndpoint) { }
        public void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention) { }
    }
    public static partial class ComponentEndpointRouteBuilderExtensions
    {
        public static Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder MapBlazorHub(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints) { throw null; }
        public static Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder MapBlazorHub(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, System.Action<Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions> configureOptions) { throw null; }
        public static Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder MapBlazorHub(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string path) { throw null; }
        public static Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder MapBlazorHub(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints, string path, System.Action<Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions> configureOptions) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ComponentParameter
    {
        private object _dummy;
        private int _dummyPrimitive;
        public string Assembly { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        public static (System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> parameterDefinitions, System.Collections.Generic.IList<object> parameterValues) FromParameterView(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    internal partial class ComponentParametersTypeCache
    {
        public ComponentParametersTypeCache() { }
        public System.Type GetParameterType(string assembly, string type) { throw null; }
    }
    internal sealed partial class ElementReferenceJsonConverter : System.Text.Json.Serialization.JsonConverter<Microsoft.AspNetCore.Components.ElementReference>
    {
        public ElementReferenceJsonConverter() { }
        public override Microsoft.AspNetCore.Components.ElementReference Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options) { throw null; }
        public override void Write(System.Text.Json.Utf8JsonWriter writer, Microsoft.AspNetCore.Components.ElementReference value, System.Text.Json.JsonSerializerOptions options) { }
    }
    internal static partial class JsonSerializerOptionsProvider
    {
        public static readonly System.Text.Json.JsonSerializerOptions Options;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ServerComponent
    {
        private object _dummy;
        private int _dummyPrimitive;
        public ServerComponent(int sequence, string assemblyName, string typeName, System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> parametersDefinitions, System.Collections.Generic.IList<object> parameterValues, System.Guid invocationId) { throw null; }
        public string AssemblyName { get { throw null; } set { } }
        public System.Guid InvocationId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> ParameterDefinitions { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> ParameterValues { get { throw null; } set { } }
        public int Sequence { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ServerComponentMarker
    {
        private object _dummy;
        private int _dummyPrimitive;
        public const string ServerMarkerType = "server";
        public string Descriptor { get { throw null; } set { } }
        public string PrerenderId { get { throw null; } set { } }
        public int? Sequence { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public Microsoft.AspNetCore.Components.ServerComponentMarker GetEndRecord() { throw null; }
        public static Microsoft.AspNetCore.Components.ServerComponentMarker NonPrerendered(int sequence, string descriptor) { throw null; }
        public static Microsoft.AspNetCore.Components.ServerComponentMarker Prerendered(int sequence, string descriptor) { throw null; }
    }
    internal static partial class ServerComponentSerializationSettings
    {
        public static readonly System.TimeSpan DataExpiration;
        public const string DataProtectionProviderPurpose = "Microsoft.AspNetCore.Components.ComponentDescriptorSerializer,V1";
        public static readonly System.Text.Json.JsonSerializerOptions JsonSerializationOptions;
    }
    internal partial class ServerComponentTypeCache
    {
        public ServerComponentTypeCache() { }
        public System.Type GetRootComponent(string assembly, string type) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.Server
{
    internal partial class CircuitDisconnectMiddleware
    {
        public CircuitDisconnectMiddleware(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.CircuitDisconnectMiddleware> logger, Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry registry, Microsoft.AspNetCore.Components.Server.Circuits.CircuitIdFactory circuitIdFactory, Microsoft.AspNetCore.Http.RequestDelegate next) { }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitIdFactory CircuitIdFactory { get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.CircuitDisconnectMiddleware> Logger { get { throw null; } }
        public Microsoft.AspNetCore.Http.RequestDelegate Next { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry Registry { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public sealed partial class CircuitOptions
    {
        public CircuitOptions() { }
        public bool DetailedErrors { get { throw null; } set { } }
        public int DisconnectedCircuitMaxRetained { get { throw null; } set { } }
        public System.TimeSpan DisconnectedCircuitRetentionPeriod { get { throw null; } set { } }
        public System.TimeSpan JSInteropDefaultCallTimeout { get { throw null; } set { } }
        public int MaxBufferedUnacknowledgedRenderBatches { get { throw null; } set { } }
    }
    internal partial class CircuitOptionsJSInteropDetailedErrorsConfiguration : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Components.Server.CircuitOptions>
    {
        public CircuitOptionsJSInteropDetailedErrorsConfiguration(Microsoft.Extensions.Configuration.IConfiguration configuration) { }
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get { throw null; } }
        public void Configure(Microsoft.AspNetCore.Components.Server.CircuitOptions options) { }
    }
    internal partial class ComponentDescriptor
    {
        public ComponentDescriptor() { }
        public System.Type ComponentType { get { throw null; } set { } }
        public Microsoft.AspNetCore.Components.ParameterView Parameters { get { throw null; } set { } }
        public int Sequence { get { throw null; } set { } }
        public void Deconstruct(out System.Type componentType, out Microsoft.AspNetCore.Components.ParameterView parameters, out int sequence) { throw null; }
    }
    internal sealed partial class ComponentHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public ComponentHub(Microsoft.AspNetCore.Components.Server.ServerComponentDeserializer serializer, Microsoft.AspNetCore.Components.Server.Circuits.CircuitFactory circuitFactory, Microsoft.AspNetCore.Components.Server.Circuits.CircuitIdFactory circuitIdFactory, Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry circuitRegistry, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.ComponentHub> logger) { }
        public static Microsoft.AspNetCore.Http.PathString DefaultPath { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask BeginInvokeDotNetFromJS(string callId, string assemblyName, string methodIdentifier, long dotNetObjectId, string argsJson) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask<bool> ConnectCircuit(string circuitIdSecret) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask DispatchBrowserEvent(string eventDescriptor, string eventArgs) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask EndInvokeJSFromDotNet(long asyncHandle, bool succeeded, string arguments) { throw null; }
        public override System.Threading.Tasks.Task OnDisconnectedAsync(System.Exception exception) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask OnLocationChanged(string uri, bool intercepted) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask OnRenderCompleted(long renderId, string errorMessageOrNull) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask<string> StartCircuit(string baseUri, string uri, string serializedComponentRecords) { throw null; }
    }
    internal partial class ComponentParameterDeserializer
    {
        public ComponentParameterDeserializer(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.ComponentParameterDeserializer> logger, Microsoft.AspNetCore.Components.ComponentParametersTypeCache parametersCache) { }
        public bool TryDeserializeParameters(System.Collections.Generic.IList<Microsoft.AspNetCore.Components.ComponentParameter> parametersDefinitions, System.Collections.Generic.IList<object> parameterValues, out Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    internal partial class ConfigureStaticFilesOptions : Microsoft.Extensions.Options.IPostConfigureOptions<Microsoft.AspNetCore.Builder.StaticFileOptions>
    {
        public ConfigureStaticFilesOptions(Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment) { }
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment Environment { get { throw null; } }
        public void PostConfigure(string name, Microsoft.AspNetCore.Builder.StaticFileOptions options) { }
    }
    public abstract partial class RevalidatingServerAuthenticationStateProvider : Microsoft.AspNetCore.Components.Server.ServerAuthenticationStateProvider, System.IDisposable
    {
        public RevalidatingServerAuthenticationStateProvider(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        protected abstract System.TimeSpan RevalidationInterval { get; }
        protected virtual void Dispose(bool disposing) { }
        void System.IDisposable.Dispose() { }
        protected abstract System.Threading.Tasks.Task<bool> ValidateAuthenticationStateAsync(Microsoft.AspNetCore.Components.Authorization.AuthenticationState authenticationState, System.Threading.CancellationToken cancellationToken);
    }
    public partial class ServerAuthenticationStateProvider : Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider, Microsoft.AspNetCore.Components.Authorization.IHostEnvironmentAuthenticationStateProvider
    {
        public ServerAuthenticationStateProvider() { }
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> GetAuthenticationStateAsync() { throw null; }
        public void SetAuthenticationState(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> authenticationStateTask) { }
    }
    internal partial class ServerComponentDeserializer
    {
        public ServerComponentDeserializer(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.ServerComponentDeserializer> logger, Microsoft.AspNetCore.Components.ServerComponentTypeCache rootComponentTypeCache, Microsoft.AspNetCore.Components.Server.ComponentParameterDeserializer parametersDeserializer) { }
        public bool TryDeserializeComponentDescriptorCollection(string serializedComponentRecords, out System.Collections.Generic.List<Microsoft.AspNetCore.Components.Server.ComponentDescriptor> descriptors) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.Server.BlazorPack
{
    internal sealed partial class ArrayBufferWriter<T> : System.Buffers.IBufferWriter<T>, System.IDisposable
    {
        public ArrayBufferWriter() { }
        public ArrayBufferWriter(int initialCapacity) { }
        public int Capacity { get { throw null; } }
        public int FreeCapacity { get { throw null; } }
        public int WrittenCount { get { throw null; } }
        public System.ReadOnlyMemory<T> WrittenMemory { get { throw null; } }
        public void Advance(int count) { }
        public void Clear() { }
        public void Dispose() { }
        public System.Memory<T> GetMemory(int sizeHint = 0) { throw null; }
        public System.Span<T> GetSpan(int sizeHint = 0) { throw null; }
    }
    [Microsoft.AspNetCore.SignalR.Internal.NonDefaultHubProtocolAttribute]
    internal sealed partial class BlazorPackHubProtocol : Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol
    {
        internal const string ProtocolName = "blazorpack";
        public BlazorPackHubProtocol() { }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.Connections.TransferFormat TransferFormat { get { throw null; } }
        public int Version { get { throw null; } }
        public System.ReadOnlyMemory<byte> GetMessageBytes(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { throw null; }
        public bool IsVersionSupported(int version) { throw null; }
        public bool TryParseMessage(ref System.Buffers.ReadOnlySequence<byte> input, Microsoft.AspNetCore.SignalR.IInvocationBinder binder, out Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { throw null; }
        public void WriteMessage(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message, System.Buffers.IBufferWriter<byte> output) { }
    }
}
namespace Microsoft.AspNetCore.Components.Server.Circuits
{
    internal sealed partial class ArrayBuilderMemoryStream : System.IO.Stream
    {
        public ArrayBuilderMemoryStream(Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder<byte> arrayBuilder) { }
        public Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder<byte> ArrayBuilder { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class ArrayBuilder<T> : System.IDisposable
    {
        public ArrayBuilder(int minCapacity = 32, System.Buffers.ArrayPool<T> arrayPool = null) { }
        public T[] Buffer { get { throw null; } }
        public int Count { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public int Append(in T item) { throw null; }
        internal int Append(T[] source, int startIndex, int length) { throw null; }
        public void Clear() { }
        public void Dispose() { }
        public void InsertExpensive(int index, T value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Overwrite(int index, in T value) { }
        public void RemoveLast() { }
    }
    public sealed partial class Circuit
    {
        internal Circuit(Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost) { }
        public string Id { get { throw null; } }
    }
    internal partial class CircuitClientProxy : Microsoft.AspNetCore.SignalR.IClientProxy
    {
        public CircuitClientProxy() { }
        public CircuitClientProxy(Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string connectionId) { }
        public Microsoft.AspNetCore.SignalR.IClientProxy Client { get { throw null; } }
        public bool Connected { get { throw null; } }
        public string ConnectionId { get { throw null; } }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public void SetDisconnected() { }
        public void Transfer(Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string connectionId) { }
    }
    internal partial class CircuitFactory
    {
        public CircuitFactory(Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Components.Server.Circuits.CircuitIdFactory circuitIdFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Components.Server.CircuitOptions> options) { }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost CreateCircuitHost(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.Server.ComponentDescriptor> components, Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy client, string baseUri, string uri, System.Security.Claims.ClaimsPrincipal user) { throw null; }
    }
    internal partial class CircuitHandle
    {
        public CircuitHandle() { }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost CircuitHost { get { throw null; } set { } }
    }
    public abstract partial class CircuitHandler
    {
        protected CircuitHandler() { }
        public virtual int Order { get { throw null; } }
        public virtual System.Threading.Tasks.Task OnCircuitClosedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit circuit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task OnCircuitOpenedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit circuit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task OnConnectionDownAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit circuit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task OnConnectionUpAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit circuit, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class CircuitHost : System.IAsyncDisposable
    {
        public CircuitHost(Microsoft.AspNetCore.Components.Server.Circuits.CircuitId circuitId, Microsoft.Extensions.DependencyInjection.IServiceScope scope, Microsoft.AspNetCore.Components.Server.CircuitOptions options, Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy client, Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer renderer, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.Server.ComponentDescriptor> descriptors, Microsoft.AspNetCore.Components.Server.Circuits.RemoteJSRuntime jsRuntime, Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler[] circuitHandlers, Microsoft.Extensions.Logging.ILogger logger) { }
        public Microsoft.AspNetCore.Components.Server.Circuits.Circuit Circuit { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitId CircuitId { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy Client { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.Server.ComponentDescriptor> Descriptors { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandle Handle { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.RemoteJSRuntime JSRuntime { get { throw null; } }
        public Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer Renderer { get { throw null; } }
        public System.IServiceProvider Services { get { throw null; } }
        public event System.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task BeginInvokeDotNetFromJS(string callId, string assemblyName, string methodIdentifier, long dotNetObjectId, string argsJson) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task DispatchEvent(string eventDescriptorJson, string eventArgsJson) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task EndInvokeJSFromDotNet(long asyncCall, bool succeded, string arguments) { throw null; }
        public System.Threading.Tasks.Task InitializeAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnConnectionDownAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnConnectionUpAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnLocationChangedAsync(string uri, bool intercepted) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task OnRenderCompletedAsync(long renderId, string errorMessageOrNull) { throw null; }
        public void SendPendingBatches() { }
        public void SetCircuitUser(System.Security.Claims.ClaimsPrincipal user) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CircuitId : System.IEquatable<Microsoft.AspNetCore.Components.Server.Circuits.CircuitId>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CircuitId(string secret, string id) { throw null; }
        public string Id { get { throw null; } }
        public string Secret { get { throw null; } }
        public bool Equals([System.Diagnostics.CodeAnalysis.AllowNullAttribute] Microsoft.AspNetCore.Components.Server.Circuits.CircuitId other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    internal partial class CircuitIdFactory
    {
        public CircuitIdFactory(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider provider) { }
        public Microsoft.AspNetCore.Components.Server.Circuits.CircuitId CreateCircuitId() { throw null; }
        public bool TryParseCircuitId(string text, out Microsoft.AspNetCore.Components.Server.Circuits.CircuitId circuitId) { throw null; }
    }
    internal partial class CircuitRegistry
    {
        public CircuitRegistry(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Components.Server.CircuitOptions> options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry> logger, Microsoft.AspNetCore.Components.Server.Circuits.CircuitIdFactory CircuitHostFactory) { }
        internal System.Collections.Concurrent.ConcurrentDictionary<Microsoft.AspNetCore.Components.Server.Circuits.CircuitId, Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost> ConnectedCircuits { get { throw null; } }
        internal Microsoft.Extensions.Caching.Memory.MemoryCache DisconnectedCircuits { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost> ConnectAsync(Microsoft.AspNetCore.Components.Server.Circuits.CircuitId circuitId, Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string connectionId, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected virtual (Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost, bool previouslyConnected) ConnectCore(Microsoft.AspNetCore.Components.Server.Circuits.CircuitId circuitId, Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string connectionId) { throw null; }
        public virtual System.Threading.Tasks.Task DisconnectAsync(Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost, string connectionId) { throw null; }
        protected virtual bool DisconnectCore(Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost, string connectionId) { throw null; }
        protected virtual void OnEntryEvicted(object key, object value, Microsoft.Extensions.Caching.Memory.EvictionReason reason, object state) { }
        public void Register(Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost) { }
        public void RegisterDisconnectedCircuit(Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost circuitHost) { }
        public System.Threading.Tasks.ValueTask TerminateAsync(Microsoft.AspNetCore.Components.Server.Circuits.CircuitId circuitId) { throw null; }
    }
    internal partial class DefaultCircuitAccessor : Microsoft.AspNetCore.Components.Server.Circuits.ICircuitAccessor
    {
        public DefaultCircuitAccessor() { }
        public Microsoft.AspNetCore.Components.Server.Circuits.Circuit Circuit { get { throw null; } set { } }
    }
    internal partial interface ICircuitAccessor
    {
        Microsoft.AspNetCore.Components.Server.Circuits.Circuit Circuit { get; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct PendingRender
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PendingRender(int componentId, Microsoft.AspNetCore.Components.RenderFragment renderFragment) { throw null; }
        public int ComponentId { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderFragment RenderFragment { get { throw null; } }
    }
    internal partial class RemoteJSRuntime : Microsoft.JSInterop.JSRuntime
    {
        public RemoteJSRuntime(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Components.Server.CircuitOptions> options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.Circuits.RemoteJSRuntime> logger) { }
        protected override void BeginInvokeJS(long asyncHandle, string identifier, string argsJson) { }
        protected override void EndInvokeDotNet(Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo invocationInfo, in Microsoft.JSInterop.Infrastructure.DotNetInvocationResult invocationResult) { }
        internal void Initialize(Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy clientProxy) { }
        public static partial class Log
        {
            internal static void BeginInvokeJS(Microsoft.Extensions.Logging.ILogger logger, long asyncHandle, string identifier) { }
            internal static void InvokeDotNetMethodException(Microsoft.Extensions.Logging.ILogger logger, in Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo invocationInfo, System.Exception exception) { }
            internal static void InvokeDotNetMethodSuccess(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.Circuits.RemoteJSRuntime> logger, in Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo invocationInfo) { }
        }
    }
    internal sealed partial class RemoteNavigationInterception : Microsoft.AspNetCore.Components.Routing.INavigationInterception
    {
        public RemoteNavigationInterception() { }
        public bool HasAttachedJSRuntime { get { throw null; } }
        public void AttachJSRuntime(Microsoft.JSInterop.IJSRuntime jsRuntime) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task EnableNavigationInterceptionAsync() { throw null; }
    }
    internal partial class RemoteNavigationManager : Microsoft.AspNetCore.Components.NavigationManager, Microsoft.AspNetCore.Components.Routing.IHostEnvironmentNavigationManager
    {
        public RemoteNavigationManager(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.Server.Circuits.RemoteNavigationManager> logger) { }
        public bool HasAttachedJSRuntime { get { throw null; } }
        public void AttachJsRuntime(Microsoft.JSInterop.IJSRuntime jsRuntime) { }
        public new void Initialize(string baseUri, string uri) { }
        protected override void NavigateToCore(string uri, bool forceLoad) { }
        public void NotifyLocationChanged(string uri, bool intercepted) { }
    }
    internal partial class RemoteRenderer : Microsoft.AspNetCore.Components.RenderTree.Renderer
    {
        internal readonly System.Collections.Concurrent.ConcurrentQueue<Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer.UnacknowledgedRenderBatch> _unacknowledgedRenderBatches;
        public RemoteRenderer(System.IServiceProvider serviceProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Components.Server.CircuitOptions options, Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy client, Microsoft.Extensions.Logging.ILogger logger) : base (default(System.IServiceProvider), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public override Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get { throw null; } }
        public event System.EventHandler<System.Exception> UnhandledException { add { } remove { } }
        public System.Threading.Tasks.Task AddComponentAsync(System.Type componentType, Microsoft.AspNetCore.Components.ParameterView parameters, string domElementSelector) { throw null; }
        public System.Threading.Tasks.Task AddComponentAsync(System.Type componentType, string domElementSelector) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override void HandleException(System.Exception exception) { }
        public System.Threading.Tasks.Task OnRenderCompletedAsync(long incomingBatchId, string errorMessageOrNull) { throw null; }
        public System.Threading.Tasks.Task ProcessBufferedRenderBatches() { throw null; }
        protected override void ProcessPendingRender() { }
        protected override System.Threading.Tasks.Task UpdateDisplayAsync(in Microsoft.AspNetCore.Components.RenderTree.RenderBatch batch) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal readonly partial struct UnacknowledgedRenderBatch
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public UnacknowledgedRenderBatch(long batchId, Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder<byte> data, System.Threading.Tasks.TaskCompletionSource<object> completionSource, Microsoft.Extensions.Internal.ValueStopwatch valueStopwatch) { throw null; }
            public long BatchId { get { throw null; } }
            public System.Threading.Tasks.TaskCompletionSource<object> CompletionSource { get { throw null; } }
            public Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder<byte> Data { get { throw null; } }
            public Microsoft.Extensions.Internal.ValueStopwatch ValueStopwatch { get { throw null; } }
        }
    }
    internal partial class RenderBatchWriter : System.IDisposable
    {
        public RenderBatchWriter(System.IO.Stream output, bool leaveOpen) { }
        public void Dispose() { }
        public void Write(in Microsoft.AspNetCore.Components.RenderTree.RenderBatch renderBatch) { }
    }
}
namespace Microsoft.AspNetCore.Components.Web
{
    internal static partial class BrowserNavigationManagerInterop
    {
        public static readonly string EnableNavigationInterception;
        public static readonly string GetBaseUri;
        public static readonly string GetLocationHref;
        public static readonly string NavigateTo;
    }
    internal partial class WebEventData
    {
        private WebEventData() { }
        public int BrowserRendererId { get { throw null; } }
        public System.EventArgs EventArgs { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.EventFieldInfo EventFieldInfo { get { throw null; } }
        public ulong EventHandlerId { get { throw null; } }
        public static Microsoft.AspNetCore.Components.Web.WebEventData Parse(Microsoft.AspNetCore.Components.RenderTree.WebEventDescriptor eventDescriptor, string eventArgsJson) { throw null; }
        public static Microsoft.AspNetCore.Components.Web.WebEventData Parse(string eventDescriptorJson, string eventArgsJson) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Internal
{
    internal static partial class BinaryMessageFormatter
    {
        public static int LengthPrefixLength(long length) { throw null; }
        public static void WriteLengthPrefix(long length, System.Buffers.IBufferWriter<byte> output) { }
        public static int WriteLengthPrefix(long length, System.Span<byte> output) { throw null; }
    }
    internal static partial class BinaryMessageParser
    {
        public static bool TryParseMessage(ref System.Buffers.ReadOnlySequence<byte> buffer, out System.Buffers.ReadOnlySequence<byte> payload) { throw null; }
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
}
namespace Microsoft.AspNetCore.SignalR.Internal
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    internal partial class NonDefaultHubProtocolAttribute : System.Attribute
    {
        public NonDefaultHubProtocolAttribute() { }
    }
}
namespace Microsoft.AspNetCore.StaticFiles
{
    internal static partial class CacheHeaderSettings
    {
        internal static void SetCacheHeaders(Microsoft.AspNetCore.StaticFiles.StaticFileResponseContext ctx) { }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ComponentServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder AddServerSideBlazor(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Components.Server.CircuitOptions> configure = null) { throw null; }
    }
    public partial interface IServerSideBlazorBuilder
    {
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
    public static partial class ServerSideBlazorBuilderExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder AddCircuitOptions(this Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder builder, System.Action<Microsoft.AspNetCore.Components.Server.CircuitOptions> configure) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder AddHubOptions(this Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder builder, System.Action<Microsoft.AspNetCore.SignalR.HubOptions> configure) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct ValueStopwatch
    {
        private int _dummyPrimitive;
        public bool IsActive { get { throw null; } }
        public System.TimeSpan GetElapsedTime() { throw null; }
        public static Microsoft.Extensions.Internal.ValueStopwatch StartNew() { throw null; }
    }
}
namespace Nerdbank.Streams
{
    internal static partial class Requires
    {
        internal static void Argument(bool condition, string paramName, string message) { }
        internal static void NotNull(object arg, string paramName) { }
        internal static void Range(bool condition, string paramName) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplay,nq}")]
    internal partial class Sequence<T> : System.Buffers.IBufferWriter<T>, System.IDisposable
    {
        public Sequence() { }
        public Sequence(System.Buffers.ArrayPool<T> arrayPool) { }
        public Sequence(System.Buffers.MemoryPool<T> memoryPool) { }
        public System.Buffers.ReadOnlySequence<T> AsReadOnlySequence { get { throw null; } }
        public long Length { get { throw null; } }
        public int MinimumSpanLength { get { throw null; } set { } }
        public void Advance(int count) { }
        public void AdvanceTo(System.SequencePosition position) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void Dispose() { }
        public System.Memory<T> GetMemory(int sizeHint) { throw null; }
        public System.Span<T> GetSpan(int sizeHint) { throw null; }
        public static implicit operator System.Buffers.ReadOnlySequence<T> (Nerdbank.Streams.Sequence<T> sequence) { throw null; }
        public void Reset() { }
    }
}
