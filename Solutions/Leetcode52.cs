namespace Leetcode.CSharp.Solutions {
    public class Leetcode52 {

        int ansCount;
        int size;
        bool[] diag1;   // left-bottom => right-top [r+c]
        bool[] diag2;   // right-bottom => left-top [r-c+n-1]
        bool[] cols;
        public int TotalNQueens(int n) {
            diag1 = new bool[2 * n + 1];
            diag2 = new bool[2 * n + 1];
            cols = new bool[n];

            ansCount = 0;
            size = n;

            FindPossible(0);
            return ansCount;
        }
        void FindPossible(int r) {
            if (r == size) {
                ansCount++;
            }
            // try every column
            for (int c = 0; c < size; c++) {
                if (!IsValid(r, c)) continue;
                SetQueen(r, c, true);
                FindPossible(r + 1);
                SetQueen(r, c, false);
            }
        }
        private bool IsValid(int r, int c) {
            if (cols[c]) return false;
            if (diag1[r + c]) return false;
            if (diag2[r - c + size - 1]) return false;
            return true;
        }
        private void SetQueen(int r, int c, bool putQueen) {
            diag1[r + c] = putQueen;
            diag2[r - c + size - 1] = putQueen;
            cols[c] = putQueen;
        }

    }
}
