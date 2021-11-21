namespace NewYearPresent.Builders
{
    interface IBuilder<T>
    {
        void Reset();
        T GetResult();
    }
}
