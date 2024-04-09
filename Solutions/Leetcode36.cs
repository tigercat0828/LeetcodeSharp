namespace LeetcodeSharp.Solutions;
public class Leetcode36 {
    int[] count = new int[10];
    int[][] board;
    public bool IsValidSudoku(char[][] board) {
        ToIntBoard(board);
        for (int i = 0; i < 9; i++) {
            if (!IsChunkValid(i)) return false;
            if (!IsRowValid(i)) return false;
            if (!IsColumnValid(i)) return false;
        }
        return true;
    }
    private bool IsColumnValid(int col) {
        FillZero();
        for (int i = 0; i < 9; i++)
            count[board[i][col]]++;

        for (int i = 1; i <= 9; i++)
            if (count[i] > 1) return false;

        return true;
    }
    private bool IsRowValid(int row) {
        FillZero();
        for (int i = 0; i < 9; i++)
            count[board[row][i]]++;

        for (int i = 1; i <= 9; i++)
            if (count[i] > 1) return false;

        return true;
    }
    private bool IsChunkValid(int chunk) {
        FillZero();
        int row = chunk / 3;
        int col = chunk % 3;

        count[board[row * 3 + 0][col * 3 + 0]]++;
        count[board[row * 3 + 0][col * 3 + 1]]++;
        count[board[row * 3 + 0][col * 3 + 2]]++;

        count[board[row * 3 + 1][col * 3 + 0]]++;
        count[board[row * 3 + 1][col * 3 + 1]]++;
        count[board[row * 3 + 1][col * 3 + 2]]++;

        count[board[row * 3 + 2][col * 3 + 0]]++;
        count[board[row * 3 + 2][col * 3 + 1]]++;
        count[board[row * 3 + 2][col * 3 + 2]]++;

        for (int i = 1; i <= 9; i++) {
            if (count[i] > 1) return false;
        }
        return true;
    }
    private void ToIntBoard(char[][] brd) {
        board = new int[9][];
        for (int i = 0; i < 9; i++) {
            board[i] = new int[9];
        }
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (brd[i][j] == '.') continue;
                board[i][j] = brd[i][j] - '1' + 1;
            }
        }
    }
    private void FillZero() {
        Array.Fill(count, 0);
    }
}

/*
|0|1|2|
|3|4|5|
|6|7|8|
*/
