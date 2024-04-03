namespace Leetcode.CSharp.Solutions {
    public class Leetcode1502 {
        public bool CanMakeArithmeticProgression2(int[] arr) {
            if (arr.Length == 2) return true;
            Array.Sort(arr);

            for (int i = 1; i < arr.Length - 1; i++) {
                int formerDiff = arr[i] - arr[i - 1];
                int latterDiff = arr[i + 1] - arr[i];
                if (formerDiff != latterDiff) {
                    return false;
                }
            }
            return true;
        }
        // O(n) counting
        public bool CanMakeArithmeticProgression(int[] arr) {
            if (arr.Length <= 2) return true;
            const int bound = 1000000;
            Dictionary<int, int> dict = new();
            // -100000 ~ +100000
            int[] nums = new int[2 * bound + 1];
            for (int i = 0; i < arr.Length; i++) {
                int index = arr[i] + bound;
                nums[index]++;
                if (!dict.ContainsKey(index)) {
                    dict[index] = 1;
                }
                else {
                    dict[index]++;
                }

            }
            List<int> indices = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > 0) {
                    indices.Add(i);
                }
            }

            if (indices.Count == 1) {
                return true;
            }
            // O(arr.length)
            foreach (var item in dict) {
                if (item.Value > 1) return false;
            }

            for (int i = 1; i < indices.Count - 1; i++) {
                int formerIndexDiff = indices[i] - indices[i - 1];
                int latterIndexDiff = indices[i + 1] - indices[i];
                if (formerIndexDiff != latterIndexDiff) {
                    return false;
                }
            }
            return true;
        }
    }
}
