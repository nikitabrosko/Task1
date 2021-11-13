using NewYearPresent.Sweets;

namespace NewYearPresent.Repository
{
    public interface ISweetnessRepository<T> where T : ISweetness
    {
        void GetAll();
        void Add(ISweetness sweet);
        void Add(params ISweetness[] sweets);
        void Remove(ISweetness sweet);
        void RemoveAt(int id);
    }
}