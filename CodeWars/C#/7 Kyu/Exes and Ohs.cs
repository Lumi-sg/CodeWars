using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        input = input.ToLower();
        int countO = input.Split('o').Length - 1;
        int countX = input.Split('x').Length - 1;

        if (countX != countO)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
