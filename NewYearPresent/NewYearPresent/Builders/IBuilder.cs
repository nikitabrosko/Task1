namespace NewYearPresent.Builders
{
    public interface IBuilder<T>
    {
        void Reset();
        T GetResult();
    }
}
