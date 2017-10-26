using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank.Algorithms.Strings
{
    //TODO: not all test case are passing .. need to see again.
    public class GameOfThrones
    {
        static string gameOfThrones(string s)
        {
            // Complete this function
            bool palindrom = false;
            int tempcount = 0;
            string uniquestr = new string(s.Distinct().ToArray());
            for (int i = 0; i < uniquestr.Length; i++)
            {
                int length = 0;
                length = s.Length - s.Replace(uniquestr[i].ToString(), "").Length;
                if (tempcount <= 1)
                {
                    if (length % 2 == 1)
                    {
                        palindrom = true;
                    }
                    else if (length == 1)
                    {
                        tempcount++;
                        palindrom = true;
                    }
                }
                else
                {
                    palindrom = false;
                    break;
                }
            }
           return palindrom ? "YES" : "NO";
        }

        public static void Call()
        {
            string s = Console.ReadLine();
            string result = gameOfThrones(s);
            Console.WriteLine(result);
        }
    }
}
