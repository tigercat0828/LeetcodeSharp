namespace Leetcode.CSharp.Solutions {
    public class Leetcode704 {
        public int Search(int[] nums, int target) {
            return search(nums, target, 0, nums.Length - 1);
        }
        private int search(int[] nums, int target, int left, int right) {
            if (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                if (nums[mid] < target) {
                    return search(nums, target, mid + 1, right);
                }
                else {
                    return search(nums, target, left, mid - 1);
                }
            }
            return -1;
        }
        public int Search2(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                if (nums[mid] > target) {
                    right = mid - 1;
                    continue;
                }
                if (nums[mid] < target) {
                    left = mid + 1;
                    continue;
                }
            }
            return -1;
        }
    }
}
