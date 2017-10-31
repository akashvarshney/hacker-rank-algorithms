using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class AlternatingCharacters
    {
        static int alternatingCharacters(string s)
        {
            int count = 0;
            // Complete this function'
            if (s.Length > 1)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = alternatingCharacters(s);
                Console.WriteLine(result);
            }
        }
    }
}
