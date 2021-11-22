using System;
using System.Collections.Generic;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.Candies.CaramelCandies;
using NewYearPresent.Sweets.Candies.ChocolateCandies;
using NewYearPresent.Sweets.Candies.GummyCandies;
using NewYearPresent.Sweets.ChocolateBars;

namespace NewYearPresent.Builders.CandyContainerBuilder
{
    public class Maker
    {
        private static IList<ISweetness> DefaultSweets =>
            new List<ISweetness>()
            {
                new Mars(),
                new Sorvanets(),
                new Jelly(),
                new Malibu()
            };

        public ICandyContainer MakeDefaultCandyBox(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyBox();
            candyContainerBuilder.AddSweets(DefaultSweets);
            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeRandomCandyBox(CandyContainerBuilder candyContainerBuilder, int countOfCandies)
        {
            var random = new Random();

            candyContainerBuilder.CreateCandyBox();

            for (int i = 0; i < countOfCandies; i++)
            {
                candyContainerBuilder.AddSweetness(DefaultSweets[random.Next(0, DefaultSweets.Count - 1)]);
            }

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeChocolateCandyBox(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Sorvanets(),
                new Mars()
            };

            candyContainerBuilder.CreateCandyBox();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeCaramelCandyBox(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Malibu()
            };

            candyContainerBuilder.CreateCandyBox();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeGummyCandyBox(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new Jelly()
            };

            candyContainerBuilder.CreateCandyBox();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }
    }
}
