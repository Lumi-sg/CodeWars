public class Solution {
    public bool IsValid(string s) {
        if (s == null || s == string.Empty)
            return true;
        
        Dictionary<char, char> charDict = new Dictionary<char, char>();
        Stack<char> stack = new Stack<char>();
        
        charDict.Add(')', '(');
        charDict.Add('}', '{');
        charDict.Add(']', '[');
        
        foreach (var c in s)
            if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count > 0 && stack.Peek() == charDict[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        
        return stack.Count == 0;
    }
}
