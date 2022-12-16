using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        Dictionary<string,int> RomanNumerals = new Dictionary<string, int>()
        {
            {"M",1000 },
            {"CM",900},
            {"D",500 },
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV",4},
            {"I",1}
        };

        StringBuilder sb = new StringBuilder();

        foreach (var item in RomanNumerals)
        {
            if (value <= 0)
            {
                break;
            }
            while (value >= item.Value)
            {
                sb.Append(item.Key);
                value -= item.Value;
            }
        }
        return sb.ToString();
    }
}