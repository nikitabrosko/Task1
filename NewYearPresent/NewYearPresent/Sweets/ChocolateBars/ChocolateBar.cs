namespace NewYearPresent.Sweets.ChocolateBars
{
    public abstract class ChocolateBar : SweetnessBase
    {
        public override float AmountOfSugar => (Weight / 2) + (Weight % 2);
    }
}