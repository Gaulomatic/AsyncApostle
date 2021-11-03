﻿using System.IO;
using System.Threading.Tasks;

namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            await using (new MemoryStream())
            {
                await Task.Delay(1000).ConfigureAwait(false);
            }
        }
    }
}
