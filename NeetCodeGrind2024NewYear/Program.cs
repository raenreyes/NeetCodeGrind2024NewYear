using System.Text.RegularExpressions;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            
            Console.WriteLine(ContainsNearbyDuplicate(nums, 2));
        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j ++)
                {
                    if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}