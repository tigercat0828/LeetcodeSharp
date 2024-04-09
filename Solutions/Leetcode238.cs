namespace LeetcodeSharp.Solutions {
    public class Leetcode238 {
        public int[] ProductExceptSelf(int[] nums) {
            int product = 1;
            int zeroNum = 0;
            int zeroIndex = -1;
            int length = nums.Length;
            for (int i = 0; i < length; i++) {
                if (nums[i] == 0) {
                    zeroNum++;
                }
                else {
                    product *= nums[i];
                }
            }
            int[] result = new int[length];

            if (zeroNum == 0) {
                for (int i = 0; i < length; i++) {
                    result[i] = product / nums[i];
                }
            }
            else if (zeroNum == 1) {
                result[zeroIndex] = product;
                // all the other are zero
            }
            // if zeroNum >=2, all are zero
            return result;
        }
    }
}
