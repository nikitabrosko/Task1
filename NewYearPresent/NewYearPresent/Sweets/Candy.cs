namespace NewYearPresent.Sweets
{
    public class Candy : ISweetness
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public float AmountOfSugar { get; set; }
    }
}