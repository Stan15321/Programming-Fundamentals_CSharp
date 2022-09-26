using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            //how many itterations we will have 
            short n = short.Parse(Console.ReadLine());
            //initialize 2 string, current model and winning model
            string model, winning = string.Empty;
            //initialize 2 double variables, the first is for the radius(from the console) in the For loop, the second variable is for the formula
            double radius, volume = 0;
            int height;
            // to compare sth u need to have a variable, which should be double.MinValue or double.MaxValue (depends from the situation).
            double maxValue = double.MinValue;

            for (int i = 1; i <=n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume>maxValue)
                {
                    maxValue = volume;
                    winning = model;
                }

            }
            Console.WriteLine(winning);
        }
    }
}
