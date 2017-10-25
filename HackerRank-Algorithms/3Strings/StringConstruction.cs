using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank.Algorithms.Strings
{
    public class StringConstruction
    {
        static int stringConstruction(string s)
        {
            // Complete this function
            string uniqueStr = new String(s.Distinct().ToArray());
            return uniqueStr.Length;
        }

        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = stringConstruction(s);
                Console.WriteLine(result);
            }
        }
    }
}
