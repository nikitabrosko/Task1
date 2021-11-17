using System;
using System.Collections.Generic;
using System.Linq;
using NewYearPresent.Sweets;

namespace NewYearPresent.Repository
{
    public class SweetnessRepository : IRepository<ISweetness>
    {
        private ICollection<ISweetness> _sweets = new List<ISweetness>();

        public IEnumerable<ISweetness> Sweets { get => _sweets; }

        public void GetAll()
        {
            
        }

        public void Add(ISweetness sweet)
        {
            _sweets.Add(sweet);
        }

        public void Add(params ISweetness[] sweets)
        {
            foreach (var sweetness in sweets)
            {
                Add(sweetness);
            }
        }

        public void Remove(ISweetness sweet)
        {
            _sweets.Remove(sweet);
        }

        public void RemoveAt(int id)
        {
            try
            {
                _sweets.Remove(Sweets.ToArray()[id]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ID is incorrect");
                throw;
            }
        }
    }
}