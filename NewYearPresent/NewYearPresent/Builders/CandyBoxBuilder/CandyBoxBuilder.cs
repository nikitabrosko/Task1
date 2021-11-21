using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    abstract class CandyBoxBuilder : IBuilder<CandyBox.CandyBox>
    {
        public abstract CandyBox.CandyBox CandyBox { get; protected set; }

        public abstract void CreateCandyBox();

        public abstract void AddCandies();

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
