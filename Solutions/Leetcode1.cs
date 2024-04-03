namespace LeetcodeSharp.Solutions;
public class Leetcode1 {
    // O(n)
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = [];
        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                int a = dict[nums[i]];
                int b = i;
                return [a, b];
            }
            if (!dict.ContainsKey(target - nums[i])) {
                dict.Add(target - nums[i], i);
            }
        }
        return null; // Not found;
    }
    // O(n^2)
    public int[] TwoSum2(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i; j < nums.Length; j++) {
                if (i != j && nums[i] + nums[j] == target) {
                    return [i, j];
                }
            }
        }
        return null; // Not found;
    }
}
