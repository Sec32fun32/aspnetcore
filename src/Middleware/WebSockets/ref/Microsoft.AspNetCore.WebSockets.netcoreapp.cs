// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public static partial class WebSocketMiddlewareExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWebSockets(this Microsoft.AspNetCore.Builder.IApplicationBuilder app) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWebSockets(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Builder.WebSocketOptions options) { throw null; }
    }
    public partial class WebSocketOptions
    {
        public WebSocketOptions() { }
        public System.Collections.Generic.IList<string> AllowedOrigins { get { throw null; } }
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        public int ReceiveBufferSize { get { throw null; } set { } }
    }
}
namespace Microsoft.AspNetCore.WebSockets
{
    public partial class ExtendedWebSocketAcceptContext : Microsoft.AspNetCore.Http.WebSocketAcceptContext
    {
        public ExtendedWebSocketAcceptContext() { }
        public System.TimeSpan? KeepAliveInterval { get { throw null; } set { } }
        public int? ReceiveBufferSize { get { throw null; } set { } }
        public override string SubProtocol { get { throw null; } set { } }
    }
    public partial class WebSocketMiddleware
    {
        public WebSocketMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.WebSocketOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public static partial class WebSocketsDependencyInjectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWebSockets(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.Builder.WebSocketOptions> configure) { throw null; }
    }
}
