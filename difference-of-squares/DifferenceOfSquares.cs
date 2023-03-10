using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)=> Enumerable.Range(1,max).Sum().Square();
   

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1,max).Sum(num => num.Square());
    

    public static int CalculateDifferenceOfSquares(int max)=> CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}

public static class ExtendSquare
{
    public static int Square(this int num) => num * num;
}