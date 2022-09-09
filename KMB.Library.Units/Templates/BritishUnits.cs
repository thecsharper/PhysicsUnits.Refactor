namespace KMB.Library.Units.British
{
    public partial class BritishUnits: UnitsSystem
    {
		public static  BritishUnits System = new  BritishUnits();
        public static double poundsToKilogrammes = 0.45359237;
		public static double feetToMetres = 0.3048;
		public static double squareFeetToSquareMetres = (feetToMetres * feetToMetres);
		public static double cubicFeetToCubicMetres = (feetToMetres * feetToMetres * feetToMetres);
		public static double litresToCubicMetres = 0.001;

		public static Unit LongTons = new Unit("LongTons", "ton", Dimensions.Mass, poundsToKilogrammes*2240.0, Unit.DisplayOption.Multi);
		public static Unit HundredWeight = new Unit("HundredWeight", "cwt", Dimensions.Mass, poundsToKilogrammes*112.0, Unit.DisplayOption.Multi);
		public static Unit Stones = new Unit("Stones", "st", Dimensions.Mass, poundsToKilogrammes*14.0, Unit.DisplayOption.Multi);
		public static Unit Pounds = new Unit("Pounds", "lb", Dimensions.Mass, poundsToKilogrammes, Unit.DisplayOption.Standard);
		public static Unit Ounces = new Unit("Ounces", "oz", Dimensions.Mass, poundsToKilogrammes/16.0, Unit.DisplayOption.Multi);
		public static Unit Dram = new Unit("Dram", "dr", Dimensions.Mass, 0.00177185, Unit.DisplayOption.Explicit);
		public static Unit Grain = new Unit("Grain", "gr", Dimensions.Mass, 6.47989e-5, Unit.DisplayOption.Explicit);
		public static Unit Miles = new Unit("Miles", "mi", Dimensions.Length, (feetToMetres*5280.0), Unit.DisplayOption.Multi);
		public static Unit Yards = new Unit("Yards", "yd", Dimensions.Length, (feetToMetres*3.0), Unit.DisplayOption.Multi);
		public static Unit Feet = new Unit("Feet", "ft", Dimensions.Length, feetToMetres, Unit.DisplayOption.Standard);
		public static Unit Inches = new Unit("Inches", "in", Dimensions.Length, (feetToMetres/12.0), Unit.DisplayOption.Multi);
		public static Unit NauticalMiles = new Unit("NauticalMiles", "nmi", Dimensions.Length, 1852, Unit.DisplayOption.Explicit);
		public static Unit Furlongs = new Unit("Furlongs", "fur", Dimensions.Length, 201.168, Unit.DisplayOption.Explicit);
		public static Unit Rods = new Unit("Rods", "rd", Dimensions.Length, 5.029, Unit.DisplayOption.Explicit);
		public static Unit Fathoms = new Unit("Fathoms", "fth", Dimensions.Length, 1.8288, Unit.DisplayOption.Explicit);
		public static Unit Fortnights = new Unit("Fortnights", "fn", Dimensions.Time, 3600.0*24.0*14.0, Unit.DisplayOption.Explicit);
		public static Unit SquareFeet = new Unit("SquareFeet", "ft²", Dimensions.Area, squareFeetToSquareMetres, Unit.DisplayOption.Standard);
		public static Unit SquareMiles = new Unit("SquareMiles", "mi²", Dimensions.Area, 2.788e+7*squareFeetToSquareMetres, Unit.DisplayOption.Multi);
		public static Unit Acres = new Unit("Acres", "acre", Dimensions.Area, 43560*squareFeetToSquareMetres, Unit.DisplayOption.Multi);
		public static Unit SquareYards = new Unit("SquareYards", "yd²", Dimensions.Area, 9*squareFeetToSquareMetres, Unit.DisplayOption.Explicit);
		public static Unit SquareInch = new Unit("SquareInch", "in²", Dimensions.Area, 0.0069*squareFeetToSquareMetres, Unit.DisplayOption.Explicit);
		public static Unit SquareRod = new Unit("SquareRod", "in²", Dimensions.Area, 272.25*squareFeetToSquareMetres, Unit.DisplayOption.Explicit);
		public static Unit CubicFeet = new Unit("CubicFeet", "ft³", Dimensions.Volume, cubicFeetToCubicMetres, Unit.DisplayOption.Standard);
		public static Unit CubicYards = new Unit("CubicYards", "yd³", Dimensions.Volume, 27*cubicFeetToCubicMetres, Unit.DisplayOption.Standard);
		public static Unit CubicInches = new Unit("CubicInches", "in³", Dimensions.Volume, 0.00058*cubicFeetToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Gallons = new Unit("Gallons", "gal", Dimensions.Volume, 4.54609*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Quarts = new Unit("Quarts", "qt", Dimensions.Volume, 1.136*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Pints = new Unit("Pints", "pt", Dimensions.Volume, 0.568261*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit FluidOunces = new Unit("FluidOunces", "floz", Dimensions.Volume, 0.0284131*litresToCubicMetres, Unit.DisplayOption.Explicit);
		public static Unit FluidDrams = new Unit("FluidDrams", "fldr", Dimensions.Volume, 0.00355163*litresToCubicMetres, Unit.DisplayOption.Explicit);
		public static Unit DegreesFahrenheit = new Unit("DegreesFahrenheit", "°F", Dimensions.TemperatureChange, 5.0/9.0, Unit.DisplayOption.Standard);
		public static Unit MilesPerHour = new Unit("MilesPerHour", "mph", Dimensions.Velocity, 1.0/2.23694, Unit.DisplayOption.Explicit);

        private static readonly Unit[] allUnits = new Unit[]
		{
			LongTons,
			HundredWeight,
			Stones,
			Pounds,
			Ounces,
			Dram,
			Grain,
			Miles,
			Yards,
			Feet,
			Inches,
			NauticalMiles,
			Furlongs,
			Rods,
			Fathoms,
			Fortnights,
			SquareFeet,
			SquareMiles,
			Acres,
			SquareYards,
			SquareInch,
			SquareRod,
			CubicFeet,
			CubicYards,
			CubicInches,
			Gallons,
			Quarts,
			Pints,
			FluidOunces,
			FluidDrams,
			DegreesFahrenheit,
			MilesPerHour,
		};
        public override Unit[] GetAllUnits() { return allUnits; }

		private static readonly Unit[] displayUnits = new Unit[]
		{
			LongTons,
			HundredWeight,
			Stones,
			Pounds,
			Ounces,
			Miles,
			Yards,
			Feet,
			Inches,
			SquareFeet,
			SquareMiles,
			Acres,
			CubicFeet,
			CubicYards,
			CubicInches,
			Gallons,
			Quarts,
			Pints,
			DegreesFahrenheit,
		};
        protected override Unit[] GetDisplayUnits() { return displayUnits; }

		private static readonly Unit[] defaultUnits = new Unit[]
		{
			Pounds,
			Feet,
			SquareFeet,
			CubicFeet,
			CubicYards,
			DegreesFahrenheit,
		};
        protected override Unit[] GetDefaultUnits() { return defaultUnits; }

    } // end of BritishUnits
}
