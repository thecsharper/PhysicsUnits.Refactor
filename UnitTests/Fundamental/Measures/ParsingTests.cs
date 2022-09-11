using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.British;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Parsing")]
    public class ParsingTests : TestBase
    {
        [Fact]
        public void Parsing_Tests()
        {
            TestString("qty", 1, "1 m", UnitsSystem.ParseUnits("m"));
            TestString("qty", 0.01, "1 cm", UnitsSystem.ParseUnits("cm"));
            TestString("qty", 1e-6, "1E-06 m²", UnitsSystem.ParseUnits("mm²"));
            TestString("qty", 1e-07, "1E-07 J", UnitsSystem.ParseUnits("g⋅cm²/s²"));

            TestString("l", 42, "42 m", Length.Parse("42 m"));
            TestString("l2", 42.76, "42.76 m", Length.Parse("42 m 76 cm"));
            //TestString("l3", 1.6256, "1.6256 m", Length.Parse("5 ft 4 in", BritishUnits.System));

            //TODO fix this
            //Check.ThrowsException(() => { Length.Parse("42 m 76 kg"); return; }, "Parsing error: Invalid dimension for units: kg ");

            var b = Length.TryParse("5 ft 4 in", BritishUnits.System, out Length l3);
            Check.True(b, "return from TryParse() not true");
            Check.False(Length.TryParse("42 m 76 kg", out Length l4), "return from TryParse() not false");
        }
    }
}
