using System;
using System.Collections.Generic;
using System.Linq;

namespace P3.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<string> resultList = new List<string>();


            for (int i = 0; i < inputNumber; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[2] == "not")
                {
                    if (resultList.Contains(input[0]))
                    {
                        resultList.Remove(input[0]);
                    }
                    else if (!resultList.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                else if (input[2] == "going!")
                {
                    if (resultList.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else if (!resultList.Contains(input[0]))
                    {
                        resultList.Add(input[0]);
                    }
                }
            }

            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine(resultList[i]);
            }
        }
    }
}
