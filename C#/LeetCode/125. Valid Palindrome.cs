//A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and //backward. Alphanumeric characters include letters and numbers.

//Given a string s, return true if it is a palindrome, or false otherwise.

public class Solution {
    public bool IsPalindrome(string s) 
    {
        string newStr = "";

        foreach (var si in s)
        {
            if (Char.IsLetterOrDigit(si))
            {
                newStr += si.ToString().ToLower();
            }
        }

        char[] chars = newStr.ToCharArray();
        Array.Reverse(chars);
        string revString = new string(chars);

        if (revString == newStr)
        {
            return true;
        }
        else
        {
            return false;
        }    
    }
}
