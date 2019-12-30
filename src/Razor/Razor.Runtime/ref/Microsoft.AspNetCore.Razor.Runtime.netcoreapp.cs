// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Razor.Hosting
{
    internal partial class DefaultRazorCompiledItem : Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem
    {
        public DefaultRazorCompiledItem(System.Type type, string kind, string identifier) { }
        public override string Identifier { get { throw null; } }
        public override string Kind { get { throw null; } }
        public override System.Collections.Generic.IReadOnlyList<object> Metadata { get { throw null; } }
        public override System.Type Type { get { throw null; } }
    }
    public partial interface IRazorSourceChecksumMetadata
    {
        string Checksum { get; }
        string ChecksumAlgorithm { get; }
        string Identifier { get; }
    }
    public abstract partial class RazorCompiledItem
    {
        protected RazorCompiledItem() { }
        public abstract string Identifier { get; }
        public abstract string Kind { get; }
        public abstract System.Collections.Generic.IReadOnlyList<object> Metadata { get; }
        public abstract System.Type Type { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true, Inherited=false)]
    public sealed partial class RazorCompiledItemAttribute : System.Attribute
    {
        public RazorCompiledItemAttribute(System.Type type, string kind, string identifier) { }
        public string Identifier { get { throw null; } }
        public string Kind { get { throw null; } }
        public System.Type Type { get { throw null; } }
    }
    public static partial class RazorCompiledItemExtensions
    {
        public static System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Razor.Hosting.IRazorSourceChecksumMetadata> GetChecksumMetadata(this Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem item) { throw null; }
    }
    public partial class RazorCompiledItemLoader
    {
        public RazorCompiledItemLoader() { }
        protected virtual Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem CreateItem(Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute attribute) { throw null; }
        protected System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute> LoadAttributes(System.Reflection.Assembly assembly) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem> LoadItems(System.Reflection.Assembly assembly) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class RazorCompiledItemMetadataAttribute : System.Attribute
    {
        public RazorCompiledItemMetadataAttribute(string key, string value) { }
        public string Key { get { throw null; } }
        public string Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class RazorConfigurationNameAttribute : System.Attribute
    {
        public RazorConfigurationNameAttribute(string configurationName) { }
        public string ConfigurationName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true, Inherited=false)]
    public sealed partial class RazorExtensionAssemblyNameAttribute : System.Attribute
    {
        public RazorExtensionAssemblyNameAttribute(string extensionName, string assemblyName) { }
        public string AssemblyName { get { throw null; } }
        public string ExtensionName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class RazorLanguageVersionAttribute : System.Attribute
    {
        public RazorLanguageVersionAttribute(string languageVersion) { }
        public string LanguageVersion { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class RazorSourceChecksumAttribute : System.Attribute, Microsoft.AspNetCore.Razor.Hosting.IRazorSourceChecksumMetadata
    {
        public RazorSourceChecksumAttribute(string checksumAlgorithm, string checksum, string identifier) { }
        public string Checksum { get { throw null; } }
        public string ChecksumAlgorithm { get { throw null; } }
        public string Identifier { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.Razor.Runtime
{
    internal static partial class Resources
    {
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string ScopeManager_EndCannotBeCalledWithoutACallToBegin { get { throw null; } }
        internal static string FormatScopeManager_EndCannotBeCalledWithoutACallToBegin(object p0, object p1, object p2) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Razor.Runtime.TagHelpers
{
    public partial class TagHelperExecutionContext
    {
        internal TagHelperExecutionContext(string tagName, Microsoft.AspNetCore.Razor.TagHelpers.TagMode tagMode) { }
        public TagHelperExecutionContext(string tagName, Microsoft.AspNetCore.Razor.TagHelpers.TagMode tagMode, System.Collections.Generic.IDictionary<object, object> items, string uniqueId, System.Func<System.Threading.Tasks.Task> executeChildContentAsync, System.Action<System.Text.Encodings.Web.HtmlEncoder> startTagHelperWritingScope, System.Func<Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent> endTagHelperWritingScope) { }
        public bool ChildContentRetrieved { get { throw null; } }
        public Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext Context { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } }
        public Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput Output { get { throw null; } internal set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper> TagHelpers { get { throw null; } }
        public void Add(Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper tagHelper) { }
        public void AddHtmlAttribute(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute attribute) { }
        public void AddHtmlAttribute(string name, object value, Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle valueStyle) { }
        public void AddTagHelperAttribute(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute attribute) { }
        public void AddTagHelperAttribute(string name, object value, Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle valueStyle) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent> GetChildContentAsync(bool useCachedResult, System.Text.Encodings.Web.HtmlEncoder encoder) { throw null; }
        public void Reinitialize(string tagName, Microsoft.AspNetCore.Razor.TagHelpers.TagMode tagMode, System.Collections.Generic.IDictionary<object, object> items, string uniqueId, System.Func<System.Threading.Tasks.Task> executeChildContentAsync) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task SetOutputContentAsync() { throw null; }
    }
    public partial class TagHelperRunner
    {
        public TagHelperRunner() { }
        public System.Threading.Tasks.Task RunAsync(Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext executionContext) { throw null; }
    }
    public partial class TagHelperScopeManager
    {
        public TagHelperScopeManager(System.Action<System.Text.Encodings.Web.HtmlEncoder> startTagHelperWritingScope, System.Func<Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent> endTagHelperWritingScope) { }
        public Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext Begin(string tagName, Microsoft.AspNetCore.Razor.TagHelpers.TagMode tagMode, string uniqueId, System.Func<System.Threading.Tasks.Task> executeChildContentAsync) { throw null; }
        public Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext End() { throw null; }
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
