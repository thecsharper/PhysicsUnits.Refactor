using Xunit;

using KMB.Library.Units;
using KMB.Library.Units.British;

namespace UnitTests.Fundamental.Measures
{
    [Trait("Category", "BritishUnits")]
    public class BritishUnitsTests : TestBase
    {
        [Fact]
        public void BritishUnits_Tests()
        {
            var l1 = 5.Feet() + 4.Inches();
            TestString("l1", 1.6256, "1.6256 m", l1);

            string s = l1.ToString(BritishUnits.Feet, BritishUnits.Inches);
            Check.Equal("5 ft 4 in", s, "wrong value for l1.ToString()");

            var l2 = 26.Miles() + 385.Yards();
            TestString("l2", 42194.988, "42.194988 km", l2);
            s = l2.ToString(BritishUnits.Miles, BritishUnits.Yards);
            Check.Equal("26 mi 385 yd", s, "wrong value for l2.ToString()");

            var m1 = 9.Stones() + 11.Pounds();
            TestString("m1", 62.14215469, "62.1421547 kg", m1);
            s = m1.ToString(BritishUnits.Stones, BritishUnits.Pounds);
            Check.Equal("9 st 11 lb", s, "wrong value for m1.ToString()");

            var l3 = new BritishUnits().DoParse("5 ft 4 in");
            TestString("l3", 1.6256, "1.6256 m", l3);
        }
    }
}
