using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._3Strings
{
    public class SuperReducedString
    {
        static string super_reduced_string(string s)
        {
            // Complete this function
            string str = s;
            for (int i = 0; i < str.Length;)
            {
                if (str.Length > i+1)
                {
                    if (str[i] == str[i + 1])
                    {
                        str = str.Replace(string.Format(str[i].ToString() + str[i + 1].ToString()), string.Empty);
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                    break;                
            }
            return str.Length > 0 ? str : "Empty String";

        }
        public static void Call()
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }
    }
}
