using KMB.Library.Units;

namespace UnitTests
{
    public class TestBase
    { 
        protected static void TestString(string varName, double expectedValue, string expectedString, IPhysicalQuantity l1)
        {
            Check.Equal(expectedValue, l1.Value, $"wrong value for {varName}: {l1.Value}");
            Check.Equal(expectedString, l1.ToString(), "wrong value for {varName}.ToString()");
        }
    }
}
