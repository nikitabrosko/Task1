using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes
{
    public sealed class BantikCandyBox : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBox("Bantik", "A Bantik gift box");
        }
    }
}
