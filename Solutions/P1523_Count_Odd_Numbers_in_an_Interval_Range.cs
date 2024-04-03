namespace Leetcode.CSharp.Solutions {
    public class P1523_Count_Odd_Numbers_in_an_Interval_Range {
        public int CountOdds(int low, int high) {
            if (low % 2 == 0) low++;
            if (high % 2 == 0) high--;
            int ans = (high - low) / 2 + 1;
            return ans;
        }
    }
}
