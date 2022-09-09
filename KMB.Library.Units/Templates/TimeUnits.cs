namespace KMB.Library.Units.TimeUnits
{
    public partial class TimeUnits: UnitsSystem
    {
		public static  TimeUnits System = new  TimeUnits();

		public static Unit Minutes = new("Minutes", "min", Dimensions.Time, 60.0, Unit.DisplayOption.Explicit);
		public static Unit Hours = new("Hours", "hr", Dimensions.Time, 3600.0, Unit.DisplayOption.Explicit);
		public static Unit Days = new("Days", "day", Dimensions.Time, 3600.0*24.0, Unit.DisplayOption.Explicit);
		public static Unit Weeks = new("Weeks", "week", Dimensions.Time, 3600.0*24.0*7.0, Unit.DisplayOption.Explicit);
		public static Unit JulianYears = new("JulianYears", "yr", Dimensions.Time, 3600.0*24.0*365.25, Unit.DisplayOption.Explicit);
		public static Unit SiderialYears = new("SiderialYears", "aₛ", Dimensions.Time, 3600.0*24.0*365.256363004, Unit.DisplayOption.Explicit);
        private static readonly Unit[] units = new Unit[]
                {
            Minutes,
            Hours,
            Days,
            Weeks,
            JulianYears,
            SiderialYears,
                };
        private static readonly Unit[] allUnits = units;
        public override Unit[] GetAllUnits() { return allUnits; }

		private static readonly Unit[] displayUnits = new Unit[]{};

        protected override Unit[] GetDisplayUnits() { return displayUnits; }

		private static readonly Unit[] defaultUnits = new Unit[]{};

        protected override Unit[] GetDefaultUnits() { return defaultUnits; }

    } // end of TimeUnits
}
