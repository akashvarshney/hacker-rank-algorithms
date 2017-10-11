using System;
using System.Text;

namespace HackerRank.Algorithms.Strings
{
    public class ClsCamelCase
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
