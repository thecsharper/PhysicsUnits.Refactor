namespace KMB.Library.Units
{
    public static class Prefixes
    {
        private static (string name, double factor)[] lookup = new[]
        {
            ("yotta",   1.0e24),
            ("zetta",   1.0e21),
            ("exa",     1.0e18),
            ("peta",    1.0e15),
            ("tera",    1.0e12),
            ("giga",    1.0e9),
            ("mega",    1.0e6),
            ("kilo",    1000.0),
            ("hecto",   100.0),
            ("deca",    10.0),
            ("deci",    0.1),
            ("centi",   0.01),
            ("milli",   0.001),
            ("micro",   1.0e-6),
            ("nano",    1.0e-9),
            ("pico",    1.0e-12),
            ("femto",   1.0e-15),
            ("atto",    1.0e-18),
            ("zepto",   1.0e-21),
            ("yocto",   1.0e-24),
        };

        public static bool Parse(string word, out double factor, out string unit)
        {
            factor = 0.0;
            unit = null;
            if (word.Length < 3)
                return false;
            for(int i = 0; i < lookup.Length; i++)
            {
                string s = lookup[i].name;
                if( word.StartsWith(s))
                {
                    factor = lookup[i].factor;
                    unit = word.Substring(s.Length);
                    return true; 
                }
            }
            return false;
        }
    }
}
