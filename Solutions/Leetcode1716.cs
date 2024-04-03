namespace Leetcode.CSharp.Solutions;

// 1716. Calculate Money in Leetcode Bank
public class Leetcode1716 {
    public int TotalMoney(int n) {
        // O(1)
        int weeks = n / 7;
        int days = n % 7;
        // 1-st week = 28 [1,2,3,4,5,6,7]
        // 2-nd week = 35 [2,3,4,5,6,7,8]
        // 3-rd week = 42 [3,4,5,6,7,8,9]
        // ...
        // n-th week = 7*(n+3) [n,n+1, ...]

        // Arithmetic series
        // Sn = n(a1+an)/2

        // int total = weeks * (28 + 7 * (weeks + 3)) / 2;
        int total = weeks * 7 * (weeks + 7) / 2;
        total += days * (weeks + 1 + weeks + days) / 2; // [w+1,w+2,w+3,...] 
        return total;
    }


}
