using System.Diagnostics;

namespace Week06Workshop
{
    internal class Program
    {
        //Task 2:
        public delegate int Calculate(int a, int b);
        public delegate double DiscountStrategy(double price);

        public static double CalculateFinalPrice(double price, DiscountStrategy discountStrategy)
        {
            return discountStrategy(price);
        }
        public int add(int a,int b)=>a+b;

        //Task 3: 
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var number in numbers)
            {
                if (condition(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void Main(string[] args)
        {
            CustomDelegate ops = new CustomDelegate();

            Calculate calc;
            calc = ops.Add;
            Console.WriteLine("Add: " + calc(10, 5));

            calc = ops.Subtract;
            Console.WriteLine("Subtract: " + calc(10, 5));

            DiscountStrategy discount = ops.FestivalDiscount;
            Console.WriteLine("Festival Discount on 1000: " + discount(1000));
            discount = ops.SeasonalDiscount;
            Console.WriteLine("Seasonal Discount on 1000: " + discount(1000));
            discount = ops.NoDiscount;
            Console.WriteLine("No Discount on 1000: " + discount(1000));

            Console.WriteLine("Using CalculateFinalPrice method:" + CalculateFinalPrice(1000, ops.SeasonalDiscount));
            Console.WriteLine("Using CalculateFinalPrice method:" + CalculateFinalPrice(1000, n => n * 0.7));

            //Task 3:
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Even Numbers:");
            ProcessNumbers(nums,n => n % 2 == 0);

            Console.WriteLine("Numbers greater than 5:");
            ProcessNumbers(nums,n => n > 5);
        }
    }
}
