using System.Text.RegularExpressions;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord(" fly me  to  the moon "));

            
        }
        public static int LengthOfLastWord(string s)
        {
            string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string lastWord = words[words.Length - 1];
            int howManyLetters = lastWord.Length;

            return howManyLetters;
        }

    }
}