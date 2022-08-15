using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program will nake a user number,and than \n 1) multiply it by random number (0-100) \n 2) divide it by random number (1-10) and aldo will print the remainder  \n 3) gives the square root of the provided number\n");
            Console.WriteLine("Please write whole number (0-100)");
            int userImput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            MathOperations.Multi(userImput);
            MathOperations.Div(userImput);
            MathOperations.SquareRoot(userImput);
        }

    }
}
