using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_3
{
    public class Question_10
    {
          
        public static void SolveQuestion()
        {

            Console.WriteLine("Enter a 4 digit number.");

            string input = Console.ReadLine();

            int resultA = SumDigit(input);

            Console.WriteLine("The sum of the 4 digit number is " + resultA);
        }

       
        static int SumDigit(string inputedValue)
        {
            if (inputedValue.Length != 4)
                throw new Exception("The inputed value is not 4 digit!");

            //2011
            int a = int.Parse(inputedValue[0].ToString());
            int b = int.Parse(inputedValue[1].ToString());
            int c = int.Parse(inputedValue[2].ToString());
            int d = int.Parse(inputedValue[3].ToString());

            int sum = a + b + c + d;

            return sum;
        }
     






    }
}
