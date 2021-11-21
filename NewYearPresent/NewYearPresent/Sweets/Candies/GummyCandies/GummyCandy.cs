using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Sweets.Candies.GummyCandies
{
    abstract class GummyCandy : CandyBase
    {
        public new float AmountOfSugar { get; private set; }

        public override void CalculateAmountOfSugar()
        {
            CheckWeight();

            AmountOfSugar = (Weight / 3) + (Weight % 2);
        }
    }
}
