using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.Metric;

namespace UnitTests.ElectricityAndMagnetism
{
    [Trait("Category", "Resistivity")]
    public class ResistivityTests : TestBase
    {
        [Fact]
        public void Resistivity_Tests()
        {
            // A Nichrome heating element must generate 450 Watts of heat from a 250 Volt Supply.
            // The heating element is a ribbon 1 mm by 0.05 mm. What length should it be?
            Power p = 450.Watts();
            ElectricPotential v = 250.Volts();
            Area a = 1.Millimetres() * 0.05.Millimetres();
            Resistivity ρ = 1.1e-6.OhmMetres();
            // p = v²/r therefore r = v²/p;
            Resistance r = v.Squared() / p;
            // r = ρ l/a (Pouillet's law), therefore l = r a / ρ 
            Length l = r * a / ρ;
            TestString("l", 6.31313131, "6.31313131 m", l);
        }
    }
}
