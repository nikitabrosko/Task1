using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes
{
    public sealed class FieldOfDreamsCandyBox : CandyContainerBuilder
    {
        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBox("Field of Dreams", "A Field of Dreams gift box");
        }
    }
}
