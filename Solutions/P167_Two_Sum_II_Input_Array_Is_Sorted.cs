namespace Leetcode.CSharp.Solutions {
    public class P167_Two_Sum_II_Input_Array_Is_Sorted {
        // O(n) two pointer
        public int[] TwoSum(int[] numbers, int target) {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right) {
                int sum = numbers[left] + numbers[right];
                if (sum == target) {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target) {
                    left++;
                }
                else {  // sum > target
                    right--;
                }
            }
            return null; // Invalid input
        }

        // O(nlogn) input is sorted
        public int[] TwoSum2(int[] numbers, int target) {
            for (int i = 0; i < numbers.Length; i++) {
                int res = bisearch(numbers, target - numbers[i], i + 1);
                if (res != -1) {
                    return new int[] { i + 1, res + 1 };
                }
            }
            // no two sum in array, invalid input case
            return null;
        }
        private int bisearch(int[] nums, int target, int left) {
            int right = nums.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                else if (nums[mid] < target) {
                    left = mid + 1;
                }
                else {
                    right = mid - 1;
                }
            }
            return -1;
        }
        // O(n) by dict
        public int[] TwoSum3(int[] numbers, int target) {
            Dictionary<int, IndexValuePair> dict = new Dictionary<int, IndexValuePair>();
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length; i++) {
                if (dict.ContainsKey(numbers[i])) {
                    result[0] = dict[numbers[i]].index + 1;     // 1-start indexed
                    result[1] = i + 1;
                    break;
                }
                else {
                    if (!dict.ContainsKey(target - numbers[i])) {
                        dict.Add(target - numbers[i], new IndexValuePair(i, numbers[i]));
                    }
                }
            }
            return result;
        }
        public struct IndexValuePair {
            public int index;
            public int value;
            public IndexValuePair(int index, int value) {
                this.index = index;
                this.value = value;
            }
        }
    }
}
