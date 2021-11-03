using AsyncApostle.Tests.Helpers;
using NUnit.Framework;

namespace AsyncApostle.Tests.Highlightings
{
    public class AsyncWaitTests : HighlightingsTestsBase
    {
        [TestCaseSource(typeof(TestHelper),
                        nameof(TestHelper.FileNames),
                        new object[]
                        {
                            @"Highlightings\" + nameof(AsyncWaitTests)
                        })]
        public void Test(string fileName) => DoTestSolution(fileName);
    }
}
