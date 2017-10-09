using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] input = Console.ReadLine().Split(' ');
			List<long> inputValues = Array.ConvertAll(input, Int64.Parse).ToList();
			inputValues.Sort();
			long minValue = 0;
			long maxValue = 0;
			for (int i = 0; i < inputValues.Count; i++)
			{
				minValue = minValue + inputValues[i];
				if (i< inputValues.Count-1)
				{
					maxValue = maxValue + inputValues[i + 1];
				}
			}
			minValue = minValue - inputValues[inputValues.Count - 1];
			Console.WriteLine(minValue + " " + maxValue);
			
    }
}