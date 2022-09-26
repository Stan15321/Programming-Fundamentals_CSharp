using System;
using System.Linq;

namespace Ex2.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //for (int i = 0; i < array1.Length; i++)
            //{
              //  array1[i] += 10;
            //}
            //Console.WriteLine(string.Join(" ", array1));



            string[] compare1 = Console.ReadLine()
                .Split(" ");

            string[] compare2 = Console.ReadLine()
                .Split(" ");

            foreach (var element2 in compare2)
            {
                for (int i = 0; i < compare1.Length; i++)
                {
                    string element1 = compare1[i];
                    if (element1 == element2)
                    {
                        Console.Write(element1 + " ");
                        break;
                    }
                }
            }
            
            

        }
    }
}
