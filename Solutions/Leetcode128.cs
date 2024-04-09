namespace LeetcodeSharp.Solutions {
    // Longest Consecutive Sequence
    public class Leetcode128 {
        HashSet<int> set = new();
        HashSet<int> visited = new();
        public int LongestConsecutive(int[] nums) {

            for (int i = 0; i < nums.Length; i++) {
                set.Add(nums[i]);
            }
            int maxConse = 0;
            foreach (var num in set) {
                if (visited.Contains(num)) continue;
                int forward = CheckForward(num);
                int backward = CheckBackward(num);
                maxConse = Math.Min(maxConse, forward + backward + 1);
            }
            return maxConse;
        }
        private int CheckForward(int num) {
            visited.Add(num);
            int conse = 0;
            foreach (var n in set) {
                num++;
                if (set.Contains(num)) {
                    visited.Add(num);
                    conse++;
                }
                else break;
            }
            return conse;
        }
        private int CheckBackward(int num) {
            visited.Add(num);
            int conse = 0;
            foreach (var n in set) {
                num--;
                if (set.Contains(num)) {
                    visited.Add(num);
                    conse++;
                }
                else break;
            }
            return conse;
        }
        // out of memory
        public int LongestConsecutive2(int[] nums) {
            int offset = 1000000000;
            bool[] appear = new bool[2 * offset + 1];
            for (int i = 0; i < nums.Length; i++) {
                int index = nums[i] + offset;
                appear[index] = true;
            }
            int maxConse = 0;
            int conse = 0;
            for (int i = 0; i < appear.Length; i++) {
                if (!appear[i])
                    conse = 0;
                else
                    conse++;
                if (conse > maxConse) maxConse = conse;
            }
            return maxConse;
        }
    }
}
