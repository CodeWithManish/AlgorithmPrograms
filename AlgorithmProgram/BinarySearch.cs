using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BinarySearch
    {
        public void BinarySearchIterative(string input)
        {
            string[] strInputArray = { "THis", "is", "Binary", "Search"};
            int minimum = 0, middle = 0, result = -1;
            int maximum = strInputArray.Length - 1;

            Console.WriteLine("Array values are:\n");
            for (int i = 0; i <= maximum; i++)
            {
                Console.WriteLine(strInputArray[i]);
            }

            while (minimum <= maximum)
            {
                middle = minimum + (minimum - 1) / 2;

                if (input.Equals(strInputArray[middle]))
                {
                    result = 0;
                }

                if (result == 0)
                {
                    Console.WriteLine("match found");
                }

                int val = Convert.ToInt32(input.CompareTo(strInputArray[middle]));

                if (val == 1)
                {
                    minimum = middle + 1;
                    result = 1;
                }
                else
                {
                    maximum = middle - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("word is not found");
            }
            else if (result == 1)
            {
                Console.WriteLine("word is found");
            }

        }
    }
}
