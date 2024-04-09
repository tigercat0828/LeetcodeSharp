namespace LeetcodeSharp.Solutions {
    public class Leetcode279 {
        struct Node {
            public int val;
            public int level;
            public Node(int v, int lvl) {
                val = v;
                level = lvl;
            }
        }
        int[] squares;
        public int NumSquares(int n) {
            InitSquares();
            if (isSquare(n)) {
                return 1;
            }
            Queue<Node> queue = new();
            queue.Enqueue(new Node(n, 0));
            while (queue.Count != 0) {
                Node pop = queue.Dequeue();
                if (isSquare(pop.val) || pop.val == 0) {
                    return pop.level + 1;
                }
                // enquque new Node;
                for (int i = 1; i <= 100; i++) {
                    int tmpVal = pop.val - squares[i];
                    if (tmpVal >= 0) {
                        queue.Enqueue(new Node(tmpVal, pop.level + 1));
                    }
                    else {
                        break;
                    }
                }
            }
            return -1; // BFS failed
        }
        private bool isSquare(int x) {
            int sqrtX = (int)MathF.Sqrt(x);
            return sqrtX * sqrtX == x;
        }
        private void InitSquares() {
            squares = new int[101];
            for (int i = 1; i <= 100; i++) {
                squares[i] = i * i;
            }
        }
        // DP approach
        public int NumSquares2(int n) {
            // Dynamic Programming;
            if (isSquare(n)) return 1;
            int[] DP = new int[n + 1];
            Array.Fill(DP, int.MaxValue);
            for (int i = 1; i * i <= n; i++) {
                DP[i * i] = 1;
            }
            // build DP table
            for (int i = 1; i <= n; i++) {
                if (DP[i] == 1) {
                    continue;
                }
                for (int j = 1; j * j <= i; j++) {
                    DP[i] = Math.Min(DP[i], DP[i - j * j] + 1);
                }
            }
            return DP[n];
        }
        public int NumSquares3(int n) {
            /* 
             * Legendre 3-Square Theorem
             * let n = aa+bb+cc 
             * <-> n not in form of 4^a*(8b+7)
             * answer will be 4
            */

            if (isSquare(n)) return 1;

            while (n % 4 == 0) {   // feteh the a(8b+7) part
                n /= 4;
            }
            if (n % 8 == 7) return 4;


            for (int i = 1; i * i <= n; i++) {
                int val = n - i * i;
                if (isSquare(val)) {
                    // n = A+B = (n-i*i) + (i*i)
                    return 2;
                }
            }
            return 3;
        }
    }
}
