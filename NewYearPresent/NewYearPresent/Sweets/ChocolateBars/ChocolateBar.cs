using System;

namespace NewYearPresent.Sweets.ChocolateBars
{
    abstract class ChocolateBar : ISweetness
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public float Weight { get; protected set; }
        public float AmountOfSugar { get; private set; }

        public void CalculateAmountOfSugar()
        {
            if (Weight == 0)
            {
                throw new ArgumentException();
            }

            AmountOfSugar = (Weight / 2) + (Weight % 2);
        }
    }
}