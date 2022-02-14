//Can you find the needle in the haystack?

//Write a function findNeedle() that takes an array full of junk but containing one "needle"

//After your function finds the needle it should return a message (as a string) that says:

//"found the needle at position " plus the index it found the needle, so:
//

using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
  foreach (object haystackItem in haystack)
        {
            if (haystackItem as string == "needle")
            {
                int position = Array.IndexOf(haystack, haystackItem);
                return ($"found the needle at position {position}");
            }
        }
        return null;
    }
}
