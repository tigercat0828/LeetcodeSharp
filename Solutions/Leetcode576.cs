namespace LeetcodeSharp.Solutions;
public class Leetcode576 {
    private int M, N, MaxMove;
    private const int MOD = 1_000_000_000 + 7;
    private Dictionary<(int, int, int), int> cache;

    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        M = m;
        N = n;
        MaxMove = maxMove;
        cache = [];

        return DFS(startRow, startColumn, 0);
    }
    int DFS(int row, int col, int move) {

        if (row < 0 || row >= M || col < 0 || col >= N) {
            cache[(row, col, move)] = 1;
            return 1;
        }
        if (move == MaxMove) {
            cache[(row, col, move)] = 0;
            return 0;
        }
        if (cache.ContainsKey((row, col, move))) {
            return cache[(row, col, move)];
        }

        int north_south = (DFS(row - 1, col, move + 1) + DFS(row + 1, col, move + 1)) % MOD;
        int east_west = (DFS(row, col + 1, move + 1) + DFS(row, col - 1, move + 1)) % MOD;

        cache.Add((row, col, move), (north_south + east_west) % MOD);
        return cache[(row, col, move)];
    }
}