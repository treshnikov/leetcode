using System;
using System.Collections.Generic;

public class CountSquaresSolution
{
    // https://leetcode.com/problems/count-square-submatrices-with-all-ones/
    /*
        Input: matrix =
        [
        [0,1,1,1],
        [1,1,1,1],
        [0,1,1,1]
        ]
        Output: 15
        Explanation: 
        There are 10 squares of side 1.
        There are 4 squares of side 2.
        There is  1 square of side 3.
        Total number of squares = 10 + 4 + 1 = 15.    

    */
    public int CountSquares(int[][] matrix)
    {
        var r = 0;
        var m = matrix.Length;
        var n = matrix[0].Length;
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][j] != 0)
                {
                    matrix[i][j] += Math.Min(matrix[i][j - 1], Math.Min(matrix[i - 1][j - 1], matrix[i - 1][j]));
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                r += matrix[i][j];
            }
        }

        return r;
    }
}