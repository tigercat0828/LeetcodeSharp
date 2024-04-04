using LeetcodeSharp.Common;
namespace LeetcodeSharp.Solutions;
public class Leetcode590 {
    public IList<int> Postorder(Node root) {
        if (root == null) return [];
        IList<int> result = [];
        Stack<Node> stack = new();
        stack.Push(root);
        while (stack.Count != 0) {
            Node pop = stack.Pop();
            result.Add(pop.val);
            foreach (var item in pop.children) {
                stack.Push(item);
            }
        }
        return result.Reverse().ToList();
    }
}
