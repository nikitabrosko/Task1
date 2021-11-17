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

            var candyBoxesRepository = new CandyBoxRepository();
            candyBoxesRepository.GetAll();

            Print(candyBoxesRepository.CandyBoxes.ToList()[1]);
            Sort(candyBoxesRepository.CandyBoxes.ToList()[1]);
            PrintAllSweets(candyBoxesRepository.CandyBoxes.ToList()[1]);
            PrintSweetsInRangeOfSugar(candyBoxesRepository.CandyBoxes.ToList()[1]);
        }

        public static void PrintSweetsInRangeOfSugar(CandyBox.CandyBox candyBox)
        {
            Console.WriteLine("Do you want to find sweets with range of sugar amount?");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                try
                {
                    Console.WriteLine("Write the Min number of range");
                    int min = int.Parse(Console.ReadLine());

                    Console.WriteLine("Write the Max number of range");
                    int max = int.Parse(Console.ReadLine());

                    foreach (var sweetness in candyBox.FindSweetnessWithRangeOfSugarAmount(min, max))
                    {
                        Console.WriteLine(String.Concat(
                            "Name " + sweetness.Name,
                            " Price " + sweetness.Price,
                            " Weight " + sweetness.Weight,
                            " Amount of sugar: " + sweetness.AmountOfSugar));
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You didn't type anything!\n Try again?");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        PrintSweetsInRangeOfSugar(candyBox);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You type a wrong number!\n Try again?");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        PrintSweetsInRangeOfSugar(candyBox);
                    }
                }
            }

            Console.WriteLine();
        }

        public static void PrintAllSweets(CandyBox.CandyBox candyBox)
        {
            Console.WriteLine();

            foreach (var sweetness in candyBox.Sweets)
            {
                Console.WriteLine(String.Concat(
                    "Name " + sweetness.Name,
                    " Price " + sweetness.Price,
                    " Weight " + sweetness.Weight,
                    " Amount of sugar: " + sweetness.AmountOfSugar));
            }

            Console.WriteLine();
        }

        public static void Sort(CandyBox.CandyBox candyBox)
        {
            Console.WriteLine("Do you want to sort your Candy Box?");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Type the parameter (Name, Price, Weight, Sugar)");

                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "name":
                            candyBox.SortBy(SortParameters.Name);
                            break;
                        case "price":
                            candyBox.SortBy(SortParameters.Price);
                            break;
                        case "weight":
                            candyBox.SortBy(SortParameters.Weight);
                            break;
                        case "sugar":
                            candyBox.SortBy(SortParameters.AmountOfSugar);
                            break;
                        default:
                            throw new ArgumentException("Incorrect write!");
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("You didn't type anything!\nTry again?");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Sort(candyBox);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You type a wrong word!\nTry again?");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Sort(candyBox);
                    }
                }
            }
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