using System;

namespace StrongNumer
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            int numCopy = input;
            int factorialSum = 0;

            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }

            if (factorialSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
