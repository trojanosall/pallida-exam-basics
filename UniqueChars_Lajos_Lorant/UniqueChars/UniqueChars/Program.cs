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
            string basicWord = "anagram";

            List<char> UniqueCharactersList = UniqueCharacters(basicWord);

            UniqueCharactersList.ForEach(Console.WriteLine);

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
