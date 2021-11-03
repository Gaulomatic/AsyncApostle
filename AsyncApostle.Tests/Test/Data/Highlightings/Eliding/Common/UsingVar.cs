﻿using System.Threading;
using System.Threading.Tasks;

namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            using var usingVar = new SemaphoreSlim(1);
            await usingVar.WaitAsync().ConfigureAwait(false);
        }
    }
}
