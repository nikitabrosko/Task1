using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder.CandyBuilder
{
    class Sorvanets : CandyBuilder
    {
        public override ISweetness Sweetness { get; set; }

        public override void SetName()
        {
            Sweetness.Name = "Sorvanets";
        }

        public override void SetPrice()
        {
            Sweetness.Price = 0.35m;
        }

        public override void SetWeight()
        {
            Sweetness.Weight = 8.7f;
        }

        public override void SetAmountOfSugar()
        {
            Sweetness.AmountOfSugar = 4.3f;
        }
    }
}
