using System;
using System.Collections.Generic;
using System.Linq;

namespace P5.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> bombNumberAndPower = Console.ReadLine().Split().ToList();

            int bombNumber = int.Parse(bombNumberAndPower[0]);
            int bombNumPower = int.Parse(bombNumberAndPower[1]);

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bombNumber)
                {
                    for (int j = bombNumber; j > bombNumber - bombNumPower; j--)
                    {
                        listOfNumbers.Remove(listOfNumbers[j]);
                    }
                }
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bombNumber) 
                {
                    for (int j = bombNumber; j < bombNumber + bombNumPower; j++)
                    {
                        listOfNumbers.Remove(listOfNumbers[j]);
                    }
                }
            }
            

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bombNumber)
                {
                    listOfNumbers.Remove(bombNumber);
                }
            }
            Console.WriteLine(listOfNumbers.Sum());    
        }
    }
}
