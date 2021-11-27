using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBags
{
    public sealed class LarezCandyBag : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBag("Larez", "A Larez gift box");
        }
    }
}
