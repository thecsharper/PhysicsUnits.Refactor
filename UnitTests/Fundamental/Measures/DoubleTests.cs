using Xunit;

using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Double")]
    public class DoubleTests : TestBase
    {
        [Fact]
        public void Double_Tests()
        {
            double d1 = 4.2;
            double d2 = 5.3;
            double d3 = 6.4;
            double d4 = d1 + d2 + d3;
            Check.Equal(15.9, d4, "wrong value for d4");
        }
    }
}
