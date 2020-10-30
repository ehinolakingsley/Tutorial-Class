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

            Console.WriteLine("1#. The sum of the 4 digit number is " + resultA);
             
          
            string resultB = ReverseDigit(input);

            Console.WriteLine("2#. The reverse order of {0} is {1}.", input, resultB);

          
            string resultC = ReverseDigit2nd(input);

            Console.WriteLine("3#. The reverse order of {0} is {1}.", input, resultC);


            string resultD = ReverseDigit3rd(input);

            Console.WriteLine("4#. The reverse order of {0} is {1}.", input, resultD); 

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

        static string ReverseDigit(string inputedValue)
        {
            if (inputedValue.Length != 4)
                throw new Exception("The inputed value is not 4 digit!");

            char a = inputedValue[0];
            char b = inputedValue[1]; 
            char c = inputedValue[2];
            char d = inputedValue[3];

            string reverseJoined = string.Format("{0}{1}{2}{3}", d, c, b, a);

            //string reverseJoined_ = "" + d + "" + c + "" + b + "" + a + "";

            return reverseJoined;
        }
         
        static string ReverseDigit2nd(string inputedValue)
        {
            if (inputedValue.Length != 4)
                throw new Exception("The inputed value is not 4 digit!");

            char a = inputedValue[0];
            char b = inputedValue[1];
            char c = inputedValue[2];
            char d = inputedValue[3];

            string reverseJoined = string.Format("{0}{1}{2}{3}", d, a, b, c);

            //string reverseJoined_ = "" + d + "" + c + "" + b + "" + a + "";

            return reverseJoined;
        }

        static string ReverseDigit3rd(string inputedValue)
        {
            if (inputedValue.Length != 4)
                throw new Exception("The inputed value is not 4 digit!");

            char a = inputedValue[0];
            char b = inputedValue[1];
            char c = inputedValue[2];
            char d = inputedValue[3];

            string reverseJoined = string.Format("{0}{1}{2}{3}", a, c, b, d);
             
            return reverseJoined;
        }

    }
}
