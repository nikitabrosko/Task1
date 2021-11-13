﻿namespace NewYearPresent.Sweets
{
    public class Candy : ISweetness
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ushort Weight { get; set; }
        public float AmountOfSugar { get; set; }

        public Candy(string name, decimal price, ushort weight, float amountOfSugar)
        {
            Name = name;
            Price = price;
            Weight = weight;
            AmountOfSugar = amountOfSugar;
        }
    }
}