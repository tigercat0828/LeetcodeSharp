namespace Leetcode.CSharp.Solutions {
    public class Leetcode1464 {
        public int MaxProduct(int[] nums) {
            if (nums.Length < 2) return -1;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max1) {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2) {
                    max2 = nums[i];
                }
            }
            return (max1 - 1) * (max2 - 1);
        }
        public int MaxProduct2(int[] nums) {
            if (nums.Length < 2) return -1;
            int max1 = Math.Max(nums[0], nums[1]);
            int max2 = Math.Min(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++) {
                if (nums[i] > max2) {
                    max2 = nums[i];
                    if (max2 > max1) {
                        (max1, max2) = (max2, max1);  // swap
                    }
                }

            }
            return (max1 - 1) * (max2 - 1);
        }
    }
}
