using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes
{
    public sealed class NewYearCandyBox : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBox("New Year", "It's a most popular New Year present!");
        }
    }
}
