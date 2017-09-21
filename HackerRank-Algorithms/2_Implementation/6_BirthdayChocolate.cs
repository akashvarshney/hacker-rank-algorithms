using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._2_Implementation
{
    public class _6_BirthdayChocolate
    {
        static int solve(int n, int[] s, int d, int m)
        {
            int startingIndex = 0;
            int result = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                startingIndex = i;

                try
                {
                    for (int j = 0; j < m; j++)
                    {
                        total += s[startingIndex + j];
                    }
                }
                catch (Exception e)
                {
                    break;
                }

                if (total == d)
                {
                    result++;
                }
                total = 0;
            }
            return result;
        }
        public static void CallMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}
