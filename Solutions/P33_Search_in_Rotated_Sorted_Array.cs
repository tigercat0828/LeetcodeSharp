namespace Leetcode.CSharp.Solutions {
    public class P33_Search_in_Rotated_Sorted_Array {
        public int Search(int[] nums, int target) {
            int index = FindMinIndex(nums);
            if (index == 0) {
                return BiSearch(nums, target, 0, nums.Length - 1);
            }
            int left = BiSearch(nums, target, 0, index - 1);
            int right = BiSearch(nums, target, index, nums.Length - 1);
            return Math.Max(left, right);
        }
        public int FindMinIndex(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right]) {
                    left = mid + 1;
                }
                else { // nums[mid] <= nums[right]
                    right = mid;
                }
            }
            return left;
        }
        private int BiSearch(int[] nums, int target, int left, int right) {
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                else if (nums[mid] < target) {
                    left = mid + 1;
                }
                else {
                    right = mid - 1;
                }
            }
            return -1;  // not found
        }
    }
}
