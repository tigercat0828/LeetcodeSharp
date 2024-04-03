namespace Leetcode.CSharp.Solutions;

public class Leetcode2870 {
    public int MinOperations(int[] nums) {

        // init();

        var freq = CountFreq(nums);

        int result = 0;
        foreach (var item in freq) {
            int num = item.Value;
            if (num == 1) return -1;
            if (num % 3 == 0) {
                result += num / 3;

            }
            else {
                result += num / 3 + 1;
            }

            //result += query(num);
        }

        return result;
    }
    private Dictionary<int, int> CountFreq(int[] nums) {
        Dictionary<int, int> freq = [];
        foreach (var n in nums) {
            if (!freq.ContainsKey(n)) {
                freq.Add(n, 1);
            }
            else {
                freq[n]++;
            }
        }
        return freq;
    }

    // not even complex...
    int[] memo;
    private int query(int n) {
        if (memo[n] != 0) return memo[n];
        int n2 = query(n - 2);
        int n3 = query(n - 3);
        memo[n] = Math.Min(n2, n3) + 1;
        return memo[n];
    }
    private void init() {
        int range = 1_000_000 + 1;
        memo = new int[range];
        memo[1] = -1;
        memo[2] = 1;
        memo[3] = 1;
        memo[4] = 2;
    }
}
