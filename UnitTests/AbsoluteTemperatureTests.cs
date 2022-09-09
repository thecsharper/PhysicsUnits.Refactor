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
            AbsoluteTemperature t1 = 0.Kelvin();
            TestToString("t1", 0.0, "0 K", t1);
            AbsoluteTemperature t2 = 300.Kelvin();
            TestToString("t2", 300.0, "300 K", t2);
            AbsoluteTemperature t3 = 600.65.Kelvin();   // melting point of lead
            TestToString("t3", 600.65, "600.65 K", t3);

            AbsoluteTemperature c1 = 0.Celsius();
            TestToString("c1", 273.15, "273.15 K", c1);
            AbsoluteTemperature c2 = 60.Celsius();
            TestToString("c2", 333.15, "333.15 K", c2);
            AbsoluteTemperature c3 = 100.Celsius();
            TestToString("c3", 373.15, "373.15 K", c3);

            var s1 = c1.ToString(TemperatureUnits.Celsius);
            Check.Equal(s1, "0 °C", "wrong value for s1");
            var s2 = c2.ToString(TemperatureUnits.Celsius);
            Check.Equal(s2, "60 °C", "wrong value for s2");
            var s3 = c3.ToString(TemperatureUnits.Celsius);
            Check.Equal(s3, "100 °C", "wrong value for s3");

            AbsoluteTemperature f1 = 0.Fahrenheit();
            TestToString("f1", 255.37222222, "255.37 K", f1);
            AbsoluteTemperature f2 = 32.Fahrenheit();
            TestToString("f2", 273.15, "273.15 K", f2);
            AbsoluteTemperature f3 = 60.Fahrenheit();
            TestToString("f3", 288.705555, "288.71 K", f3);
            AbsoluteTemperature f4 = 100.Fahrenheit();
            TestToString("f4", 310.9277778, "310.93 K", f4);

            var s4 = f3.ToString(TemperatureUnits.Fahrenheit);
            Check.Equal(s4, "60 °F", "wrong value for s4");

            Action act = () => TestToString("t4", 309.814444444, "309.81 K", AbsoluteTemperature.Parse("98 °F"));
            act.Should().NotThrow<Exception>();
        }

        private static void TestToString(string varName, double expectedValue, string expectedString, IPhysicalQuantity l1)
        {
            Check.Equal(expectedValue, l1.Value, $"wrong value for {varName}: {l1.Value}");
            var s = l1.ToString();
            Check.Equal(expectedString, s, "wrong value for {varName}.ToString()");
            Console.WriteLine($"{varName}={s}");
            
        }
    }
}
