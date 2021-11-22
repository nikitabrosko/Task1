using System;

namespace NewYearPresent.Sweets.Candies
{
    public abstract class CandyBase : ISweetness
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public float Weight { get; protected set; }

        public virtual float AmountOfSugar
        {
            get
            {
                CheckWeight();

                return Weight / 2;
            }
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