using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length-1; i >=0 ; i--)
            {
                char currCharacter = username[i];
                password += currCharacter;
            }

            int tries = 0;
            string enteredPassowrd;
            while ((enteredPassowrd = Console.ReadLine())!= password)
            {
                tries++;
                if (tries>=4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            if (tries<4)
            {
                Console.WriteLine($"User {username} logged in.");
            }

            
        }
    }
}
