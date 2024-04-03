namespace Leetcode.CSharp.Solutions {
    public class Leetcode217 {
        public bool ContainsDuplicate(int[] nums) {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i++) {
                if (!dict.ContainsKey(nums[i])) {
                    dict.Add(nums[i], 1);
                }
                else {
                    return true;
                }
            }
            return false;
        }
    }

}
