using System;
using System.Collections.Generic;
using System.Linq;

namespace P2.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                List<string> commandsList = command.Split().ToList();

                if (commandsList[0] == "Delete")
                {
                    for (int i = 0; i < listOfIntegers.Count; i++)
                    {
                        if (listOfIntegers[i] == int.Parse(commandsList[1]))
                        {
                            listOfIntegers.Remove(listOfIntegers[i]);
                        }
                    }
                }
                else if (commandsList[0] == "Insert")
                {
                    listOfIntegers.Insert(int.Parse(commandsList[2]), int.Parse(commandsList[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}
