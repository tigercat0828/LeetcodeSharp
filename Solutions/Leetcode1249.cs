using System.Text;

namespace LeetcodeSharp.Solutions;

/// <summary>
/// Minimum Remove to Make
/// </summary>
public class Leetcode1249 {

    public string MinRemoveToMakeValid(string s) {
        int length = s.Length;
        int[] sign = new int[length]; ;
        Stack<(char, int)> stack = [];

        for (int i = 0; i < length; i++) {
            if (s[i] == '(') {
                stack.Push(('(', i));
            }
            else if (s[i] == ')') {
                bool IsleftParen = stack.Count > 0 && stack.Peek().Item1 == '(';
                stack.Push((')', i));
                if (IsleftParen) {
                    int rightParen = stack.Pop().Item2;
                    int leftParen = stack.Pop().Item2;
                    sign[rightParen] = 1;
                    sign[leftParen] = 1;
                }
            }
            else {
                sign[i] = 1;
            }
        }
        StringBuilder sb = new(length);

        for (int i = 0; i < length; i++) {
            if (sign[i] == 1) sb.Append(s[i]);
        }
        Console.WriteLine(string.Join("", sign));
        return sb.ToString();
    }

}
