namespace NewYearPresent.Sweets.ChocolateCandies
{
    public abstract class ChocolateCandy : SweetnessBase
    {
        public override float AmountOfSugar => (Weight / 2) + (Weight % 2);
    }
}
