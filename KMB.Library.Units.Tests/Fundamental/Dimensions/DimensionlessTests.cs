using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using System;
using FluentAssertions;

namespace UnitTests.Fundamental.Dimensions
{
    [Trait("Category", "Dimensionless")]
    public class DimensionlessTests : TestBase
    {
        [Fact]
        public void Dimensionless_Tests()
        {
            Dimensionless d1 = 4.2;
            Dimensionless d2 = 5.3;
            Dimensionless d3 = 6.4;
            Dimensionless d4 = d1 + d2 + d3;

            Check.Equal(15.9, d4.Value, "wrong value for d4.Value");

            Dimensionless c1 = 42;
            Action test1 = () => TestString("c1", 42.0, "42", c1);
            test1.Should().Throw<Exception>();
            double d5 = c1;

            Check.Equal(42.0, d5, "wrong value for d5");

            Dimensionless pc = 2.5.Percent();
            Action test2 = () => TestString("pc", 0.025, "0.025", pc);
            test2.Should().Throw<Exception>();

            Check.Equal("2.5 %", pc.ToString(MetricUnits.Percent), "Wrong value for pc.ToString()");
        }
    }
}
