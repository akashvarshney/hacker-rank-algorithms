using System;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Strings
{
    public class FunnyString
    {
        private static string funnyString(string s)
        {
            string str = "Not Funny";
            string reversStr = new string(s.ToCharArray().Reverse().ToArray());
            for (int i = 1; i < s.Length; i++)
            {
                str = "Not Funny";
                if (Math.Abs(((int)s[i] - (int)s[i - 1])) == Math.Abs(((int)reversStr[i] - (int)reversStr[i - 1])))
                {
                    str = "Funny";
                }
                else
                {
                    break;
                }
            }

            return str;
        }



        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = funnyString(s);
                Console.WriteLine(result);
            }
        }
    }
}
