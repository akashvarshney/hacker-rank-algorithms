﻿using System;

namespace HackerRank.Algorithms.Implementation
{
    public class ClsDayoftheProgrammer
    {
        // not getting all test cases pass .. :( 
        static string solve(int year)
        {
            string date = string.Empty;
            // Complete this function
            date = Convert.ToDateTime(("01.01." + year)).AddDays(255).ToString("dd.MM.yyyy");
            //if (year > 1916)
            //{
               
            //}
            //else
            //{
            //    date = Convert.ToDateTime(("01.01." + year)).AddDays(255-14).ToString("dd.MM.yyyy");
            //}
            return date;
        }
        public static void Call()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
