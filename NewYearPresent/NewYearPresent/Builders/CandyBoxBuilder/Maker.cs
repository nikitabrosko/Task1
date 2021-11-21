using System;
using System.Collections.Generic;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.ChocolateBars;
using NewYearPresent.Sweets.Candies.CaramelCandies;
using NewYearPresent.Sweets.Candies.ChocolateCandies;
using NewYearPresent.Sweets.Candies.GummyCandies;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    sealed class Maker
    {
        private IList<ISweetness> DefaultSweets =>
            new List<ISweetness>()
            {
                new Mars(),
                new Sorvanets(),
                new Jelly(),
                new Malibu()
            };

        public CandyBox.CandyBox MakeDefaultCandyBox(CandyBoxBuilder candyBoxBuilder)
        {
            candyBoxBuilder.CreateCandyBox();
            candyBoxBuilder.AddSweets(DefaultSweets);
            return candyBoxBuilder.GetResult();
        }

        public CandyBox.CandyBox MakeRandomCandyBox(CandyBoxBuilder candyBoxBuilder, int countOfCandies)
        {
            Random random = new Random();

            candyBoxBuilder.CreateCandyBox();

            for (int i = 0; i < countOfCandies; i++)
            {
                candyBoxBuilder.AddSweetness(DefaultSweets[random.Next(0, DefaultSweets.Count - 1)]);
            }

            return candyBoxBuilder.GetResult();
        }

        public CandyBox.CandyBox MakeChocolateCandyBox(CandyBoxBuilder candyBoxBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Sorvanets(),
                new Mars()
            };

            candyBoxBuilder.CreateCandyBox();
            candyBoxBuilder.AddSweets(sweets);

            return candyBoxBuilder.GetResult();
        }

        public CandyBox.CandyBox MakeCaramelCandyBox(CandyBoxBuilder candyBoxBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Malibu()
            };

            candyBoxBuilder.CreateCandyBox();
            candyBoxBuilder.AddSweets(sweets);

            return candyBoxBuilder.GetResult();
        }

        public CandyBox.CandyBox MakeGummyCandyBox(CandyBoxBuilder candyBoxBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Jelly()
            };

            candyBoxBuilder.CreateCandyBox();
            candyBoxBuilder.AddSweets(sweets);

            return candyBoxBuilder.GetResult();
        }
    }
}
