using System.Linq;
public class Kata
{
  public static string Repeater(string s, int n)
  {

    string str = string.Concat(Enumerable.Repeat(s, n));
    return str;
  }

}
