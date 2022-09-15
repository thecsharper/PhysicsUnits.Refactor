using Xunit;

using KMB.Library.Units.Metric;
using System;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Density")]
    public class DensityTests : TestBase
    {
        [Fact]
        public void Density_Tests()
        {
            // For men's cricket, the official ball weighs between 155.9 and 163 grams.
            var mass = 161.Grams();
            
            // The ball's circumference is between 22.4 and 22.9 centimeters.
            var circumference = 22.6.Centimetres();
            var radius = circumference / (2 * Math.PI);
            var volume = (4.0 / 3.0) * Math.PI * radius.Cubed();
            var density = mass / volume;
            
            TestString("density", 825.94581, "825.94581 kg/m³", density);
        }
    }
}
