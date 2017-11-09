
using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(\s[a-zA-Z0-9][\w.-]*\@[A-Za-z-]+)(\.[a-zA-Z-]+)+";
        var input = Console.ReadLine();
        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine(m);
        }
    }
}
