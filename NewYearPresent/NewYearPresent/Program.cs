using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using NewYearPresent.CandyBox;
using NewYearPresent.Repository;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            var sweetnessRepository = new SweetnessRepository();
            sweetnessRepository.GetAll();

            var candyBox = new CandyBox.CandyBox("New Year", Size.Medium, "It's a most popular New Year's present!");
            candyBox.Add(sweetnessRepository.Sweets);

            Print(candyBox);
        }

        public static void Print(CandyBox.CandyBox candyBox)
        {
            Console.WriteLine(String.Concat(
                Environment.NewLine, "Candy Box", 
                Environment.NewLine, "Name: " + candyBox.Name, 
                Environment.NewLine, "Size: " + candyBox.MaxWeight,
                Environment.NewLine, "Description: " + candyBox.Description,
                Environment.NewLine, "Price: " + candyBox.Price,
                Environment.NewLine, "Weight: " + candyBox.CurrentWeight + "g",
                Environment.NewLine, "Amount of sweets: " + candyBox.AmountOfSweets,
                Environment.NewLine, "Sweets in a box: "));

            var sweets = candyBox.Sweets
                .GroupBy(x => x.Name)
                .Select(g => g.First());

            foreach (var sweet in sweets)
            {
                var countOfSweets = candyBox.Sweets
                    .Count(x => x.Equals(sweet));

                Console.Write($"{sweet.Name}({countOfSweets}) ");
            }

            Console.WriteLine();
        }
    }
}
