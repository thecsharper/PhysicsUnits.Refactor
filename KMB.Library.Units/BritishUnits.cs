  
// Keith Barrett 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	public static class BritishUnitsExtensions
    {
        public static Mass LongTons(this int v)   {  return ((double)v).LongTons();   }
        public static Mass LongTons(this double v)
		{
			return new Mass(BritishUnits.LongTons.ConvertValueToSI(v));
	    }
        public static double InLongTons(this Mass v)
		{
			return BritishUnits.LongTons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass HundredWeight(this int v)   {  return ((double)v).HundredWeight();   }
        public static Mass HundredWeight(this double v)
		{
			return new Mass(BritishUnits.HundredWeight.ConvertValueToSI(v));
	    }
        public static double InHundredWeight(this Mass v)
		{
			return BritishUnits.HundredWeight.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Stones(this int v)   {  return ((double)v).Stones();   }
        public static Mass Stones(this double v)
		{
			return new Mass(BritishUnits.Stones.ConvertValueToSI(v));
	    }
        public static double InStones(this Mass v)
		{
			return BritishUnits.Stones.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Pounds(this int v)   {  return ((double)v).Pounds();   }
        public static Mass Pounds(this double v)
		{
			return new Mass(BritishUnits.Pounds.ConvertValueToSI(v));
	    }
        public static double InPounds(this Mass v)
		{
			return BritishUnits.Pounds.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Ounces(this int v)   {  return ((double)v).Ounces();   }
        public static Mass Ounces(this double v)
		{
			return new Mass(BritishUnits.Ounces.ConvertValueToSI(v));
	    }
        public static double InOunces(this Mass v)
		{
			return BritishUnits.Ounces.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Dram(this int v)   {  return ((double)v).Dram();   }
        public static Mass Dram(this double v)
		{
			return new Mass(BritishUnits.Dram.ConvertValueToSI(v));
	    }
        public static double InDram(this Mass v)
		{
			return BritishUnits.Dram.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Grain(this int v)   {  return ((double)v).Grain();   }
        public static Mass Grain(this double v)
		{
			return new Mass(BritishUnits.Grain.ConvertValueToSI(v));
	    }
        public static double InGrain(this Mass v)
		{
			return BritishUnits.Grain.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Miles(this int v)   {  return ((double)v).Miles();   }
        public static Length Miles(this double v)
		{
			return new Length(BritishUnits.Miles.ConvertValueToSI(v));
	    }
        public static double InMiles(this Length v)
		{
			return BritishUnits.Miles.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Yards(this int v)   {  return ((double)v).Yards();   }
        public static Length Yards(this double v)
		{
			return new Length(BritishUnits.Yards.ConvertValueToSI(v));
	    }
        public static double InYards(this Length v)
		{
			return BritishUnits.Yards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Feet(this int v)   {  return ((double)v).Feet();   }
        public static Length Feet(this double v)
		{
			return new Length(BritishUnits.Feet.ConvertValueToSI(v));
	    }
        public static double InFeet(this Length v)
		{
			return BritishUnits.Feet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Inches(this int v)   {  return ((double)v).Inches();   }
        public static Length Inches(this double v)
		{
			return new Length(BritishUnits.Inches.ConvertValueToSI(v));
	    }
        public static double InInches(this Length v)
		{
			return BritishUnits.Inches.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length NauticalMiles(this int v)   {  return ((double)v).NauticalMiles();   }
        public static Length NauticalMiles(this double v)
		{
			return new Length(BritishUnits.NauticalMiles.ConvertValueToSI(v));
	    }
        public static double InNauticalMiles(this Length v)
		{
			return BritishUnits.NauticalMiles.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Furlongs(this int v)   {  return ((double)v).Furlongs();   }
        public static Length Furlongs(this double v)
		{
			return new Length(BritishUnits.Furlongs.ConvertValueToSI(v));
	    }
        public static double InFurlongs(this Length v)
		{
			return BritishUnits.Furlongs.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Rods(this int v)   {  return ((double)v).Rods();   }
        public static Length Rods(this double v)
		{
			return new Length(BritishUnits.Rods.ConvertValueToSI(v));
	    }
        public static double InRods(this Length v)
		{
			return BritishUnits.Rods.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Fathoms(this int v)   {  return ((double)v).Fathoms();   }
        public static Length Fathoms(this double v)
		{
			return new Length(BritishUnits.Fathoms.ConvertValueToSI(v));
	    }
        public static double InFathoms(this Length v)
		{
			return BritishUnits.Fathoms.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time Fortnights(this int v)   {  return ((double)v).Fortnights();   }
        public static Time Fortnights(this double v)
		{
			return new Time(BritishUnits.Fortnights.ConvertValueToSI(v));
	    }
        public static double InFortnights(this Time v)
		{
			return BritishUnits.Fortnights.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareFeet(this int v)   {  return ((double)v).SquareFeet();   }
        public static Area SquareFeet(this double v)
		{
			return new Area(BritishUnits.SquareFeet.ConvertValueToSI(v));
	    }
        public static double InSquareFeet(this Area v)
		{
			return BritishUnits.SquareFeet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareMiles(this int v)   {  return ((double)v).SquareMiles();   }
        public static Area SquareMiles(this double v)
		{
			return new Area(BritishUnits.SquareMiles.ConvertValueToSI(v));
	    }
        public static double InSquareMiles(this Area v)
		{
			return BritishUnits.SquareMiles.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area Acres(this int v)   {  return ((double)v).Acres();   }
        public static Area Acres(this double v)
		{
			return new Area(BritishUnits.Acres.ConvertValueToSI(v));
	    }
        public static double InAcres(this Area v)
		{
			return BritishUnits.Acres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareYards(this int v)   {  return ((double)v).SquareYards();   }
        public static Area SquareYards(this double v)
		{
			return new Area(BritishUnits.SquareYards.ConvertValueToSI(v));
	    }
        public static double InSquareYards(this Area v)
		{
			return BritishUnits.SquareYards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareInch(this int v)   {  return ((double)v).SquareInch();   }
        public static Area SquareInch(this double v)
		{
			return new Area(BritishUnits.SquareInch.ConvertValueToSI(v));
	    }
        public static double InSquareInch(this Area v)
		{
			return BritishUnits.SquareInch.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareRod(this int v)   {  return ((double)v).SquareRod();   }
        public static Area SquareRod(this double v)
		{
			return new Area(BritishUnits.SquareRod.ConvertValueToSI(v));
	    }
        public static double InSquareRod(this Area v)
		{
			return BritishUnits.SquareRod.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicFeet(this int v)   {  return ((double)v).CubicFeet();   }
        public static Volume CubicFeet(this double v)
		{
			return new Volume(BritishUnits.CubicFeet.ConvertValueToSI(v));
	    }
        public static double InCubicFeet(this Volume v)
		{
			return BritishUnits.CubicFeet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicYards(this int v)   {  return ((double)v).CubicYards();   }
        public static Volume CubicYards(this double v)
		{
			return new Volume(BritishUnits.CubicYards.ConvertValueToSI(v));
	    }
        public static double InCubicYards(this Volume v)
		{
			return BritishUnits.CubicYards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicInches(this int v)   {  return ((double)v).CubicInches();   }
        public static Volume CubicInches(this double v)
		{
			return new Volume(BritishUnits.CubicInches.ConvertValueToSI(v));
	    }
        public static double InCubicInches(this Volume v)
		{
			return BritishUnits.CubicInches.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Gallons(this int v)   {  return ((double)v).Gallons();   }
        public static Volume Gallons(this double v)
		{
			return new Volume(BritishUnits.Gallons.ConvertValueToSI(v));
	    }
        public static double InGallons(this Volume v)
		{
			return BritishUnits.Gallons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Quarts(this int v)   {  return ((double)v).Quarts();   }
        public static Volume Quarts(this double v)
		{
			return new Volume(BritishUnits.Quarts.ConvertValueToSI(v));
	    }
        public static double InQuarts(this Volume v)
		{
			return BritishUnits.Quarts.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Pints(this int v)   {  return ((double)v).Pints();   }
        public static Volume Pints(this double v)
		{
			return new Volume(BritishUnits.Pints.ConvertValueToSI(v));
	    }
        public static double InPints(this Volume v)
		{
			return BritishUnits.Pints.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume FluidOunces(this int v)   {  return ((double)v).FluidOunces();   }
        public static Volume FluidOunces(this double v)
		{
			return new Volume(BritishUnits.FluidOunces.ConvertValueToSI(v));
	    }
        public static double InFluidOunces(this Volume v)
		{
			return BritishUnits.FluidOunces.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume FluidDrams(this int v)   {  return ((double)v).FluidDrams();   }
        public static Volume FluidDrams(this double v)
		{
			return new Volume(BritishUnits.FluidDrams.ConvertValueToSI(v));
	    }
        public static double InFluidDrams(this Volume v)
		{
			return BritishUnits.FluidDrams.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static TemperatureChange DegreesFahrenheit(this int v)   {  return ((double)v).DegreesFahrenheit();   }
        public static TemperatureChange DegreesFahrenheit(this double v)
		{
			return new TemperatureChange(BritishUnits.DegreesFahrenheit.ConvertValueToSI(v));
	    }
        public static double InDegreesFahrenheit(this TemperatureChange v)
		{
			return BritishUnits.DegreesFahrenheit.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Velocity MilesPerHour(this int v)   {  return ((double)v).MilesPerHour();   }
        public static Velocity MilesPerHour(this double v)
		{
			return new Velocity(BritishUnits.MilesPerHour.ConvertValueToSI(v));
	    }
        public static double InMilesPerHour(this Velocity v)
		{
			return BritishUnits.MilesPerHour.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
	}
}
