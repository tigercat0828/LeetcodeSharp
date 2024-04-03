namespace Leetcode.CSharp.Solutions {
    public class Leetcode1688 {
        // 1688. Count of Matches in Tournament
        public int NumberOfMatches(int n) => n - 1;
        public int NumberOfMatches2(int n) {
            int matchSum = 0;
            while (n != 1) {
                matchSum += n / 2;
                n = (n + 1) / 2;
                /*
                if (n % 2 == 0) {   // n is even
                    n /= 2;
                    matchSum += n;
                }
                else {              // n is odd
                    n /= 2;
                    matchSum += n;
                    n++;
                }
                */
            }
            return matchSum;
        }
    }
}
