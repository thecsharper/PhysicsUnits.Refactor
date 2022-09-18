using System;

using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.Metric;

namespace UnitTests.ElectricityAndMagnetism
{
    [Trait("Category", "Resistance")]
    public class ResistanceTests : TestBase
    {
        [Fact]
        public void Resistance_Tests()
        {
            // A 1 ohm resistor has a voltage drop from 100V to 10V across it.
            // What is the current through the resistor? 
            Resistance r = 1.Ohms();
            ElectricPotential v = 100.Volts() - 10.Volts();
            Current i = v / r;  // i = 90 amp
            TestString("i", 90.0, "90 amp", i);
            
            Power w = v * i;    // w = 8.1 kW 
            TestString("w", 8100, "8.1 kW", w);

            // A 10 ohm resistor in a circuit subject to a current of 2 Ampere and a voltage of 120V.
            // What is the voltage drop across the resistor?
            r = 10.Ohms();
            i = 2.Ampere();
            v = i * r;
            
            TestString("v", 20, "20 volt", v);
        }
    }
}
