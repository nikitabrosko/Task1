using System.Collections.Generic;
using System.Linq;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes
{
    public sealed class NewYearCandyBox : CandyContainerBuilder
    {
        protected override ICandyContainer CandyContainer { get; set; }

        public override void CreateCandyContainer()
        {
            CandyContainer = new CandyBox("New Year", "It's a most popular New Year present!");
        }

        public override void AddSweetness(ISweetness sweetness)
        {
            CandyContainer.Add(sweetness);
        }

        public override void AddSweets(IEnumerable<ISweetness> sweets)
        {
            CandyContainer.Add(sweets.ToArray());
        }
    }
}
