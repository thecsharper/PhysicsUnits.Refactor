using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Force")]
    public class ForceTests : TestBase
    {
        [Fact]
        public void Force_Tests()
        {
            // If a mass of 200 g is acted upon by a force F which produces an acceleration a of 4 m s^-2,
            // then F = ma = 0.8 N
            Mass m = 200.Grams();
            Acceleration a = 4.MetresPerSecondSquared();
            Force f = m * a;
            TestString("f", 0.8, "0.8 N", f);

            // A force of 20 kgf pulls a sledge of mass 50 kg and overcomes a constant frictional force of 4 kgf.
            // What is the acceleration of the sledge?
            // Resultant force, F, = 20 kgf - 4 kgf = 16 kgf.
            // To change this to units of newtons, use 1 kgf = 9.8 N.
            var kgf = 9.8.Newtons();
            f = 16 * kgf;
            m = 50.Kilograms();
            a = f / m;
            TestString("a", 3.136, "3.136 m/s²", a);

            // A person of mass 50 kg who is jumping from a height of 5 metres will land on the ground
            // with a velocity = √2gh = √ 2 x 9.8 x 5 = 9.9 m/s , assuming g = 9.8 m/s.
            Length h = 5.Metres();
            Acceleration g = 9.80665.MetresPerSecondSquared();
            Velocity v = Functions.Sqrt(2 * g * h);
            TestString("v", 9.90285312, "9.90285312 m/s", v);

            // If he does not flex his knees on landing, he will be brought to rest very quickly, say in
            // 1/10th second.  The force F acting is then given by momentum change/time = 50 * 9.9 / 0.1 = 4951 N
            Momentum mm = m * v;
            Time t = 0.1.Seconds();
            f = mm / t;
            TestString("f", 4951.426562113185, "4951.42656 N", f);
        }
    }
}
