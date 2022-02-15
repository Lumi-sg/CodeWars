//In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

using System;
using System.Linq;

namespace Highest_and_Lowest_String
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            int[] myInts = numbers.Split(' ').Select(int.Parse).ToArray();
            var max = myInts.Max();
            var min = myInts.Min();
            return $"{max} {min}";
        }
    }
}
