namespace Leetcode.CSharp.Solutions {
    public class Leetcode1913 {
        public int MaxProductDifference(int[] nums) {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max1) {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2) {
                    max2 = nums[i];
                }

                if (nums[i] < min1) {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2) {
                    min2 = nums[i];
                }
            }
            return max1 * max2 - min1 * min2;
        }
    }
}

