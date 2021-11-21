namespace NewYearPresent.Sweets.Candies.ChocolateCandies
{
    class ChocolateCandy : CandyBase
    {
        public new float AmountOfSugar { get; private set; }

        public override void CalculateAmountOfSugar()
        {
            CheckWeight();

            AmountOfSugar = (Weight / 2) + (Weight % 2);
        }
    }
}
