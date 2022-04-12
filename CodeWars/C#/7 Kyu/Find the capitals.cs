using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] Capitals(string word)
  {
    List<int> list = new List<int>();
		for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsUpper(word[i]))
            {
                list.Add(i);
            }
        }
        return list.ToArray();
  }
}
