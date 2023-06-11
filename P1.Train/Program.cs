using System;
using System.Collections.Generic;
using System.Linq;

namespace P1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                List<string> commands = input.Split().ToList();

                if (commands[0] == "Add")
                {
                    wagonsList.Add(int.Parse(commands[1]));
                }
                else if (commands[0] != "Add")

                {
                    for (int i = 0; i < wagonsList.Count; i++)
                    {
                        if (int.Parse(commands[0]) + wagonsList[i] <= capacity)
                        {
                            wagonsList[i] += int.Parse(commands[0]);
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", wagonsList));
        }
    }
}
      

 