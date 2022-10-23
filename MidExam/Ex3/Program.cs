using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList(); 

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] cmdArgs;
                int parameter;
                cmdArgs = input.Split(' ');

                if (cmdArgs[0] == "Finish") 
                    break;

                parameter = int.Parse(cmdArgs[1]);
                switch (cmdArgs[0])
                {
                    case "Add":
                        inputList.Add(parameter);
                        break;
                    case "Remove":
                        RemoveFirst(inputList, parameter);
                        break;
                    case "Replace":
                        int repl = int.Parse(cmdArgs[2]);
                        Replace(inputList, parameter, repl);
                        break;
                    case "Collapse":
                        Collapse(inputList, parameter);
                        break;
                    default:
                        Console.WriteLine("Unexpected command");
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", inputList));
        }

         static void RemoveFirst(List<int> inputList, int value)
        {
            int firstOccurance = -1;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == value)
                {
                    firstOccurance = i;
                    break;
                }
            }
            if (firstOccurance > -1)
            {
                inputList.RemoveAt(firstOccurance);
            }
        }

        static void Replace(List<int> inputList, int value, int replacement)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == value)
                {
                    inputList[i] = replacement;
                    return;
                }
            }
        }
        static void Collapse(List<int> inputList, int value)
        {
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                if (inputList[i] < value)
                {
                    inputList.RemoveAt(i);
                }
            }
        }
    }
}
