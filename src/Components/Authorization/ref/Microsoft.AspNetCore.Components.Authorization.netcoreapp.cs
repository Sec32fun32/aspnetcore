// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components.Authorization
{
    public partial class AuthenticationState
    {
        public AuthenticationState(System.Security.Claims.ClaimsPrincipal user) { }
        public System.Security.Claims.ClaimsPrincipal User { get { throw null; } }
    }
    public delegate void AuthenticationStateChangedHandler(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> task);
    public abstract partial class AuthenticationStateProvider
    {
        protected AuthenticationStateProvider() { }
        public event Microsoft.AspNetCore.Components.Authorization.AuthenticationStateChangedHandler AuthenticationStateChanged { add { } remove { } }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> GetAuthenticationStateAsync();
        protected void NotifyAuthenticationStateChanged(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> task) { }
    }
    public sealed partial class AuthorizeRouteView : Microsoft.AspNetCore.Components.RouteView
    {
        public AuthorizeRouteView() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment Authorizing { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> NotAuthorized { get { throw null; } set { } }
        protected override void Render(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder) { }
    }
    public partial class AuthorizeView : Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore
    {
        public AuthorizeView() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public string Policy { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public string Roles { get { throw null; } set { } }
        protected override Microsoft.AspNetCore.Authorization.IAuthorizeData[] GetAuthorizeData() { throw null; }
    }
    public abstract partial class AuthorizeViewCore : Microsoft.AspNetCore.Components.ComponentBase
    {
        protected AuthorizeViewCore() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> Authorized { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment Authorizing { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> ChildContent { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> NotAuthorized { get { throw null; } set { } }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public object Resource { get { throw null; } set { } }
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder) { }
        protected abstract Microsoft.AspNetCore.Authorization.IAuthorizeData[] GetAuthorizeData();
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected override System.Threading.Tasks.Task OnParametersSetAsync() { throw null; }
    }
    public partial class CascadingAuthenticationState : Microsoft.AspNetCore.Components.ComponentBase, System.IDisposable
    {
        public CascadingAuthenticationState() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment ChildContent { get { throw null; } set { } }
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder) { }
        protected override void OnInitialized() { }
        void System.IDisposable.Dispose() { }
    }
    public partial interface IHostEnvironmentAuthenticationStateProvider
    {
        void SetAuthenticationState(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> authenticationStateTask);
    }
}
