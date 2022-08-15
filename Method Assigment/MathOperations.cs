using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Assigment
{
    public class MathOperations
    {
        public static void Multi(int number)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int result = number * randomNumber;

            Console.WriteLine(number + " multiplied by " + randomNumber + " equals " + result + "\n");

            Console.ReadLine();
        }

        public static void Div(int number)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            int result = number / randomNumber;
            int remainder = number % randomNumber;

            Console.WriteLine(number + " divided by " + randomNumber + " equals " + result + "\n and the remainder is: " + remainder);

            Console.ReadLine();


        }

        public static void SquareRoot(int number)
        {
            double result = Math.Sqrt(number);

            Console.WriteLine("The Square root of " + number + " is " + result);

            Console.ReadLine();

        }
    }
}
