using System;
using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum){
        // Constraints:
        //      1) a < b < c
        //      2) a + b + c = sum
        //      3) a^2 + b^2 = c^2
        //      4) a > 0
        //...
        //      a < sum / 3
        //      c = sum - a - b

        for (int a = 1; a < sum / 3; a++){
            for (int b = a+1; b < sum / 2; b++){
                if (a * a + b * b == (sum - a - b)*(sum - a - b)){
                    yield return (a, b, sum - a - b);
                }
            }
        }
    }
    public static IEnumerable<(int a, int b, int c)> TripletsWithSumLinq(int sum) =>
        from a in Enumerable.Range(1, sum / 3)
        from b in Enumerable.Range(a + 1, sum / 2)
        where a * a + b * b == (sum - a - b) * (sum - a - b)
        select (a, b, sum - a - b);
}