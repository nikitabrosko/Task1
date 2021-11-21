using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Sweets.Candies.CaramelCandies
{
    sealed class Malibu : CaramelCandy
    {
        public Malibu()
        {
            Name = "Malibu";
            Price = 0.6m;
            Weight = 5.4f;

            CalculateAmountOfSugar();
        }
    }
}
