using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Class.Chapter_2
{
    public class Question_10
    {
        /// <summary>
        /// Write a program to print a figure in the shape of a heart by the sign "o".
        /// </summary>
        public static void SolveQuestion()
        {
            string loveSymbol = "\u00B0"; 

            Console.WriteLine("             \t  " + loveSymbol + " " + loveSymbol);
            Console.WriteLine("           " + loveSymbol + "     " + loveSymbol);
            Console.WriteLine("         " + loveSymbol + "        " + loveSymbol);
            Console.WriteLine("        " + loveSymbol + "           " + loveSymbol);
            Console.WriteLine("         " + loveSymbol + "           " + loveSymbol);
            Console.WriteLine("           " + loveSymbol + "        " + loveSymbol);
            Console.WriteLine("             " + loveSymbol + "    " + loveSymbol);
            Console.WriteLine("              " + loveSymbol + "  " + loveSymbol);
            Console.WriteLine("                " + loveSymbol + loveSymbol); 
            Console.WriteLine("                 " + loveSymbol);



        }

    }
}
