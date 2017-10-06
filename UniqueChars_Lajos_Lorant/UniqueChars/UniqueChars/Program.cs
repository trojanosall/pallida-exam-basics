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

            List<char> basicWordarCharacters = UniqueCharacters(basicWord);

            basicWordarCharacters.ForEach(Console.WriteLine);

            //for (int i = 0; i < basicWordarCharacters.Length; i++)
            //{
            //    Console.WriteLine(basicWordarCharacters[i]);
            //}

            Console.ReadKey();

        }

        private static List<char> UniqueCharacters(string basicWord)
        {
            Char[] basicwordArray = basicWord.ToCharArray();
            Array.Sort(basicwordArray);

            List<char> listOfUniqeChararacters = new List<char>();

            for (int i = 0; i < basicwordArray.Length; i++)
            {
                if (basicwordArray[i] != basicwordArray[i++])
                {
                   listOfUniqeChararacters.Add(basicwordArray[i]);
                }
            }

            return listOfUniqeChararacters;
            
        }
    }
}
