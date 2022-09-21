namespace _11._Orders
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                double priceCapusule = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                price = (day * capsuleCount) * priceCapusule;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
