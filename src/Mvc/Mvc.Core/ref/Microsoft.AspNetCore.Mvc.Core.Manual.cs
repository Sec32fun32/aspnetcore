// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc
{
    internal static partial class MvcCoreLoggerExtensions
    {
#nullable enable
        public static System.IDisposable? ActionScope(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor action) { throw new System.Exception(); }
#nullable restore
    }
}

namespace Microsoft.AspNetCore.Mvc.Infrastructure
{
#nullable enable
    internal abstract partial class ResourceInvoker
    {
        protected readonly Microsoft.AspNetCore.Mvc.ActionContext _actionContext;
        protected readonly Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor _actionContextAccessor;
        protected Microsoft.AspNetCore.Mvc.Filters.FilterCursor _cursor;
        protected readonly System.Diagnostics.DiagnosticListener _diagnosticListener;
        protected readonly Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] _filters;
        protected object? _instance;
        protected readonly Microsoft.Extensions.Logging.ILogger _logger;
        protected readonly Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper _mapper;
        protected Microsoft.AspNetCore.Mvc.IActionResult? _result;
        protected readonly System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> _valueProviderFactories;
        public ResourceInvoker(System.Diagnostics.DiagnosticListener diagnosticListener, Microsoft.Extensions.Logging.ILogger logger, Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor actionContextAccessor, Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper mapper, Microsoft.AspNetCore.Mvc.ActionContext actionContext, Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata[] filters, System.Collections.Generic.IList<Microsoft.AspNetCore.Mvc.ModelBinding.IValueProviderFactory> valueProviderFactories)
        {
            _actionContext = actionContext;
            _actionContextAccessor = actionContextAccessor;
            _cursor = new Microsoft.AspNetCore.Mvc.Filters.FilterCursor(filters);
            _diagnosticListener = diagnosticListener;
            _filters = filters;
            _logger = logger;
            _mapper = mapper;
            _valueProviderFactories = valueProviderFactories;
        }
        public virtual System.Threading.Tasks.Task InvokeAsync() { throw new System.Exception(); }
        protected abstract System.Threading.Tasks.Task InvokeInnerFilterAsync();
        protected virtual System.Threading.Tasks.Task InvokeResultAsync(Microsoft.AspNetCore.Mvc.IActionResult result) { throw new System.Exception(); }
        protected abstract void ReleaseResources();
    }
#nullable restore
    internal partial class ControllerActionInvoker : Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker
    {
    }
}
