namespace KMB.Library.Units
{
    public interface IPhysicalQuantity
    {
        public double Value { get; }
        public Dimensions Dimensions { get; }
    }
}
