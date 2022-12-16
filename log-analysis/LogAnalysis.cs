using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimeter){
        return str[(str.IndexOf(delimeter)+delimeter.Length)..];
    }

     public static string SubstringBetween(this string str, string delimeter1,string delimeter2){ 
        return str[(str.IndexOf(delimeter1)+delimeter1.Length)..str.IndexOf(delimeter2)];  
     }
    
    public static string Message(this string str){ 
         return str[(str.IndexOf(":")+2)..]; 
     }

    public static string LogLevel(this string str) {
        return str[(str.IndexOf("[")+1)..str.IndexOf("]")]; 
    }
}