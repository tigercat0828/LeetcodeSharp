namespace Leetcode.CSharp.Solutions {
    // Definition for a Node.

    public class Leetcode133 {
        public class Node {
            public int val;
            public IList<Node> neighbors;
            public Node() {
                val = 0;
                neighbors = new List<Node>();
            }
            public Node(int _val) {
                val = _val;
                neighbors = new List<Node>();
            }
            public Node(int _val, List<Node> _neighbors) {
                val = _val;
                neighbors = _neighbors;
            }
        }

        public Node CloneGraph(Node node) {
            if (node == null) return null;
            // BFS
            Dictionary<int, Node> dict = new();
            Queue<Node> queue = new Queue<Node>();
            bool[] visited = new bool[101];
            queue.Enqueue(node);
            while (queue.Count > 0) {
                Node pop = queue.Dequeue();
                if (visited[pop.val]) continue;
                visited[pop.val] = true;

                if (!dict.ContainsKey(pop.val)) {
                    Node newNode = new Node(pop.val, new List<Node>());
                    dict.Add(pop.val, newNode);
                }
                Node current = dict[pop.val];
                foreach (var nei in pop.neighbors) {

                    queue.Enqueue(nei);
                    if (!dict.ContainsKey(nei.val)) {
                        Node newNode = new Node(nei.val, new List<Node>());
                        dict.Add(nei.val, newNode);
                    }
                    current.neighbors.Add(dict[nei.val]);
                }

            }
            return dict[1];
        }
    }
}
