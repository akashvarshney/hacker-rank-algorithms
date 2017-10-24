using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class Gemstones
    {
        static int gemstones(string[] arr)
        {
            int count = 0;
            List<char[]> charArray = new List<char[]>();

            for (int i = 0; i < arr.Length; i++)
            {
                charArray.Add(arr[i].ToCharArray());
            }
            var firstGemstone = charArray[0].Distinct().ToArray();
            for (int i = 0; i < firstGemstone.Length; i++)
            {
                char letter = firstGemstone[i];
                bool found = false;
                for (int j = 1; j < charArray.Count; j++)
                {
                    found = false;
                    if (CheckData(charArray[j], letter))
                    {
                        found = true;                       
                    }
                    else
                    {
                        break;
                    }

                }
                if (found)
                {
                    count++;
                }
            }
            return count;

        }

        private static bool CheckData(char[] v, char letter)
        {
            bool iscontainLetter = false;
            for (int i = 0; i < v.Length; i++)
            {
                if (letter == v[i])
                {
                    iscontainLetter= true;
                    break;
                }
                else
                {
                    iscontainLetter= false;
                }
            }
            return iscontainLetter;
        }


        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            int result = gemstones(arr);
            Console.WriteLine(result);
        }
    }
}
