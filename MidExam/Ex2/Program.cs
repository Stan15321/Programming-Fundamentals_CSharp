using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" - ").ToArray();
                string command = cmdArgs[0];
                string phone = cmdArgs[1];

                if (command == "Add")
                {
                    if (!phones.Contains(phone))
                    {
                        phones.Add(phone);
                    }
                }
                else if (command == "Remove")
                {
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                }
                else if (command == "Bonus phone")
                {
                    string[] oldNewPhone = phone.Split(":").ToArray();
                    string oldPhone = oldNewPhone[0];
                    string newPhone = oldNewPhone[1];
                    if (phones.Contains(oldPhone))
                    {
                        int index = phones.IndexOf(oldPhone);
                        phones.Insert(index + 1, newPhone);
                    }
                }
                else if (command == "Last")
                {
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                        phones.Add(phone);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
