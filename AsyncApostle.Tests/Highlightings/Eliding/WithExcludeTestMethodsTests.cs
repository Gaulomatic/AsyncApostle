using AsyncApostle.Settings.General;
using AsyncApostle.Tests.Helpers;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace AsyncApostle.Tests.Highlightings.Eliding;

[TestSetting(typeof(GeneralSettings), nameof(GeneralSettings.ExcludeTestMethodsFromEliding), false)]
public class WithExcludeTestMethodsTests : HighlightingsTestsBase
{
   protected sealed override string RelativeTestDataPath => @"Highlightings\Eliding\WithExcludeTestMethods";

   [TestCaseSource(typeof(TestHelper), nameof(TestHelper.FileNames), new object[] { @"Highlightings\Eliding\WithExcludeTestMethods" })]
   public void Test(string fileName) => DoTestSolution(fileName);
}