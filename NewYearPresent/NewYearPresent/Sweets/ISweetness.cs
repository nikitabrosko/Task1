namespace NewYearPresent.Sweets
{
    public interface ISweetness
    {
        string Name { get; }
        decimal Price { get; }
        float Weight { get; }
        float AmountOfSugar { get; }

        void CalculateAmountOfSugar();
    }
}