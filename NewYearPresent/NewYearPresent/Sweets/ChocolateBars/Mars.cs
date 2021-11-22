namespace NewYearPresent.Sweets.ChocolateBars
{
    sealed class Mars : ChocolateBar
    {
        public Mars()
        {
            Name = "Mars";
            Price = 0.3m;
            Weight = 7.5f;

            CalculateAmountOfSugar();
        }
    }
}
