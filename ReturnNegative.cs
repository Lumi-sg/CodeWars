﻿using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        if (number > 0)
        {
            number = -number;
        }
        return number;
    }
}