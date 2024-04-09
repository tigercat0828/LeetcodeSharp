namespace LeetcodeSharp.Solutions;
public class Leetcode547 {
    public int FindCircleNum(int[][] isConnected) {
        int groups = 0;
        int length = isConnected.Length;
        bool[] visited = new bool[length];
        for (int i = 0; i < length; i++) {
            if (!visited[i]) {
                DFS(isConnected, visited, i);
                groups++;
            }
        }
        return groups;
    }
    private void DFS(int[][] matrix, bool[] visited, int node) {

        visited[node] = true;
        for (int i = 0; i < matrix[node].Length; i++) {
            if (matrix[node][i] == 1 && !visited[node]) {
                DFS(matrix, visited, i);
            }
        }
    }
}
