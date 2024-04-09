namespace LeetcodeSharp.Solutions {
    public class P231_Power_of_two {
        public bool IsPowerOfTwo(int n) {
            return n > 0 && (n & n - 1) == 0;
        }
        public bool IsPowerOfTwo2(int n) {
            if (n < 0) return false;
            for (int i = 0; i < 32; i++) { // int 32-bits

                if (n == 1 << i) return true;
            }
            return false;
        }
    }
}
