namespace Leetcode.CSharp.Solutions {

    public class P485_Max_Consecutive_Ones {
        public int FindMaxConsecutiveOnes(int[] nums) {
            int count = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1) {
                    count++;
                    if (count > max) {
                        max = count;
                    }
                }
                else {
                    count = 0;
                }
            }
            return max;
        }

    }
}
