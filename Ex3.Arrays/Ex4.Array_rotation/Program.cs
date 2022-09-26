using System;
using System.Linq;

namespace Ex4.Array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());


            for (int i = 1; i <= rotations; i++)
            {
                int temp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
