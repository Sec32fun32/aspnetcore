// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Internal
{
    internal static partial class AspNetCoreTempDirectory
    {
        public static string TempDirectory { get { throw null; } }
        public static System.Func<string> TempDirectoryFactory { get { throw null; } }
    }
    internal partial class UrlDecoder
    {
        public UrlDecoder() { }
        public static int DecodeInPlace(System.Span<byte> buffer, bool isFormEncoding) { throw null; }
        public static int DecodeRequestLine(System.ReadOnlySpan<byte> source, System.Span<byte> destination, bool isFormEncoding) { throw null; }
    }
}
namespace Microsoft.AspNetCore.WebUtilities
{
    public static partial class Base64UrlTextEncoder
    {
        public static byte[] Decode(string text) { throw null; }
        public static string Encode(byte[] data) { throw null; }
    }
    public partial class BufferedReadStream : System.IO.Stream
    {
        public BufferedReadStream(System.IO.Stream inner, int bufferSize) { }
        public BufferedReadStream(System.IO.Stream inner, int bufferSize, System.Buffers.ArrayPool<byte> bytePool) { }
        public System.ArraySegment<byte> BufferedData { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public bool EnsureBuffered() { throw null; }
        public bool EnsureBuffered(int minCount) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> EnsureBufferedAsync(int minCount, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<bool> EnsureBufferedAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public string ReadLine(int lengthLimit) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<string> ReadLineAsync(int lengthLimit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class FileBufferingReadStream : System.IO.Stream
    {
        public FileBufferingReadStream(System.IO.Stream inner, int memoryThreshold) { }
        public FileBufferingReadStream(System.IO.Stream inner, int memoryThreshold, long? bufferLimit, System.Func<string> tempFileDirectoryAccessor) { }
        public FileBufferingReadStream(System.IO.Stream inner, int memoryThreshold, long? bufferLimit, System.Func<string> tempFileDirectoryAccessor, System.Buffers.ArrayPool<byte> bytePool) { }
        public FileBufferingReadStream(System.IO.Stream inner, int memoryThreshold, long? bufferLimit, string tempFileDirectory) { }
        public FileBufferingReadStream(System.IO.Stream inner, int memoryThreshold, long? bufferLimit, string tempFileDirectory, System.Buffers.ArrayPool<byte> bytePool) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool InMemory { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public string TempFileName { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class FileBufferingWriteStream : System.IO.Stream
    {
        public FileBufferingWriteStream(int memoryThreshold = 32768, long? bufferLimit = default(long?), System.Func<string> tempFileDirectoryAccessor = null) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        internal bool Disposed { get { throw null; } }
        internal System.IO.FileStream FileStream { get { throw null; } }
        public override long Length { get { throw null; } }
        internal Microsoft.AspNetCore.WebUtilities.PagedByteBuffer PagedByteBuffer { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task DrainBufferAsync(System.IO.Stream destination, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class FileMultipartSection
    {
        public FileMultipartSection(Microsoft.AspNetCore.WebUtilities.MultipartSection section) { }
        public FileMultipartSection(Microsoft.AspNetCore.WebUtilities.MultipartSection section, Microsoft.Net.Http.Headers.ContentDispositionHeaderValue header) { }
        public string FileName { get { throw null; } }
        public System.IO.Stream FileStream { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.WebUtilities.MultipartSection Section { get { throw null; } }
    }
    public partial class FormMultipartSection
    {
        public FormMultipartSection(Microsoft.AspNetCore.WebUtilities.MultipartSection section) { }
        public FormMultipartSection(Microsoft.AspNetCore.WebUtilities.MultipartSection section, Microsoft.Net.Http.Headers.ContentDispositionHeaderValue header) { }
        public string Name { get { throw null; } }
        public Microsoft.AspNetCore.WebUtilities.MultipartSection Section { get { throw null; } }
        public System.Threading.Tasks.Task<string> GetValueAsync() { throw null; }
    }
    public partial class FormPipeReader
    {
        public FormPipeReader(System.IO.Pipelines.PipeReader pipeReader) { }
        public FormPipeReader(System.IO.Pipelines.PipeReader pipeReader, System.Text.Encoding encoding) { }
        public int KeyLengthLimit { get { throw null; } set { } }
        public int ValueCountLimit { get { throw null; } set { } }
        public int ValueLengthLimit { get { throw null; } set { } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]internal void ParseFormValues(ref System.Buffers.ReadOnlySequence<byte> buffer, ref Microsoft.AspNetCore.WebUtilities.KeyValueAccumulator accumulator, bool isFinalBlock) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>> ReadFormAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FormReader : System.IDisposable
    {
        public const int DefaultKeyLengthLimit = 2048;
        public const int DefaultValueCountLimit = 1024;
        public const int DefaultValueLengthLimit = 4194304;
        public FormReader(System.IO.Stream stream) { }
        public FormReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public FormReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Buffers.ArrayPool<char> charPool) { }
        public FormReader(string data) { }
        public FormReader(string data, System.Buffers.ArrayPool<char> charPool) { }
        public int KeyLengthLimit { get { throw null; } set { } }
        public int ValueCountLimit { get { throw null; } set { } }
        public int ValueLengthLimit { get { throw null; } set { } }
        public void Dispose() { }
        public System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> ReadForm() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>> ReadFormAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Collections.Generic.KeyValuePair<string, string>? ReadNextPair() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<string, string>?> ReadNextPairAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HttpRequestStreamReader : System.IO.TextReader
    {
        public HttpRequestStreamReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public HttpRequestStreamReader(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        public HttpRequestStreamReader(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize, System.Buffers.ArrayPool<byte> bytePool, System.Buffers.ArrayPool<char> charPool) { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
        public override int Read(char[] buffer, int index, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { throw null; }
    }
    public partial class HttpResponseStreamWriter : System.IO.TextWriter
    {
        internal const int DefaultBufferSize = 16384;
        public HttpResponseStreamWriter(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public HttpResponseStreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        public HttpResponseStreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize, System.Buffers.ArrayPool<byte> bytePool, System.Buffers.ArrayPool<char> charPool) { }
        public override System.Text.Encoding Encoding { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync() { throw null; }
        public override void Write(char value) { }
        public override void Write(char[] values, int index, int count) { }
        public override void Write(string value) { }
        public override System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(char[] values, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct KeyValueAccumulator
    {
        private object _dummy;
        private int _dummyPrimitive;
        public bool HasValues { get { throw null; } }
        public int KeyCount { get { throw null; } }
        public int ValueCount { get { throw null; } }
        public void Append(string key, string value) { }
        public System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> GetResults() { throw null; }
    }
    internal partial class MultipartBoundary
    {
        public MultipartBoundary(string boundary, bool expectLeadingCrlf = true) { }
        public byte[] BoundaryBytes { get { throw null; } }
        public bool ExpectLeadingCrlf { get { throw null; } set { } }
        public int FinalBoundaryLength { get { throw null; } }
        public int GetSkipValue(byte input) { throw null; }
    }
    public partial class MultipartReader
    {
        public const int DefaultHeadersCountLimit = 16;
        public const int DefaultHeadersLengthLimit = 16384;
        public MultipartReader(string boundary, System.IO.Stream stream) { }
        public MultipartReader(string boundary, System.IO.Stream stream, int bufferSize) { }
        public long? BodyLengthLimit { get { throw null; } set { } }
        public int HeadersCountLimit { get { throw null; } set { } }
        public int HeadersLengthLimit { get { throw null; } set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.WebUtilities.MultipartSection> ReadNextSectionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal sealed partial class MultipartReaderStream : System.IO.Stream
    {
        public MultipartReaderStream(Microsoft.AspNetCore.WebUtilities.BufferedReadStream stream, Microsoft.AspNetCore.WebUtilities.MultipartBoundary boundary) { }
        public MultipartReaderStream(Microsoft.AspNetCore.WebUtilities.BufferedReadStream stream, Microsoft.AspNetCore.WebUtilities.MultipartBoundary boundary, System.Buffers.ArrayPool<byte> bytePool) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool FinalBoundaryFound { get { throw null; } }
        public override long Length { get { throw null; } }
        public long? LengthLimit { get { throw null; } set { } }
        public override long Position { get { throw null; } set { } }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class MultipartSection
    {
        public MultipartSection() { }
        public long? BaseStreamOffset { get { throw null; } set { } }
        public System.IO.Stream Body { get { throw null; } set { } }
        public string ContentDisposition { get { throw null; } }
        public string ContentType { get { throw null; } }
        public System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> Headers { get { throw null; } set { } }
    }
    public static partial class MultipartSectionConverterExtensions
    {
        public static Microsoft.AspNetCore.WebUtilities.FileMultipartSection AsFileSection(this Microsoft.AspNetCore.WebUtilities.MultipartSection section) { throw null; }
        public static Microsoft.AspNetCore.WebUtilities.FormMultipartSection AsFormDataSection(this Microsoft.AspNetCore.WebUtilities.MultipartSection section) { throw null; }
        public static Microsoft.Net.Http.Headers.ContentDispositionHeaderValue GetContentDispositionHeader(this Microsoft.AspNetCore.WebUtilities.MultipartSection section) { throw null; }
    }
    public static partial class MultipartSectionStreamExtensions
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task<string> ReadAsStringAsync(this Microsoft.AspNetCore.WebUtilities.MultipartSection section) { throw null; }
    }
    internal sealed partial class PagedByteBuffer : System.IDisposable
    {
        internal const int PageSize = 1024;
        public PagedByteBuffer(System.Buffers.ArrayPool<byte> arrayPool) { }
        internal bool Disposed { get { throw null; } }
        public int Length { get { throw null; } }
        internal System.Collections.Generic.List<byte[]> Pages { get { throw null; } }
        public void Add(byte[] buffer, int offset, int count) { }
        public void Dispose() { }
        public void MoveTo(System.IO.Stream stream) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task MoveToAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class QueryHelpers
    {
        public static string AddQueryString(string uri, System.Collections.Generic.IDictionary<string, string> queryString) { throw null; }
        public static string AddQueryString(string uri, string name, string value) { throw null; }
        public static System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> ParseNullableQuery(string queryString) { throw null; }
        public static System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> ParseQuery(string queryString) { throw null; }
    }
    public static partial class ReasonPhrases
    {
        public static string GetReasonPhrase(int statusCode) { throw null; }
    }
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string HttpRequestStreamReader_StreamNotReadable { get { throw null; } }
        internal static string HttpResponseStreamWriter_StreamNotWritable { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string WebEncoders_InvalidCountOffsetOrLength { get { throw null; } }
        internal static string FormatWebEncoders_InvalidCountOffsetOrLength(object p0, object p1, object p2) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public static partial class StreamHelperExtensions
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task DrainAsync(this System.IO.Stream stream, System.Buffers.ArrayPool<byte> bytePool, long? limit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task DrainAsync(this System.IO.Stream stream, long? limit, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task DrainAsync(this System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class WebEncoders
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
