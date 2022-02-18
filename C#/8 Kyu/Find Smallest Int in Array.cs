//Given an array of integers your solution should find the smallest integer.
using System.Linq;
public class Kata

{
    public static int FindSmallestInt(int[] args)
    {
        int minValue = args.Min();
        return minValue;
    }
}
