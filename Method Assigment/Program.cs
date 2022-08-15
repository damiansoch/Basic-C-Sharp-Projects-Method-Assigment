using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program will take a user number, and than \n 1) multiply it by random number (0-100) \n 2) divide it by random number (1-10) and aldo will print the remainder  \n 3) gives the square root of the provided number \n " +
                "The program will print the results inside the function, as well as the returned values in the main program");
            Console.WriteLine("Please write whole number (0-100)");
            int userImput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            int multiResult = MathOperations.Multi(userImput);
            int divResult = MathOperations.Div(userImput);
            double sqrResult = MathOperations.SquareRoot(userImput);

            Console.WriteLine("The returned values are: " + multiResult + " from \"Multi\" method, " + divResult + " from \" Div\" method and " + sqrResult + " from \"SquareRoot\" method.");
            Console.ReadLine();
        }

    }
}
