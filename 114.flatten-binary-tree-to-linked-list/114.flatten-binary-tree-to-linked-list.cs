/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public void Flatten(TreeNode root) {
        /**********
        if (root == null) return;
        Flatten(root.left);
        Flatten(root.right);
        TreeNode temp = root.right;
        root.right = root.left;
        root.left = null;
        while (root.right != null) root = root.right;
        root.right = temp;

        **************/

        if (root == null) return;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0) {
            TreeNode node = stack.Pop();
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
            node.left = null;
            if (stack.Count > 0) node.right = stack.Peek();
        }



    }
}
// @lc code=end

