﻿using System;
using System.Linq;

namespace Ex8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length ; j++)
                {
                    if (array[i]+array[j]==n)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                    
                }
            }
        }
    }
}
