namespace NewYearPresent.Sweets.Candies.GummyCandies
{
    public abstract class GummyCandy : CandyBase
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
