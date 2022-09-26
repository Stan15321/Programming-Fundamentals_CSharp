using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagonPassengers = new int[n];
            int temp = 0;
            for (int i = 0; i < wagonPassengers.Length; i++)
            {
                wagonPassengers[i] = int.Parse(Console.ReadLine());
                temp += wagonPassengers[i];
                
            }
            Console.WriteLine(string.Join(" ", wagonPassengers));
            Console.WriteLine(temp);
        }
    }
}
