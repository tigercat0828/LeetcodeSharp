namespace Leetcode.CSharp.Solutions;
public class Leetcode1376 {
    int[] managers;
    int[] informTimes;
    int[] times;
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        // build tree
        List<List<int>> tree = new();
        for (int i = 0; i < n; i++) tree.Add(new List<int>());
        for (int i = 0; i < n; i++) {
            if (i == headID) continue;
            tree[manager[i]].Add(i);
        }

        managers = manager;
        informTimes = informTime;
        times = new int[n];

        // post order <leetcode 590>
        List<int> order = PostOrder(tree, headID);
        foreach (var em in order) {
            if (em == headID) continue;
            FindMyManager(em);
        }
        return times[headID];
    }
    private List<int> PostOrder(List<List<int>> tree, int root) {
        List<int> result = new(tree.Count);
        Stack<int> stack = new();
        stack.Push(root);
        while (stack.Any()) {
            int node = stack.Pop();
            result.Add(node);
            foreach (var item in tree[node]) {
                stack.Push(item);
            }
        }
        result.Reverse();
        Console.WriteLine(string.Join(',', result));
        return result;
    }
    private void FindMyManager(int employee) {
        int manager = managers[employee];
        int informTime = informTimes[manager];
        times[manager] = Math.Max(
            times[employee] + informTime,
            times[manager]);
    }
}
