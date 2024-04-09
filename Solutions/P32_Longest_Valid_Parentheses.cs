namespace LeetcodeSharp.Solutions {
    public class P32_Longest_Valid_Parentheses {
        // (char, index)
        struct Node {
            public char ch;
            public int index;
            public Node(char ch, int index) {
                this.ch = ch;
                this.index = index;
            }
        }
        // O(n)
        public int LongestValidParentheses(string s) {

            if (string.IsNullOrEmpty(s)) return 0;
            bool[] isValid = new bool[s.Length];
            Stack<Node> stack = new Stack<Node>();

            for (int i = 0; i < s.Length; i++) {
                Node next = new Node(s[i], i);
                if (stack.Count == 0) {
                    stack.Push(next);
                    continue;
                }

                Node peek = stack.Peek();
                if (peek.ch == '(' && next.ch == ')') {
                    Node pop = stack.Pop();
                    isValid[pop.index] = true;
                    isValid[i] = true;
                }
                else {
                    stack.Push(next);
                }
            }

            // calcute max interval 
            int maxCount = int.MinValue;
            int count = 0;

            for (int i = 0; i < isValid.Length; i++) {
                if (isValid[i]) count++;
                else count = 0;
                if (count > maxCount) {
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}
