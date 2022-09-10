using System;

using Xunit;

using KMB.Library.Units;
using FluentAssertions;

namespace UnitTests
{
    [Trait("Category", "AbsoluteTemperature")]
    public class AbsoluteTemperatureTests
    {
        [Fact]
        public void Absolute_Temperature_Tests()
        {
            TestString("t1", 0.0, "0 K", 0.Kelvin());
            
            TestString("t2", 300.0, "300 K", 300.Kelvin());
            
            // melting point of lead
            TestString("t3", 600.65, "600.65 K", 600.65.Kelvin());

            TestString("c1", 273.15, "273.15 K", 0.Celsius());
            
            TestString("c2", 333.15, "333.15 K", 60.Celsius());
            
            TestString("c3", 373.15, "373.15 K", 100.Celsius());

            Check.Equal(0.Celsius().ToString(TemperatureUnits.Celsius), "0 °C", "wrong value for s1");
            
            Check.Equal(60.Celsius().ToString(TemperatureUnits.Celsius), "60 °C", "wrong value for s2");
            
            Check.Equal(100.Celsius().ToString(TemperatureUnits.Celsius), "100 °C", "wrong value for s3");

            TestString("f1", 255.37222222, "255.37 K", 0.Fahrenheit());
            
            TestString("f2", 273.15, "273.15 K", 32.Fahrenheit());
            
            TestString("f3", 288.705555, "288.71 K", 60.Fahrenheit());
            
            TestString("f4", 310.9277778, "310.93 K", 100.Fahrenheit());

            Check.Equal(60.Fahrenheit().ToString(TemperatureUnits.Fahrenheit), "60 °F", "wrong value for s4");

            // New style, may not throw if conversion fails in the future
            Action act = () => TestString("t4", 309.814444444, "309.81 K", AbsoluteTemperature.Parse("98 °F"));
            act.Should().NotThrow<Exception>();
        }

        private static void TestString(string varName, double expectedValue, string expectedString, IPhysicalQuantity l1)
        {
            Check.Equal(expectedValue, l1.Value, $"wrong value for {varName}: {l1.Value}");
            Check.Equal(expectedString, l1.ToString(), "wrong value for {varName}.ToString()");
        }
    }
}
