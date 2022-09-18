using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Dynamics")]
    public class DynamicsTests : TestBase
    {
        [Fact]
        public void Dynamics_Car_Tests()
        {
            // A car moving with a velocity of 54 km / h accelerates uniformly at the rate of 2 m s-2.
            // Calculate the distance travelled from the place where acceleration began to that where the
            // velocity reaches 72 km / h, and the time taken to cover this distance.

            Velocity u = 54.KilometresPerHour();
            Acceleration a = 2.MetresPerSecondSquared();
            Velocity v = 72.KilometresPerHour();
            // v^2 = u^2 + 2 as
            // therefore s = (v^2 - u^2)/2a
            Length s = (v * v - u * u) / (2 * a);
            TestString("s", 43.75, "43.75 m", s);
            Time t = (v - u) / a;
            TestString("t", 2.5, "2.5 s", t);
        }

        [Fact]
        public void Dynamics_Train_Tests()
        {
            // A train travelling at 72 km/h undergoes a uniform retardation of 2 m s^2 when brakes are
            // applied. Find the time taken to come to rest and the distance travelled from the place where
            // the  brakes were applied.
            Velocity u = 72.KilometresPerHour();
            Acceleration a = -2.MetresPerSecondSquared();
            Velocity v = 0.KilometresPerHour();
            Time t = (v - u) / a;
            TestString("t", 10.0, "10 s", t);
            Length s = u * t + a * t * t / 2.0;
            TestString("s", 100.0, "100 m", s);
        }

    }
}
