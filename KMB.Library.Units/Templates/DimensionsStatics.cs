namespace KMB.Library.Units
{
	// Generated from Dimensions.xml
    public partial class Dimensions
    {
        public static readonly Dimensions Dimensionless = new Dimensions(0, 0, 0);
        public static readonly Dimensions Mass = new Dimensions(1, 0, 0);
        public static readonly Dimensions Length = new Dimensions(0, 1, 0);
        public static readonly Dimensions Time = new Dimensions(0, 0, 1);
        public static readonly Dimensions Current = new Dimensions(0, 0, 0, 1);
        public static readonly Dimensions TemperatureChange = new Dimensions(0, 0, 0, 0, 1);
        public static readonly Dimensions AmountOfSubstance = new Dimensions(0, 0, 0, 0, 0, 1);
        public static readonly Dimensions LuminousIntensity = new Dimensions(0, 0, 0, 0, 0, 0, 1);
        public static readonly Dimensions Angle = new Dimensions(0, 0, 0, 0, 0, 0, 0, 1);
        public static readonly Dimensions Area = Length * Length;
        public static readonly Dimensions Volume = Area * Length;
        public static readonly Dimensions Density = Mass / Volume;
        public static readonly Dimensions Velocity = Length / Time;
        public static readonly Dimensions AngularVelocity = Angle / Time;
        public static readonly Dimensions TimeSquared = Time * Time;
        public static readonly Dimensions VelocitySquared = Velocity * Velocity;
        public static readonly Dimensions AngularVelocitySquared = AngularVelocity * AngularVelocity;
        public static readonly Dimensions Acceleration = Velocity / Time;
        public static readonly Dimensions Momentum = Mass * Velocity;
        public static readonly Dimensions Force = Mass * Acceleration;
        public static readonly Dimensions MomentOfInertia = Mass * Area;
        public static readonly Dimensions AngularMomentum = MomentOfInertia * AngularVelocity;
        public static readonly Dimensions Energy = Force * Length;
        public static readonly Dimensions ElectricCharge = Current * Time;
        public static readonly Dimensions ElectricPotential = Energy / ElectricCharge;
        public static readonly Dimensions ElectricPotentialSquared = ElectricPotential * ElectricPotential;
        public static readonly Dimensions Power = Energy / Time;
        public static readonly Dimensions Resistance = ElectricPotential / Current;
        public static readonly Dimensions Pressure = Force / Area;
        public static readonly Dimensions Frequency = Dimensionless / Time;
        public static readonly Dimensions MassFlowRate = Mass / Time;
        public static readonly Dimensions VolumeFlowRate = Volume / Time;
        public static readonly Dimensions ThermalCapacity = Energy / TemperatureChange;
        public static readonly Dimensions SpecificHeat = ThermalCapacity / Mass;
        public static readonly Dimensions ResistanceTimesArea = Resistance * Area;
        public static readonly Dimensions Resistivity = Resistance * Length;

        public static readonly Dimensions[] allDimensions = new Dimensions[]
		{
			Dimensionless,
			Mass,
			Length,
			Time,
			Current,
			TemperatureChange,
			AmountOfSubstance,
			LuminousIntensity,
			Angle,
			Area,
			Volume,
			Density,
			Velocity,
			AngularVelocity,
			TimeSquared,
			VelocitySquared,
			AngularVelocitySquared,
			Acceleration,
			Momentum,
			Force,
			MomentOfInertia,
			AngularMomentum,
			Energy,
			ElectricCharge,
			ElectricPotential,
			ElectricPotentialSquared,
			Power,
			Resistance,
			Pressure,
			Frequency,
			MassFlowRate,
			VolumeFlowRate,
			ThermalCapacity,
			SpecificHeat,
			ResistanceTimesArea,
			Resistivity,
		};

    }
}
