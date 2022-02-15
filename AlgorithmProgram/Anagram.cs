using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagram
    {
        public void FindAnagram()
        {
            Console.WriteLine("Enter the 1st String :");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter the 2nd String :");
            string str2 = Console.ReadLine();
            char[] ch1= str1.ToUpper().ToCharArray();
            char[] ch2 = str2.ToUpper().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1=new string(ch1);
            string newString2=new string(ch2);
            if(newString1==newString2)
            {
                Console.WriteLine("Both the Strings are Anagram!");
            }
            else
            {
                Console.WriteLine("Both the Strings are not Anagram!");
            }

        }
    }
}
