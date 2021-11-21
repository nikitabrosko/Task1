namespace NewYearPresent.Sweets.Candies.GummyCandies
{
    abstract class GummyCandy : CandyBase
    {
        public new float AmountOfSugar { get; private set; }

        public override void CalculateAmountOfSugar()
        {
            CheckWeight();

            AmountOfSugar = (Weight / 3) + (Weight % 2);
        }
    }
}
