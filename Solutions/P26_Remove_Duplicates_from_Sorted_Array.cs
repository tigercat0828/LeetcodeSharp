namespace LeetcodeSharp.Solutions {
    public class P26_Remove_Duplicates_from_Sorted_Array {

        public int RemoveDuplicates(int[] nums) {
            int len = 0;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[len] == nums[i]) {
                    continue;
                }
                nums[len++] = nums[i];
            }
            return len + 1;
        }
        public int RemoveDuplicates2(int[] nums) {
            if (nums.Length == 0) return 0;
            int length = nums.Length;
            int index = 1;
            int hold = nums[0];
            while (index < length) {
                if (nums[index] == hold) {
                    ShiftLeft(nums, index - 1, length);
                    length--;
                }
                else {
                    hold = nums[index];
                    index++;
                }
            }
            return length;
        }
        private void ShiftLeft(int[] nums, int index, int length) {
            for (int i = index + 1; i < length; i++) {
                nums[i - 1] = nums[i];
            }
        }
    }
}
