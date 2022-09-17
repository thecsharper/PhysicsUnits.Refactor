using Xunit;

using KMB.Library.Units.Metric;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "CricketBall")]
    public class CricketBallTests : TestBase
    {
        [Fact]
        public void CricketBall_Tests()
        {
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
            TestString("t", 3.05914864, "3.05914864 s", t);
            var d = u * t + -g * t * t / 2.0;
            TestString("d", 45.8872296, "45.8872296 m", d);
        }
    }
}
