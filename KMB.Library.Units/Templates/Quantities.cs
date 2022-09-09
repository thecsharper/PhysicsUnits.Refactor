using System;
using System.Runtime.CompilerServices;

namespace KMB.Library.Units
{
    // Generated from Dimensions.xml
    public readonly partial struct Dimensionless: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Dimensionless; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Dimensionless(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Dimensionless(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Dimensionless)
				throw new Exception("Invalid conversion from PhysicalQuantity to Dimensionless");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Dimensionless Parse(string s)
		{
		     Dimensionless q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Dimensionless Parse(string s, UnitsSystem system)
		{
		     Dimensionless q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Dimensionless q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new Dimensionless(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Dimensionless q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new Dimensionless(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Dimensionless v1, Dimensionless v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Dimensionless v1, Dimensionless v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator+(Dimensionless v1, Dimensionless v2)
        {
            return new Dimensionless(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator-(Dimensionless v1, Dimensionless v2)
        {
            return new Dimensionless(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator-(Dimensionless v)
        {
            return new Dimensionless(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(Dimensionless v1, int v2)
        {
            return new Dimensionless(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(Dimensionless v1, double v2)
        {
            return new Dimensionless(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(double v1, Dimensionless v2)
        {
            return new Dimensionless(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(Dimensionless v1, Dimensionless v2)
        {
            return new Dimensionless(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Dimensionless v1, int v2)
        {
            return new Dimensionless(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Dimensionless operator/(Dimensionless v1, double v2)
        {
            return new Dimensionless(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Dimensionless v1, Dimensionless v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }


#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Dimensionless v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Dimensionless v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Dimensionless / by Time gives Frequency 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator/(Dimensionless v1, Time v2)
        {
            return new Frequency(v1.Value / v2.Value);
        }
		// Dimensionless / by Frequency gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Dimensionless v1, Frequency v2)
        {
            return new Time(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct Mass: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Mass; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Mass(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Mass(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Mass)
				throw new Exception("Invalid conversion from PhysicalQuantity to Mass");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Mass Parse(string s)
		{
		     Mass q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Mass Parse(string s, UnitsSystem system)
		{
		     Mass q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Mass q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new Mass(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Mass q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new Mass(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Mass v1, Mass v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Mass v1, Mass v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Mass v1, Mass v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Mass v1, Mass v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Mass v1, Mass v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Mass v1, Mass v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Mass v1, Mass v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator+(Mass v1, Mass v2)
        {
            return new Mass(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator-(Mass v1, Mass v2)
        {
            return new Mass(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator-(Mass v)
        {
            return new Mass(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Mass v1, int v2)
        {
            return new Mass(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Mass v1, double v2)
        {
            return new Mass(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(double v1, Mass v2)
        {
            return new Mass(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Mass v1, Dimensionless v2)
        {
            return new Mass(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(Mass v1, int v2)
        {
            return new Mass(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Mass operator/(Mass v1, double v2)
        {
            return new Mass(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(Mass v1, Dimensionless v2)
        {
            return new Mass(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Mass v1, Mass v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Mass v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Mass v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Mass / by Volume gives Density 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator/(Mass v1, Volume v2)
        {
            return new Density(v1.Value / v2.Value);
        }
		// Mass / by Density gives Volume 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator/(Mass v1, Density v2)
        {
            return new Volume(v1.Value / v2.Value);
        }
		// Mass * by Velocity gives Momentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Mass v1, Velocity v2)
        {
            return new Momentum(v1.Value * v2.Value);
        }
		// Mass * by Acceleration gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Mass v1, Acceleration v2)
        {
            return new Force(v1.Value * v2.Value);
        }
		// Mass * by Area gives MomentOfInertia 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(Mass v1, Area v2)
        {
            return new MomentOfInertia(v1.Value * v2.Value);
        }
		// Mass * by VelocitySquared gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Mass v1, VelocitySquared v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// Mass / by Time gives MassFlowRate 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator/(Mass v1, Time v2)
        {
            return new MassFlowRate(v1.Value / v2.Value);
        }
		// Mass / by MassFlowRate gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Mass v1, MassFlowRate v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// Mass * by SpecificHeat gives ThermalCapacity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(Mass v1, SpecificHeat v2)
        {
            return new ThermalCapacity(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Length: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Length; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Length(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Length(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Length)
				throw new Exception("Invalid conversion from PhysicalQuantity to Length");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Length Parse(string s)
		{
		     Length q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Length Parse(string s, UnitsSystem system)
		{
		     Length q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Length q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new Length(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Length q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new Length(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Length v1, Length v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Length v1, Length v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Length v1, Length v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Length v1, Length v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Length v1, Length v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Length v1, Length v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Length v1, Length v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator+(Length v1, Length v2)
        {
            return new Length(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator-(Length v1, Length v2)
        {
            return new Length(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator-(Length v)
        {
            return new Length(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Length v1, int v2)
        {
            return new Length(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Length v1, double v2)
        {
            return new Length(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(double v1, Length v2)
        {
            return new Length(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Length v1, Dimensionless v2)
        {
            return new Length(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Length v1, int v2)
        {
            return new Length(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Length operator/(Length v1, double v2)
        {
            return new Length(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Length v1, Dimensionless v2)
        {
            return new Length(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Length v1, Length v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Length v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Length v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Length * by Length gives Area 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator*(Length v1, Length v2)
        {
            return new Area(v1.Value * v2.Value);
        }
		// Length * by Area gives Volume 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Length v1, Area v2)
        {
            return new Volume(v1.Value * v2.Value);
        }
		// Length / by Time gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator/(Length v1, Time v2)
        {
            return new Velocity(v1.Value / v2.Value);
        }
		// Length / by Velocity gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Length v1, Velocity v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// Length * by AngularVelocity gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Length v1, AngularVelocity v2)
        {
            return new Velocity(v1.Value * v2.Value);
        }
		// Length * by Acceleration gives VelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(Length v1, Acceleration v2)
        {
            return new VelocitySquared(v1.Value * v2.Value);
        }
		// Length / by TimeSquared gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(Length v1, TimeSquared v2)
        {
            return new Acceleration(v1.Value / v2.Value);
        }
		// Length / by Acceleration gives TimeSquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator/(Length v1, Acceleration v2)
        {
            return new TimeSquared(v1.Value / v2.Value);
        }
		// Length * by AngularVelocitySquared gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(Length v1, AngularVelocitySquared v2)
        {
            return new Acceleration(v1.Value * v2.Value);
        }
		// Length * by Force gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Length v1, Force v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// Length * by Resistance gives Resistivity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(Length v1, Resistance v2)
        {
            return new Resistivity(v1.Value * v2.Value);
        }
		// Length * by Resistivity gives ResistanceTimesArea 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(Length v1, Resistivity v2)
        {
            return new ResistanceTimesArea(v1.Value * v2.Value);
        }
	#endregion
	#region powers
        public Area Squared()
        {
            return new Area(Value * Value);
        }
        public Volume Cubed()
        {
            return new Volume(Value * Value * Value);
        }
	#endregion

    }

	public readonly partial struct Time: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Time; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Time(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Time(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Time)
				throw new Exception("Invalid conversion from PhysicalQuantity to Time");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Time Parse(string s)
		{
		     Time q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Time Parse(string s, UnitsSystem system)
		{
		     Time q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Time q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new Time(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Time q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new Time(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Time v1, Time v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Time v1, Time v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Time v1, Time v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Time v1, Time v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Time v1, Time v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Time v1, Time v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Time v1, Time v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator+(Time v1, Time v2)
        {
            return new Time(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator-(Time v1, Time v2)
        {
            return new Time(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator-(Time v)
        {
            return new Time(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator*(Time v1, int v2)
        {
            return new Time(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator*(Time v1, double v2)
        {
            return new Time(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator*(double v1, Time v2)
        {
            return new Time(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator*(Time v1, Dimensionless v2)
        {
            return new Time(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Time v1, int v2)
        {
            return new Time(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Time operator/(Time v1, double v2)
        {
            return new Time(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Time v1, Dimensionless v2)
        {
            return new Time(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Time v1, Time v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Time v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Time v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Time * by Velocity gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Time v1, Velocity v2)
        {
            return new Length(v1.Value * v2.Value);
        }
		// Time * by AngularVelocity gives Angle 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(Time v1, AngularVelocity v2)
        {
            return new Angle(v1.Value * v2.Value);
        }
		// Time * by Time gives TimeSquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator*(Time v1, Time v2)
        {
            return new TimeSquared(v1.Value * v2.Value);
        }
		// Time * by Acceleration gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Time v1, Acceleration v2)
        {
            return new Velocity(v1.Value * v2.Value);
        }
		// Time * by Force gives Momentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Time v1, Force v2)
        {
            return new Momentum(v1.Value * v2.Value);
        }
		// Time * by Current gives ElectricCharge 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(Time v1, Current v2)
        {
            return new ElectricCharge(v1.Value * v2.Value);
        }
		// Time * by Power gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Time v1, Power v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// Time * by Frequency gives Dimensionless 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(Time v1, Frequency v2)
        {
            return new Dimensionless(v1.Value * v2.Value);
        }
		// Time * by MassFlowRate gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Time v1, MassFlowRate v2)
        {
            return new Mass(v1.Value * v2.Value);
        }
		// Time * by VolumeFlowRate gives Volume 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Time v1, VolumeFlowRate v2)
        {
            return new Volume(v1.Value * v2.Value);
        }
	#endregion
	#region powers
        public TimeSquared Squared()
        {
            return new TimeSquared(Value * Value);
        }
	#endregion

    }

	public readonly partial struct Current: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Current; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Current(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Current(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Current)
				throw new Exception("Invalid conversion from PhysicalQuantity to Current");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Current Parse(string s)
		{
		     Current q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Current Parse(string s, UnitsSystem system)
		{
		     Current q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Current q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new Current(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Current q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new Current(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Current v1, Current v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Current v1, Current v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Current v1, Current v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Current v1, Current v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Current v1, Current v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Current v1, Current v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Current v1, Current v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator+(Current v1, Current v2)
        {
            return new Current(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator-(Current v1, Current v2)
        {
            return new Current(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator-(Current v)
        {
            return new Current(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator*(Current v1, int v2)
        {
            return new Current(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator*(Current v1, double v2)
        {
            return new Current(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator*(double v1, Current v2)
        {
            return new Current(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator*(Current v1, Dimensionless v2)
        {
            return new Current(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator/(Current v1, int v2)
        {
            return new Current(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Current operator/(Current v1, double v2)
        {
            return new Current(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator/(Current v1, Dimensionless v2)
        {
            return new Current(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Current v1, Current v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Current v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Current v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Current * by Time gives ElectricCharge 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(Current v1, Time v2)
        {
            return new ElectricCharge(v1.Value * v2.Value);
        }
		// Current * by ElectricPotential gives Power 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(Current v1, ElectricPotential v2)
        {
            return new Power(v1.Value * v2.Value);
        }
		// Current * by Resistance gives ElectricPotential 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(Current v1, Resistance v2)
        {
            return new ElectricPotential(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct TemperatureChange: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.TemperatureChange; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public TemperatureChange(double v)
        {
            Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public TemperatureChange(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.TemperatureChange)
				throw new Exception("Invalid conversion from PhysicalQuantity to TemperatureChange");
            Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static TemperatureChange Parse(string s)
		{
		     TemperatureChange q = UnitsSystem.Parse(s);
			 return q;
		}

		public static TemperatureChange Parse(string s, UnitsSystem system)
		{
		     TemperatureChange q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out TemperatureChange q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new TemperatureChange(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out TemperatureChange q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new TemperatureChange(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(TemperatureChange v1, TemperatureChange v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(TemperatureChange v1, TemperatureChange v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator+(TemperatureChange v1, TemperatureChange v2)
        {
            return new TemperatureChange(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator-(TemperatureChange v1, TemperatureChange v2)
        {
            return new TemperatureChange(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator-(TemperatureChange v)
        {
            return new TemperatureChange(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator*(TemperatureChange v1, int v2)
        {
            return new TemperatureChange(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator*(TemperatureChange v1, double v2)
        {
            return new TemperatureChange(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator*(double v1, TemperatureChange v2)
        {
            return new TemperatureChange(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator*(TemperatureChange v1, Dimensionless v2)
        {
            return new TemperatureChange(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator/(TemperatureChange v1, int v2)
        {
            return new TemperatureChange(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static TemperatureChange operator/(TemperatureChange v1, double v2)
        {
            return new TemperatureChange(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator/(TemperatureChange v1, Dimensionless v2)
        {
            return new TemperatureChange(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(TemperatureChange v1, TemperatureChange v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(TemperatureChange v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(TemperatureChange v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// TemperatureChange * by ThermalCapacity gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(TemperatureChange v1, ThermalCapacity v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct AmountOfSubstance: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.AmountOfSubstance; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AmountOfSubstance(double v)
        {
            Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AmountOfSubstance(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.AmountOfSubstance)
				throw new Exception("Invalid conversion from PhysicalQuantity to AmountOfSubstance");
            Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static AmountOfSubstance Parse(string s)
		{
		     AmountOfSubstance q = UnitsSystem.Parse(s);
			 return q;
		}

		public static AmountOfSubstance Parse(string s, UnitsSystem system)
		{
		     AmountOfSubstance q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out AmountOfSubstance q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new AmountOfSubstance(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out AmountOfSubstance q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new AmountOfSubstance(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator+(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return new AmountOfSubstance(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator-(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return new AmountOfSubstance(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator-(AmountOfSubstance v)
        {
            return new AmountOfSubstance(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator*(AmountOfSubstance v1, int v2)
        {
            return new AmountOfSubstance(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator*(AmountOfSubstance v1, double v2)
        {
            return new AmountOfSubstance(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator*(double v1, AmountOfSubstance v2)
        {
            return new AmountOfSubstance(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator*(AmountOfSubstance v1, Dimensionless v2)
        {
            return new AmountOfSubstance(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator/(AmountOfSubstance v1, int v2)
        {
            return new AmountOfSubstance(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static AmountOfSubstance operator/(AmountOfSubstance v1, double v2)
        {
            return new AmountOfSubstance(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AmountOfSubstance operator/(AmountOfSubstance v1, Dimensionless v2)
        {
            return new AmountOfSubstance(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(AmountOfSubstance v1, AmountOfSubstance v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(AmountOfSubstance v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(AmountOfSubstance v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

	#endregion

    }

	public readonly partial struct LuminousIntensity: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.LuminousIntensity; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public LuminousIntensity(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public LuminousIntensity(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.LuminousIntensity)
				throw new Exception("Invalid conversion from PhysicalQuantity to LuminousIntensity");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static LuminousIntensity Parse(string s)
		{
		     LuminousIntensity q = UnitsSystem.Parse(s);
			 return q;
		}

		public static LuminousIntensity Parse(string s, UnitsSystem system)
		{
		     LuminousIntensity q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out LuminousIntensity q)
		{
            bool retVal = UnitsSystem.TryParse(s, out PhysicalQuantity qty);
            q = retVal ? qty : new LuminousIntensity(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out LuminousIntensity q)
		{
            bool retVal = UnitsSystem.TryParse(s, system, out PhysicalQuantity qty);
            q = retVal ? qty : new LuminousIntensity(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(LuminousIntensity v1, LuminousIntensity v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                var pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(LuminousIntensity v1, LuminousIntensity v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator+(LuminousIntensity v1, LuminousIntensity v2)
        {
            return new LuminousIntensity(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator-(LuminousIntensity v1, LuminousIntensity v2)
        {
            return new LuminousIntensity(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator-(LuminousIntensity v)
        {
            return new LuminousIntensity(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator*(LuminousIntensity v1, int v2)
        {
            return new LuminousIntensity(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator*(LuminousIntensity v1, double v2)
        {
            return new LuminousIntensity(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator*(double v1, LuminousIntensity v2)
        {
            return new LuminousIntensity(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator*(LuminousIntensity v1, Dimensionless v2)
        {
            return new LuminousIntensity(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator/(LuminousIntensity v1, int v2)
        {
            return new LuminousIntensity(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static LuminousIntensity operator/(LuminousIntensity v1, double v2)
        {
            return new LuminousIntensity(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static LuminousIntensity operator/(LuminousIntensity v1, Dimensionless v2)
        {
            return new LuminousIntensity(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(LuminousIntensity v1, LuminousIntensity v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(LuminousIntensity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(LuminousIntensity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

	#endregion

    }

	public readonly partial struct Angle: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Angle; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Angle(double v)
        {
            Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Angle(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Angle)
				throw new Exception("Invalid conversion from PhysicalQuantity to Angle");
            Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Angle Parse(string s)
		{
		     Angle q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Angle Parse(string s, UnitsSystem system)
		{
		     Angle q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Angle q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Angle(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Angle q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Angle(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Angle v1, Angle v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Angle v1, Angle v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Angle v1, Angle v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Angle v1, Angle v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Angle v1, Angle v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Angle v1, Angle v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Angle v1, Angle v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator+(Angle v1, Angle v2)
        {
            return new Angle(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator-(Angle v1, Angle v2)
        {
            return new Angle(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator-(Angle v)
        {
            return new Angle(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(Angle v1, int v2)
        {
            return new Angle(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(Angle v1, double v2)
        {
            return new Angle(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(double v1, Angle v2)
        {
            return new Angle(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(Angle v1, Dimensionless v2)
        {
            return new Angle(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator/(Angle v1, int v2)
        {
            return new Angle(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Angle operator/(Angle v1, double v2)
        {
            return new Angle(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator/(Angle v1, Dimensionless v2)
        {
            return new Angle(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Angle v1, Angle v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Angle v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Angle v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Angle / by Time gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(Angle v1, Time v2)
        {
            return new AngularVelocity(v1.Value / v2.Value);
        }
		// Angle / by AngularVelocity gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Angle v1, AngularVelocity v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// Angle * by Frequency gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(Angle v1, Frequency v2)
        {
            return new AngularVelocity(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Area: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Area; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Area(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Area(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Area)
				throw new Exception("Invalid conversion from PhysicalQuantity to Area");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Area Parse(string s)
		{
		     Area q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Area Parse(string s, UnitsSystem system)
		{
		     Area q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Area q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Area(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Area q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Area(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Area v1, Area v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Area v1, Area v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Area v1, Area v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Area v1, Area v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Area v1, Area v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Area v1, Area v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Area v1, Area v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator+(Area v1, Area v2)
        {
            return new Area(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator-(Area v1, Area v2)
        {
            return new Area(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator-(Area v)
        {
            return new Area(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator*(Area v1, int v2)
        {
            return new Area(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator*(Area v1, double v2)
        {
            return new Area(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator*(double v1, Area v2)
        {
            return new Area(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator*(Area v1, Dimensionless v2)
        {
            return new Area(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(Area v1, int v2)
        {
            return new Area(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Area operator/(Area v1, double v2)
        {
            return new Area(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(Area v1, Dimensionless v2)
        {
            return new Area(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Area v1, Area v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Area v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Area v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Area / by Length gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Area v1, Length v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Area * by Length gives Volume 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Area v1, Length v2)
        {
            return new Volume(v1.Value * v2.Value);
        }
		// Area * by Mass gives MomentOfInertia 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(Area v1, Mass v2)
        {
            return new MomentOfInertia(v1.Value * v2.Value);
        }
		// Area * by Pressure gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Area v1, Pressure v2)
        {
            return new Force(v1.Value * v2.Value);
        }
		// Area * by Resistance gives ResistanceTimesArea 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(Area v1, Resistance v2)
        {
            return new ResistanceTimesArea(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Volume: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Volume; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Volume(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Volume(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Volume)
				throw new Exception("Invalid conversion from PhysicalQuantity to Volume");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Volume Parse(string s)
		{
		     Volume q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Volume Parse(string s, UnitsSystem system)
		{
		     Volume q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Volume q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Volume(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Volume q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Volume(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Volume v1, Volume v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Volume v1, Volume v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Volume v1, Volume v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Volume v1, Volume v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Volume v1, Volume v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Volume v1, Volume v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Volume v1, Volume v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator+(Volume v1, Volume v2)
        {
            return new Volume(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator-(Volume v1, Volume v2)
        {
            return new Volume(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator-(Volume v)
        {
            return new Volume(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Volume v1, int v2)
        {
            return new Volume(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Volume v1, double v2)
        {
            return new Volume(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(double v1, Volume v2)
        {
            return new Volume(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(Volume v1, Dimensionless v2)
        {
            return new Volume(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator/(Volume v1, int v2)
        {
            return new Volume(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Volume operator/(Volume v1, double v2)
        {
            return new Volume(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator/(Volume v1, Dimensionless v2)
        {
            return new Volume(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Volume v1, Volume v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Volume v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Volume v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Volume / by Area gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Volume v1, Area v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Volume / by Length gives Area 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(Volume v1, Length v2)
        {
            return new Area(v1.Value / v2.Value);
        }
		// Volume * by Density gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Volume v1, Density v2)
        {
            return new Mass(v1.Value * v2.Value);
        }
		// Volume / by Time gives VolumeFlowRate 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator/(Volume v1, Time v2)
        {
            return new VolumeFlowRate(v1.Value / v2.Value);
        }
		// Volume / by VolumeFlowRate gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Volume v1, VolumeFlowRate v2)
        {
            return new Time(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct Density: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Density; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Density(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Density(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Density)
				throw new Exception("Invalid conversion from PhysicalQuantity to Density");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Density Parse(string s)
		{
		     Density q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Density Parse(string s, UnitsSystem system)
		{
		     Density q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Density q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Density(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Density q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Density(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Density v1, Density v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Density v1, Density v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Density v1, Density v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Density v1, Density v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Density v1, Density v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Density v1, Density v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Density v1, Density v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator+(Density v1, Density v2)
        {
            return new Density(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator-(Density v1, Density v2)
        {
            return new Density(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator-(Density v)
        {
            return new Density(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator*(Density v1, int v2)
        {
            return new Density(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator*(Density v1, double v2)
        {
            return new Density(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator*(double v1, Density v2)
        {
            return new Density(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator*(Density v1, Dimensionless v2)
        {
            return new Density(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator/(Density v1, int v2)
        {
            return new Density(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Density operator/(Density v1, double v2)
        {
            return new Density(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Density operator/(Density v1, Dimensionless v2)
        {
            return new Density(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Density v1, Density v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Density v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Density v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Density * by Volume gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(Density v1, Volume v2)
        {
            return new Mass(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Velocity: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Velocity; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Velocity(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Velocity(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Velocity)
				throw new Exception("Invalid conversion from PhysicalQuantity to Velocity");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Velocity Parse(string s)
		{
		     Velocity q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Velocity Parse(string s, UnitsSystem system)
		{
		     Velocity q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Velocity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Velocity(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Velocity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Velocity(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Velocity v1, Velocity v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Velocity v1, Velocity v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator+(Velocity v1, Velocity v2)
        {
            return new Velocity(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator-(Velocity v1, Velocity v2)
        {
            return new Velocity(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator-(Velocity v)
        {
            return new Velocity(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Velocity v1, int v2)
        {
            return new Velocity(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Velocity v1, double v2)
        {
            return new Velocity(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(double v1, Velocity v2)
        {
            return new Velocity(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Velocity v1, Dimensionless v2)
        {
            return new Velocity(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator/(Velocity v1, int v2)
        {
            return new Velocity(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Velocity operator/(Velocity v1, double v2)
        {
            return new Velocity(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator/(Velocity v1, Dimensionless v2)
        {
            return new Velocity(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Velocity v1, Velocity v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Velocity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Velocity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Velocity * by Time gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Velocity v1, Time v2)
        {
            return new Length(v1.Value * v2.Value);
        }
		// Velocity / by Length gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(Velocity v1, Length v2)
        {
            return new AngularVelocity(v1.Value / v2.Value);
        }
		// Velocity / by AngularVelocity gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Velocity v1, AngularVelocity v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Velocity * by Velocity gives VelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(Velocity v1, Velocity v2)
        {
            return new VelocitySquared(v1.Value * v2.Value);
        }
		// Velocity / by Time gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(Velocity v1, Time v2)
        {
            return new Acceleration(v1.Value / v2.Value);
        }
		// Velocity / by Acceleration gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Velocity v1, Acceleration v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// Velocity * by Mass gives Momentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Velocity v1, Mass v2)
        {
            return new Momentum(v1.Value * v2.Value);
        }
	#endregion
	#region powers
        public VelocitySquared Squared()
        {
            return new VelocitySquared(this.Value * this.Value);
        }
	#endregion

    }

	public readonly partial struct AngularVelocity: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.AngularVelocity; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularVelocity(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularVelocity(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.AngularVelocity)
				throw new Exception("Invalid conversion from PhysicalQuantity to AngularVelocity");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static AngularVelocity Parse(string s)
		{
		     AngularVelocity q = UnitsSystem.Parse(s);
			 return q;
		}

		public static AngularVelocity Parse(string s, UnitsSystem system)
		{
		     AngularVelocity q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out AngularVelocity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new AngularVelocity(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out AngularVelocity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new AngularVelocity(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(AngularVelocity v1, AngularVelocity v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(AngularVelocity v1, AngularVelocity v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator+(AngularVelocity v1, AngularVelocity v2)
        {
            return new AngularVelocity(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator-(AngularVelocity v1, AngularVelocity v2)
        {
            return new AngularVelocity(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator-(AngularVelocity v)
        {
            return new AngularVelocity(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(AngularVelocity v1, int v2)
        {
            return new AngularVelocity(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(AngularVelocity v1, double v2)
        {
            return new AngularVelocity(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(double v1, AngularVelocity v2)
        {
            return new AngularVelocity(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(AngularVelocity v1, Dimensionless v2)
        {
            return new AngularVelocity(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(AngularVelocity v1, int v2)
        {
            return new AngularVelocity(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static AngularVelocity operator/(AngularVelocity v1, double v2)
        {
            return new AngularVelocity(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(AngularVelocity v1, Dimensionless v2)
        {
            return new AngularVelocity(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(AngularVelocity v1, AngularVelocity v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(AngularVelocity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(AngularVelocity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// AngularVelocity * by Time gives Angle 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator*(AngularVelocity v1, Time v2)
        {
            return new Angle(v1.Value * v2.Value);
        }
		// AngularVelocity * by Length gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(AngularVelocity v1, Length v2)
        {
            return new Velocity(v1.Value * v2.Value);
        }
		// AngularVelocity * by AngularVelocity gives AngularVelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator*(AngularVelocity v1, AngularVelocity v2)
        {
            return new AngularVelocitySquared(v1.Value * v2.Value);
        }
		// AngularVelocity * by MomentOfInertia gives AngularMomentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(AngularVelocity v1, MomentOfInertia v2)
        {
            return new AngularMomentum(v1.Value * v2.Value);
        }
		// AngularVelocity / by Angle gives Frequency 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator/(AngularVelocity v1, Angle v2)
        {
            return new Frequency(v1.Value / v2.Value);
        }
		// AngularVelocity / by Frequency gives Angle 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Angle operator/(AngularVelocity v1, Frequency v2)
        {
            return new Angle(v1.Value / v2.Value);
        }
	#endregion
	#region powers
        public AngularVelocitySquared Squared()
        {
            return new AngularVelocitySquared(this.Value * this.Value);
        }
	#endregion

    }

	public readonly partial struct TimeSquared: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.TimeSquared; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public TimeSquared(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public TimeSquared(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.TimeSquared)
				throw new Exception("Invalid conversion from PhysicalQuantity to TimeSquared");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static TimeSquared Parse(string s)
		{
		     TimeSquared q = UnitsSystem.Parse(s);
			 return q;
		}

		public static TimeSquared Parse(string s, UnitsSystem system)
		{
		     TimeSquared q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out TimeSquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new TimeSquared(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out TimeSquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new TimeSquared(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(TimeSquared v1, TimeSquared v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(TimeSquared v1, TimeSquared v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator+(TimeSquared v1, TimeSquared v2)
        {
            return new TimeSquared(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator-(TimeSquared v1, TimeSquared v2)
        {
            return new TimeSquared(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator-(TimeSquared v)
        {
            return new TimeSquared(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator*(TimeSquared v1, int v2)
        {
            return new TimeSquared(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator*(TimeSquared v1, double v2)
        {
            return new TimeSquared(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator*(double v1, TimeSquared v2)
        {
            return new TimeSquared(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator*(TimeSquared v1, Dimensionless v2)
        {
            return new TimeSquared(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator/(TimeSquared v1, int v2)
        {
            return new TimeSquared(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static TimeSquared operator/(TimeSquared v1, double v2)
        {
            return new TimeSquared(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TimeSquared operator/(TimeSquared v1, Dimensionless v2)
        {
            return new TimeSquared(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(TimeSquared v1, TimeSquared v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(TimeSquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(TimeSquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// TimeSquared / by Time gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(TimeSquared v1, Time v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// TimeSquared * by Acceleration gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(TimeSquared v1, Acceleration v2)
        {
            return new Length(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct VelocitySquared: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.VelocitySquared; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VelocitySquared(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VelocitySquared(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.VelocitySquared)
				throw new Exception("Invalid conversion from PhysicalQuantity to VelocitySquared");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static VelocitySquared Parse(string s)
		{
		     VelocitySquared q = UnitsSystem.Parse(s);
			 return q;
		}

		public static VelocitySquared Parse(string s, UnitsSystem system)
		{
		     VelocitySquared q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out VelocitySquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new VelocitySquared(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out VelocitySquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new VelocitySquared(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(VelocitySquared v1, VelocitySquared v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(VelocitySquared v1, VelocitySquared v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator+(VelocitySquared v1, VelocitySquared v2)
        {
            return new VelocitySquared(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator-(VelocitySquared v1, VelocitySquared v2)
        {
            return new VelocitySquared(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator-(VelocitySquared v)
        {
            return new VelocitySquared(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(VelocitySquared v1, int v2)
        {
            return new VelocitySquared(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(VelocitySquared v1, double v2)
        {
            return new VelocitySquared(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(double v1, VelocitySquared v2)
        {
            return new VelocitySquared(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(VelocitySquared v1, Dimensionless v2)
        {
            return new VelocitySquared(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator/(VelocitySquared v1, int v2)
        {
            return new VelocitySquared(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static VelocitySquared operator/(VelocitySquared v1, double v2)
        {
            return new VelocitySquared(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator/(VelocitySquared v1, Dimensionless v2)
        {
            return new VelocitySquared(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(VelocitySquared v1, VelocitySquared v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(VelocitySquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(VelocitySquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// VelocitySquared / by Velocity gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator/(VelocitySquared v1, Velocity v2)
        {
            return new Velocity(v1.Value / v2.Value);
        }
		// VelocitySquared / by Length gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(VelocitySquared v1, Length v2)
        {
            return new Acceleration(v1.Value / v2.Value);
        }
		// VelocitySquared / by Acceleration gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(VelocitySquared v1, Acceleration v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// VelocitySquared * by Mass gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(VelocitySquared v1, Mass v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct AngularVelocitySquared: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.AngularVelocitySquared; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularVelocitySquared(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularVelocitySquared(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.AngularVelocitySquared)
				throw new Exception("Invalid conversion from PhysicalQuantity to AngularVelocitySquared");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static AngularVelocitySquared Parse(string s)
		{
		     AngularVelocitySquared q = UnitsSystem.Parse(s);
			 return q;
		}

		public static AngularVelocitySquared Parse(string s, UnitsSystem system)
		{
		     AngularVelocitySquared q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out AngularVelocitySquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new AngularVelocitySquared(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out AngularVelocitySquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new AngularVelocitySquared(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator+(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return new AngularVelocitySquared(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator-(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return new AngularVelocitySquared(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator-(AngularVelocitySquared v)
        {
            return new AngularVelocitySquared(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator*(AngularVelocitySquared v1, int v2)
        {
            return new AngularVelocitySquared(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator*(AngularVelocitySquared v1, double v2)
        {
            return new AngularVelocitySquared(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator*(double v1, AngularVelocitySquared v2)
        {
            return new AngularVelocitySquared(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator*(AngularVelocitySquared v1, Dimensionless v2)
        {
            return new AngularVelocitySquared(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator/(AngularVelocitySquared v1, int v2)
        {
            return new AngularVelocitySquared(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static AngularVelocitySquared operator/(AngularVelocitySquared v1, double v2)
        {
            return new AngularVelocitySquared(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator/(AngularVelocitySquared v1, Dimensionless v2)
        {
            return new AngularVelocitySquared(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(AngularVelocitySquared v1, AngularVelocitySquared v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(AngularVelocitySquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(AngularVelocitySquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// AngularVelocitySquared / by AngularVelocity gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(AngularVelocitySquared v1, AngularVelocity v2)
        {
            return new AngularVelocity(v1.Value / v2.Value);
        }
		// AngularVelocitySquared * by Length gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(AngularVelocitySquared v1, Length v2)
        {
            return new Acceleration(v1.Value * v2.Value);
        }
		// AngularVelocitySquared * by AngularMomentum gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(AngularVelocitySquared v1, AngularMomentum v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Acceleration: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Acceleration; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Acceleration(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Acceleration(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Acceleration)
				throw new Exception("Invalid conversion from PhysicalQuantity to Acceleration");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Acceleration Parse(string s)
		{
		     Acceleration q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Acceleration Parse(string s, UnitsSystem system)
		{
		     Acceleration q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Acceleration q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Acceleration(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Acceleration q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Acceleration(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Acceleration v1, Acceleration v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Acceleration v1, Acceleration v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator+(Acceleration v1, Acceleration v2)
        {
            return new Acceleration(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator-(Acceleration v1, Acceleration v2)
        {
            return new Acceleration(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator-(Acceleration v)
        {
            return new Acceleration(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(Acceleration v1, int v2)
        {
            return new Acceleration(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(Acceleration v1, double v2)
        {
            return new Acceleration(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(double v1, Acceleration v2)
        {
            return new Acceleration(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator*(Acceleration v1, Dimensionless v2)
        {
            return new Acceleration(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(Acceleration v1, int v2)
        {
            return new Acceleration(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Acceleration operator/(Acceleration v1, double v2)
        {
            return new Acceleration(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(Acceleration v1, Dimensionless v2)
        {
            return new Acceleration(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Acceleration v1, Acceleration v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Acceleration v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Acceleration v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Acceleration * by Time gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator*(Acceleration v1, Time v2)
        {
            return new Velocity(v1.Value * v2.Value);
        }
		// Acceleration * by Length gives VelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator*(Acceleration v1, Length v2)
        {
            return new VelocitySquared(v1.Value * v2.Value);
        }
		// Acceleration * by TimeSquared gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator*(Acceleration v1, TimeSquared v2)
        {
            return new Length(v1.Value * v2.Value);
        }
		// Acceleration / by Length gives AngularVelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator/(Acceleration v1, Length v2)
        {
            return new AngularVelocitySquared(v1.Value / v2.Value);
        }
		// Acceleration / by AngularVelocitySquared gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Acceleration v1, AngularVelocitySquared v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Acceleration * by Mass gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Acceleration v1, Mass v2)
        {
            return new Force(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Momentum: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Momentum; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Momentum(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Momentum(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Momentum)
				throw new Exception("Invalid conversion from PhysicalQuantity to Momentum");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Momentum Parse(string s)
		{
		     Momentum q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Momentum Parse(string s, UnitsSystem system)
		{
		     Momentum q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Momentum q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Momentum(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Momentum q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Momentum(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Momentum v1, Momentum v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Momentum v1, Momentum v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator+(Momentum v1, Momentum v2)
        {
            return new Momentum(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator-(Momentum v1, Momentum v2)
        {
            return new Momentum(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator-(Momentum v)
        {
            return new Momentum(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Momentum v1, int v2)
        {
            return new Momentum(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Momentum v1, double v2)
        {
            return new Momentum(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(double v1, Momentum v2)
        {
            return new Momentum(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Momentum v1, Dimensionless v2)
        {
            return new Momentum(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator/(Momentum v1, int v2)
        {
            return new Momentum(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Momentum operator/(Momentum v1, double v2)
        {
            return new Momentum(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator/(Momentum v1, Dimensionless v2)
        {
            return new Momentum(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Momentum v1, Momentum v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Momentum v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Momentum v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Momentum / by Mass gives Velocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Velocity operator/(Momentum v1, Mass v2)
        {
            return new Velocity(v1.Value / v2.Value);
        }
		// Momentum / by Velocity gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(Momentum v1, Velocity v2)
        {
            return new Mass(v1.Value / v2.Value);
        }
		// Momentum / by Time gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator/(Momentum v1, Time v2)
        {
            return new Force(v1.Value / v2.Value);
        }
		// Momentum / by Force gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Momentum v1, Force v2)
        {
            return new Time(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct Force: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Force; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Force(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Force(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Force)
				throw new Exception("Invalid conversion from PhysicalQuantity to Force");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Force Parse(string s)
		{
		     Force q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Force Parse(string s, UnitsSystem system)
		{
		     Force q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Force q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Force(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Force q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Force(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Force v1, Force v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Force v1, Force v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Force v1, Force v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Force v1, Force v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Force v1, Force v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Force v1, Force v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Force v1, Force v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator+(Force v1, Force v2)
        {
            return new Force(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator-(Force v1, Force v2)
        {
            return new Force(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator-(Force v)
        {
            return new Force(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Force v1, int v2)
        {
            return new Force(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Force v1, double v2)
        {
            return new Force(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(double v1, Force v2)
        {
            return new Force(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Force v1, Dimensionless v2)
        {
            return new Force(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator/(Force v1, int v2)
        {
            return new Force(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Force operator/(Force v1, double v2)
        {
            return new Force(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator/(Force v1, Dimensionless v2)
        {
            return new Force(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Force v1, Force v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Force v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Force v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Force / by Mass gives Acceleration 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Acceleration operator/(Force v1, Mass v2)
        {
            return new Acceleration(v1.Value / v2.Value);
        }
		// Force / by Acceleration gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(Force v1, Acceleration v2)
        {
            return new Mass(v1.Value / v2.Value);
        }
		// Force * by Time gives Momentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Momentum operator*(Force v1, Time v2)
        {
            return new Momentum(v1.Value * v2.Value);
        }
		// Force * by Length gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Force v1, Length v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// Force / by Area gives Pressure 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator/(Force v1, Area v2)
        {
            return new Pressure(v1.Value / v2.Value);
        }
		// Force / by Pressure gives Area 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(Force v1, Pressure v2)
        {
            return new Area(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct MomentOfInertia: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.MomentOfInertia; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public MomentOfInertia(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public MomentOfInertia(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.MomentOfInertia)
				throw new Exception("Invalid conversion from PhysicalQuantity to MomentOfInertia");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static MomentOfInertia Parse(string s)
		{
		     MomentOfInertia q = UnitsSystem.Parse(s);
			 return q;
		}

		public static MomentOfInertia Parse(string s, UnitsSystem system)
		{
		     MomentOfInertia q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out MomentOfInertia q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new MomentOfInertia(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out MomentOfInertia q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new MomentOfInertia(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(MomentOfInertia v1, MomentOfInertia v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(MomentOfInertia v1, MomentOfInertia v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator+(MomentOfInertia v1, MomentOfInertia v2)
        {
            return new MomentOfInertia(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator-(MomentOfInertia v1, MomentOfInertia v2)
        {
            return new MomentOfInertia(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator-(MomentOfInertia v)
        {
            return new MomentOfInertia(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(MomentOfInertia v1, int v2)
        {
            return new MomentOfInertia(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(MomentOfInertia v1, double v2)
        {
            return new MomentOfInertia(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(double v1, MomentOfInertia v2)
        {
            return new MomentOfInertia(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator*(MomentOfInertia v1, Dimensionless v2)
        {
            return new MomentOfInertia(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator/(MomentOfInertia v1, int v2)
        {
            return new MomentOfInertia(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static MomentOfInertia operator/(MomentOfInertia v1, double v2)
        {
            return new MomentOfInertia(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator/(MomentOfInertia v1, Dimensionless v2)
        {
            return new MomentOfInertia(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(MomentOfInertia v1, MomentOfInertia v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(MomentOfInertia v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(MomentOfInertia v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// MomentOfInertia / by Mass gives Area 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(MomentOfInertia v1, Mass v2)
        {
            return new Area(v1.Value / v2.Value);
        }
		// MomentOfInertia / by Area gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(MomentOfInertia v1, Area v2)
        {
            return new Mass(v1.Value / v2.Value);
        }
		// MomentOfInertia * by AngularVelocity gives AngularMomentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(MomentOfInertia v1, AngularVelocity v2)
        {
            return new AngularMomentum(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct AngularMomentum: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.AngularMomentum; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularMomentum(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public AngularMomentum(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.AngularMomentum)
				throw new Exception("Invalid conversion from PhysicalQuantity to AngularMomentum");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static AngularMomentum Parse(string s)
		{
		     AngularMomentum q = UnitsSystem.Parse(s);
			 return q;
		}

		public static AngularMomentum Parse(string s, UnitsSystem system)
		{
		     AngularMomentum q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out AngularMomentum q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new AngularMomentum(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out AngularMomentum q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new AngularMomentum(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(AngularMomentum v1, AngularMomentum v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(AngularMomentum v1, AngularMomentum v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator+(AngularMomentum v1, AngularMomentum v2)
        {
            return new AngularMomentum(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator-(AngularMomentum v1, AngularMomentum v2)
        {
            return new AngularMomentum(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator-(AngularMomentum v)
        {
            return new AngularMomentum(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(AngularMomentum v1, int v2)
        {
            return new AngularMomentum(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(AngularMomentum v1, double v2)
        {
            return new AngularMomentum(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(double v1, AngularMomentum v2)
        {
            return new AngularMomentum(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator*(AngularMomentum v1, Dimensionless v2)
        {
            return new AngularMomentum(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator/(AngularMomentum v1, int v2)
        {
            return new AngularMomentum(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static AngularMomentum operator/(AngularMomentum v1, double v2)
        {
            return new AngularMomentum(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator/(AngularMomentum v1, Dimensionless v2)
        {
            return new AngularMomentum(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(AngularMomentum v1, AngularMomentum v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(AngularMomentum v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(AngularMomentum v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// AngularMomentum / by MomentOfInertia gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator/(AngularMomentum v1, MomentOfInertia v2)
        {
            return new AngularVelocity(v1.Value / v2.Value);
        }
		// AngularMomentum / by AngularVelocity gives MomentOfInertia 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MomentOfInertia operator/(AngularMomentum v1, AngularVelocity v2)
        {
            return new MomentOfInertia(v1.Value / v2.Value);
        }
		// AngularMomentum * by AngularVelocitySquared gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(AngularMomentum v1, AngularVelocitySquared v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Energy: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Energy; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Energy(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Energy(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Energy)
				throw new Exception("Invalid conversion from PhysicalQuantity to Energy");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Energy Parse(string s)
		{
		     Energy q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Energy Parse(string s, UnitsSystem system)
		{
		     Energy q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Energy q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Energy(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Energy q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Energy(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Energy v1, Energy v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Energy v1, Energy v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Energy v1, Energy v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Energy v1, Energy v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Energy v1, Energy v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Energy v1, Energy v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Energy v1, Energy v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator+(Energy v1, Energy v2)
        {
            return new Energy(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator-(Energy v1, Energy v2)
        {
            return new Energy(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator-(Energy v)
        {
            return new Energy(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Energy v1, int v2)
        {
            return new Energy(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Energy v1, double v2)
        {
            return new Energy(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(double v1, Energy v2)
        {
            return new Energy(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Energy v1, Dimensionless v2)
        {
            return new Energy(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator/(Energy v1, int v2)
        {
            return new Energy(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Energy operator/(Energy v1, double v2)
        {
            return new Energy(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator/(Energy v1, Dimensionless v2)
        {
            return new Energy(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Energy v1, Energy v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Energy v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Energy v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Energy / by Force gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Energy v1, Force v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Energy / by Length gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator/(Energy v1, Length v2)
        {
            return new Force(v1.Value / v2.Value);
        }
		// Energy / by Mass gives VelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VelocitySquared operator/(Energy v1, Mass v2)
        {
            return new VelocitySquared(v1.Value / v2.Value);
        }
		// Energy / by VelocitySquared gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(Energy v1, VelocitySquared v2)
        {
            return new Mass(v1.Value / v2.Value);
        }
		// Energy / by AngularMomentum gives AngularVelocitySquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocitySquared operator/(Energy v1, AngularMomentum v2)
        {
            return new AngularVelocitySquared(v1.Value / v2.Value);
        }
		// Energy / by AngularVelocitySquared gives AngularMomentum 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularMomentum operator/(Energy v1, AngularVelocitySquared v2)
        {
            return new AngularMomentum(v1.Value / v2.Value);
        }
		// Energy / by ElectricCharge gives ElectricPotential 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator/(Energy v1, ElectricCharge v2)
        {
            return new ElectricPotential(v1.Value / v2.Value);
        }
		// Energy / by ElectricPotential gives ElectricCharge 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator/(Energy v1, ElectricPotential v2)
        {
            return new ElectricCharge(v1.Value / v2.Value);
        }
		// Energy / by Time gives Power 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator/(Energy v1, Time v2)
        {
            return new Power(v1.Value / v2.Value);
        }
		// Energy / by Power gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(Energy v1, Power v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// Energy / by TemperatureChange gives ThermalCapacity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator/(Energy v1, TemperatureChange v2)
        {
            return new ThermalCapacity(v1.Value / v2.Value);
        }
		// Energy / by ThermalCapacity gives TemperatureChange 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TemperatureChange operator/(Energy v1, ThermalCapacity v2)
        {
            return new TemperatureChange(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct ElectricCharge: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.ElectricCharge; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricCharge(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricCharge(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.ElectricCharge)
				throw new Exception("Invalid conversion from PhysicalQuantity to ElectricCharge");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static ElectricCharge Parse(string s)
		{
		     ElectricCharge q = UnitsSystem.Parse(s);
			 return q;
		}

		public static ElectricCharge Parse(string s, UnitsSystem system)
		{
		     ElectricCharge q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out ElectricCharge q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new ElectricCharge(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out ElectricCharge q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new ElectricCharge(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(ElectricCharge v1, ElectricCharge v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(ElectricCharge v1, ElectricCharge v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator+(ElectricCharge v1, ElectricCharge v2)
        {
            return new ElectricCharge(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator-(ElectricCharge v1, ElectricCharge v2)
        {
            return new ElectricCharge(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator-(ElectricCharge v)
        {
            return new ElectricCharge(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(ElectricCharge v1, int v2)
        {
            return new ElectricCharge(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(ElectricCharge v1, double v2)
        {
            return new ElectricCharge(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(double v1, ElectricCharge v2)
        {
            return new ElectricCharge(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator*(ElectricCharge v1, Dimensionless v2)
        {
            return new ElectricCharge(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator/(ElectricCharge v1, int v2)
        {
            return new ElectricCharge(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ElectricCharge operator/(ElectricCharge v1, double v2)
        {
            return new ElectricCharge(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricCharge operator/(ElectricCharge v1, Dimensionless v2)
        {
            return new ElectricCharge(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(ElectricCharge v1, ElectricCharge v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(ElectricCharge v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(ElectricCharge v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// ElectricCharge / by Current gives Time 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Time operator/(ElectricCharge v1, Current v2)
        {
            return new Time(v1.Value / v2.Value);
        }
		// ElectricCharge / by Time gives Current 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator/(ElectricCharge v1, Time v2)
        {
            return new Current(v1.Value / v2.Value);
        }
		// ElectricCharge * by ElectricPotential gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(ElectricCharge v1, ElectricPotential v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct ElectricPotential: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.ElectricPotential; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricPotential(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricPotential(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.ElectricPotential)
				throw new Exception("Invalid conversion from PhysicalQuantity to ElectricPotential");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static ElectricPotential Parse(string s)
		{
		     ElectricPotential q = UnitsSystem.Parse(s);
			 return q;
		}

		public static ElectricPotential Parse(string s, UnitsSystem system)
		{
		     ElectricPotential q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out ElectricPotential q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new ElectricPotential(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out ElectricPotential q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new ElectricPotential(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(ElectricPotential v1, ElectricPotential v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(ElectricPotential v1, ElectricPotential v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator+(ElectricPotential v1, ElectricPotential v2)
        {
            return new ElectricPotential(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator-(ElectricPotential v1, ElectricPotential v2)
        {
            return new ElectricPotential(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator-(ElectricPotential v)
        {
            return new ElectricPotential(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(ElectricPotential v1, int v2)
        {
            return new ElectricPotential(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(ElectricPotential v1, double v2)
        {
            return new ElectricPotential(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(double v1, ElectricPotential v2)
        {
            return new ElectricPotential(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(ElectricPotential v1, Dimensionless v2)
        {
            return new ElectricPotential(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator/(ElectricPotential v1, int v2)
        {
            return new ElectricPotential(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ElectricPotential operator/(ElectricPotential v1, double v2)
        {
            return new ElectricPotential(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator/(ElectricPotential v1, Dimensionless v2)
        {
            return new ElectricPotential(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(ElectricPotential v1, ElectricPotential v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(ElectricPotential v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(ElectricPotential v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// ElectricPotential * by ElectricCharge gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(ElectricPotential v1, ElectricCharge v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// ElectricPotential * by ElectricPotential gives ElectricPotentialSquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(ElectricPotential v1, ElectricPotential v2)
        {
            return new ElectricPotentialSquared(v1.Value * v2.Value);
        }
		// ElectricPotential * by Current gives Power 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(ElectricPotential v1, Current v2)
        {
            return new Power(v1.Value * v2.Value);
        }
		// ElectricPotential / by Current gives Resistance 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(ElectricPotential v1, Current v2)
        {
            return new Resistance(v1.Value / v2.Value);
        }
		// ElectricPotential / by Resistance gives Current 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator/(ElectricPotential v1, Resistance v2)
        {
            return new Current(v1.Value / v2.Value);
        }
	#endregion
	#region powers
        public ElectricPotentialSquared Squared()
        {
            return new ElectricPotentialSquared(this.Value * this.Value);
        }
	#endregion

    }

	public readonly partial struct ElectricPotentialSquared: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.ElectricPotentialSquared; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricPotentialSquared(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ElectricPotentialSquared(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.ElectricPotentialSquared)
				throw new Exception("Invalid conversion from PhysicalQuantity to ElectricPotentialSquared");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static ElectricPotentialSquared Parse(string s)
		{
		     ElectricPotentialSquared q = UnitsSystem.Parse(s);
			 return q;
		}

		public static ElectricPotentialSquared Parse(string s, UnitsSystem system)
		{
		     ElectricPotentialSquared q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out ElectricPotentialSquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new ElectricPotentialSquared(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out ElectricPotentialSquared q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new ElectricPotentialSquared(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator+(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return new ElectricPotentialSquared(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator-(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return new ElectricPotentialSquared(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator-(ElectricPotentialSquared v)
        {
            return new ElectricPotentialSquared(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(ElectricPotentialSquared v1, int v2)
        {
            return new ElectricPotentialSquared(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(ElectricPotentialSquared v1, double v2)
        {
            return new ElectricPotentialSquared(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(double v1, ElectricPotentialSquared v2)
        {
            return new ElectricPotentialSquared(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(ElectricPotentialSquared v1, Dimensionless v2)
        {
            return new ElectricPotentialSquared(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator/(ElectricPotentialSquared v1, int v2)
        {
            return new ElectricPotentialSquared(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ElectricPotentialSquared operator/(ElectricPotentialSquared v1, double v2)
        {
            return new ElectricPotentialSquared(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator/(ElectricPotentialSquared v1, Dimensionless v2)
        {
            return new ElectricPotentialSquared(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(ElectricPotentialSquared v1, ElectricPotentialSquared v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(ElectricPotentialSquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(ElectricPotentialSquared v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// ElectricPotentialSquared / by ElectricPotential gives ElectricPotential 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator/(ElectricPotentialSquared v1, ElectricPotential v2)
        {
            return new ElectricPotential(v1.Value / v2.Value);
        }
		// ElectricPotentialSquared / by Resistance gives Power 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator/(ElectricPotentialSquared v1, Resistance v2)
        {
            return new Power(v1.Value / v2.Value);
        }
		// ElectricPotentialSquared / by Power gives Resistance 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(ElectricPotentialSquared v1, Power v2)
        {
            return new Resistance(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct Power: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Power; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Power(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Power(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Power)
				throw new Exception("Invalid conversion from PhysicalQuantity to Power");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Power Parse(string s)
		{
		     Power q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Power Parse(string s, UnitsSystem system)
		{
		     Power q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Power q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Power(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Power q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Power(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Power v1, Power v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Power v1, Power v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Power v1, Power v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Power v1, Power v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Power v1, Power v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Power v1, Power v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Power v1, Power v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator+(Power v1, Power v2)
        {
            return new Power(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator-(Power v1, Power v2)
        {
            return new Power(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator-(Power v)
        {
            return new Power(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(Power v1, int v2)
        {
            return new Power(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(Power v1, double v2)
        {
            return new Power(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(double v1, Power v2)
        {
            return new Power(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator*(Power v1, Dimensionless v2)
        {
            return new Power(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator/(Power v1, int v2)
        {
            return new Power(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Power operator/(Power v1, double v2)
        {
            return new Power(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Power operator/(Power v1, Dimensionless v2)
        {
            return new Power(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Power v1, Power v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Power v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Power v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Power * by Time gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(Power v1, Time v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// Power / by ElectricPotential gives Current 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Current operator/(Power v1, ElectricPotential v2)
        {
            return new Current(v1.Value / v2.Value);
        }
		// Power / by Current gives ElectricPotential 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator/(Power v1, Current v2)
        {
            return new ElectricPotential(v1.Value / v2.Value);
        }
		// Power * by Resistance gives ElectricPotentialSquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(Power v1, Resistance v2)
        {
            return new ElectricPotentialSquared(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Resistance: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Resistance; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Resistance(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Resistance(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Resistance)
				throw new Exception("Invalid conversion from PhysicalQuantity to Resistance");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Resistance Parse(string s)
		{
		     Resistance q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Resistance Parse(string s, UnitsSystem system)
		{
		     Resistance q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Resistance q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Resistance(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Resistance q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Resistance(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Resistance v1, Resistance v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Resistance v1, Resistance v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator+(Resistance v1, Resistance v2)
        {
            return new Resistance(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator-(Resistance v1, Resistance v2)
        {
            return new Resistance(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator-(Resistance v)
        {
            return new Resistance(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator*(Resistance v1, int v2)
        {
            return new Resistance(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator*(Resistance v1, double v2)
        {
            return new Resistance(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator*(double v1, Resistance v2)
        {
            return new Resistance(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator*(Resistance v1, Dimensionless v2)
        {
            return new Resistance(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(Resistance v1, int v2)
        {
            return new Resistance(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Resistance operator/(Resistance v1, double v2)
        {
            return new Resistance(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(Resistance v1, Dimensionless v2)
        {
            return new Resistance(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Resistance v1, Resistance v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Resistance v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Resistance v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Resistance * by Power gives ElectricPotentialSquared 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotentialSquared operator*(Resistance v1, Power v2)
        {
            return new ElectricPotentialSquared(v1.Value * v2.Value);
        }
		// Resistance * by Current gives ElectricPotential 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ElectricPotential operator*(Resistance v1, Current v2)
        {
            return new ElectricPotential(v1.Value * v2.Value);
        }
		// Resistance * by Area gives ResistanceTimesArea 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(Resistance v1, Area v2)
        {
            return new ResistanceTimesArea(v1.Value * v2.Value);
        }
		// Resistance * by Length gives Resistivity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(Resistance v1, Length v2)
        {
            return new Resistivity(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Pressure: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Pressure; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Pressure(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Pressure(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Pressure)
				throw new Exception("Invalid conversion from PhysicalQuantity to Pressure");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Pressure Parse(string s)
		{
		     Pressure q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Pressure Parse(string s, UnitsSystem system)
		{
		     Pressure q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Pressure q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Pressure(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Pressure q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Pressure(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Pressure v1, Pressure v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Pressure v1, Pressure v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator+(Pressure v1, Pressure v2)
        {
            return new Pressure(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator-(Pressure v1, Pressure v2)
        {
            return new Pressure(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator-(Pressure v)
        {
            return new Pressure(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator*(Pressure v1, int v2)
        {
            return new Pressure(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator*(Pressure v1, double v2)
        {
            return new Pressure(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator*(double v1, Pressure v2)
        {
            return new Pressure(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator*(Pressure v1, Dimensionless v2)
        {
            return new Pressure(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator/(Pressure v1, int v2)
        {
            return new Pressure(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Pressure operator/(Pressure v1, double v2)
        {
            return new Pressure(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Pressure operator/(Pressure v1, Dimensionless v2)
        {
            return new Pressure(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Pressure v1, Pressure v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Pressure v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Pressure v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Pressure * by Area gives Force 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Force operator*(Pressure v1, Area v2)
        {
            return new Force(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct Frequency: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Frequency; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Frequency(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Frequency(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Frequency)
				throw new Exception("Invalid conversion from PhysicalQuantity to Frequency");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Frequency Parse(string s)
		{
		     Frequency q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Frequency Parse(string s, UnitsSystem system)
		{
		     Frequency q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Frequency q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Frequency(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Frequency q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Frequency(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Frequency v1, Frequency v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Frequency v1, Frequency v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator+(Frequency v1, Frequency v2)
        {
            return new Frequency(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator-(Frequency v1, Frequency v2)
        {
            return new Frequency(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator-(Frequency v)
        {
            return new Frequency(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator*(Frequency v1, int v2)
        {
            return new Frequency(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator*(Frequency v1, double v2)
        {
            return new Frequency(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator*(double v1, Frequency v2)
        {
            return new Frequency(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator*(Frequency v1, Dimensionless v2)
        {
            return new Frequency(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator/(Frequency v1, int v2)
        {
            return new Frequency(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Frequency operator/(Frequency v1, double v2)
        {
            return new Frequency(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Frequency operator/(Frequency v1, Dimensionless v2)
        {
            return new Frequency(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Frequency v1, Frequency v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Frequency v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Frequency v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Frequency * by Time gives Dimensionless 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator*(Frequency v1, Time v2)
        {
            return new Dimensionless(v1.Value * v2.Value);
        }
		// Frequency * by Angle gives AngularVelocity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static AngularVelocity operator*(Frequency v1, Angle v2)
        {
            return new AngularVelocity(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct MassFlowRate: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.MassFlowRate; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public MassFlowRate(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public MassFlowRate(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.MassFlowRate)
				throw new Exception("Invalid conversion from PhysicalQuantity to MassFlowRate");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static MassFlowRate Parse(string s)
		{
		     MassFlowRate q = UnitsSystem.Parse(s);
			 return q;
		}

		public static MassFlowRate Parse(string s, UnitsSystem system)
		{
		     MassFlowRate q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out MassFlowRate q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new MassFlowRate(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out MassFlowRate q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new MassFlowRate(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(MassFlowRate v1, MassFlowRate v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(MassFlowRate v1, MassFlowRate v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator+(MassFlowRate v1, MassFlowRate v2)
        {
            return new MassFlowRate(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator-(MassFlowRate v1, MassFlowRate v2)
        {
            return new MassFlowRate(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator-(MassFlowRate v)
        {
            return new MassFlowRate(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator*(MassFlowRate v1, int v2)
        {
            return new MassFlowRate(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator*(MassFlowRate v1, double v2)
        {
            return new MassFlowRate(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator*(double v1, MassFlowRate v2)
        {
            return new MassFlowRate(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator*(MassFlowRate v1, Dimensionless v2)
        {
            return new MassFlowRate(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator/(MassFlowRate v1, int v2)
        {
            return new MassFlowRate(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static MassFlowRate operator/(MassFlowRate v1, double v2)
        {
            return new MassFlowRate(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static MassFlowRate operator/(MassFlowRate v1, Dimensionless v2)
        {
            return new MassFlowRate(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(MassFlowRate v1, MassFlowRate v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(MassFlowRate v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(MassFlowRate v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// MassFlowRate * by Time gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator*(MassFlowRate v1, Time v2)
        {
            return new Mass(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct VolumeFlowRate: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.VolumeFlowRate; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VolumeFlowRate(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VolumeFlowRate(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.VolumeFlowRate)
				throw new Exception("Invalid conversion from PhysicalQuantity to VolumeFlowRate");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static VolumeFlowRate Parse(string s)
		{
		     VolumeFlowRate q = UnitsSystem.Parse(s);
			 return q;
		}

		public static VolumeFlowRate Parse(string s, UnitsSystem system)
		{
		     VolumeFlowRate q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out VolumeFlowRate q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new VolumeFlowRate(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out VolumeFlowRate q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new VolumeFlowRate(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator+(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return new VolumeFlowRate(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator-(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return new VolumeFlowRate(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator-(VolumeFlowRate v)
        {
            return new VolumeFlowRate(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator*(VolumeFlowRate v1, int v2)
        {
            return new VolumeFlowRate(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator*(VolumeFlowRate v1, double v2)
        {
            return new VolumeFlowRate(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator*(double v1, VolumeFlowRate v2)
        {
            return new VolumeFlowRate(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator*(VolumeFlowRate v1, Dimensionless v2)
        {
            return new VolumeFlowRate(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator/(VolumeFlowRate v1, int v2)
        {
            return new VolumeFlowRate(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static VolumeFlowRate operator/(VolumeFlowRate v1, double v2)
        {
            return new VolumeFlowRate(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VolumeFlowRate operator/(VolumeFlowRate v1, Dimensionless v2)
        {
            return new VolumeFlowRate(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(VolumeFlowRate v1, VolumeFlowRate v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(VolumeFlowRate v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(VolumeFlowRate v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// VolumeFlowRate * by Time gives Volume 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Volume operator*(VolumeFlowRate v1, Time v2)
        {
            return new Volume(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct ThermalCapacity: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.ThermalCapacity; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ThermalCapacity(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ThermalCapacity(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.ThermalCapacity)
				throw new Exception("Invalid conversion from PhysicalQuantity to ThermalCapacity");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static ThermalCapacity Parse(string s)
		{
		     ThermalCapacity q = UnitsSystem.Parse(s);
			 return q;
		}

		public static ThermalCapacity Parse(string s, UnitsSystem system)
		{
		     ThermalCapacity q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out ThermalCapacity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new ThermalCapacity(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out ThermalCapacity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new ThermalCapacity(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(ThermalCapacity v1, ThermalCapacity v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(ThermalCapacity v1, ThermalCapacity v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator+(ThermalCapacity v1, ThermalCapacity v2)
        {
            return new ThermalCapacity(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator-(ThermalCapacity v1, ThermalCapacity v2)
        {
            return new ThermalCapacity(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator-(ThermalCapacity v)
        {
            return new ThermalCapacity(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(ThermalCapacity v1, int v2)
        {
            return new ThermalCapacity(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(ThermalCapacity v1, double v2)
        {
            return new ThermalCapacity(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(double v1, ThermalCapacity v2)
        {
            return new ThermalCapacity(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(ThermalCapacity v1, Dimensionless v2)
        {
            return new ThermalCapacity(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator/(ThermalCapacity v1, int v2)
        {
            return new ThermalCapacity(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ThermalCapacity operator/(ThermalCapacity v1, double v2)
        {
            return new ThermalCapacity(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator/(ThermalCapacity v1, Dimensionless v2)
        {
            return new ThermalCapacity(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(ThermalCapacity v1, ThermalCapacity v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(ThermalCapacity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(ThermalCapacity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// ThermalCapacity * by TemperatureChange gives Energy 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Energy operator*(ThermalCapacity v1, TemperatureChange v2)
        {
            return new Energy(v1.Value * v2.Value);
        }
		// ThermalCapacity / by Mass gives SpecificHeat 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator/(ThermalCapacity v1, Mass v2)
        {
            return new SpecificHeat(v1.Value / v2.Value);
        }
		// ThermalCapacity / by SpecificHeat gives Mass 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Mass operator/(ThermalCapacity v1, SpecificHeat v2)
        {
            return new Mass(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct SpecificHeat: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.SpecificHeat; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public SpecificHeat(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public SpecificHeat(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.SpecificHeat)
				throw new Exception("Invalid conversion from PhysicalQuantity to SpecificHeat");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static SpecificHeat Parse(string s)
		{
		     SpecificHeat q = UnitsSystem.Parse(s);
			 return q;
		}

		public static SpecificHeat Parse(string s, UnitsSystem system)
		{
		     SpecificHeat q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out SpecificHeat q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new SpecificHeat(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out SpecificHeat q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new SpecificHeat(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(SpecificHeat v1, SpecificHeat v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(SpecificHeat v1, SpecificHeat v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator+(SpecificHeat v1, SpecificHeat v2)
        {
            return new SpecificHeat(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator-(SpecificHeat v1, SpecificHeat v2)
        {
            return new SpecificHeat(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator-(SpecificHeat v)
        {
            return new SpecificHeat(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator*(SpecificHeat v1, int v2)
        {
            return new SpecificHeat(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator*(SpecificHeat v1, double v2)
        {
            return new SpecificHeat(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator*(double v1, SpecificHeat v2)
        {
            return new SpecificHeat(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator*(SpecificHeat v1, Dimensionless v2)
        {
            return new SpecificHeat(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator/(SpecificHeat v1, int v2)
        {
            return new SpecificHeat(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static SpecificHeat operator/(SpecificHeat v1, double v2)
        {
            return new SpecificHeat(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static SpecificHeat operator/(SpecificHeat v1, Dimensionless v2)
        {
            return new SpecificHeat(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(SpecificHeat v1, SpecificHeat v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(SpecificHeat v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(SpecificHeat v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// SpecificHeat * by Mass gives ThermalCapacity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ThermalCapacity operator*(SpecificHeat v1, Mass v2)
        {
            return new ThermalCapacity(v1.Value * v2.Value);
        }
	#endregion

    }

	public readonly partial struct ResistanceTimesArea: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.ResistanceTimesArea; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ResistanceTimesArea(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ResistanceTimesArea(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.ResistanceTimesArea)
				throw new Exception("Invalid conversion from PhysicalQuantity to ResistanceTimesArea");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static ResistanceTimesArea Parse(string s)
		{
		     ResistanceTimesArea q = UnitsSystem.Parse(s);
			 return q;
		}

		public static ResistanceTimesArea Parse(string s, UnitsSystem system)
		{
		     ResistanceTimesArea q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out ResistanceTimesArea q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new ResistanceTimesArea(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out ResistanceTimesArea q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new ResistanceTimesArea(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator+(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return new ResistanceTimesArea(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator-(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return new ResistanceTimesArea(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator-(ResistanceTimesArea v)
        {
            return new ResistanceTimesArea(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(ResistanceTimesArea v1, int v2)
        {
            return new ResistanceTimesArea(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(ResistanceTimesArea v1, double v2)
        {
            return new ResistanceTimesArea(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(double v1, ResistanceTimesArea v2)
        {
            return new ResistanceTimesArea(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(ResistanceTimesArea v1, Dimensionless v2)
        {
            return new ResistanceTimesArea(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator/(ResistanceTimesArea v1, int v2)
        {
            return new ResistanceTimesArea(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ResistanceTimesArea operator/(ResistanceTimesArea v1, double v2)
        {
            return new ResistanceTimesArea(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator/(ResistanceTimesArea v1, Dimensionless v2)
        {
            return new ResistanceTimesArea(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(ResistanceTimesArea v1, ResistanceTimesArea v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(ResistanceTimesArea v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(ResistanceTimesArea v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// ResistanceTimesArea / by Resistance gives Area 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Area operator/(ResistanceTimesArea v1, Resistance v2)
        {
            return new Area(v1.Value / v2.Value);
        }
		// ResistanceTimesArea / by Area gives Resistance 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(ResistanceTimesArea v1, Area v2)
        {
            return new Resistance(v1.Value / v2.Value);
        }
		// ResistanceTimesArea / by Length gives Resistivity 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator/(ResistanceTimesArea v1, Length v2)
        {
            return new Resistivity(v1.Value / v2.Value);
        }
		// ResistanceTimesArea / by Resistivity gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(ResistanceTimesArea v1, Resistivity v2)
        {
            return new Length(v1.Value / v2.Value);
        }
	#endregion

    }

	public readonly partial struct Resistivity: IPhysicalQuantity
    {
        public readonly double Value { get; init; }
		public readonly Dimensions Dimensions { get { return Dimensions.Resistivity; } }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Resistivity(double v)
        {
            this.Value = v;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Resistivity(PhysicalQuantity q)
        {
			if(q.Dimensions != Dimensions.Resistivity)
				throw new Exception("Invalid conversion from PhysicalQuantity to Resistivity");
            this.Value = q.Value;
        }
		
		#region String conversion methods
        public override string ToString()
        {
            return UnitsSystem.ToString(this, UnitsSystem.FormatOption.BestFit);
        }

        public string ToString(UnitsSystem.FormatOption option)
        {
            return UnitsSystem.ToString(this, option);
        }

		public string ToString(UnitsSystem system, UnitsSystem.FormatOption option)
		{
            return UnitsSystem.ToString(this, system, option);
		}

        public string ToString(params Unit[] units)
        {
            return UnitsSystem.ToString(this, units);
        }
		
		public static Resistivity Parse(string s)
		{
		     Resistivity q = UnitsSystem.Parse(s);
			 return q;
		}

		public static Resistivity Parse(string s, UnitsSystem system)
		{
		     Resistivity q = UnitsSystem.Parse(s, system);
			 return q;
		}

		public static bool TryParse(string s, out Resistivity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, out qty);
			q = retVal ? qty : new Resistivity(0);
			return retVal;
		}

		public static bool TryParse(string s, UnitsSystem system, out Resistivity q)
		{
			PhysicalQuantity qty;
		    bool retVal = UnitsSystem.TryParse(s, system, out qty);
			q = retVal ? qty : new Resistivity(0);
			return retVal;
		}
		#endregion

		#region Comparison Operators

		public static int Compare(Resistivity v1, Resistivity v2)
        {
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

		public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                PhysicalQuantity pq = new PhysicalQuantity(this);
                return PhysicalQuantity.Compare(pq, obj as IPhysicalQuantity) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) == 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) != 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) > 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) >= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) <= 0;
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Resistivity v1, Resistivity v2)
        {
            return Compare(v1, v2) < 0;
        }

		#endregion

		#region Maths Operators

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator+(Resistivity v1, Resistivity v2)
        {
            return new Resistivity(v1.Value + v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator-(Resistivity v1, Resistivity v2)
        {
            return new Resistivity(v1.Value - v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator-(Resistivity v)
        {
            return new Resistivity(-v.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(Resistivity v1, int v2)
        {
            return new Resistivity(v1.Value * (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(Resistivity v1, double v2)
        {
            return new Resistivity(v1.Value * v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(double v1, Resistivity v2)
        {
            return new Resistivity(v1 * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator*(Resistivity v1, Dimensionless v2)
        {
            return new Resistivity(v1.Value * v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator/(Resistivity v1, int v2)
        {
            return new Resistivity(v1.Value / (double)v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static Resistivity operator/(Resistivity v1, double v2)
        {
            return new Resistivity(v1.Value / v2);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistivity operator/(Resistivity v1, Dimensionless v2)
        {
            return new Resistivity(v1.Value / v2.Value);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Dimensionless operator/(Resistivity v1, Resistivity v2)
        {
            return new Dimensionless(v1.Value / v2.Value);
        }

#if PREFER_RUNTIME_CHECKS
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static PhysicalQuantity operator *(Resistivity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static PhysicalQuantity operator /(Resistivity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }
#endif

		// Resistivity / by Resistance gives Length 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Length operator/(Resistivity v1, Resistance v2)
        {
            return new Length(v1.Value / v2.Value);
        }
		// Resistivity / by Length gives Resistance 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Resistance operator/(Resistivity v1, Length v2)
        {
            return new Resistance(v1.Value / v2.Value);
        }
		// Resistivity * by Length gives ResistanceTimesArea 
 		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ResistanceTimesArea operator*(Resistivity v1, Length v2)
        {
            return new ResistanceTimesArea(v1.Value * v2.Value);
        }
	#endregion

    }

    public readonly partial struct PhysicalQuantity : IPhysicalQuantity
    {
        public static implicit operator Dimensionless(PhysicalQuantity q) { return new Dimensionless(q); }
        public static implicit operator Mass(PhysicalQuantity q) { return new Mass(q); }
        public static implicit operator Length(PhysicalQuantity q) { return new Length(q); }
        public static implicit operator Time(PhysicalQuantity q) { return new Time(q); }
        public static implicit operator Current(PhysicalQuantity q) { return new Current(q); }
        public static implicit operator TemperatureChange(PhysicalQuantity q) { return new TemperatureChange(q); }
        public static implicit operator AmountOfSubstance(PhysicalQuantity q) { return new AmountOfSubstance(q); }
        public static implicit operator LuminousIntensity(PhysicalQuantity q) { return new LuminousIntensity(q); }
        public static implicit operator Angle(PhysicalQuantity q) { return new Angle(q); }
        public static implicit operator Area(PhysicalQuantity q) { return new Area(q); }
        public static implicit operator Volume(PhysicalQuantity q) { return new Volume(q); }
        public static implicit operator Density(PhysicalQuantity q) { return new Density(q); }
        public static implicit operator Velocity(PhysicalQuantity q) { return new Velocity(q); }
        public static implicit operator AngularVelocity(PhysicalQuantity q) { return new AngularVelocity(q); }
        public static implicit operator TimeSquared(PhysicalQuantity q) { return new TimeSquared(q); }
        public static implicit operator VelocitySquared(PhysicalQuantity q) { return new VelocitySquared(q); }
        public static implicit operator AngularVelocitySquared(PhysicalQuantity q) { return new AngularVelocitySquared(q); }
        public static implicit operator Acceleration(PhysicalQuantity q) { return new Acceleration(q); }
        public static implicit operator Momentum(PhysicalQuantity q) { return new Momentum(q); }
        public static implicit operator Force(PhysicalQuantity q) { return new Force(q); }
        public static implicit operator MomentOfInertia(PhysicalQuantity q) { return new MomentOfInertia(q); }
        public static implicit operator AngularMomentum(PhysicalQuantity q) { return new AngularMomentum(q); }
        public static implicit operator Energy(PhysicalQuantity q) { return new Energy(q); }
        public static implicit operator ElectricCharge(PhysicalQuantity q) { return new ElectricCharge(q); }
        public static implicit operator ElectricPotential(PhysicalQuantity q) { return new ElectricPotential(q); }
        public static implicit operator ElectricPotentialSquared(PhysicalQuantity q) { return new ElectricPotentialSquared(q); }
        public static implicit operator Power(PhysicalQuantity q) { return new Power(q); }
        public static implicit operator Resistance(PhysicalQuantity q) { return new Resistance(q); }
        public static implicit operator Pressure(PhysicalQuantity q) { return new Pressure(q); }
        public static implicit operator Frequency(PhysicalQuantity q) { return new Frequency(q); }
        public static implicit operator MassFlowRate(PhysicalQuantity q) { return new MassFlowRate(q); }
        public static implicit operator VolumeFlowRate(PhysicalQuantity q) { return new VolumeFlowRate(q); }
        public static implicit operator ThermalCapacity(PhysicalQuantity q) { return new ThermalCapacity(q); }
        public static implicit operator SpecificHeat(PhysicalQuantity q) { return new SpecificHeat(q); }
        public static implicit operator ResistanceTimesArea(PhysicalQuantity q) { return new ResistanceTimesArea(q); }
        public static implicit operator Resistivity(PhysicalQuantity q) { return new Resistivity(q); }
    }
}

