using System;

using Xunit;

namespace UnitTests.Fundamental.Dimensions
{
    [Trait("Category", "Dimensions")]
    public class DimensionsTests : TestBase
    {
        [Fact]
        public void Pressure_Tests()
        {
            var p = KMB.Library.Units.Dimensions.Pressure;
            Console.WriteLine($"p={p}");
        }

        [Fact]
        public void Resistivity_Tests()
        {
            var r = KMB.Library.Units.Dimensions.Resistivity;
            Console.WriteLine($"r={r}");
        }
    }
}
