using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank.Algorithms.Strings
{
    public class BeautifulBinaryString
    {
        static int minSteps(int n, string B)
        {
            int count = 0;
            // Complete this function
            if (B.Contains("010"))
            {
                count = (n - B.Replace("010", string.Empty).Length) / 3;

            }
            return count;
        }
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();
            int result = minSteps(n, B);
            Console.WriteLine(result);
        }
    }
}
