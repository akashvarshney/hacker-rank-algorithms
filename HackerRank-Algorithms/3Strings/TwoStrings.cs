using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class TwoStrings
    {
        static string twoStrings(string s1, string s2)
        {
            string result = "NO";
            // Complete this function
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    for (int j = 0; j < s1.Length; j++)
            //    {
            //        if (s1[i] == s2[j])
            //        {
            //            result = "YES";
            //            break;
            //        }
            //    }
            //    if (result == "YES")
            //    {
            //        break;
            //    }
            //}
            for (int i = 97; i < 123; i++)
            {
                if (s2.Contains((char)i) && s1.Contains((char)i)) 
                {
                    return "YES";                   
                }
            }

            return result;
        }
        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string result = twoStrings(s1, s2);
                Console.WriteLine(result);
            }
        }
    }
}