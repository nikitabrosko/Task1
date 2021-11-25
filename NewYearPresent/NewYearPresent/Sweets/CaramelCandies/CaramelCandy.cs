using System;

namespace NewYearPresent.Sweets.CaramelCandies
{
    public abstract class CaramelCandy : SweetnessBase
    {
        public override float AmountOfSugar => (float)Math.Round((Weight / 2.5f) + (Weight % 2), 1);
    }
}
