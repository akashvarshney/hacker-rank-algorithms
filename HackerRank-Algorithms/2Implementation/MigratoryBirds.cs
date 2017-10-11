using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    public class ClsMigratoryBirds
    {
        // not the best solution
        static int migratoryBirds(int n, int[] ar)
        {
            var reapetedValue = ar.GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .ToArray()[0];

            return reapetedValue;
        }
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}