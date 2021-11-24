using System.Collections.Generic;
using System.Linq;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.CandyContainerBuilder
{
    public abstract class CandyContainerBuilder : IBuilder<ICandyContainer>
    {
        protected ICandyContainer CandyContainer { get; set; }

        public abstract void CreateCandyContainer();

        public void AddSweetness(ISweetness sweetness)
        {
            CandyContainer.Add(sweetness);
        }

        public void AddSweets(IEnumerable<ISweetness> sweets)
        {
            CandyContainer.Add(sweets.ToArray());
        }

        public void Reset(ICandyContainer candyContainer)
        {
            CandyContainer = candyContainer;
        }

        public ICandyContainer GetResult()
        {
            return CandyContainer;
        }
    }
}
