using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.CandyBox;
using NewYearPresent.Sweets.ChocolateBars;
using NewYearPresent.Sweets.Candies.CaramelCandies;
using NewYearPresent.Sweets.Candies.ChocolateCandies;
using NewYearPresent.Sweets.Candies.GummyCandies;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    sealed class NewYear : CandyBoxBuilder
    {
        public override CandyBox.CandyBox CandyBox { get; protected set; }
        public override void CreateCandyBox()
        {
            CandyBox = new CandyBox.CandyBox("new Year", "It's a most popular New Year present!");
        }

        public override void AddCandies()
        {
            CandyBox.Add(new Mars(), new Sorvanets(), new Malibu(), new Jelly());
        }
    }
}
