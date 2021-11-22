namespace NewYearPresent.Sweets.Candies.CaramelCandies
{
    public abstract class CaramelCandy : CandyBase
    {
        public override float AmountOfSugar
        {
            get
            {
                CheckWeight();

                return (Weight / 2.5f) + (Weight % 2);
            }
        }
    }
}
