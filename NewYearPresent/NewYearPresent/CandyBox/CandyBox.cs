using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyBox
{
    public class CandyBox
    {
        private IList<ISweetness> _sweets = new List<ISweetness>();

        public IEnumerable<ISweetness> Sweets { get => new ReadOnlyCollection<ISweetness>(_sweets); }
        public string Name { get; }
        public string Description { get; }
        public decimal Price
        {
            get
            {
                decimal totalPrice = 0;

                foreach (var sweetness in _sweets)
                {
                    totalPrice += sweetness.Price;
                }

                return totalPrice;
            }
        }
        public int AmountOfSweets { get => _sweets.Count; }
        public float CurrentWeight
        {
            get
            {
                float totalWeight = 0;

                foreach (var sweetness in _sweets)
                {
                    totalWeight += sweetness.Weight;
                }

                return totalWeight;
            }
        }

        public CandyBox(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Add(ISweetness sweetness)
        {
            _sweets.Add(sweetness);
        }

        public void Add(params ISweetness[] sweets)
        {
            foreach (var sweetness in sweets)
            {
                Add(sweetness);
            }
        }

        public void Remove(ISweetness sweetness)
        {
            _sweets.Remove(sweetness);
        }

        public void RemoveAt(int id)
        {
            if (id >= AmountOfSweets)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            _sweets.Remove(_sweets[id]);
        }

        public void SortBy(SortParameters parameter)
        {
            switch (parameter)
            {
                case SortParameters.Name:
                    _sweets = _sweets.OrderBy(x => x.Name).ToList();
                    break;
                case SortParameters.Price:
                    _sweets = _sweets.OrderBy(x => x.Price).ToList();
                    break;
                case SortParameters.Weight:
                    _sweets = _sweets.OrderBy(x => x.Weight).ToList();
                    break;
                case SortParameters.AmountOfSugar:
                    _sweets = _sweets.OrderBy(x => x.AmountOfSugar).ToList();
                    break;
            }
        }

        public IEnumerable<ISweetness> FindSweetnessWithRangeOfSugarAmount(float min, float max)
        {
            return _sweets.Where(x => x.AmountOfSugar >= min && x.AmountOfSugar <= max);
        }
    }
}