using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            string basicWord = "anagram";

            UniqueCharacters(basicWord).ForEach(i => Console.Write("{0}\t", i)); ;
            
            Console.ReadKey();

        }

        private static List<string> UniqueCharacters(string basicWord)
        {
            List<string> result = new List<string>();
            result = basicWord.Split(',').ToList();
            return result;
        }
    }
}
