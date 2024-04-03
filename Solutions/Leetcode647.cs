namespace LeetcodeSharp.Solutions;
public class Leetcode647 {
    public int CountSubstrings(string s) {
        int row = s.Length;
        int col = s.Length;
        bool[][] matrix = new bool[row][];
        for (int i = 0; i < row; i++) {
            matrix[i] = new bool[col];
        }

        int count = 0;
        for (int i = 0; i < row; i++) { // one char palindrome
            matrix[i][i] = true;
            count++;
        }


        // if matrix[i][j] == true, substring[i,j] is a palindrome
        // traverse the upper triangle matrix like:
        // ↓↓↓↓
        //  ↓↓↓
        //   ↓↓
        //    ↓

        for (int j = 1; j < col; j++) {
            for (int i = 0; i < j; i++) {
                if (s[i] == s[j] && i == j - 1) { // right to the diagnal ⇒
                    count++;
                    matrix[i][j] = true;
                }
                else if (s[i] == s[j] && matrix[i + 1][j - 1]) {    // ⇙
                    count++;
                    matrix[i][j] = true;
                }
            }
        }
        PrintMatrix(matrix);
        return count;
    }
    private void PrintMatrix(bool[][] matrix) {
        for (int i = 0; i < matrix.Length; i++) {
            Console.Write("[ ");
            for (int j = 0; j < matrix[0].Length; j++) {
                if (matrix[i][j]) {
                    Console.Write(1 + ", ");
                }
                else {
                    Console.Write(0 + ", ");
                }
            }
            Console.WriteLine("]");
        }
    }

}


/*
a b c b a b
a [1,0,0,0,1,0]
b [0,1,0,1,0,0]
c [0,0,1,0,0,0]
b [0,0,0,1,0,1]
a [0,0,0,0,1,0]
b [0,0,0,0,0,1]

*/
