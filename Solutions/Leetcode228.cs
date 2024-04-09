namespace LeetcodeSharp.Solutions;
public class Leetcode228 {
    public IList<string> SummaryRanges(int[] nums) {

        List<string> result = new();
        int i = 0;
        int a = 0;
        while (i + 1 < nums.Length) {
            if (nums[i] + 1 == nums[i + 1]) {
                i++;
            }
            else {
                if (a == i) {
                    result.Add($"{nums[i]}");
                }
                else {
                    result.Add($"{nums[a]}->{nums[i]}");
                }
                i++;
                a = i;
            }
        }
        if (i < nums.Length) {

            if (a == i) {
                result.Add($"{nums[i]}");
            }
            else {
                result.Add($"{nums[a]}->{nums[i]}");
            }
        }

        return result;
    }
}
