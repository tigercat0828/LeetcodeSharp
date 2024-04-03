namespace Leetcode.CSharp.Solutions;
public class Leetcode1704 {
    public bool HalvesAreAlike(string s) {

        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        int half = s.Length / 2;
        string subStr1 = s.Substring(0, half - 1);
        string subStr2 = s.Substring(half, s.Length - 1);
        int vows1 = 0;
        int vows2 = 0;
        for (int i = 0; i < half; i++) {
            if (vowels.Contains(subStr1[i])) vows1++;
            if (vowels.Contains(subStr2[i])) vows2++;
        }
        return vows1 == vows2;
    }
}
