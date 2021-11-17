using System;
using System.Collections.Generic;
using System.Linq;
using NewYearPresent.CandyBox;
using NewYearPresent.Sweets;

namespace NewYearPresent.Repository
{
    public class CandyBoxRepository : IRepository<CandyBox.CandyBox>
    {
        private ICollection<CandyBox.CandyBox> _candyBoxes = new List<CandyBox.CandyBox>();

        public IEnumerable<CandyBox.CandyBox> CandyBoxes { get => _candyBoxes; }

        public void GetAll()
        {
            
        }

        public void Add(CandyBox.CandyBox candyBox)
        {
            _candyBoxes.Add(candyBox);
        }

        public void Add(params CandyBox.CandyBox[] candyBoxes)
        {
            foreach (var candyBox in candyBoxes)
            {
                Add(candyBox);
            }
        }

        public void Remove(CandyBox.CandyBox candyBox)
        {
            _candyBoxes.Remove(candyBox);
        }

        public void RemoveAt(int id)
        {
            try
            {
                _candyBoxes.Remove(CandyBoxes.ToArray()[id]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ID is incorrect");
                throw;
            }
        }
    }
}