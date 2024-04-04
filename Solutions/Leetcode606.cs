using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
//606. Construct String from Binary Tree
public class Leetcode606 {

    public string Tree2str(TreeNode root) {
        return Preorder(root);
    }
    private string Preorder(TreeNode node) {
        if (node == null) return "";
        string result = node.val.ToString();

        if (node.left != null || node.right != null) {
            result += $"({Preorder(node.left)})";
        }
        if (node.right != null) {
            result += $"({Preorder(node.right)})";
        }
        return result.ToString();
    }
    private string Preorder2(TreeNode node) {
        if (node == null) return "";

        if (node.left == null && node.right == null) return $"{node.val}"; // XX

        else if (node.left != null && node.right != null) {           // OO
            return $"{node.val}({Preorder(node.left)})({Preorder(node.right)})";
        }
        else if (node.left != null && node.right == null) {      // OX
            return $"{node.val}({Preorder(node.left)})";
        }
        else {  // XO
            return $"{node.val}()({Preorder(node.right)})";
        }
    }
}
