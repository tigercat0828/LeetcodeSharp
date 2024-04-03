namespace Leetcode.CSharp.Solutions {
    public class Leetcode20 {
        public bool IsValid(string s) {

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++) {
                if (stack.Any()) {
                    stack.Push(s[i]);
                }
                else {
                    char top = stack.Peek();
                    char current = s[i];
                    if (top == '[' && current == ']' ||
                        top == '(' && current == ')' ||
                        top == '{' && current == '}') {
                        stack.Pop();
                    }
                    else {
                        stack.Push(current);
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
