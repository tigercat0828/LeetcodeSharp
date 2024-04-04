namespace LeetcodeSharp.Solutions {
    public class Leetcode912 {
        public int[] SortArray(int[] nums) {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }
        private void QuickSort(int[] nums, int left, int right) {
            if (left < right) {
                int pivot = LomutoPartition(nums, left, right);
                QuickSort(nums, left, pivot - 1);
                QuickSort(nums, pivot + 1, right);
            }
        }
        private int LomutoPartition(int[] nums, int left, int right) {
            int pivot = right;
            int i = left;
            int j = left;
            while (j < pivot) {
                if (nums[j] < nums[pivot]) {
                    swap(nums, i, j);
                    i++;
                }
                j++;
            }
            swap(nums, i, pivot);
            return i;
        }
        private void swap(int[] nums, int i, int j) {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
