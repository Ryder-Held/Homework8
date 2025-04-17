// Creator: Ryder Held
// Date: 4/16/2025
namespace FindPivotIndex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            int left = nums[0];
            int right = nums[nums.Count() - 1];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (left < right)
                {
                    left += nums[i];
                }
                if (right == left)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
                if (right < left)
                {
                    right += nums[nums.Count() - 1 - i];
                }
                if (right == left)
                {
                    Console.WriteLine(nums.Count() - 2 - i);
                    break;
                }
            }
        }
    }
}
