using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Prefix")]
    public class PrefixTests : TestBase
    {
        [Fact]
        public void Prefix_Tests()
        {
            TestString("l1", 4.2E-08, "42 nm", 42.Nano().Metres());

            Prefixes.Parse("nanometres", out double factor, out string unit);

            Check.Equal(1e-9, factor, "incorrect factor returned from Prefixes.Parse()");
            Check.Equal("metres", unit, "incorrect unit returned from Prefixes.Parse()");
        }
    }
}
