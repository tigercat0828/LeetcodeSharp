namespace Leetcode.CSharp.Solutions {
    public class P1672_Richest_Customer_Wealth {
        public int MaximumWealth(int[][] accounts) {
            int maxCustomer = int.MinValue;
            int banks = accounts[0].Length;
            for (int i = 0; i < accounts.Length; i++) {
                int customer = 0;
                for (int j = 0; j < banks; j++) {
                    customer += accounts[i][j];
                }
                if (customer > maxCustomer) {
                    maxCustomer = customer;
                }
            }
            return maxCustomer;
        }
    }
}
