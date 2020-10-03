using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_2
{
    public class Question_13
    {
        /// <summary>
        /// Declare two variables of type int. Assign to them values 5 and 10 respectively.Exchange(swap) their values and print them. 
        /// </summary>
        public static void SolveQuestion()
        {
            int a = 5;
            int b = 10;
            int c = a;

            Console.WriteLine("The value of a is: "+ a);
            Console.WriteLine("The value of b is: "+ b);


            a = b;
            b = c;


            Console.WriteLine("The swap value of a is: " + a);
            Console.WriteLine("The swap value of b is: " + b);
        }
    }
}
