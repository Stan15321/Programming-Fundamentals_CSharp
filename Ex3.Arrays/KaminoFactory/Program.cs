using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequences = int.Parse(Console.ReadLine());
            string input;
            int[] samplesArray = new int[sequences];
            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                samplesArray = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                for (int i = 0; i < samplesArray.Length-1; i++)
                {
                    if (samplesArray[i] ==samplesArray[i+1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                        start = 1;
                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                        bestStart = start;
                    }

                }
            }
            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.WriteLine($"Best DNA sample {maxLength} with sum:{bestStart}.");
                Console.WriteLine(string.Join(" ", samplesArray));
            }
        }
    }
}
