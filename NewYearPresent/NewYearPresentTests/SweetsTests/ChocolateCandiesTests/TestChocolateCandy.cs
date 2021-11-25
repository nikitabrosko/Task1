using NewYearPresent.Sweets.ChocolateCandies;

namespace NewYearPresentTests.SweetsTests.ChocolateCandiesTests
{
    public sealed class TestChocolateCandy : ChocolateCandy
    {
        public TestChocolateCandy(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
