public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary<char, char> dictionary = new Dictionary<char, char>();
            Stack<char> stack = new Stack<char>();

            dictionary.Add(')', '(');
            dictionary.Add('}', '{');
            dictionary.Add(']', '[');

            foreach (var str in s)
            {
                if (str is ')' or ']' or '{')
                {
                    if (stack.Count > 0 && stack.Peek() == dictionary[str])
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
                    stack.Push(str);
                }
            }

            return stack.Count == 0;
    }
}
