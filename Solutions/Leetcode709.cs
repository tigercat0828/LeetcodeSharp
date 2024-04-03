namespace Leetcode.CSharp.Solutions;
public class Leetcode709 {
    public string ToLowerCase(string s) {
        string res = "";
        for (int i = 0; i < s.Length; i++) {
            if (s[i] >= 65 && s[i] <= 90)
                res += (char)(s[i] + 32);
            else
                res += s[i];

        }
        return res;
    }
    // built-in
    public string ToLowerCase2(string s) {
        return s.ToLower();
    }
}