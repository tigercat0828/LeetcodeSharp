
namespace Leetcode.CSharp.Solutions;
internal class Leetcode2966 {

    // O(nlogn)
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 3) {
            if ((nums[i + 2] - nums[i]) > k) {
                return [];
            }
        }

        int groupNum = nums.Length / 3;
        int[][] result = new int[groupNum][];

        for (int i = 0; i < result.Length; i++) {
            result[i] = new int[3];
        }
        for (int i = 0; i < nums.Length; i++) {
            int group = i / 3;
            result[group][i % 3] = nums[i];
        }
        return result;
    }
}
