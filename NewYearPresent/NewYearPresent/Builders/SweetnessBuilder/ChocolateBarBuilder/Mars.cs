using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder.ChocolateBarBuilder
{
    class Mars : ChocolateBarBuilder
    {
        public override ISweetness Sweetness { get; set; }

        public override void SetName()
        {
            Sweetness.Name = "Mars";
        }

        public override void SetPrice()
        {
            Sweetness.Price = 1.5m;
        }

        public override void SetWeight()
        {
            Sweetness.Weight = 55.6f;
        }

        public override void SetAmountOfSugar()
        {
            Sweetness.AmountOfSugar = 25.3f;
        }
    }
}
