using System;

namespace NewYearPresent.Sweets.Candies
{
    abstract class CandyBase : ISweetness
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public float Weight { get; protected set; }
        public float AmountOfSugar { get; private set; }

        public virtual void CalculateAmountOfSugar()
        {
            CheckWeight();

            AmountOfSugar = Weight / 2;
        }

        protected void CheckWeight()
        {
            if (Weight == 0)
            {
                throw new ArgumentException("Property Weight can not be 0!");
            }
        }
    }
}