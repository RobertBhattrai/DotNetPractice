namespace Week06Workshop
{
    public class CustomDelegate
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;

        public double FestivalDiscount(double price) => (price * 0.80);
        public double SeasonalDiscount(double price) => (price * 0.90);
        public double NoDiscount(double price) => price;
    }
}
