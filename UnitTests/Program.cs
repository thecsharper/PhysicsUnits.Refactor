using System;
using System.Diagnostics;
using KMB.Library.Units;
using KMB.Library.Units.Metric;
using KMB.Library.Units.TimeUnits;     // for hours, minutes etc.
using KMB.Library.Units.British;       // For feet and pounds.  Or use USA if you prefer
using System.Runtime.CompilerServices;

namespace UnitTests
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    TestBasics();

        //    TestBritishUnits();

        //    TestDynamics();

        //    TestHeat();

        //    TestLight();

        //    TestElectricityAndMagnetism();
        //}

        private static void TestLight()
        {
            //throw new NotImplementedException();
        }

        //Converted
        private static void TestAbsoluteTemperature()
        {
            Console.WriteLine("TestTemperature ------------------------");
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

            string s1 = c1.ToString(TemperatureUnits.Celsius);
            Check.Equal(s1, "0 °C", "wrong value for s1");
            string s2 = c2.ToString(TemperatureUnits.Celsius);
            Check.Equal(s2, "60 °C", "wrong value for s2");
            string s3 = c3.ToString(TemperatureUnits.Celsius);
            Check.Equal(s3, "100 °C", "wrong value for s3");

            AbsoluteTemperature f1 = 0.Fahrenheit();
            TestToString("f1", 255.37222222, "255.37 K", f1);
            AbsoluteTemperature f2 = 32.Fahrenheit();
            TestToString("f2", 273.15, "273.15 K", f2);
            AbsoluteTemperature f3 = 60.Fahrenheit();
            TestToString("f3", 288.705555, "288.71 K", f3);
            AbsoluteTemperature f4 = 100.Fahrenheit();
            TestToString("f4", 310.9277778, "310.93 K", f4);

            string s4 = f3.ToString(TemperatureUnits.Fahrenheit);
            Check.Equal(s4, "60 °F", "wrong value for s4");

            AbsoluteTemperature t4 = AbsoluteTemperature.Parse("98 °F");
            TestToString("t4", 309.814444444, "309.81 K", t4);
        }

        //Converted
        private static void TestTemperatureChange()
        {
            TemperatureChange deltaT = 100.Celsius() - 20.Celsius();
            TestToString("deltaT", 80, "80 K", deltaT);
            string s = deltaT.ToString(BritishUnits.DegreesFahrenheit);
            Check.Equal(s, "144 °F", "wrong value for s");
            TemperatureChange dt2 = 33.DegreesCelsius();
            AbsoluteTemperature t1 = 0.Celsius();
            AbsoluteTemperature t2 = t1 + dt2;
            TestToString("t2", 306.15, "306.15 K", t2);
        }

        private static void TestHeat()
        {
            TestAbsoluteTemperature(); // Converted
            TestTemperatureChange();  // Converted
            TestCalorimetry();        // Converted
            TestThermalExpansion();
            TestGases();
        }

        private static void TestGases()
        {
            //throw new NotImplementedException();
        }

        private static void TestThermalExpansion()
        {
            //throw new NotImplementedException();
        }

        private static void TestCalorimetry()
        {
            Console.WriteLine("TestCalorimetry ------------------------");
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
            TestToString("p2", 512.0, "512 W", p2);
            // So assuming the boiling point of water is 100 C
            TemperatureChange deltaT = 100.Celsius() - 20.Celsius();
            ThermalCapacity tcKettle = 100.CaloriesPerDegreeKelvin();
            SpecificHeat shWater = 4184.JoulesPerKilogramPerDegreeKelvin();
            Mass mWater = 1.Kilograms();
            ThermalCapacity tcWater = mWater * shWater;
            ThermalCapacity tcTotal = tcKettle + tcWater;
            Energy e = tcTotal * deltaT;    // e = 368208 J
            Time t = e / p2;  // t=722 secs
            TestToString("t", 719.15625, "719.15625 s", t);
        }

        private static void TestElectricityAndMagnetism()
        {
            TestResistance();
            TestResistivity();
        }

        private static void TestResistance()
        {
            // A 1 ohm resistor has a voltage drop from 100V to 10V across it.
            // What is the current through the resistor? 
            Resistance r = 1.Ohms();
            ElectricPotential v = 100.Volts() - 10.Volts();
            Current i = v / r;  // i = 90 amp
            TestToString("i", 90.0, "90 amp", i);
            Power w = v * i;    // w = 8.1 kW 
            TestToString("w", 8100, "8.1 kW", w);

            // A 10 ohm resistor in a circuit subject to a current of 2 Ampere and a voltage of 120V.
            // What is the voltage drop across the resistor?
            r = 10.Ohms();
            i = 2.Ampere();
            v = i * r;
            TestToString("v", 20, "20 volt", v);
        }

        private static void TestResistivity()
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
            Length l = r * a  / ρ;
            TestToString("l", 6.31313131, "6.31313131 m", l);
        }

        private static void TestBasics()
        {
            TestDimensions(); // Converted

            TestDimensionless(); // Converted

            TestUnits(); // Converted

            TestPhysicalQuantity(); // Converted

            TestToString(); // Converted

            TestParsing();

            TestDouble();

            TestAngles();

            TestLength();

            // conversions to higher dimensions
            TestArea();

            TestVolume();

            TestDensity();

            TestTime();

            TestPrefixes();

        }

        private static void TestDimensions()
        {
            Console.WriteLine("TestDimensions ------------------------");
            Dimensions p = Dimensions.Pressure;
            Console.WriteLine($"p={p}");
            Dimensions r = Dimensions.Resistivity;
            Console.WriteLine($"r={r}");
        }

        private static void TestPhysicalQuantity()
        {
            Console.WriteLine("TestPhysicalQuantity ------------------------");
            PhysicalQuantity l1 = new PhysicalQuantity(2.632, Dimensions.Length);
            PhysicalQuantity l2 = new PhysicalQuantity(2.632, Dimensions.Length);
            PhysicalQuantity sum = l1 + l2;
            Check.Equal("5.264 m", sum.ToString(), "wrong value for sum.ToString()");
            PhysicalQuantity m = new PhysicalQuantity(65, Dimensions.Mass);
           // TODO fix this
            //Check.ThrowsException(() => sum = l1 + m, "Dimension mismatch: L  M ");
            PhysicalQuantity product = l1 * m;
            Check.Equal("171.08 kg⋅m", product.ToString(), "wrong value for product.ToString()");
        }

        private static void TestToString()
        {
            Console.WriteLine("TestToString ------------------------");
            Mass m = 63.5029.Kilograms();
            Check.Equal("63.5029 kg", m.ToString(), "wrong value for m.ToString()");
            Check.Equal("63.5029 kg", m.ToString(UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(Standard)");
            Check.Equal("63.5029 kg", m.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(BestFit)");
            Check.Equal("63 kg 502 g 900 μg", m.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(Multiple)");
            Check.Equal("63 kg 502.9 g", m.ToString(MetricUnits.Kilograms, MetricUnits.Grams), "wrong value for m.ToString(kg,g)");

            Check.Equal("139.99993 lb", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("1.24999937 cwt", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("1 cwt 1 st 13 lb 15.9988783 oz", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("139 lb 15.9988783 oz", m.ToString(BritishUnits.Pounds, BritishUnits.Ounces), "wrong value for m.ToString(lb,oz)");

            m = 163.Grams();
            Check.Equal("163 g", m.ToString(), "wrong value for m.ToString()");
            Check.Equal("0.163 kg", m.ToString(UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(Standard)");
            Check.Equal("163 g", m.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(BestFit)");
            Check.Equal("163 g", m.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(Multiple)");
            Check.Equal("163 g", m.ToString(MetricUnits.Kilograms, MetricUnits.Grams), "wrong value for m.ToString(kg,g)");

            Check.Equal("0.359353487 lb", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("5.7496558 oz", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("5.7496558 oz", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("5.7496558 oz", m.ToString(BritishUnits.Pounds, BritishUnits.Ounces), "wrong value for m.ToString(lb,oz)");

            m = 16.Tonnes();
            Check.Equal("16 t", m.ToString(), "wrong value for m.ToString()");
            Check.Equal("16000 kg", m.ToString(UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(Standard)");
            Check.Equal("16 t", m.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(BestFit)");
            Check.Equal("16 t", m.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(Multiple)");
            Check.Equal("16000 kg", m.ToString(MetricUnits.Kilograms, MetricUnits.Grams), "wrong value for m.ToString(kg,g)");

            Check.Equal("35273.9619 lb", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("15.7473044 ton", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("15 ton 14 cwt 7 st 7 lb 15.3911933 oz", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("35273 lb 15.3911933 oz", m.ToString(BritishUnits.Pounds, BritishUnits.Ounces), "wrong value for m.ToString(lb,oz)");

            Length l = 1.6256.Metres();
            Check.Equal("1.6256 m", l.ToString(), "wrong value for l.ToString()");
            Check.Equal("1.6256 m", l.ToString(UnitsSystem.FormatOption.Standard), "wrong value for l.ToString(Standard)");
            Check.Equal("1.6256 m", l.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for l.ToString(BestFit)");
            Check.Equal("1 m 62 cm 5 mm 600 μ", l.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for l.ToString(Multiple)");
            Check.Equal("1 m 62.56 cm", l.ToString(MetricUnits.Metres, MetricUnits.Centimetres), "wrong value for l.ToString(kg,g)");

            Check.Equal("5.33333333 ft", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("1.77777778 yd", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("1 yd 2 ft 4 in", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("5 ft 4 in", l.ToString(BritishUnits.Feet, BritishUnits.Inches), "wrong value for m.ToString(lb,oz)");

            l = 1234.567.Metres();
            Check.Equal("1.234567 km", l.ToString(), "wrong value for l.ToString()");
            Check.Equal("1234.567 m", l.ToString(UnitsSystem.FormatOption.Standard), "wrong value for l.ToString(Standard)");
            Check.Equal("1.234567 km", l.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for l.ToString(BestFit)");
            Check.Equal("1 km 234 m 56 cm 7 mm", l.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for l.ToString(Multiple)");
            Check.Equal("1234 m 56.7 cm", l.ToString(MetricUnits.Metres, MetricUnits.Centimetres), "wrong value for l.ToString(kg,g)");

            Check.Equal("4050.41667 ft", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("1350.13889 yd", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("1350 yd 5 in", l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("4050 ft 5 in", l.ToString(BritishUnits.Miles, BritishUnits.Feet, BritishUnits.Inches), "wrong value for m.ToString(lb,oz)");
        }

        private static void LengthToStringParseDemo()
        {
            Length l = 1234.567.Metres();
            string s = l.ToString();    // s = "1.234567 km" (same as BestFit)
            // Formatting options:
            s = l.ToString(UnitsSystem.FormatOption.Standard);    // s = "1234.567 m" (force to metres)
            s = l.ToString(UnitsSystem.FormatOption.BestFit);     // s = "1.234567 km"
            s = l.ToString(UnitsSystem.FormatOption.Multiple);    // s = "1 km 234 m 56 cm 7 mm"
            // Specify the units:
            s = l.ToString(MetricUnits.Metres, MetricUnits.Centimetres);    // s = "1234 m 56.7 cm" 
            // British units:
            s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard);     // s = "4050.41667 ft"
            s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit);      // s = "1350.13889 yd"
            s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple);     // s = "1350 yd 5 in"
            // Specified British units:
            s = l.ToString(BritishUnits.Miles, BritishUnits.Feet, BritishUnits.Inches); // s = "4050 ft 5 in"
            Console.WriteLine($"s={s}");

            l = Length.Parse("42 m");    // l = 42 m
            l = Length.Parse("42 m 76 cm"); // l = 42.76 m
            l = Length.Parse("5 ft 4 in", BritishUnits.System); // l = 1.6256 m
            // This will throw an exception
            l = Length.Parse("42 m 76 kg");
            Console.WriteLine($"l={l}");
        }

        private static void TestParsing()
        {
            Console.WriteLine("TestParsing ------------------------");
            PhysicalQuantity qty = UnitsSystem.ParseUnits("m");
            TestToString("qty", 1, "1 m", qty);
            qty = UnitsSystem.ParseUnits("cm");
            TestToString("qty", 0.01, "1 cm", qty);
            qty = UnitsSystem.ParseUnits("mm²");
            TestToString("qty", 1e-6, "1E-06 m²", qty);
            qty = UnitsSystem.ParseUnits("g⋅cm²/s²");
            TestToString("qty", 1e-07, "1E-07 J", qty);

            Length l = Length.Parse("42 m");
            TestToString("l", 42, "42 m", l);
            Length l2 = Length.Parse("42 m 76 cm");
            TestToString("l2", 42.76, "42.76 m", l2);
            Length l3 = Length.Parse("5 ft 4 in", BritishUnits.System);
            TestToString("l3", 1.6256, "1.6256 m", l3);
            // TODO fix this
            //Check.ThrowsException(() => { Length.Parse("42 m 76 kg"); return; }, "Parsing error: Invalid dimension for units: kg ");
            bool b = Length.TryParse("5 ft 4 in", BritishUnits.System, out l3);
            Check.True(b, "return from TryParse() not true");
            Length l4;
            b = Length.TryParse("42 m 76 kg", out l4);
            Check.False(b, "return from TryParse() not false");
        }

        private static void TestUnits()
        {
            Console.WriteLine("TestUnits ------------------------");
            Unit m = MetricUnits.Metres;
            Console.WriteLine($"m={m}");
        }

        private static void TestDouble()
        {
            double d1 = 4.2;
            double d2 = 5.3;
            double d3 = 6.4;
            double d4 = d1 + d2 + d3;
            Check.Equal(15.9, d4, "wrong value for d4");
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static void TestDimensionless()
        {
            Console.WriteLine("TestDimensionless ------------------------");
            Dimensionless d1 = 4.2;
            Dimensionless d2 = 5.3;
            Dimensionless d3 = 6.4;
            //Console.WriteLine("TestDimensionless ------------------------");
            Dimensionless d4 = d1 + d2 + d3;
            //Console.WriteLine("TestDimensionless ------------------------");
            Check.Equal(15.9, d4.Value, "wrong value for d4.Value");

            Dimensionless c1 = 42;
            TestToString("c1", 42.0, "42", c1);
            double d5 = c1;
            Check.Equal(42.0, d5, "wrong value for d5");

            Dimensionless pc = 2.5.Percent();
            TestToString("pc", 0.025, "0.025", pc);
            string s = pc.ToString(MetricUnits.Percent);
            Check.Equal("2.5 %", s, "Wrong value for pc.ToString()");
        }

        private static void TestAngles()
        {
            Console.WriteLine("TestAngles ------------------------");
            Angle a1 = 45.Degrees();
            TestToString("a1", 0.78539816339744828, "0.785398163 rad", a1);
            Angle a2 = (Math.PI / 2.0).Radians();
            string s = a2.ToString(MetricUnits.Degrees);
            Check.Equal("90 °", s, "Wrong value for a2.ToString()");
            Angle a3 = Angle.Parse("3.1415926535897932 rad");
            TestToString("a3", 3.1415926535897931, "3.14159265 rad", a3);
            s = a3.ToString(MetricUnits.Degrees);
            Check.Equal("180 °", s, "Wrong value for a3.ToString()");
            Angle a4 = Angle.Parse("180 °");
            TestToString("a3", 3.1415926535897931, "3.14159265 rad", a4);
            s = a4.ToString(MetricUnits.Degrees);
            Check.Equal("180 °", s, "Wrong value for a4.ToString()");
        }

        private static void TestLength()
        {
            Console.WriteLine("TestLength ------------------------");

            Length l0 = new Length(3.4);
            TestToString("l0", 3.4, "3.4 m", l0);

            // Basic maths in metres
            Length l1 = 4.2.Metres();
            TestToString("l1", 4.2, "4.2 m", l1);

            double f1 = l1.InMetres();
            Check.Equal(4.2, f1, "wrong value for l1.InMetres()");

            Length l2 = 4.2.Kilometres();
            TestToString("l2", 4200, "4.2 km", l2);

            Length l3 = 4.2.Centimetres();
            TestToString("l3", 0.042, "4.2 cm", l3);

            Length l4 = 4.2.Millimetres();
            TestToString("l4", 0.0042, "4.2 mm", l4);

            Length l5 = l1 + l4;
            TestToString("l5", 4.2042, "4.2042 m", l5);

            Length l6 = l1 * 7;
            TestToString("l6", 29.4, "29.4 m", l6);

            Length l7 = 9 * l1;
            TestToString("l7", 37.8, "37.8 m", l7);

            Length l8 = l1 / 2.3;
            TestToString("l8", 1.82608695652174, "1.82608696 m", l8);

            Length l9 = l1 / 10;
            TestToString("l9", 0.42, "42 cm", l9);

            Dimensionless five = new Dimensionless(5);
            Length l10 = l1 * five;
            TestToString("l10", 21, "21 m", l10);

            Dimensionless d1 = l5 / l6;
            TestToString("d1", 0.143, "0.143", d1);

            Area a1 = l1 * l5;
            TestToString("a1", 17.65764, "17.65764 m²", a1);

            Area a2 = l1 * l2;
            TestToString("a2", 17640, "1.764 ha", a2);

#if PREFER_RUNTIME_CHECKS
            PhysicalQuantity q1 = d1 / l1;
            TestToString("q1", 0.034047619047619042, "0.03404761904761904 m⁻¹", q1);
#endif

            // Convert from Physical quantity back to length:
            PhysicalQuantity q2 = new PhysicalQuantity(2.632, Dimensions.Length);
            Length l11 = q2;
            TestToString("l11", 2.632, "2.632 m", l11);

            Length m1 = l1;
            Length m2 = 5.3.Metres();
            Length m3 = 6.4.Metres();
            Length m4 = m1 + m2 + m3;
            Check.Equal(15.9, m4.Value, "wrong value for m4");
            Check.Equal("15.9 m", m4.ToString(), "ToString() returns wrong value for m4");

            Length m5 = m3 - m2;
            Check.Equal(1.1, m5.Value, "wrong value for m4");
            Check.Equal("1.1 m", m5.ToString(), "ToString() returns wrong value for m4");

            Dimensionless c2 = m1 / m2;
            Check.Equal(0.7924528301886793, c2.Value, "wrong value for c2");

            // Comparisons
            bool mb1 = (m1 > m2); Check.False(mb1, "(m1 > m2) returns wrong value");
            bool mb2 = (m1 >= m2); Check.False(mb2, "(m1 >= m2) returns wrong value");
            bool mb3 = (m1 == m2); Check.False(mb3, "(m1 == m2) returns wrong value");
            bool mb4 = (m1 != m2); Check.True(mb4, "(m1 != m2) returns wrong value");
            bool mb5 = (m1 <= m2); Check.True(mb5, "(m1 <= m2) returns wrong value");
            bool mb6 = (m1 < m2); Check.True(mb6, "(m1 < m2) returns wrong value");
        }

        private static void TestArea()
        {
            Console.WriteLine("TestArea ------------------------");
            Length l1 = 3.Metres();
            Length l2 = 4.Metres();
            Area a1 = l1 * l2;
            TestToString("a1", 12, "12 m²", a1);
            Area a2 = l1.Squared();
            TestToString("a2", 9, "9 m²", a2);
        }

        private static void TestVolume()
        {
            Console.WriteLine("TestVolume ------------------------");
            Length l1 = 3.Metres();
            Length l2 = 4.Metres();
            Length l3 = 5.Metres();
            Volume v1 = l1 * l2 * l3;
            TestToString("v1", 60, "60 m³", v1);
            Volume v2 = l1.Cubed();
            TestToString("v2", 27, "27 m³", v2);
        }

        private static void TestDensity()
        {
            Console.WriteLine("TestDensity ------------------------");
            // For men's cricket, the official ball weighs between 155.9 and 163 grams.
            Mass mass = 161.Grams();
            // The ball's circumference is between 22.4 and 22.9 centimeters.
            Length circumference = 22.6.Centimetres();
            Length radius = circumference / (2 * Math.PI);
            Volume volume = (4.0 / 3.0) * Math.PI * radius.Cubed();
            Density density = mass / volume;
            TestToString("density", 825.94581, "825.94581 kg/m³", density);
        }

        private static void TestPrefixes()
        {
            Console.WriteLine("TestPrefixes ------------------------");
            Length l1 = 42.Nano().Metres();
            TestToString("l1", 4.2E-08, "42 nm", l1);

            double factor;
            string unit;
            Prefixes.Parse("nanometres", out factor, out unit);
            Check.Equal(1e-9, factor, "incorrect factor returned from Prefixes.Parse()");
            Check.Equal("metres", unit, "incorrect unit returned from Prefixes.Parse()");
        }

        private static void TestToString(string varName, double expectedValue, string expectedString, IPhysicalQuantity l1)
        {
            Check.Equal(expectedValue, l1.Value, $"wrong value for {varName}: {l1.Value}");
            string s = l1.ToString();
            Check.Equal(expectedString, s, "wrong value for {varName}.ToString()");
            Console.WriteLine($"{varName}={s}");
        }

        static void TestTime()
        {
            Console.WriteLine("TestTime ------------------------");
            var t1 = 66.JulianYears() + 21.Weeks() + 16.Hours() + 29.Minutes() + 13.Seconds();
            TestToString("t1", 2095561753.0, "2.09556175E+09 s", t1);
            string s = t1.ToString(TimeUnits.Minutes, MetricUnits.Seconds);
            Check.Equal("34926029 min 13.0000001 s", s, "wrong value for l1.ToString()");
        }

        private static void TestBritishUnits()
        {
            Console.WriteLine("TestBritishUnits ------------------------");
            Length l1 = 5.Feet() + 4.Inches();
            TestToString("l1", 1.6256, "1.6256 m", l1);

            string s = l1.ToString(BritishUnits.Feet, BritishUnits.Inches);
            Check.Equal("5 ft 4 in", s, "wrong value for l1.ToString()");

            Length l2 = 26.Miles() + 385.Yards();
            TestToString("l2", 42194.988, "42.194988 km", l2);
            s = l2.ToString(BritishUnits.Miles, BritishUnits.Yards);
            Check.Equal("26 mi 385 yd", s, "wrong value for l2.ToString()");

            Mass m1 = 9.Stones() + 11.Pounds();
            TestToString("m1", 62.14215469, "62.1421547 kg", m1);
            s = m1.ToString(BritishUnits.Stones, BritishUnits.Pounds);
            Check.Equal("9 st 11 lb", s, "wrong value for m1.ToString()");

            Length l3 = new BritishUnits().DoParse("5 ft 4 in");
            TestToString("l3", 1.6256, "1.6256 m", l3);
        }

        private static void TestDynamics()
        {
            Console.WriteLine("TestDynamics ------------------------");
            TestVelocity();

            TestAcceleration();

            TestMomentum();

            TestForce();

            DynamicsExample1();
            DynamicsExample2();
            CricketBallTest();

            CircularMotionTest();

            StarshipTestWithDoubles();

            StarshipTest();

            Gravity();
        }

        private static void TestVelocity()
        {
            Console.WriteLine("TestVelocity ------------------------");
            // velocity = distance / time
            // Usain Bolt
            var l = 100.Metres();
            var t = 9.58.Seconds();
            var v = l / t;
            TestToString("v", 10.4384134, "10.4384134 m/s", v);
            // check v = 44.72 km/h
            string s = v.ToString(MetricUnits.KilometresPerHour);
            Check.Equal("37.5782881 kph", s, "wrong value for v.ToString()");
            s = v.ToString(BritishUnits.MilesPerHour);
            Check.Equal("23.3501044 mph", s, "wrong value for v.ToString(BritishUnits.MilesPerHour)");
            // distance = velocity * time
            l = v * 1.Hours();
            s = l.ToString(MetricUnits.Kilometres);
            Check.Equal("37.5782881 km", s, "wrong value for l.ToString()");
        }

        private static void TestAcceleration()
        {
            Console.WriteLine("TestAcceleration ------------------------");
            // acceleration = velocity / time
            // Accelerating flea
            Velocity v = 1.5.MetresPerSecond();
            Time t = 1.MilliSeconds();
            Acceleration a = v / t;
            // check a = 1500 m/s^2, 150G
            TestToString("a", 1500, "1500 m/s²", a);

            // acceleration = distance / time^2
            Length l = 100.Metres();
            t = 6.Seconds();
            a = l / t.Squared();
            TestToString("a", 2.7777777777777777, "2.77777778 m/s²", a);

            // velocity v of a uniformaly accelerated object
            // v = u + at
            // where 
            // u is the initial velocity
            // a is the acceleration
            // t is time
            Velocity u = 54.KilometresPerHour();
            a = 2.MetresPerSecondSquared();
            t = 2.5.Seconds();
            v = u + a * t;
            TestToString("v", 20, "20 m/s", v);

            // a = (v - u) / t
            u = 10.MetresPerSecond();
            v = 25.MetresPerSecond();
            t = 3.Seconds();
            a = (v - u) / t;
            TestToString("a", 5, "5 m/s²", a);

            // t = (v - u) / a
            u = 5.MetresPerSecond();
            v = 25.MetresPerSecond();
            a = 1.MetresPerSecondSquared();
            t = (v - u) / a;
            TestToString("t", 20, "20 s", t);

            // Distance travelled by a uniformally accelerating object:
            // s = ut + 1/2 at^2
            l = u * t + a * t * t / 2.0;
            TestToString("l", 300.0, "300 m", l);

            // When a cricket ball is thrown upwards, the height s reached at any instant t is given by
            //     s = ut — 1/2 gt^2
            // where
            // u is the initial velocity
            // g is the acceleration due to gravity
            u = 25.MetresPerSecond();
            t = 3.Seconds();
            Acceleration g = 9.80665.MetresPerSecondSquared();
            l = u * t - 0.5 * g * t * t;
            TestToString("l", 30.870075, "30.870075 m", l);
        }

        private static void TestMomentum()
        {
            Console.WriteLine("TestMomentum ------------------------");
            // Momentum = mass * velocity
            // An object of mass 20 kg moving with a velocity of 10 m/s has a momentum of 200 kg m/s
            Momentum m = 20.Kilograms() * 10.MetresPerSecond();
            TestToString("m", 200, "200 kg⋅m/s", m);
        }

        private static void TestForce()
        {
            Console.WriteLine("TestForce ------------------------");
            // If a mass of 200 g is acted upon by a force F which produces an acceleration a of 4 m s^-2,
            // then F = ma = 0.8 N
            Mass m = 200.Grams();
            Acceleration a = 4.MetresPerSecondSquared();
            Force f = m * a;
            TestToString("f", 0.8, "0.8 N", f);

            // A force of 20 kgf pulls a sledge of mass 50 kg and overcomes a constant frictional force of 4 kgf.
            // What is the acceleration of the sledge?
            // Resultant force, F, = 20 kgf - 4 kgf = 16 kgf.
            // To change this to units of newtons, use 1 kgf = 9.8 N.
            var kgf = 9.8.Newtons();
            f = 16 * kgf;
            m = 50.Kilograms();
            a = f / m;
            TestToString("a", 3.136, "3.136 m/s²", a);

            // A person of mass 50 kg who is jumping from a height of 5 metres will land on the ground
            // with a velocity = √2gh = √ 2 x 9.8 x 5 = 9.9 m/s , assuming g = 9.8 m/s.
            Length h = 5.Metres();
            Acceleration g = 9.80665.MetresPerSecondSquared();
            Velocity v = Functions.Sqrt(2 * g * h);
            TestToString("v", 9.90285312, "9.90285312 m/s", v);

            // If he does not flex his knees on landing, he will be brought to rest very quickly, say in
            // 1/10th second.  The force F acting is then given by momentum change/time = 50 * 9.9 / 0.1 = 4951 N
            Momentum mm = m * v;
            Time t = 0.1.Seconds();
            f = mm / t;
            TestToString("f", 4951.426562113185, "4951.42656 N", f);
        }

        private static void DynamicsExample1()
        {
            Console.WriteLine("DynamicsExample1 ------------------------");
            // A car moving with a velocity of 54 km / h accelerates uniformly at the rate of 2 m s-2.
            // Calculate the distance travelled from the place where acceleration began to that where the
            // velocity reaches 72 km / h, and the time taken to cover this distance.

            Velocity u = 54.KilometresPerHour();
            Acceleration a = 2.MetresPerSecondSquared();
            Velocity v = 72.KilometresPerHour();
            // v^2 = u^2 + 2 as
            // therefore s = (v^2 - u^2)/2a
            Length s = (v * v - u * u) / (2 * a);
            TestToString("s", 43.75, "43.75 m", s);
            Time t = (v - u) / a;
            TestToString("t", 2.5, "2.5 s", t);
        }

        private static void DynamicsExample2()
        {
            Console.WriteLine("DynamicsExample2 ------------------------");
            // A train travelling at 72 km/h undergoes a uniform retardation of 2 m s^2 when brakes are
            // applied. Find the time taken to come to rest and the distance travelled from the place where
            // the  brakes were applied.
            Velocity u = 72.KilometresPerHour();
            Acceleration a = -2.MetresPerSecondSquared();
            Velocity v = 0.KilometresPerHour();
            Time t = (v - u) / a;
            TestToString("t", 10.0, "10 s", t);
            Length s = u * t + a * t * t / 2.0;
            TestToString("s", 100.0, "100 m", s);
        }

        private static void CricketBallTest()
        {
            Console.WriteLine("CricketBallTest ------------------------");
            // Suppose a cricket ball was thrown straight up with an initial velocity, u, of 30 ms - 1.
            // The time taken to reach the top of its motion can be obtained from the equation
            // v = u + at.
            // The velocity, v, at the top is zero; and since u = 30 m and a = —9.8 or 10 ms 2(approx),
            // we have  30 - 10t = 0.
            // Therefore t = 30 / 10 = 3s
            // The highest distance reached is thus given by
            // d = ut + 1 / 2 at ^ 2 = 30x3 - 5x3 ^ 2 = 45 m.
            var u = 30.MetresPerSecond();
            var g = 9.80665.MetresPerSecondSquared();
            var t = u / g;
            TestToString("t", 3.05914864, "3.05914864 s", t);
            var d = u * t + -g * t * t / 2.0;
            TestToString("d", 45.8872296, "45.8872296 m", d);
        }

        private static void CircularMotionTest()
        {
            Console.WriteLine("CircularMotionTest ------------------------");
            //Angular velocity is usually expressed in 'radians per second'
            AngularVelocity w = Math.PI * 2.Radians() / 0.1.Seconds();
            TestToString("w", 62.831853071795862, "62.83185307179586 rad⋅s⁻¹", w);
            Frequency f = w / (Math.PI * 2.Radians());
            TestToString("f", 10.0, "10 Hz", f);
            //An object moving in a circle of radius r with a constant speed v has a constant acceleration towards the centre equal to v^2 / r
            //Or rw^2
            //Where w is the angular velocity
            Length r = 2.Metres();
            Acceleration a = r * w.Squared();
            TestToString("a", 7895.6835208714865, "7895.68352 m/s²", a);

            // A pendulum bob of mass 1 kg is attached to a string 1 metre long and made to revolve
            // in a horizontal circle of radius 60 cm.
            // Find the period of the motion and the tension of the string.
            Mass m = 1.Kilograms();
            Acceleration g = 1.AccelerationOfGravity();
            Length l = 1.Metres();
            r = 60.Centimetres();
            // theta is the angle of inclination of the string:
            Angle θ = Math.Acos(r/l).Radians();
            // If T is the tension 
            //  T cos θ = m.v² / r  for motion in a circle
            //  T sin θ = m.g       for the vertical motion
            // ∴ T = m.g / sin θ
            Force T = m * g / Functions.Sin(θ);
            TestToString("T", 12.258312499999999, "12.2583125 N", T);
            // So v = √ r T cos θ / m
            Velocity v = Functions.Sqrt((r * T * Functions.Cos(θ)) / m);
            TestToString("v", 2.10071238, "2.10071238 m/s", v);
            // ∴ angular velocity ω = v/r
            w = v / r;
            // ∴ Period t = 2𝜋 / w
            Time t = (2 * Math.PI).Radians() / w;
            TestToString("t", 1.79458703, "1.79458703 s", t);

            // The period of a simple pendulum t = 2𝜋 √ l/g (for small angles)
            // So what is the period of a pendulum of length 2m?
            l = 2.Metres();
            t = (2 * Math.PI) * Functions.Sqrt(l/g);
            TestToString("t", 2.83749123, "2.83749123 s", t);
            // How long does a pendulum have to be to have a period of 1 sec?
            t = 1.Seconds();
            l = (t.Squared() * g) / (4 * Math.PI);
            TestToString("l", 0.780388411, "78.0388411 cm", l);
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static void StarshipTest()
        {
            Console.WriteLine("StarshipTest ------------------------");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Mass EmptyMass = 120000.Kilograms();
                Mass PropellantMass = 1200000.Kilograms();
                Mass WetMass = EmptyMass + PropellantMass;
                Force Thrust = 12000000.Newtons();
                Time SpecificImpulse = 380.Seconds();
                Velocity ExhaustVelocity = 3700.MetresPerSecond();

                // Tsiolkovsky rocket equation
                Velocity DeltaV = ExhaustVelocity * Math.Log(WetMass / EmptyMass);

//                Console.WriteLine($"Starship velocity = {DeltaV} ({DeltaV.ToString(BritishUnits.MilesPerHour)})");

                // do the same calculation by integration:
                var MassFlowRatePerEngine = 931.2.KilogramsPerSecond();
                int NumberOfEngines = 6;
                var MassFlowRate = MassFlowRatePerEngine * NumberOfEngines;
                var DeltaT = 0.001.Seconds();
                Mass DeltaM = MassFlowRate * DeltaT;
                var CurrentPropellantMass = PropellantMass;
                Time CurrentTime = 0.Seconds();
                Velocity CurrentVelocity = 0.MetresPerSecond();
                while (CurrentPropellantMass > new Mass(0.0))
                {
                    Mass CurrentMass = EmptyMass + CurrentPropellantMass;
                    // integration m dv/dt = -ve dm / dt
                    DeltaV = ExhaustVelocity * DeltaM / CurrentMass;
                    CurrentTime += DeltaT;
                    CurrentVelocity += DeltaV;
                    CurrentPropellantMass -= DeltaM;
                }

                //Console.WriteLine($"Burn Time={CurrentTime}");
                //Console.WriteLine($"Starship velocity = {CurrentVelocity} ({CurrentVelocity.ToString(BritishUnits.MilesPerHour)})");
            }
            stopWatch.Stop();
            Console.WriteLine($"Elapsed time = {stopWatch.Elapsed}");
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static void StarshipTestWithDoubles()
        {
            Console.WriteLine("StarshipTestWithDoubles ------------------------");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                double EmptyMass = 120000.0;
                double PropellantMass = 1200000.0;
                double WetMass = EmptyMass + PropellantMass;
                double ExhaustVelocity = 3700.0;

                // Tsiolkovsky rocket equation
                double DeltaV = ExhaustVelocity * Math.Log(WetMass / EmptyMass);

//                Console.WriteLine($"Starship velocity = {DeltaV}");

                // do the same calculation by integration:
                double MassFlowRatePerEngine = 931.2;
                int NumberOfEngines = 6;
                double MassFlowRate = MassFlowRatePerEngine * NumberOfEngines;
                double DeltaT = 0.001;
                double DeltaM = MassFlowRate * DeltaT;
                double CurrentPropellantMass = PropellantMass;
                double CurrentTime = 0;
                double CurrentVelocity = 0;
                while (CurrentPropellantMass > 0.0)
                {
                    double CurrentMass = EmptyMass + CurrentPropellantMass;
                    // integration m dv/dt = -ve dm / dt
                    DeltaV = ExhaustVelocity * DeltaM / CurrentMass;
                    CurrentTime += DeltaT;
                    CurrentVelocity += DeltaV;
                    CurrentPropellantMass -= DeltaM;
                }
                //Console.WriteLine($"Burn Time={CurrentTime}");
                //Console.WriteLine($"Starship velocity = {CurrentVelocity}");
            }
            stopWatch.Stop();
            Console.WriteLine($"Elapsed time = {stopWatch.Elapsed}");
        }

        static void Gravity()
        {
            Console.WriteLine("GravityTest ------------------------");
            // Newton's law of universal gravitation states that every mass in the universe
            // attracts every other mass in the universe with a force that is proportional to the product of their masses, and inversely proportional to the square of the distance between them.
            // F=G*m1*m2/r^2
            // F=gravitational force· G=gravitational constant· m=mass· r=distance between masses
            // G = 6.67430 × 10-11 m3 kg-1 s-2
#if PREFER_RUNTIME_CHECKS
            var G = 6.6743e-11 * 1.CubicMetres()/(1.Kilograms()*1.Seconds()*1.Seconds());
#else
            var G = new PhysicalQuantity(6.6743e-11, new Dimensions(-1,3,-2));
#endif
            Mass m1 = 5.972e24.Kilograms(); // mass of earth
            Mass m2 = 7.34767309e22.Kilograms(); // mass of moon
            Length r = 384400.Kilometres(); // earth to moon
            // for some reason the next line is ambiguous without the cast
            Force f = G * m1 * m2 / (IPhysicalQuantity)(r * r);
            TestToString("f", 1.9820225456526813E+20, "1.98202255E+20 N", f);

            // The barycentric gravitational acceleration at a point in space is given by:
            // g = (G * M / r ^ 2)rh
            //      where:
            // M is the mass of the attracting object,
            // rh is the unit vector from center - of - mass of the attracting object to the center-of - mass of the object being
            // accelerated,
            // r is the distance between the two objects,
            // and G is the gravitational constant.
            //When this calculation is done for objects on the surface of the Earth, or aircraft that rotate with the Earth,
            //one has to account for the fact that the Earth is rotating and the centrifugal acceleration has to be subtracted
            //from this.For example, the equation above gives the acceleration at 9.820 m / s2,
            //when GM = 3.986×10 ^ 14 m3 / s2, and R = 6.371×10 ^ 6 m.
            r = 6.371e6.Metres();
            Acceleration g = G * m1 / (IPhysicalQuantity)(r * r);
            TestToString("g", 9.8199734262246867, "9.81997343 m/s²", g);

            //The centripetal radius is r = R cos(φ), and the centripetal time unit is approximately(day / 2π),
            //reduces this, for r = 5×10 ^ 6 metres, to 9.79379 m / s2, which is closer to the observed value.
        }
     }
}
