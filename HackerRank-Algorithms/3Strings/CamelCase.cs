using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._3Strings
{
    public class CamelCase
    {
        public static void Call()
        {
            string s = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int count = 1;
            for (int i = 1; i < asciiBytes.Length; i++)
            {
                if (asciiBytes[i] >= 65 && asciiBytes[i] <= 90)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
