using System;
using System.Linq;

namespace LabExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                
                if (array1[i]!=array2[i])
                 {
                     Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                     break;
                 }
                 else if(array2[i+2]==array1[i+2])
                 {
                    foreach (var item in array1)
                    {
                        sum += item;
                    }
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    break;
                }
                    
                
            }

        }
    }
}
