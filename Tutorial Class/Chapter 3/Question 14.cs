using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_3
{
    public class Question_14
    {
        //Prime number are numbers that are divisible by 1 and itself.
        //21 & 17 & 20
        //2,3,4,5, 6,7,8,9,10
        //2,3,4,5,6,7,8
        //

        public static void SolveQuestion()
        {
            Console.WriteLine("Agent Prime Number Detector!");

            startAgain:

            Console.WriteLine("Enter any number between 1 and 100.");

            string input = Console.ReadLine();

            string questionResponse;

            int convertedInputed = int.Parse(input);

            if(convertedInputed < 2 || convertedInputed > 99)
            {
                Console.WriteLine("You are a chicken! You enter a value out of range.");

                goto startAgain;
            } 

            for(int count = 2; count <= convertedInputed/2; count++)
            {
                int remainder = convertedInputed % count;

                if (remainder == 0)
                {
                    if (count != convertedInputed)
                    {
                        Console.WriteLine("{0} is not a prime number!", convertedInputed);


                        Console.WriteLine("Do you want to try again? Enter Y for Yes or N for No.");

                        questionResponse =  Console.ReadLine();

                        if (questionResponse == "Y" || questionResponse == "y")
                            goto startAgain;
                        else  
                            goto Finish;

                        
                    }
                }  
            }

            Console.WriteLine("{0} is a prime number.", convertedInputed);

            Console.WriteLine("Do you want to try again? Enter Y for Yes or N for No.");

            questionResponse = Console.ReadLine();

            if (questionResponse == "Y" || questionResponse == "y")
                goto startAgain;
            else
                goto Finish;


            Finish:

            Console.WriteLine("Finished....");
        }



        //Print out all the prime numbers btw 1-100
        public static void Assignment()
        { 
            Console.WriteLine("This application prints all prime numbers between 1-100.");
             

            for (int input = 2; input <= 100; input++)
            {  
                for (int count = 2; count <= input; count++)
                {
                    int remainder = input % count;

                    if (remainder == 0)
                        if (count == input)
                        {
                            Console.Write("{0}, ", input);
                            //  break;
                        }
                        else
                            break; 
                } 
            }



             
        }
    }
}
