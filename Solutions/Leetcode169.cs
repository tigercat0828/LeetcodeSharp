namespace LeetcodeSharp.Solutions;
public class Leetcode169 {

    // O(nlogn)
    public int MajorityElement2(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
    // O(n)
    public int MajorityElement(int[] nums) {

        if (nums.Length == 1) return nums[0];

        Dictionary<int, int> freq = [];
        int majorTime = nums.Length / 2;

        for (int i = 0; i < nums.Length; i++) {
            if (freq.ContainsKey(nums[i])) {
                freq[nums[i]]++;
            }
            else {
                freq.Add(nums[i], 1);
                continue;
            }
            if (freq[nums[i]] > majorTime) {
                return nums[i];
            }
        }
        return -1;
    }
}