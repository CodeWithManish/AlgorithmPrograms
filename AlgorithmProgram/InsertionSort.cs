using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class InsertionSort
    {
        int i, j, k;
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            for(i=1; i<size; i++)
            {
                 k=arr[i];
                j = i - 1;
                while(j >= 0 && arr[j]>k)
                {
                    arr[j + 1] = arr[j];
                        j=j-1;
                }
                arr[j+1] = k;   
                
            }
        }

        public void printArray(int[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int num=arr.Length;
            for(int i=0; i<num; i++)
            {
                Console.WriteLine(arr[i]+" ");  
            }
            Console.WriteLine("\n");
        }
    }
}
