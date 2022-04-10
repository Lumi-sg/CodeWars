using System;

public static class Kata
{
  public static string Greet(string name)
  {
    string subName = name.Substring(0, 1).ToUpper();
    string restName = name.Substring(1, name.Length - 1).ToLower();
    return "Hello " + subName + restName +"!";
  }
}