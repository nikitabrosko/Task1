using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBags
{
    public sealed class NewYearCandyBag : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBag("New Year", "It's a most popular New Year present!");
        }
    }
}
