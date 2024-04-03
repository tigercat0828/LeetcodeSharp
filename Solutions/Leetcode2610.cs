namespace Leetcode.CSharp.Solutions;
public class Leetcode2610 {
    public IList<IList<int>> FindMatrix(int[] nums) {
        int[] freq = new int[nums.Length + 1];

        foreach (int n in nums) freq[n]++;

        int count = freq.Max();
        List<IList<int>> result = new(count);

        for (int i = 0; i < count; i++)
            result.Add(new List<int>());

        for (int i = 0; i < freq.Length; i++) {
            for (int t = 0; t < freq[i]; t++) {

                result[t].Add(i);
            }
        }
        return result;
    }
    public IList<IList<int>> FindMatrix2(int[] nums) {
        List<IList<int>> result = [];

        HashSet<int> ini = [nums[0]];
        List<HashSet<int>> sets = [ini];

        for (int i = 0; i < nums.Length; i++) {
            foreach (var set in sets) {
                if (set.Contains(nums[i])) {
                    continue;
                }
                else {
                    set.Add(nums[i]);
                }
            }
            HashSet<int> tmp = [nums[i]];
            sets.Add(tmp);
        }

        foreach (var set in sets) {
            result.Add(set.ToList());
        }
        return result;
    }
}
