//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        var hashSet = new HashSet<int>();

        foreach (var n in nums)
        {
            if (hashSet.Contains(n))
            {
                return true;
            }

            hashSet.Add(n);
            
        }

        return false;
    }
}
