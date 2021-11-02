namespace LeetCode.Problems
{
    public class RotateMatrixProblem
    {
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            var res = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    res[i, j] = matrix[n - j - 1][i];
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i][j] = res[i, j];
                }
            }
        }

    }
}