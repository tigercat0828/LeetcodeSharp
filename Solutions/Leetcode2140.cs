namespace LeetcodeSharp.Solutions; 
public class Leetcode2140 {
    long[] DP;
    int[][] questions;
    // recursive form
    public long MostPoints(int[][] questions) {
        this.questions = questions;
        DP = new long[questions.Length];

        return DFS(0);
    }
    private long DFS(int no) {
        if (no >= DP.Length) return 0;
        if (DP[no] != 0) return DP[no];
        int point = questions[no][0];
        int power = questions[no][1];
        DP[no] = Math.Max(
            DFS(no + 1),        // skip the current question
            point + DFS(no + power + 1)
        );
        return DP[no];
    }
    // [[3, 2], [4, 3], [4, 4], [2, 5]]
}
