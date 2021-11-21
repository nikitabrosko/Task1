﻿namespace NewYearPresent.Sweets.Candies.CaramelCandies
{
    abstract class CaramelCandy : CandyBase
    {
        public new float AmountOfSugar { get; private set; }

        public override void CalculateAmountOfSugar()
        {
            CheckWeight();

            AmountOfSugar = (Weight / 2.5f) + (Weight % 2);
        }
    }
}
