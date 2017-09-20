using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._2_Implementation
{
    public class _5_BreakingTheRecords
    {
        static int[] getRecord(int[] s)
        {
            int lowestRecordCount = 0;
            int heighestRecordCount = 0;
            int heighestRecord = s[0];
            int lowestRecord = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (heighestRecord < s[i])
                {
                    heighestRecordCount++;
                    heighestRecord = s[i];
                }
                else if (lowestRecord > s[i])
                {
                    lowestRecordCount++;
                    lowestRecord = s[i];
                }
            }
            return new int[] { heighestRecordCount, lowestRecordCount };

        }
        public static void CallMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
            Console.Read();
        }
    }
}
