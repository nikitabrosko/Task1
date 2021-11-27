using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes
{
    public sealed class CoolStoryCandyBox : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBox("Cool Story", "A Cool Story gift box");
        }
    }
}
