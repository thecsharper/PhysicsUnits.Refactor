using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using KMB.Library.Units.British;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "String")]
    public class StringTests : TestBase
    {
        [Fact]
        public void Kilograms_Tests()
        {
            var m = 63.5029.Kilograms();
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

            var l = 1.6256.Metres();
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

        [Fact]
        public void Grams_Tests()
        {
            var m = 163.Grams();
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

            var l = 1.6256.Metres();
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

        [Fact]
        public void Tonnes_Tests()
        {
            var m = 16.Tonnes();
            Check.Equal("16 t", m.ToString(), "wrong value for m.ToString()");
            Check.Equal("16000 kg", m.ToString(UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(Standard)");
            Check.Equal("16 t", m.ToString(UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(BestFit)");
            Check.Equal("16 t", m.ToString(UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(Multiple)");
            Check.Equal("16000 kg", m.ToString(MetricUnits.Kilograms, MetricUnits.Grams), "wrong value for m.ToString(kg,g)");

            Check.Equal("35273.9619 lb", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard), "wrong value for m.ToString(British,Standard)");
            Check.Equal("15.7473044 ton", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit), "wrong value for m.ToString(British,BestFit)");
            Check.Equal("15 ton 14 cwt 7 st 7 lb 15.3911933 oz", m.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple), "wrong value for m.ToString(British,Multiple)");
            Check.Equal("35273 lb 15.3911933 oz", m.ToString(BritishUnits.Pounds, BritishUnits.Ounces), "wrong value for m.ToString(lb,oz)");

            var l = 1.6256.Metres();
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

        [Fact]
        public void Metres_Tests()
        {
            var l = 1.6256.Metres();
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
    }
}
