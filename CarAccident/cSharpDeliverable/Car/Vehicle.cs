namespace Car
{
    public class Vehicle
    {
        public required string CarModel;
        public int Year;
        public bool IsElectric;

        public void DisplayInfo()
        {
            Console.WriteLine($"Car Model: {CarModel}, Year: {Year}, Electric: {IsElectric.ToString().ToLower()}");
        }
    }

    public class Details
    {
        public required string Brand;
        public int Price;
        public bool IsUsed;

        public void CarDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Price Bought: ${Price}, Bought New: False, Bought Used: {IsUsed}");
        }
    }
}