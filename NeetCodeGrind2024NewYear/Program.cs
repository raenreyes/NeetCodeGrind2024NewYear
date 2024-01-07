using System.Text.RegularExpressions;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(-121));

        }
        public static bool IsPalindrome(int x)
        {
            string toWord1 = x.ToString();
            string toWord2 = x.ToString();

            char[] toCharArray1 = toWord1.ToCharArray();
            char[] toCharArray2 = toWord2.ToCharArray();

            Array.Reverse(toCharArray2);

            for (int i = 0; i < toCharArray1.Length; i++)
            {
                if (toCharArray1[i] != toCharArray2[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}