using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Momentum")]
    public class MomentumTests : TestBase
    {
        [Fact]
        public void Momentum_Tests()
        {
            // Momentum = mass * velocity
            // An object of mass 20 kg moving with a velocity of 10 m/s has a momentum of 200 kg m/s
            Momentum m = 20.Kilograms() * 10.MetresPerSecond();
            TestString("m", 200, "200 kg⋅m/s", m);
        }
    }
}
