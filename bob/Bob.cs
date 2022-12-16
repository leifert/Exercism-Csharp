using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrEmpty(statement) || statement.All(char.IsWhiteSpace))
        {
            return "Fine. Be that way!";
        }
        else if (!statement.Any(char.IsLower) && statement[statement.Length-1] == '?' && statement.Any(char.IsLetter))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if(statement[statement.Length-1] == '?' || statement[statement.Length-4] == '?')
        {
            return "Sure.";
        }
        
        else if (!statement.Any(char.IsLower) && statement.Any(char.IsLetter))
        {
            return "Whoa, chill out!";
        }
        else {
            return "Whatever.";
        }
    }

    /*
      public static string Response(string message)
    {
        if (message.IsSilence())
            return "Fine. Be that way!";
        if (message.IsYell() && message.IsQuestion())
            return "Calm down, I know what I'm doing!";
        if (message.IsYell())
            return "Whoa, chill out!";
        if (message.IsQuestion())
            return "Sure.";
        return "Whatever.";
    }
    private static bool IsSilence(this string message) =>
        string.IsNullOrWhiteSpace(message);
    private static bool IsYell(this string message) =>
        message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
    private static bool IsQuestion(this string message) =>
        message.TrimEnd().EndsWith("?");
}
     */
 
}