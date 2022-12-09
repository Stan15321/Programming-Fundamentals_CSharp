using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine()) != "Complete")
            {
               
                string[] commandArgs = input.Split(' ');
                string command = commandArgs[0];
                if (command == "Make")
                {
                    string commandAbout = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (commandAbout == "Upper")
                    {
                        char charToWorkWith = password[index];
                        password = password.Remove(index, 1).Insert(index, char.ToUpper(charToWorkWith).ToString());
                        Console.WriteLine(password);
                    }
                    else if (commandAbout == "Lower")
                    {
                        char charToWorkWith = password[index];
                        password = password.Remove(index, 1).Insert(index, char.ToLower(charToWorkWith).ToString());
                        Console.WriteLine(password);
                    }
                }
                else if (command == "Insert")
                {
                    int indexItoInsert = int.Parse(commandArgs[1]);
                    string character = commandArgs[2];
                    if (!(indexItoInsert < 0 | indexItoInsert > input.Length))
                    {
                    password = password.Insert(indexItoInsert, character.ToString());
                    Console.WriteLine(password);
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
                        asciiValue += value;
                        
                        password = password.Replace(character, (char)asciiValue);
                        Console.WriteLine(password);
                    }
                }
                else if (command == "Validation")
                {
                    if (password.Length<8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    string pattern = @"[A-z+0-9+_]{1,}";
                    if (!Regex.IsMatch(password, pattern))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!password.Any(char.IsUpper))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!password.Any(char.IsLower))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if (!password.Any(char.IsDigit))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
            }
        }
    }
}
