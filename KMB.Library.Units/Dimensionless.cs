namespace KMB.Library.Units
{
    public partial struct Dimensionless : IPhysicalQuantity
    {

        public static implicit operator Dimensionless(int value)
        {
            return new Dimensionless(value);
        }

        public static implicit operator Dimensionless(double value)
        {
            return new Dimensionless(value);
        }

        public static implicit operator double(Dimensionless v)
        {
            return v.Value;
        }
    }
}
