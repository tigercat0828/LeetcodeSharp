namespace LeetcodeSharp.Solutions {
    public class Leetcode55 {

        /*
            [2 3 5 0 0 0 0 0 1 .......]
        =>  [2 3 5 4 3 2 1 0 X X X X X]
        */
        // DP bottom up 
        public bool CanJump(int[] nums) {

            for (int i = 1; i < nums.Length; i++) {
                if (nums[i - 1] == 0) return false;                // if available move of last point is 0, we cant reach this point
                nums[i] = Math.Max(nums[i], nums[i - 1] - 1);   // i-1 to i, cost one step
            }
            return true;
        }
        // Brute force O(n^2)
        public bool CanJump2(int[] nums) {
            int length = nums.Length;
            bool[] can = new bool[length];
            can[0] = true;
            for (int i = 0; i < length; i++) {
                if (can[i] == false) return false;
                for (int j = 1; j <= nums[i]; j++) {
                    if (i + j < length) {
                        can[i + j] = true;
                    }
                }
            }
            return can.Last();
        }
    }
}
