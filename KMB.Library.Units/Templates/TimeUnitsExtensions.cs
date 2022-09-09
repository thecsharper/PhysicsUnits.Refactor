namespace KMB.Library.Units.TimeUnits
{
    public static class TimeUnitsExtensions
    {
        public static Time Minutes(this int v)   {  return ((double)v).Minutes();   }
        public static Time Minutes(this double v)
		{
			return new Time(TimeUnits.Minutes.ConvertValueToSI(v));
	    }
        public static double InMinutes(this Time v)
		{
			return TimeUnits.Minutes.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time Hours(this int v)   {  return ((double)v).Hours();   }
        public static Time Hours(this double v)
		{
			return new Time(TimeUnits.Hours.ConvertValueToSI(v));
	    }
        public static double InHours(this Time v)
		{
			return TimeUnits.Hours.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time Days(this int v)   {  return ((double)v).Days();   }
        public static Time Days(this double v)
		{
			return new Time(TimeUnits.Days.ConvertValueToSI(v));
	    }
        public static double InDays(this Time v)
		{
			return TimeUnits.Days.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time Weeks(this int v)   {  return ((double)v).Weeks();   }
        public static Time Weeks(this double v)
		{
			return new Time(TimeUnits.Weeks.ConvertValueToSI(v));
	    }
        public static double InWeeks(this Time v)
		{
			return TimeUnits.Weeks.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time JulianYears(this int v)   {  return ((double)v).JulianYears();   }
        public static Time JulianYears(this double v)
		{
			return new Time(TimeUnits.JulianYears.ConvertValueToSI(v));
	    }
        public static double InJulianYears(this Time v)
		{
			return TimeUnits.JulianYears.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
        public static Time SiderialYears(this int v)   {  return ((double)v).SiderialYears();   }
        public static Time SiderialYears(this double v)
		{
			return new Time(TimeUnits.SiderialYears.ConvertValueToSI(v));
	    }
        public static double InSiderialYears(this Time v)
		{
			return TimeUnits.SiderialYears.ConvertValueFromSI((IPhysicalQuantity)v);
	    }
	}
}
