using System.Text;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode1758 {
        public int MinOperations(string s) {
            // either start with '0' or '1'
            // "10101010....." or "0101010101...."
            StringBuilder zeroSB = new();
            StringBuilder oneSB = new();
            for (int i = 0; i < s.Length; i++) {
                if (i % 2 == 0) {
                    zeroSB.Append('0');
                    oneSB.Append('1');
                }
                else {
                    zeroSB.Append('1');
                    oneSB.Append('0');
                }

            }
            string zeroStr = zeroSB.ToString();
            string oneStr = oneSB.ToString();
            int oneDiff = 0;
            int zeroDiff = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != zeroStr[i]) zeroDiff++;
                if (s[i] != oneStr[i]) oneDiff++;
            }
            return Math.Min(oneDiff, zeroDiff);
        }
    }
}
