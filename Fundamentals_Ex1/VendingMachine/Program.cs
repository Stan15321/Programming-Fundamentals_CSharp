using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = string.Empty;
            decimal sumCoins = 0;
            while ((coins = Console.ReadLine()) != "Start")
            {
                
                if (coins == "0.1"|| coins == "0.2" || coins == "0.5" || coins == "1" || coins == "2")
                {
                    sumCoins += decimal.Parse(coins);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            string product = string.Empty;
            decimal productPrice = 0;

            while ((product = Console.ReadLine())!="End")
            {
                if (product == "Nuts")
                {
                    productPrice = 2.0m;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7m;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5m;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8m;
                }
                else if (product == "Coke")
                {
                    productPrice = 1.0m;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (sumCoins>= productPrice && sumCoins> 0 && productPrice>0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sumCoins -= productPrice;
                }
                else if (productPrice>0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    productPrice = 0;
                }
            }
            Console.WriteLine($"Change: {sumCoins:f2}");
        }
    }
}
