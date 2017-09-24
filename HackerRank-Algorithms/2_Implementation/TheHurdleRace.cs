using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._2_Implementation
{
    public class TheHurdleRace
    {
        public static void Call()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            // your code goes here
            int heigestvalue = 0;
            for (int i = 0; i < n; i++)
            {
                if (height[i] > heigestvalue)
                {
                    heigestvalue = height[i];
                }
            }
            Console.WriteLine(heigestvalue > k ? heigestvalue - k : 0);
            Console.Read();
        }
    }
}
