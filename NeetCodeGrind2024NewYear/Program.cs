using System.Text.RegularExpressions;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal -- Panama";
            IsPalindrome(s);
            
        }

        public static bool IsPalindrome(string s)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "");
            s = s.Replace(" ", "").ToLower();
            
            char[] one = s.ToCharArray();
            char[] two = s.ToCharArray();

            
            Array.Reverse(two);

           

            for (int i = 0; i < one.Length; i++)
            {
                if (one.Length != two.Length)
                {
                    return false;
                }
                if (one[i] != two[i])
                {
                    Console.WriteLine("False");
                    return false;
                }

            }
            Console.WriteLine("True");
            return true;
            
        }
    }
}   