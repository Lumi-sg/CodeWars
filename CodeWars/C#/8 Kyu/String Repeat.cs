//Write a function called repeatStr which repeats the given string string exactly n times.

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string counter = "";
            if (n > 0)
            { 
                do
                {
                counter += s;
                    n--;
                } while (n > 0);
                return counter;
            }
            else
            {
                return "";
            }
    }
  }
