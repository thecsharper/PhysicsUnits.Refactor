// Keith Barrett 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMB.Library.Units
{
    public class Unit
    {
        public string Name;
        public string ShortName;
        public Dimensions Dimensions;
        public double ConversionFactor; //to convert from ISO units
        public enum DisplayOption
        {
            Standard,   // this is the default unit for the standard
            Multi,      // can be used as best fit or in multiple format
            Explicit    // can be used explicitly in a format
        };
        public DisplayOption displayOption;

        public bool Default { get { return displayOption == DisplayOption.Standard; } }

        public Unit(string name, string shortname, Dimensions dim, double conv, DisplayOption opt = DisplayOption.Explicit)
        {
            Name = name;
            ShortName = shortname;
            Dimensions = dim;
            ConversionFactor = conv;
            displayOption = opt;
        }

        public override string ToString()
        {
            return ShortName;
        }

        internal string FormatValue(double SIValue)
        {
            // The value will be in SI Units
            return string.Format("{0:G9} {1}", ConvertValueFromSI(SIValue), ShortName);
        }

        internal double ConvertValueFromSI(IPhysicalQuantity pq)
        {
            // the dimensions have to match
            Check.True(Dimensions == pq.Dimensions, "Dimensions must match");
            return ConvertValueFromSI(pq.Value);
        }

        internal virtual double ConvertValueFromSI(double value)
        {
            return value / ConversionFactor;
        }

        internal virtual double ConvertValueToSI(double value)
        {
            return value * ConversionFactor;
        }
    }
}
