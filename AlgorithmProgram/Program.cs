using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!\n");
            Console.WriteLine("Enter 1.to print insertion Sort\nEnter 2.to print Bubble Sort\n" +
                "Enter 3.to pirnt Merge Sort\nEnter 4.to print Anagram\nEnter 5.to print Range of Prime Number\n");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        InsertionSort insertion = new InsertionSort();
                        int[] arr = { 20, 15, 4, 8, 12, 3 };
                        insertion.Sort(arr);
                        insertion.printArray(arr);
                        break;

                    case 2:
                        int[] arr1 = { 10, 35, 32, 13, 26 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;

                    case 3:
                        int[] arr2 = { 33, 12, 9, 85, 21, 4 }; 
                        MergeSort.Sort(arr2, 0, arr2.Length - 1);
                        MergeSort.PrintArray(arr2);
                        break;

                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.FindAnagram();
                        break;

                    case 5:
                        PrimeNumRange prime = new PrimeNumRange();
                        prime.FindPrime();
                        break;

                }
            }

        }
    }
}
