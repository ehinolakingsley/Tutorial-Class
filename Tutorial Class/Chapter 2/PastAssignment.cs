using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Day_2
{
    public class PastAssignment
    {
        public static void CalculateAge()
        {
            begin:

            string age = Console.ReadLine();
            
            int convertedAge;

            bool isConversionSuccessful = int.TryParse(age, out convertedAge);

            if(isConversionSuccessful == false)
            {

                Console.WriteLine("Invalid input! Please enter a proper age number.");

                goto begin;

            }    

            int result = convertedAge + 10;

            Console.WriteLine(result);

            Console.ReadLine();

            Console.WriteLine("Do u want to try again? Enter Y yes or N no");

            string response = Console.ReadLine();

            if (response == "Y")
                goto begin;

        }
    }
}
