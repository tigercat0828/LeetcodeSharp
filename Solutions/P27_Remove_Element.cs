namespace Leetcode.CSharp.Solutions {
    public class P27_Remove_Element {
        public int RemoveElement(int[] nums, int val) {
            int length = nums.Length;
            int index = 0;
            while (index < length) {
                if (nums[index] == val) {
                    ShiftLeft(nums, index, length);
                    length--;
                }
                else {
                    index++;
                }
            }
            return length;
        }

        public void ShiftLeft(int[] nums, int index, int length) {
            for (int i = index + 1; i < length; i++) {
                nums[i - 1] = nums[i];
            }
        }
    }
}
