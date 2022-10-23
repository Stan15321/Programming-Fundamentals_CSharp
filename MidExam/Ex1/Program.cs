using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfCities = short.Parse(Console.ReadLine());
            double profit = 0;
            double totalprofit = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfTheCity = Console.ReadLine();
                double ownerIncome = double.Parse(Console.ReadLine());
                double ownerExpenses = double.Parse(Console.ReadLine());
                profit = ownerIncome - ownerExpenses;
                
                if(i % 5 == 0)
                {

                    profit -= ownerIncome * 0.1;
                }

                else if (i % 3 == 0)
                {
                    profit -=  (ownerExpenses * 0.5);
                }
                totalprofit += profit;


                Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {profit:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalprofit:f2} leva.");
        }
    }
}
