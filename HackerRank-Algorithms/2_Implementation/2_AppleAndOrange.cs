using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms._2_Implementation
{
    public class _2_AppleAndOrange
    {
        public static void CallMethod()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int apple_count = 0;
            int orange_count = 0;
            for (int i = 0; i < apple.Length; i++)
            {

                int abs_apple_dist = a + apple[i];
                if (abs_apple_dist >= s && abs_apple_dist <= t)
                {
                    apple_count++;
                }
            }

            for (int i = 0; i < orange.Length; i++)
            {
                int abs_orange_dist = b + orange[i];
                if (abs_orange_dist >= s && abs_orange_dist <= t)
                {
                    orange_count++;
                }
            }
            Console.WriteLine(apple_count);
            Console.WriteLine(orange_count);
        }
    }
}
