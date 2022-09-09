namespace KMB.Library.Units.Metric
{
    public partial class MetricUnits: UnitsSystem
    {
		public static  MetricUnits System = new  MetricUnits();

		public static Unit Ones = new Unit("Ones", "1", Dimensions.Dimensionless, 1.0, Unit.DisplayOption.Explicit);
		public static Unit Metres = new Unit("Metres", "m", Dimensions.Length, 1.0, Unit.DisplayOption.Standard);
		public static Unit SquareMetres = new Unit("SquareMetres", "m²", Dimensions.Area, 1.0, Unit.DisplayOption.Standard);
		public static Unit CubicMetres = new Unit("CubicMetres", "m³", Dimensions.Volume, 1.0, Unit.DisplayOption.Standard);
		public static Unit Kilograms = new Unit("Kilograms", "kg", Dimensions.Mass, 1.0, Unit.DisplayOption.Standard);
		public static Unit Seconds = new Unit("Seconds", "s", Dimensions.Time, 1.0, Unit.DisplayOption.Standard);
		public static Unit Ampere = new Unit("Ampere", "amp", Dimensions.Current, 1.0, Unit.DisplayOption.Standard);
		public static Unit DegreesKelvin = new Unit("DegreesKelvin", "K", Dimensions.TemperatureChange, 1.0, Unit.DisplayOption.Standard);
		public static Unit Mole = new Unit("Mole", "mol", Dimensions.AmountOfSubstance, 1.0, Unit.DisplayOption.Standard);
		public static Unit Candela = new Unit("Candela", "cd", Dimensions.LuminousIntensity, 1.0, Unit.DisplayOption.Standard);
		public static Unit Radians = new Unit("Radians", "rad", Dimensions.Angle, 1.0, Unit.DisplayOption.Standard);
		public static Unit MetresPerSecond = new Unit("MetresPerSecond", "m/s", Dimensions.Velocity, 1.0, Unit.DisplayOption.Standard);
		public static Unit MetresPerSecondSquared = new Unit("MetresPerSecondSquared", "m/s²", Dimensions.Acceleration, 1.0, Unit.DisplayOption.Standard);
		public static Unit KilogramMetresPerSecond = new Unit("KilogramMetresPerSecond", "kg⋅m/s", Dimensions.Momentum, 1.0, Unit.DisplayOption.Standard);
		public static Unit KilogramsPerCubicMetre = new Unit("KilogramsPerCubicMetre", "kg/m³", Dimensions.Density, 1.0, Unit.DisplayOption.Standard);
		public static Unit Newtons = new Unit("Newtons", "N", Dimensions.Force, 1.0, Unit.DisplayOption.Standard);
		public static Unit Joules = new Unit("Joules", "J", Dimensions.Energy, 1.0, Unit.DisplayOption.Standard);
		public static Unit Watts = new Unit("Watts", "W", Dimensions.Power, 1.0, Unit.DisplayOption.Standard);
		public static Unit Pascals = new Unit("Pascals", "Pa", Dimensions.Pressure, 1.0, Unit.DisplayOption.Standard);
		public static Unit Hertz = new Unit("Hertz", "Hz", Dimensions.Frequency, 1.0, Unit.DisplayOption.Standard);
		public static Unit KilogramsPerSecond = new Unit("KilogramsPerSecond", "kg/s", Dimensions.MassFlowRate, 1.0, Unit.DisplayOption.Standard);
		public static Unit CubicMetresPerSecond = new Unit("CubicMetresPerSecond", "m³/s", Dimensions.VolumeFlowRate, 1.0, Unit.DisplayOption.Standard);
		public static Unit Volts = new Unit("Volts", "volt", Dimensions.ElectricPotential, 1.0, Unit.DisplayOption.Standard);
		public static Unit Ohms = new Unit("Ohms", "Ω", Dimensions.Resistance, 1.0, Unit.DisplayOption.Standard);
		public static Unit JoulesPerDegreeKelvin = new Unit("JoulesPerDegreeKelvin", "J/K", Dimensions.ThermalCapacity, 1.0, Unit.DisplayOption.Standard);
		public static Unit JoulesPerKilogramPerDegreeKelvin = new Unit("JoulesPerKilogramPerDegreeKelvin", "J⋅kg⁻¹⋅K⁻¹", Dimensions.SpecificHeat, 1.0, Unit.DisplayOption.Standard);
		public static Unit Percent = new Unit("Percent", "%", Dimensions.Dimensionless, 0.01, Unit.DisplayOption.Explicit);
		public static Unit Grams = new Unit("Grams", "g", Dimensions.Mass, 0.001, Unit.DisplayOption.Multi);
		public static Unit MicroGrams = new Unit("MicroGrams", "μg", Dimensions.Mass, 0.000001, Unit.DisplayOption.Multi);
		public static Unit NanoGrams = new Unit("NanoGrams", "ng", Dimensions.Mass, 0.000000001, Unit.DisplayOption.Multi);
		public static Unit Kilometres = new Unit("Kilometres", "km", Dimensions.Length, 1000.0, Unit.DisplayOption.Multi);
		public static Unit Centimetres = new Unit("Centimetres", "cm", Dimensions.Length, 0.01, Unit.DisplayOption.Multi);
		public static Unit Millimetres = new Unit("Millimetres", "mm", Dimensions.Length, 0.001, Unit.DisplayOption.Multi);
		public static Unit Micrometres = new Unit("Micrometres", "μ", Dimensions.Length, 0.000001, Unit.DisplayOption.Multi);
		public static Unit Nanometres = new Unit("Nanometres", "nm", Dimensions.Length, 0.000000001, Unit.DisplayOption.Multi);
		public static Unit AccelerationOfGravity = new Unit("AccelerationOfGravity", "g0", Dimensions.Acceleration, 9.80665, Unit.DisplayOption.Explicit);
		public static Unit Colories = new Unit("Colories", "cal", Dimensions.Energy, 4.184, Unit.DisplayOption.Explicit);
		public static Unit Kilowatts = new Unit("Kilowatts", "kW", Dimensions.Power, 1000.0, Unit.DisplayOption.Multi);
		public static Unit KilowattHours = new Unit("KilowattHours", "kWh", Dimensions.Energy, 3.6e6, Unit.DisplayOption.Multi);
		public static Unit DegreesCelsius = new Unit("DegreesCelsius", "°C", Dimensions.TemperatureChange, 1.0, Unit.DisplayOption.Explicit);
		public static Unit CaloriesPerDegreeKelvin = new Unit("CaloriesPerDegreeKelvin", "cal/K", Dimensions.ThermalCapacity, 4.186, Unit.DisplayOption.Explicit);
		public static Unit MilliSeconds = new Unit("MilliSeconds", "ms", Dimensions.Time, 0.001, Unit.DisplayOption.Multi);
		public static Unit OhmMetres = new Unit("OhmMetres", "Ω⋅m", Dimensions.Resistivity, 1.0, Unit.DisplayOption.Standard);
		public static Unit AstronomicalUnits = new Unit("AstronomicalUnits", "au", Dimensions.Length, 149597870700.0, Unit.DisplayOption.Explicit);
		public static Unit Hectares = new Unit("Hectares", "ha", Dimensions.Area, 10000.0, Unit.DisplayOption.Multi);
		public static Unit Tonnes = new Unit("Tonnes", "t", Dimensions.Mass, 1000.0, Unit.DisplayOption.Multi);
		public static Unit Daltons = new Unit("Daltons", "Da", Dimensions.Mass, 1.660539040E-27, Unit.DisplayOption.Explicit);
		public static Unit ElectronVolts = new Unit("ElectronVolts", "eV", Dimensions.Energy, 1.602176634E-19, Unit.DisplayOption.Explicit);
		public static Unit Degrees = new Unit("Degrees", "°", Dimensions.Angle, 0.01745329251994329576923690768489, Unit.DisplayOption.Explicit);
		public static Unit KilometresPerHour = new Unit("KilometresPerHour", "kph", Dimensions.Velocity, 0.2777777777777778, Unit.DisplayOption.Explicit);
		public static Unit Dyne = new Unit("Dyne", "dyn", Dimensions.Force, 1e-5, Unit.DisplayOption.Explicit);

        private static readonly Unit[] allUnits = new Unit[]
		{
			Ones,
			Metres,
			SquareMetres,
			CubicMetres,
			Kilograms,
			Seconds,
			Ampere,
			DegreesKelvin,
			Mole,
			Candela,
			Radians,
			MetresPerSecond,
			MetresPerSecondSquared,
			KilogramMetresPerSecond,
			KilogramsPerCubicMetre,
			Newtons,
			Joules,
			Watts,
			Pascals,
			Hertz,
			KilogramsPerSecond,
			CubicMetresPerSecond,
			Volts,
			Ohms,
			JoulesPerDegreeKelvin,
			JoulesPerKilogramPerDegreeKelvin,
			Percent,
			Grams,
			MicroGrams,
			NanoGrams,
			Kilometres,
			Centimetres,
			Millimetres,
			Micrometres,
			Nanometres,
			AccelerationOfGravity,
			Colories,
			Kilowatts,
			KilowattHours,
			DegreesCelsius,
			CaloriesPerDegreeKelvin,
			MilliSeconds,
			OhmMetres,
			AstronomicalUnits,
			Hectares,
			Tonnes,
			Daltons,
			ElectronVolts,
			Degrees,
			KilometresPerHour,
			Dyne,
		};
        public override Unit[] GetAllUnits() { return allUnits; }

		private static readonly Unit[] displayUnits = new Unit[]
		{
			Metres,
			SquareMetres,
			CubicMetres,
			Kilograms,
			Seconds,
			Ampere,
			DegreesKelvin,
			Mole,
			Candela,
			Radians,
			MetresPerSecond,
			MetresPerSecondSquared,
			KilogramMetresPerSecond,
			KilogramsPerCubicMetre,
			Newtons,
			Joules,
			Watts,
			Pascals,
			Hertz,
			KilogramsPerSecond,
			CubicMetresPerSecond,
			Volts,
			Ohms,
			JoulesPerDegreeKelvin,
			JoulesPerKilogramPerDegreeKelvin,
			Grams,
			MicroGrams,
			NanoGrams,
			Kilometres,
			Centimetres,
			Millimetres,
			Micrometres,
			Nanometres,
			Kilowatts,
			KilowattHours,
			MilliSeconds,
			OhmMetres,
			Hectares,
			Tonnes,
		};
        protected override Unit[] GetDisplayUnits() { return displayUnits; }

		private static readonly Unit[] defaultUnits = new Unit[]
		{
			Metres,
			SquareMetres,
			CubicMetres,
			Kilograms,
			Seconds,
			Ampere,
			DegreesKelvin,
			Mole,
			Candela,
			Radians,
			MetresPerSecond,
			MetresPerSecondSquared,
			KilogramMetresPerSecond,
			KilogramsPerCubicMetre,
			Newtons,
			Joules,
			Watts,
			Pascals,
			Hertz,
			KilogramsPerSecond,
			CubicMetresPerSecond,
			Volts,
			Ohms,
			JoulesPerDegreeKelvin,
			JoulesPerKilogramPerDegreeKelvin,
			OhmMetres,
		};
        protected override Unit[] GetDefaultUnits() { return defaultUnits; }

    } // end of MetricUnits

	public static class MetricUnitsExtensions
    {
        public static Dimensionless Ones(this int v)   {  return ((double)v).Ones();   }
        public static Dimensionless Ones(this double v)
		{
			return new Dimensionless(v);
	    }
        public static double InOnes(this Dimensionless v)
		{
			return v.Value;
	    }
        public static Length Metres(this int v)   {  return ((double)v).Metres();   }
        public static Length Metres(this double v)
		{
			return new Length(v);
	    }
        public static double InMetres(this Length v)
		{
			return v.Value;
	    }
        public static Area SquareMetres(this int v)   {  return ((double)v).SquareMetres();   }
        public static Area SquareMetres(this double v)
		{
			return new Area(v);
	    }
        public static double InSquareMetres(this Area v)
		{
			return v.Value;
	    }
        public static Volume CubicMetres(this int v)   {  return ((double)v).CubicMetres();   }
        public static Volume CubicMetres(this double v)
		{
			return new Volume(v);
	    }
        public static double InCubicMetres(this Volume v)
		{
			return v.Value;
	    }
        public static Mass Kilograms(this int v)   {  return ((double)v).Kilograms();   }
        public static Mass Kilograms(this double v)
		{
			return new Mass(v);
	    }
        public static double InKilograms(this Mass v)
		{
			return v.Value;
	    }
        public static Time Seconds(this int v)   {  return ((double)v).Seconds();   }
        public static Time Seconds(this double v)
		{
			return new Time(v);
	    }
        public static double InSeconds(this Time v)
		{
			return v.Value;
	    }
        public static Current Ampere(this int v)   {  return ((double)v).Ampere();   }
        public static Current Ampere(this double v)
		{
			return new Current(v);
	    }
        public static double InAmpere(this Current v)
		{
			return v.Value;
	    }
        public static TemperatureChange DegreesKelvin(this int v)   {  return ((double)v).DegreesKelvin();   }
        public static TemperatureChange DegreesKelvin(this double v)
		{
			return new TemperatureChange(v);
	    }
        public static double InDegreesKelvin(this TemperatureChange v)
		{
			return v.Value;
	    }
        public static AmountOfSubstance Mole(this int v)   {  return ((double)v).Mole();   }
        public static AmountOfSubstance Mole(this double v)
		{
			return new AmountOfSubstance(v);
	    }
        public static double InMole(this AmountOfSubstance v)
		{
			return v.Value;
	    }
        public static LuminousIntensity Candela(this int v)   {  return ((double)v).Candela();   }
        public static LuminousIntensity Candela(this double v)
		{
			return new LuminousIntensity(v);
	    }
        public static double InCandela(this LuminousIntensity v)
		{
			return v.Value;
	    }
        public static Angle Radians(this int v)   {  return ((double)v).Radians();   }
        public static Angle Radians(this double v)
		{
			return new Angle(v);
	    }
        public static double InRadians(this Angle v)
		{
			return v.Value;
	    }
        public static Velocity MetresPerSecond(this int v)   {  return ((double)v).MetresPerSecond();   }
        public static Velocity MetresPerSecond(this double v)
		{
			return new Velocity(v);
	    }
        public static double InMetresPerSecond(this Velocity v)
		{
			return v.Value;
	    }
        public static Acceleration MetresPerSecondSquared(this int v)   {  return ((double)v).MetresPerSecondSquared();   }
        public static Acceleration MetresPerSecondSquared(this double v)
		{
			return new Acceleration(v);
	    }
        public static double InMetresPerSecondSquared(this Acceleration v)
		{
			return v.Value;
	    }
        public static Momentum KilogramMetresPerSecond(this int v)   {  return ((double)v).KilogramMetresPerSecond();   }
        public static Momentum KilogramMetresPerSecond(this double v)
		{
			return new Momentum(v);
	    }
        public static double InKilogramMetresPerSecond(this Momentum v)
		{
			return v.Value;
	    }
        public static Density KilogramsPerCubicMetre(this int v)   {  return ((double)v).KilogramsPerCubicMetre();   }
        public static Density KilogramsPerCubicMetre(this double v)
		{
			return new Density(v);
	    }
        public static double InKilogramsPerCubicMetre(this Density v)
		{
			return v.Value;
	    }
        public static Force Newtons(this int v)   {  return ((double)v).Newtons();   }
        public static Force Newtons(this double v)
		{
			return new Force(v);
	    }
        public static double InNewtons(this Force v)
		{
			return v.Value;
	    }
        public static Energy Joules(this int v)   {  return ((double)v).Joules();   }
        public static Energy Joules(this double v)
		{
			return new Energy(v);
	    }
        public static double InJoules(this Energy v)
		{
			return v.Value;
	    }
        public static Power Watts(this int v)   {  return ((double)v).Watts();   }
        public static Power Watts(this double v)
		{
			return new Power(v);
	    }
        public static double InWatts(this Power v)
		{
			return v.Value;
	    }
        public static Pressure Pascals(this int v)   {  return ((double)v).Pascals();   }
        public static Pressure Pascals(this double v)
		{
			return new Pressure(v);
	    }
        public static double InPascals(this Pressure v)
		{
			return v.Value;
	    }
        public static Frequency Hertz(this int v)   {  return ((double)v).Hertz();   }
        public static Frequency Hertz(this double v)
		{
			return new Frequency(v);
	    }
        public static double InHertz(this Frequency v)
		{
			return v.Value;
	    }
        public static MassFlowRate KilogramsPerSecond(this int v)   {  return ((double)v).KilogramsPerSecond();   }
        public static MassFlowRate KilogramsPerSecond(this double v)
		{
			return new MassFlowRate(v);
	    }
        public static double InKilogramsPerSecond(this MassFlowRate v)
		{
			return v.Value;
	    }
        public static VolumeFlowRate CubicMetresPerSecond(this int v)   {  return ((double)v).CubicMetresPerSecond();   }
        public static VolumeFlowRate CubicMetresPerSecond(this double v)
		{
			return new VolumeFlowRate(v);
	    }
        public static double InCubicMetresPerSecond(this VolumeFlowRate v)
		{
			return v.Value;
	    }
        public static ElectricPotential Volts(this int v)   {  return ((double)v).Volts();   }
        public static ElectricPotential Volts(this double v)
		{
			return new ElectricPotential(v);
	    }
        public static double InVolts(this ElectricPotential v)
		{
			return v.Value;
	    }
        public static Resistance Ohms(this int v)   {  return ((double)v).Ohms();   }
        public static Resistance Ohms(this double v)
		{
			return new Resistance(v);
	    }
        public static double InOhms(this Resistance v)
		{
			return v.Value;
	    }
        public static ThermalCapacity JoulesPerDegreeKelvin(this int v)   {  return ((double)v).JoulesPerDegreeKelvin();   }
        public static ThermalCapacity JoulesPerDegreeKelvin(this double v)
		{
			return new ThermalCapacity(v);
	    }
        public static double InJoulesPerDegreeKelvin(this ThermalCapacity v)
		{
			return v.Value;
	    }
        public static SpecificHeat JoulesPerKilogramPerDegreeKelvin(this int v)   {  return ((double)v).JoulesPerKilogramPerDegreeKelvin();   }
        public static SpecificHeat JoulesPerKilogramPerDegreeKelvin(this double v)
		{
			return new SpecificHeat(v);
	    }
        public static double InJoulesPerKilogramPerDegreeKelvin(this SpecificHeat v)
		{
			return v.Value;
	    }
        public static Dimensionless Percent(this int v)   {  return ((double)v).Percent();   }
        public static Dimensionless Percent(this double v)
		{
			return new Dimensionless(MetricUnits.Percent.ConvertValueToSI(v));
	    }
        public static double InPercent(this Dimensionless v)
		{
			return MetricUnits.Percent.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Grams(this int v)   {  return ((double)v).Grams();   }
        public static Mass Grams(this double v)
		{
			return new Mass(MetricUnits.Grams.ConvertValueToSI(v));
	    }
        public static double InGrams(this Mass v)
		{
			return MetricUnits.Grams.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass MicroGrams(this int v)   {  return ((double)v).MicroGrams();   }
        public static Mass MicroGrams(this double v)
		{
			return new Mass(MetricUnits.MicroGrams.ConvertValueToSI(v));
	    }
        public static double InMicroGrams(this Mass v)
		{
			return MetricUnits.MicroGrams.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass NanoGrams(this int v)   {  return ((double)v).NanoGrams();   }
        public static Mass NanoGrams(this double v)
		{
			return new Mass(MetricUnits.NanoGrams.ConvertValueToSI(v));
	    }
        public static double InNanoGrams(this Mass v)
		{
			return MetricUnits.NanoGrams.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Kilometres(this int v)   {  return ((double)v).Kilometres();   }
        public static Length Kilometres(this double v)
		{
			return new Length(MetricUnits.Kilometres.ConvertValueToSI(v));
	    }
        public static double InKilometres(this Length v)
		{
			return MetricUnits.Kilometres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Centimetres(this int v)   {  return ((double)v).Centimetres();   }
        public static Length Centimetres(this double v)
		{
			return new Length(MetricUnits.Centimetres.ConvertValueToSI(v));
	    }
        public static double InCentimetres(this Length v)
		{
			return MetricUnits.Centimetres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Millimetres(this int v)   {  return ((double)v).Millimetres();   }
        public static Length Millimetres(this double v)
		{
			return new Length(MetricUnits.Millimetres.ConvertValueToSI(v));
	    }
        public static double InMillimetres(this Length v)
		{
			return MetricUnits.Millimetres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Micrometres(this int v)   {  return ((double)v).Micrometres();   }
        public static Length Micrometres(this double v)
		{
			return new Length(MetricUnits.Micrometres.ConvertValueToSI(v));
	    }
        public static double InMicrometres(this Length v)
		{
			return MetricUnits.Micrometres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Nanometres(this int v)   {  return ((double)v).Nanometres();   }
        public static Length Nanometres(this double v)
		{
			return new Length(MetricUnits.Nanometres.ConvertValueToSI(v));
	    }
        public static double InNanometres(this Length v)
		{
			return MetricUnits.Nanometres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Acceleration AccelerationOfGravity(this int v)   {  return ((double)v).AccelerationOfGravity();   }
        public static Acceleration AccelerationOfGravity(this double v)
		{
			return new Acceleration(MetricUnits.AccelerationOfGravity.ConvertValueToSI(v));
	    }
        public static double InAccelerationOfGravity(this Acceleration v)
		{
			return MetricUnits.AccelerationOfGravity.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Energy Colories(this int v)   {  return ((double)v).Colories();   }
        public static Energy Colories(this double v)
		{
			return new Energy(MetricUnits.Colories.ConvertValueToSI(v));
	    }
        public static double InColories(this Energy v)
		{
			return MetricUnits.Colories.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Power Kilowatts(this int v)   {  return ((double)v).Kilowatts();   }
        public static Power Kilowatts(this double v)
		{
			return new Power(MetricUnits.Kilowatts.ConvertValueToSI(v));
	    }
        public static double InKilowatts(this Power v)
		{
			return MetricUnits.Kilowatts.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Energy KilowattHours(this int v)   {  return ((double)v).KilowattHours();   }
        public static Energy KilowattHours(this double v)
		{
			return new Energy(MetricUnits.KilowattHours.ConvertValueToSI(v));
	    }
        public static double InKilowattHours(this Energy v)
		{
			return MetricUnits.KilowattHours.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static TemperatureChange DegreesCelsius(this int v)   {  return ((double)v).DegreesCelsius();   }
        public static TemperatureChange DegreesCelsius(this double v)
		{
			return new TemperatureChange(v);
	    }
        public static double InDegreesCelsius(this TemperatureChange v)
		{
			return v.Value;
	    }
        public static ThermalCapacity CaloriesPerDegreeKelvin(this int v)   {  return ((double)v).CaloriesPerDegreeKelvin();   }
        public static ThermalCapacity CaloriesPerDegreeKelvin(this double v)
		{
			return new ThermalCapacity(MetricUnits.CaloriesPerDegreeKelvin.ConvertValueToSI(v));
	    }
        public static double InCaloriesPerDegreeKelvin(this ThermalCapacity v)
		{
			return MetricUnits.CaloriesPerDegreeKelvin.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time MilliSeconds(this int v)   {  return ((double)v).MilliSeconds();   }
        public static Time MilliSeconds(this double v)
		{
			return new Time(MetricUnits.MilliSeconds.ConvertValueToSI(v));
	    }
        public static double InMilliSeconds(this Time v)
		{
			return MetricUnits.MilliSeconds.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Resistivity OhmMetres(this int v)   {  return ((double)v).OhmMetres();   }
        public static Resistivity OhmMetres(this double v)
		{
			return new Resistivity(v);
	    }
        public static double InOhmMetres(this Resistivity v)
		{
			return v.Value;
	    }
        public static Length AstronomicalUnits(this int v)   {  return ((double)v).AstronomicalUnits();   }
        public static Length AstronomicalUnits(this double v)
		{
			return new Length(MetricUnits.AstronomicalUnits.ConvertValueToSI(v));
	    }
        public static double InAstronomicalUnits(this Length v)
		{
			return MetricUnits.AstronomicalUnits.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area Hectares(this int v)   {  return ((double)v).Hectares();   }
        public static Area Hectares(this double v)
		{
			return new Area(MetricUnits.Hectares.ConvertValueToSI(v));
	    }
        public static double InHectares(this Area v)
		{
			return MetricUnits.Hectares.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Tonnes(this int v)   {  return ((double)v).Tonnes();   }
        public static Mass Tonnes(this double v)
		{
			return new Mass(MetricUnits.Tonnes.ConvertValueToSI(v));
	    }
        public static double InTonnes(this Mass v)
		{
			return MetricUnits.Tonnes.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Daltons(this int v)   {  return ((double)v).Daltons();   }
        public static Mass Daltons(this double v)
		{
			return new Mass(MetricUnits.Daltons.ConvertValueToSI(v));
	    }
        public static double InDaltons(this Mass v)
		{
			return MetricUnits.Daltons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Energy ElectronVolts(this int v)   {  return ((double)v).ElectronVolts();   }
        public static Energy ElectronVolts(this double v)
		{
			return new Energy(MetricUnits.ElectronVolts.ConvertValueToSI(v));
	    }
        public static double InElectronVolts(this Energy v)
		{
			return MetricUnits.ElectronVolts.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Angle Degrees(this int v)   {  return ((double)v).Degrees();   }
        public static Angle Degrees(this double v)
		{
			return new Angle(MetricUnits.Degrees.ConvertValueToSI(v));
	    }
        public static double InDegrees(this Angle v)
		{
			return MetricUnits.Degrees.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Velocity KilometresPerHour(this int v)   {  return ((double)v).KilometresPerHour();   }
        public static Velocity KilometresPerHour(this double v)
		{
			return new Velocity(MetricUnits.KilometresPerHour.ConvertValueToSI(v));
	    }
        public static double InKilometresPerHour(this Velocity v)
		{
			return MetricUnits.KilometresPerHour.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Force Dyne(this int v)   {  return ((double)v).Dyne();   }
        public static Force Dyne(this double v)
		{
			return new Force(MetricUnits.Dyne.ConvertValueToSI(v));
	    }
        public static double InDyne(this Force v)
		{
			return MetricUnits.Dyne.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
	}
}
