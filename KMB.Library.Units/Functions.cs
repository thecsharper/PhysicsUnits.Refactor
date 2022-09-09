using System;

namespace KMB.Library.Units
{
    public static class Functions
    {
        public static Velocity Sqrt(VelocitySquared velocitySquared)
        {
            double v = velocitySquared.Value;
            return new Velocity(Math.Sqrt(v));
        }

        public static Time Sqrt(TimeSquared timeSquared)
        {
            double v = timeSquared.Value;
            return new Time(Math.Sqrt(v));
        }
        
        public static AngularVelocity Sqrt(AngularVelocitySquared angluarVelocitySquared)
        {
            double v = angluarVelocitySquared.Value;
            return new AngularVelocity(Math.Sqrt(v));
        }

        public static double Sin(Angle a)
        {
            return Math.Sin(a.Value);
        }

        public static double Cos(Angle a)
        {
            return Math.Cos(a.Value);
        }
    }
}
