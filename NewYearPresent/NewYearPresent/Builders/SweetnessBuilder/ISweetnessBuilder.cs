using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder
{
    interface ISweetnessBuilder : IBuilder<ISweetness>
    {
        ISweetness Sweetness { get; set; }

        void CreateSweetness();
        void SetName();
        void SetPrice();
        void SetWeight();
        void SetAmountOfSugar();
    }
}
