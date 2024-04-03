
public class Leetcode1043 {
    int[] cache;
    int[] arr;
    int k = 0;

    public int MaxSumAfterPartitioning(int[] arr, int k) {
        cache = new int[arr.Length];
        this.k = k;
        this.arr = arr;
        Array.Fill(cache, -1);
        return DFS(0);
    }
    private int DFS(int t) {
        if (t >= arr.Length) return 0;
        if (cache[t] != -1) return cache[t];
        int range = Math.Min(arr.Length, t + k);
        int currMax = -1;
        int result = 0;
        for (int i = t; i < range; i++) {
            currMax = Math.Max(currMax, arr[i]);
            int width = i - t + 1;
            result = Math.Max(result, DFS(i + 1) + currMax * width);
        }
        cache[t] = result;
        return result;
    }
}