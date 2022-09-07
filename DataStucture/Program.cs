using DataStucture_I;

namespace DataStucture
{
    class Program
    {
        static void Main(string[] args)
        {
            Day2_Array day2_Array = new Day2_Array();

            int target = 9;
            int[] nums = { 3, 2, 4 };

            var result = day2_Array.TwoSum(nums, target);

            Console.WriteLine(result);
        }
    }
}