namespace Leetcode.CSharp.Solutions {
    public class P53_Maximum_Subarray {

        // O(n)
        public int MaxSubArray(int[] nums) {
            int maxSum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (sum < 0) {
                    sum = 0;
                }
                sum += nums[i];
                maxSum = Math.Max(sum, maxSum);
            }
            return maxSum;
        }
    }

}
