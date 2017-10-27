using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class TheLoveLetterMystery
    {
        static int theLoveLetterMystery(string s)
        {
            int transaction = 0;
            // Complete this function
            for (int i = 0; i < s.Length / 2; i++)
            {
                transaction = transaction + Math.Abs(s[i] - s[s.Length - 1 - i]);
            }
            return transaction;
        }

        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = theLoveLetterMystery(s);
                Console.WriteLine(result);
            }
        }
    }
}
