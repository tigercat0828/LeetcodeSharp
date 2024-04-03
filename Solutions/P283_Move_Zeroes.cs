namespace Leetcode.CSharp.Solutions {
    public class P283_Move_Zeroes {
        public void MoveZeroes(int[] nums) {
            int len = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    nums[len] = nums[i];
                    len++;
                }
            }
            for (int i = len; i < nums.Length; i++) {
                nums[i] = 0;
            }
        }
    }
}
