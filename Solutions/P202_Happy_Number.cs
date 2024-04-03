namespace Leetcode.CSharp.Solutions {
    public class P202_Happy_Number {
        public bool IsHappy(int n) {

            HashSet<int> visited = new HashSet<int>();
            while (n != 1) {
                if (visited.Contains(n)) return false;
                visited.Add(n);
                n = DigitsSquareSum(n);
            }
            return true;
        }
        private int DigitsSquareSum(int n) {
            int sum = 0;
            while (n > 0) {
                int d = n % 10;
                sum += d * d;
                n /= 10;
            }
            // Console.WriteLine(sum);
            return sum;
        }
    }
}
