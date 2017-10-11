using System;

namespace HackerRank.Algorithms.Implementation
{
    public class ClsDivisibleSumPairs
    {
        public static void Call()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (((a[i] + a[j]) % k == 0))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
