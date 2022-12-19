using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb= new StringBuilder();
        bool kebabFlag = false;

        foreach (char c in identifier) {
            if (kebabFlag) {
                sb.Append(char.ToUpper(c));
                kebabFlag = false;
            }
            else {
                switch (c) {
                    case char x when char.IsWhiteSpace(c):
                        sb.Append('_'); 
                        break;
                    case char x when char.IsControl(c):
                        sb.Append("CTRL"); 
                        break;
                    case '-':
                        kebabFlag = true;
                        break;
                    case char x when c >= 945 && c <= 969:
                        break;
                    case char x when char.IsLetter(c):
                        sb.Append(c);
                        break;
                    default:
                        break;
                }
            }
        }
        return sb.ToString();
    }
}
