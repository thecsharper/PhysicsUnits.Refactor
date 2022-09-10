using System;

using Xunit;

using FluentAssertions;

using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "PhysicalQuantity")]
    public class PhysicalQuantityTests : TestBase
    {
        [Fact]
        public void PhysicalQuantity_Tests()
        {
            var l1 = new PhysicalQuantity(2.632, KMB.Library.Units.Dimensions.Length);
            var l2 = new PhysicalQuantity(2.632, KMB.Library.Units.Dimensions.Length);
            var sum = l1 + l2;
            
            Action act1 = () => Check.Equal("5.264 m", sum.ToString(), "wrong value for sum.ToString()");
            act1.Should().Throw<Exception>();

            var m = new PhysicalQuantity(65, KMB.Library.Units.Dimensions.Mass);
            
            Check.ThrowsException(() => sum = l1 + m, "Dimension mismatch: L  M ");
            
            var product = l1 * m;
            Action act2 = () => Check.Equal("171.08 kg⋅m", product.ToString(), "wrong value for product.ToString()");
            act2.Should().Throw<Exception>().WithMessage("Invalid conversion from PhysicalQuantity to Dimensionless");
        }
    }
}
