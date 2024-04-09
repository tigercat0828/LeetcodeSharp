namespace LeetcodeSharp.Solutions {
    public class Leetcode290 {
        public bool WordPattern(string pattern, string s) {
            // Bidirection Dict
            Dictionary<char, string> pat2tok = new();
            Dictionary<string, char> tok2pat = new();
            string[] tokens = s.Split();
            if (tokens.Length != pattern.Length) return false;
            for (int i = 0; i < pattern.Length; i++) {
                char patKey = pattern[i];
                if (pat2tok.ContainsKey(patKey)) {
                    if (pat2tok[patKey] != tokens[i]) return false;
                }
                else {
                    pat2tok.Add(pattern[i], tokens[i]);
                }
                string tokKey = tokens[i];
                if (tok2pat.ContainsKey(tokKey)) {
                    if (tok2pat[tokKey] != pattern[i]) return false;
                }
                else {
                    tok2pat.Add(tokKey, pattern[i]);
                }
            }
            return true;
        }
    }

}
