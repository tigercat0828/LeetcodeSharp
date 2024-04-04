
namespace LeetcodeSharp.Solutions; 
public class Leetcode1614 {
    // Maximum Nesting Depth of the Parentheses
    public int MaxDepth(string s) {
        int depth = 0;
        int maxDepth = 0;
        Stack<char> stack = [];
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                stack.Push('(');
                depth++;
                maxDepth = Math.Max(maxDepth, depth);
            }
            else if (s[i] == ')') {
                stack.Pop();
                depth--;
            }
        }
        return maxDepth;
    }
}
