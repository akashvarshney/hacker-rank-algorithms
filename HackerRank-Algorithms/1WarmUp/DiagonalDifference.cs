using System;

namespace HackerRank.Algorithms.Warmup
{
    public class ClsDiagonalDifference {
        public static void Call()
        {
            int result = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int DignalFirst = 0;
            int DigonalSecond = 0;
            for (int i = 0; i < n; i++)
            {
                DignalFirst = DignalFirst + a[i][i];
                DigonalSecond = DigonalSecond + a[i][n - i - 1];
            }
            result = DignalFirst > DigonalSecond ? DignalFirst - DigonalSecond : DigonalSecond - DignalFirst;
            Console.WriteLine(result);
        }
    }
}
