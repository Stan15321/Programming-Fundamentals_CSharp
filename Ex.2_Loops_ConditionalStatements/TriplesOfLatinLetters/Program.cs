using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar;
            char secondChar;
            char therdChar;

            for (int i = 0; i <= n-1; i++)
            {
                 firstChar = (char)('a' +  i);

                for (int j = 0; j <= n-1 ; j++)
                {

                    secondChar = (char)('a' + j);
                    
                    for (int k = 0; k <= n-1 ; k++)
                    {
                        therdChar = (char)('a' + k);
                        Console.Write($"{firstChar}{secondChar}{therdChar}");
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
