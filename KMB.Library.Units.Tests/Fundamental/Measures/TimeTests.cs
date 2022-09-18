using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using KMB.Library.Units.TimeUnits;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Time")]
    public class TimeTests : TestBase
    {
        [Fact]
        public void Time_Tests()
        {
            var t1 = 66.JulianYears() + 21.Weeks() + 16.Hours() + 29.Minutes() + 13.Seconds();
            TestString("t1", 2095561753.0, "2.09556175E+09 s", t1);
            
            var s = t1.ToString(TimeUnits.Minutes, MetricUnits.Seconds);
            Check.Equal("34926029 min 13.0000001 s", s, "wrong value for l1.ToString()");
        }
    }
}
