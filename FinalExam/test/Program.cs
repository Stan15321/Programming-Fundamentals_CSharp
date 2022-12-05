using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordThing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string password;
            int index;
            int value;
            int asciiValue;
            char selectedChar;
            char newChar;

            input = Console.ReadLine();
            password = input;

            while (input != "Complete")
            {
                input = Console.ReadLine();

                if (input.Contains("Make Upper "))
                {
                    index = int.Parse(input.Substring("Make Upper ".Length - 1));
                    selectedChar = password[index];
                    password = password.Remove(index, 1).Insert(index, char.ToUpper(selectedChar).ToString());
                    Console.WriteLine(password);
                }
                else if (input.Contains("Make Lower "))
                {
                    index = int.Parse(input.Substring("Make Lower ".Length - 1));
                    selectedChar = password[index];
                    password = password.Remove(index, 1).Insert(index, char.ToLower(selectedChar).ToString());
                    Console.WriteLine(password);
                }
                else if (input.Contains("Insert "))
                {
                    index = int.Parse(input.Split(" ")[1]);
                    selectedChar = (input.Split(" ")[2])[0];
                    password = password.Insert(index, selectedChar.ToString());
                    Console.WriteLine(password);
                }
                else if (input.Contains("Replace "))
                {
                    selectedChar = (input.Split(" ")[1])[0];
                    value = int.Parse(input.Split(" ")[2]);
                    asciiValue = Encoding.ASCII.GetBytes(new char[] { selectedChar })[0];
                    asciiValue += value;
                    newChar = Encoding.ASCII.GetChars(new byte[] { Convert.ToByte(asciiValue) })[0];
                    password = password.Replace(selectedChar, newChar);
                    Console.WriteLine(password);
                }
                else if (input == "Validation")
                {
                    if (input.Length < 8)
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
