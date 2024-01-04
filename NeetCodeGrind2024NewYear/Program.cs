namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 2, 9, 11, 15 };
            TwoSum(numArray, 9);

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {   
                
                for (int j = i + 1; j < nums.Length; j++)
                {
                  
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("Found");
                        return new int[] { i, j };
                    }
                }
                
            }
            return new int[0];
        }

    }
}