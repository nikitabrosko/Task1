using System;
using System.Collections.Generic;
using System.Linq;
using NewYearPresent.Sweets;

namespace NewYearPresent.Repository
{
    public class SweetnessRepository : ISweetnessRepository<ISweetness>
    {
        private ICollection<ISweetness> _sweets = new List<ISweetness>();

        public IEnumerable<ISweetness> Sweets { get => _sweets; }

        public void GetAll()
        {
            var mars = new ChocolateBar("Mars", 1.3M, 55, 25.3f);
            var snickers = new ChocolateBar("Snickers", 1.2M, 60, 22.6f);
            var kitkat = new ChocolateBar("KitKat", 1.1M, 50, 21.5f);
            var bounty = new ChocolateBar("Bounty", 1.2M, 65, 31.8f);
            var lion = new ChocolateBar("Lion", 1.1M, 55, 21.1f);
            var mishkaKosolapy = new Sweets.Candy("Mishka Kosolapy", 0.10M, 7, 3.1f);
            var rotFront = new Sweets.Candy("Rot Front", 0.15M, 8, 4.9f);
            var karakum = new Sweets.Candy("Kara-Kum", 0.09M, 6, 2.8f);
            var zolotoyKlyuchik = new Sweets.Candy("Zolotoy Klyuchik", 0.08M, 7, 4.2f);
            var korovka = new Sweets.Candy("Korovka", 0.2M, 10, 6.7f);

            Add(mars, snickers, kitkat, bounty, lion, mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka,
                mars, snickers, kitkat, bounty, lion, mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka,
                mars, snickers, kitkat, bounty, lion, mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka,
                mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka,
                mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka,
                mishkaKosolapy, rotFront, karakum, zolotoyKlyuchik, korovka);
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