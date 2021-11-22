using System.Collections.Generic;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyBox
{
    public interface ICandyContainer
    {
        IEnumerable<ISweetness> Sweets { get; }
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
        int AmountOfSweets { get; }
        float CurrentWeight { get; }

        void Add(ISweetness sweetness);
        void Add(params ISweetness[] sweets);
        void Remove(ISweetness sweetness);
        void RemoveAt(int id);
        void SortBy(SortParameters sortParameter);
        IEnumerable<ISweetness> FindSweetnessWithRangeOfSugarAmount(float min, float max);
    }
}
