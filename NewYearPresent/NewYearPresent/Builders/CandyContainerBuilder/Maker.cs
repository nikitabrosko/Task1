using System;
using System.Collections.Generic;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.CaramelCandies;
using NewYearPresent.Sweets.ChocolateBars;
using NewYearPresent.Sweets.ChocolateCandies;
using NewYearPresent.Sweets.GummyCandies;

namespace NewYearPresent.Builders.CandyContainerBuilder
{
    public class Maker
    {
        private static IList<CaramelCandy> CaramelCandies =>
            new List<CaramelCandy>()
            {
                new MalibuCaramelCandy(),
                new AlenkaCaramelCandy(),
                new LollipopCaramelCandy(),
                new MolochnayaCaramelCandy(),
                new ZubastikiCaramelCandy()
            };
        private static IList<ChocolateBar> ChocolateBars =>
            new List<ChocolateBar>()
            {
                new MarsChocolateBar(),
                new BountyChocolateBar(),
                new KitKatChocolateBar(),
                new LionChocolateBar(),
                new SnickersChocolateBar()
            };
        private static IList<ChocolateCandy> ChocolateCandies =>
            new List<ChocolateCandy>()
            {
                new SorvanetsChocolateCandy(),
                new AlenkaChocolateCandy(),
                new KommunarkaChocolateCandy(),
                new KuznechikChocolateCandy(),
                new MinchankaChocolateCandy()
            };
        private static IList<GummyCandy> GummyCandies =>
            new List<GummyCandy>()
            {
                new JellyGummyCandy(),
                new CrazyBeeGummyCandy(),
                new GummyBearGummyCandy(),
                new HariboGummyCandy(),
                new MatreshkaGummyCandy()
            };

        private static IList<ISweetness> GetAllSweets()
        {
            IList<ISweetness> sweets = new List<ISweetness>();

            foreach (var caramelCandy in CaramelCandies)
            {
                sweets.Add(caramelCandy);
            }

            foreach (var chocolateBar in ChocolateBars)
            {
                sweets.Add(chocolateBar);
            }

            foreach (var chocolateCandy in ChocolateCandies)
            {
                sweets.Add(chocolateCandy);
            }

            foreach (var gummyCandy in GummyCandies)
            {
                sweets.Add(gummyCandy);
            }

            return sweets;
        }

        public static ICandyContainer MakeDefaultCandyContainer(CandyContainerBuilder candyContainerBuilder)
        {
            candyContainerBuilder.CreateCandyContainer();
            candyContainerBuilder.AddSweets(GetAllSweets());
            return candyContainerBuilder.GetResult();
        }

        public static ICandyContainer MakeRandomCandyContainer(CandyContainerBuilder candyContainerBuilder, int countOfCandies)
        {
            var random = new Random();

            var sweets = GetAllSweets();

            candyContainerBuilder.CreateCandyContainer();

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
