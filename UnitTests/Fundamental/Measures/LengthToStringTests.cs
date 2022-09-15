using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using KMB.Library.Units.British;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "LengthToString")]
    public class LengthToStringTests : TestBase
    {
        [Fact]
        public void LengthToString_Tests()
        {
            Length l = 1234.567.Metres();
            l.ToString();    // s = "1.234567 km" (same as BestFit)
            // Formatting options:
            l.ToString(UnitsSystem.FormatOption.Standard);    // s = "1234.567 m" (force to metres)
            l.ToString(UnitsSystem.FormatOption.BestFit);     // s = "1.234567 km"
            l.ToString(UnitsSystem.FormatOption.Multiple);    // s = "1 km 234 m 56 cm 7 mm"
            // Specify the units:
            l.ToString(MetricUnits.Metres, MetricUnits.Centimetres);    // s = "1234 m 56.7 cm" 
            // British units:
            l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard);     // s = "4050.41667 ft"
            l.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit);      // s = "1350.13889 yd"
            l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple);     // s = "1350 yd 5 in"
            // Specified British units:
            l.ToString(BritishUnits.Miles, BritishUnits.Feet, BritishUnits.Inches); // s = "4050 ft 5 in"

            Length.Parse("42 m");    // l = 42 m
            Length.Parse("42 m 76 cm"); // l = 42.76 m
            Length.Parse("5 ft 4 in", BritishUnits.System); // l = 1.6256 m
            // This will throw an exception
            Length.Parse("42 m 76 kg");
        }
    }
}
