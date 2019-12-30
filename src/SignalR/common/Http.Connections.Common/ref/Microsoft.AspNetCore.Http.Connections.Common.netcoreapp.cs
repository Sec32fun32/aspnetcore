// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Http.Connections
{
    public partial class AvailableTransport
    {
        public AvailableTransport() { }
        public System.Collections.Generic.IList<string> TransferFormats { get { throw null; } set { } }
        public string Transport { get { throw null; } set { } }
    }
    public static partial class HttpTransports
    {
        public static readonly Microsoft.AspNetCore.Http.Connections.HttpTransportType All;
    }
    [System.FlagsAttribute]
    public enum HttpTransportType
    {
        None = 0,
        WebSockets = 1,
        ServerSentEvents = 2,
        LongPolling = 4,
    }
    public static partial class NegotiateProtocol
    {
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future version. The recommended alternative is ParseResponse(ReadOnlySpan{byte}).")]
        public static Microsoft.AspNetCore.Http.Connections.NegotiationResponse ParseResponse(System.IO.Stream content) { throw null; }
        public static Microsoft.AspNetCore.Http.Connections.NegotiationResponse ParseResponse(System.ReadOnlySpan<byte> content) { throw null; }
        public static void WriteResponse(Microsoft.AspNetCore.Http.Connections.NegotiationResponse response, System.Buffers.IBufferWriter<byte> output) { }
    }
    public partial class NegotiationResponse
    {
        public NegotiationResponse() { }
        public string AccessToken { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Http.Connections.AvailableTransport> AvailableTransports { get { throw null; } set { } }
        public string ConnectionId { get { throw null; } set { } }
        public string ConnectionToken { get { throw null; } set { } }
        public string Error { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
    }
}
