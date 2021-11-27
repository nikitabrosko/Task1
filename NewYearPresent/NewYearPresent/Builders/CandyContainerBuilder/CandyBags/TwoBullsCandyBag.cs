using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBags
{
    public sealed class TwoBullsCandyBag : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBag("Two Bulls", "A Two Bulls gift box");
        }
    }
}
