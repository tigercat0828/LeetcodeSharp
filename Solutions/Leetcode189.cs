namespace LeetcodeSharp.Solutions;
public class Leetcode189 {
    // time O(n)
    public void Rotate(int[] nums, int k) {

        int len = nums.Length;
        int[] result = new int[len];
        for (int i = 0; i < len; i++) {
            int ni = (i + k) % len;
            result[ni] = nums[i];
        }
        Array.Copy(result, 0, nums, 0, len);
    }
    // O(n) so cool
    public void Rotate2(int[] nums, int k) {
        int len = nums.Length;
        k = k % len;
        Reverse(nums, 0, len - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, len - 1);

    }
    void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int tmp = nums[start];
            nums[start] = nums[end];
            nums[end] = tmp;
            start++;
            end--;
        }
    }
}
