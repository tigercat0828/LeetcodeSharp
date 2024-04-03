using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode100 {

    //recursion
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // p and q are empty tree
        if (p == null && q == null) return true;

        // one is null, another is not null
        if (p == null || q == null) return false;

        // if p and q are not null, compare value
        if (p.val != q.val) return false;

        // then compare their child
        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right, q.right);
        return left && right;
    }
    // iteration
    public bool IsSameTree2(TreeNode p, TreeNode q) {
        // both are empty tree
        if (p == null && q == null) return true;

        if (p == null || q == null) return false;

        Queue<TreeNode> queueQ = [];
        Queue<TreeNode> queueP = [];

        queueP.Enqueue(q);
        queueQ.Enqueue(p);
        while (queueQ.Count > 0 && queueP.Count > 0) {
            TreeNode nodeP = queueP.Dequeue();
            TreeNode nodeQ = queueQ.Dequeue();


            if (nodeP == null || nodeQ == null) return false;

            if (nodeP.val != nodeQ.val) return false;

            if (nodeP.left != null || nodeQ.left != null) {
                queueP.Enqueue(nodeP.left);
                queueQ.Enqueue(nodeQ.left);
            }
            if (nodeP.right != null || nodeQ.right != null) {
                queueP.Enqueue(nodeP.right);
                queueQ.Enqueue(nodeQ.right);
            }
        }
        return true;
    }
}

