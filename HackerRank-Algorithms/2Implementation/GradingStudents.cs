﻿using System;

namespace HackerRank.Algorithms.Implementation
{
    public class ClsGradingStudents
    {
        public static int[] Solve(int[] grades)
        {            
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    if (grades[i] % 5 == 3 || grades[i] % 5 == 4)
                    {
                        grades[i] = grades[i] + (5 - (grades[i] % 5));
                    }
                }
               
            }
            return grades;
        }
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = Solve(grades);
            Console.WriteLine(String.Join("\n", result));
            Console.Read();
        }
    }
}
