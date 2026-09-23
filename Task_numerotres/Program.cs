using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_numerotres
{
    internal class Program
    {
        static void Main()
        {
            int[] events = { 1, 2, 3, 4, 5, 6, 7 };
            int[] last = new int[5];

            for (int i = 0; i < 7; i++)
            {
                last[i % 5] = events[i];
            }
            Console.WriteLine(last[2]);
            Console.WriteLine(last[3]);
            Console.WriteLine(last[4]);
            Console.WriteLine(last[0]);
            Console.WriteLine(last[1]);
        }
    }
}
