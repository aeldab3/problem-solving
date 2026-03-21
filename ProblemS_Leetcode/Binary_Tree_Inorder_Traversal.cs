using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Binary_Tree_Inorder_Traversal
    {
        /*
         94- Binary Tree Inorder Traversal
         Given the root of a binary tree, return the inorder traversal of its nodes' values.
         */

        public static void Run()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            Solution s = new Solution();
            var result = s.InorderTraversal(root);

            foreach (var item in result)
                Console.Write(item + " ");
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int _val = 0, TreeNode _left = null, TreeNode _right = null)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                Traverse(root, result);
                return result;
            }

            private void Traverse(TreeNode node, List<int> result)
            {
                if (node == null) return;
                Traverse(node.left, result);
                result.Add(node.val);
                Traverse(node.right, result);
            }
        }
    }
}