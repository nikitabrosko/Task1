using System.Collections.Generic;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    public abstract class CandyBoxBuilder : IBuilder<CandyBox.CandyBox>
    {
        protected abstract CandyBox.CandyBox CandyBox { get; set; }

        public abstract void CreateCandyBox();

        public abstract void AddSweetness(ISweetness sweetness);

        public abstract void AddSweets(IEnumerable<ISweetness> sweets);

        public void Reset()
        {
            CandyBox = new CandyBox.CandyBox("None", "None");
        }

        public CandyBox.CandyBox GetResult()
        {
            return CandyBox;
        }
    }
}
