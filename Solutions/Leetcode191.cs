namespace Leetcode.CSharp.Solutions {
    public class Leetcode191 {
        // faster solution O(number of one bit)
        /*
            10101
            10100 +1
            -----
            10100
            10011 +1
            -----
            10000
            01111 +1
            -----
            00000 total 3 bit
         */
        public int HammingWeight(uint n) {
            int count = 0;
            while (n != 0) {
                n &= n - 1;
                count++;
            }
            return count;
        }
        // O(leading bit)
        public int HammingWeight2(uint n) {
            int count = 0;
            while (n > 0) {
                count += (int)(n & 1);
                n = n >> 1;
            }
            return count;
        }
    }
}
