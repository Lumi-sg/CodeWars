public class Solution {
    public int Search(int[] nums, int target) 
    {
        foreach (var num in nums)
        {
            if (num == target)
            {
                return Array.IndexOf(nums, num);
            }
        }
        return -1;
    }
}
// Better way:

public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int mid = (l +r ) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return -1;
    }
}