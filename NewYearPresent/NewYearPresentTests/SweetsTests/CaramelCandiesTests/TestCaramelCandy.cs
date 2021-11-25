using NewYearPresent.Sweets.CaramelCandies;

namespace NewYearPresentTests.SweetsTests.CaramelCandiesTests
{
    public sealed class TestCaramelCandy : CaramelCandy
    {
        public TestCaramelCandy(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
