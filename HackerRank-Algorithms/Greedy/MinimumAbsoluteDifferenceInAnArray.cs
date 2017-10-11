using System;

namespace HackerRank.Algorithms.Greedy
{
    public class ClsMinimumAbsoluteDifference
    {
        static int minimumAbsoluteDifference(int n, int[] arr)
        {
            Array.Sort(arr);
            int gap = arr[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                int a = Math.Abs(arr[i] - arr[i + 1]);
                if (a < gap)
                    gap = a;

            }
            return gap;
        }
        public static void Call() {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = minimumAbsoluteDifference(n, arr);
            Console.WriteLine(result);
        }
    }
}
