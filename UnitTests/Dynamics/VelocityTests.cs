using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using KMB.Library.Units.British;
using KMB.Library.Units.TimeUnits;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Velocity")]
    public class VelocityTests : TestBase
    {
        [Fact]
        public void Velocity_Tests()
        {
            // velocity = distance / time
            // Usain Bolt
            var l = 100.Metres();
            var t = 9.58.Seconds();
            var v = l / t;
            TestString("v", 10.4384134, "10.4384134 m/s", v);
            // check v = 44.72 km/h
            
            var s = v.ToString(MetricUnits.KilometresPerHour);
            Check.Equal("37.5782881 kph", s, "wrong value for v.ToString()");
            s = v.ToString(BritishUnits.MilesPerHour);
            Check.Equal("23.3501044 mph", s, "wrong value for v.ToString(BritishUnits.MilesPerHour)");
            
            // distance = velocity * time
            l = v * 1.Hours();
            s = l.ToString(MetricUnits.Kilometres);
            Check.Equal("37.5782881 km", s, "wrong value for l.ToString()");
        }
    }
}
