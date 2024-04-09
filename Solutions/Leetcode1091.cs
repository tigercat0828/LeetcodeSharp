namespace LeetcodeSharp.Solutions;
public class Leetcode1091 {

    public int ShortestPathBinaryMatrix(int[][] grid) {

        int n = grid.Length;

        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1) return -1;    // start or end are obstacle

        // setup
        int[] DIR_R = [0, 1, 1, 1, 0, -1, -1, -1];
        int[] DIR_C = [1, 1, 0, -1, -1, -1, 0, 1];

        int[][] distance = new int[n][];
        for (int i = 0; i < n; i++) {
            distance[i] = new int[8];
            Array.Fill(distance[i], -1);
        }

        // Run Dijsktra
        Queue<int[]> queue = new();
        distance[0][0] = 1;
        queue.Enqueue([0, 0]);
        while (queue.Count != 0) {
            int[] pop = queue.Dequeue();
            int row = pop[0];
            int col = pop[1];
            if (row == n - 1 && col == n - 1) return distance[row][col];

            for (int i = 0; i < 8; i++) {
                int nextR = row + DIR_R[i];
                int nextC = col + DIR_C[i];

                if (nextR >= 0 && nextR < n && nextC >= 0 && nextC < n &&
                    distance[nextR][nextC] == -1 && grid[nextR][nextC] == 0) {

                    distance[nextR][nextC] = distance[row][col] + 1;
                    queue.Enqueue([nextR, nextC]);
                }
            }
        }
        return -1; // no path
    }


}


