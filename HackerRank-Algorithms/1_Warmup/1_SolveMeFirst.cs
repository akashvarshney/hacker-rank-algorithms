using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._1.Warmup
{
    public class _SloveMeFirst
    {
        public static int SloveMeFirst(int a, int b)
        {
            return a + b;
        }

		public static void CallMethod()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SloveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
