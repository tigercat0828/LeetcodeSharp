namespace Leetcode.CSharp.Solutions {
    public class P34_Find_First_and_Last_Position_of_Element_in_Sorted_Array {
        public int[] SearchRange(int[] nums, int target) {
            int left = 0;
            int right = nums.Length;
            // find start
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] >= target) {
                    right = mid;
                }
                else {
                    left = mid + 1;
                }
            }
            if (left == nums.Length || nums[left] != target) {
                return new int[] { -1, -1 };
            }
            int startIndex = left;
            right = nums.Length;

            // find end 
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] > target) {
                    right = mid;
                }
                else {
                    left = mid + 1;
                }
            }
            int endIndex = left - 1;
            return new int[] { startIndex, endIndex };
        }

        // Build-in function
        public int[] SearchRange2(int[] nums, int target) {
            if (!nums.Contains(target)) {
                return new int[2] { -1, -1 };
            }
            int start = Array.IndexOf(nums, target);
            int end = Array.LastIndexOf(nums, target);
            return new int[] { start, end };
        }

    }
}
