using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        int heighestNumber = ar[0];
            int count = 0;
            string str = string.Empty;
            for (int i = 0; i < ar.Length; i++)
            {
                if (heighestNumber < ar[i])
                {
                    heighestNumber = ar[i];
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (heighestNumber == ar[i])
                {
                    count++;
                }
            }
            return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
