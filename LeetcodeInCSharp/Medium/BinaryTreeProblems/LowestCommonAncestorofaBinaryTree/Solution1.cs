using System;
using LeetcodeInCSharp.Common.DataStructures;
using System.Collections.Generic;

namespace LeetcodeInCSharp.Medium.BinaryTreeProblems.LowestCommonAncestorofaBinaryTree
{
    public class Solution1
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val == p.val || root.val == q.val) return root;
            if(Contains(root.left, p))
                return Contains(root.left, q) ? LowestCommonAncestor(root.left, p, q) : root;
            return Contains(root.right, q) ? root : LowestCommonAncestor(root.right, p, q);
        }

        private bool Contains(TreeNode cur, TreeNode p)
        {            
            if (cur == null) return false;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(cur);

            while(stack.Count > 0)
            {
                TreeNode temp = stack.Pop();
                if (temp.val == p.val)
                    return true;
                if (cur.left != null)
                    stack.Push(cur.left);
                if (cur.right != null)
                    stack.Push(cur.right);
            }

            return false;
        }
    }
}
