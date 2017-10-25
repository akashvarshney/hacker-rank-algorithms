using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class HackerRankInAString
    {
        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                // your code goes here
                string str = "hackerrank";
                if (s.Length < str.Length)
                {
                    Console.WriteLine("NO");
                }
                int j = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (j < str.Length && s[i] == str[j])
                    {
                        j++;
                    }
                }
                if ( j == str.Length)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
               
            }
        }

    }
}
