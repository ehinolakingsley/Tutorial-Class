using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_1
{
    /// <summary>
    /// Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
    /// </summary>
    public class Question_10
    { 
        public static void SolveQuestion()
        {
            for(int startingPoint = 2; startingPoint <= 100; startingPoint++)
            {
                int reminder = startingPoint % 2; //Get reminder

                string result;

                if (reminder == 0)
                    result = startingPoint.ToString();
                else
                    result = "-"+startingPoint;

                Console.WriteLine(result); 

            }

        }






    }
}
