using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 1, 1, 4 };
        bool canReach = CanJump(nums);
        Console.WriteLine("Can reach last index: " + canReach);
    }

    static bool CanJump(int[] nums)
    {
        int maxReach = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
                return false;
            maxReach = Math.Max(maxReach, i + nums[i]);
        }
        return true;
    }
}

