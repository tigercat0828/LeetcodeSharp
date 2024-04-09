namespace LeetcodeSharp.Solutions {
    public class P153_Find_Minimum_in_Rotated_Sorted_Array {
        public int FindMin(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right]) {
                    left = mid + 1;
                }
                else {
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
