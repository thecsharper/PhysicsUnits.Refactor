using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.British;
using KMB.Library.Units.Metric;

namespace UnitTests.Heat
{
    [Trait("Category", "TemperatureChange")]
    public class TemperatureChangeTests : TestBase
    {
        [Fact]
        public void Temperature_Change_Tests()
        {
            var deltaT = 100.Celsius() - 20.Celsius();
            TestString("deltaT", 80, "80 K", deltaT);
            Check.Equal(deltaT.ToString(BritishUnits.DegreesFahrenheit), "144 °F", "wrong value for s");

            TestString("t2", 306.15, "306.15 K", 0.Celsius() + 33.DegreesCelsius());
        }
    }
}
