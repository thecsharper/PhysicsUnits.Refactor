using System;

using FluentAssertions;
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
            Action act = () => TestString("qty", 1, "1 m", UnitsSystem.ParseUnits("m"));
            act.Should().Throw<Exception>().WithMessage("Invalid conversion from PhysicalQuantity to Dimensionless");

            Action acta = () => TestString("qty", 0.01, "1 cm", UnitsSystem.ParseUnits("cm"));
            acta.Should().Throw<Exception>().WithMessage("Invalid conversion from PhysicalQuantity to Dimensionless");

            Action actb = () => TestString("qty", 1e-6, "1E-06 m²", UnitsSystem.ParseUnits("mm²"));
            actb.Should().Throw<Exception>().WithMessage("Invalid conversion from PhysicalQuantity to Dimensionless");

            Action actc = () => TestString("qty", 1e-07, "1E-07 J", UnitsSystem.ParseUnits("g⋅cm²/s²"));
            actc.Should().Throw<Exception>().WithMessage("Invalid conversion from PhysicalQuantity to Dimensionless");

            TestString("l", 42, "42 m", Length.Parse("42 m"));
            TestString("l2", 42.76, "42.76 m", Length.Parse("42 m 76 cm"));
            TestString("l3", 1.6256, "1.6256 m", Length.Parse("5 ft 4 in", BritishUnits.System));

            Action actd = () => Length.Parse("42 m 76 kg");
            actd.Should().Throw<Exception>().WithMessage("Parsing error: Invalid dimension for units: kg ");

            var b = Length.TryParse("5 ft 4 in", BritishUnits.System, out Length l3);
            Check.True(b, "return from TryParse() not true");
            Check.False(Length.TryParse("42 m 76 kg", out Length l4), "return from TryParse() not false");
        }
    }
}
