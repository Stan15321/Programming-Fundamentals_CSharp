using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greet = "Hello World";
            Console.WriteLine(greet.Substring(3, 4));
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);
            for (int i = 10; i > 3; i -= 2)
            {
                Console.WriteLine($"{i}");
            }
            
           
            print("C#");
           
            Console.WriteLine(c);
             bool isTrue = 5 > 'a';
            Console.WriteLine(isTrue);
        }
        public static void print(string text)
        {
            Console.WriteLine("I love" + text);
        }
    }
}
