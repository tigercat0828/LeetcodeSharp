namespace LeetcodeSharp.Solutions;
public class Leetcode58 {
    // TODO : optimize with while-loop
    public int LengthOfLastWord(string s) {
        string[] tokens = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int lastWordLen = tokens.Last().Length;
        return lastWordLen;
    }
}
