using System;

namespace HackerRank.Algorithms.Warmup
{
    public class ClsPlusMinus
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            // count positive ,negative and zero numbers in the array
            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount = positiveCount + 1;
                }
                else if (arr[i] < 0)
                {
                    negativeCount = negativeCount + 1;
                }
                else
                {
                    zeroCount = zeroCount + 1;
                }
            }
            Console.WriteLine(String.Format("{0:N6}", positiveCount / n));
            Console.WriteLine(String.Format("{0:N6}", negativeCount / n));
            Console.WriteLine(String.Format("{0:N6}", zeroCount / n));
        }
    }
}