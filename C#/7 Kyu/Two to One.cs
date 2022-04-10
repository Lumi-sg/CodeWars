using System.Linq;
public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
  {
        var combArray = s1.Union(s2).ToArray();
        var result = new string(combArray.OrderBy(x => x).ToArray());
        return result;
  }
}