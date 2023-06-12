using System;
using System.Collections.Generic;
using System.Linq;

namespace P4.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> commands = input.Split().ToList();

                if (commands[0] == "Add")
                {
                    integersList.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) > integersList.Count || int.Parse(commands[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integersList.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) > integersList.Count || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integersList.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            int firstNumber = integersList[0];
                            integersList.Remove(integersList[0]);
                            integersList.Add(firstNumber);
                        }
                    }
                    else if (commands[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            int lastNumber = integersList[integersList.Count - 1];
                            integersList.Remove(integersList[integersList.Count - 1]);
                            integersList.Insert(0, lastNumber);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", integersList));
        }
    }
}
