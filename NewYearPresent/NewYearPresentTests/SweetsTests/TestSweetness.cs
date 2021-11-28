using NewYearPresent.Sweets.ChocolateCandies;

namespace NewYearPresentTests.SweetsTests
{
    public sealed class TestSweetness : ChocolateCandy
    {
        public TestSweetness(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
