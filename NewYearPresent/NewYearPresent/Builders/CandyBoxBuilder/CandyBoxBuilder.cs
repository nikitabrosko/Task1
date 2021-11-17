using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    abstract class CandyBoxBuilder : IBuilder<CandyBox.CandyBox>
    {
        public abstract CandyBox.CandyBox CandyBox { get; set; }

        public void CreateCandyBox()
        {
            CandyBox = new CandyBox.CandyBox();
        }

        public abstract void SetName();
        public abstract void SetSize();
        public abstract void SetDescription();
        public abstract void SetSweets();
        public abstract void SetPrice();
        public abstract void SetCurrentWeight();
        public abstract void SetAmountOfSweets();

        public void Reset()
        {
            CandyBox = new CandyBox.CandyBox();
        }

        public CandyBox.CandyBox GetResult()
        {
            return CandyBox;
        }
    }
}
