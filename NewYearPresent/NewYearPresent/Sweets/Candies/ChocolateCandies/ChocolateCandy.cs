namespace NewYearPresent.Sweets.Candies.ChocolateCandies
{
    abstract class ChocolateCandy : CandyBase
    {
        public override float AmountOfSugar
        {
            get
            {
                CheckWeight();

                return (Weight / 2) + (Weight % 2);
            }
        }
    }
}
