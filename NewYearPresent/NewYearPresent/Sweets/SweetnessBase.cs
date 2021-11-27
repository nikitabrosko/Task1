using System;

namespace NewYearPresent.Sweets
{
    public abstract class SweetnessBase : ISweetness
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public string Name
        {
            get => _name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Name));
                }

                _name = value;
            }
        }
        public decimal Price
        {
            get => _price;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(Price));
                }

                _price = value;
            }
        }
        public float Weight
        {
            get => _weight;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(Weight));
                }

                _weight = value;
            }
        }

        public abstract float AmountOfSugar { get; }
    }
}
