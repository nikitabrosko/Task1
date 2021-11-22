namespace NewYearPresent.Sweets.Candies.GummyCandies
{
    abstract class GummyCandy : CandyBase
    {
        public override float AmountOfSugar
        {
            get
            {
                CheckWeight();

                return (Weight / 3) + (Weight % 2);
            }
        }
    }
}
