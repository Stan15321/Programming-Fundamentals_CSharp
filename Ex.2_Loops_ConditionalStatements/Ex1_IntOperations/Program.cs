using System;

namespace Ex1_IntOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            long sumofNum = number1 + number2;
            long devisionOfNum = sumofNum / number3;
            long multiplicationOfSum = devisionOfNum * number4;
            Console.WriteLine(multiplicationOfSum);
        }
    }
}
