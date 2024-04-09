namespace LeetcodeSharp.Solutions {
    public class P414_Third_Maximum_Number {

        // O(3n)
        public int ThirdMax(int[] nums) {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            List<int> maxes = new List<int>();  // O(3) = O(1)
            for (int t = 0; t < 3; t++) {
                int max = int.MinValue;
                bool maxFound = false;
                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] >= max && !maxes.Contains(nums[i])) {
                        max = nums[i];
                        maxFound = true;
                    }
                }
                if (maxFound) maxes.Add(max);
            }
            if (maxes.Count == 3) {
                return maxes[2];
            }
            else {
                return maxes[0];
            }
        }
        public int ThirdMax2(int[] nums) {
            nums = nums.Distinct().ToArray();
            Array.Sort(nums);

            if (nums.Length < 3) {
                return nums.Max();
            }
            else {
                return nums[nums.Length - 3];
            }

        }
    }
}

