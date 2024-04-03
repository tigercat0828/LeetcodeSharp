namespace Leetcode.CSharp.Solutions;
public class Leetcode590 {
    public IList<int> Postorder(Node root) {
        if (root == null) return new List<int>();
        IList<int> result = new List<int>();
        Stack<Node> stack = new();
        stack.Push(root);
        while (stack.Any()) {
            Node pop = stack.Pop();
            result.Add(pop.val);
            foreach (var item in pop.children) {
                stack.Push(item);
            }
        }
        return result.Reverse().ToList();
    }
}
