using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    //TODO:Terminated due to timeout
    public class ClsClimbingTheLeaderboard
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            // code goes here
           
            int[] distictscore = scores.Distinct().ToArray();
            //Alice Games Scores Rank
            for (int i = 0; i < alice.Length; i++)
            {
                int aliceRank = distictscore.Length + 1;
                for (int j = 0; j < distictscore.Length; j++)
                {
                    if (alice[i] >= distictscore[j])
                    {
                        aliceRank = j + 1;
                        break;
                    }
                }
                Console.WriteLine(aliceRank);
            }
            Console.Read();
        }
    }
}
