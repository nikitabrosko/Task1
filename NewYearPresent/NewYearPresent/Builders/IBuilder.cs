using NewYearPresent.CandyContainer;

namespace NewYearPresent.Builders
{
    public interface IBuilder<T>
    {
        void Reset(ICandyContainer candyContainer);
        T GetResult();
    }
}
