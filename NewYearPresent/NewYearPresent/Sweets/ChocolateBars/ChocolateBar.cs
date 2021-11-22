using System;

namespace NewYearPresent.Sweets.ChocolateBars
{
    public abstract class ChocolateBar : ISweetness
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public float Weight { get; protected set; }
        public virtual float AmountOfSugar 
        {
            get
            {
                if (Weight == 0)
                {
                    throw new ArgumentException();
                }

                return (Weight / 2) + (Weight % 2);
            }
        }
    }
}