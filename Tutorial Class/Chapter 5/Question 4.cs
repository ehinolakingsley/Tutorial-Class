using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_5
{
    public class Question_4
    {
        public void SolveQuestion()
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int c = int.Parse(Console.ReadLine());

           

            //Sort in descending order
            //i.e 3, 4, 1

            if (a > b && a > c)
            {
                //a: is the biggest
                if(b > c)
                {
                    //b: is the 2nd bigger no.
                    Console.WriteLine($"{a}, {b}, {c}");
                }
                else
                {
                    //c: is the 2nd bigger no.
                    Console.WriteLine($"{a}, {c}, {b}");
                }

            }
            else if(b > a && b > c)
            {
                //b: is the biggest no.
                if (a > c)
                {
                    //a: is the 2nd bigger no.
                    Console.WriteLine($"{b}, {a}, {c}");
                }
                else
                {
                    //c: is the 2nd bigger no.
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }
            else  
            {
                //c: is the biggest no.
                if (a > b)
                {
                    //a: is the 2nd bigger no.
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    //b: is the 2nd bigger no.
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            } 

        }


    }
}
