using System;
using System.Linq;

namespace BT1_to_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: Data Transformation
            Console.WriteLine("Exercise 1: Data Transformation");
            Console.WriteLine("Please enter an integer:");
            int userInput1 = int.Parse(Console.ReadLine());
            double doubleNumber = (double)userInput1;
            Console.WriteLine($"The number you entered is {userInput1} and as a double is {doubleNumber}");
            Console.WriteLine();

            // Exercise 2: Converting between numeric types
            Console.WriteLine("Exercise 2: Converting between numeric types");
            Console.WriteLine("Please enter a real number:");
            double userInput2 = double.Parse(Console.ReadLine());
            int intNumber = (int)userInput2;
            long longNumber = (long)userInput2;
            Console.WriteLine($"The number you entered is {userInput2}, as an int is {intNumber} and as a long is {longNumber}");
            Console.WriteLine();

            // Exercise 3: Convert between char type and int type
            Console.WriteLine("Exercise 3: Convert between char type and int type");
            Console.WriteLine("Please enter a character:");
            char userInput3 = char.Parse(Console.ReadLine());
            int asciiCode = (int)userInput3;
            Console.WriteLine($"The character you entered is '{userInput3}', its ASCII code is {asciiCode}");
            Console.WriteLine();

            // Exercise 4: Find the maximum value in an array of integers
            Console.WriteLine("Exercise 4: Find the maximum value in an array of integers");
            Console.WriteLine("How many integers do you want to enter?");
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arraySize];

            Console.WriteLine($"Please enter {arraySize} integers:");
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = numbers.Max();

            Console.WriteLine($"The maximum value in the array is {maxValue}");
        }
    }
}