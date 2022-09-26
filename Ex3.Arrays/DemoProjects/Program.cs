using System;
using System.Linq;

namespace DemoProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //char[] characters = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();

            //for (int i = 0; i < characters.Length; i++)
            //{
              //  Console.Write(characters[i] + " ");
            //}
            //Console.WriteLine( );

            int input = int.Parse(Console.ReadLine());
            int[] carriges = new int [input];
            

            for (int i = 0; i < input; i++)
            {
                carriges = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
                carriges[i] += 10;
            }
                Console.WriteLine(string.Join(" ", carriges));
            
            

            int[] newInteger = { 50, 
                60, 
                80, 
                100,
                150
            };
            for (int i = 0; i < newInteger.Length; i++)
            {
                newInteger[3] += 10;
                //Console.Write(newInteger[i] + " ");
            }
            //Console.WriteLine(string.Join(",", newInteger));

            foreach (var item in newInteger)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
