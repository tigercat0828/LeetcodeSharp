using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode2385 {
    Dictionary<int, HashSet<int>> Graph = [];
    public int AmountOfTime(TreeNode root, int start) {
        Dictionary<int, HashSet<int>> graph = [];
        // traverse the tree and turn to indirected graph
        Stack<TreeNode> stack = [];
        stack.Push(root);
        while (stack.Count > 0) {
            TreeNode node = stack.Pop();
            if (!graph.ContainsKey(node.val)) {
                graph.Add(node.val, []);
            }
            if (node.left != null) {
                int leftVal = node.left.val;
                if (!graph.ContainsKey(leftVal)) {
                    graph.Add(leftVal, []);
                }
                graph[node.val].Add(leftVal);
                graph[leftVal].Add(node.val);
                stack.Push(node.left);
            }
            if (node.right != null) {
                int rightVal = node.right.val;
                if (!graph.ContainsKey(rightVal)) {
                    graph.Add(rightVal, []);
                }
                graph[node.val].Add(rightVal);
                graph[rightVal].Add(node.val);
                stack.Push(node.right);
            }
        }

        int round = 0;
        // BFS
        Queue<int> queue = [];
        queue.Enqueue(start);
        HashSet<int> visited = [start];
        while (queue.Count > 0) {
            int count = queue.Count;
            for (int i = 0; i < count; i++) {
                int pop = queue.Dequeue();
                var neighbors = graph[pop];

                foreach (var node in neighbors) {
                    if (!visited.Contains(node)) {
                        queue.Enqueue(node);
                        visited.Add(node);
                    }
                }
            }
            round++;
        }
        return round - 1;
    }
    // may stack overflow
    private void Traversal(TreeNode node) {
        if (!Graph.ContainsKey(node.val)) {
            Graph.Add(node.val, []);
        }
        if (node.left != null) {
            int leftVal = node.left.val;
            if (!Graph.ContainsKey(leftVal)) {
                Graph.Add(leftVal, []);
            }
            Graph[node.val].Add(leftVal);
            Graph[leftVal].Add(node.val);
            Traversal(node.left);
        }
        if (node.right != null) {
            int rightVal = node.right.val;
            if (!Graph.ContainsKey(rightVal)) {
                Graph.Add(rightVal, []);
            }
            Graph[node.val].Add(rightVal);
            Graph[rightVal].Add(node.val);
            Traversal(node.right);
        }
    }
}
