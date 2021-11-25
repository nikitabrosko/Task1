namespace NewYearPresent.Sweets.CaramelCandies
{
    public abstract class CaramelCandy : SweetnessBase
    {
        public override float AmountOfSugar => (Weight / 2.5f) + (Weight % 2);
    }
}
