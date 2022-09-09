namespace KMB.Library.Units.British
{
    public static class BritishUnitsExtensions
    {
        public static Mass LongTons(this int v)   
		{  
			return ((double)v).LongTons();   
		}

        public static Mass LongTons(this double v)
		{
			return new Mass(BritishUnits.LongTons.ConvertValueToSI(v));
	    }
        
		public static double InLongTons(this Mass v)
		{
			return BritishUnits.LongTons.ConvertValueFromSI(v);
	    }
        public static Mass HundredWeight(this int v)   
		{  
			return ((double)v).HundredWeight();   
		}

        public static Mass HundredWeight(this double v)
		{
			return new Mass(BritishUnits.HundredWeight.ConvertValueToSI(v));
	    }

        public static double InHundredWeight(this Mass v)
		{
			return BritishUnits.HundredWeight.ConvertValueFromSI(v);
	    }

        public static Mass Stones(this int v)   
		{  
			return ((double)v).Stones();   
		}

        public static Mass Stones(this double v)
		{
			return new Mass(BritishUnits.Stones.ConvertValueToSI(v));
	    }

        public static double InStones(this Mass v)
		{
			return BritishUnits.Stones.ConvertValueFromSI(v);
	    }

        public static Mass Pounds(this int v)   
		{  
			return ((double)v).Pounds();   
		}

        public static Mass Pounds(this double v)
		{
			return new Mass(BritishUnits.Pounds.ConvertValueToSI(v));
	    }

        public static double InPounds(this Mass v)
		{
			return BritishUnits.Pounds.ConvertValueFromSI(v);
	    }

        public static Mass Ounces(this int v)   
		{  
			return ((double)v).Ounces();   
		}

        public static Mass Ounces(this double v)
		{
			return new Mass(BritishUnits.Ounces.ConvertValueToSI(v));
	    }

        public static double InOunces(this Mass v)
		{
			return BritishUnits.Ounces.ConvertValueFromSI(v);
	    }

        public static Mass Dram(this int v)   
		{  
			return ((double)v).Dram();   
		}


        public static Mass Dram(this double v)
		{
			return new Mass(BritishUnits.Dram.ConvertValueToSI(v));
	    }

        public static double InDram(this Mass v)
		{
			return BritishUnits.Dram.ConvertValueFromSI(v);
	    }

        public static Mass Grain(this int v)   
		{  
			return ((double)v).Grain();   
		}

        public static Mass Grain(this double v)
		{
			return new Mass(BritishUnits.Grain.ConvertValueToSI(v));
	    }

        public static double InGrain(this Mass v)
		{
			return BritishUnits.Grain.ConvertValueFromSI(v);
	    }

        public static Length Miles(this int v)   
		{  
			return ((double)v).Miles();   
		}

        public static Length Miles(this double v)
		{
			return new Length(BritishUnits.Miles.ConvertValueToSI(v));
	    }

        public static double InMiles(this Length v)
		{
			return BritishUnits.Miles.ConvertValueFromSI(v);
	    }

        public static Length Yards(this int v)   
		{  
			return ((double)v).Yards();   
		}

        public static Length Yards(this double v)
		{
			return new Length(BritishUnits.Yards.ConvertValueToSI(v));
	    }

        public static double InYards(this Length v)
		{
			return BritishUnits.Yards.ConvertValueFromSI(v);
	    }
        public static Length Feet(this int v)   
		{  
			return ((double)v).Feet();   
		}

        public static Length Feet(this double v)
		{
			return new Length(BritishUnits.Feet.ConvertValueToSI(v));
	    }

        public static double InFeet(this Length v)
		{
			return BritishUnits.Feet.ConvertValueFromSI(v);
	    }

        public static Length Inches(this int v)   
		{  
			return ((double)v).Inches();   
		}

        public static Length Inches(this double v)
		{
			return new Length(BritishUnits.Inches.ConvertValueToSI(v));
	    }

        public static double InInches(this Length v)
		{
			return BritishUnits.Inches.ConvertValueFromSI(v);
	    }

        public static Length NauticalMiles(this int v)
		{  
			return ((double)v).NauticalMiles();   
		}

        public static Length NauticalMiles(this double v)
		{
			return new Length(BritishUnits.NauticalMiles.ConvertValueToSI(v));
	    }

        public static double InNauticalMiles(this Length v)
		{
			return BritishUnits.NauticalMiles.ConvertValueFromSI(v);
	    }

        public static Length Furlongs(this int v)   
		{  
			return ((double)v).Furlongs();   
		}

        public static Length Furlongs(this double v)
		{
			return new Length(BritishUnits.Furlongs.ConvertValueToSI(v));
	    }

        public static double InFurlongs(this Length v)
		{
			return BritishUnits.Furlongs.ConvertValueFromSI(v);
	    }

        public static Length Rods(this int v)   
		{  
			return ((double)v).Rods();   
		}

        public static Length Rods(this double v)
		{
			return new Length(BritishUnits.Rods.ConvertValueToSI(v));
	    }

        public static double InRods(this Length v)
		{
			return BritishUnits.Rods.ConvertValueFromSI(v);
	    }

        public static Length Fathoms(this int v)   
		{  
			return ((double)v).Fathoms();   
		}

        public static Length Fathoms(this double v)
		{
			return new Length(BritishUnits.Fathoms.ConvertValueToSI(v));
	    }

        public static double InFathoms(this Length v)
		{
			return BritishUnits.Fathoms.ConvertValueFromSI(v);
	    }

        public static Time Fortnights(this int v)   
		{  
			return ((double)v).Fortnights();   
		}

        public static Time Fortnights(this double v)
		{
			return new Time(BritishUnits.Fortnights.ConvertValueToSI(v));
	    }

        public static double InFortnights(this Time v)
		{
			return BritishUnits.Fortnights.ConvertValueFromSI(v);
	    }

        public static Area SquareFeet(this int v)   
		{  
			return ((double)v).SquareFeet();   
		}

        public static Area SquareFeet(this double v)
		{
			return new Area(BritishUnits.SquareFeet.ConvertValueToSI(v));
	    }

        public static double InSquareFeet(this Area v)
		{
			return BritishUnits.SquareFeet.ConvertValueFromSI(v);
	    }
        
		public static Area SquareMiles(this int v)
		{  
			return ((double)v).SquareMiles(); 
		}

        public static Area SquareMiles(this double v)
		{
			return new Area(BritishUnits.SquareMiles.ConvertValueToSI(v));
	    }

        public static double InSquareMiles(this Area v)
		{
			return BritishUnits.SquareMiles.ConvertValueFromSI(v);
	    }

        public static Area Acres(this int v)   
		{  
			return ((double)v).Acres();   
		}

        public static Area Acres(this double v)
		{
			return new Area(BritishUnits.Acres.ConvertValueToSI(v));
	    }

        public static double InAcres(this Area v)
		{
			return BritishUnits.Acres.ConvertValueFromSI(v);
	    }

        public static Area SquareYards(this int v)
		{  
			return ((double)v).SquareYards();   
		}

        public static Area SquareYards(this double v)
		{
			return new Area(BritishUnits.SquareYards.ConvertValueToSI(v));
	    }

        public static double InSquareYards(this Area v)
		{
			return BritishUnits.SquareYards.ConvertValueFromSI(v);
	    }

        public static Area SquareInch(this int v)
		{  
			return ((double)v).SquareInch();   
		}

        public static Area SquareInch(this double v)
		{
			return new Area(BritishUnits.SquareInch.ConvertValueToSI(v));
	    }

        public static double InSquareInch(this Area v)
		{
			return BritishUnits.SquareInch.ConvertValueFromSI(v);
	    }
        public static Area SquareRod(this int v)
		{  
			return ((double)v).SquareRod();   
		}

        public static Area SquareRod(this double v)
		{
			return new Area(BritishUnits.SquareRod.ConvertValueToSI(v));
	    }
        
		public static double InSquareRod(this Area v)
		{
			return BritishUnits.SquareRod.ConvertValueFromSI(v);
	    }

        public static Volume CubicFeet(this int v)   
		{  
			return ((double)v).CubicFeet();   
		}

        public static Volume CubicFeet(this double v)
		{
			return new Volume(BritishUnits.CubicFeet.ConvertValueToSI(v));
	    }

        public static double InCubicFeet(this Volume v)
		{
			return BritishUnits.CubicFeet.ConvertValueFromSI(v);
	    }

        public static Volume CubicYards(this int v)   
		{  
			return ((double)v).CubicYards();   
		}

        public static Volume CubicYards(this double v)
		{
			return new Volume(BritishUnits.CubicYards.ConvertValueToSI(v));
	    }

        public static double InCubicYards(this Volume v)
		{
			return BritishUnits.CubicYards.ConvertValueFromSI(v);
	    }

        public static Volume CubicInches(this int v)   
		{  
			return ((double)v).CubicInches();   
		}

        public static Volume CubicInches(this double v)
		{
			return new Volume(BritishUnits.CubicInches.ConvertValueToSI(v));
	    }

        public static double InCubicInches(this Volume v)
		{
			return BritishUnits.CubicInches.ConvertValueFromSI(v);
	    }

        public static Volume Gallons(this int v)
		{ 
			return ((double)v).Gallons();   
		}
        
		public static Volume Gallons(this double v)
		{
			return new Volume(BritishUnits.Gallons.ConvertValueToSI(v));
	    }

        public static double InGallons(this Volume v)
		{
			return BritishUnits.Gallons.ConvertValueFromSI(v);
	    }
        public static Volume Quarts(this int v)
		{  
			return ((double)v).Quarts();   
		}

        public static Volume Quarts(this double v)
		{
			return new Volume(BritishUnits.Quarts.ConvertValueToSI(v));
	    }

        public static double InQuarts(this Volume v)
		{
			return BritishUnits.Quarts.ConvertValueFromSI(v);
	    }

        public static Volume Pints(this int v)   
		{  
			return ((double)v).Pints();   
		}

        public static Volume Pints(this double v)
		{
			return new Volume(BritishUnits.Pints.ConvertValueToSI(v));
	    }

        public static double InPints(this Volume v)
		{
			return BritishUnits.Pints.ConvertValueFromSI(v);
	    }
        
		public static Volume FluidOunces(this int v)   
		{  
			return ((double)v).FluidOunces();   
		}

        public static Volume FluidOunces(this double v)
		{
			return new Volume(BritishUnits.FluidOunces.ConvertValueToSI(v));
	    }

        public static double InFluidOunces(this Volume v)
		{
			return BritishUnits.FluidOunces.ConvertValueFromSI(v);
	    }

        public static Volume FluidDrams(this int v)   
		{  
			return ((double)v).FluidDrams();   
		}
        
		public static Volume FluidDrams(this double v)
		{
			return new Volume(BritishUnits.FluidDrams.ConvertValueToSI(v));
	    }

        public static double InFluidDrams(this Volume v)
		{
			return BritishUnits.FluidDrams.ConvertValueFromSI(v);
	    }

        public static TemperatureChange DegreesFahrenheit(this int v)   
		{  
			return ((double)v).DegreesFahrenheit();   
		}

        public static TemperatureChange DegreesFahrenheit(this double v)
		{
			return new TemperatureChange(BritishUnits.DegreesFahrenheit.ConvertValueToSI(v));
	    }

        public static double InDegreesFahrenheit(this TemperatureChange v)
		{
			return BritishUnits.DegreesFahrenheit.ConvertValueFromSI(v);
	    }

        public static Velocity MilesPerHour(this int v)   
		{  
			return ((double)v).MilesPerHour();   
		}
        
		public static Velocity MilesPerHour(this double v)
		{
			return new Velocity(BritishUnits.MilesPerHour.ConvertValueToSI(v));
	    }

        public static double InMilesPerHour(this Velocity v)
		{
			return BritishUnits.MilesPerHour.ConvertValueFromSI(v);
	    }
	}
}
