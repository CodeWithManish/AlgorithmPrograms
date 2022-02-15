using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PrimeNumRange
    {

        public void FindPrime()
        {
            int count = 0; int range = 1000;
            for (int i = 1; i < range; i++)
            {
                for (int j = 1; j < range; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(i + " ");
                }
                count = 0;
            }

        }
    }
}