//Given an array of integers, return a new array with each value doubled.

using System;
using System.Linq;
public class Kata
{
    public static int[] Maps(int[] x)
    {
        int[] resultArray = x.Select(x => x *2).ToArray();
        return resultArray;
    }
}
