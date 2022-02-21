//Make a program that filters a list of strings and returns a list with only your friends name in it.

//If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

using System;
using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        List<string> list = new List<string>();
        foreach (string name in names)
        {
            if (name.Length == 4)
            {
                list.Add(name);
            }
            
        }
        return list.ToArray();
    }
}
