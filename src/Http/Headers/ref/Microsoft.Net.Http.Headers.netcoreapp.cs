// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Net.Http.Headers
{
    internal abstract partial class BaseHeaderParser<T> : Microsoft.Net.Http.Headers.HttpHeaderParser<T>
    {
        protected BaseHeaderParser(bool supportsMultipleValues) : base (default(bool)) { }
        protected abstract int GetParsedValueLength(Microsoft.Extensions.Primitives.StringSegment value, int startIndex, out T parsedValue);
        public sealed override bool TryParseValue(Microsoft.Extensions.Primitives.StringSegment value, ref int index, out T parsedValue) { throw null; }
    }
    public partial class CacheControlHeaderValue
    {
        public static readonly string MaxAgeString;
        public static readonly string MaxStaleString;
        public static readonly string MinFreshString;
        public static readonly string MustRevalidateString;
        public static readonly string NoCacheString;
        public static readonly string NoStoreString;
        public static readonly string NoTransformString;
        public static readonly string OnlyIfCachedString;
        public static readonly string PrivateString;
        public static readonly string ProxyRevalidateString;
        public static readonly string PublicString;
        public static readonly string SharedMaxAgeString;
        public CacheControlHeaderValue() { }
        public System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> Extensions { get { throw null; } }
        public System.TimeSpan? MaxAge { get { throw null; } set { } }
        public bool MaxStale { get { throw null; } set { } }
        public System.TimeSpan? MaxStaleLimit { get { throw null; } set { } }
        public System.TimeSpan? MinFresh { get { throw null; } set { } }
        public bool MustRevalidate { get { throw null; } set { } }
        public bool NoCache { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringSegment> NoCacheHeaders { get { throw null; } }
        public bool NoStore { get { throw null; } set { } }
        public bool NoTransform { get { throw null; } set { } }
        public bool OnlyIfCached { get { throw null; } set { } }
        public bool Private { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringSegment> PrivateHeaders { get { throw null; } }
        public bool ProxyRevalidate { get { throw null; } set { } }
        public bool Public { get { throw null; } set { } }
        public System.TimeSpan? SharedMaxAge { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.CacheControlHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.CacheControlHeaderValue parsedValue) { throw null; }
    }
    public partial class ContentDispositionHeaderValue
    {
        public ContentDispositionHeaderValue(Microsoft.Extensions.Primitives.StringSegment dispositionType) { }
        public System.DateTimeOffset? CreationDate { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment DispositionType { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment FileName { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment FileNameStar { get { throw null; } set { } }
        public System.DateTimeOffset? ModificationDate { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public System.DateTimeOffset? ReadDate { get { throw null; } set { } }
        public long? Size { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.ContentDispositionHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public void SetHttpFileName(Microsoft.Extensions.Primitives.StringSegment fileName) { }
        public void SetMimeFileName(Microsoft.Extensions.Primitives.StringSegment fileName) { }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.ContentDispositionHeaderValue parsedValue) { throw null; }
        internal static byte UnEscapeAscii(char digit, char next) { throw null; }
    }
    public static partial class ContentDispositionHeaderValueIdentityExtensions
    {
        public static bool IsFileDisposition(this Microsoft.Net.Http.Headers.ContentDispositionHeaderValue header) { throw null; }
        public static bool IsFormDisposition(this Microsoft.Net.Http.Headers.ContentDispositionHeaderValue header) { throw null; }
    }
    public partial class ContentRangeHeaderValue
    {
        public ContentRangeHeaderValue(long length) { }
        public ContentRangeHeaderValue(long from, long to) { }
        public ContentRangeHeaderValue(long from, long to, long length) { }
        public long? From { get { throw null; } }
        public bool HasLength { get { throw null; } }
        public bool HasRange { get { throw null; } }
        public long? Length { get { throw null; } }
        public long? To { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Unit { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.ContentRangeHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.ContentRangeHeaderValue parsedValue) { throw null; }
    }
    internal sealed partial class CookieHeaderParser : Microsoft.Net.Http.Headers.HttpHeaderParser<Microsoft.Net.Http.Headers.CookieHeaderValue>
    {
        internal CookieHeaderParser(bool supportsMultipleValues) : base (default(bool)) { }
        public override bool TryParseValue(Microsoft.Extensions.Primitives.StringSegment value, ref int index, out Microsoft.Net.Http.Headers.CookieHeaderValue parsedValue) { throw null; }
    }
    public partial class CookieHeaderValue
    {
        public CookieHeaderValue(Microsoft.Extensions.Primitives.StringSegment name) { }
        public CookieHeaderValue(Microsoft.Extensions.Primitives.StringSegment name, Microsoft.Extensions.Primitives.StringSegment value) { }
        public Microsoft.Extensions.Primitives.StringSegment Name { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Value { get { throw null; } set { } }
        internal static void CheckNameFormat(Microsoft.Extensions.Primitives.StringSegment name, string parameterName) { }
        internal static void CheckValueFormat(Microsoft.Extensions.Primitives.StringSegment value, string parameterName) { }
        public override bool Equals(object obj) { throw null; }
        internal static Microsoft.Extensions.Primitives.StringSegment GetCookieValue(Microsoft.Extensions.Primitives.StringSegment input, ref int offset) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.CookieHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.CookieHeaderValue> ParseList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.CookieHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public override string ToString() { throw null; }
        internal static bool TryGetCookieLength(Microsoft.Extensions.Primitives.StringSegment input, ref int offset, out Microsoft.Net.Http.Headers.CookieHeaderValue parsedValue) { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.CookieHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.CookieHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.CookieHeaderValue> parsedValues) { throw null; }
    }
    public partial class EntityTagHeaderValue
    {
        public EntityTagHeaderValue(Microsoft.Extensions.Primitives.StringSegment tag) { }
        public EntityTagHeaderValue(Microsoft.Extensions.Primitives.StringSegment tag, bool isWeak) { }
        public static Microsoft.Net.Http.Headers.EntityTagHeaderValue Any { get { throw null; } }
        public bool IsWeak { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Tag { get { throw null; } }
        public bool Compare(Microsoft.Net.Http.Headers.EntityTagHeaderValue other, bool useStrongComparison) { throw null; }
        public override bool Equals(object obj) { throw null; }
        internal static int GetEntityTagLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, out Microsoft.Net.Http.Headers.EntityTagHeaderValue parsedValue) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.EntityTagHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.EntityTagHeaderValue> ParseList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.EntityTagHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.EntityTagHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.EntityTagHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.EntityTagHeaderValue> parsedValues) { throw null; }
    }
    internal sealed partial class GenericHeaderParser<T> : Microsoft.Net.Http.Headers.BaseHeaderParser<T>
    {
        internal GenericHeaderParser(bool supportsMultipleValues, Microsoft.Net.Http.Headers.GenericHeaderParser<T>.GetParsedValueLengthDelegate getParsedValueLength) : base (default(bool)) { }
        protected override int GetParsedValueLength(Microsoft.Extensions.Primitives.StringSegment value, int startIndex, out T parsedValue) { throw null; }
        internal delegate int GetParsedValueLengthDelegate(Microsoft.Extensions.Primitives.StringSegment value, int startIndex, out T parsedValue);
    }
    public static partial class HeaderNames
    {
        public static readonly string Accept;
        public static readonly string AcceptCharset;
        public static readonly string AcceptEncoding;
        public static readonly string AcceptLanguage;
        public static readonly string AcceptRanges;
        public static readonly string AccessControlAllowCredentials;
        public static readonly string AccessControlAllowHeaders;
        public static readonly string AccessControlAllowMethods;
        public static readonly string AccessControlAllowOrigin;
        public static readonly string AccessControlExposeHeaders;
        public static readonly string AccessControlMaxAge;
        public static readonly string AccessControlRequestHeaders;
        public static readonly string AccessControlRequestMethod;
        public static readonly string Age;
        public static readonly string Allow;
        public static readonly string Authority;
        public static readonly string Authorization;
        public static readonly string CacheControl;
        public static readonly string Connection;
        public static readonly string ContentDisposition;
        public static readonly string ContentEncoding;
        public static readonly string ContentLanguage;
        public static readonly string ContentLength;
        public static readonly string ContentLocation;
        public static readonly string ContentMD5;
        public static readonly string ContentRange;
        public static readonly string ContentSecurityPolicy;
        public static readonly string ContentSecurityPolicyReportOnly;
        public static readonly string ContentType;
        public static readonly string Cookie;
        public static readonly string CorrelationContext;
        public static readonly string Date;
        public static readonly string DNT;
        public static readonly string ETag;
        public static readonly string Expect;
        public static readonly string Expires;
        public static readonly string From;
        public static readonly string Host;
        public static readonly string IfMatch;
        public static readonly string IfModifiedSince;
        public static readonly string IfNoneMatch;
        public static readonly string IfRange;
        public static readonly string IfUnmodifiedSince;
        public static readonly string KeepAlive;
        public static readonly string LastModified;
        public static readonly string Location;
        public static readonly string MaxForwards;
        public static readonly string Method;
        public static readonly string Origin;
        public static readonly string Path;
        public static readonly string Pragma;
        public static readonly string ProxyAuthenticate;
        public static readonly string ProxyAuthorization;
        public static readonly string Range;
        public static readonly string Referer;
        public static readonly string RequestId;
        public static readonly string RetryAfter;
        public static readonly string Scheme;
        public static readonly string SecWebSocketAccept;
        public static readonly string SecWebSocketKey;
        public static readonly string SecWebSocketProtocol;
        public static readonly string SecWebSocketVersion;
        public static readonly string Server;
        public static readonly string SetCookie;
        public static readonly string Status;
        public static readonly string StrictTransportSecurity;
        public static readonly string TE;
        public static readonly string TraceParent;
        public static readonly string TraceState;
        public static readonly string Trailer;
        public static readonly string TransferEncoding;
        public static readonly string Translate;
        public static readonly string Upgrade;
        public static readonly string UpgradeInsecureRequests;
        public static readonly string UserAgent;
        public static readonly string Vary;
        public static readonly string Via;
        public static readonly string Warning;
        public static readonly string WebSocketSubProtocols;
        public static readonly string WWWAuthenticate;
        public static readonly string XFrameOptions;
    }
    public static partial class HeaderQuality
    {
        public const double Match = 1;
        public const double NoMatch = 0;
    }
    public static partial class HeaderUtilities
    {
        internal const string BytesUnit = "bytes";
        internal static bool AreEqualCollections<T>(System.Collections.Generic.ICollection<T> x, System.Collections.Generic.ICollection<T> y) { throw null; }
        internal static bool AreEqualCollections<T>(System.Collections.Generic.ICollection<T> x, System.Collections.Generic.ICollection<T> y, System.Collections.Generic.IEqualityComparer<T> comparer) { throw null; }
        internal static void CheckValidToken(Microsoft.Extensions.Primitives.StringSegment value, string parameterName) { }
        public static bool ContainsCacheDirective(Microsoft.Extensions.Primitives.StringValues cacheControlDirectives, string targetDirectives) { throw null; }
        public static Microsoft.Extensions.Primitives.StringSegment EscapeAsQuotedString(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static string FormatDate(System.DateTimeOffset dateTime) { throw null; }
        public static string FormatDate(System.DateTimeOffset dateTime, bool quoted) { throw null; }
        public static string FormatNonNegativeInt64(long value) { throw null; }
        internal static int GetNextNonEmptyOrWhitespaceIndex(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, bool skipEmptyValues, out bool separatorFound) { throw null; }
        internal static double? GetQuality(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> parameters) { throw null; }
        public static bool IsQuoted(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static Microsoft.Extensions.Primitives.StringSegment RemoveQuotes(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        internal static void SetQuality(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> parameters, double? value) { }
        internal static void ThrowIfReadOnly(bool isReadOnly) { }
        public static bool TryParseDate(Microsoft.Extensions.Primitives.StringSegment input, out System.DateTimeOffset result) { throw null; }
        public static bool TryParseNonNegativeInt32(Microsoft.Extensions.Primitives.StringSegment value, out int result) { throw null; }
        public static bool TryParseNonNegativeInt64(Microsoft.Extensions.Primitives.StringSegment value, out long result) { throw null; }
        internal static bool TryParseQualityDouble(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, out double quality, out int length) { throw null; }
        public static bool TryParseSeconds(Microsoft.Extensions.Primitives.StringValues headerValues, string targetValue, out System.TimeSpan? value) { throw null; }
        public static Microsoft.Extensions.Primitives.StringSegment UnescapeAsQuotedString(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
    }
    internal abstract partial class HttpHeaderParser<T>
    {
        protected HttpHeaderParser(bool supportsMultipleValues) { }
        public bool SupportsMultipleValues { get { throw null; } }
        public virtual System.Collections.Generic.IList<T> ParseStrictValues(System.Collections.Generic.IList<string> values) { throw null; }
        public T ParseValue(Microsoft.Extensions.Primitives.StringSegment value, ref int index) { throw null; }
        public virtual System.Collections.Generic.IList<T> ParseValues(System.Collections.Generic.IList<string> values) { throw null; }
        protected virtual System.Collections.Generic.IList<T> ParseValues(System.Collections.Generic.IList<string> values, bool strict) { throw null; }
        public virtual string ToString(object value) { throw null; }
        public virtual bool TryParseStrictValues(System.Collections.Generic.IList<string> values, out System.Collections.Generic.IList<T> parsedValues) { throw null; }
        public abstract bool TryParseValue(Microsoft.Extensions.Primitives.StringSegment value, ref int index, out T parsedValue);
        protected virtual bool TryParseValues(System.Collections.Generic.IList<string> values, bool strict, out System.Collections.Generic.IList<T> parsedValues) { throw null; }
        public virtual bool TryParseValues(System.Collections.Generic.IList<string> values, out System.Collections.Generic.IList<T> parsedValues) { throw null; }
    }
    internal enum HttpParseResult
    {
        Parsed = 0,
        NotParsed = 1,
        InvalidFormat = 2,
    }
    internal static partial class HttpRuleParser
    {
        internal const char CR = '\r';
        internal static readonly System.Text.Encoding DefaultHttpEncoding;
        internal const char LF = '\n';
        internal const int MaxInt32Digits = 10;
        internal const int MaxInt64Digits = 19;
        internal const char SP = ' ';
        internal const char Tab = '\t';
        internal static int GetNumberLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, bool allowDecimal) { throw null; }
        internal static Microsoft.Net.Http.Headers.HttpParseResult GetQuotedPairLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, out int length) { throw null; }
        internal static Microsoft.Net.Http.Headers.HttpParseResult GetQuotedStringLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, out int length) { throw null; }
        internal static int GetTokenLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex) { throw null; }
        internal static int GetWhitespaceLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex) { throw null; }
        internal static bool IsTokenChar(char character) { throw null; }
        internal static bool TryStringToDate(Microsoft.Extensions.Primitives.StringSegment input, out System.DateTimeOffset result) { throw null; }
    }
    public partial class MediaTypeHeaderValue
    {
        public MediaTypeHeaderValue(Microsoft.Extensions.Primitives.StringSegment mediaType) { }
        public MediaTypeHeaderValue(Microsoft.Extensions.Primitives.StringSegment mediaType, double quality) { }
        public Microsoft.Extensions.Primitives.StringSegment Boundary { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Charset { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.Primitives.StringSegment> Facets { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool MatchesAllSubTypes { get { throw null; } }
        public bool MatchesAllSubTypesWithoutSuffix { get { throw null; } }
        public bool MatchesAllTypes { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment MediaType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public double? Quality { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment SubType { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment SubTypeWithoutSuffix { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Suffix { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Type { get { throw null; } }
        public Microsoft.Net.Http.Headers.MediaTypeHeaderValue Copy() { throw null; }
        public Microsoft.Net.Http.Headers.MediaTypeHeaderValue CopyAsReadOnly() { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool IsSubsetOf(Microsoft.Net.Http.Headers.MediaTypeHeaderValue otherMediaType) { throw null; }
        public static Microsoft.Net.Http.Headers.MediaTypeHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.MediaTypeHeaderValue> ParseList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.MediaTypeHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.MediaTypeHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.MediaTypeHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.MediaTypeHeaderValue> parsedValues) { throw null; }
    }
    public partial class MediaTypeHeaderValueComparer : System.Collections.Generic.IComparer<Microsoft.Net.Http.Headers.MediaTypeHeaderValue>
    {
        private MediaTypeHeaderValueComparer() { }
        public static Microsoft.Net.Http.Headers.MediaTypeHeaderValueComparer QualityComparer { get { throw null; } }
        public int Compare(Microsoft.Net.Http.Headers.MediaTypeHeaderValue mediaType1, Microsoft.Net.Http.Headers.MediaTypeHeaderValue mediaType2) { throw null; }
    }
    public partial class NameValueHeaderValue
    {
        internal static readonly Microsoft.Net.Http.Headers.HttpHeaderParser<Microsoft.Net.Http.Headers.NameValueHeaderValue> MultipleValueParser;
        public NameValueHeaderValue(Microsoft.Extensions.Primitives.StringSegment name) { }
        public NameValueHeaderValue(Microsoft.Extensions.Primitives.StringSegment name, Microsoft.Extensions.Primitives.StringSegment value) { }
        public bool IsReadOnly { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Name { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Value { get { throw null; } set { } }
        public Microsoft.Net.Http.Headers.NameValueHeaderValue Copy() { throw null; }
        public Microsoft.Net.Http.Headers.NameValueHeaderValue CopyAsReadOnly() { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.Net.Http.Headers.NameValueHeaderValue Find(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> values, Microsoft.Extensions.Primitives.StringSegment name) { throw null; }
        public override int GetHashCode() { throw null; }
        internal static int GetHashCode(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> values) { throw null; }
        internal static int GetNameValueListLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, char delimiter, System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> nameValueCollection) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment GetUnescapedValue() { throw null; }
        internal static int GetValueLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex) { throw null; }
        public static Microsoft.Net.Http.Headers.NameValueHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> ParseList(System.Collections.Generic.IList<string> input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> input) { throw null; }
        public void SetAndEscapeValue(Microsoft.Extensions.Primitives.StringSegment value) { }
        public override string ToString() { throw null; }
        internal static string ToString(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> values, char separator, bool leadingSeparator) { throw null; }
        internal static void ToString(System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> values, char separator, bool leadingSeparator, System.Text.StringBuilder destination) { }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.NameValueHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> input, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> input, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.NameValueHeaderValue> parsedValues) { throw null; }
    }
    internal sealed partial class ObjectCollection<T> : System.Collections.ObjectModel.Collection<T>
    {
        internal static readonly System.Action<T> DefaultValidator;
        internal static readonly Microsoft.Net.Http.Headers.ObjectCollection<T> EmptyReadOnlyCollection;
        public ObjectCollection() { }
        public ObjectCollection(System.Action<T> validator, bool isReadOnly = false) { }
        public ObjectCollection(System.Collections.Generic.IEnumerable<T> other, bool isReadOnly = false) { }
        public bool IsReadOnly { get { throw null; } }
        protected override void InsertItem(int index, T item) { }
        protected override void SetItem(int index, T item) { }
    }
    public partial class RangeConditionHeaderValue
    {
        public RangeConditionHeaderValue(Microsoft.Net.Http.Headers.EntityTagHeaderValue entityTag) { }
        public RangeConditionHeaderValue(System.DateTimeOffset lastModified) { }
        public RangeConditionHeaderValue(string entityTag) { }
        public Microsoft.Net.Http.Headers.EntityTagHeaderValue EntityTag { get { throw null; } }
        public System.DateTimeOffset? LastModified { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.RangeConditionHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.RangeConditionHeaderValue parsedValue) { throw null; }
    }
    public partial class RangeHeaderValue
    {
        public RangeHeaderValue() { }
        public RangeHeaderValue(long? from, long? to) { }
        public System.Collections.Generic.ICollection<Microsoft.Net.Http.Headers.RangeItemHeaderValue> Ranges { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Unit { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.RangeHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.RangeHeaderValue parsedValue) { throw null; }
    }
    public partial class RangeItemHeaderValue
    {
        public RangeItemHeaderValue(long? from, long? to) { }
        public long? From { get { throw null; } }
        public long? To { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        internal static int GetRangeItemLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, out Microsoft.Net.Http.Headers.RangeItemHeaderValue parsedValue) { throw null; }
        internal static int GetRangeItemListLength(Microsoft.Extensions.Primitives.StringSegment input, int startIndex, System.Collections.Generic.ICollection<Microsoft.Net.Http.Headers.RangeItemHeaderValue> rangeCollection) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum SameSiteMode
    {
        Unspecified = -1,
        None = 0,
        Lax = 1,
        Strict = 2,
    }
    public partial class SetCookieHeaderValue
    {
        internal static bool SuppressSameSiteNone;
        public SetCookieHeaderValue(Microsoft.Extensions.Primitives.StringSegment name) { }
        public SetCookieHeaderValue(Microsoft.Extensions.Primitives.StringSegment name, Microsoft.Extensions.Primitives.StringSegment value) { }
        public Microsoft.Extensions.Primitives.StringSegment Domain { get { throw null; } set { } }
        public System.DateTimeOffset? Expires { get { throw null; } set { } }
        public bool HttpOnly { get { throw null; } set { } }
        public System.TimeSpan? MaxAge { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Name { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Path { get { throw null; } set { } }
        public Microsoft.Net.Http.Headers.SameSiteMode SameSite { get { throw null; } set { } }
        public bool Secure { get { throw null; } set { } }
        public Microsoft.Extensions.Primitives.StringSegment Value { get { throw null; } set { } }
        public void AppendToStringBuilder(System.Text.StringBuilder builder) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.SetCookieHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.SetCookieHeaderValue> ParseList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.SetCookieHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> inputs) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.SetCookieHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.SetCookieHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> inputs, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.SetCookieHeaderValue> parsedValues) { throw null; }
    }
    public partial class StringWithQualityHeaderValue
    {
        public StringWithQualityHeaderValue(Microsoft.Extensions.Primitives.StringSegment value) { }
        public StringWithQualityHeaderValue(Microsoft.Extensions.Primitives.StringSegment value, double quality) { }
        public double? Quality { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.Net.Http.Headers.StringWithQualityHeaderValue Parse(Microsoft.Extensions.Primitives.StringSegment input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue> ParseList(System.Collections.Generic.IList<string> input) { throw null; }
        public static System.Collections.Generic.IList<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue> ParseStrictList(System.Collections.Generic.IList<string> input) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Microsoft.Extensions.Primitives.StringSegment input, out Microsoft.Net.Http.Headers.StringWithQualityHeaderValue parsedValue) { throw null; }
        public static bool TryParseList(System.Collections.Generic.IList<string> input, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue> parsedValues) { throw null; }
        public static bool TryParseStrictList(System.Collections.Generic.IList<string> input, out System.Collections.Generic.IList<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue> parsedValues) { throw null; }
    }
    public partial class StringWithQualityHeaderValueComparer : System.Collections.Generic.IComparer<Microsoft.Net.Http.Headers.StringWithQualityHeaderValue>
    {
        private StringWithQualityHeaderValueComparer() { }
        public static Microsoft.Net.Http.Headers.StringWithQualityHeaderValueComparer QualityComparer { get { throw null; } }
        public int Compare(Microsoft.Net.Http.Headers.StringWithQualityHeaderValue stringWithQuality1, Microsoft.Net.Http.Headers.StringWithQualityHeaderValue stringWithQuality2) { throw null; }
    }
}
