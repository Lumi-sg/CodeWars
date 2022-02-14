using System;

public class KataBase
{
    public static string FindNeedle(object[] haystack)
    {

        foreach (object haystackItem in haystack)
        {
            if (haystackItem as string == "needle")
            {
                int position = Array.IndexOf(haystack, haystackItem);
                return ($"found the needle at {position}");
            }
        }
        return null;
    }
}