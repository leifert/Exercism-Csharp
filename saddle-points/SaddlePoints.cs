using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[] rowMaxs = new int[rows];
        Array.Fill(rowMaxs, int.MinValue);

        int[] colMins = new int[cols];
        Array.Fill(colMins, int.MaxValue);

        for (int row = 0; row < rows; row++)
            for (int col = 0; col < cols; col++){
                rowMaxs[row] = Math.Max(rowMaxs[row], matrix[row, col]);
                colMins[col] = Math.Min(colMins[col], matrix[row, col]);
            }

        for (int row = 0; row < rows; row++){
            for (int col = 0; col < cols; col++){
                if (matrix[row, col] == rowMaxs[row] && matrix[row, col] == colMins[col])
                    yield return (row + 1, col + 1);
            } 
        }
    }
}
