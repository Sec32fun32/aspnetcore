// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

internal partial class StartupHook
{
    public StartupHook() { }
    public static void Initialize() { }
}
namespace Microsoft.AspNetCore.Builder
{
    public partial class IISServerOptions
    {
        internal long IisMaxRequestSizeLimit;
        public IISServerOptions() { }
        public bool AllowSynchronousIO { get { throw null; } set { } }
        public string AuthenticationDisplayName { get { throw null; } set { } }
        public bool AutomaticAuthentication { get { throw null; } set { } }
        internal bool ForwardWindowsAuthentication { get { throw null; } set { } }
        public long? MaxRequestBodySize { get { throw null; } set { } }
        internal string[] ServerAddresses { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.Hosting
{
    public static partial class WebHostBuilderIISExtensions
    {
        public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseIIS(this Microsoft.AspNetCore.Hosting.IWebHostBuilder hostBuilder) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Hosting.Views
{
    internal partial class ErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
        public ErrorPage(Microsoft.AspNetCore.Hosting.Views.ErrorPageModel model) { }
        public Microsoft.AspNetCore.Hosting.Views.ErrorPageModel Model { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task ExecuteAsync() { throw null; }
    }
    internal partial class ErrorPageModel
    {
        public ErrorPageModel() { }
        public string ClrVersion { get { throw null; } set { } }
        public string CurrentAssemblyVesion { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> ErrorDetails { get { throw null; } set { } }
        public string OperatingSystemDescription { get { throw null; } set { } }
        public string RuntimeArchitecture { get { throw null; } set { } }
        public string RuntimeDisplayName { get { throw null; } set { } }
        public bool ShowRuntimeDetails { get { throw null; } set { } }
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
namespace Microsoft.AspNetCore.Server.IIS
{
    public sealed partial class BadHttpRequestException : System.IO.IOException
    {
        private BadHttpRequestException() { }
        internal Microsoft.AspNetCore.Server.IIS.RequestRejectionReason Reason { get { throw null; } }
        public int StatusCode { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]internal static Microsoft.AspNetCore.Server.IIS.BadHttpRequestException GetException(Microsoft.AspNetCore.Server.IIS.RequestRejectionReason reason) { throw null; }
        internal static void Throw(Microsoft.AspNetCore.Server.IIS.RequestRejectionReason reason) { }
    }
    internal static partial class CoreStrings
    {
        internal static string BadRequest { get { throw null; } }
        internal static string BadRequest_RequestBodyTooLarge { get { throw null; } }
        internal static string CannotUpgradeNonUpgradableRequest { get { throw null; } }
        internal static string ConnectionAbortedByApplication { get { throw null; } }
        internal static string ConnectionOrStreamAbortedByCancellationToken { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string MaxRequestBodySizeCannotBeModifiedAfterRead { get { throw null; } }
        internal static string MaxRequestBodySizeCannotBeModifiedForUpgradedRequests { get { throw null; } }
        internal static string MaxRequestLimitWarning { get { throw null; } }
        internal static string NonNegativeNumberOrNullRequired { get { throw null; } }
        internal static string ParameterReadOnlyAfterResponseStarted { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string ResponseStreamWasUpgraded { get { throw null; } }
        internal static string SynchronousReadsDisallowed { get { throw null; } }
        internal static string SynchronousWritesDisallowed { get { throw null; } }
        internal static string UnhandledApplicationException { get { throw null; } }
        internal static string UpgradeCannotBeCalledMultipleTimes { get { throw null; } }
        internal static string WritingToResponseBodyAfterResponseCompleted { get { throw null; } }
        internal static string FormatParameterReadOnlyAfterResponseStarted(object name) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public static partial class HttpContextExtensions
    {
        [System.ObsoleteAttribute("This is obsolete and will be removed in a future version. Use GetServerVariable instead.")]
        public static string GetIISServerVariable(this Microsoft.AspNetCore.Http.HttpContext context, string variableName) { throw null; }
    }
    public partial class IISServerDefaults
    {
        public const string AuthenticationScheme = "Windows";
        public IISServerDefaults() { }
    }
    internal static partial class NativeMethods
    {
        internal const string AspNetCoreModuleDll = "aspnetcorev2_inprocess.dll";
        internal const int ERROR_HANDLE_EOF = -2147024858;
        internal const int ERROR_INVALID_PARAMETER = -2147024809;
        internal const int ERROR_NOT_FOUND = -2147023728;
        internal const int ERROR_OPERATION_ABORTED = -2147023901;
        internal const int HR_OK = 0;
        [System.Runtime.InteropServices.DllImport("kernel32.dll")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern bool CloseHandle(System.IntPtr handle);
        public static void HttpCloseConnection(System.IntPtr pInProcessHandler) { }
        public static void HttpDisableBuffering(System.IntPtr pInProcessApplication) { }
        public static void HttpEnableWebsockets(System.IntPtr pInProcessHandler) { }
        public static int HttpFlushResponseBytes(System.IntPtr pInProcessHandler, bool fMoreData, out bool fCompletionExpected) { throw null; }
        internal static Microsoft.AspNetCore.Server.IIS.Core.IISConfigurationData HttpGetApplicationProperties() { throw null; }
        public static void HttpGetAuthenticationInformation(System.IntPtr pInProcessHandler, out string authType, out System.IntPtr token) { throw null; }
        public static void HttpGetCompletionInfo(System.IntPtr pCompletionInfo, out int cbBytes, out int hr) { throw null; }
        internal unsafe static Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_V2* HttpGetRawRequest(System.IntPtr pInProcessHandler) { throw null; }
        public static void HttpPostCompletion(System.IntPtr pInProcessHandler, int cbBytes) { }
        public unsafe static int HttpReadRequestBytes(System.IntPtr pInProcessHandler, byte* pvBuffer, int cbBuffer, out int dwBytesReceived, out bool fCompletionExpected) { throw null; }
        public static void HttpRegisterCallbacks(System.IntPtr pInProcessApplication, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_REQUEST_HANDLER requestCallback, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_SHUTDOWN_HANDLER shutdownCallback, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_DISCONNECT_HANDLER disconnectCallback, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_ASYNC_COMPLETION asyncCallback, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_REQUESTS_DRAINED_HANDLER requestsDrainedHandler, System.IntPtr pvRequestContext, System.IntPtr pvShutdownContext) { }
        public unsafe static void HttpResponseSetKnownHeader(System.IntPtr pInProcessHandler, int headerId, byte* pHeaderValue, ushort length, bool fReplace) { }
        public unsafe static void HttpResponseSetUnknownHeader(System.IntPtr pInProcessHandler, byte* pszHeaderName, byte* pszHeaderValue, ushort usHeaderValueLength, bool fReplace) { }
        public static void HttpSetCompletionStatus(System.IntPtr pInProcessHandler, Microsoft.AspNetCore.Server.IIS.NativeMethods.REQUEST_NOTIFICATION_STATUS rquestNotificationStatus) { }
        public static void HttpSetManagedContext(System.IntPtr pInProcessHandler, System.IntPtr pvManagedContext) { }
        public static void HttpSetResponseStatusCode(System.IntPtr pInProcessHandler, ushort statusCode, string pszReason) { }
        public static void HttpSetServerVariable(System.IntPtr pInProcessHandler, string variableName, string value) { }
        internal static void HttpSetStartupErrorPageContent(byte[] content) { }
        public static void HttpStopCallsIntoManaged(System.IntPtr pInProcessApplication) { }
        public static void HttpStopIncomingRequests(System.IntPtr pInProcessApplication) { }
        public static bool HttpTryCancelIO(System.IntPtr pInProcessHandler) { throw null; }
        public static bool HttpTryGetServerVariable(System.IntPtr pInProcessHandler, string variableName, out string value) { throw null; }
        public unsafe static int HttpWebsocketsReadBytes(System.IntPtr pInProcessHandler, byte* pvBuffer, int cbBuffer, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_WEBSOCKET_ASYNC_COMPLETION pfnCompletionCallback, System.IntPtr pvCompletionContext, out int dwBytesReceived, out bool fCompletionExpected) { throw null; }
        internal unsafe static int HttpWebsocketsWriteBytes(System.IntPtr pInProcessHandler, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* pDataChunks, int nChunks, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_WEBSOCKET_ASYNC_COMPLETION pfnCompletionCallback, System.IntPtr pvCompletionContext, out bool fCompletionExpected) { throw null; }
        internal unsafe static int HttpWriteResponseBytes(System.IntPtr pInProcessHandler, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* pDataChunks, int nChunks, out bool fCompletionExpected) { throw null; }
        public static bool IsAspNetCoreModuleLoaded() { throw null; }
        public delegate Microsoft.AspNetCore.Server.IIS.NativeMethods.REQUEST_NOTIFICATION_STATUS PFN_ASYNC_COMPLETION(System.IntPtr pvManagedHttpContext, int hr, int bytes);
        public delegate void PFN_DISCONNECT_HANDLER(System.IntPtr pvManagedHttpContext);
        public delegate void PFN_REQUESTS_DRAINED_HANDLER(System.IntPtr pvRequestContext);
        public delegate Microsoft.AspNetCore.Server.IIS.NativeMethods.REQUEST_NOTIFICATION_STATUS PFN_REQUEST_HANDLER(System.IntPtr pInProcessHandler, System.IntPtr pvRequestContext);
        public delegate bool PFN_SHUTDOWN_HANDLER(System.IntPtr pvRequestContext);
        public delegate Microsoft.AspNetCore.Server.IIS.NativeMethods.REQUEST_NOTIFICATION_STATUS PFN_WEBSOCKET_ASYNC_COMPLETION(System.IntPtr pInProcessHandler, System.IntPtr completionInfo, System.IntPtr pvCompletionContext);
        public enum REQUEST_NOTIFICATION_STATUS
        {
            RQ_NOTIFICATION_CONTINUE = 0,
            RQ_NOTIFICATION_PENDING = 1,
            RQ_NOTIFICATION_FINISH_REQUEST = 2,
        }
    }
    internal enum RequestRejectionReason
    {
        RequestBodyTooLarge = 0,
    }
}
namespace Microsoft.AspNetCore.Server.IIS.Core
{
    internal partial class DuplexStream : System.IO.Stream
    {
        public DuplexStream(System.IO.Stream requestBody, System.IO.Stream responseBody) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class EmptyStream : Microsoft.AspNetCore.Server.IIS.Core.ReadOnlyStream
    {
        public EmptyStream(Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature bodyControl) { }
        public void Abort(System.Exception error = null) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void StopAcceptingReads() { }
    }
    internal partial class HttpRequestStream : Microsoft.AspNetCore.Server.IIS.Core.ReadOnlyStream
    {
        public HttpRequestStream(Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature bodyControl) { }
        public void Abort(System.Exception error = null) { }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public void StartAcceptingReads(Microsoft.AspNetCore.Server.IIS.Core.IISHttpContext body) { }
        public void StopAcceptingReads() { }
    }
    internal partial class HttpResponseStream : Microsoft.AspNetCore.Server.IIS.Core.WriteOnlyStream
    {
        public HttpResponseStream(Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature bodyControl, Microsoft.AspNetCore.Server.IIS.Core.IISHttpContext context) { }
        public void Abort() { }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public void StartAcceptingWrites() { }
        public void StopAcceptingWrites() { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal enum HttpStreamState
    {
        Open = 0,
        Closed = 1,
        Aborted = 2,
    }
    internal partial class HttpUpgradeStream : System.IO.Stream
    {
        public HttpUpgradeStream(System.IO.Stream requestStream, System.IO.Stream responseStream) { }
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
        public override void Close() { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void WriteByte(byte value) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct IISConfigurationData
    {
        public bool fAnonymousAuthEnable;
        public bool fBasicAuthEnabled;
        public bool fWindowsAuthEnabled;
        public int maxRequestBodySize;
        public System.IntPtr pNativeApplication;
        public string pwzBindings;
        public string pwzFullApplicationPath;
        public string pwzVirtualApplicationPath;
    }
    internal partial interface IISContextFactory
    {
        Microsoft.AspNetCore.Server.IIS.Core.IISHttpContext CreateHttpContext(System.IntPtr pInProcessHandler);
    }
    internal abstract partial class IISHttpContext : Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext, Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature, Microsoft.AspNetCore.Http.Features.IFeatureCollection, Microsoft.AspNetCore.Http.Features.IHttpBodyControlFeature, Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature, Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature, Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature, Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature, Microsoft.AspNetCore.Http.Features.IHttpResponseFeature, Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature, Microsoft.AspNetCore.Http.Features.IServerVariablesFeature, Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, object>>, System.Collections.IEnumerable, System.IDisposable, System.Threading.IThreadPoolWorkItem
    {
        protected System.Exception _applicationException;
        protected System.IO.Pipelines.Pipe _bodyInputPipe;
        protected Microsoft.AspNetCore.Server.IIS.Core.OutputProducer _bodyOutput;
        protected System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<System.Func<object, System.Threading.Tasks.Task>, object>> _onCompleted;
        protected System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<System.Func<object, System.Threading.Tasks.Task>, object>> _onStarting;
        protected readonly System.IntPtr _pInProcessHandler;
        protected System.Threading.Tasks.Task _readBodyTask;
        protected volatile bool _requestAborted;
        protected Microsoft.AspNetCore.Server.IIS.BadHttpRequestException _requestRejectedException;
        protected Microsoft.AspNetCore.Server.IIS.Core.Streams _streams;
        protected System.Threading.Tasks.Task _writeBodyTask;
        internal unsafe IISHttpContext(System.Buffers.MemoryPool<byte> memoryPool, System.IntPtr pInProcessHandler, Microsoft.AspNetCore.Builder.IISServerOptions options, Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer server, Microsoft.Extensions.Logging.ILogger logger) : base (default(Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped), default(int), default(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST*), default(byte[]), default(ulong)) { }
        protected Microsoft.AspNetCore.Server.IIS.Core.IO.IAsyncIOEngine AsyncIO { get { throw null; } set { } }
        public bool HasResponseStarted { get { throw null; } }
        public System.Version HttpVersion { get { throw null; } set { } }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB KnownMethod { get { throw null; } }
        public System.Net.IPAddress LocalIpAddress { get { throw null; } set { } }
        public int LocalPort { get { throw null; } set { } }
        public long? MaxRequestBodySize { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        System.Security.Claims.ClaimsPrincipal Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature.User { get { throw null; } set { } }
        bool Microsoft.AspNetCore.Http.Features.IFeatureCollection.IsReadOnly { get { throw null; } }
        object Microsoft.AspNetCore.Http.Features.IFeatureCollection.this[System.Type key] { get { throw null; } set { } }
        int Microsoft.AspNetCore.Http.Features.IFeatureCollection.Revision { get { throw null; } }
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
        string Microsoft.AspNetCore.Http.Features.IServerVariablesFeature.this[string variableName] { get { throw null; } set { } }
        System.Security.Cryptography.X509Certificates.X509Certificate2 Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature.ClientCertificate { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string PathBase { get { throw null; } set { } }
        public string QueryString { get { throw null; } set { } }
        public string RawTarget { get { throw null; } set { } }
        public string ReasonPhrase { get { throw null; } set { } }
        public System.Net.IPAddress RemoteIpAddress { get { throw null; } set { } }
        public int RemotePort { get { throw null; } set { } }
        public System.IO.Stream RequestBody { get { throw null; } set { } }
        public string RequestConnectionId { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary RequestHeaders { get { throw null; } set { } }
        public System.IO.Stream ResponseBody { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary ResponseHeaders { get { throw null; } set { } }
        public System.IO.Pipelines.PipeWriter ResponsePipeWrapper { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer Server { get { throw null; } }
        public int StatusCode { get { throw null; } set { } }
        public string TraceIdentifier { get { throw null; } set { } }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } set { } }
        internal System.Security.Principal.WindowsPrincipal WindowsUser { get { throw null; } set { } }
        public void Abort(System.Exception reason) { }
        internal void AbortIO(bool clientDisconnect) { }
        protected System.Threading.Tasks.Task CompleteResponseBodyAsync() { throw null; }
        public override void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Execute() { }
        internal object FastFeatureGet(System.Type key) { throw null; }
        internal void FastFeatureSet(System.Type key, object feature) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected System.Threading.Tasks.Task FireOnCompleted() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected System.Threading.Tasks.Task FireOnStarting() { throw null; }
        internal System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected void InitializeContext() { }
        TFeature Microsoft.AspNetCore.Http.Features.IFeatureCollection.Get<TFeature>() { throw null; }
        void Microsoft.AspNetCore.Http.Features.IFeatureCollection.Set<TFeature>(TFeature instance) { }
        void Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature.Abort() { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.CompleteAsync() { throw null; }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.DisableBuffering() { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancellation) { throw null; }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature.StartAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        void Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        System.Threading.Tasks.Task<System.IO.Stream> Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature.UpgradeAsync() { throw null; }
        System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature.GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        internal void OnAsyncCompletion(int hr, int bytes) { }
        public void OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public void OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public void PostCompletion(Microsoft.AspNetCore.Server.IIS.NativeMethods.REQUEST_NOTIFICATION_STATUS requestNotificationStatus) { }
        public abstract System.Threading.Tasks.Task<bool> ProcessRequestAsync();
        protected System.Threading.Tasks.Task ProduceEnd() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> memory, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected void ReportApplicationError(System.Exception ex) { }
        public void ResetFeatureCollection() { }
        public void SetBadRequestState(Microsoft.AspNetCore.Server.IIS.BadHttpRequestException ex) { }
        public void SetResponseHeaders() { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        internal System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<byte> memory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class IISHttpContextOfT<TContext> : Microsoft.AspNetCore.Server.IIS.Core.IISHttpContext
    {
        public IISHttpContextOfT(System.Buffers.MemoryPool<byte> memoryPool, Microsoft.AspNetCore.Hosting.Server.IHttpApplication<TContext> application, System.IntPtr pInProcessHandler, Microsoft.AspNetCore.Builder.IISServerOptions options, Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer server, Microsoft.Extensions.Logging.ILogger logger) : base (default(System.Buffers.MemoryPool<byte>), default(System.IntPtr), default(Microsoft.AspNetCore.Builder.IISServerOptions), default(Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer), default(Microsoft.Extensions.Logging.ILogger)) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<bool> ProcessRequestAsync() { throw null; }
    }
    internal partial class IISHttpServer : Microsoft.AspNetCore.Hosting.Server.IServer, System.IDisposable
    {
        public IISHttpServer(Microsoft.AspNetCore.Server.IIS.Core.IISNativeApplication nativeApplication, Microsoft.Extensions.Hosting.IHostApplicationLifetime applicationLifetime, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider authentication, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.IISServerOptions> options, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer> logger) { }
        public Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        public void Dispose() { }
        public bool IsWebSocketAvailable(System.IntPtr pInProcessHandler) { throw null; }
        public System.Threading.Tasks.Task StartAsync<TContext>(Microsoft.AspNetCore.Hosting.Server.IHttpApplication<TContext> application, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class IISNativeApplication
    {
        public IISNativeApplication(System.IntPtr nativeApplication) { }
        public void Dispose() { }
        ~IISNativeApplication() { }
        public void RegisterCallbacks(Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_REQUEST_HANDLER requestHandler, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_SHUTDOWN_HANDLER shutdownHandler, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_DISCONNECT_HANDLER disconnectHandler, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_ASYNC_COMPLETION onAsyncCompletion, Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_REQUESTS_DRAINED_HANDLER requestDrainedHandler, System.IntPtr requestContext, System.IntPtr shutdownContext) { }
        public void StopCallsIntoManaged() { }
        public void StopIncomingRequests() { }
    }
    public partial class IISServerAuthenticationHandler : Microsoft.AspNetCore.Authentication.IAuthenticationHandler
    {
        public IISServerAuthenticationHandler() { }
        internal Microsoft.AspNetCore.Authentication.AuthenticationScheme Scheme { get { throw null; } }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Authentication.AuthenticateResult> AuthenticateAsync() { throw null; }
        public System.Threading.Tasks.Task ChallengeAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task ForbidAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties properties) { throw null; }
        public System.Threading.Tasks.Task InitializeAsync(Microsoft.AspNetCore.Authentication.AuthenticationScheme scheme, Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    internal partial class IISServerSetupFilter : Microsoft.AspNetCore.Hosting.IStartupFilter
    {
        public IISServerSetupFilter(string virtualPath) { }
        public System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> Configure(System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> next) { throw null; }
    }
    internal partial class OutputProducer
    {
        public OutputProducer(System.IO.Pipelines.Pipe pipe) { }
        public System.IO.Pipelines.PipeReader Reader { get { throw null; } }
        public void Abort(System.Exception error) { }
        public void Dispose() { }
        public System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal abstract partial class ReadOnlyStream : System.IO.Stream
    {
        protected ReadOnlyStream() { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class ServerAddressesFeature : Microsoft.AspNetCore.Hosting.Server.Features.IServerAddressesFeature
    {
        public ServerAddressesFeature() { }
        public System.Collections.Generic.ICollection<string> Addresses { get { throw null; } set { } }
        public bool PreferHostingUrls { get { throw null; } set { } }
    }
    internal partial class Streams
    {
        public Streams(Microsoft.AspNetCore.Server.IIS.Core.IISHttpContext context) { }
        public void Abort(System.Exception error) { }
        public (System.IO.Stream request, System.IO.Stream response) Start() { throw null; }
        public void Stop() { }
        public System.IO.Stream Upgrade() { throw null; }
    }
    public partial class ThrowingWasUpgradedWriteOnlyStream : Microsoft.AspNetCore.Server.IIS.Core.WriteOnlyStream
    {
        public ThrowingWasUpgradedWriteOnlyStream() { }
        public override void Flush() { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class WrappingStream : System.IO.Stream
    {
        public WrappingStream(System.IO.Stream inner) { }
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
        public override void Close() { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override bool Equals(object obj) { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int GetHashCode() { throw null; }
        public override object InitializeLifetimeService() { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public void SetInnerStream(System.IO.Stream inner) { }
        public override void SetLength(long value) { }
        public override string ToString() { throw null; }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void WriteByte(byte value) { }
    }
    public abstract partial class WriteOnlyStream : System.IO.Stream
    {
        protected WriteOnlyStream() { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
    }
}
namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
    internal partial class AsyncIOEngine : Microsoft.AspNetCore.Server.IIS.Core.IO.IAsyncIOEngine, System.IDisposable
    {
        public AsyncIOEngine(object contextSync, System.IntPtr handler) { }
        public void Dispose() { }
        public System.Threading.Tasks.ValueTask FlushAsync(bool moreData) { throw null; }
        public void NotifyCompletion(int hr, int bytes) { }
        public System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> memory) { throw null; }
        public System.Threading.Tasks.ValueTask<int> WriteAsync(System.Buffers.ReadOnlySequence<byte> data) { throw null; }
        internal partial class AsyncFlushOperation : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation
        {
            public AsyncFlushOperation(Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOEngine engine) { }
            public void Initialize(System.IntPtr requestHandler, bool moreData) { }
            protected override bool InvokeOperation(out int hr, out int bytes) { throw null; }
            protected override void ResetOperation() { }
        }
        internal partial class AsyncReadOperation : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation
        {
            public AsyncReadOperation(Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOEngine engine) { }
            public override void FreeOperationResources(int hr, int bytes) { }
            public void Initialize(System.IntPtr requestHandler, System.Memory<byte> memory) { }
            protected override bool InvokeOperation(out int hr, out int bytes) { throw null; }
            protected override bool IsSuccessfulResult(int hr) { throw null; }
            protected override void ResetOperation() { }
        }
    }
    internal abstract partial class AsyncIOOperation : System.Threading.Tasks.Sources.IValueTaskSource, System.Threading.Tasks.Sources.IValueTaskSource<int>
    {
        protected AsyncIOOperation() { }
        public Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation.AsyncContinuation Complete(int hr, int bytes) { throw null; }
        public virtual void FreeOperationResources(int hr, int bytes) { }
        public int GetResult(short token) { throw null; }
        public System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token) { throw null; }
        public Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation.AsyncContinuation? Invoke() { throw null; }
        protected abstract bool InvokeOperation(out int hr, out int bytes);
        protected virtual bool IsSuccessfulResult(int hr) { throw null; }
        public void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags) { }
        protected virtual void ResetOperation() { }
        void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct AsyncContinuation
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public AsyncContinuation(System.Action<object> continuation, object state) { throw null; }
            public System.Action<object> Continuation { get { throw null; } }
            public object State { get { throw null; } }
            public void Invoke() { }
        }
    }
    internal abstract partial class AsyncWriteOperationBase : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation
    {
        protected AsyncWriteOperationBase() { }
        public override void FreeOperationResources(int hr, int bytes) { }
        public void Initialize(System.IntPtr requestHandler, System.Buffers.ReadOnlySequence<byte> buffer) { }
        protected override bool InvokeOperation(out int hr, out int bytes) { throw null; }
        protected override void ResetOperation() { }
        protected unsafe abstract int WriteChunks(System.IntPtr requestHandler, int chunkCount, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* dataChunks, out bool completionExpected);
    }
    internal partial interface IAsyncIOEngine : System.IDisposable
    {
        System.Threading.Tasks.ValueTask FlushAsync(bool moreData);
        void NotifyCompletion(int hr, int bytes);
        System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> memory);
        System.Threading.Tasks.ValueTask<int> WriteAsync(System.Buffers.ReadOnlySequence<byte> data);
    }
    internal partial class WebSocketsAsyncIOEngine : Microsoft.AspNetCore.Server.IIS.Core.IO.IAsyncIOEngine, System.IDisposable
    {
        public WebSocketsAsyncIOEngine(object contextLock, System.IntPtr handler) { }
        public void Dispose() { }
        public System.Threading.Tasks.ValueTask FlushAsync(bool moreData) { throw null; }
        public void NotifyCompletion(int hr, int bytes) { }
        public System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> memory) { throw null; }
        public System.Threading.Tasks.ValueTask<int> WriteAsync(System.Buffers.ReadOnlySequence<byte> data) { throw null; }
        internal partial class AsyncInitializeOperation : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation
        {
            public AsyncInitializeOperation(Microsoft.AspNetCore.Server.IIS.Core.IO.WebSocketsAsyncIOEngine engine) { }
            public void Initialize(System.IntPtr requestHandler) { }
            protected override bool InvokeOperation(out int hr, out int bytes) { throw null; }
            protected override void ResetOperation() { }
        }
        internal partial class WebSocketReadOperation : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncIOOperation
        {
            public static readonly Microsoft.AspNetCore.Server.IIS.NativeMethods.PFN_WEBSOCKET_ASYNC_COMPLETION ReadCallback;
            public WebSocketReadOperation(Microsoft.AspNetCore.Server.IIS.Core.IO.WebSocketsAsyncIOEngine engine) { }
            public override void FreeOperationResources(int hr, int bytes) { }
            public void Initialize(System.IntPtr requestHandler, System.Memory<byte> memory) { }
            protected override bool InvokeOperation(out int hr, out int bytes) { throw null; }
            protected override bool IsSuccessfulResult(int hr) { throw null; }
            protected override void ResetOperation() { }
        }
        internal sealed partial class WebSocketWriteOperation : Microsoft.AspNetCore.Server.IIS.Core.IO.AsyncWriteOperationBase
        {
            public WebSocketWriteOperation(Microsoft.AspNetCore.Server.IIS.Core.IO.WebSocketsAsyncIOEngine engine) { }
            protected override void ResetOperation() { }
            protected unsafe override int WriteChunks(System.IntPtr requestHandler, int chunkCount, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* dataChunks, out bool completionExpected) { throw null; }
        }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal partial class TypeNameHelper
    {
        public TypeNameHelper() { }
        public static string GetTypeDisplayName(object item, bool fullName = true) { throw null; }
        public static string GetTypeDisplayName(System.Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+') { throw null; }
    }
}
namespace Microsoft.Extensions.RazorViews
{
    internal partial class AttributeValue
    {
        public AttributeValue(string prefix, object value, bool literal) { }
        public bool Literal { get { throw null; } }
        public string Prefix { get { throw null; } }
        public object Value { get { throw null; } }
        public static Microsoft.Extensions.RazorViews.AttributeValue FromTuple(System.Tuple<string, object, bool> value) { throw null; }
        public static Microsoft.Extensions.RazorViews.AttributeValue FromTuple(System.Tuple<string, string, bool> value) { throw null; }
        public static implicit operator Microsoft.Extensions.RazorViews.AttributeValue (System.Tuple<string, object, bool> value) { throw null; }
    }
    internal abstract partial class BaseView
    {
        protected BaseView() { }
        protected Microsoft.AspNetCore.Http.HttpContext Context { get { throw null; } }
        protected System.Text.Encodings.Web.HtmlEncoder HtmlEncoder { get { throw null; } set { } }
        protected System.Text.Encodings.Web.JavaScriptEncoder JavaScriptEncoder { get { throw null; } set { } }
        protected System.IO.TextWriter Output { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpRequest Request { get { throw null; } }
        protected Microsoft.AspNetCore.Http.HttpResponse Response { get { throw null; } }
        protected System.Text.Encodings.Web.UrlEncoder UrlEncoder { get { throw null; } set { } }
        protected void BeginWriteAttribute(string name, string begining, int startPosition, string ending, int endPosition, int thingy) { }
        protected void EndWriteAttribute() { }
        public abstract System.Threading.Tasks.Task ExecuteAsync();
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ExecuteAsync(System.IO.Stream stream) { throw null; }
        protected string HtmlEncodeAndReplaceLineBreaks(string input) { throw null; }
        protected virtual System.IO.TextWriter PopWriter() { throw null; }
        protected virtual void PushWriter(System.IO.TextWriter writer) { }
        protected void Write(Microsoft.Extensions.RazorViews.HelperResult result) { }
        protected void Write(object value) { }
        protected void Write(string value) { }
        protected void WriteAttribute(string name, string leader, string trailer, params Microsoft.Extensions.RazorViews.AttributeValue[] values) { }
        protected void WriteAttributeValue(string thingy, int startPostion, object value, int endValue, int dealyo, bool yesno) { }
        protected void WriteLiteral(object value) { }
        protected void WriteLiteral(string value) { }
    }
    internal partial class HelperResult
    {
        public HelperResult(System.Action<System.IO.TextWriter> action) { }
        public System.Action<System.IO.TextWriter> WriteAction { get { throw null; } }
        public void WriteTo(System.IO.TextWriter writer) { }
    }
}
namespace Microsoft.Extensions.StackTrace.Sources
{
    internal partial class ExceptionDetails
    {
        public ExceptionDetails() { }
        public System.Exception Error { get { throw null; } set { } }
        public string ErrorMessage { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo> StackFrames { get { throw null; } set { } }
    }
    internal partial class ExceptionDetailsProvider
    {
        public ExceptionDetailsProvider(Microsoft.Extensions.FileProviders.IFileProvider fileProvider, int sourceCodeLineCount) { }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ExceptionDetails> GetDetails(System.Exception exception) { throw null; }
        internal Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo GetStackFrameSourceCodeInfo(string method, string filePath, int lineNumber) { throw null; }
        internal void ReadFrameContent(Microsoft.Extensions.StackTrace.Sources.StackFrameSourceCodeInfo frame, System.Collections.Generic.IEnumerable<string> allLines, int errorStartLineNumberInFile, int errorEndLineNumberInFile) { }
    }
    internal partial class MethodDisplayInfo
    {
        public MethodDisplayInfo() { }
        public string DeclaringTypeName { get { throw null; } set { } }
        public string GenericArguments { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.StackTrace.Sources.ParameterDisplayInfo> Parameters { get { throw null; } set { } }
        public string SubMethod { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    internal partial class ParameterDisplayInfo
    {
        public ParameterDisplayInfo() { }
        public string Name { get { throw null; } set { } }
        public string Prefix { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    internal partial class PortablePdbReader : System.IDisposable
    {
        public PortablePdbReader() { }
        public void Dispose() { }
        public void PopulateStackFrame(Microsoft.Extensions.StackTrace.Sources.StackFrameInfo frameInfo, System.Reflection.MethodBase method, int IlOffset) { }
    }
    internal partial class StackFrameInfo
    {
        public StackFrameInfo() { }
        public string FilePath { get { throw null; } set { } }
        public int LineNumber { get { throw null; } set { } }
        public Microsoft.Extensions.StackTrace.Sources.MethodDisplayInfo MethodDisplayInfo { get { throw null; } set { } }
        public System.Diagnostics.StackFrame StackFrame { get { throw null; } set { } }
    }
    internal partial class StackFrameSourceCodeInfo
    {
        public StackFrameSourceCodeInfo() { }
        public System.Collections.Generic.IEnumerable<string> ContextCode { get { throw null; } set { } }
        public string ErrorDetails { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string Function { get { throw null; } set { } }
        public int Line { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> PostContextCode { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> PreContextCode { get { throw null; } set { } }
        public int PreContextLine { get { throw null; } set { } }
    }
    internal partial class StackTraceHelper
    {
        public StackTraceHelper() { }
        public static System.Collections.Generic.IList<Microsoft.Extensions.StackTrace.Sources.StackFrameInfo> GetFrames(System.Exception exception) { throw null; }
        internal static Microsoft.Extensions.StackTrace.Sources.MethodDisplayInfo GetMethodDisplayString(System.Reflection.MethodBase method) { throw null; }
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
