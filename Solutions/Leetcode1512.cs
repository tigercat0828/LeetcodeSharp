namespace LeetcodeSharp.Solutions {
    public class Leetcode1512 {
        // O(n^2)
        public int NumIdenticalPairs2(int[] nums) {
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0; j < nums.Length; j++) {
                    if (nums[i] == nums[j] && i < j) {
                        count++;
                    }
                }
            }
            return count;
        }
        // O(n)
        public int NumIdenticalPair(int[] nums) {
            // num[i] : 1 ~ 100
            int[] dict = new int[101];
            foreach (int i in nums) {
                dict[i]++;
            }
            int count = 0;
            for (int i = 0; i < dict.Length; i++) {
                if (dict[i] > 1) {
                    int n = dict[i];
                    count += n * (n - 1) / 2;
                }
            }
            return count;
        }

    }
}
