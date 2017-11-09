using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class AnonymousVox
{

    public static void Main()
    {
        var encodedText = Console.ReadLine();
        var placeholders = Console.ReadLine();
        string pattern = @"(?<start>[a-zA-Z]+)(?<middle>.+)(?<end>\1)";
        string patternForPlaceholders = @"{([a-zA-Z0-9]+)}";

        MatchCollection matches = Regex.Matches(encodedText, pattern);
        MatchCollection placeMatches = Regex.Matches(placeholders,patternForPlaceholders);

        Regex regex = new Regex(pattern);
        string result = string.Empty;
        StringBuilder sb = new StringBuilder();

        foreach (Match match in matches)
        {
            sb.Append(match.Groups[1].Value);
   
        }
       
        Console.WriteLine(sb.ToString());


    
    }
}