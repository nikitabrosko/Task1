using System;

namespace NewYearPresent.Sweets.GummyCandies
{
    public abstract class GummyCandy : SweetnessBase
    {
        public override float AmountOfSugar => (float)Math.Round((Weight / 3) + (Weight % 2), 1);
    }
}
