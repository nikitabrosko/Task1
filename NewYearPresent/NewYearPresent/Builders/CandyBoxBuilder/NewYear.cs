using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.CandyBox;

namespace NewYearPresent.Builders.CandyBoxBuilder
{
    class NewYear : CandyBoxBuilder
    {
        public override CandyBox.CandyBox CandyBox { get; set; }

        public override void SetName()
        {
            CandyBox.Name = "New Year";
        }

        public override void SetSize()
        {
            CandyBox.MaxWeight = Size.Large;
        }

        public override void SetDescription()
        {
            CandyBox.Description = "A most popular New Year present";
        }

        public override void SetSweets()
        {
            throw new NotImplementedException();
        }

        public override void SetPrice()
        {
            foreach (var sweetness in CandyBox.Sweets)
            {
                CandyBox.Price += sweetness.Price;
            }
        }

        public override void SetAmountOfSweets()
        {
            CandyBox.AmountOfSweets = CandyBox.Sweets.Count();
        }

        public override void SetCurrentWeight()
        {
            foreach (var sweetness in CandyBox.Sweets)
            {
                CandyBox.CurrentWeight += sweetness.Weight;
            }
        }

    }
}
