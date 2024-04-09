namespace LeetcodeSharp.Solutions {
    public class Leetcode35 {
        // O(logn)
        public int SearchInsert(int[] nums, int target) {
            if (target > nums[nums.Length - 1]) return nums.Length;

            int left = 0;
            int right = nums.Length - 1;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                else if (nums[mid] < target) {
                    left = mid + 1;
                }
                else {
                    right = mid;
                }

            }

            return left;
        }
    }
}
