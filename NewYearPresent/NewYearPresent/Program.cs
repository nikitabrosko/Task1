using System;
using System.Linq;
using NewYearPresent.Builders.CandyContainerBuilder;
using NewYearPresent.CandyContainer;

namespace NewYearPresent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maker = new Maker();

            var randomCandyBox = maker.MakeRandomCandyBox(new NewYear(), 100);

            PrintCandyBox(randomCandyBox);

            Sort(randomCandyBox);

            PrintCandyBox(randomCandyBox);

            PrintSweetsInRangeOfSugar(randomCandyBox);
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

        public static void PrintCandyBox(ICandyContainer candyContainer)
        {
            Console.WriteLine(string.Concat(
                Environment.NewLine, "Candy Box",
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