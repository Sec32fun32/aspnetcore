// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Internal
{
    internal static partial class TaskCache
    {
        public static readonly System.Threading.Tasks.Task<bool> False;
        public static readonly System.Threading.Tasks.Task<bool> True;
    }
}
namespace Microsoft.AspNetCore.SignalR
{
    public static partial class ClientProxyExtensions
    {
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, object arg5, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, object arg4, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, object arg3, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, object arg2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, object arg1, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task SendAsync(this Microsoft.AspNetCore.SignalR.IClientProxy clientProxy, string method, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DefaultHubLifetimeManager<THub> : Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public DefaultHubLifetimeManager(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.SignalR.DefaultHubLifetimeManager<THub>> logger) { }
        public override System.Threading.Tasks.Task AddToGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task OnConnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { throw null; }
        public override System.Threading.Tasks.Task OnDisconnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { throw null; }
        public override System.Threading.Tasks.Task RemoveFromGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendAllAsync(string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendAllExceptAsync(string methodName, object[] args, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendConnectionAsync(string connectionId, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendConnectionsAsync(System.Collections.Generic.IReadOnlyList<string> connectionIds, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendGroupAsync(string groupName, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendGroupExceptAsync(string groupName, string methodName, object[] args, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendGroupsAsync(System.Collections.Generic.IReadOnlyList<string> groupNames, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendUserAsync(string userId, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task SendUsersAsync(System.Collections.Generic.IReadOnlyList<string> userIds, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DefaultUserIdProvider : Microsoft.AspNetCore.SignalR.IUserIdProvider
    {
        public DefaultUserIdProvider() { }
        public virtual string GetUserId(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { throw null; }
    }
    public abstract partial class DynamicHub : Microsoft.AspNetCore.SignalR.Hub
    {
        protected DynamicHub() { }
        public new Microsoft.AspNetCore.SignalR.DynamicHubClients Clients { get { throw null; } set { } }
    }
    public partial class DynamicHubClients
    {
        public DynamicHubClients(Microsoft.AspNetCore.SignalR.IHubCallerClients clients) { }
        public dynamic All { get { throw null; } }
        public dynamic Caller { get { throw null; } }
        public dynamic Others { get { throw null; } }
        public dynamic AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public dynamic Client(string connectionId) { throw null; }
        public dynamic Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds) { throw null; }
        public dynamic Group(string groupName) { throw null; }
        public dynamic GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public dynamic Groups(System.Collections.Generic.IReadOnlyList<string> groupNames) { throw null; }
        public dynamic OthersInGroup(string groupName) { throw null; }
        public dynamic User(string userId) { throw null; }
        public dynamic Users(System.Collections.Generic.IReadOnlyList<string> userIds) { throw null; }
    }
    public abstract partial class Hub : System.IDisposable
    {
        protected Hub() { }
        public Microsoft.AspNetCore.SignalR.IHubCallerClients Clients { get { throw null; } set { } }
        public Microsoft.AspNetCore.SignalR.HubCallerContext Context { get { throw null; } set { } }
        public Microsoft.AspNetCore.SignalR.IGroupManager Groups { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Threading.Tasks.Task OnConnectedAsync() { throw null; }
        public virtual System.Threading.Tasks.Task OnDisconnectedAsync(System.Exception exception) { throw null; }
    }
    public abstract partial class HubCallerContext
    {
        protected HubCallerContext() { }
        public abstract System.Threading.CancellationToken ConnectionAborted { get; }
        public abstract string ConnectionId { get; }
        public abstract Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get; }
        public abstract System.Collections.Generic.IDictionary<object, object> Items { get; }
        public abstract System.Security.Claims.ClaimsPrincipal User { get; }
        public abstract string UserIdentifier { get; }
        public abstract void Abort();
    }
    public static partial class HubClientsExtensions
    {
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6, string excludedConnectionId7) { throw null; }
        public static T AllExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6, string excludedConnectionId7, string excludedConnectionId8) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3, string connection4) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3, string connection4, string connection5) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3, string connection4, string connection5, string connection6) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3, string connection4, string connection5, string connection6, string connection7) { throw null; }
        public static T Clients<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string connection1, string connection2, string connection3, string connection4, string connection5, string connection6, string connection7, string connection8) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6, string excludedConnectionId7) { throw null; }
        public static T GroupExcept<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string groupName, string excludedConnectionId1, string excludedConnectionId2, string excludedConnectionId3, string excludedConnectionId4, string excludedConnectionId5, string excludedConnectionId6, string excludedConnectionId7, string excludedConnectionId8) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3, string group4) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3, string group4, string group5) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3, string group4, string group5, string group6) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3, string group4, string group5, string group6, string group7) { throw null; }
        public static T Groups<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string group1, string group2, string group3, string group4, string group5, string group6, string group7, string group8) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3, string user4) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3, string user4, string user5) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3, string user4, string user5, string user6) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3, string user4, string user5, string user6, string user7) { throw null; }
        public static T Users<T>(this Microsoft.AspNetCore.SignalR.IHubClients<T> hubClients, string user1, string user2, string user3, string user4, string user5, string user6, string user7, string user8) { throw null; }
    }
    public partial class HubConnectionContext
    {
        public HubConnectionContext(Microsoft.AspNetCore.Connections.ConnectionContext connectionContext, Microsoft.AspNetCore.SignalR.HubConnectionContextOptions contextOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal System.Collections.Concurrent.ConcurrentDictionary<string, System.Threading.CancellationTokenSource> ActiveRequestCancellationSources { get { throw null; } }
        internal bool AllowReconnect { get { throw null; } }
        public virtual System.Threading.CancellationToken ConnectionAborted { get { throw null; } }
        public virtual string ConnectionId { get { throw null; } }
        public virtual Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        internal Microsoft.AspNetCore.SignalR.HubCallerContext HubCallerContext { get { throw null; } }
        internal System.IO.Pipelines.PipeReader Input { get { throw null; } }
        public virtual System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } }
        public virtual Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol Protocol { get { throw null; } set { } }
        internal Microsoft.AspNetCore.SignalR.StreamTracker StreamTracker { get { throw null; } }
        public virtual System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
        public string UserIdentifier { get { throw null; } set { } }
        public virtual void Abort() { }
        internal System.Threading.Tasks.Task AbortAsync() { throw null; }
        internal void BeginClientTimeout() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        internal System.Threading.Tasks.Task<bool> HandshakeAsync(System.TimeSpan timeout, System.Collections.Generic.IReadOnlyList<string> supportedProtocols, Microsoft.AspNetCore.SignalR.IHubProtocolResolver protocolResolver, Microsoft.AspNetCore.SignalR.IUserIdProvider userIdProvider, bool enableDetailedErrors) { throw null; }
        internal void ResetClientTimeout() { }
        internal void StartClientTimeout() { }
        internal void StopClientTimeout() { }
        public virtual System.Threading.Tasks.ValueTask WriteAsync(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.ValueTask WriteAsync(Microsoft.AspNetCore.SignalR.SerializedHubMessage message, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HubConnectionContextOptions
    {
        public HubConnectionContextOptions() { }
        public System.TimeSpan ClientTimeoutInterval { get { throw null; } set { } }
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        public long? MaximumReceiveMessageSize { get { throw null; } set { } }
        public int StreamBufferCapacity { get { throw null; } set { } }
    }
    public partial class HubConnectionHandler<THub> : Microsoft.AspNetCore.Connections.ConnectionHandler where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubConnectionHandler(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, Microsoft.AspNetCore.SignalR.IHubProtocolResolver protocolResolver, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.SignalR.HubOptions> globalHubOptions, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.SignalR.HubOptions<THub>> hubOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.SignalR.IUserIdProvider userIdProvider, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory serviceScopeFactory) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task OnConnectedAsync(Microsoft.AspNetCore.Connections.ConnectionContext connection) { throw null; }
    }
    public partial class HubConnectionStore
    {
        public HubConnectionStore() { }
        public int Count { get { throw null; } }
        public Microsoft.AspNetCore.SignalR.HubConnectionContext this[string connectionId] { get { throw null; } }
        public void Add(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { }
        public Microsoft.AspNetCore.SignalR.HubConnectionStore.Enumerator GetEnumerator() { throw null; }
        public void Remove(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct Enumerator : System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.SignalR.HubConnectionContext>, System.Collections.IEnumerator, System.IDisposable
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public Enumerator(Microsoft.AspNetCore.SignalR.HubConnectionStore hubConnectionList) { throw null; }
            public Microsoft.AspNetCore.SignalR.HubConnectionContext Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public partial class HubInvocationContext
    {
        public HubInvocationContext(Microsoft.AspNetCore.SignalR.HubCallerContext context, string hubMethodName, object[] hubMethodArguments) { }
        public Microsoft.AspNetCore.SignalR.HubCallerContext Context { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<object> HubMethodArguments { get { throw null; } }
        public string HubMethodName { get { throw null; } }
    }
    public abstract partial class HubLifetimeManager<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        protected HubLifetimeManager() { }
        public abstract System.Threading.Tasks.Task AddToGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task OnConnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection);
        public abstract System.Threading.Tasks.Task OnDisconnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection);
        public abstract System.Threading.Tasks.Task RemoveFromGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendAllAsync(string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendAllExceptAsync(string methodName, object[] args, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendConnectionAsync(string connectionId, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendConnectionsAsync(System.Collections.Generic.IReadOnlyList<string> connectionIds, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendGroupAsync(string groupName, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendGroupExceptAsync(string groupName, string methodName, object[] args, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendGroupsAsync(System.Collections.Generic.IReadOnlyList<string> groupNames, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendUserAsync(string userId, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Threading.Tasks.Task SendUsersAsync(System.Collections.Generic.IReadOnlyList<string> userIds, string methodName, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial class HubMetadata
    {
        public HubMetadata(System.Type hubType) { }
        public System.Type HubType { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public partial class HubMethodNameAttribute : System.Attribute
    {
        public HubMethodNameAttribute(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class HubOptions
    {
        public HubOptions() { }
        public System.TimeSpan? ClientTimeoutInterval { get { throw null; } set { } }
        public bool? EnableDetailedErrors { get { throw null; } set { } }
        public System.TimeSpan? HandshakeTimeout { get { throw null; } set { } }
        public System.TimeSpan? KeepAliveInterval { get { throw null; } set { } }
        public long? MaximumReceiveMessageSize { get { throw null; } set { } }
        public int? StreamBufferCapacity { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> SupportedProtocols { get { throw null; } set { } }
    }
    public partial class HubOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.SignalR.HubOptions>
    {
        internal const int DefaultMaximumMessageSize = 32768;
        internal const int DefaultStreamBufferCapacity = 10;
        public HubOptionsSetup(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol> protocols) { }
        internal static System.TimeSpan DefaultClientTimeoutInterval { get { throw null; } }
        internal static System.TimeSpan DefaultHandshakeTimeout { get { throw null; } }
        internal static System.TimeSpan DefaultKeepAliveInterval { get { throw null; } }
        public void Configure(Microsoft.AspNetCore.SignalR.HubOptions options) { }
    }
    public partial class HubOptionsSetup<THub> : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.SignalR.HubOptions<THub>> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubOptionsSetup(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.SignalR.HubOptions> options) { }
        public void Configure(Microsoft.AspNetCore.SignalR.HubOptions<THub> options) { }
    }
    public partial class HubOptions<THub> : Microsoft.AspNetCore.SignalR.HubOptions where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubOptions() { }
        internal bool UserHasSetValues { get { throw null; } set { } }
    }
    public abstract partial class Hub<T> : Microsoft.AspNetCore.SignalR.Hub where T : class
    {
        protected Hub() { }
        public new Microsoft.AspNetCore.SignalR.IHubCallerClients<T> Clients { get { throw null; } set { } }
    }
    public partial interface IClientProxy
    {
        System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial interface IGroupManager
    {
        System.Threading.Tasks.Task AddToGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        System.Threading.Tasks.Task RemoveFromGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial interface IHubActivator<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        THub Create();
        void Release(THub hub);
    }
    public partial interface IHubCallerClients : Microsoft.AspNetCore.SignalR.IHubCallerClients<Microsoft.AspNetCore.SignalR.IClientProxy>, Microsoft.AspNetCore.SignalR.IHubClients<Microsoft.AspNetCore.SignalR.IClientProxy>
    {
    }
    public partial interface IHubCallerClients<T> : Microsoft.AspNetCore.SignalR.IHubClients<T>
    {
        T Caller { get; }
        T Others { get; }
        T OthersInGroup(string groupName);
    }
    public partial interface IHubClients : Microsoft.AspNetCore.SignalR.IHubClients<Microsoft.AspNetCore.SignalR.IClientProxy>
    {
    }
    public partial interface IHubClients<T>
    {
        T All { get; }
        T AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds);
        T Client(string connectionId);
        T Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds);
        T Group(string groupName);
        T GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds);
        T Groups(System.Collections.Generic.IReadOnlyList<string> groupNames);
        T User(string userId);
        T Users(System.Collections.Generic.IReadOnlyList<string> userIds);
    }
    public partial interface IHubContext<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        Microsoft.AspNetCore.SignalR.IHubClients Clients { get; }
        Microsoft.AspNetCore.SignalR.IGroupManager Groups { get; }
    }
    public partial interface IHubContext<THub, T> where THub : Microsoft.AspNetCore.SignalR.Hub<T> where T : class
    {
        Microsoft.AspNetCore.SignalR.IHubClients<T> Clients { get; }
        Microsoft.AspNetCore.SignalR.IGroupManager Groups { get; }
    }
    public partial interface IHubProtocolResolver
    {
        System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol> AllProtocols { get; }
        Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol GetProtocol(string protocolName, System.Collections.Generic.IReadOnlyList<string> supportedProtocols);
    }
    public partial interface ISignalRServerBuilder : Microsoft.AspNetCore.SignalR.ISignalRBuilder
    {
    }
    public partial interface IUserIdProvider
    {
        string GetUserId(Microsoft.AspNetCore.SignalR.HubConnectionContext connection);
    }
    internal static partial class ReflectionHelper
    {
        public static bool IsIAsyncEnumerable(System.Type type) { throw null; }
        public static bool IsStreamingType(System.Type type, bool mustBeDirectType = false) { throw null; }
    }
    public partial class SerializedHubMessage
    {
        public SerializedHubMessage(Microsoft.AspNetCore.SignalR.Protocol.HubMessage message) { }
        public SerializedHubMessage(System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.SignalR.SerializedMessage> messages) { }
        public Microsoft.AspNetCore.SignalR.Protocol.HubMessage Message { get { throw null; } }
        internal System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.SignalR.SerializedMessage> GetAllSerializations() { throw null; }
        public System.ReadOnlyMemory<byte> GetSerializedMessage(Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol protocol) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SerializedMessage
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SerializedMessage(string protocolName, System.ReadOnlyMemory<byte> serialized) { throw null; }
        public string ProtocolName { get { throw null; } }
        public System.ReadOnlyMemory<byte> Serialized { get { throw null; } }
    }
    public static partial class SignalRConnectionBuilderExtensions
    {
        public static Microsoft.AspNetCore.Connections.IConnectionBuilder UseHub<THub>(this Microsoft.AspNetCore.Connections.IConnectionBuilder connectionBuilder) where THub : Microsoft.AspNetCore.SignalR.Hub { throw null; }
    }
    internal partial class StreamTracker
    {
        public StreamTracker(int streamBufferCapacity) { }
        public object AddStream(string streamId, System.Type itemType, System.Type targetType) { throw null; }
        public void CompleteAll(System.Exception ex) { }
        public System.Type GetStreamItemType(string streamId) { throw null; }
        public bool TryComplete(Microsoft.AspNetCore.SignalR.Protocol.CompletionMessage message) { throw null; }
        public bool TryProcessItem(Microsoft.AspNetCore.SignalR.Protocol.StreamItemMessage message, out System.Threading.Tasks.Task task) { throw null; }
    }
}
namespace Microsoft.AspNetCore.SignalR.Internal
{
    internal partial class AllClientProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public AllClientProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class AllClientsExceptProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public AllClientsExceptProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal static partial class AsyncDisposableExtensions
    {
        public static System.Threading.Tasks.ValueTask DisposeAsync(this System.IDisposable disposable) { throw null; }
    }
    internal static partial class AsyncEnumerableAdapters
    {
        public static System.Collections.Generic.IAsyncEnumerable<object> MakeCancelableAsyncEnumerable<T>(System.Collections.Generic.IAsyncEnumerable<T> asyncEnumerable, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Collections.Generic.IAsyncEnumerable<T> MakeCancelableTypedAsyncEnumerable<T>(System.Collections.Generic.IAsyncEnumerable<T> asyncEnumerable, System.Threading.CancellationTokenSource cts) { throw null; }
    }
    internal partial class DefaultHubActivator<THub> : Microsoft.AspNetCore.SignalR.IHubActivator<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public DefaultHubActivator(System.IServiceProvider serviceProvider) { }
        public virtual THub Create() { throw null; }
        public virtual void Release(THub hub) { }
    }
    internal partial class DefaultHubCallerContext : Microsoft.AspNetCore.SignalR.HubCallerContext
    {
        public DefaultHubCallerContext(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { }
        public override System.Threading.CancellationToken ConnectionAborted { get { throw null; } }
        public override string ConnectionId { get { throw null; } }
        public override Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get { throw null; } }
        public override System.Collections.Generic.IDictionary<object, object> Items { get { throw null; } }
        public override System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
        public override string UserIdentifier { get { throw null; } }
        public override void Abort() { }
    }
    internal partial class DefaultHubDispatcher<THub> : Microsoft.AspNetCore.SignalR.Internal.HubDispatcher<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public DefaultHubDispatcher(Microsoft.Extensions.DependencyInjection.IServiceScopeFactory serviceScopeFactory, Microsoft.AspNetCore.SignalR.IHubContext<THub> hubContext, bool enableDetailedErrors, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.SignalR.Internal.DefaultHubDispatcher<THub>> logger) { }
        public override System.Threading.Tasks.Task DispatchMessageAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection, Microsoft.AspNetCore.SignalR.Protocol.HubMessage hubMessage) { throw null; }
        public override System.Collections.Generic.IReadOnlyList<System.Type> GetParameterTypes(string methodName) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task OnConnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task OnDisconnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection, System.Exception exception) { throw null; }
    }
    internal partial class DefaultHubProtocolResolver : Microsoft.AspNetCore.SignalR.IHubProtocolResolver
    {
        public DefaultHubProtocolResolver(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol> availableProtocols, Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.SignalR.Internal.DefaultHubProtocolResolver> logger) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol> AllProtocols { get { throw null; } }
        public virtual Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol GetProtocol(string protocolName, System.Collections.Generic.IReadOnlyList<string> supportedProtocols) { throw null; }
    }
    internal partial class DynamicClientProxy : System.Dynamic.DynamicObject
    {
        public DynamicClientProxy(Microsoft.AspNetCore.SignalR.IClientProxy clientProxy) { }
        public override bool TryInvokeMember(System.Dynamic.InvokeMemberBinder binder, object[] args, out object result) { throw null; }
    }
    internal static partial class ErrorMessageHelper
    {
        internal static string BuildErrorMessage(string message, System.Exception exception, bool includeExceptionDetails) { throw null; }
    }
    internal partial class GroupConnectionList : System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.AspNetCore.SignalR.HubConnectionContext>
    {
        public GroupConnectionList() { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    internal partial class GroupExceptProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public GroupExceptProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class GroupManager<THub> : Microsoft.AspNetCore.SignalR.IGroupManager where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public GroupManager(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public System.Threading.Tasks.Task AddToGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.Task RemoveFromGroupAsync(string connectionId, string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class GroupProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public GroupProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, string groupName) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class HubCallerClients : Microsoft.AspNetCore.SignalR.IHubCallerClients, Microsoft.AspNetCore.SignalR.IHubCallerClients<Microsoft.AspNetCore.SignalR.IClientProxy>, Microsoft.AspNetCore.SignalR.IHubClients<Microsoft.AspNetCore.SignalR.IClientProxy>
    {
        public HubCallerClients(Microsoft.AspNetCore.SignalR.IHubClients hubClients, string connectionId) { }
        public Microsoft.AspNetCore.SignalR.IClientProxy All { get { throw null; } }
        public Microsoft.AspNetCore.SignalR.IClientProxy Caller { get { throw null; } }
        public Microsoft.AspNetCore.SignalR.IClientProxy Others { get { throw null; } }
        public Microsoft.AspNetCore.SignalR.IClientProxy AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Client(string connectionId) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Group(string groupName) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Groups(System.Collections.Generic.IReadOnlyList<string> groupNames) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy OthersInGroup(string groupName) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy User(string userId) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Users(System.Collections.Generic.IReadOnlyList<string> userIds) { throw null; }
    }
    internal partial class HubClients<THub> : Microsoft.AspNetCore.SignalR.IHubClients, Microsoft.AspNetCore.SignalR.IHubClients<Microsoft.AspNetCore.SignalR.IClientProxy> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubClients(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public Microsoft.AspNetCore.SignalR.IClientProxy All { get { throw null; } }
        public Microsoft.AspNetCore.SignalR.IClientProxy AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Client(string connectionId) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Group(string groupName) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Groups(System.Collections.Generic.IReadOnlyList<string> groupNames) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy User(string userId) { throw null; }
        public Microsoft.AspNetCore.SignalR.IClientProxy Users(System.Collections.Generic.IReadOnlyList<string> userIds) { throw null; }
    }
    internal partial class HubClients<THub, T> : Microsoft.AspNetCore.SignalR.IHubClients<T> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubClients(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public T All { get { throw null; } }
        public T AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public virtual T Client(string connectionId) { throw null; }
        public T Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds) { throw null; }
        public virtual T Group(string groupName) { throw null; }
        public T GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public T Groups(System.Collections.Generic.IReadOnlyList<string> groupNames) { throw null; }
        public virtual T User(string userId) { throw null; }
        public virtual T Users(System.Collections.Generic.IReadOnlyList<string> userIds) { throw null; }
    }
    internal partial class HubConnectionBinder<THub> : Microsoft.AspNetCore.SignalR.IInvocationBinder where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubConnectionBinder(Microsoft.AspNetCore.SignalR.Internal.HubDispatcher<THub> dispatcher, Microsoft.AspNetCore.SignalR.HubConnectionContext connection) { }
        public System.Collections.Generic.IReadOnlyList<System.Type> GetParameterTypes(string methodName) { throw null; }
        public System.Type GetReturnType(string invocationId) { throw null; }
        public System.Type GetStreamItemType(string streamId) { throw null; }
    }
    internal partial class HubContext<THub> : Microsoft.AspNetCore.SignalR.IHubContext<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public HubContext(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public Microsoft.AspNetCore.SignalR.IHubClients Clients { get { throw null; } }
        public virtual Microsoft.AspNetCore.SignalR.IGroupManager Groups { get { throw null; } }
    }
    internal partial class HubContext<THub, T> : Microsoft.AspNetCore.SignalR.IHubContext<THub, T> where THub : Microsoft.AspNetCore.SignalR.Hub<T> where T : class
    {
        public HubContext(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager) { }
        public Microsoft.AspNetCore.SignalR.IHubClients<T> Clients { get { throw null; } }
        public virtual Microsoft.AspNetCore.SignalR.IGroupManager Groups { get { throw null; } }
    }
    internal abstract partial class HubDispatcher<THub> where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        protected HubDispatcher() { }
        public abstract System.Threading.Tasks.Task DispatchMessageAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection, Microsoft.AspNetCore.SignalR.Protocol.HubMessage hubMessage);
        public abstract System.Collections.Generic.IReadOnlyList<System.Type> GetParameterTypes(string name);
        public abstract System.Threading.Tasks.Task OnConnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection);
        public abstract System.Threading.Tasks.Task OnDisconnectedAsync(Microsoft.AspNetCore.SignalR.HubConnectionContext connection, System.Exception exception);
    }
    internal partial class HubGroupList : System.Collections.Generic.IEnumerable<System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.AspNetCore.SignalR.HubConnectionContext>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.AspNetCore.SignalR.HubConnectionContext>>, System.Collections.IEnumerable
    {
        public HubGroupList() { }
        public int Count { get { throw null; } }
        public System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.AspNetCore.SignalR.HubConnectionContext> this[string groupName] { get { throw null; } }
        public void Add(Microsoft.AspNetCore.SignalR.HubConnectionContext connection, string groupName) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.AspNetCore.SignalR.HubConnectionContext>> GetEnumerator() { throw null; }
        public void Remove(string connectionId, string groupName) { }
        public void RemoveDisconnectedConnection(string connectionId) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    internal partial class HubMethodDescriptor
    {
        public HubMethodDescriptor(Microsoft.Extensions.Internal.ObjectMethodExecutor methodExecutor, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizeData> policies) { }
        public bool HasSyntheticArguments { get { throw null; } }
        public bool IsStreamResponse { get { throw null; } }
        public Microsoft.Extensions.Internal.ObjectMethodExecutor MethodExecutor { get { throw null; } }
        public System.Type NonAsyncReturnType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Type> OriginalParameterTypes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Type> ParameterTypes { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.Authorization.IAuthorizeData> Policies { get { throw null; } }
        public System.Collections.Generic.List<System.Type> StreamingParameters { get { throw null; } }
        public System.Type StreamReturnType { get { throw null; } }
        public System.Collections.Generic.IAsyncEnumerable<object> FromReturnedStream(object stream, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal static partial class HubReflectionHelper
    {
        public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetHubMethods(System.Type hubType) { throw null; }
    }
    internal partial class MultipleClientProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public MultipleClientProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, System.Collections.Generic.IReadOnlyList<string> connectionIds) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class MultipleGroupProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public MultipleGroupProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, System.Collections.Generic.IReadOnlyList<string> groupNames) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class MultipleUserProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public MultipleUserProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, System.Collections.Generic.IReadOnlyList<string> userIds) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal partial class SignalRCoreMarkerService
    {
        public SignalRCoreMarkerService() { }
    }
    internal partial class SignalRServerBuilder : Microsoft.AspNetCore.SignalR.ISignalRBuilder, Microsoft.AspNetCore.SignalR.ISignalRServerBuilder
    {
        public SignalRServerBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get { throw null; } }
    }
    internal partial class SingleClientProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public SingleClientProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, string connectionId) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal static partial class TypeBaseEnumerationExtensions
    {
        public static System.Collections.Generic.IEnumerable<System.Type> AllBaseTypes(this System.Type type) { throw null; }
    }
    internal static partial class TypedClientBuilder<T>
    {
        public static T Build(Microsoft.AspNetCore.SignalR.IClientProxy proxy) { throw null; }
        public static void Validate() { }
    }
    internal partial class TypedHubClients<T> : Microsoft.AspNetCore.SignalR.IHubCallerClients<T>, Microsoft.AspNetCore.SignalR.IHubClients<T>
    {
        public TypedHubClients(Microsoft.AspNetCore.SignalR.IHubCallerClients dynamicContext) { }
        public T All { get { throw null; } }
        public T Caller { get { throw null; } }
        public T Others { get { throw null; } }
        public T AllExcept(System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public T Client(string connectionId) { throw null; }
        public T Clients(System.Collections.Generic.IReadOnlyList<string> connectionIds) { throw null; }
        public T Group(string groupName) { throw null; }
        public T GroupExcept(string groupName, System.Collections.Generic.IReadOnlyList<string> excludedConnectionIds) { throw null; }
        public T Groups(System.Collections.Generic.IReadOnlyList<string> groupNames) { throw null; }
        public T OthersInGroup(string groupName) { throw null; }
        public T User(string userId) { throw null; }
        public T Users(System.Collections.Generic.IReadOnlyList<string> userIds) { throw null; }
    }
    internal partial class UserProxy<THub> : Microsoft.AspNetCore.SignalR.IClientProxy where THub : Microsoft.AspNetCore.SignalR.Hub
    {
        public UserProxy(Microsoft.AspNetCore.SignalR.HubLifetimeManager<THub> lifetimeManager, string userId) { }
        public System.Threading.Tasks.Task SendCoreAsync(string method, object[] args, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class SignalRDependencyInjectionExtensions
    {
        public static Microsoft.AspNetCore.SignalR.ISignalRServerBuilder AddSignalRCore(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
    }
}
namespace Microsoft.Extensions.Internal
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct AwaitableInfo
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AwaitableInfo(System.Type awaiterType, System.Reflection.PropertyInfo awaiterIsCompletedProperty, System.Reflection.MethodInfo awaiterGetResultMethod, System.Reflection.MethodInfo awaiterOnCompletedMethod, System.Reflection.MethodInfo awaiterUnsafeOnCompletedMethod, System.Type resultType, System.Reflection.MethodInfo getAwaiterMethod) { throw null; }
        public System.Reflection.MethodInfo AwaiterGetResultMethod { get { throw null; } }
        public System.Reflection.PropertyInfo AwaiterIsCompletedProperty { get { throw null; } }
        public System.Reflection.MethodInfo AwaiterOnCompletedMethod { get { throw null; } }
        public System.Type AwaiterType { get { throw null; } }
        public System.Reflection.MethodInfo AwaiterUnsafeOnCompletedMethod { get { throw null; } }
        public System.Reflection.MethodInfo GetAwaiterMethod { get { throw null; } }
        public System.Type ResultType { get { throw null; } }
        public static bool IsTypeAwaitable(System.Type type, out Microsoft.Extensions.Internal.AwaitableInfo awaitableInfo) { throw null; }
    }
    internal static partial class ClosedGenericMatcher
    {
        public static System.Type ExtractGenericInterface(System.Type queryType, System.Type interfaceType) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CoercedAwaitableInfo
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CoercedAwaitableInfo(Microsoft.Extensions.Internal.AwaitableInfo awaitableInfo) { throw null; }
        public CoercedAwaitableInfo(System.Linq.Expressions.Expression coercerExpression, System.Type coercerResultType, Microsoft.Extensions.Internal.AwaitableInfo coercedAwaitableInfo) { throw null; }
        public Microsoft.Extensions.Internal.AwaitableInfo AwaitableInfo { get { throw null; } }
        public System.Linq.Expressions.Expression CoercerExpression { get { throw null; } }
        public System.Type CoercerResultType { get { throw null; } }
        public bool RequiresCoercion { get { throw null; } }
        public static bool IsTypeAwaitable(System.Type type, out Microsoft.Extensions.Internal.CoercedAwaitableInfo info) { throw null; }
    }
    internal partial class ObjectMethodExecutor
    {
        private ObjectMethodExecutor() { }
        public System.Type AsyncResultType { get { throw null; } }
        public bool IsMethodAsync { get { throw null; } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public System.Reflection.ParameterInfo[] MethodParameters { get { throw null; } }
        public System.Type MethodReturnType { get { throw null; } internal set { } }
        public System.Reflection.TypeInfo TargetTypeInfo { get { throw null; } }
        public static Microsoft.Extensions.Internal.ObjectMethodExecutor Create(System.Reflection.MethodInfo methodInfo, System.Reflection.TypeInfo targetTypeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.ObjectMethodExecutor Create(System.Reflection.MethodInfo methodInfo, System.Reflection.TypeInfo targetTypeInfo, object[] parameterDefaultValues) { throw null; }
        public object Execute(object target, object[] parameters) { throw null; }
        public Microsoft.Extensions.Internal.ObjectMethodExecutorAwaitable ExecuteAsync(object target, object[] parameters) { throw null; }
        public object GetDefaultValueForParameter(int index) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct ObjectMethodExecutorAwaitable
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ObjectMethodExecutorAwaitable(object customAwaitable, System.Func<object, object> getAwaiterMethod, System.Func<object, bool> isCompletedMethod, System.Func<object, object> getResultMethod, System.Action<object, System.Action> onCompletedMethod, System.Action<object, System.Action> unsafeOnCompletedMethod) { throw null; }
        public Microsoft.Extensions.Internal.ObjectMethodExecutorAwaitable.Awaiter GetAwaiter() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public Awaiter(object customAwaiter, System.Func<object, bool> isCompletedMethod, System.Func<object, object> getResultMethod, System.Action<object, System.Action> onCompletedMethod, System.Action<object, System.Action> unsafeOnCompletedMethod) { throw null; }
            public bool IsCompleted { get { throw null; } }
            public object GetResult() { throw null; }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    internal static partial class ObjectMethodExecutorFSharpSupport
    {
        public static bool TryBuildCoercerFromFSharpAsyncToAwaitable(System.Type possibleFSharpAsyncType, out System.Linq.Expressions.Expression coerceToAwaitableExpression, out System.Type awaitableType) { throw null; }
    }
}
