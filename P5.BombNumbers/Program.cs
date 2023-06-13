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
            List<int> bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bombNumberAndPower[0];
            int bombNumPower = bombNumberAndPower[1];

            while (listOfNumbers.Contains(bombNumber))
            {
                int bombPosition = listOfNumbers.IndexOf(bombNumber);

                if (listOfNumbers.Count > bombPosition + bombNumPower)

                {
                    for (int i = bombPosition + 1; i <= bombPosition + bombNumPower; i++)
                    {
                        listOfNumbers.RemoveAt(bombPosition + 1);
                    }
                }

                else

                {
                    for (int i = bombPosition + 1; i < listOfNumbers.Count; i++)
                    {
                        listOfNumbers.RemoveAt(bombPosition + 1);
                    }
                }

                if (bombPosition - bombNumPower >= 0)

                {
                    for (int i = bombPosition; i >= bombPosition - bombNumPower; i--)
                    {
                        listOfNumbers.RemoveAt(i);
                    }
                }

                else

                {
                    for (int i = bombPosition; i >= 0; i--)
                    {
                        listOfNumbers.RemoveAt(i);
                    }
                }
            }
            Console.WriteLine(listOfNumbers.Sum());
        }
    }
}