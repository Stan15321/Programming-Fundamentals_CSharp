using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            while ((input=Console.ReadLine()) != "Complete")
            {
                string password = input;
                string[] commandArgs = input.Split(' ');
                string command = commandArgs[0];
                if (command == "Make")
                {
                    string commandAbout = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (commandAbout == "Upper")
                    {
                        char charToWorkWith = input[index];
                        password = password.Remove(index, 1).Insert(index, char.ToUpper(charToWorkWith).ToString());
                        Console.WriteLine(input);
                    }
                    else if (commandAbout == "Lower")
                    {
                        char charToWorkWith = input[index];
                        password = password.Remove(index, 1).Insert(index, char.ToLower(charToWorkWith).ToString());
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Insert")
                {
                    int indexItoInsert = int.Parse(commandArgs[1]);
                    string character = commandArgs[2];
                    if (!(indexItoInsert < 0 | indexItoInsert > input.Length))
                    {
                    password = password.Insert(indexItoInsert, character.ToString());
                    Console.WriteLine(input);
                    }
                }
                else if (command == "Replace")
                {
                    //*problem may occur
                    char character = char.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);
                    if (input.Contains(character))
                    {
                        int asciiValue = Convert.ToInt32(character);
                        asciiValue += character;
                        
                        password = password.Replace(character, (char)asciiValue);
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Validation")
                {
                    if (password.Length<8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    string pattern = @"[A-z+0-9+_]{1,}";
                    if (!Regex.IsMatch(input, pattern))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!input.Any(char.IsUpper))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!input.Any(char.IsLower))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if (!input.Any(char.IsDigit))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
            }
        }
    }
}
