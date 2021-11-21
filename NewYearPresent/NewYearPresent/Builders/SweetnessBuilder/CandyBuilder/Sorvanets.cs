using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Sweets;

namespace NewYearPresent.Builders.SweetnessBuilder.CandyBuilder
{
    class Sorvanets : ISweetness
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public float AmountOfSugar { get; set; }

        public Sorvanets()
        {
            Name = "Sorvanets";
            Price = 0.5m;
            Weight = 8.9f;
            AmountOfSugar = 3.5f;
        }
    }
}
