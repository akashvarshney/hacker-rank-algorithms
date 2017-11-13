using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    public class StrangerCounter
    {
        public static void Call()
        {
            double t = Convert.ToDouble(Console.ReadLine());
            int n = 2;
            while (3 * (n - 1) < t) n = 2 * n;
            Console.WriteLine((3 * (n - 1) - t + 1));
        }
    }
}
