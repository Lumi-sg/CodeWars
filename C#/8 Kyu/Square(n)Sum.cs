//Complete the square sum function so that it squares each number passed into it and then sums the results together.

using System;
public static class Kata
{
    public static int SquareSum(int[] n)
    {
        int sum = 0;
        foreach (int number in n)
        {
            int expo= (int)Math.Pow(number, 2);
            sum += expo;
        }
        return sum;
    }
}
