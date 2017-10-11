using System;

namespace HackerRank.Algorithms.Warmup
{
    public class ClsSimpleArraySum
    { 
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }
            Console.WriteLine(total);
        }
    }
}
