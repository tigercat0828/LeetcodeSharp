namespace LeetcodeSharp.Solutions;
public class Leetcode205 {
    // Isomorphic Strings
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, char> maps = [];
        Dictionary<char, char> mapt = [];
        for (int i = 0; i < s.Length; i++) {
            if (maps.TryGetValue(s[i], out char values)) {
                if (values != t[i]) return false;
            }
            else {
                maps.Add(s[i], t[i]);
            }
            if (mapt.TryGetValue(t[i], out char valueT)) {
                if (valueT != s[i]) return false;
            }
            else {
                mapt.Add(t[i], s[i]);
            }
        }
        return true;
    }
}
