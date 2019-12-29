// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR.Internal
{
    internal static partial class AsyncEnumerableAdapters
    {
        public static async System.Collections.Generic.IAsyncEnumerable<object> MakeAsyncEnumerableFromChannel<T>(System.Threading.Channels.ChannelReader<T> channel, [System.Runtime.CompilerServices.EnumeratorCancellationAttribute] System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await System.Threading.Tasks.Task.Delay(1);
            yield return null;
            throw null;
        }
    }
}
