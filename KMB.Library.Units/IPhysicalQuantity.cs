namespace KMB.Library.Units
{
    public interface IPhysicalQuantity
    {
        double Value { get; }
        Dimensions Dimensions { get; }
    }
}
