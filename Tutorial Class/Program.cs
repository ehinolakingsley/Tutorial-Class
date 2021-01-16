using System; 

namespace Tutorial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter_5.Question_4 question = new Chapter_5.Question_4();
              
            retry:

            question.SolveQuestion();

            //Retry
            Console.WriteLine("Do u want to retry?");

            string response = Console.ReadLine();

            if (response.ToLower() == "yes" || response.ToLower() == "y")
                goto retry;

            Console.WriteLine("Finished!");

            Console.ReadLine();
        }
    }
}
