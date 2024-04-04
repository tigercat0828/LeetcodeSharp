namespace LeetcodeSharp.Solutions {
    public class Leetcode977 {
        // O(n)
        public int[] SortedSquares(int[] nums) {
            int[] ans = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int index = nums.Length - 1;
            while (left <= right) {
                int select;
                if (Math.Abs(nums[right]) > Math.Abs(nums[left])) {
                    select = nums[right--];
                }
                else {
                    select = nums[left++];
                }
                ans[index--] = select * select;
            }
            return ans;
        }

        // O(nlogn)
        public int[] SortedSquares2(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);
            return nums;
        }
    }
}
