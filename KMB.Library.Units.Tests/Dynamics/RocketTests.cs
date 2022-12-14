using Xunit;

using KMB.Library.Units.Metric;
using KMB.Library.Units;
using System.Diagnostics;
using System;

namespace UnitTests.Fundamental.Dynamics
{
    [Trait("Category", "Rocket")]
    public class RocketTests : TestBase
    {
        //[Fact]
        //public void Rocket_Tests()
        //{
        //    var stopWatch = new Stopwatch();
        //    stopWatch.Start();

        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Mass EmptyMass = 120000.Kilograms();
        //        Mass PropellantMass = 1200000.Kilograms();
        //        Mass WetMass = EmptyMass + PropellantMass;
        //        Force Thrust = 12000000.Newtons();
        //        Time SpecificImpulse = 380.Seconds();
        //        Velocity ExhaustVelocity = 3700.MetresPerSecond();

        //        // Tsiolkovsky rocket equation
        //        Velocity DeltaV = ExhaustVelocity * Math.Log(WetMass / EmptyMass);

        //        // do the same calculation by integration:
        //        var MassFlowRatePerEngine = 931.2.KilogramsPerSecond();
        //        int NumberOfEngines = 6;
        //        var MassFlowRate = MassFlowRatePerEngine * NumberOfEngines;
        //        var DeltaT = 0.001.Seconds();
        //        Mass DeltaM = MassFlowRate * DeltaT;
        //        var CurrentPropellantMass = PropellantMass;
        //        Time CurrentTime = 0.Seconds();
        //        Velocity CurrentVelocity = 0.MetresPerSecond();
                
        //        while (CurrentPropellantMass > new Mass(0.0))
        //        {
        //            Mass CurrentMass = EmptyMass + CurrentPropellantMass;
        //            // integration m dv/dt = -ve dm / dt
        //            DeltaV = ExhaustVelocity * DeltaM / CurrentMass;
        //            CurrentTime += DeltaT;
        //            CurrentVelocity += DeltaV;
        //            CurrentPropellantMass -= DeltaM;
        //        }
        //    }

        //    stopWatch.Stop();
        //}

        [Fact]
        public void Rocket_Doubles_Tests()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                double EmptyMass = 120000.0;
                double PropellantMass = 1200000.0;
                double WetMass = EmptyMass + PropellantMass;
                double ExhaustVelocity = 3700.0;

                // Tsiolkovsky rocket equation
                double DeltaV = ExhaustVelocity * Math.Log(WetMass / EmptyMass);

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
            }

            stopWatch.Stop();
        }
    }
}
