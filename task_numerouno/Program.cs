using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_numerouno
{
    internal class Program
    {
        static void Main()
        {
            int[] log = { 1, 2, 3, 4, 5 };

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(log[i]);
            }
        }
    }
}
