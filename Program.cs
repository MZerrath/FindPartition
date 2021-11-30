/* Purpose: To determine if all numbers in one array is found in another array.
 *          While the problem assumes one array of length 3, I will design this
 *          program assuming that the length of both arrays are unknown.
 *          This program takes the possibility of numbers appearing multiple
 *          times into account.
 */

using System;
using static System.Console;

namespace FindPartition
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = new int[] { 2, 1, 3 };
            int[] secondArray = new int[] { 4, 19, -3, 2, 5, 3, 1, 10 };
            //int[] firstArray = new int[] { 6, 2, 9 };
            //int[] secondArray = new int[] { 9, 0, 14, -3, 2, 1 };
            bool partitionFound = false;
            int positiveMatch = 0;
            int matchesNecessary = 0;
            int timesNumberFound = 0;

            // Determines how many matches are necessary to set partitionFound to true.
            // matchesNecessary is always the lesser number.
            if (firstArray.Length < secondArray.Length)
            {
                matchesNecessary = firstArray.Length;
            }
            else
            {
                matchesNecessary = secondArray.Length;
            }

            // Counts the number of positive matches by comparing numbers in each array.
            foreach(int number in firstArray)
            {
                foreach(int compare in secondArray)
                {
                    if (number == compare)
                    {
                        positiveMatch++;
                        timesNumberFound++;
                    }
                    if (timesNumberFound > 1)
                    {
                        // Test for if a number shows up more than once
                        positiveMatch = positiveMatch - (timesNumberFound - 1);
                    }
                }
                timesNumberFound = 0;
                //WriteLine(positiveMatch);
            }

            // Determines if the bool partitionFound can be set to true.
            if (positiveMatch == matchesNecessary)
            {
                partitionFound = true;
            }
            else
            {
                partitionFound = false;
            }

            // Display arrays and message depending on results.
            WriteLine("First Array:");
            for(int i = 0; i < firstArray.Length; i++)
            {
                Write(" {0}", firstArray[i]);
            }
            WriteLine("\n\nSecond Array:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Write(" {0}", secondArray[i]);
            }

            if (partitionFound)
            {
                WriteLine("\n\n All numbers found.");
            }
            else
            {
                WriteLine("\n\n Not all numbers found.");
            }
        }
    }
}
