//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
//Note: input will never be an empty string

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static string FakeBin(string x)
    {
        Regex pattern0 = new Regex("[01234]");
        Regex pattern1 = new Regex("[56789]");

        x = pattern0.Replace(x, "0");
        x = pattern1.Replace(x, "1");

        return x;
    }
}
