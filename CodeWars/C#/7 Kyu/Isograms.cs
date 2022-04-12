using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    int strLength = str.Length;
    return str.ToLower().Distinct().Count() == strLength;
  }
}
