namespace LeetcodeSharp.Solutions;
public class Leetcode1295 {
    public int FindNumbers(int[] nums) {
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            int digits = (int)Math.Log10(nums[i]) + 1;
            if (digits % 2 == 0) {
                count++;
            }

        }
        return count;
    }
}
