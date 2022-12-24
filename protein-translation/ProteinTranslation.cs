using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        Dictionary<string,string> proteins  = new Dictionary<string, string>(){
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"},
         };

        return Enumerable.Range(0,strand.Length/3)
            .Select(i => strand.Substring(i*3,3))
            .Select(c => proteins[c])
            .TakeWhile(p => p!="STOP").ToArray();
    }
}
