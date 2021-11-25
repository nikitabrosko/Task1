using System;

namespace NewYearPresent.Sweets.ChocolateBars
{
    public abstract class ChocolateBar : SweetnessBase
    {
        public override float AmountOfSugar => (float)Math.Round((Weight / 2) + (Weight % 2), 1);
    }
}