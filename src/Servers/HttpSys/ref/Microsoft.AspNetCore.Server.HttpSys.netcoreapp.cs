// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Hosting
{
    public static partial class WebHostBuilderHttpSysExtensions
    {
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseHttpSys(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder) { throw null; }
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseHttpSys(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder, System.Action<Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions> options) { throw null; }
    }
}
namespace Microsoft.AspNetCore.HttpSys.Internal
{
    internal static partial class Constants
    {
        internal const string Chunked = "chunked";
        internal const string Close = "close";
        internal const string DefaultServerAddress = "http://localhost:5000";
        internal const string HttpScheme = "http";
        internal const string HttpsScheme = "https";
        internal const string SchemeDelimiter = "://";
        internal static System.Version V1_0;
        internal static System.Version V1_1;
        internal static System.Version V2;
        internal const string Zero = "0";
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CookedUrl
    {
        private readonly int _dummyPrimitive;
        internal CookedUrl(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_COOKED_URL nativeCookedUrl) { throw null; }
        internal string GetAbsPath() { throw null; }
        internal string GetFullUrl() { throw null; }
        internal string GetHost() { throw null; }
        internal string GetQueryString() { throw null; }
    }
    internal partial class HeaderCollection : Microsoft.AspNetCore.Http.IHeaderDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        public HeaderCollection() { }
        public HeaderCollection(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> store) { }
        public long? ContentLength { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } internal set { } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        Microsoft.Extensions.Primitives.StringValues System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringValues> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { }
        public void Add(string key, Microsoft.Extensions.Primitives.StringValues value) { }
        public void Append(string key, string value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> GetEnumerator() { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValues(string key) { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
        public static void ValidateHeaderCharacters(Microsoft.Extensions.Primitives.StringValues headerValues) { }
        public static void ValidateHeaderCharacters(string headerCharacters) { }
    }
    internal static partial class HeaderEncoding
    {
        internal static byte[] GetBytes(string myString) { throw null; }
        internal unsafe static string GetString(byte* pBytes, int byteCount) { throw null; }
    }
    internal static partial class HeaderParser
    {
        internal static System.Collections.Generic.IEnumerable<string> Empty;
        internal static System.Collections.Generic.IEnumerable<string> SplitValues(Microsoft.Extensions.Primitives.StringValues values) { throw null; }
    }
    internal sealed partial class HeapAllocHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        private HeapAllocHandle() : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal static partial class HttpApiTypes
    {
        internal static readonly string[] HttpVerbs;
        internal const int MaxTimeout = 6;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct FromFileHandle
        {
            internal ulong count;
            internal System.IntPtr fileHandle;
            internal ulong offset;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct FromMemory
        {
            internal uint BufferLength;
            internal System.IntPtr pBuffer;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTPAPI_VERSION
        {
            internal ushort HttpApiMajorVersion;
            internal ushort HttpApiMinorVersion;
        }
        internal enum HTTP_API_VERSION
        {
            Invalid = 0,
            Version10 = 1,
            Version20 = 2,
        }
        internal enum HTTP_AUTH_STATUS
        {
            HttpAuthStatusSuccess = 0,
            HttpAuthStatusNotAuthenticated = 1,
            HttpAuthStatusFailure = 2,
        }
        [System.FlagsAttribute]
        internal enum HTTP_AUTH_TYPES : uint
        {
            NONE = (uint)0,
            HTTP_AUTH_ENABLE_BASIC = (uint)1,
            HTTP_AUTH_ENABLE_DIGEST = (uint)2,
            HTTP_AUTH_ENABLE_NTLM = (uint)4,
            HTTP_AUTH_ENABLE_NEGOTIATE = (uint)8,
            HTTP_AUTH_ENABLE_KERBEROS = (uint)16,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_BINDING_INFO
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS Flags;
            internal System.IntPtr RequestQueueHandle;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_CACHE_POLICY
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_CACHE_POLICY_TYPE Policy;
            internal uint SecondsToLive;
        }
        internal enum HTTP_CACHE_POLICY_TYPE
        {
            HttpCachePolicyNocache = 0,
            HttpCachePolicyUserInvalidates = 1,
            HttpCachePolicyTimeToLive = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_CONNECTION_LIMIT_INFO
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS Flags;
            internal uint MaxConnections;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_COOKED_URL
        {
            internal ushort AbsPathLength;
            internal ushort FullUrlLength;
            internal ushort HostLength;
            internal unsafe ushort* pAbsPath;
            internal unsafe ushort* pFullUrl;
            internal unsafe ushort* pHost;
            internal unsafe ushort* pQueryString;
            internal ushort QueryStringLength;
        }
        [System.FlagsAttribute]
        internal enum HTTP_CREATE_REQUEST_QUEUE_FLAG : uint
        {
            None = (uint)0,
            OpenExisting = (uint)1,
            Controller = (uint)2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        internal partial struct HTTP_DATA_CHUNK
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK_TYPE DataChunkType;
            [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.FromFileHandle fromFile;
            [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.FromMemory fromMemory;
        }
        internal enum HTTP_DATA_CHUNK_TYPE
        {
            HttpDataChunkFromMemory = 0,
            HttpDataChunkFromFileHandle = 1,
            HttpDataChunkFromFragmentCache = 2,
            HttpDataChunkMaximum = 3,
        }
        [System.FlagsAttribute]
        internal enum HTTP_FLAGS : uint
        {
            NONE = (uint)0,
            HTTP_INITIALIZE_SERVER = (uint)1,
            HTTP_PROPERTY_FLAG_PRESENT = (uint)1,
            HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY = (uint)1,
            HTTP_RECEIVE_SECURE_CHANNEL_TOKEN = (uint)1,
            HTTP_SEND_REQUEST_FLAG_MORE_DATA = (uint)1,
            HTTP_SEND_RESPONSE_FLAG_DISCONNECT = (uint)1,
            HTTP_SEND_RESPONSE_FLAG_MORE_DATA = (uint)2,
            HTTP_INITIALIZE_CBT = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_RAW_HEADER = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_OPAQUE = (uint)64,
            HTTP_SEND_RESPONSE_FLAG_GOAWAY = (uint)256,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_KNOWN_HEADER
        {
            internal unsafe byte* pRawValue;
            internal ushort RawValueLength;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_MULTIPLE_KNOWN_HEADERS
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_INFO_FLAGS Flags;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_HEADER_ID.Enum HeaderId;
            internal ushort KnownHeaderCount;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER* KnownHeaders;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_QOS_SETTING_INFO
        {
            internal System.IntPtr QosSetting;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_QOS_SETTING_TYPE QosType;
        }
        internal enum HTTP_QOS_SETTING_TYPE
        {
            HttpQosSettingTypeBandwidth = 0,
            HttpQosSettingTypeConnectionLimit = 1,
            HttpQosSettingTypeFlowRate = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_TRANSPORT_ADDRESS Address;
            internal ulong BytesReceived;
            internal ulong ConnectionId;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_COOKED_URL CookedUrl;
            internal ushort EntityChunkCount;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_FLAGS Flags;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_HEADERS Headers;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* pEntityChunks;
            internal unsafe byte* pRawUrl;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SSL_INFO* pSslInfo;
            internal unsafe byte* pUnknownVerb;
            internal ulong RawConnectionId;
            internal ushort RawUrlLength;
            internal ulong RequestId;
            internal ushort UnknownVerbLength;
            internal ulong UrlContext;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB Verb;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERSION Version;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_AUTH_INFO
        {
            internal System.IntPtr AccessToken;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_AUTH_STATUS AuthStatus;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_AUTH_TYPE AuthType;
            internal uint ContextAttributes;
            internal uint Flags;
            internal uint MutualAuthDataLength;
            internal System.IntPtr PackedContext;
            internal uint PackedContextLength;
            internal uint PackedContextType;
            internal unsafe char* pMutualAuthData;
            internal uint SecStatus;
        }
        internal enum HTTP_REQUEST_AUTH_TYPE
        {
            HttpRequestAuthTypeNone = 0,
            HttpRequestAuthTypeBasic = 1,
            HttpRequestAuthTypeDigest = 2,
            HttpRequestAuthTypeNTLM = 3,
            HttpRequestAuthTypeNegotiate = 4,
            HttpRequestAuthTypeKerberos = 5,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_CHANNEL_BIND_STATUS
        {
            internal System.IntPtr ChannelToken;
            internal uint ChannelTokenSize;
            internal uint Flags;
            internal System.IntPtr ServiceName;
        }
        [System.FlagsAttribute]
        internal enum HTTP_REQUEST_FLAGS
        {
            None = 0,
            MoreEntityBodyExists = 1,
            IPRouted = 2,
            Http2 = 4,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_HEADERS
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_02;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_03;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_04;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_05;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_06;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_07;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_08;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_09;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_10;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_11;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_12;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_13;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_14;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_15;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_16;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_17;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_18;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_19;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_20;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_21;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_22;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_23;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_24;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_25;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_26;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_27;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_28;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_29;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_30;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_31;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_32;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_33;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_34;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_35;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_36;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_37;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_38;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_39;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_40;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_41;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_UNKNOWN_HEADER* pTrailers;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_UNKNOWN_HEADER* pUnknownHeaders;
            internal ushort TrailerCount;
            internal ushort UnknownHeaderCount;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_INFO
        {
            internal uint InfoLength;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_INFO_TYPE InfoType;
            internal unsafe void* pInfo;
        }
        internal enum HTTP_REQUEST_INFO_TYPE
        {
            HttpRequestInfoTypeAuth = 0,
            HttpRequestInfoTypeChannelBind = 1,
            HttpRequestInfoTypeSslProtocol = 2,
            HttpRequestInfoTypeSslTokenBinding = 3,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_TOKEN_BINDING_INFO
        {
            public unsafe char* KeyType;
            public unsafe byte* TlsUnique;
            public uint TlsUniqueSize;
            public unsafe byte* TokenBinding;
            public uint TokenBindingSize;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_V2
        {
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_INFO* pRequestInfo;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST Request;
            internal ushort RequestInfoCount;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE
        {
            internal ushort EntityChunkCount;
            internal uint Flags;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_HEADERS Headers;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* pEntityChunks;
            internal unsafe byte* pReason;
            internal ushort ReasonLength;
            internal ushort StatusCode;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERSION Version;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_HEADERS
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_02;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_03;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_04;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_05;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_06;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_07;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_08;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_09;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_10;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_11;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_12;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_13;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_14;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_15;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_16;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_17;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_18;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_19;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_20;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_21;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_22;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_23;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_24;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_25;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_26;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_27;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_28;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_29;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_KNOWN_HEADER KnownHeaders_30;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_UNKNOWN_HEADER* pTrailers;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_UNKNOWN_HEADER* pUnknownHeaders;
            internal ushort TrailerCount;
            internal ushort UnknownHeaderCount;
        }
        internal static partial class HTTP_RESPONSE_HEADER_ID
        {
            internal static int IndexOfKnownHeader(string HeaderName) { throw null; }
            internal enum Enum
            {
                HttpHeaderCacheControl = 0,
                HttpHeaderConnection = 1,
                HttpHeaderDate = 2,
                HttpHeaderKeepAlive = 3,
                HttpHeaderPragma = 4,
                HttpHeaderTrailer = 5,
                HttpHeaderTransferEncoding = 6,
                HttpHeaderUpgrade = 7,
                HttpHeaderVia = 8,
                HttpHeaderWarning = 9,
                HttpHeaderAllow = 10,
                HttpHeaderContentLength = 11,
                HttpHeaderContentType = 12,
                HttpHeaderContentEncoding = 13,
                HttpHeaderContentLanguage = 14,
                HttpHeaderContentLocation = 15,
                HttpHeaderContentMd5 = 16,
                HttpHeaderContentRange = 17,
                HttpHeaderExpires = 18,
                HttpHeaderLastModified = 19,
                HttpHeaderAcceptRanges = 20,
                HttpHeaderAge = 21,
                HttpHeaderEtag = 22,
                HttpHeaderLocation = 23,
                HttpHeaderProxyAuthenticate = 24,
                HttpHeaderRetryAfter = 25,
                HttpHeaderServer = 26,
                HttpHeaderSetCookie = 27,
                HttpHeaderVary = 28,
                HttpHeaderWwwAuthenticate = 29,
                HttpHeaderResponseMaximum = 30,
                HttpHeaderMaximum = 41,
            }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_INFO
        {
            internal uint Length;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_MULTIPLE_KNOWN_HEADERS* pInfo;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_INFO_TYPE Type;
        }
        internal enum HTTP_RESPONSE_INFO_FLAGS : uint
        {
            None = (uint)0,
            PreserveOrder = (uint)1,
        }
        internal enum HTTP_RESPONSE_INFO_TYPE
        {
            HttpResponseInfoTypeMultipleKnownHeaders = 0,
            HttpResponseInfoTypeAuthenticationProperty = 1,
            HttpResponseInfoTypeQosProperty = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_V2
        {
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_INFO* pResponseInfo;
            internal ushort ResponseInfoCount;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE Response_V1;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS
        {
            internal unsafe char* DomainName;
            internal ushort DomainNameLength;
            internal unsafe char* Realm;
            internal ushort RealmLength;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_INFO
        {
            private int _dummyPrimitive;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_AUTH_TYPES AuthSchemes;
            internal bool DisableNTLMCredentialCaching;
            internal ulong ExFlags;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS Flags;
            internal bool ReceiveContextHandle;
            internal bool ReceiveMutualAuth;
        }
        internal enum HTTP_SERVER_PROPERTY
        {
            HttpServerAuthenticationProperty = 0,
            HttpServerLoggingProperty = 1,
            HttpServerQosProperty = 2,
            HttpServerTimeoutsProperty = 3,
            HttpServerQueueLengthProperty = 4,
            HttpServerStateProperty = 5,
            HttpServer503VerbosityProperty = 6,
            HttpServerBindingProperty = 7,
            HttpServerExtendedAuthenticationProperty = 8,
            HttpServerListenEndpointProperty = 9,
            HttpServerChannelBindProperty = 10,
            HttpServerProtectionLevelProperty = 11,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVICE_BINDING_BASE
        {
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SERVICE_BINDING_TYPE Type;
        }
        internal enum HTTP_SERVICE_BINDING_TYPE : uint
        {
            HttpServiceBindingTypeNone = (uint)0,
            HttpServiceBindingTypeW = (uint)1,
            HttpServiceBindingTypeA = (uint)2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_CLIENT_CERT_INFO
        {
            internal byte CertDeniedByMapper;
            internal uint CertEncodedSize;
            internal uint CertFlags;
            internal unsafe byte* pCertEncoded;
            internal unsafe void* Token;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_INFO
        {
            internal ushort ConnectionKeySize;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SSL_CLIENT_CERT_INFO* pClientCertInfo;
            internal unsafe byte* pServerCertIssuer;
            internal unsafe byte* pServerCertSubject;
            internal uint ServerCertIssuerSize;
            internal ushort ServerCertKeySize;
            internal uint ServerCertSubjectSize;
            internal uint SslClientCertNegotiated;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_PROTOCOL_INFO
        {
            internal uint CipherStrength;
            internal System.Security.Authentication.CipherAlgorithmType CipherType;
            internal uint HashStrength;
            internal System.Security.Authentication.HashAlgorithmType HashType;
            internal uint KeyExchangeStrength;
            internal System.Security.Authentication.ExchangeAlgorithmType KeyExchangeType;
            internal System.Security.Authentication.SslProtocols Protocol;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_TIMEOUT_LIMIT_INFO
        {
            internal ushort DrainEntityBody;
            internal ushort EntityBody;
            internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS Flags;
            internal ushort HeaderWait;
            internal ushort IdleConnection;
            internal uint MinSendRate;
            internal ushort RequestQueue;
        }
        internal enum HTTP_TIMEOUT_TYPE
        {
            EntityBody = 0,
            DrainEntityBody = 1,
            RequestQueue = 2,
            IdleConnection = 3,
            HeaderWait = 4,
            MinSendRate = 5,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_TRANSPORT_ADDRESS
        {
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.SOCKADDR* pLocalAddress;
            internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.SOCKADDR* pRemoteAddress;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_UNKNOWN_HEADER
        {
            internal ushort NameLength;
            internal unsafe byte* pName;
            internal unsafe byte* pRawValue;
            internal ushort RawValueLength;
        }
        internal enum HTTP_VERB
        {
            HttpVerbUnparsed = 0,
            HttpVerbUnknown = 1,
            HttpVerbInvalid = 2,
            HttpVerbOPTIONS = 3,
            HttpVerbGET = 4,
            HttpVerbHEAD = 5,
            HttpVerbPOST = 6,
            HttpVerbPUT = 7,
            HttpVerbDELETE = 8,
            HttpVerbTRACE = 9,
            HttpVerbCONNECT = 10,
            HttpVerbTRACK = 11,
            HttpVerbMOVE = 12,
            HttpVerbCOPY = 13,
            HttpVerbPROPFIND = 14,
            HttpVerbPROPPATCH = 15,
            HttpVerbMKCOL = 16,
            HttpVerbLOCK = 17,
            HttpVerbUNLOCK = 18,
            HttpVerbSEARCH = 19,
            HttpVerbMaximum = 20,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_VERSION
        {
            internal ushort MajorVersion;
            internal ushort MinorVersion;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct SOCKADDR
        {
            internal byte sa_data;
            internal byte sa_data_02;
            internal byte sa_data_03;
            internal byte sa_data_04;
            internal byte sa_data_05;
            internal byte sa_data_06;
            internal byte sa_data_07;
            internal byte sa_data_08;
            internal byte sa_data_09;
            internal byte sa_data_10;
            internal byte sa_data_11;
            internal byte sa_data_12;
            internal byte sa_data_13;
            internal byte sa_data_14;
            internal ushort sa_family;
        }
    }
    internal static partial class HttpKnownHeaderNames
    {
        internal const string Accept = "Accept";
        internal const string AcceptCharset = "Accept-Charset";
        internal const string AcceptEncoding = "Accept-Encoding";
        internal const string AcceptLanguage = "Accept-Language";
        internal const string AcceptRanges = "Accept-Ranges";
        internal const string Age = "Age";
        internal const string Allow = "Allow";
        internal const string Authorization = "Authorization";
        internal const string CacheControl = "Cache-Control";
        internal const string Connection = "Connection";
        internal const string ContentDisposition = "Content-Disposition";
        internal const string ContentEncoding = "Content-Encoding";
        internal const string ContentLanguage = "Content-Language";
        internal const string ContentLength = "Content-Length";
        internal const string ContentLocation = "Content-Location";
        internal const string ContentMD5 = "Content-MD5";
        internal const string ContentRange = "Content-Range";
        internal const string ContentType = "Content-Type";
        internal const string Cookie = "Cookie";
        internal const string Cookie2 = "Cookie2";
        internal const string Date = "Date";
        internal const string ETag = "ETag";
        internal const string Expect = "Expect";
        internal const string Expires = "Expires";
        internal const string From = "From";
        internal const string Host = "Host";
        internal const string IfMatch = "If-Match";
        internal const string IfModifiedSince = "If-Modified-Since";
        internal const string IfNoneMatch = "If-None-Match";
        internal const string IfRange = "If-Range";
        internal const string IfUnmodifiedSince = "If-Unmodified-Since";
        internal const string KeepAlive = "Keep-Alive";
        internal const string LastModified = "Last-Modified";
        internal const string Location = "Location";
        internal const string MaxForwards = "Max-Forwards";
        internal const string Origin = "Origin";
        internal const string P3P = "P3P";
        internal const string Pragma = "Pragma";
        internal const string ProxyAuthenticate = "Proxy-Authenticate";
        internal const string ProxyAuthorization = "Proxy-Authorization";
        internal const string ProxyConnection = "Proxy-Connection";
        internal const string Range = "Range";
        internal const string Referer = "Referer";
        internal const string RetryAfter = "Retry-After";
        internal const string SecWebSocketAccept = "Sec-WebSocket-Accept";
        internal const string SecWebSocketExtensions = "Sec-WebSocket-Extensions";
        internal const string SecWebSocketKey = "Sec-WebSocket-Key";
        internal const string SecWebSocketProtocol = "Sec-WebSocket-Protocol";
        internal const string SecWebSocketVersion = "Sec-WebSocket-Version";
        internal const string Server = "Server";
        internal const string SetCookie = "Set-Cookie";
        internal const string SetCookie2 = "Set-Cookie2";
        internal const string TE = "TE";
        internal const string Trailer = "Trailer";
        internal const string TransferEncoding = "Transfer-Encoding";
        internal const string Upgrade = "Upgrade";
        internal const string UserAgent = "User-Agent";
        internal const string Vary = "Vary";
        internal const string Via = "Via";
        internal const string Warning = "Warning";
        internal const string WWWAuthenticate = "WWW-Authenticate";
        internal const string XAspNetVersion = "X-AspNet-Version";
        internal const string XPoweredBy = "X-Powered-By";
    }
    internal enum HttpSysRequestHeader
    {
        CacheControl = 0,
        Connection = 1,
        Date = 2,
        KeepAlive = 3,
        Pragma = 4,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Via = 8,
        Warning = 9,
        Allow = 10,
        ContentLength = 11,
        ContentType = 12,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        Expires = 18,
        LastModified = 19,
        Accept = 20,
        AcceptCharset = 21,
        AcceptEncoding = 22,
        AcceptLanguage = 23,
        Authorization = 24,
        Cookie = 25,
        Expect = 26,
        From = 27,
        Host = 28,
        IfMatch = 29,
        IfModifiedSince = 30,
        IfNoneMatch = 31,
        IfRange = 32,
        IfUnmodifiedSince = 33,
        MaxForwards = 34,
        ProxyAuthorization = 35,
        Referer = 36,
        Range = 37,
        Te = 38,
        Translate = 39,
        UserAgent = 40,
    }
    internal enum HttpSysResponseHeader
    {
        CacheControl = 0,
        Connection = 1,
        Date = 2,
        KeepAlive = 3,
        Pragma = 4,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Via = 8,
        Warning = 9,
        Allow = 10,
        ContentLength = 11,
        ContentType = 12,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        Expires = 18,
        LastModified = 19,
        AcceptRanges = 20,
        Age = 21,
        ETag = 22,
        Location = 23,
        ProxyAuthenticate = 24,
        RetryAfter = 25,
        Server = 26,
        SetCookie = 27,
        Vary = 28,
        WwwAuthenticate = 29,
    }
    internal partial class NativeRequestContext : System.IDisposable
    {
        internal unsafe NativeRequestContext(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* request) { }
        internal unsafe NativeRequestContext(Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped nativeOverlapped, int bufferAlignment, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* nativeRequest, byte[] backingBuffer, ulong requestId) { }
        internal ulong ConnectionId { get { throw null; } }
        internal bool IsHttp2 { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped NativeOverlapped { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* NativeRequest { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_V2* NativeRequestV2 { get { throw null; } }
        internal ulong RequestId { get { throw null; } set { } }
        internal uint Size { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SslStatus SslStatus { get { throw null; } }
        internal ushort UnknownHeaderCount { get { throw null; } }
        internal ulong UrlContext { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB VerbId { get { throw null; } }
        internal bool CheckAuthenticated() { throw null; }
        public virtual void Dispose() { }
        internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size) { throw null; }
        internal System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate() { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.CookedUrl GetCookedUrl() { throw null; }
        internal string GetKnownHeader(Microsoft.AspNetCore.HttpSys.Internal.HttpSysRequestHeader header) { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.SocketAddress GetLocalEndPoint() { throw null; }
        internal string GetRawUrl() { throw null; }
        internal System.Span<byte> GetRawUrlInBytes() { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.SocketAddress GetRemoteEndPoint() { throw null; }
        internal System.Collections.Generic.IReadOnlyDictionary<int, System.ReadOnlyMemory<byte>> GetRequestInfo() { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SSL_PROTOCOL_INFO GetTlsHandshake() { throw null; }
        internal void GetUnknownHeaders(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> unknownHeaders) { }
        internal System.Security.Principal.WindowsPrincipal GetUser() { throw null; }
        internal string GetVerb() { throw null; }
        internal System.Version GetVersion() { throw null; }
        internal void ReleasePins() { }
    }
    internal static partial class NclUtilities
    {
        internal static bool HasShutdownStarted { get { throw null; } }
    }
    internal static partial class PathNormalizer
    {
        public unsafe static bool ContainsDotSegments(byte* start, byte* end) { throw null; }
        public unsafe static int RemoveDotSegments(byte* start, byte* end) { throw null; }
        public static int RemoveDotSegments(System.Span<byte> input) { throw null; }
    }
    internal static partial class RawUrlHelper
    {
        public static System.Span<byte> GetPath(System.Span<byte> raw) { throw null; }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TextTemplatingFileGenerator", "")]
    internal partial class RequestHeaders : Microsoft.AspNetCore.Http.IHeaderDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        internal RequestHeaders(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemoryBlob) { }
        internal Microsoft.Extensions.Primitives.StringValues Accept { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptCharset { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptLanguage { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Allow { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Authorization { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues CacheControl { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Connection { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLanguage { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLength { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLocation { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentMd5 { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentRange { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentType { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Cookie { get { throw null; } set { } }
        public int Count { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues Date { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Expect { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Expires { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues From { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Host { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfMatch { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfModifiedSince { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfNoneMatch { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfRange { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfUnmodifiedSince { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } internal set { } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues KeepAlive { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues LastModified { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues MaxForwards { get { throw null; } set { } }
        long? Microsoft.AspNetCore.Http.IHeaderDictionary.ContentLength { get { throw null; } set { } }
        Microsoft.Extensions.Primitives.StringValues Microsoft.AspNetCore.Http.IHeaderDictionary.this[string key] { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Pragma { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ProxyAuthorization { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Range { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Referer { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.IsReadOnly { get { throw null; } }
        Microsoft.Extensions.Primitives.StringValues System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.this[string key] { get { throw null; } set { } }
        System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringValues> System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.Values { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues Te { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Trailer { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues TransferEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Translate { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Upgrade { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues UserAgent { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Via { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Warning { get { throw null; } set { } }
        public bool ContainsKey(string key) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValues(string key) { throw null; }
        public bool Remove(string key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Add(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Contains(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Remove(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        void System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.Add(string key, Microsoft.Extensions.Primitives.StringValues value) { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
    }
    internal static partial class RequestUriBuilder
    {
        public static string DecodeAndUnescapePath(System.Span<byte> rawUrlBytes) { throw null; }
    }
    internal partial class SafeLocalFreeChannelBinding : System.Security.Authentication.ExtendedProtection.ChannelBinding
    {
        public SafeLocalFreeChannelBinding() { }
        public override bool IsInvalid { get { throw null; } }
        public override int Size { get { throw null; } }
        public static Microsoft.AspNetCore.HttpSys.Internal.SafeLocalFreeChannelBinding LocalAlloc(int cb) { throw null; }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal sealed partial class SafeLocalMemHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        internal SafeLocalMemHandle() : base (default(bool)) { }
        internal SafeLocalMemHandle(System.IntPtr existingHandle, bool ownsHandle) : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal partial class SafeNativeOverlapped : System.Runtime.InteropServices.SafeHandle
    {
        internal static readonly Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped Zero;
        internal SafeNativeOverlapped() : base (default(System.IntPtr), default(bool)) { }
        internal unsafe SafeNativeOverlapped(System.Threading.ThreadPoolBoundHandle boundHandle, System.Threading.NativeOverlapped* handle) : base (default(System.IntPtr), default(bool)) { }
        public override bool IsInvalid { get { throw null; } }
        public void ReinitializeNativeOverlapped() { }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal partial class SocketAddress
    {
        internal const int IPv4AddressSize = 16;
        internal const int IPv6AddressSize = 28;
        public SocketAddress(System.Net.Sockets.AddressFamily family, int size) { }
        internal byte[] Buffer { get { throw null; } }
        internal System.Net.Sockets.AddressFamily Family { get { throw null; } }
        internal int Size { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        internal System.Net.IPAddress GetIPAddress() { throw null; }
        internal string GetIPAddressString() { throw null; }
        internal int GetPort() { throw null; }
        public override string ToString() { throw null; }
    }
    internal enum SslStatus : byte
    {
        Insecure = (byte)0,
        NoClientCert = (byte)1,
        ClientCert = (byte)2,
    }
    internal static partial class UnsafeNclNativeMethods
    {
        [System.Runtime.InteropServices.DllImport("api-ms-win-core-io-l1-1-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint CancelIoEx(System.Runtime.InteropServices.SafeHandle handle, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped overlapped);
        [System.Runtime.InteropServices.DllImport("api-ms-win-core-heap-L1-2-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern System.IntPtr GetProcessHeap();
        [System.Runtime.InteropServices.DllImport("api-ms-win-core-heap-L1-2-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern bool HeapFree(System.IntPtr hHeap, uint dwFlags, System.IntPtr lpMem);
        [System.Runtime.InteropServices.DllImport("api-ms-win-core-kernel32-legacy-l1-1-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern bool SetFileCompletionNotificationModes(System.Runtime.InteropServices.SafeHandle handle, Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.FileCompletionNotificationModes modes);
        [System.Runtime.InteropServices.DllImport("tokenbinding.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public unsafe static extern int TokenBindingVerifyMessage(byte* tokenBindingMessage, uint tokenBindingMessageSize, char* keyType, byte* tlsUnique, uint tlsUniqueSize, out Microsoft.AspNetCore.HttpSys.Internal.HeapAllocHandle resultList);
        internal static partial class ErrorCodes
        {
            internal const uint ERROR_ACCESS_DENIED = (uint)5;
            internal const uint ERROR_ALREADY_EXISTS = (uint)183;
            internal const uint ERROR_CONNECTION_INVALID = (uint)1229;
            internal const uint ERROR_FILE_NOT_FOUND = (uint)2;
            internal const uint ERROR_HANDLE_EOF = (uint)38;
            internal const uint ERROR_INVALID_NAME = (uint)123;
            internal const uint ERROR_INVALID_PARAMETER = (uint)87;
            internal const uint ERROR_IO_PENDING = (uint)997;
            internal const uint ERROR_MORE_DATA = (uint)234;
            internal const uint ERROR_NOT_FOUND = (uint)1168;
            internal const uint ERROR_NOT_SUPPORTED = (uint)50;
            internal const uint ERROR_OPERATION_ABORTED = (uint)995;
            internal const uint ERROR_SHARING_VIOLATION = (uint)32;
            internal const uint ERROR_SUCCESS = (uint)0;
        }
        [System.FlagsAttribute]
        internal enum FileCompletionNotificationModes : byte
        {
            None = (byte)0,
            SkipCompletionPortOnSuccess = (byte)1,
            SkipSetEventOnHandle = (byte)2,
        }
        internal static partial class SafeNetHandles
        {
            [System.Runtime.InteropServices.DllImport("api-ms-win-core-handle-l1-1-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern bool CloseHandle(System.IntPtr handle);
            [System.Runtime.InteropServices.DllImport("sspicli.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern int FreeContextBuffer(System.IntPtr contextBuffer);
            [System.Runtime.InteropServices.DllImport("api-ms-win-core-heap-obsolete-L1-1-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern Microsoft.AspNetCore.HttpSys.Internal.SafeLocalFreeChannelBinding LocalAllocChannelBinding(int uFlags, System.UIntPtr sizetdwBytes);
            [System.Runtime.InteropServices.DllImport("api-ms-win-core-heap-obsolete-L1-1-0.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern System.IntPtr LocalFree(System.IntPtr handle);
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial class SECURITY_ATTRIBUTES
        {
            public bool bInheritHandle;
            public Microsoft.AspNetCore.HttpSys.Internal.SafeLocalMemHandle lpSecurityDescriptor;
            public int nLength;
            public SECURITY_ATTRIBUTES() { }
        }
        internal static partial class TokenBinding
        {
            internal enum TOKENBINDING_EXTENSION_FORMAT
            {
                TOKENBINDING_EXTENSION_FORMAT_UNDEFINED = 0,
            }
            internal enum TOKENBINDING_HASH_ALGORITHM : byte
            {
                TOKENBINDING_HASH_ALGORITHM_SHA256 = (byte)4,
            }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            internal partial struct TOKENBINDING_IDENTIFIER
            {
                public Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_TYPE bindingType;
                public Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_HASH_ALGORITHM hashAlgorithm;
                public Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_SIGNATURE_ALGORITHM signatureAlgorithm;
            }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            internal partial struct TOKENBINDING_RESULT_DATA
            {
                public System.IntPtr extensionData;
                public Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_EXTENSION_FORMAT extensionFormat;
                public uint extensionSize;
                public unsafe Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_IDENTIFIER* identifierData;
                public uint identifierSize;
            }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            internal partial struct TOKENBINDING_RESULT_LIST
            {
                public uint resultCount;
                public unsafe Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.TokenBinding.TOKENBINDING_RESULT_DATA* resultData;
            }
            internal enum TOKENBINDING_SIGNATURE_ALGORITHM : byte
            {
                TOKENBINDING_SIGNATURE_ALGORITHM_RSA = (byte)1,
                TOKENBINDING_SIGNATURE_ALGORITHM_ECDSAP256 = (byte)3,
            }
            internal enum TOKENBINDING_TYPE : byte
            {
                TOKENBINDING_TYPE_PROVIDED = (byte)0,
                TOKENBINDING_TYPE_REFERRED = (byte)1,
            }
        }
    }
}
namespace Microsoft.AspNetCore.Server.HttpSys
{
    internal partial class AsyncAcceptContext : System.IAsyncResult, System.IDisposable
    {
        internal static readonly System.Threading.IOCompletionCallback IOCallback;
        internal AsyncAcceptContext(Microsoft.AspNetCore.Server.HttpSys.HttpSysListener server) { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        public bool CompletedSynchronously { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.HttpSysListener Server { get { throw null; } }
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Server.HttpSys.RequestContext> Task { get { throw null; } }
        internal void AllocateNativeRequest(uint? size = default(uint?), ulong requestId = (ulong)0) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        internal uint QueueBeginGetContext() { throw null; }
    }
    internal partial class AuthenticationHandler : Microsoft.AspNetCore.Authentication.IAuthenticationHandler
    {
        public AuthenticationHandler() { }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Authentication.AuthenticateResult> AuthenticateAsync() { throw null; }
        public System.Threading.Tasks.Task ChallengeAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task ForbidAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task InitializeAsync(Microsoft.AspNetCore.Authentication.AuthenticationScheme scheme, Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public sealed partial class AuthenticationManager
    {
        internal AuthenticationManager() { }
        public bool AllowAnonymous { get { throw null; } set { } }
        public Microsoft.AspNetCore.Server.HttpSys.AuthenticationSchemes Schemes { get { throw null; } set { } }
        internal static System.Collections.Generic.IList<string> GenerateChallenges(Microsoft.AspNetCore.Server.HttpSys.AuthenticationSchemes authSchemes) { throw null; }
        internal void SetAuthenticationChallenge(Microsoft.AspNetCore.Server.HttpSys.RequestContext context) { }
        internal void SetUrlGroupSecurity(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup) { }
    }
    [System.FlagsAttribute]
    public enum AuthenticationSchemes
    {
        None = 0,
        Basic = 1,
        NTLM = 4,
        Negotiate = 8,
        Kerberos = 16,
    }
    internal enum BoundaryType
    {
        None = 0,
        Chunked = 1,
        ContentLength = 2,
        Close = 3,
        PassThrough = 4,
        Invalid = 5,
    }
    public enum ClientCertificateMethod
    {
        NoCertificate = 0,
        AllowCertificate = 1,
        AllowRenegotation = 2,
    }
    internal sealed partial class ClientCertLoader : System.IAsyncResult, System.IDisposable
    {
        internal ClientCertLoader(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext, System.Threading.CancellationToken cancellationToken) { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        internal System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCert { get { throw null; } }
        internal int ClientCertError { get { throw null; } }
        internal System.Exception ClientCertException { get { throw null; } }
        public bool CompletedSynchronously { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        internal System.Runtime.InteropServices.SafeHandle RequestQueueHandle { get { throw null; } }
        public void Dispose() { }
        internal static System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBindingFromTls(Microsoft.AspNetCore.Server.HttpSys.RequestQueue requestQueue, ulong connectionId, Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        internal System.Threading.Tasks.Task LoadClientCertificateAsync() { throw null; }
    }
    internal static partial class ComNetOS
    {
        internal static readonly bool IsWin8orLater;
    }
    internal partial class DisconnectListener
    {
        internal DisconnectListener(Microsoft.AspNetCore.Server.HttpSys.RequestQueue requestQueue, Microsoft.Extensions.Logging.ILogger logger) { }
        internal System.Threading.CancellationToken GetTokenForConnection(ulong connectionId) { throw null; }
    }
    internal partial class FeatureContext : Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature, Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature, Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature, Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature, Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature, Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature, Microsoft.AspNetCore.Http.Features.IHttpResponseFeature, Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature, Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature, Microsoft.AspNetCore.Server.HttpSys.IHttpSysRequestInfoFeature
    {
        internal FeatureContext(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext) { }
        internal Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        System.Security.Authentication.CipherAlgorithmType Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.CipherAlgorithm { get { throw null; } }
        int Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.CipherStrength { get { throw null; } }
        System.Security.Authentication.HashAlgorithmType Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.HashAlgorithm { get { throw null; } }
        int Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.HashStrength { get { throw null; } }
        System.Security.Authentication.ExchangeAlgorithmType Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.KeyExchangeAlgorithm { get { throw null; } }
        int Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.KeyExchangeStrength { get { throw null; } }
        System.Security.Authentication.SslProtocols Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature.Protocol { get { throw null; } }
        System.Security.Claims.ClaimsPrincipal Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature.User { get { throw null; } set { } }
        bool Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature.AllowSynchronousIO { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature.ConnectionId { get { throw null; } set { } }
        System.Net.IPAddress Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature.LocalIpAddress { get { throw null; } set { } }
        int Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature.LocalPort { get { throw null; } set { } }
        System.Net.IPAddress Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature.RemoteIpAddress { get { throw null; } set { } }
        int Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature.RemotePort { get { throw null; } set { } }
        bool Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature.IsReadOnly { get { throw null; } }
        long? Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature.MaxRequestBodySize { get { throw null; } set { } }
        System.IO.Stream Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Body { get { throw null; } set { } }
        Microsoft.AspNetCore.Http.IHeaderDictionary Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Headers { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Method { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Path { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.PathBase { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Protocol { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.QueryString { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.RawTarget { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Scheme { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature.TraceIdentifier { get { throw null; } set { } }
        System.Threading.CancellationToken Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature.RequestAborted { get { throw null; } set { } }
        System.IO.Stream Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.Stream { get { throw null; } }
        System.IO.Pipelines.PipeWriter Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.Writer { get { throw null; } }
        System.IO.Stream Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.Body { get { throw null; } set { } }
        bool Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.HasStarted { get { throw null; } }
        Microsoft.AspNetCore.Http.IHeaderDictionary Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.Headers { get { throw null; } set { } }
        string Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.ReasonPhrase { get { throw null; } set { } }
        int Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.StatusCode { get { throw null; } set { } }
        bool Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature.IsUpgradableRequest { get { throw null; } }
        System.Security.Cryptography.X509Certificates.X509Certificate2 Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature.ClientCertificate { get { throw null; } set { } }
        System.Collections.Generic.IReadOnlyDictionary<int, System.ReadOnlyMemory<byte>> Microsoft.AspNetCore.Server.HttpSys.IHttpSysRequestInfoFeature.RequestInfo { get { throw null; } }
        internal object RequestContext { get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task CompleteAsync() { throw null; }
        internal Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature GetTlsConnectionFeature() { throw null; }
        internal Microsoft.AspNetCore.Connections.Features.ITlsHandshakeFeature GetTlsHandshakeFeature() { throw null; }
        void Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature.Abort() { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.CompleteAsync() { throw null; }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.DisableBuffering() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.SendFileAsync(string path, long offset, long? length, System.Threading.CancellationToken cancellation) { throw null; }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.StartAsync(System.Threading.CancellationToken cancellation) { throw null; }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        System.Threading.Tasks.Task<System.IO.Stream> Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature.UpgradeAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature.GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        internal System.Threading.Tasks.Task OnCompleted() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task OnResponseStart() { throw null; }
    }
    internal static partial class Helpers
    {
        internal static readonly byte[] ChunkTerminator;
        internal static readonly byte[] CRLF;
        internal static System.ArraySegment<byte> GetChunkHeader(int size) { throw null; }
        internal static System.ArraySegment<byte> GetChunkHeader(long size) { throw null; }
        internal static System.Runtime.CompilerServices.ConfiguredTaskAwaitable SupressContext(this System.Threading.Tasks.Task task) { throw null; }
        internal static System.Runtime.CompilerServices.ConfiguredTaskAwaitable<T> SupressContext<T>(this System.Threading.Tasks.Task<T> task) { throw null; }
        internal static System.IAsyncResult ToIAsyncResult(this System.Threading.Tasks.Task task, System.AsyncCallback callback, object state) { throw null; }
    }
    public enum Http503VerbosityLevel : long
    {
        Basic = (long)0,
        Limited = (long)1,
        Full = (long)2,
    }
    internal static partial class HttpApi
    {
        internal static Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_API_VERSION ApiVersion { get { throw null; } }
        internal static bool Supported { get { throw null; } }
        internal static Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTPAPI_VERSION Version { get { throw null; } }
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpAddUrlToUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, ulong context, uint pReserved);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpCancelHttpRequest(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong requestId, System.IntPtr pOverlapped);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpCloseRequestQueue(System.IntPtr pReqQueueHandle);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpCloseServerSession(ulong serverSessionId);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpCloseUrlGroup(ulong urlGroupId);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpCreateRequestQueue(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTPAPI_VERSION version, string pName, Microsoft.AspNetCore.HttpSys.Internal.UnsafeNclNativeMethods.SECURITY_ATTRIBUTES pSecurityAttributes, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_CREATE_REQUEST_QUEUE_FLAG flags, out Microsoft.AspNetCore.Server.HttpSys.HttpRequestQueueV2Handle pReqQueueHandle);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpCreateServerSession(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTPAPI_VERSION version, ulong* serverSessionId, uint reserved);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpCreateUrlGroup(ulong serverSessionId, ulong* urlGroupId, uint reserved);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpInitialize(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTPAPI_VERSION version, uint flags, void* pReserved);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpReceiveClientCertificate(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong connectionId, uint flags, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SSL_CLIENT_CERT_INFO* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpReceiveClientCertificate(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong connectionId, uint flags, byte* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpReceiveHttpRequest(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong requestId, uint flags, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* pRequestBuffer, uint requestBufferLength, uint* pBytesReturned, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpReceiveRequestEntityBody(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong requestId, uint flags, System.IntPtr pEntityBuffer, uint entityBufferLength, out uint bytesReturned, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpRemoveUrlFromUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, uint flags);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpSendHttpResponse(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong requestId, uint flags, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_RESPONSE_V2* pHttpResponse, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_CACHE_POLICY* pCachePolicy, uint* pBytesSent, System.IntPtr pReserved1, uint Reserved2, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped, System.IntPtr pLogData);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal unsafe static extern uint HttpSendResponseEntityBody(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong requestId, uint flags, ushort entityChunkCount, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* pEntityChunks, uint* pBytesSent, System.IntPtr pReserved1, uint Reserved2, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped pOverlapped, System.IntPtr pLogData);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpSetRequestQueueProperty(System.Runtime.InteropServices.SafeHandle requestQueueHandle, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SERVER_PROPERTY serverProperty, System.IntPtr pPropertyInfo, uint propertyInfoLength, uint reserved, System.IntPtr pReserved);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpSetUrlGroupProperty(ulong urlGroupId, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SERVER_PROPERTY serverProperty, System.IntPtr pPropertyInfo, uint propertyInfoLength);
        [System.Runtime.InteropServices.DllImport("httpapi.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]internal static extern uint HttpWaitForDisconnectEx(System.Runtime.InteropServices.SafeHandle requestQueueHandle, ulong connectionId, uint reserved, Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped overlapped);
    }
    internal static partial class HttpReasonPhrase
    {
        internal static string Get(int code) { throw null; }
    }
    internal sealed partial class HttpRequestQueueV2Handle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        private HttpRequestQueueV2Handle() : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal sealed partial class HttpServerSessionHandle : Microsoft.Win32.SafeHandles.CriticalHandleZeroOrMinusOneIsInvalid
    {
        internal HttpServerSessionHandle(ulong id) { }
        internal ulong DangerousGetServerSessionId() { throw null; }
        protected override bool ReleaseHandle() { throw null; }
    }
    public static partial class HttpSysDefaults
    {
        public const string AuthenticationScheme = "Windows";
    }
    public partial class HttpSysException : System.ComponentModel.Win32Exception
    {
        internal HttpSysException() { }
        internal HttpSysException(int errorCode) { }
        internal HttpSysException(int errorCode, string message) { }
        public override int ErrorCode { get { throw null; } }
    }
    internal partial class HttpSysListener : System.IDisposable
    {
        internal static readonly bool SkipIOCPCallbackOnSuccess;
        public HttpSysListener(Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.Server.HttpSys.DisconnectListener DisconnectListener { get { throw null; } }
        public bool IsListening { get { throw null; } }
        internal Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions Options { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestQueue RequestQueue { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.UrlGroup UrlGroup { get { throw null; } }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Server.HttpSys.RequestContext> AcceptAsync() { throw null; }
        public void Dispose() { }
        internal void SendError(ulong requestId, int httpStatusCode, System.Collections.Generic.IList<string> authChallenges = null) { }
        public void Start() { }
        internal bool ValidateAuth(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemory) { throw null; }
        internal bool ValidateRequest(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemory) { throw null; }
        internal enum State
        {
            Stopped = 0,
            Started = 1,
            Disposed = 2,
        }
    }
    public partial class HttpSysOptions
    {
        internal static readonly int DefaultMaxAccepts;
        public HttpSysOptions() { }
        public bool AllowSynchronousIO { get { throw null; } set { } }
        public Microsoft.AspNetCore.Server.HttpSys.AuthenticationManager Authentication { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.ClientCertificateMethod ClientCertificateMethod { get { throw null; } set { } }
        public bool EnableResponseCaching { get { throw null; } set { } }
        public Microsoft.AspNetCore.Server.HttpSys.Http503VerbosityLevel Http503Verbosity { get { throw null; } set { } }
        public int MaxAccepts { get { throw null; } set { } }
        public long? MaxConnections { get { throw null; } set { } }
        public long? MaxRequestBodySize { get { throw null; } set { } }
        public long RequestQueueLimit { get { throw null; } set { } }
        public Microsoft.AspNetCore.Server.HttpSys.RequestQueueMode RequestQueueMode { get { throw null; } set { } }
        public string RequestQueueName { get { throw null; } set { } }
        public bool ThrowWriteExceptions { get { throw null; } set { } }
        public Microsoft.AspNetCore.Server.HttpSys.TimeoutManager Timeouts { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.UrlPrefixCollection UrlPrefixes { get { throw null; } }
        internal void Apply(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup, Microsoft.AspNetCore.Server.HttpSys.RequestQueue requestQueue) { }
    }
    internal static partial class HttpSysSettings
    {
        internal static bool EnableNonUtf8 { get { throw null; } }
        internal static bool FavorUtf8 { get { throw null; } }
    }
    public partial interface IHttpSysRequestInfoFeature
    {
        System.Collections.Generic.IReadOnlyDictionary<int, System.ReadOnlyMemory<byte>> RequestInfo { get; }
    }
    internal static partial class IntPtrHelper
    {
        internal static System.IntPtr Add(System.IntPtr a, int b) { throw null; }
        internal static long Subtract(System.IntPtr a, System.IntPtr b) { throw null; }
    }
    internal static partial class LogHelper
    {
        internal static Microsoft.Extensions.Logging.ILogger CreateLogger(Microsoft.Extensions.Logging.ILoggerFactory factory, System.Type type) { throw null; }
        internal static void LogDebug(Microsoft.Extensions.Logging.ILogger logger, string data) { }
        internal static void LogDebug(Microsoft.Extensions.Logging.ILogger logger, string location, System.Exception exception) { }
        internal static void LogDebug(Microsoft.Extensions.Logging.ILogger logger, string location, string data) { }
        internal static void LogError(Microsoft.Extensions.Logging.ILogger logger, string location, string message) { }
        internal static void LogException(Microsoft.Extensions.Logging.ILogger logger, string location, System.Exception exception) { }
        internal static void LogInfo(Microsoft.Extensions.Logging.ILogger logger, string data) { }
        internal static void LogWarning(Microsoft.Extensions.Logging.ILogger logger, string data) { }
    }
    internal partial class MessagePump : Microsoft.AspNetCore.Hosting.Server.IServer, System.IDisposable
    {
        public MessagePump(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider authentication) { }
        public Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.HttpSysListener Listener { get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.Task StartAsync<TContext>(Microsoft.AspNetCore.Hosting.Server.IHttpApplication<TContext> application, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class OpaqueStream : System.IO.Stream
    {
        internal OpaqueStream(System.IO.Stream requestStream, System.IO.Stream responseStream) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    internal sealed partial class Request
    {
        internal Request(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext, Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext nativeRequestContext) { }
        public System.IO.Stream Body { get { throw null; } }
        public System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get { throw null; } }
        public int CipherStrength { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate { get { throw null; } }
        public long ConnectionId { get { throw null; } }
        public long? ContentLength { get { throw null; } }
        public bool HasEntityBody { get { throw null; } }
        public System.Security.Authentication.HashAlgorithmType HashAlgorithm { get { throw null; } }
        public int HashStrength { get { throw null; } }
        public bool HasRequestBodyStarted { get { throw null; } }
        public Microsoft.AspNetCore.HttpSys.Internal.RequestHeaders Headers { get { throw null; } }
        internal bool IsHeadMethod { get { throw null; } }
        public bool IsHttps { get { throw null; } }
        internal bool IsUpgradable { get { throw null; } }
        public System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get { throw null; } }
        public int KeyExchangeStrength { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB KnownMethod { get { throw null; } }
        public System.Net.IPAddress LocalIpAddress { get { throw null; } }
        public int LocalPort { get { throw null; } }
        public long? MaxRequestBodySize { get { throw null; } set { } }
        public string Method { get { throw null; } }
        public string Path { get { throw null; } }
        public string PathBase { get { throw null; } }
        public System.Security.Authentication.SslProtocols Protocol { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } }
        public string QueryString { get { throw null; } }
        public string RawUrl { get { throw null; } }
        public System.Net.IPAddress RemoteIpAddress { get { throw null; } }
        public int RemotePort { get { throw null; } }
        internal ulong RequestId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<int, System.ReadOnlyMemory<byte>> RequestInfo { get { throw null; } }
        public string Scheme { get { throw null; } }
        internal ulong UConnectionId { get { throw null; } }
        internal System.Security.Principal.WindowsPrincipal User { get { throw null; } }
        internal void Dispose() { }
        internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        internal void SwitchToOpaqueMode() { }
    }
    internal sealed partial class RequestContext : System.IDisposable
    {
        internal RequestContext(Microsoft.AspNetCore.Server.HttpSys.HttpSysListener server, Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext memoryBlob) { }
        internal bool AllowSynchronousIO { get { throw null; } set { } }
        public System.Threading.CancellationToken DisconnectToken { get { throw null; } }
        public bool IsUpgradableRequest { get { throw null; } }
        internal Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.Request Request { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.Response Response { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.HttpSysListener Server { get { throw null; } }
        public System.Guid TraceIdentifier { get { throw null; } }
        public System.Security.Principal.WindowsPrincipal User { get { throw null; } }
        public void Abort() { }
        public void Dispose() { }
        internal void ForceCancelRequest() { }
        internal System.Threading.CancellationTokenRegistration RegisterForCancellation(System.Threading.CancellationToken cancellationToken) { throw null; }
        internal bool TryGetChannelBinding(ref System.Security.Authentication.ExtendedProtection.ChannelBinding value) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> UpgradeAsync() { throw null; }
    }
    internal partial class RequestQueue
    {
        internal RequestQueue(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup, string requestQueueName, Microsoft.AspNetCore.Server.HttpSys.RequestQueueMode mode, Microsoft.Extensions.Logging.ILogger logger) { }
        internal System.Threading.ThreadPoolBoundHandle BoundHandle { get { throw null; } }
        internal bool Created { get { throw null; } }
        internal System.Runtime.InteropServices.SafeHandle Handle { get { throw null; } }
        internal void AttachToUrlGroup() { }
        internal void DetachFromUrlGroup() { }
        public void Dispose() { }
        internal void SetLengthLimit(long length) { }
        internal void SetRejectionVerbosity(Microsoft.AspNetCore.Server.HttpSys.Http503VerbosityLevel verbosity) { }
    }
    public enum RequestQueueMode
    {
        Create = 0,
        Attach = 1,
        CreateOrAttach = 2,
    }
    internal partial class RequestStream : System.IO.Stream
    {
        internal RequestStream(Microsoft.AspNetCore.Server.HttpSys.RequestContext httpContext) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool HasStarted { get { throw null; } }
        public override long Length { get { throw null; } }
        public long? MaxSize { get { throw null; } set { } }
        public override long Position { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestContext RequestContext { get { throw null; } }
        internal void Abort() { }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int size) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        internal void SwitchToOpaqueMode() { }
        internal bool TryCheckSizeLimit(int bytesRead, out System.Exception exception) { throw null; }
        internal void UpdateAfterRead(uint statusCode, uint dataRead) { }
        public override void Write(byte[] buffer, int offset, int size) { }
    }
    internal partial class RequestStreamAsyncResult : System.IAsyncResult, System.IDisposable
    {
        internal RequestStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.RequestStream requestStream, object userState, System.AsyncCallback callback) { }
        internal RequestStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.RequestStream requestStream, object userState, System.AsyncCallback callback, byte[] buffer, int offset, uint dataAlreadyRead) { }
        internal RequestStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.RequestStream requestStream, object userState, System.AsyncCallback callback, byte[] buffer, int offset, uint dataAlreadyRead, System.Threading.CancellationTokenRegistration cancellationRegistration) { }
        internal RequestStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.RequestStream requestStream, object userState, System.AsyncCallback callback, uint dataAlreadyRead) { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        public bool CompletedSynchronously { get { throw null; } }
        internal uint DataAlreadyRead { get { throw null; } }
        internal bool EndCalled { get { throw null; } set { } }
        public bool IsCompleted { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped NativeOverlapped { get { throw null; } }
        internal System.IntPtr PinnedBuffer { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestStream RequestStream { get { throw null; } }
        internal System.Threading.Tasks.Task<int> Task { get { throw null; } }
        internal void Complete(int read, uint errorCode = (uint)0) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        internal void Fail(System.Exception ex) { }
        internal void IOCompleted(uint errorCode, uint numBytes) { }
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string Exception_ArrayTooSmall { get { throw null; } }
        internal static string Exception_EndCalledMultipleTimes { get { throw null; } }
        internal static string Exception_InvalidStatusCode { get { throw null; } }
        internal static string Exception_NoSeek { get { throw null; } }
        internal static string Exception_PrefixAlreadyRegistered { get { throw null; } }
        internal static string Exception_ReadOnlyStream { get { throw null; } }
        internal static string Exception_TooMuchWritten { get { throw null; } }
        internal static string Exception_UnsupportedScheme { get { throw null; } }
        internal static string Exception_WriteOnlyStream { get { throw null; } }
        internal static string Exception_WrongIAsyncResult { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string Warning_ExceptionInOnResponseCompletedAction { get { throw null; } }
        internal static string FormatException_InvalidStatusCode(object p0) { throw null; }
        internal static string FormatException_PrefixAlreadyRegistered(object p0) { throw null; }
        internal static string FormatWarning_ExceptionInOnResponseCompletedAction(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    internal sealed partial class Response
    {
        internal Response(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext) { }
        public Microsoft.AspNetCore.Server.HttpSys.AuthenticationSchemes AuthenticationChallenges { get { throw null; } set { } }
        public System.IO.Stream Body { get { throw null; } }
        internal bool BodyIsFinished { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.BoundaryType BoundaryType { get { throw null; } }
        public System.TimeSpan? CacheTtl { get { throw null; } set { } }
        public long? ContentLength { get { throw null; } set { } }
        internal long ExpectedBodyLength { get { throw null; } }
        internal bool HasComputedHeaders { get { throw null; } }
        public bool HasStarted { get { throw null; } }
        public Microsoft.AspNetCore.HttpSys.Internal.HeaderCollection Headers { get { throw null; } }
        public string ReasonPhrase { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        internal void Abort() { }
        internal void CancelLastWrite() { }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS ComputeHeaders(long writeCount, bool endOfRequest = false) { throw null; }
        internal void Dispose() { }
        public System.Threading.Tasks.Task SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancel) { throw null; }
        internal uint SendHeaders(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK[] dataChunks, Microsoft.AspNetCore.Server.HttpSys.ResponseStreamAsyncResult asyncResult, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS flags, bool isOpaqueUpgrade) { throw null; }
        internal void SendOpaqueUpgrade() { }
        internal void SwitchToOpaqueMode() { }
    }
    internal partial class ResponseBody : System.IO.Stream
    {
        internal ResponseBody(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        internal bool IsDisposed { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestContext RequestContext { get { throw null; } }
        internal bool ThrowWriteExceptions { get { throw null; } }
        internal void Abort(bool dispose = true) { }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        internal void CancelLastWrite() { }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task SendFileAsync(string fileName, long offset, long? count, System.Threading.CancellationToken cancellationToken) { throw null; }
        internal System.Threading.Tasks.Task SendFileAsyncCore(string fileName, long offset, long? count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void SetLength(long value) { }
        internal void SwitchToOpaqueMode() { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class ResponseStream : System.IO.Stream
    {
        internal ResponseStream(System.IO.Stream innerStream, System.Func<System.Threading.Tasks.Task> onStart) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class ResponseStreamAsyncResult : System.IAsyncResult, System.IDisposable
    {
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.ArraySegment<byte> data, bool chunked, System.Threading.CancellationToken cancellationToken) { }
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.IO.FileStream fileStream, long offset, long count, bool chunked, System.Threading.CancellationToken cancellationToken) { }
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.Threading.CancellationToken cancellationToken) { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        internal uint BytesSent { get { throw null; } set { } }
        public bool CompletedSynchronously { get { throw null; } }
        internal ushort DataChunkCount { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* DataChunks { get { throw null; } }
        internal bool EndCalled { get { throw null; } set { } }
        public bool IsCompleted { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped NativeOverlapped { get { throw null; } }
        internal System.Threading.Tasks.Task Task { get { throw null; } }
        internal void Cancel(bool dispose) { }
        internal void Complete() { }
        public void Dispose() { }
        internal void Fail(System.Exception ex) { }
        internal void FailSilently() { }
        internal void IOCompleted(uint errorCode) { }
        internal void IOCompleted(uint errorCode, uint numBytes) { }
    }
    internal partial class ServerSession : System.IDisposable
    {
        internal ServerSession() { }
        public Microsoft.AspNetCore.Server.HttpSys.HttpServerSessionHandle Id { get { throw null; } }
        public void Dispose() { }
    }
    internal sealed partial class StandardFeatureCollection : Microsoft.AspNetCore.Http.Features.IFeatureCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, object>>, System.Collections.IEnumerable
    {
        public StandardFeatureCollection(Microsoft.AspNetCore.Server.HttpSys.FeatureContext featureContext) { }
        public bool IsReadOnly { get { throw null; } }
        public object this[System.Type key] { get { throw null; } set { } }
        public int Revision { get { throw null; } }
        public TFeature Get<TFeature>() { throw null; }
        public void Set<TFeature>(TFeature instance) { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class TimeoutManager
    {
        internal TimeoutManager() { }
        public System.TimeSpan DrainEntityBody { get { throw null; } set { } }
        public System.TimeSpan EntityBody { get { throw null; } set { } }
        public System.TimeSpan HeaderWait { get { throw null; } set { } }
        public System.TimeSpan IdleConnection { get { throw null; } set { } }
        public long MinSendBytesPerSecond { get { throw null; } set { } }
        public System.TimeSpan RequestQueue { get { throw null; } set { } }
        internal void SetUrlGroupTimeouts(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup) { }
    }
    internal static partial class TokenBindingUtil
    {
        public unsafe static byte[] GetProvidedTokenIdFromBindingInfo(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_TOKEN_BINDING_INFO* pTokenBindingInfo, out byte[] referredId) { throw null; }
    }
    internal partial class UrlGroup : System.IDisposable
    {
        internal UrlGroup(Microsoft.AspNetCore.Server.HttpSys.ServerSession serverSession, Microsoft.Extensions.Logging.ILogger logger) { }
        internal ulong Id { get { throw null; } }
        public void Dispose() { }
        internal void RegisterPrefix(string uriPrefix, int contextId) { }
        internal void SetMaxConnections(long maxConnections) { }
        internal void SetProperty(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SERVER_PROPERTY property, System.IntPtr info, uint infosize, bool throwOnError = true) { }
        internal bool UnregisterPrefix(string uriPrefix) { throw null; }
    }
    public partial class UrlPrefix
    {
        private UrlPrefix() { }
        public string FullPrefix { get { throw null; } }
        public string Host { get { throw null; } }
        internal string HostAndPort { get { throw null; } }
        public bool IsHttps { get { throw null; } }
        public string Path { get { throw null; } }
        internal string PathWithoutTrailingSlash { get { throw null; } }
        public string Port { get { throw null; } }
        public int PortValue { get { throw null; } }
        public string Scheme { get { throw null; } }
        public static Microsoft.AspNetCore.Server.HttpSys.UrlPrefix Create(string prefix) { throw null; }
        public static Microsoft.AspNetCore.Server.HttpSys.UrlPrefix Create(string scheme, string host, int? portValue, string path) { throw null; }
        public static Microsoft.AspNetCore.Server.HttpSys.UrlPrefix Create(string scheme, string host, string port, string path) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlPrefixCollection : System.Collections.Generic.ICollection<Microsoft.AspNetCore.Server.HttpSys.UrlPrefix>, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Server.HttpSys.UrlPrefix>, System.Collections.IEnumerable
    {
        internal UrlPrefixCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void Add(Microsoft.AspNetCore.Server.HttpSys.UrlPrefix item) { }
        public void Add(string prefix) { }
        public void Clear() { }
        public bool Contains(Microsoft.AspNetCore.Server.HttpSys.UrlPrefix item) { throw null; }
        public void CopyTo(Microsoft.AspNetCore.Server.HttpSys.UrlPrefix[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Server.HttpSys.UrlPrefix> GetEnumerator() { throw null; }
        internal Microsoft.AspNetCore.Server.HttpSys.UrlPrefix GetPrefix(int id) { throw null; }
        internal void RegisterAllPrefixes(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup) { }
        public bool Remove(Microsoft.AspNetCore.Server.HttpSys.UrlPrefix item) { throw null; }
        public bool Remove(string prefix) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        internal bool TryMatchLongestPrefix(bool isHttps, string host, string originalPath, out string pathBase, out string remainingPath) { throw null; }
        internal void UnregisterAllPrefixes() { }
    }
    internal static partial class ValidationHelper
    {
        public static string ExceptionMessage(System.Exception exception) { throw null; }
        public static string HashString(object objectValue) { throw null; }
        public static string ToString(object objectValue) { throw null; }
    }
}
