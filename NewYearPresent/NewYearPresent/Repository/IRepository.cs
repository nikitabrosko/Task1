using NewYearPresent.Sweets;

namespace NewYearPresent.Repository
{
    public interface IRepository<T>
    {
        void GetAll();
        void Add(T value);
        void Add(params T[] values);
        void Remove(T value);
        void RemoveAt(int id);
    }
}