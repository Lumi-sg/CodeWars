//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var dict = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(target - nums[i]))
                return new int[]{i, dict[target - nums[i]]};
            else if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }
        
        return new int[2];
    }
}
