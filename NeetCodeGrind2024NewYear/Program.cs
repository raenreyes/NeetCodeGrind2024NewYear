namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("217 contains duplicate");
            int[] nums = { 1, 2, 3, 4 };
            ContainsDuplicate(nums);
        }
        public static bool ContainsDuplicate(int[] nums)
        {

            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) { 
                    if (nums[i] == nums[j])
                    {
                        Console.WriteLine("True");
                        return true;
                    }
                }
            }
            Console.WriteLine("False");
            return false;
        }
    }
}