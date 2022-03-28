using System;

namespace Solution
{
  public static class Program
  {
    public static string alternateCase(string s)
    {
      string result = null;

            foreach (var str in s)
            {
                if (char.IsUpper(str))
                {
                    result += Char.ToLower(str);
                }
                else
                {
                    result += Char.ToUpper(str);
                }
            }
      return result;
    }
  }
}
