using Xunit;

using FluentAssertions;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Units")]
    public class UnitsTests : TestBase
    {
        [Fact]
        public void Units_Tests()
        {
            var m = MetricUnits.Metres;
            m.Should().BeOfType<Unit>();
        }
    }
}
