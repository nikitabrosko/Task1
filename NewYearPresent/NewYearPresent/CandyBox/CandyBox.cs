using System.Collections.Generic;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyBox
{
    public class CandyBox
    {
        private ICollection<ISweetness> _sweets = new List<ISweetness>();
        private decimal _price;
        private float _amountOfSweets;
        private float _currentWeight;

        public IEnumerable<ISweetness> Sweets{ get => _sweets; }
        public string Name { get; set; }
        public Size MaxWeight { get; set; }
        public string Description { get; set; }
        public decimal Price
        {
            get
            {
                _price = 0;

                foreach (var sweetness in _sweets)
                {
                    _price += sweetness.Price;
                }

                return _price;
            }
            private set => _price = value;
        }
        public float AmountOfSweets
        {
            get => _sweets.Count;
            private set => _amountOfSweets = value;
        }
        public float CurrentWeight
        {
            get
            {
                _currentWeight = 0;

                foreach (var sweetness in _sweets)
                {
                    _currentWeight += sweetness.Weight;
                }

                return _currentWeight;
            }
            private set => _currentWeight = value;
        }

        public CandyBox(string name, Size size, string description)
        {
            Name = name;
            MaxWeight = size;
            Description = description;
            Price = 0;
            AmountOfSweets = 0;
            CurrentWeight = 0;
        }

        public void Add(ISweetness sweetness)
        {
            _sweets.Add(sweetness);
        }

        public void Add(IEnumerable<ISweetness> sweets)
        {
            foreach (var sweetness in sweets)
            {
                Add(sweetness);
            }
        }
    }
}