namespace NewYearPresent.Sweets.GummyCandies
{
    public abstract class GummyCandy : SweetnessBase
    {
        public override float AmountOfSugar => (Weight / 3) + (Weight % 2);
    }
}
