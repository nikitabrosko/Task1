using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    class Maker
    {
        public CandyBox.CandyBox Make(CandyBoxBuilder candyBoxBuilder)
        {
            candyBoxBuilder.CreateCandyBox();
            candyBoxBuilder.SetName();
            candyBoxBuilder.SetSize();
            candyBoxBuilder.SetDescription();
            candyBoxBuilder.SetSweets();
            candyBoxBuilder.SetPrice();
            candyBoxBuilder.SetCurrentWeight();
            candyBoxBuilder.SetAmountOfSweets();
            return candyBoxBuilder.GetResult();
        }
    }
}
