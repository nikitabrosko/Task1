using System.Collections.Generic;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.CandyContainerBuilder
{
    public abstract class CandyContainerBuilder : IBuilder<ICandyContainer>
    {
        protected abstract ICandyContainer CandyContainer { get; set; }

        public abstract void CreateCandyBox();

        public abstract void AddSweetness(ISweetness sweetness);

        public abstract void AddSweets(IEnumerable<ISweetness> sweets);

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
