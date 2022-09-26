using System;

namespace WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short capacity = 255;
            short capacityLeft = capacity;
            for (int i = 1; i <= n; i++)
            {
                 short liters = short.Parse(Console.ReadLine());
                
                if (capacityLeft>= liters)
                {
                    capacityLeft -= liters;
                    
                    
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(capacity-capacityLeft);
        }
    }
}
