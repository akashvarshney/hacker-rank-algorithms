using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CompareTheTriplets {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');       
        string[] tokens_b0 = Console.ReadLine().Split(' ');
       
         int alicepoints = 0;
            int bobpoints = 0;
            if (tokens_a0.Length == tokens_b0.Length)
            {
                for (int i = 0; i < tokens_a0.Length; i++)
                {
                    if (Convert.ToInt32(tokens_a0[i]) > Convert.ToInt32(tokens_b0[i]))
                    {
                        alicepoints = alicepoints + 1;
                    }
                    else if (Convert.ToInt32(tokens_a0[i]) < Convert.ToInt32(tokens_b0[i]))
                    {
                        bobpoints = bobpoints + 1;
                    }
                }
            }
        Console.WriteLine(Convert.ToString(alicepoints + " " + bobpoints));
    }
}
