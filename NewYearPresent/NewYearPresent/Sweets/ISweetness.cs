namespace NewYearPresent.Sweets
{
    public interface ISweetness
    {
        string Name { get; set; }
        decimal Price { get; set; }
        float Weight { get; set; }
        float AmountOfSugar { get; set; }
    }
}