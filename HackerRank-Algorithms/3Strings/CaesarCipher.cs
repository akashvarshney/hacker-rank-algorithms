using System;
using System.Text;

namespace HackerRank.Algorithms.Strings
{
    //TODO: Need to revisit . Not getting solution as of now.
    public class ClsCaesarCipher
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            // Code 
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            string str = string.Empty;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                if ((asciiBytes[i] >= 65 && asciiBytes[i] <= 90) || (asciiBytes[i] >= 97 && asciiBytes[i] <= 122))
                {
                    int value = (int)asciiBytes[i] + k;
                    if ((value >= 65 && value <= 90) || (value >= 97 && value <= 122)) { str = str + (char)value; }
                    else
                    {
                        if (value > 90) {
                        }
                    }

                }
                else
                {
                    str = str + (char)asciiBytes[i];
                }

            }
            Console.WriteLine(Encoding.UTF8.GetString(asciiBytes));
        }
    }
}
