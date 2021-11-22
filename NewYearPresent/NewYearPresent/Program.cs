using System;
using System.Linq;
using NewYearPresent.Builders.CandyContainerBuilder;
using NewYearPresent.Builders.CandyContainerBuilder.CandyBags;
using NewYearPresent.Builders.CandyContainerBuilder.CandyBoxes;
using NewYearPresent.CandyContainer;

namespace NewYearPresent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maker = new Maker();

            var randomCandyBox = maker.MakeRandomCandyContainer(new NewYearCandyBox(), 100);
            var randomCandyBag = maker.MakeRandomCandyContainer(new NewYearCandyBag(), 30);

            PrintCandyContainer(randomCandyBox);
            Sort(randomCandyBox);
            PrintCandyContainer(randomCandyBox);
            PrintSweetsInRangeOfSugar(randomCandyBox);

            PrintCandyContainer(randomCandyBag);
            Sort(randomCandyBag);
            PrintCandyContainer(randomCandyBag);
            PrintSweetsInRangeOfSugar(randomCandyBag);
        }

        public static void PrintSweetsInRangeOfSugar(ICandyContainer candyContainer)
        {
            float min = 3.4f;
            float max = 6.4f;

            Console.WriteLine();

            var sweets = candyContainer.FindSweetnessWithRangeOfSugarAmount(min, max)
                .GroupBy(x => x.Name)
                .Select(x => x.First());

            foreach (var sweetness in sweets)
            {
                Console.WriteLine(string.Concat(
                    "Name " + sweetness.Name,
                    " Price " + sweetness.Price,
                    " Weight " + sweetness.Weight,
                    " Amount of sugar: " + sweetness.AmountOfSugar));

                var countOfSweetness = candyContainer.Sweets
                    .Count(x => x.Name.Equals(sweetness.Name));

                Console.WriteLine("Count of this sweetness: " + countOfSweetness);
            }

            Console.WriteLine();
        }

        public static void Sort(ICandyContainer candyContainer)
        {
            candyContainer.SortBy(SortParameters.Name);
        }

        public static void PrintCandyContainer(ICandyContainer candyContainer)
        {
            Console.WriteLine(string.Concat(
                Environment.NewLine, candyContainer.GetType(),
                Environment.NewLine, "Name: " + candyContainer.Name,
                Environment.NewLine, "Description: " + candyContainer.Description,
                Environment.NewLine, "Price: $" + candyContainer.Price,
                Environment.NewLine, "Weight: " + candyContainer.CurrentWeight + "g",
                Environment.NewLine, "Amount of sweets: " + candyContainer.AmountOfSweets,
                Environment.NewLine, "Sweets in a box: "));

            var sweets = candyContainer.Sweets
                .GroupBy(x => x.Name)
                .Select(g => g.First());

            foreach (var sweetness in sweets)
            {
                var countOfSweets = candyContainer.Sweets
                    .Count(x => x.Name.Equals(sweetness.Name));

                Console.Write($"{sweetness.Name}({countOfSweets}) ");
            }

            Console.WriteLine();
        }
    }
}