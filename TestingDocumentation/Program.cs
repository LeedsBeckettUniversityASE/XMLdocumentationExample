using System;

namespace TestingDocumentation
{
    /// <summary>
    /// class Program is to show XML comments
    /// </summary>
    class Program
    {
        /// <summary>
        /// entry point to porhram
        /// </summary>
        /// <param name="args">Command line, array of Strings</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// Compares two integers number1 with number2 and outputs the biggest, zero if the same
        /// </summary>
        /// <param name="number1">first number to compare</param>
        /// <param name="number2">second number to compare</param>
        /// <returns>biggest integer or zero if the same</returns>
        int compare(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            else if (number2 > number1)
                return number2;
            else return 0;
        }
    }
}
