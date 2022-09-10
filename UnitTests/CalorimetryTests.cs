using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.Metric;

namespace UnitTests
{
    [Trait("Category", "Calorimetry")]
    public class CalorimetryTests : TestBase
    {
        [Fact]
        public void Calorimetry_Tests()
        {
            // An electric kettle with an 800 watt 250 volt imersion heater is connecteed to the 200 volt mains.
            // How long will it take to raise 1000 gm of water to boiling point if the thermal capaciity of the
            // kettle is 100 cal per deg C and the initial temperature of the water is 20 C?
            Power p1 = 800.Watts();
            ElectricPotential v1 = 250.Volts();
            // Therefor the resistance of the element is
            Resistance r = v1.Squared() / p1;
            // Therefore the power on the 200 volt supply is:
            ElectricPotential v2 = 200.Volts();
            Power p2 = v2.Squared() / r;
            
            TestString("p2", 512.0, "512 W", p2);
            
            // So assuming the boiling point of water is 100 C
            TemperatureChange deltaT = 100.Celsius() - 20.Celsius();
            ThermalCapacity tcKettle = 100.CaloriesPerDegreeKelvin();
            SpecificHeat shWater = 4184.JoulesPerKilogramPerDegreeKelvin();
            Mass mWater = 1.Kilograms();
            ThermalCapacity tcWater = mWater * shWater;
            ThermalCapacity tcTotal = tcKettle + tcWater;
            Energy e = tcTotal * deltaT;    // e = 368208 J
            Time t = e / p2;  // t=722 secs
            
            TestString("t", 719.15625, "719.15625 s", t);
        }
    }
}
