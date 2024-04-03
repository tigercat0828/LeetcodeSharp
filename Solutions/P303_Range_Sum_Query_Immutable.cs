namespace Leetcode.CSharp.Solutions {
    public class P303_Range_Sum_Query_Immutable {
        public class NumArray {
            int[] num;

            // O(n)
            public NumArray(int[] nums) {
                for (int i = 1; i < nums.Length; i++) {
                    nums[i] += nums[i - 1];
                }
                num = nums;
            }
            // O(1)
            public int SumRange(int left, int right) {
                if (left == 0) return num[right];
                if (right == 0) return num[0];
                return num[right] - num[left - 1];
            }
        }
        // slower version
        public class NumArray2 {
            int[] num;
            public NumArray2(int[] nums) {
                num = nums;
            }

            // O(n)
            public int SumRange(int left, int right) {
                int sum = 0;
                for (int i = left; i <= sum; i++) {
                    sum += num[i];
                }
                return sum;
            }
        }
    }
}
