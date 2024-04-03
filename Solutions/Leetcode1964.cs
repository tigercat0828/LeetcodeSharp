namespace LeetcodeSharp.Solutions; 
public class Leetcode1964 {
    // O(n^2) TLE
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles) {
        int[] result = new int[obstacles.Length];
        Array.Fill(result, 1);
        for (int i = 1; i < obstacles.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (obstacles[j] <= obstacles[i]) {
                    result[i] = Math.Max(result[i], result[j] + 1);
                }
            }
        }
        return result;
    }

}
