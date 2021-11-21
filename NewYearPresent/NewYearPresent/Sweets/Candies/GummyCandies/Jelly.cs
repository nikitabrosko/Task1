namespace NewYearPresent.Sweets.Candies.GummyCandies
{
    sealed class Jelly : GummyCandy
    {
        public Jelly()
        {
            Name = "Jelly";
            Price = 0.4m;
            Weight = 6.3f;

            CalculateAmountOfSugar();
        }
    }
}
