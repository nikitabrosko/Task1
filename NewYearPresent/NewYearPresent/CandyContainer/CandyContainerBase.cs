using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyContainer
{
    public abstract class CandyContainerBase : ICandyContainer
    {
        private IList<ISweetness> _sweets = new List<ISweetness>();
        private string _name;
        private string _description;

        public IEnumerable<ISweetness> Sweets  => new ReadOnlyCollection<ISweetness>(_sweets);

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

        public string Description
        {
            get => _description;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Description));
                }

                _description = value;
            }
        }

        public decimal Price => _sweets.Sum(sweetness => sweetness.Price);

        public int AmountOfSweets => _sweets.Count;

        public float CurrentWeight => _sweets.Sum(sweetness => sweetness.Weight);

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

        public virtual void SortBy(SortParameters sortParameter)
        {
            switch (sortParameter)
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
