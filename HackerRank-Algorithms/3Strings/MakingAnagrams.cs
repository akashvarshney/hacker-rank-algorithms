using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class MakingAnagrams
    {
        static int makingAnagrams(string s1, string s2)
        {
            string[] str = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int diff = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int chacountS1 = s1.Length - s1.Replace(str[i], string.Empty).Length;
                int chacountS2 = s2.Length - s2.Replace(str[i], string.Empty).Length;
                diff = diff + Math.Abs(chacountS1 - chacountS2);
            }
            return diff;
        }
        public static void Call()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int result = makingAnagrams(s1, s2);
            Console.WriteLine(result);
        }
    }
}
