using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SimpleArraySum {

    static void Main(String[] args) {
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