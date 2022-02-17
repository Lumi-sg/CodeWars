//You get an array of numbers, return the sum of all of the positives ones.

using System;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int sum = 0;
        foreach (int number in arr)
        {
            if (number > 0)
            {
                sum += number;
            }
        }
        return sum;
    }
}
