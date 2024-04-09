namespace LeetcodeSharp.Solutions; 
public class Leetcode136 {

    // O(n) Xor operation 
    public int SingleNumber(int[] nums) {
        int ans = 0;
        for (int i = 0; i < nums.Length; i++) {
            ans = ans ^ nums[i];
        }
        return ans;
    }
    // Time O(n)
    // Space O(n)
    public int SingleNumber2(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!dict.ContainsKey(nums[i])) {
                dict.Add(nums[i], 1);
            }
            else {
                dict[nums[i]]++;
            }
        }
        foreach (var item in dict) {
            if (item.Value == 1) {
                return item.Key;
            }
        }
        return -1;  // no single number
    }
}
