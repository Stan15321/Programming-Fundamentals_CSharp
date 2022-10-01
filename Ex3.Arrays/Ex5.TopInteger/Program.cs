using System;
using System.Linq;

namespace Ex5.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < integers.Length; i++)
            {
                int currNumber = integers[i];
                bool isTopInteger = true;
                for (int j = i+1; j < integers.Length; j++)
                {
                    int nextNumber = integers[j];
                    if (nextNumber>=currNumber)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currNumber + " ");
                }
            }
        }
    }
}
