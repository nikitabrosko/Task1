using System;
using System.Linq;
using NewYearPresent.Builders.CandyBoxBuilder;
using NewYearPresent.CandyBox;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            Maker maker = new Maker();

            CandyBox.CandyBox randomCandyBox = maker.MakeRandomCandyBox(new NewYear(), 100);

            PrintCandyBox(randomCandyBox);

            Sort(randomCandyBox);

            PrintCandyBox(randomCandyBox);

            PrintSweetsInRangeOfSugar(randomCandyBox);
        }

        public static void PrintSweetsInRangeOfSugar(CandyBox.CandyBox candyBox)
        {
            float min = 3.4f;
            float max = 6.4f;

            Console.WriteLine();

            var sweets = candyBox.FindSweetnessWithRangeOfSugarAmount(min, max)
                .GroupBy(x => x.Name)
                .Select(x => x.First());

            foreach (var sweetness in sweets)
            {
                Console.WriteLine(String.Concat(
                    "Name " + sweetness.Name,
                    " Price " + sweetness.Price,
                    " Weight " + sweetness.Weight,
                    " Amount of sugar: " + sweetness.AmountOfSugar));

                var countOfSweetness = candyBox.Sweets
                    .Count(x => x.Name.Equals(sweetness.Name));

                Console.WriteLine("Count of this sweetness: " + countOfSweetness);
            }

            Console.WriteLine();
        }

        public static void Sort(CandyBox.CandyBox candyBox)
        {
            candyBox.SortBy(SortParameters.Name);
        }

        public static void PrintCandyBox(CandyBox.CandyBox candyBox)
        {
            Console.WriteLine(String.Concat(
                Environment.NewLine, "Candy Box",
                Environment.NewLine, "Name: " + candyBox.Name,
                Environment.NewLine, "Description: " + candyBox.Description,
                Environment.NewLine, "Price: $" + candyBox.Price,
                Environment.NewLine, "Weight: " + candyBox.CurrentWeight + "g",
                Environment.NewLine, "Amount of sweets: " + candyBox.AmountOfSweets,
                Environment.NewLine, "Sweets in a box: "));

            var sweets = candyBox.Sweets
                .GroupBy(x => x.Name)
                .Select(g => g.First());

            foreach (var sweetness in sweets)
            {
                var countOfSweets = candyBox.Sweets
                    .Count(x => x.Name.Equals(sweetness.Name));

                Console.Write($"{sweetness.Name}({countOfSweets}) ");
            }

            Console.WriteLine();
        }
    }
}