using NewYearPresent.Sweets.ChocolateBars;

namespace NewYearPresentTests.SweetsTests.ChocolateBarsTests
{
    public sealed class TestChocolateBar : ChocolateBar
    {
        public TestChocolateBar(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
