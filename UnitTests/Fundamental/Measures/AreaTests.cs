using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Area")]
    public class AreaTests : TestBase
    {
        [Fact]
        public void Area_Tests()
        {
            Length l1 = 3.Metres();
            Length l2 = 4.Metres();
            Area a1 = l1 * l2;
            TestString("a1", 12, "12 m²", a1);
            Area a2 = l1.Squared();
            TestString("a2", 9, "9 m²", a2);
        }
    }
}
