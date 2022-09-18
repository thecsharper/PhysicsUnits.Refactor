using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Volume")]
    public class VolumeTests : TestBase
    {
        [Fact]
        public void Volume_Tests()
        {
            Length l1 = 3.Metres();
            Length l2 = 4.Metres();
            Length l3 = 5.Metres();
            Volume v1 = l1 * l2 * l3;
            TestString("v1", 60, "60 m³", v1);
            Volume v2 = l1.Cubed();
            TestString("v2", 27, "27 m³", v2);
        }
    }
}
