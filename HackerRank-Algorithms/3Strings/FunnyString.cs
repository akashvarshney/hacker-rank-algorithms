using System;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Strings
{
    public class FunnyString
    {
        private static string funnyString(string s)
        {
            string str = string.Empty;
            string reversStr = s.Reverse().ToString();
            for (int i = 0; i < s.Length; i++)
            {
                
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
