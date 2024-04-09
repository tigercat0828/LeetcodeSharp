namespace LeetcodeSharp.Solutions;
public class Leetcode322 {
    // dp approach bottom-up
    public int CoinChange(int[] coins, int amount) {

        /* state transition function
         * R[i] 代表硬幣數
         * R[i] = min(R[i], R[i-coins[i]]+1);
         */
        int[] remain = new int[amount + 1];
        Array.Fill(remain, -1);
        remain[0] = 0;
        for (int i = 1; i <= amount; i++) {
            foreach (var coin in coins) {
                if (i - coin < 0) continue;
                if (remain[i - coin] == -1) continue;    // i-coin 也沒有答案,換下一個coin測試

                if (remain[i] == -1) {
                    remain[i] = remain[i - coin] + 1;
                }
                else {
                    remain[i] = Math.Min(remain[i], remain[i - coin] + 1);
                }
            }
        }
        return remain[amount];
    }

    // BFS approach
    public int CoinChange2(int[] coins, int amount) {
        Queue<Node> queue = new Queue<Node>();
        bool[] dict = new bool[10001];
        queue.Enqueue(new Node(amount, 0));
        dict[amount] = true;
        while (queue.Count > 0) {
            Node pop = queue.Dequeue();
            if (pop.remain == 0) return pop.level;
            foreach (var coin in coins.Reverse()) {
                int possible = pop.remain - coin;
                if (possible >= 0 && !dict[possible]) {
                    queue.Enqueue(new Node(possible, pop.level + 1));
                    dict[possible] = true;
                }
            }
        }
        return -1;
    }
    class Node {
        public int remain;
        public int level;
        public Node(int remain, int level) {
            this.remain = remain;
            this.level = level;
        }
    }
}
