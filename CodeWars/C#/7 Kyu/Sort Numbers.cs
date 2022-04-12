using System;
public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    if (nums == null || nums.Length == 0) 
    {
      int[] emptyArray = new int [0];
      return emptyArray;
    }
    Array.Sort(nums);
    
    return nums;
  }
}
