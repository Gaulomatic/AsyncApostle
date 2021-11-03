﻿using System.Threading.Tasks;
using SKBKontur.Billy.Core.Common.Threading;
namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task<int> TestAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            return Task.FromResult(1000).AwaitResult();
        }
    }
}

namespace SKBKontur.Billy.Core.Common.Threading
{
    public static class TaskExtensions
    {
        public static T AwaitResult<T>(this Task<T> task)
            => task.GetAwaiter().GetResult();
        public static void AwaitResult(this Task task)
            => task.GetAwaiter().GetResult();
    }    
}
