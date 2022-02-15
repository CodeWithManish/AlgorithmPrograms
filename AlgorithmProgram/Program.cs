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
            Console.WriteLine("Enter 1.to print insertion Sort\nEnter 2.to print Bubble Sort\n");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        InsertionSort insertion= new InsertionSort();
                        int[] arr = { 20, 15, 4, 8, 12, 3 };
                        insertion.Sort(arr);
                        insertion.printArray(arr);
                        break;

                        case 2:
                        int[] arr1 = { 10, 35, 32, 13, 26 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;
                }
            }

        }
    }
}
