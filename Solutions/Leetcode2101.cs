namespace Leetcode.CSharp.Solutions;

// Leetcode 2101 Detonate the Maximum Bombs
public class Leetcode2101 {
    List<List<int>> graph;
    public int MaximumDetonation(int[][] bombs) {
        // build graph
        int length = bombs.Length;
        graph = new(length);
        for (int i = 0; i < length; i++) {
            graph.Add(new List<int>());
        }
        for (int i = 0; i < length; i++) {
            for (int j = 0; j < length; j++) {
                if (i == j) continue;

                long x = bombs[i][0] - bombs[j][0];
                long y = bombs[i][1] - bombs[j][1];
                long r = bombs[i][2];
                if (r * r >= x * x + y * y) graph[i].Add(j);
            }
        }
        // Do DFS
        int result = 0;
        for (int i = 0; i < length; i++)
            result = Math.Max(result, DFS(i, new bool[length]));
        return result;
    }

    private int DFS(int node, bool[] visited) {
        visited[node] = true;
        int count = 1;
        foreach (var neighbour in graph[node]) {
            if (!visited[neighbour])
                count += DFS(neighbour, visited);
        }
        return count;
    }
}

