namespace Leetcode.CSharp.Solutions;
public class Leetcode2706 {
    public int BuyChoco(int[] prices, int money) {
        // find two smallest A,B
        // if A+B > money, return monry
        int A = int.MaxValue;
        int B = int.MaxValue;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < A) {
                B = A;
                A = prices[i];
            }
            else if (prices[i] < B) {
                B = prices[i];
            }
        }
        if (A + B > money) return money;
        return money - A - B;
    }
}


