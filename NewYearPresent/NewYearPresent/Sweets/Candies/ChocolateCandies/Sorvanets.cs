namespace NewYearPresent.Sweets.Candies.ChocolateCandies
{
    sealed class Sorvanets : ChocolateCandy
    {
        public Sorvanets()
        {
            Name = "Sorvanets";
            Price = 0.5m;
            Weight = 8.9f;

            CalculateAmountOfSugar();
        }
    }
}
