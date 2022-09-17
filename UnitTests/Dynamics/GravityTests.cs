using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Gravity")]
    public class GravityTests : TestBase
    {
        [Fact]
        public void Gravity_Tests()
        {
            // Newton's law of universal gravitation states that every mass in the universe
            // attracts every other mass in the universe with a force that is proportional to the product of their masses, and inversely proportional to the square of the distance between them.
            // F=G*m1*m2/r^2
            // F=gravitational force· G=gravitational constant· m=mass· r=distance between masses
            // G = 6.67430 × 10-11 m3 kg-1 s-2
#if PREFER_RUNTIME_CHECKS
            var G = 6.6743e-11 * 1.CubicMetres()/(1.Kilograms()*1.Seconds()*1.Seconds());
#else
            var G = new PhysicalQuantity(6.6743e-11, new KMB.Library.Units.Dimensions(-1, 3, -2));
#endif
            Mass m1 = 5.972e24.Kilograms(); // mass of earth
            Mass m2 = 7.34767309e22.Kilograms(); // mass of moon
            Length r = 384400.Kilometres(); // earth to moon
            
            // for some reason the next line is ambiguous without the cast
            Force f = G * m1 * m2 / (IPhysicalQuantity)(r * r);
            TestString("f", 1.9820225456526813E+20, "1.98202255E+20 N", f);

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
            TestString("g", 9.8199734262246867, "9.81997343 m/s²", g);

            //The centripetal radius is r = R cos(φ), and the centripetal time unit is approximately(day / 2π),
            //reduces this, for r = 5×10 ^ 6 metres, to 9.79379 m / s2, which is closer to the observed value.
        }
    }
}
