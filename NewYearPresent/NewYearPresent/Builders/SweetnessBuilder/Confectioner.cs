using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder
{
    class Confectioner
    {
        public ISweetness Make(ISweetnessBuilder sweetnessBuilder)
        {
            sweetnessBuilder.CreateSweetness();
            sweetnessBuilder.SetName();
            sweetnessBuilder.SetPrice();
            sweetnessBuilder.SetWeight();
            sweetnessBuilder.SetAmountOfSugar();
            return sweetnessBuilder.GetResult();
        }
    }
}
