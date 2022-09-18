using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using System;
using FluentAssertions;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "Length")]
    public class LengthTests : TestBase
    {
        [Fact]
        public void Length_Tests()
        {
            TestString("l0", 3.4, "3.4 m", new Length(3.4));

            // Basic maths in metres
            var l1 = 4.2.Metres();
            TestString("l1", 4.2, "4.2 m", l1);

            double f1 = l1.InMetres();
            Check.Equal(4.2, f1, "wrong value for l1.InMetres()");

            var l2 = 4.2.Kilometres();
            TestString("l2", 4200, "4.2 km", l2);

            var l3 = 4.2.Centimetres();
            TestString("l3", 0.042, "4.2 cm", l3);

            var l4 = 4.2.Millimetres();
            TestString("l4", 0.0042, "4.2 mm", l4);

            var l5 = l1 + l4;
            TestString("l5", 4.2042, "4.2042 m", l5);

            var l6 = l1 * 7;
            TestString("l6", 29.4, "29.4 m", l6);

            var l7 = 9 * l1;
            TestString("l7", 37.8, "37.8 m", l7);

            var l8 = l1 / 2.3;
            TestString("l8", 1.82608695652174, "1.82608696 m", l8);

            var l9 = l1 / 10;
            TestString("l9", 0.42, "42 cm", l9);

            var five = new Dimensionless(5);
            var l10 = l1 * five;
            TestString("l10", 21, "21 m", l10);

            var d1 = l5 / l6;
            Action act = () => TestString("d1", 0.143, "0.143", d1);
            act.Should().Throw<Exception>();

            var a1 = l1 * l5;
            TestString("a1", 17.65764, "17.65764 m²", a1);

            var a2 = l1 * l2;
            TestString("a2", 17640, "1.764 ha", a2);

#if PREFER_RUNTIME_CHECKS
            PhysicalQuantity q1 = d1 / l1;
            TestToString("q1", 0.034047619047619042, "0.03404761904761904 m⁻¹", q1);
#endif

            // Convert from Physical quantity back to length:
            var q2 = new PhysicalQuantity(2.632, KMB.Library.Units.Dimensions.Length);
            var l11 = q2;
            Action acta = () => TestString("l11", 2.632, "2.632 m", l11);
            acta.Should().Throw<Exception>();

            var m1 = l1;
            var m2 = 5.3.Metres();
            var m3 = 6.4.Metres();
            var m4 = m1 + m2 + m3;
            Check.Equal(15.9, m4.Value, "wrong value for m4");
            Check.Equal("15.9 m", m4.ToString(), "ToString() returns wrong value for m4");

            var m5 = m3 - m2;
            Check.Equal(1.1, m5.Value, "wrong value for m4");
            Check.Equal("1.1 m", m5.ToString(), "ToString() returns wrong value for m4");

            var c2 = m1 / m2;
            Check.Equal(0.7924528301886793, c2.Value, "wrong value for c2");

            // Comparisons
            var mb1 = (m1 > m2); Check.False(mb1, "(m1 > m2) returns wrong value");
            var mb2 = (m1 >= m2); Check.False(mb2, "(m1 >= m2) returns wrong value");
            var mb3 = (m1 == m2); Check.False(mb3, "(m1 == m2) returns wrong value");
            var mb4 = (m1 != m2); Check.True(mb4, "(m1 != m2) returns wrong value");
            var mb5 = (m1 <= m2); Check.True(mb5, "(m1 <= m2) returns wrong value");
            var mb6 = (m1 < m2); Check.True(mb6, "(m1 < m2) returns wrong value");
        }
    }
}
