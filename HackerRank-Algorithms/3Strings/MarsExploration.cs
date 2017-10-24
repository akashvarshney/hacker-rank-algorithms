using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class MarsExploration
    {
        public static void Call()
        {
            string S = Console.ReadLine();
            char[] temp = { 'S', 'O', 'S' };
            List<string> splitedStr = new List<string>();
            for (int i = 0; i < S.Length; i = i + 3)
            {
                splitedStr.Add(S.Substring(i, 3));
            }
            int count = 0;
            foreach (var item in splitedStr)
            {
                if (item != "SOS")
                {
                    for (int j = 0; j < item.Length; j++)
                    {
                        if (item[j] != "SOS"[j])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
