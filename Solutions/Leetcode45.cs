namespace Leetcode.CSharp.Solutions {
    public class Leetcode45 {
        struct Node {

            public Node(int position, int move, int level) {
                Position = position;
                Move = move;
                Level = level;
            }
            public int Position;
            public int Move;
            public int Level;
            public override string ToString() {
                return $"{Position}, {Move}, {Level}";
            }

        }
        // bad BFS out of memory : TODO optimize it
        public int Jump(int[] nums) {
            Queue<Node> queue = new Queue<Node>();
            int length = nums.Length;
            queue.Enqueue(new Node(0, nums[0], 0));
            while (queue.Count > 0) {
                Node pop = queue.Dequeue();
                //Console.WriteLine($"Dequeue {pop}");
                if (pop.Position == length - 1) return pop.Level;
                for (int i = pop.Move; i >= 1; i--) {
                    if (pop.Position + i >= nums.Length) continue;
                    Node newNode = new Node(pop.Position + i, nums[pop.Position + i], pop.Level + 1);
                    queue.Enqueue(newNode);
                    //Console.WriteLine($"    Enqueue {newNode}");
                }
            }
            return -1;
        }
        // DP approach O(n^2)
        public int Jump2(int[] nums) {
            int n = nums.Length;
            int[] DP = new int[n];
            Array.Fill(DP, 10001);
            DP[0] = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 1; j <= nums[i]; j++) {
                    if (i + j < n) {
                        DP[i + j] = Math.Min(DP[i] + 1, DP[i + j]);
                    }
                }
            }
            foreach (var dp in DP) {
                Console.Write(dp + " ");
            }
            Console.WriteLine();
            return DP[n - 1];
        }
    }
}
