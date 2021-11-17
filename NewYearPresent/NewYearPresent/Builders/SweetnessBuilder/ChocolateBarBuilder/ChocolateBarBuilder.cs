using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder.ChocolateBarBuilder
{
    abstract class ChocolateBarBuilder : ISweetnessBuilder
    {
        public abstract ISweetness Sweetness { get; set; }

        public void CreateSweetness()
        {
            Sweetness = new ChocolateBar();
        }

        public abstract void SetName();
        public abstract void SetPrice();
        public abstract void SetWeight();
        public abstract void SetAmountOfSugar();

        public void Reset()
        {
            Sweetness = new ChocolateBar();
        }

        public ISweetness GetResult()
        {
            return Sweetness;
        }
    }
}
