namespace LeetcodeSharp.Solutions
{
    public class Leetcode867
    {
        public int[][] Transpose(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int nrow = col;
            int ncol = row;
            int[][] result = new int[nrow][];
            for (int i = 0; i < nrow; i++)
            {
                result[i] = new int[ncol];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }
            return result;
        }
    }
}
