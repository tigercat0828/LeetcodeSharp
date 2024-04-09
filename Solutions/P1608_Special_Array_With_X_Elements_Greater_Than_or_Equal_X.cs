namespace LeetcodeSharp.Solutions {
    public class P1608_Special_Array_With_X_Elements_Greater_Than_or_Equal_X {
        // O(n) Counting
        public int SpecialArray(int[] nums) {
            int n = nums.Length;

            // counting
            int[] counter = new int[n + 1];
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] >= n) {
                    counter[n]++;
                }
                else {
                    counter[nums[i]]++;
                }
            }
            // check
            int sum = 0;
            for (int i = counter.Length - 1; i >= 0; i--) {
                sum += counter[i];
                if (sum == i) return i;
                if (sum > i) break;
            }

            return -1; // not a special array
        }
        // O(n^2 )Brute Force   
        public int SpecialArray2(int[] nums) {
            for (int i = 0; i <= nums.Length; i++) {
                if (i == check(nums, i)) {
                    return i;
                }
            }
            return -1;
        }
        int check(int[] nums, int x) {
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (x <= nums[i]) {
                    count++;
                }
            }
            return count;
        }
    }
}
