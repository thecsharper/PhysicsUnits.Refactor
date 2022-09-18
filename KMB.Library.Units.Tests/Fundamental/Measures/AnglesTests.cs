using System;

using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Angles")]
    public class AnglesTests : TestBase
    {
        [Fact]
        public void Angles_Tests()
        {
            TestString("a1", 0.78539816339744828, "0.785398163 rad", 45.Degrees());
            var a2 = (Math.PI / 2.0).Radians();
            
            Check.Equal("90 °", a2.ToString(MetricUnits.Degrees), "Wrong value for a2.ToString()");
            
            var a3 = Angle.Parse("3.1415926535897932 rad");
            TestString("a3", 3.1415926535897931, "3.14159265 rad", a3);
            
            var s = a3.ToString(MetricUnits.Degrees);
            Check.Equal("180 °", s, "Wrong value for a3.ToString()");
            
            var a4 = Angle.Parse("180 °");
            TestString("a3", 3.1415926535897931, "3.14159265 rad", a4);
            
            Check.Equal("180 °", a4.ToString(MetricUnits.Degrees), "Wrong value for a4.ToString()");
        }
    }
}
