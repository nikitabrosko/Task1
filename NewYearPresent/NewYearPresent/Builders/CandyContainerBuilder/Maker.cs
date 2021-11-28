using System;
using System.Collections.Generic;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.CaramelCandies;
using NewYearPresent.Sweets.ChocolateBars;
using NewYearPresent.Sweets.ChocolateCandies;
using NewYearPresent.Sweets.GummyCandies;
using System.Linq;

namespace NewYearPresent.Builders.CandyContainerBuilder
{
    public class Maker
    {
        private static IList<ISweetness> CaramelCandies =>
            new List<ISweetness>()
            {
                new MalibuCaramelCandy(),
                new AlenkaCaramelCandy(),
                new LollipopCaramelCandy(),
                new MolochnayaCaramelCandy(),
                new ZubastikiCaramelCandy()
            };

        private static IList<ISweetness> ChocolateBars =>
            new List<ISweetness>()
            {
                new MarsChocolateBar(),
                new BountyChocolateBar(),
                new KitKatChocolateBar(),
                new LionChocolateBar(),
                new SnickersChocolateBar()
            };

        private static IList<ISweetness> ChocolateCandies =>
            new List<ISweetness>()
            {
                new SorvanetsChocolateCandy(),
                new AlenkaChocolateCandy(),
                new KommunarkaChocolateCandy(),
                new KuznechikChocolateCandy(),
                new MinchankaChocolateCandy()
            };

        private static IList<ISweetness> GummyCandies =>
            new List<ISweetness>()
            {
                new JellyGummyCandy(),
                new CrazyBeeGummyCandy(),
                new GummyBearGummyCandy(),
                new HariboGummyCandy(),
                new MatreshkaGummyCandy()
            };

        private static IEnumerable<ISweetness> AllSweets =>
            CaramelCandies.Union(ChocolateBars).Union(ChocolateCandies).Union(GummyCandies);

        public static ICandyContainer MakeDefaultCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(AllSweets);
            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeRandomCandyContainer(CandyContainerBuilder candyContainerBuilder, int countOfCandies)
        {
            var random = new Random();
            candyContainerBuilder.CreateCandyContainer();

            var sweets = AllSweets.ToList();

            for (int i = 0; i < countOfCandies; i++)
            {
                candyContainerBuilder.AddSweetness(sweets[random.Next(0, sweets.Count - 1)]);
            }

            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeChocolateCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(ChocolateCandies);

            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeCaramelCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(CaramelCandies);

            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeGummyCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(GummyCandies);

            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeChocolateBarContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(ChocolateBars);

            return candyContainerBuilder.GetResult();
        }
    }
}
