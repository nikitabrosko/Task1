using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyBox
{
    public class CandyBox
    {
        private ICollection<ISweetness> _sweets = new List<ISweetness>();
        private bool _isWeightExceeded = false;

        public IEnumerable<ISweetness> Sweets{ get => _sweets; }
        public string Name { get; set; }
        public Size MaxWeight { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmountOfSweets { get; set; }
        public float CurrentWeight { get; set; }

        private void CheckCurrentWeightState(ISweetness sweetness)
        {
            if ((CurrentWeight + sweetness.Weight) >= (ushort)MaxWeight)
            {
                _isWeightExceeded = true;
            }
        }

        public void Add(ISweetness sweetness)
        {
            CheckCurrentWeightState(sweetness);

            if (!_isWeightExceeded)
            {
                _sweets.Add(sweetness);
            }
        }

        public void Add(params ISweetness[] sweets)
        {
            foreach (var sweetness in sweets)
            {
                Add(sweetness);
            }
        }

        public void GenerateRandomCandyBox(IList<ISweetness> sweets)
        {
            Random random = new Random();

            while (!_isWeightExceeded)
            {
                Add(sweets[random.Next(0, sweets.Count - 1)]);
            }
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