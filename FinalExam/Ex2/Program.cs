using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|%)[A-Z][a-z]{2,}(\1):\s(\[)(?<numbers>[0-9]{1,}\]\|(\3)[0-9]{1,}\]\|(\3)[0-9]{1,})\]\|$";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    List<string> numbers = input.Split(new char[] { '|', '[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    
                    
                    var charsToRemove = new string[] {"$", ":", " ", "%"};

                    foreach (var c in charsToRemove)
                    {

                        numbers[0] = numbers[0].Replace(c, string.Empty);
                        
                    }
                    Console.Write($"{numbers[0]}: ");
                    numbers.RemoveAt(0);
                   
                 
                    foreach (var item in numbers)
                    {      
                        int number = int.Parse(item);
                       Console.Write($"{Convert.ToChar(number)}");
                    }
                       Console.WriteLine();

                }
            }
        }
    }
}
