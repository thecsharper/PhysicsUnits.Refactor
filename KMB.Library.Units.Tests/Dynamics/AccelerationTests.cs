using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Acceleration")]
    public class AccelerationTests : TestBase
    {
        [Fact]
        public void Acceleration_Tests()
        {
            // acceleration = velocity / time
            // Accelerating flea
            Velocity v = 1.5.MetresPerSecond();
            Time t = 1.MilliSeconds();
            Acceleration a = v / t;
            // check a = 1500 m/s^2, 150G
            TestString("a", 1500, "1500 m/s²", a);

            // acceleration = distance / time^2
            Length l = 100.Metres();
            t = 6.Seconds();
            a = l / t.Squared();
            TestString("a", 2.7777777777777777, "2.77777778 m/s²", a);

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
            TestString("v", 20, "20 m/s", v);

            // a = (v - u) / t
            u = 10.MetresPerSecond();
            v = 25.MetresPerSecond();
            t = 3.Seconds();
            a = (v - u) / t;
            TestString("a", 5, "5 m/s²", a);

            // t = (v - u) / a
            u = 5.MetresPerSecond();
            v = 25.MetresPerSecond();
            a = 1.MetresPerSecondSquared();
            t = (v - u) / a;
            TestString("t", 20, "20 s", t);

            // Distance travelled by a uniformally accelerating object:
            // s = ut + 1/2 at^2
            l = u * t + a * t * t / 2.0;
            TestString("l", 300.0, "300 m", l);

            // When a cricket ball is thrown upwards, the height s reached at any instant t is given by
            //     s = ut — 1/2 gt^2
            // where
            // u is the initial velocity
            // g is the acceleration due to gravity
            u = 25.MetresPerSecond();
            t = 3.Seconds();
            Acceleration g = 9.80665.MetresPerSecondSquared();
            l = u * t - 0.5 * g * t * t;
            TestString("l", 30.870075, "30.870075 m", l);
        }
    }
}
