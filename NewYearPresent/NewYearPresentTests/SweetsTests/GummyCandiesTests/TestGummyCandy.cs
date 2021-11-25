using NewYearPresent.Sweets.GummyCandies;

namespace NewYearPresentTests.SweetsTests.GummyCandiesTests
{
    public sealed class TestGummyCandy : GummyCandy
    {
        public TestGummyCandy(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
