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
                new MarsChocolateBar(),
                new SorvanetsChocolateCandy(),
                new JellyGummyCandy(),
                new MalibuCaramelCandy()
            };

        public ICandyContainer MakeDefaultCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(DefaultSweets);
            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeRandomCandyContainer(CandyContainerBuilder candyContainerBuilder, int countOfCandies)
        {
            var random = new Random();

            candyContainerBuilder.CreateCandyContainer();

            for (int i = 0; i < countOfCandies; i++)
            {
                candyContainerBuilder.AddSweetness(DefaultSweets[random.Next(0, DefaultSweets.Count - 1)]);
            }

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeChocolateCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new SorvanetsChocolateCandy(),
                new MarsChocolateBar()
            };

            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeCaramelCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new MalibuCaramelCandy()
            };

            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }

        public ICandyContainer MakeGummyCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            IList<ISweetness> sweets = new List<ISweetness>()
            {
                new JellyGummyCandy()
            };

            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(sweets);

            return candyContainerBuilder.GetResult();
        }
    }
}
