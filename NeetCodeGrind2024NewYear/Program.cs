using System.Text.RegularExpressions;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 1, 2 };
            Console.WriteLine(RemoveDuplicates(myArray));

        }
        public static int RemoveDuplicates(int[] nums)
        {
            int[] result = new int[nums.Length];
            int tempNum = int.MaxValue;
            int counter = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] != tempNum)
                {
                    result[j] = nums[i];
                    j++;
                    counter++;
                    tempNum = nums[i];

                }

            }
            for (int k = 0; k < result.Length; k++)
            {
                nums[k] = result[k];
            }
            return counter;
        }

    }
}