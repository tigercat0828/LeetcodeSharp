namespace LeetcodeSharp.Solutions {
    public class Leetcode51 {

        List<IList<string>> result;
        char[][] board;
        bool[] cols;
        bool[] diag1;   // r+c       left-bottom > top-right
        bool[] diag2;   // r-c+n-1   top-left > bottom-right
        public IList<IList<string>> SolveNQueens(int n) {
            result = new List<IList<string>>();
            cols = new bool[n];
            diag1 = new bool[2 * n - 1];
            diag2 = new bool[2 * n - 1];
            board = new char[n][];
            for (int i = 0; i < n; i++) {
                board[i] = new char[n];
            }
            for (int r = 0; r < n; r++) {
                for (int c = 0; c < n; c++) {
                    board[r][c] = '.';
                }
            }

            FindPossible(0, n);

            return result;
        }
        private void SetQueen(int r, int c, int n, bool putQueen) {
            board[r][c] = putQueen ? 'Q' : '.';
            cols[c] = putQueen;
            diag1[r + c] = putQueen;
            diag2[r - c + n - 1] = putQueen;
        }
        private void FindPossible(int r, int n) {
            if (r == n) {
                result.Add(ToListString(board));
            }
            // try every col;
            for (int c = 0; c < n; c++) {
                if (!IsValid(r, c, n)) continue;
                SetQueen(r, c, n, true);
                FindPossible(r + 1, n);
                SetQueen(r, c, n, false);
            }
        }
        private bool IsValid(int r, int c, int n) {
            if (cols[c]) return false;
            if (diag1[r + c]) return false;
            if (diag2[r - c + n - 1]) return false;
            return true;
        }
        private List<string> ToListString(char[][] board) {
            List<string> boardStr = new List<string>();
            foreach (var row in board) {
                boardStr.Add(string.Join("", row));
            }
            return boardStr;
        }
    }
}
