using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            int sum1 = 0;
            char character;  
            for (int i = 1; i <= n; i++)
            {
                character = char.Parse(Console.ReadLine());
                Convert.ToInt32(character);
                sum1 += character;
                //sum +=(int)character --> without using Convert.ToInt32
            }
            Console.WriteLine($"The sum equals: {sum1}");
        }
    }
}
