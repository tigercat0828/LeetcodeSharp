namespace LeetcodeSharp.Solutions;
public class Leetcode79 {
    int rows;
    int cols;
    string target;
    int TERMINAL;
    char[][] board;
    HashSet<(int, int)> visited;

    public bool Exist(char[][] board, string word) {

        this.board = board;
        target = word;
        rows = board.Length;
        cols = board[0].Length;
        TERMINAL = word.Length;
        visited = [];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                visited.Clear();
                if (Search(0, i, j)) return true;
            }
        }
        return false;
    }
    bool Search(int index, int row, int col) {  // apply DFS
        if (index == TERMINAL) return true;

        if (IsInBoundaryAndNotVisited(row, col) && board[row][col] == target[index]) {
            visited.Add((row, col));
            bool result = (
                Search(index + 1, row + 1, col) ||
                Search(index + 1, row - 1, col) ||
                Search(index + 1, row, col + 1) ||
                Search(index + 1, row, col - 1)
            );
            // backtracking
            if (!result) {
                visited.Remove((row, col));
            }
            return result;
        }
        return false;
    }
    bool IsInBoundaryAndNotVisited(int row, int col) {
        if (row >= 0 && row < rows &&
            col >= 0 && col < cols &&
            !visited.Contains((row, col))) return true;
        return false;
    }
}
