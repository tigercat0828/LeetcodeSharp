

using System.Text;

namespace LeetcodeSharp.Solutions;
public class Leetcode1544 {
    public string MakeGood(string s) {
        while (make(ref s)) ;
        return s;
    }
    private bool make(ref string s) {
        bool edited = false;
        int i = 0;
        StringBuilder sb = new();
        while (i < s.Length) {
            if (i < s.Length - 1 && Math.Abs(s[i] - s[i + 1]) == 32) {
                edited = true;
                i += 2;
            }
            else {
                sb.Append(s[i]);
                i++;
            }
        }
        s = sb.ToString();
        return edited;
    }
}

