namespace Leetcode.CSharp.Solutions;
public class Leetcode446 {

    // DP[i][diff] number of subseq with diff at i
    public int NumberOfArithmeticSlices(int[] nums) {
        List<Dictionary<int, int>> DP = [];
        int N = nums.Length;
        int ans = 0;
        for (int i = 0; i < N; i++) DP.Add([]);
        for (int i = 1; i < N; i++) {
            for (int j = 0; j < i; j++) {
                long diffLong = nums[i] - (long)nums[j];
                if (diffLong > int.MaxValue || diffLong < int.MinValue) {
                    continue;
                }
                int diff = (int)diffLong;
                DP[i][diff] = DP[i].GetValueOrDefault(diff) + 1;
                if (DP[j].TryGetValue(diff, out int value)) {
                    DP[i][diff] += value;
                    ans += value;
                }
            }
        }
        return ans;
    }


}