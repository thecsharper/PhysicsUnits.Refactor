using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using System;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "CircularMotion")]
    public class CircularMotionTests : TestBase
    {
        [Fact]
        public void CircularMotion_Tests()
        {
            //Angular velocity is usually expressed in 'radians per second'
            AngularVelocity w = Math.PI * 2.Radians() / 0.1.Seconds();
            TestString("w", 62.831853071795862, "62.83185307179586 rad⋅s⁻¹", w);
            Frequency f = w / (Math.PI * 2.Radians());
            TestString("f", 10.0, "10 Hz", f);
            //An object moving in a circle of radius r with a constant speed v has a constant acceleration towards the centre equal to v^2 / r
            //Or rw^2
            //Where w is the angular velocity
            Length r = 2.Metres();
            Acceleration a = r * w.Squared();
            TestString("a", 7895.6835208714865, "7895.68352 m/s²", a);

            // A pendulum bob of mass 1 kg is attached to a string 1 metre long and made to revolve
            // in a horizontal circle of radius 60 cm.
            // Find the period of the motion and the tension of the string.
            Mass m = 1.Kilograms();
            Acceleration g = 1.AccelerationOfGravity();
            Length l = 1.Metres();
            r = 60.Centimetres();
            // theta is the angle of inclination of the string:
            Angle θ = Math.Acos(r / l).Radians();
           
            // If T is the tension 
            //  T cos θ = m.v² / r  for motion in a circle
            //  T sin θ = m.g       for the vertical motion
            // ∴ T = m.g / sin θ
            Force T = m * g / Functions.Sin(θ);
            TestString("T", 12.258312499999999, "12.2583125 N", T);
            // So v = √ r T cos θ / m
            Velocity v = Functions.Sqrt((r * T * Functions.Cos(θ)) / m);
            TestString("v", 2.10071238, "2.10071238 m/s", v);
            
            // ∴ angular velocity ω = v/r
            w = v / r;
            // ∴ Period t = 2𝜋 / w
            Time t = (2 * Math.PI).Radians() / w;
            TestString("t", 1.79458703, "1.79458703 s", t);

            // The period of a simple pendulum t = 2𝜋 √ l/g (for small angles)
            // So what is the period of a pendulum of length 2m?
            l = 2.Metres();
            t = (2 * Math.PI) * Functions.Sqrt(l / g);
            TestString("t", 2.83749123, "2.83749123 s", t);
            // How long does a pendulum have to be to have a period of 1 sec?
            t = 1.Seconds();
            l = (t.Squared() * g) / (4 * Math.PI);
            TestString("l", 0.780388411, "78.0388411 cm", l);
        }
    }
}
