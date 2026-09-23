using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_numeroduo
{
    internal class Program
    {
        static void Main()
        {
            int[] month = { 1, 2, 1, 5, 5 };
            double[] sum = { 100, 200, 50, 300, 150 };

            double[] result = new double[12];

            for (int i = 0; i < 5; i++)
            {
                result[month[i] - 1] += sum[i];
            }

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
