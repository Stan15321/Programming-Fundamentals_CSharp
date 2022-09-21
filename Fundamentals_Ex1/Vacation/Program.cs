namespace Vacation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double total = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    price += 8.45;
                }
                else if (day == "Saturday")
                {
                    price += 9.80;
                }
                else if (day == "Sunday")
                {
                    price += 10.46;          
                }
                total =  price * count;
                if (typeOfGroup == "Students" && count>=30)
                {
                    total -=total*0.15;
                }
            }

            if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    price += 10.90;
                }
                else if (day == "Saturday")
                {
                    price += 15.60;
                }
                else if (day == "Sunday")
                {
                    price += 16;
                }
        
                if (typeOfGroup == "Business" && count>=100)
                {
                    total = (count - 10) * price; 
                }
                else
                {
                    total = price * count;
                }
            }

            if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price += 15;
                }
                else if (day == "Saturday")
                {
                    price += 20;
                }
                else if (day == "Sunday")
                {
                    price += 22.50;
                }
                total = price * count;
                if (typeOfGroup == "Regular" && count>=10 && count<=20)
                {
                    total -= total * 0.05;
                }

            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
