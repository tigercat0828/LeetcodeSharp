namespace LeetcodeSharp.Solutions;
public class Leetcode1207 {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> freq = [];
        foreach (int i in arr) {
            if (freq.ContainsKey(i)) freq[i]++;
            else freq.Add(i, 1);
        }
        HashSet<int> uniqueOccurence = [];
        foreach (int i in freq.Values) {
            if (uniqueOccurence.Contains(i)) {
                return false;
            }
            uniqueOccurence.Add(i);
        }
        return true;
    }

}
