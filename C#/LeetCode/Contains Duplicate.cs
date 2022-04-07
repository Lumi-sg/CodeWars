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
