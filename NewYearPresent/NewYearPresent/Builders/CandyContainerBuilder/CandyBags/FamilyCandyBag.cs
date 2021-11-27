using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBags
{
    public sealed class FamilyCandyBag : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBag("Family", "A Family gift box");
        }
    }
}
