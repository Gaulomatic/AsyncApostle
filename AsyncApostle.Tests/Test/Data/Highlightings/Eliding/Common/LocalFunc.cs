﻿using System.Threading.Tasks;

namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            await Foo().ConfigureAwait(false);
            static async Task Foo()
            {
                await Task.Delay(1000).ConfigureAwait(false);
            }
        }
    }
}
