namespace Leetcode.CSharp.Solutions;
public class Leetcode645 {
    public int[] FindErrorNums(int[] nums) {

        int[] freq = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++) {
            freq[nums[i]]++;
        }
        int[] result = new int[2];
        for (int i = 1; i < freq.Length; i++) {
            if (freq[i] == 2) {
                result[0] = i;
            }
            if (freq[i] == 0) {
                result[1] = i;
            }
        }

        return [.. result];
    }
}