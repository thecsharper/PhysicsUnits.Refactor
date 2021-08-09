// Keith Barrett 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMB.Library.Units
{
    public partial struct Dimensionless : IPhysicalQuantity
    {

        static public implicit operator Dimensionless(int value)
        {
            return new Dimensionless(value);
        }

        static public implicit operator Dimensionless(double value)
        {
            return new Dimensionless(value);
        }

        public static implicit operator double(Dimensionless v)
        {
            return v.Value;
        }
    }
}
