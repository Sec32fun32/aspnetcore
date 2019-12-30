// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components
{
    public static partial class BindConverter
    {
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<bool> ConvertToBool;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<System.DateTime> ConvertToDateTime;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<System.DateTimeOffset> ConvertToDateTimeOffset;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParserWithFormat<System.DateTimeOffset> ConvertToDateTimeOffsetWithFormat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParserWithFormat<System.DateTime> ConvertToDateTimeWithFormat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<decimal> ConvertToDecimal;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<double> ConvertToDoubleDelegate;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<float> ConvertToFloat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<int> ConvertToInt;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<long> ConvertToLong;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<bool?> ConvertToNullableBool;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<System.DateTime?> ConvertToNullableDateTime;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<System.DateTimeOffset?> ConvertToNullableDateTimeOffset;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParserWithFormat<System.DateTimeOffset?> ConvertToNullableDateTimeOffsetWithFormat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParserWithFormat<System.DateTime?> ConvertToNullableDateTimeWithFormat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<decimal?> ConvertToNullableDecimal;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<double?> ConvertToNullableDoubleDelegate;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<float?> ConvertToNullableFloat;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<int?> ConvertToNullableInt;
        internal static Microsoft.AspNetCore.Components.BindConverter.BindParser<long?> ConvertToNullableLong;
        internal static readonly Microsoft.AspNetCore.Components.BindConverter.BindParser<string> ConvertToString;
        public static bool FormatValue(bool value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(decimal value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(double value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(int value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(long value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static bool? FormatValue(bool? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset? value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime? value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(decimal? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(double? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(int? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(long? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(float? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(float value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(string value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static object FormatValue<T>(T value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static bool TryConvertToBool(object obj, System.Globalization.CultureInfo culture, out bool value) { throw null; }
        public static bool TryConvertToDateTime(object obj, System.Globalization.CultureInfo culture, out System.DateTime value) { throw null; }
        public static bool TryConvertToDateTime(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTime value) { throw null; }
        public static bool TryConvertToDateTimeOffset(object obj, System.Globalization.CultureInfo culture, out System.DateTimeOffset value) { throw null; }
        public static bool TryConvertToDateTimeOffset(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTimeOffset value) { throw null; }
        public static bool TryConvertToDecimal(object obj, System.Globalization.CultureInfo culture, out decimal value) { throw null; }
        public static bool TryConvertToDouble(object obj, System.Globalization.CultureInfo culture, out double value) { throw null; }
        public static bool TryConvertToFloat(object obj, System.Globalization.CultureInfo culture, out float value) { throw null; }
        public static bool TryConvertToInt(object obj, System.Globalization.CultureInfo culture, out int value) { throw null; }
        public static bool TryConvertToLong(object obj, System.Globalization.CultureInfo culture, out long value) { throw null; }
        public static bool TryConvertToNullableBool(object obj, System.Globalization.CultureInfo culture, out bool? value) { throw null; }
        public static bool TryConvertToNullableDateTime(object obj, System.Globalization.CultureInfo culture, out System.DateTime? value) { throw null; }
        public static bool TryConvertToNullableDateTime(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTime? value) { throw null; }
        public static bool TryConvertToNullableDateTimeOffset(object obj, System.Globalization.CultureInfo culture, out System.DateTimeOffset? value) { throw null; }
        public static bool TryConvertToNullableDateTimeOffset(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTimeOffset? value) { throw null; }
        public static bool TryConvertToNullableDecimal(object obj, System.Globalization.CultureInfo culture, out decimal? value) { throw null; }
        public static bool TryConvertToNullableDouble(object obj, System.Globalization.CultureInfo culture, out double? value) { throw null; }
        public static bool TryConvertToNullableFloat(object obj, System.Globalization.CultureInfo culture, out float? value) { throw null; }
        public static bool TryConvertToNullableInt(object obj, System.Globalization.CultureInfo culture, out int? value) { throw null; }
        public static bool TryConvertToNullableLong(object obj, System.Globalization.CultureInfo culture, out long? value) { throw null; }
        public static bool TryConvertToString(object obj, System.Globalization.CultureInfo culture, out string value) { throw null; }
        public static bool TryConvertTo<T>(object obj, System.Globalization.CultureInfo culture, out T value) { throw null; }
        internal delegate bool BindParserWithFormat<T>(object obj, System.Globalization.CultureInfo culture, string format, out T value);
        internal delegate bool BindParser<T>(object obj, System.Globalization.CultureInfo culture, out T value);
        internal static partial class ParserDelegateCache
        {
            public static Microsoft.AspNetCore.Components.BindConverter.BindParser<T> Get<T>() { throw null; }
        }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class BindElementAttribute : System.Attribute
    {
        public BindElementAttribute(string element, string suffix, string valueAttribute, string changeAttribute) { }
        public string ChangeAttribute { get { throw null; } }
        public string Element { get { throw null; } }
        public string Suffix { get { throw null; } }
        public string ValueAttribute { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class CascadingParameterAttribute : System.Attribute
    {
        public CascadingParameterAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CascadingParameterState
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CascadingParameterState(string localValueName, Microsoft.AspNetCore.Components.ICascadingValueComponent valueSupplier) { throw null; }
        public string LocalValueName { get { throw null; } }
        public Microsoft.AspNetCore.Components.ICascadingValueComponent ValueSupplier { get { throw null; } }
        public static System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.CascadingParameterState> FindCascadingParameters(Microsoft.AspNetCore.Components.Rendering.ComponentState componentState) { throw null; }
    }
    public partial class CascadingValue<TValue> : Microsoft.AspNetCore.Components.ICascadingValueComponent, Microsoft.AspNetCore.Components.IComponent
    {
        public CascadingValue() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment ChildContent { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public bool IsFixed { get { throw null; } set { } }
        object Microsoft.AspNetCore.Components.ICascadingValueComponent.CurrentValue { get { throw null; } }
        bool Microsoft.AspNetCore.Components.ICascadingValueComponent.CurrentValueIsFixed { get { throw null; } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public string Name { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public TValue Value { get { throw null; } set { } }
        public void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        bool Microsoft.AspNetCore.Components.ICascadingValueComponent.CanSupplyValue(System.Type requestedType, string requestedName) { throw null; }
        void Microsoft.AspNetCore.Components.ICascadingValueComponent.Subscribe(Microsoft.AspNetCore.Components.Rendering.ComponentState subscriber) { }
        void Microsoft.AspNetCore.Components.ICascadingValueComponent.Unsubscribe(Microsoft.AspNetCore.Components.Rendering.ComponentState subscriber) { }
        public System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    internal partial class ChangeDetection
    {
        public ChangeDetection() { }
        public static bool MayHaveChanged<T1, T2>(T1 oldValue, T2 newValue) { throw null; }
    }
    public partial class ChangeEventArgs : System.EventArgs
    {
        public ChangeEventArgs() { }
        public object Value { get { throw null; } set { } }
    }
    public abstract partial class ComponentBase : Microsoft.AspNetCore.Components.IComponent, Microsoft.AspNetCore.Components.IHandleAfterRender, Microsoft.AspNetCore.Components.IHandleEvent
    {
        public ComponentBase() { }
        protected virtual void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder) { }
        protected System.Threading.Tasks.Task InvokeAsync(System.Action workItem) { throw null; }
        protected System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> workItem) { throw null; }
        void Microsoft.AspNetCore.Components.IComponent.Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Components.IHandleAfterRender.OnAfterRenderAsync() { throw null; }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Components.IHandleEvent.HandleEventAsync(Microsoft.AspNetCore.Components.EventCallbackWorkItem callback, object arg) { throw null; }
        protected virtual void OnAfterRender(bool firstRender) { }
        protected virtual System.Threading.Tasks.Task OnAfterRenderAsync(bool firstRender) { throw null; }
        protected virtual void OnInitialized() { }
        protected virtual System.Threading.Tasks.Task OnInitializedAsync() { throw null; }
        protected virtual void OnParametersSet() { }
        protected virtual System.Threading.Tasks.Task OnParametersSetAsync() { throw null; }
        public virtual System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
        protected virtual bool ShouldRender() { throw null; }
        protected void StateHasChanged() { }
    }
    internal partial class ComponentFactory
    {
        public static readonly Microsoft.AspNetCore.Components.ComponentFactory Instance;
        public ComponentFactory() { }
        public Microsoft.AspNetCore.Components.IComponent InstantiateComponent(System.IServiceProvider serviceProvider, System.Type componentType) { throw null; }
    }
    public abstract partial class Dispatcher
    {
        protected Dispatcher() { }
        internal event System.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        public void AssertAccess() { }
        public abstract bool CheckAccess();
        public static Microsoft.AspNetCore.Components.Dispatcher CreateDefault() { throw null; }
        public abstract System.Threading.Tasks.Task InvokeAsync(System.Action workItem);
        public abstract System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> workItem);
        public abstract System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> workItem);
        public abstract System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<TResult> workItem);
        protected void OnUnhandledException(System.UnhandledExceptionEventArgs e) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ElementReference
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ElementReference(string id) { throw null; }
        public string Id { get { throw null; } }
        internal static Microsoft.AspNetCore.Components.ElementReference CreateWithUniqueId() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallback : Microsoft.AspNetCore.Components.IEventCallback
    {
        internal readonly System.MulticastDelegate Delegate;
        public static readonly Microsoft.AspNetCore.Components.EventCallback Empty;
        public static readonly Microsoft.AspNetCore.Components.EventCallbackFactory Factory;
        internal readonly Microsoft.AspNetCore.Components.IHandleEvent Receiver;
        public EventCallback(Microsoft.AspNetCore.Components.IHandleEvent receiver, System.MulticastDelegate @delegate) { throw null; }
        public bool HasDelegate { get { throw null; } }
        internal bool RequiresExplicitReceiver { get { throw null; } }
        public System.Threading.Tasks.Task InvokeAsync(object arg) { throw null; }
        object Microsoft.AspNetCore.Components.IEventCallback.UnpackForRenderTree() { throw null; }
    }
    public sealed partial class EventCallbackFactory
    {
        public EventCallbackFactory() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, Microsoft.AspNetCore.Components.EventCallback callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Action callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Action<object> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Func<object, System.Threading.Tasks.Task> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Func<System.Threading.Tasks.Task> callback) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<TValue> CreateInferred<TValue>(object receiver, System.Action<TValue> callback, TValue value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<TValue> CreateInferred<TValue>(object receiver, System.Func<TValue, System.Threading.Tasks.Task> callback, TValue value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, Microsoft.AspNetCore.Components.EventCallback callback) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, Microsoft.AspNetCore.Components.EventCallback<TValue> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, System.Action callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, System.Action<TValue> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, System.Func<System.Threading.Tasks.Task> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<TValue> Create<TValue>(object receiver, System.Func<TValue, System.Threading.Tasks.Task> callback) { throw null; }
    }
    public static partial class EventCallbackFactoryBinderExtensions
    {
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<bool> setter, bool existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset> setter, System.DateTimeOffset existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset> setter, System.DateTimeOffset existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime> setter, System.DateTime existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime> setter, System.DateTime existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<decimal> setter, decimal existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<double> setter, double existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<int> setter, int existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<long> setter, long existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<bool?> setter, bool? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset?> setter, System.DateTimeOffset? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset?> setter, System.DateTimeOffset? existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime?> setter, System.DateTime? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime?> setter, System.DateTime? existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<decimal?> setter, decimal? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<double?> setter, double? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<int?> setter, int? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<long?> setter, long? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<float?> setter, float? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<float> setter, float existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<string> setter, string existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> CreateBinder<T>(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<T> setter, T existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
    }
    public static partial class EventCallbackFactoryEventArgsExtensions
    {
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<Microsoft.AspNetCore.Components.ChangeEventArgs> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<System.EventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.EventArgs> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Func<Microsoft.AspNetCore.Components.ChangeEventArgs, System.Threading.Tasks.Task> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<System.EventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Func<System.EventArgs, System.Threading.Tasks.Task> callback) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallbackWorkItem
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Microsoft.AspNetCore.Components.EventCallbackWorkItem Empty;
        public EventCallbackWorkItem(System.MulticastDelegate @delegate) { throw null; }
        public System.Threading.Tasks.Task InvokeAsync(object arg) { throw null; }
        internal static System.Threading.Tasks.Task InvokeAsync<T>(System.MulticastDelegate @delegate, T arg) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallback<TValue> : Microsoft.AspNetCore.Components.IEventCallback
    {
        internal readonly System.MulticastDelegate Delegate;
        public static readonly Microsoft.AspNetCore.Components.EventCallback<TValue> Empty;
        internal readonly Microsoft.AspNetCore.Components.IHandleEvent Receiver;
        public EventCallback(Microsoft.AspNetCore.Components.IHandleEvent receiver, System.MulticastDelegate @delegate) { throw null; }
        public bool HasDelegate { get { throw null; } }
        internal bool RequiresExplicitReceiver { get { throw null; } }
        internal Microsoft.AspNetCore.Components.EventCallback AsUntyped() { throw null; }
        public System.Threading.Tasks.Task InvokeAsync(TValue arg) { throw null; }
        object Microsoft.AspNetCore.Components.IEventCallback.UnpackForRenderTree() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class EventHandlerAttribute : System.Attribute
    {
        public EventHandlerAttribute(string attributeName, System.Type eventArgsType) { }
        public EventHandlerAttribute(string attributeName, System.Type eventArgsType, bool enableStopPropagation, bool enablePreventDefault) { }
        public string AttributeName { get { throw null; } }
        public bool EnablePreventDefault { get { throw null; } }
        public bool EnableStopPropagation { get { throw null; } }
        public System.Type EventArgsType { get { throw null; } }
    }
    internal partial interface ICascadingValueComponent
    {
        object CurrentValue { get; }
        bool CurrentValueIsFixed { get; }
        bool CanSupplyValue(System.Type valueType, string valueName);
        void Subscribe(Microsoft.AspNetCore.Components.Rendering.ComponentState subscriber);
        void Unsubscribe(Microsoft.AspNetCore.Components.Rendering.ComponentState subscriber);
    }
    public partial interface IComponent
    {
        void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle);
        System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters);
    }
    internal partial interface IEventCallback
    {
        bool HasDelegate { get; }
        object UnpackForRenderTree();
    }
    public partial interface IHandleAfterRender
    {
        System.Threading.Tasks.Task OnAfterRenderAsync();
    }
    public partial interface IHandleEvent
    {
        System.Threading.Tasks.Task HandleEventAsync(Microsoft.AspNetCore.Components.EventCallbackWorkItem item, object arg);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class InjectAttribute : System.Attribute
    {
        public InjectAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class LayoutAttribute : System.Attribute
    {
        public LayoutAttribute(System.Type layoutType) { }
        public System.Type LayoutType { get { throw null; } }
    }
    public abstract partial class LayoutComponentBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        internal const string BodyPropertyName = "Body";
        protected LayoutComponentBase() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment Body { get { throw null; } set { } }
    }
    public partial class LayoutView : Microsoft.AspNetCore.Components.IComponent
    {
        public LayoutView() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment ChildContent { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public System.Type Layout { get { throw null; } set { } }
        public void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        public System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    public sealed partial class LocationChangeException : System.Exception
    {
        public LocationChangeException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MarkupString
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MarkupString(string value) { throw null; }
        public string Value { get { throw null; } }
        public static explicit operator Microsoft.AspNetCore.Components.MarkupString (string value) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NavigationException : System.Exception
    {
        public NavigationException(string uri) { }
        public string Location { get { throw null; } }
    }
    public abstract partial class NavigationManager
    {
        protected NavigationManager() { }
        public string BaseUri { get { throw null; } protected set { } }
        public string Uri { get { throw null; } protected set { } }
        public event System.EventHandler<Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs> LocationChanged { add { } remove { } }
        protected virtual void EnsureInitialized() { }
        protected void Initialize(string baseUri, string uri) { }
        public void NavigateTo(string uri, bool forceLoad = false) { }
        protected abstract void NavigateToCore(string uri, bool forceLoad);
        internal static string NormalizeBaseUri(string baseUri) { throw null; }
        protected void NotifyLocationChanged(bool isInterceptedLink) { }
        public System.Uri ToAbsoluteUri(string relativeUri) { throw null; }
        public string ToBaseRelativePath(string uri) { throw null; }
    }
    public abstract partial class OwningComponentBase : Microsoft.AspNetCore.Components.ComponentBase, System.IDisposable
    {
        protected OwningComponentBase() { }
        protected bool IsDisposed { get { throw null; } }
        protected System.IServiceProvider ScopedServices { get { throw null; } }
        protected virtual void Dispose(bool disposing) { }
        void System.IDisposable.Dispose() { }
    }
    public abstract partial class OwningComponentBase<TService> : Microsoft.AspNetCore.Components.OwningComponentBase, System.IDisposable
    {
        protected OwningComponentBase() { }
        protected TService Service { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class ParameterAttribute : System.Attribute
    {
        public ParameterAttribute() { }
        public bool CaptureUnmatchedValues { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ParameterValue
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        internal ParameterValue(string name, object value, bool cascading) { throw null; }
        public bool Cascading { get { throw null; } }
        public string Name { get { throw null; } }
        public object Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ParameterView
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        internal ParameterView(in Microsoft.AspNetCore.Components.Rendering.ParameterViewLifetime lifetime, Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame[] frames, int ownerIndex) { throw null; }
        public static Microsoft.AspNetCore.Components.ParameterView Empty { get { throw null; } }
        internal Microsoft.AspNetCore.Components.Rendering.ParameterViewLifetime Lifetime { get { throw null; } }
        internal void CaptureSnapshot(Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> builder) { }
        internal bool DefinitelyEquals(Microsoft.AspNetCore.Components.ParameterView oldParameters) { throw null; }
        public static Microsoft.AspNetCore.Components.ParameterView FromDictionary(System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
        public Microsoft.AspNetCore.Components.ParameterView.Enumerator GetEnumerator() { throw null; }
        public TValue GetValueOrDefault<TValue>(string parameterName) { throw null; }
        public TValue GetValueOrDefault<TValue>(string parameterName, TValue defaultValue) { throw null; }
        public void SetParameterProperties(object target) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> ToDictionary() { throw null; }
        public bool TryGetValue<TValue>(string parameterName, out TValue result) { throw null; }
        internal Microsoft.AspNetCore.Components.ParameterView WithCascadingParameters(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.CascadingParameterState> cascadingParameters) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame[] frames, int ownerIndex, System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.Components.CascadingParameterState> cascadingParameters) { throw null; }
            public Microsoft.AspNetCore.Components.ParameterValue Current { get { throw null; } }
            public bool MoveNext() { throw null; }
        }
    }
    internal static partial class PlatformInfo
    {
        public static bool IsWebAssembly { get { throw null; } }
    }
    public delegate void RenderFragment(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder);
    public delegate Microsoft.AspNetCore.Components.RenderFragment RenderFragment<TValue>(TValue value);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderHandle
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        internal RenderHandle(Microsoft.AspNetCore.Components.RenderTree.Renderer renderer, int componentId) { throw null; }
        public Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get { throw null; } }
        public bool IsInitialized { get { throw null; } }
        public void Render(Microsoft.AspNetCore.Components.RenderFragment renderFragment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=false)]
    public sealed partial class RouteAttribute : System.Attribute
    {
        public RouteAttribute(string template) { }
        public string Template { get { throw null; } }
    }
    public sealed partial class RouteData
    {
        public RouteData(System.Type pageType, System.Collections.Generic.IReadOnlyDictionary<string, object> routeValues) { }
        public System.Type PageType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> RouteValues { get { throw null; } }
    }
    internal static partial class RouteTableFactory
    {
        public static readonly System.Collections.Generic.IComparer<Microsoft.AspNetCore.Components.Routing.RouteEntry> RoutePrecedence;
        internal static Microsoft.AspNetCore.Components.Routing.RouteTable Create(System.Collections.Generic.Dictionary<System.Type, string[]> templatesByHandler) { throw null; }
        public static Microsoft.AspNetCore.Components.Routing.RouteTable Create(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { throw null; }
        internal static Microsoft.AspNetCore.Components.Routing.RouteTable Create(System.Collections.Generic.IEnumerable<System.Type> componentTypes) { throw null; }
        internal static int RouteComparison(Microsoft.AspNetCore.Components.Routing.RouteEntry x, Microsoft.AspNetCore.Components.Routing.RouteEntry y) { throw null; }
    }
    public partial class RouteView : Microsoft.AspNetCore.Components.IComponent
    {
        public RouteView() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public System.Type DefaultLayout { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RouteData RouteData { get { throw null; } set { } }
        public void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        protected virtual void Render(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder) { }
        public System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.CompilerServices
{
    public static partial class RuntimeHelpers
    {
        public static Microsoft.AspNetCore.Components.EventCallback<T> CreateInferredEventCallback<T>(object receiver, System.Action<T> callback, T value) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<T> CreateInferredEventCallback<T>(object receiver, System.Func<T, System.Threading.Tasks.Task> callback, T value) { throw null; }
        public static T TypeCheck<T>(T value) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.Reflection
{
    internal static partial class ComponentProperties
    {
        internal static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetCandidateBindableProperties(System.Type targetType) { throw null; }
        public static void SetProperties(in Microsoft.AspNetCore.Components.ParameterView parameters, object target) { }
    }
    internal partial interface IPropertySetter
    {
        bool Cascading { get; }
        void SetValue(object target, object value);
    }
    internal partial class MemberAssignment
    {
        public MemberAssignment() { }
        public static Microsoft.AspNetCore.Components.Reflection.IPropertySetter CreatePropertySetter(System.Type targetType, System.Reflection.PropertyInfo property, bool cascading) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetPropertiesIncludingInherited(System.Type type, System.Reflection.BindingFlags bindingFlags) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.Rendering
{
    internal partial class ComponentState : System.IDisposable
    {
        public ComponentState(Microsoft.AspNetCore.Components.RenderTree.Renderer renderer, int componentId, Microsoft.AspNetCore.Components.IComponent component, Microsoft.AspNetCore.Components.Rendering.ComponentState parentComponentState) { }
        public Microsoft.AspNetCore.Components.IComponent Component { get { throw null; } }
        public int ComponentId { get { throw null; } }
        public Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder CurrentRenderTree { get { throw null; } }
        public Microsoft.AspNetCore.Components.Rendering.ComponentState ParentComponentState { get { throw null; } }
        public void Dispose() { }
        public void NotifyCascadingValueChanged(in Microsoft.AspNetCore.Components.Rendering.ParameterViewLifetime lifetime) { }
        public System.Threading.Tasks.Task NotifyRenderCompletedAsync() { throw null; }
        public void RenderIntoBatch(Microsoft.AspNetCore.Components.Rendering.RenderBatchBuilder batchBuilder, Microsoft.AspNetCore.Components.RenderFragment renderFragment) { }
        public void SetDirectParameters(Microsoft.AspNetCore.Components.ParameterView parameters) { }
        public bool TryDisposeInBatch(Microsoft.AspNetCore.Components.Rendering.RenderBatchBuilder batchBuilder, out System.Exception exception) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct KeyedItemInfo
    {
        public readonly int NewIndex;
        public readonly int NewSiblingIndex;
        public readonly int OldIndex;
        public readonly int OldSiblingIndex;
        public KeyedItemInfo(int oldIndex, int newIndex) { throw null; }
        public Microsoft.AspNetCore.Components.Rendering.KeyedItemInfo WithNewSiblingIndex(int newSiblingIndex) { throw null; }
        public Microsoft.AspNetCore.Components.Rendering.KeyedItemInfo WithOldSiblingIndex(int oldSiblingIndex) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ParameterViewLifetime
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Microsoft.AspNetCore.Components.Rendering.ParameterViewLifetime Unbound;
        public ParameterViewLifetime(Microsoft.AspNetCore.Components.Rendering.RenderBatchBuilder owner) { throw null; }
        public void AssertNotExpired() { }
    }
    internal partial class RenderBatchBuilder : System.IDisposable
    {
        public RenderBatchBuilder() { }
        public System.Collections.Generic.Dictionary<string, int> AttributeDiffSet { get { throw null; } }
        public System.Collections.Generic.Queue<int> ComponentDisposalQueue { get { throw null; } }
        public System.Collections.Generic.Queue<Microsoft.AspNetCore.Components.Rendering.RenderQueueEntry> ComponentRenderQueue { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<int> DisposedComponentIds { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<ulong> DisposedEventHandlerIds { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit> EditsBuffer { get { throw null; } }
        internal Microsoft.AspNetCore.Components.RenderTree.StackObjectPool<System.Collections.Generic.Dictionary<object, Microsoft.AspNetCore.Components.Rendering.KeyedItemInfo>> KeyedItemInfoDictionaryPool { get { throw null; } }
        public int ParameterViewValidityStamp { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> ReferenceFramesBuffer { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiff> UpdatedComponentDiffs { get { throw null; } }
        public void ClearStateForCurrentBatch() { }
        public void Dispose() { }
        public void InvalidateParameterViews() { }
        public Microsoft.AspNetCore.Components.RenderTree.RenderBatch ToBatch() { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{_state,nq}")]
    internal partial class RendererSynchronizationContext : System.Threading.SynchronizationContext
    {
        public RendererSynchronizationContext() { }
        public event System.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        public override System.Threading.SynchronizationContext CreateCopy() { throw null; }
        public System.Threading.Tasks.Task InvokeAsync(System.Action action) { throw null; }
        public System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> asyncAction) { throw null; }
        public System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> asyncFunction) { throw null; }
        public System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<TResult> function) { throw null; }
        public override void Post(System.Threading.SendOrPostCallback d, object state) { }
        public override void Send(System.Threading.SendOrPostCallback d, object state) { }
    }
    internal partial class RendererSynchronizationContextDispatcher : Microsoft.AspNetCore.Components.Dispatcher
    {
        public RendererSynchronizationContextDispatcher() { }
        public override bool CheckAccess() { throw null; }
        public override System.Threading.Tasks.Task InvokeAsync(System.Action workItem) { throw null; }
        public override System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> workItem) { throw null; }
        public override System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> workItem) { throw null; }
        public override System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<TResult> workItem) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct RenderQueueEntry
    {
        public readonly Microsoft.AspNetCore.Components.Rendering.ComponentState ComponentState;
        public readonly Microsoft.AspNetCore.Components.RenderFragment RenderFragment;
        public RenderQueueEntry(Microsoft.AspNetCore.Components.Rendering.ComponentState componentState, Microsoft.AspNetCore.Components.RenderFragment renderFragment) { throw null; }
    }
    public sealed partial class RenderTreeBuilder : System.IDisposable
    {
        public RenderTreeBuilder() { }
        public void AddAttribute(int sequence, in Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame frame) { }
        public void AddAttribute(int sequence, string name, Microsoft.AspNetCore.Components.EventCallback value) { }
        public void AddAttribute(int sequence, string name, bool value) { }
        public void AddAttribute(int sequence, string name, System.MulticastDelegate value) { }
        public void AddAttribute(int sequence, string name, object value) { }
        public void AddAttribute(int sequence, string name, string value) { }
        public void AddAttribute<TArgument>(int sequence, string name, Microsoft.AspNetCore.Components.EventCallback<TArgument> value) { }
        public void AddComponentReferenceCapture(int sequence, System.Action<object> componentReferenceCaptureAction) { }
        public void AddContent(int sequence, Microsoft.AspNetCore.Components.MarkupString markupContent) { }
        public void AddContent(int sequence, Microsoft.AspNetCore.Components.RenderFragment fragment) { }
        public void AddContent(int sequence, object textContent) { }
        public void AddContent(int sequence, string textContent) { }
        public void AddContent<TValue>(int sequence, Microsoft.AspNetCore.Components.RenderFragment<TValue> fragment, TValue value) { }
        public void AddElementReferenceCapture(int sequence, System.Action<Microsoft.AspNetCore.Components.ElementReference> elementReferenceCaptureAction) { }
        public void AddMarkupContent(int sequence, string markupContent) { }
        public void AddMultipleAttributes(int sequence, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> attributes) { }
        public void Clear() { }
        public void CloseComponent() { }
        public void CloseElement() { }
        public void CloseRegion() { }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> GetFrames() { throw null; }
        internal void InsertAttributeExpensive(int insertAtIndex, int sequence, string attributeName, object attributeValue) { }
        public void OpenComponent(int sequence, System.Type componentType) { }
        public void OpenComponent<TComponent>(int sequence) where TComponent : Microsoft.AspNetCore.Components.IComponent { }
        public void OpenElement(int sequence, string elementName) { }
        public void OpenRegion(int sequence) { }
        internal void ProcessDuplicateAttributes(int first) { }
        public void SetKey(object value) { }
        public void SetUpdatesAttributeName(string updatesAttributeName) { }
        void System.IDisposable.Dispose() { }
        internal void TrackAttributeName(string name) { }
    }
    internal partial class RenderTreeUpdater
    {
        public RenderTreeUpdater() { }
        public static void UpdateToMatchClientState(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder renderTreeBuilder, ulong eventHandlerId, object newFieldValue) { }
    }
}
namespace Microsoft.AspNetCore.Components.RenderTree
{
    internal static partial class ArrayBuilderExtensions
    {
        public static Microsoft.AspNetCore.Components.RenderTree.ArrayRange<T> ToRange<T>(this Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<T> builder) { throw null; }
        public static Microsoft.AspNetCore.Components.RenderTree.ArrayBuilderSegment<T> ToSegment<T>(this Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<T> builder, int fromIndexInclusive, int toIndexExclusive) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArrayBuilderSegment<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        internal ArrayBuilderSegment(Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder<T> builder, int offset, int count) { throw null; }
        public T[] Array { get { throw null; } }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public int Offset { get { throw null; } }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
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
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArrayRange<T>
    {
        public readonly T[] Array;
        public readonly int Count;
        public ArrayRange(T[] array, int count) { throw null; }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<T> Clone() { throw null; }
    }
    public partial class EventFieldInfo
    {
        public EventFieldInfo() { }
        public int ComponentId { get { throw null; } set { } }
        public object FieldValue { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderBatch
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        internal RenderBatch(Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiff> updatedComponents, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> referenceFrames, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<int> disposedComponentIDs, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<ulong> disposedEventHandlerIDs) { throw null; }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<int> DisposedComponentIDs { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<ulong> DisposedEventHandlerIDs { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> ReferenceFrames { get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiff> UpdatedComponents { get { throw null; } }
    }
    public abstract partial class Renderer : System.IDisposable
    {
        public Renderer(System.IServiceProvider serviceProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public abstract Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get; }
        public event System.UnhandledExceptionEventHandler UnhandledSynchronizationException { add { } remove { } }
        internal void AddToPendingTasks(System.Threading.Tasks.Task task) { }
        internal void AddToRenderQueue(int componentId, Microsoft.AspNetCore.Components.RenderFragment renderFragment) { }
        internal void AssignEventHandlerId(ref Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame frame) { }
        protected internal int AssignRootComponentId(Microsoft.AspNetCore.Components.IComponent component) { throw null; }
        public virtual System.Threading.Tasks.Task DispatchEventAsync(ulong eventHandlerId, Microsoft.AspNetCore.Components.RenderTree.EventFieldInfo fieldInfo, System.EventArgs eventArgs) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> GetCurrentRenderTreeFrames(int componentId) { throw null; }
        protected abstract void HandleException(System.Exception exception);
        internal void InstantiateChildComponentOnFrame(ref Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame frame, int parentComponentId) { }
        protected Microsoft.AspNetCore.Components.IComponent InstantiateComponent(System.Type componentType) { throw null; }
        protected virtual void ProcessPendingRender() { }
        protected System.Threading.Tasks.Task RenderRootComponentAsync(int componentId) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected System.Threading.Tasks.Task RenderRootComponentAsync(int componentId, Microsoft.AspNetCore.Components.ParameterView initialParameters) { throw null; }
        internal void TrackReplacedEventHandlerId(ulong oldEventHandlerId, ulong newEventHandlerId) { }
        protected abstract System.Threading.Tasks.Task UpdateDisplayAsync(in Microsoft.AspNetCore.Components.RenderTree.RenderBatch renderBatch);
        internal static partial class Log
        {
            public static void DisposingComponent(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.RenderTree.Renderer> logger, Microsoft.AspNetCore.Components.Rendering.ComponentState componentState) { }
            public static void HandlingEvent(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Components.RenderTree.Renderer> logger, ulong eventHandlerId, System.EventArgs eventArgs) { }
            public static void InitializingComponent(Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Components.Rendering.ComponentState componentState, Microsoft.AspNetCore.Components.Rendering.ComponentState parentComponentState) { }
            public static void RenderingComponent(Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Components.Rendering.ComponentState componentState) { }
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderTreeDiff
    {
        public readonly int ComponentId;
        public readonly Microsoft.AspNetCore.Components.RenderTree.ArrayBuilderSegment<Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit> Edits;
        internal RenderTreeDiff(int componentId, Microsoft.AspNetCore.Components.RenderTree.ArrayBuilderSegment<Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit> entries) { throw null; }
    }
    internal static partial class RenderTreeDiffBuilder
    {
        public const int SystemAddedAttributeSequenceNumber = -2147483648;
        public static Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiff ComputeDiff(Microsoft.AspNetCore.Components.RenderTree.Renderer renderer, Microsoft.AspNetCore.Components.Rendering.RenderBatchBuilder batchBuilder, int componentId, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> oldTree, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> newTree) { throw null; }
        public static void DisposeFrames(Microsoft.AspNetCore.Components.Rendering.RenderBatchBuilder batchBuilder, Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> frames) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly partial struct RenderTreeEdit
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int MoveToSiblingIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int ReferenceFrameIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string RemovedAttributeName;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public readonly int SiblingIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType Type;
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit PermutationListEnd() { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit PermutationListEntry(int fromSiblingIndex, int toSiblingIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit PrependFrame(int siblingIndex, int referenceFrameIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit RemoveAttribute(int siblingIndex, string name) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit RemoveFrame(int siblingIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit SetAttribute(int siblingIndex, int referenceFrameIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit StepIn(int siblingIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit StepOut() { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit UpdateMarkup(int siblingIndex, int referenceFrameIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit UpdateText(int siblingIndex, int referenceFrameIndex) { throw null; }
    }
    public enum RenderTreeEditType
    {
        PrependFrame = 1,
        RemoveFrame = 2,
        SetAttribute = 3,
        RemoveAttribute = 4,
        UpdateText = 5,
        StepIn = 6,
        StepOut = 7,
        UpdateMarkup = 8,
        PermutationListEntry = 9,
        PermutationListEnd = 10,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Pack=4)]
    public readonly partial struct RenderTreeFrame
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly ulong AttributeEventHandlerId;
        [System.Runtime.InteropServices.FieldOffsetAttribute(32)]
        public readonly string AttributeEventUpdatesAttributeName;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string AttributeName;
        [System.Runtime.InteropServices.FieldOffsetAttribute(24)]
        public readonly object AttributeValue;
        [System.Runtime.InteropServices.FieldOffsetAttribute(12)]
        public readonly int ComponentId;
        [System.Runtime.InteropServices.FieldOffsetAttribute(32)]
        public readonly object ComponentKey;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly System.Action<object> ComponentReferenceCaptureAction;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int ComponentReferenceCaptureParentFrameIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(24)]
        internal readonly Microsoft.AspNetCore.Components.Rendering.ComponentState ComponentState;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int ComponentSubtreeLength;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly System.Type ComponentType;
        [System.Runtime.InteropServices.FieldOffsetAttribute(24)]
        public readonly object ElementKey;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string ElementName;
        [System.Runtime.InteropServices.FieldOffsetAttribute(24)]
        public readonly System.Action<Microsoft.AspNetCore.Components.ElementReference> ElementReferenceCaptureAction;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string ElementReferenceCaptureId;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int ElementSubtreeLength;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public readonly Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType FrameType;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string MarkupContent;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int RegionSubtreeLength;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly int Sequence;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string TextContent;
        public Microsoft.AspNetCore.Components.IComponent Component { get { throw null; } }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame Attribute(int sequence, string name, object value) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame ChildComponent(int sequence, System.Type componentType) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame ComponentReferenceCapture(int sequence, System.Action<object> componentReferenceCaptureAction, int parentFrameIndex) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame Element(int sequence, string elementName) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame ElementReferenceCapture(int sequence, System.Action<Microsoft.AspNetCore.Components.ElementReference> elementReferenceCaptureAction) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame Markup(int sequence, string markupContent) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame PlaceholderChildComponentWithSubtreeLength(int subtreeLength) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame Region(int sequence) { throw null; }
        internal static Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame Text(int sequence, string textContent) { throw null; }
        public override string ToString() { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithAttributeEventHandlerId(ulong eventHandlerId) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithAttributeEventUpdatesAttributeName(string attributeUpdatesAttributeName) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithAttributeSequence(int sequence) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithAttributeValue(object attributeValue) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithComponent(Microsoft.AspNetCore.Components.Rendering.ComponentState componentState) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithComponentKey(object componentKey) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithComponentSubtreeLength(int componentSubtreeLength) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithElementKey(object elementKey) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithElementReferenceCaptureId(string elementReferenceCaptureId) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithElementSubtreeLength(int elementSubtreeLength) { throw null; }
        internal Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame WithRegionSubtreeLength(int regionSubtreeLength) { throw null; }
    }
    public enum RenderTreeFrameType : short
    {
        None = (short)0,
        Element = (short)1,
        Text = (short)2,
        Attribute = (short)3,
        Component = (short)4,
        Region = (short)5,
        ElementReferenceCapture = (short)6,
        ComponentReferenceCapture = (short)7,
        Markup = (short)8,
    }
    internal partial class StackObjectPool<T> where T : class
    {
        public StackObjectPool(int maxPreservedItems, System.Func<T> instanceFactory) { }
        public T Get() { throw null; }
        public void Return(T instance) { }
    }
}
namespace Microsoft.AspNetCore.Components.Routing
{
    public partial interface IHostEnvironmentNavigationManager
    {
        void Initialize(string baseUri, string uri);
    }
    public partial interface INavigationInterception
    {
        System.Threading.Tasks.Task EnableNavigationInterceptionAsync();
    }
    public partial class LocationChangedEventArgs : System.EventArgs
    {
        public LocationChangedEventArgs(string location, bool isNavigationIntercepted) { }
        public bool IsNavigationIntercepted { get { throw null; } }
        public string Location { get { throw null; } }
    }
    internal abstract partial class RouteConstraint
    {
        protected RouteConstraint() { }
        public abstract bool Match(string pathSegment, out object convertedValue);
        public static Microsoft.AspNetCore.Components.Routing.RouteConstraint Parse(string template, string segment, string constraint) { throw null; }
    }
    internal partial class RouteContext
    {
        public RouteContext(string path) { }
        public System.Type Handler { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Parameters { get { throw null; } set { } }
        public string[] Segments { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Handler = {Handler}, Template = {Template}")]
    internal partial class RouteEntry
    {
        public RouteEntry(Microsoft.AspNetCore.Components.Routing.RouteTemplate template, System.Type handler, string[] unusedRouteParameterNames) { }
        public System.Type Handler { get { throw null; } }
        public Microsoft.AspNetCore.Components.Routing.RouteTemplate Template { get { throw null; } }
        public string[] UnusedRouteParameterNames { get { throw null; } }
        internal void Match(Microsoft.AspNetCore.Components.Routing.RouteContext context) { }
    }
    public partial class Router : Microsoft.AspNetCore.Components.IComponent, Microsoft.AspNetCore.Components.IHandleAfterRender, System.IDisposable
    {
        public Router() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public System.Collections.Generic.IEnumerable<System.Reflection.Assembly> AdditionalAssemblies { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public System.Reflection.Assembly AppAssembly { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData> Found { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment NotFound { get { throw null; } set { } }
        public void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        public void Dispose() { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Components.IHandleAfterRender.OnAfterRenderAsync() { throw null; }
        public System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView parameters) { throw null; }
    }
    internal partial class RouteTable
    {
        public RouteTable(Microsoft.AspNetCore.Components.Routing.RouteEntry[] routes) { }
        public Microsoft.AspNetCore.Components.Routing.RouteEntry[] Routes { get { throw null; } }
        internal void Route(Microsoft.AspNetCore.Components.Routing.RouteContext routeContext) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{TemplateText}")]
    internal partial class RouteTemplate
    {
        public RouteTemplate(string templateText, Microsoft.AspNetCore.Components.Routing.TemplateSegment[] segments) { }
        public Microsoft.AspNetCore.Components.Routing.TemplateSegment[] Segments { get { throw null; } }
        public string TemplateText { get { throw null; } }
    }
    internal partial class TemplateParser
    {
        public static readonly char[] InvalidParameterNameCharacters;
        public TemplateParser() { }
        internal static Microsoft.AspNetCore.Components.Routing.RouteTemplate ParseTemplate(string template) { throw null; }
    }
    internal partial class TemplateSegment
    {
        public TemplateSegment(string template, string segment, bool isParameter) { }
        public Microsoft.AspNetCore.Components.Routing.RouteConstraint[] Constraints { get { throw null; } }
        public bool IsParameter { get { throw null; } }
        public string Value { get { throw null; } }
        public bool Match(string pathSegment, out object matchedParameterValue) { throw null; }
    }
    internal partial class TypeRouteConstraint<T> : Microsoft.AspNetCore.Components.Routing.RouteConstraint
    {
        public TypeRouteConstraint(Microsoft.AspNetCore.Components.Routing.TypeRouteConstraint<T>.TryParseDelegate parser) { }
        public override bool Match(string pathSegment, out object convertedValue) { throw null; }
        public delegate bool TryParseDelegate(string str, out T result);
    }
}
namespace Microsoft.Extensions.Internal
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal partial struct HashCodeCombiner
    {
        private int _dummyPrimitive;
        public int CombinedHash { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(System.Collections.IEnumerable e) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(int i) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(object o) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add(string s) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public void Add<TValue>(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static implicit operator int (Microsoft.Extensions.Internal.HashCodeCombiner self) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static Microsoft.Extensions.Internal.HashCodeCombiner Start() { throw null; }
    }
}
