namespace Leetcode.CSharp.Solutions {
    public class P344_Reverse_String {
        // iterative
        public void ReverseString(char[] s) {
            int tail = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++) {
                Swap(ref s[i], ref s[tail - i]);
            }
        }
        private void Swap(ref char a, ref char b) {
            char temp = a;
            a = b;
            b = temp;
        }
        // recursive
        public void ReverseString2(char[] s) {
            reverse(s, 0);
        }
        private void reverse(char[] s, int i) {
            if (i == s.Length / 2) {
                return;
            }
            reverse(s, i + 1);
            Swap(ref s[i], ref s[s.Length - 1 - i]);
        }
    }
}
