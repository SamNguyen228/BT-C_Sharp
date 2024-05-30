using System;
using System.Linq;

namespace StringInC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            // Reverse the string and print the result
            string reversedString = ReverseString(userInput);
            Console.WriteLine($"Reversed string: {reversedString}");

            // Prompt the user to enter a search string
            Console.Write("Enter a search string: ");
            string searchString = Console.ReadLine();

            // Count occurrences of the search string and print the result
            int occurrenceCount = CountOccurrences(userInput, searchString);
            Console.WriteLine($"Number of occurrences of '{searchString}': {occurrenceCount}");

            // Prompt the user to enter an old substring and a new substring
            Console.Write("Enter the old substring to replace: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Enter the new substring to replace with: ");
            string newSubstring = Console.ReadLine();

            // Replace the old substring with the new substring and print the result
            string replacedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine($"String after replacement: {replacedString}");

            // Remove whitespace from the string and print the result
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine($"String without whitespace: {stringWithoutWhitespace}");
        }

        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int startIndex = 0;

            while ((startIndex = inputString.IndexOf(searchString, startIndex, StringComparison.Ordinal)) != -1)
            {
                count++;
                startIndex += searchString.Length;
            }

            return count;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
