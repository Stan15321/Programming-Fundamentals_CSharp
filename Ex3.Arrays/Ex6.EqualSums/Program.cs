using System;
using System.Linq;

namespace Ex6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sumOnTheLeft = 0;
            int sumOnTheRight = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length==1)
                {
                    Console.WriteLine(0);
                    return;
                }
                sumOnTheLeft = 0;
                for (int sumLeft= i; sumLeft >0 ; sumLeft--)
                {
                    int nextLeftElement = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        sumOnTheLeft += numbers[nextLeftElement];
                    }
                }

                sumOnTheRight = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextElementPosition = j + 1;
                    if (j< numbers.Length-1)
                    {
                        sumOnTheRight += numbers[nextElementPosition];
                    }
              
                }
                if (sumOnTheRight==sumOnTheLeft)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

        }
    }
}
