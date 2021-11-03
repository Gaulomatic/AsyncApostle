﻿using System.Threading.Tasks;

namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task<int> TestAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            var task = Task.FromResult(1000);
            return task.Result;
        }
    }
}
