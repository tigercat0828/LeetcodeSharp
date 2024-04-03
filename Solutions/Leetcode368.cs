namespace LeetcodeSharp.Solutions;
public class Leetcode368 {
    // DP O(n^2)
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        int length = nums.Length;
        int[] previous = new int[length];
        int[] count = new int[length];
        //previous[0] = -1;
        count[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            for (int j = i; j >= 0; j--) {
                if (nums[i] % nums[j] == 0 && count[i] < count[j] + 1) {
                    count[i] = count[j] + 1;
                    previous[i] = j;
                }
            }
        }
        //print the DP table
        //Console.WriteLine(string.Join(",", nums));
        //Console.WriteLine(string.Join(",", previous));
        //Console.WriteLine(string.Join(",", count));

        List<int> result = [];
        int currIndex = 0;

        int max = count[0];
        for (int i = 1; i < length; i++) {
            if (count[i] > max) {
                max = count[i];
                currIndex = i;
            }
        }

        //Console.WriteLine(currIndex);
        int lastIndex = -1;
        while (currIndex != -1 && lastIndex != currIndex) {

            result.Add(nums[currIndex]);

            lastIndex = currIndex;
            currIndex = previous[currIndex];
        }

        //Console.WriteLine(string.Join(",", result));
        return result;
    }

    // out of memory, brute force O(2^n)
    public IList<int> LargestDivisibleSubset2(int[] nums) {
        Array.Sort(nums);
        originSet = nums;

        GetAllSubsetHelper(0, []);

        int maxCount = 0;
        int returnIndex = -1;

        for (int i = 0; i < Subsets.Count; i++) {
            int len = GetDivisibleSetLength(Subsets[i]);
            if (len > maxCount) {
                maxCount = len;
                returnIndex = i;
            }
        }
        return Subsets[returnIndex];
    }
    List<List<int>> Subsets = [];
    int[] originSet;
    private void GetAllSubsetHelper(int index, List<int> current) {
        Subsets.Add(new(current));
        for (int i = index; i < originSet.Length; i++) {
            current.Add(originSet[i]);
            GetAllSubsetHelper(i + 1, current);
            current.RemoveAt(current.Count - 1);
        }
    }
    private int GetDivisibleSetLength(List<int> set) {
        for (int i = 0; i < set.Count; i++) {
            for (int j = i; j < set.Count; j++) {
                if (set[j] % set[i] != 0) {
                    return 0;
                }
            }
        }
        return set.Count;
    }
}
