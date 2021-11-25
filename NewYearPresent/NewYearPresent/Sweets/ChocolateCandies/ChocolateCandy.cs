using System;

namespace NewYearPresent.Sweets.ChocolateCandies
{
    public abstract class ChocolateCandy : SweetnessBase
    {
        public override float AmountOfSugar => (float)Math.Round((Weight / 2) + (Weight % 2), 1);
    }
}
