namespace DataStucture_I
{
    public class Solution_01
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hSet.Contains(nums[i]))
                {
                    return true;
                }
                hSet.Add(nums[i]);
            }
            return false;
        }
    }

    public class Solution_02
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}
