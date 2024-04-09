namespace LeetcodeSharp.Solutions {
    // 2439. Minimize Maximum of Array
    public class Leetcode2439 {
        int[] nums;
        public int MinimizeArrayValue(int[] nums) {
            this.nums = nums;
            bool adjusted = true;
            while (adjusted) {
                int maxIndex = GetMaxIndex();
                int minIndex = GetMinIndex(maxIndex);
                adjusted = Adjust(minIndex, maxIndex);
            }
            Console.WriteLine($"Anser = {nums.Max()}");
            return nums.Max();
        }
        private int GetMaxIndex() {
            int maxIndex = nums.Length - 1;
            int maxValue = nums[maxIndex];
            for (int i = nums.Length - 1; i >= 0; i--) {
                if (nums[i] >= maxValue) {
                    maxIndex = i;
                    maxValue = nums[i];
                }
            }
            return maxIndex;
        }
        private int GetMinIndex(int start) {
            int minIndex = start;
            int minValue = nums[minIndex];
            for (int i = start - 1; i >= 0; i--) {
                if (nums[i] <= minValue) {
                    minIndex = i;
                    minValue = nums[i];
                }
            }
            return minIndex;
        }
        private bool Adjust(int left, int right) {
            int diff = nums[right] - nums[left];
            if (diff == 0) return false;
            int amount = (int)Math.Ceiling(diff / 2.0f);
            Console.WriteLine("amt = " + amount);
            nums[left] += amount;
            nums[right] -= amount;
            return true;
        }
    }
}
