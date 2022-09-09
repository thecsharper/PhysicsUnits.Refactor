  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMB.Library.Units.USA
{
    public partial class USAUnits: UnitsSystem
    {
		public static  USAUnits System = new  USAUnits();
		public static double poundsToKilogrammes = 0.45359237;
		public static double feetToMetres = 0.3048;
		public static double squareFeetToSquareMetres = (feetToMetres * feetToMetres);
		public static double cubicFeetToCubicMetres = (feetToMetres * feetToMetres * feetToMetres);
		public static double litresToCubicMetres = 0.001;

		public static Unit LongTons = new Unit("LongTons", "ton", Dimensions.Mass, poundsToKilogrammes*2240.0, Unit.DisplayOption.Multi);
		public static Unit Pounds = new Unit("Pounds", "lb", Dimensions.Mass, poundsToKilogrammes, Unit.DisplayOption.Standard);
		public static Unit Inches = new Unit("Inches", "in", Dimensions.Length, (feetToMetres/12.0), Unit.DisplayOption.Explicit);
		public static Unit Feet = new Unit("Feet", "ft", Dimensions.Length, feetToMetres, Unit.DisplayOption.Explicit);
		public static Unit Yards = new Unit("Yards", "yrd", Dimensions.Length, (feetToMetres*3.0), Unit.DisplayOption.Explicit);
		public static Unit NauticalMiles = new Unit("NauticalMiles", "nmi", Dimensions.Length, 1852, Unit.DisplayOption.Explicit);
		public static Unit SquareFeet = new Unit("SquareFeet", "ft²", Dimensions.Area, (feetToMetres*feetToMetres), Unit.DisplayOption.Explicit);
		public static Unit Acres = new Unit("Acres", "acre", Dimensions.Area, 43560*squareFeetToSquareMetres, Unit.DisplayOption.Multi);
		public static Unit SquareYards = new Unit("SquareYards", "yd²", Dimensions.Area, 9*squareFeetToSquareMetres, Unit.DisplayOption.Explicit);
		public static Unit SquareInch = new Unit("SquareInch", "in²", Dimensions.Area, 0.0069*squareFeetToSquareMetres, Unit.DisplayOption.Explicit);
		public static Unit CubicFeet = new Unit("CubicFeet", "ft³", Dimensions.Volume, cubicFeetToCubicMetres, Unit.DisplayOption.Standard);
		public static Unit CubicYards = new Unit("CubicYards", "yd³", Dimensions.Volume, 27*cubicFeetToCubicMetres, Unit.DisplayOption.Standard);
		public static Unit CubicInches = new Unit("CubicInches", "in³", Dimensions.Volume, 0.00058*cubicFeetToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Gallons = new Unit("Gallons", "gal", Dimensions.Volume, 3.78541*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Quarts = new Unit("Quarts", "qt", Dimensions.Volume, 0.946353*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit DryGallons = new Unit("DryGallons", "gal", Dimensions.Volume, 4.404884*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit DryQuarts = new Unit("DryQuarts", "qt", Dimensions.Volume, 1.101221*litresToCubicMetres, Unit.DisplayOption.Multi);
		public static Unit Bushels = new Unit("Bushels", "bu", Dimensions.Volume, 35.23907016688*litresToCubicMetres, Unit.DisplayOption.Multi);

        private static readonly Unit[] allUnits = new Unit[]
		{
			LongTons,
			Pounds,
			Inches,
			Feet,
			Yards,
			NauticalMiles,
			SquareFeet,
			Acres,
			SquareYards,
			SquareInch,
			CubicFeet,
			CubicYards,
			CubicInches,
			Gallons,
			Quarts,
			DryGallons,
			DryQuarts,
			Bushels,
		};
        public override Unit[] GetAllUnits() { return allUnits; }

		private static readonly Unit[] displayUnits = new Unit[]
		{
			LongTons,
			Pounds,
			Acres,
			CubicFeet,
			CubicYards,
			CubicInches,
			Gallons,
			Quarts,
			DryGallons,
			DryQuarts,
			Bushels,
		};
        protected override Unit[] GetDisplayUnits() { return displayUnits; }

		private static readonly Unit[] defaultUnits = new Unit[]
		{
			Pounds,
			CubicFeet,
			CubicYards,
		};
        protected override Unit[] GetDefaultUnits() { return defaultUnits; }

    } // end of USAUnits

	public static class USAUnitsExtensions
    {
        public static Mass LongTons(this int v)   {  return ((double)v).LongTons();   }
        public static Mass LongTons(this double v)
		{
			return new Mass(USAUnits.LongTons.ConvertValueToSI(v));
	    }
        public static double InLongTons(this Mass v)
		{
			return USAUnits.LongTons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Mass Pounds(this int v)   {  return ((double)v).Pounds();   }
        public static Mass Pounds(this double v)
		{
			return new Mass(USAUnits.Pounds.ConvertValueToSI(v));
	    }
        public static double InPounds(this Mass v)
		{
			return USAUnits.Pounds.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Inches(this int v)   {  return ((double)v).Inches();   }
        public static Length Inches(this double v)
		{
			return new Length(USAUnits.Inches.ConvertValueToSI(v));
	    }
        public static double InInches(this Length v)
		{
			return USAUnits.Inches.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Feet(this int v)   {  return ((double)v).Feet();   }
        public static Length Feet(this double v)
		{
			return new Length(USAUnits.Feet.ConvertValueToSI(v));
	    }
        public static double InFeet(this Length v)
		{
			return USAUnits.Feet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length Yards(this int v)   {  return ((double)v).Yards();   }
        public static Length Yards(this double v)
		{
			return new Length(USAUnits.Yards.ConvertValueToSI(v));
	    }
        public static double InYards(this Length v)
		{
			return USAUnits.Yards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Length NauticalMiles(this int v)   {  return ((double)v).NauticalMiles();   }
        public static Length NauticalMiles(this double v)
		{
			return new Length(USAUnits.NauticalMiles.ConvertValueToSI(v));
	    }
        public static double InNauticalMiles(this Length v)
		{
			return USAUnits.NauticalMiles.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareFeet(this int v)   {  return ((double)v).SquareFeet();   }
        public static Area SquareFeet(this double v)
		{
			return new Area(USAUnits.SquareFeet.ConvertValueToSI(v));
	    }
        public static double InSquareFeet(this Area v)
		{
			return USAUnits.SquareFeet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area Acres(this int v)   {  return ((double)v).Acres();   }
        public static Area Acres(this double v)
		{
			return new Area(USAUnits.Acres.ConvertValueToSI(v));
	    }
        public static double InAcres(this Area v)
		{
			return USAUnits.Acres.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareYards(this int v)   {  return ((double)v).SquareYards();   }
        public static Area SquareYards(this double v)
		{
			return new Area(USAUnits.SquareYards.ConvertValueToSI(v));
	    }
        public static double InSquareYards(this Area v)
		{
			return USAUnits.SquareYards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Area SquareInch(this int v)   {  return ((double)v).SquareInch();   }
        public static Area SquareInch(this double v)
		{
			return new Area(USAUnits.SquareInch.ConvertValueToSI(v));
	    }
        public static double InSquareInch(this Area v)
		{
			return USAUnits.SquareInch.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicFeet(this int v)   {  return ((double)v).CubicFeet();   }
        public static Volume CubicFeet(this double v)
		{
			return new Volume(USAUnits.CubicFeet.ConvertValueToSI(v));
	    }
        public static double InCubicFeet(this Volume v)
		{
			return USAUnits.CubicFeet.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicYards(this int v)   {  return ((double)v).CubicYards();   }
        public static Volume CubicYards(this double v)
		{
			return new Volume(USAUnits.CubicYards.ConvertValueToSI(v));
	    }
        public static double InCubicYards(this Volume v)
		{
			return USAUnits.CubicYards.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume CubicInches(this int v)   {  return ((double)v).CubicInches();   }
        public static Volume CubicInches(this double v)
		{
			return new Volume(USAUnits.CubicInches.ConvertValueToSI(v));
	    }
        public static double InCubicInches(this Volume v)
		{
			return USAUnits.CubicInches.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Gallons(this int v)   {  return ((double)v).Gallons();   }
        public static Volume Gallons(this double v)
		{
			return new Volume(USAUnits.Gallons.ConvertValueToSI(v));
	    }
        public static double InGallons(this Volume v)
		{
			return USAUnits.Gallons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Quarts(this int v)   {  return ((double)v).Quarts();   }
        public static Volume Quarts(this double v)
		{
			return new Volume(USAUnits.Quarts.ConvertValueToSI(v));
	    }
        public static double InQuarts(this Volume v)
		{
			return USAUnits.Quarts.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume DryGallons(this int v)   {  return ((double)v).DryGallons();   }
        public static Volume DryGallons(this double v)
		{
			return new Volume(USAUnits.DryGallons.ConvertValueToSI(v));
	    }
        public static double InDryGallons(this Volume v)
		{
			return USAUnits.DryGallons.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume DryQuarts(this int v)   {  return ((double)v).DryQuarts();   }
        public static Volume DryQuarts(this double v)
		{
			return new Volume(USAUnits.DryQuarts.ConvertValueToSI(v));
	    }
        public static double InDryQuarts(this Volume v)
		{
			return USAUnits.DryQuarts.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Volume Bushels(this int v)   {  return ((double)v).Bushels();   }
        public static Volume Bushels(this double v)
		{
			return new Volume(USAUnits.Bushels.ConvertValueToSI(v));
	    }
        public static double InBushels(this Volume v)
		{
			return USAUnits.Bushels.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
	}
}
