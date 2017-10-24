using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class TwoCharacters
    {
        public static void Call()
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            //code goes here
            char[] stringArray = s.ToArray();
            char[] uniqueChar = stringArray.Distinct().ToArray();
            string removingCharString = string.Empty;

            for (int j = 0; j < stringArray.Length - 1; j++)
            {
                if (stringArray[j] == stringArray[j + 1])
                {
                    //add list for removing char
                    removingCharString += stringArray[j];
                }
            }
            char[] remvoedchar = removingCharString.ToArray();
            for (int i = 0; i < remvoedchar.Length; i++)
            {
               s = s.Replace(remvoedchar[i].ToString(),"");
            }
            Console.Write(s.Length);

        }
    }
}
