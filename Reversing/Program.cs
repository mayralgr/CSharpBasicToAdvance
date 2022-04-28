using System;

namespace Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given an array of zeroes and ones,
            move all zeroes to the end of the array
            [0,1] => [1,0]
            [0,1,0,1] => [1,1,0,0]
            */
            var originalArray = new int[] { 0, 1, 0, 1 };
            Array.Sort(originalArray);
            Array.Reverse(originalArray);
            Console.Write("[");
            for(int i = 0; i < originalArray.Length; i++)
            {
                Console.Write(originalArray[i]);
                if(i < originalArray.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

            // no sorting
            Console.WriteLine("No sorting");
            var arrayToBeThreated = new int[] { 0, 1, 0, 1 };
            var firstZero = Array.IndexOf(arrayToBeThreated, 0);            
            var lastOne = Array.LastIndexOf(arrayToBeThreated, 1);
            while (firstZero < lastOne)
            {
                //Console.WriteLine("Changing firstZero that is in position " + firstZero + " And has value of " + arrayToBeThreated[firstZero] + " for the index of lastone " + lastOne + " thathas the value of " + arrayToBeThreated[lastOne]);
                arrayToBeThreated[firstZero] = 1;
                arrayToBeThreated[lastOne] = 0;
                // update indexes
                firstZero = Array.IndexOf(arrayToBeThreated, 0);
                lastOne = Array.LastIndexOf(arrayToBeThreated, 1);
                //Console.WriteLine("New values {0} {1}", firstZero, lastOne);
            }
            Console.Write("[");
            for (int i = 0; i < arrayToBeThreated.Length; i++)
            {
                Console.Write(arrayToBeThreated[i]);
                if (i < arrayToBeThreated.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }

    }
}
