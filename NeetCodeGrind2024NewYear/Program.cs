namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsAnagram("rat", "car");

        }
        public static bool IsAnagram(string s, string t)
        {
            char[] word1 = s.ToCharArray();
            char[] word2 = t.ToCharArray();

            Array.Sort(word1);
            Array.Sort(word2);

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1.Length != word2.Length)
                {
                    return false;
                }
               if (word1[i] != word2[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}