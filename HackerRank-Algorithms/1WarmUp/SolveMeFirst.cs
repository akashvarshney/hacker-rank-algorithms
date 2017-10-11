using System;

namespace HackerRank.Algorithms.Warmup
{
    public class ClsSloveMeFirst
    {
        public static int SloveMeFirst(int a, int b)
        {
            return a + b;
        }

        public static void Call()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SloveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
