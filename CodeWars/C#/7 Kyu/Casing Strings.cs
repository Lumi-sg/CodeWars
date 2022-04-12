//Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

using System;
using System.Globalization;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

        return titleCase;

    }
}
