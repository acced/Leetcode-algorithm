/*
 * @lc app=leetcode id=116 lang=csharp
 *
 * [116] Populating Next Right Pointers in Each Node
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if (root==null)
        {
            return null;
        }
        traverse(root.left,root.right);
        return root;
        
    }

    public void traverse(Node left,Node right){
        if (left==null||right==null)
        {
            return ;
        }
        left.next=right;


        traverse(left.left,left.right);
        traverse(left: right.left,right.right);
        traverse(left: left.right,right.left);




    }
}
// @lc code=end

