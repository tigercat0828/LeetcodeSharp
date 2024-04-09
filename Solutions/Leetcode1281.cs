namespace LeetcodeSharp.Solutions;
public class Leetcode1281 {
    public int SubtractProductAndSum(int n) {
        int product = 1;
        int sum = 0;
        List<int> digits = ToDigits(n);
        foreach (var d in digits) {
            product *= d;
            sum += d;
        }
        return product - sum;


    }
    List<int> ToDigits(int n) {
        List<int> digits = [];
        while (n > 0) {
            digits.Add(n % 10);
            n /= 10;
        }
        return digits;
    }
}
