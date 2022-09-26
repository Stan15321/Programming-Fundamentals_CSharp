using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            int numCopy = n;
            while(numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy /=  10;
                sum += lastDigit;
               
            }
            Console.WriteLine(sum);
        }
    }
}
