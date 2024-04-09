namespace LeetcodeSharp.Solutions {
    public class P976_Largest_Perimeter_Triangle {

        // O(nlogn)
        public int LargestPerimeter(int[] nums) {
            Array.Sort(nums, (a, b) => b.CompareTo(a));
            for (int i = 0; i < nums.Length - 2; i++) {
                if (nums[i] < nums[i + 1] + nums[i + 2]) {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }
            return -1;
        }
    }
}
