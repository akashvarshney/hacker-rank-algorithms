using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._2_Implementation
{
    public class MigratoryBirds
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
        public static void CallMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}
