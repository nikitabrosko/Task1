using System.Collections.Generic;
using System.Linq;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    sealed class NewYear : CandyBoxBuilder
    {
        public override CandyBox.CandyBox CandyBox { get; protected set; }

        public override void CreateCandyBox()
        {
            CandyBox = new CandyBox.CandyBox("New Year", "It's a most popular New Year present!");
        }

        public override void AddSweetness(ISweetness sweetness)
        {
            CandyBox.Add(sweetness);
        }

        public override void AddSweets(IEnumerable<ISweetness> sweets)
        {
            CandyBox.Add(sweets.ToArray());
        }
    }
}
