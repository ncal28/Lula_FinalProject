//File Name: LeetCodeProblem1028.cs
//Name: Gabe Guyler, Andrea Forero, Ethan Chaney, Nolan Callahan
//email:  guylergm @mail.uc.edu
//Assignment Number: Assignment Final
//Due Date:   2025 / 04 / 29
//Course #/Section:   2251-1_22 IS3050 001
//Semester / Year:   Spring 2025
//Brief Description of the assignment: FinalProject Create an ASP.NET web app where each team member solves a hard LeetCode problem, displays its description, test case, and solution.

//Brief Description of what this module does. Solves LeetCode 1028, "Recover a Tree From Preorder Traversal," 
//takes a specially formatted string that represents a binary tree in preorder with dashes indicating depth,
//and reconstructs the original binary tree. The solution parses the string and rebuilds the tree structure node by node.
//Citations: https://chatgpt.com/c/6807be4a-3250-800c-9c0f-b8847d2a8543 https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/description/
//Anything else that's relevant: Project completed in junction with 3 other partners

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula_FinalProject
{
    public class LeetCodeProblem1028
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public TreeNode RecoverFromPreorder(string traversal)
        {
            Stack<(TreeNode node, int depth)> stack = new Stack<(TreeNode, int)>();
            int i = 0;

            while (i < traversal.Length)
            {
                int depth = 0;
                while (i < traversal.Length && traversal[i] == '-')
                {
                    depth++;
                    i++;
                }

                int val = 0;
                while (i < traversal.Length && Char.IsDigit(traversal[i]))
                {
                    val = val * 10 + (traversal[i] - '0');
                    i++;
                }

                TreeNode newNode = new TreeNode(val);

                while (stack.Count > depth)
                    stack.Pop();

                if (stack.Count > 0)
                {
                    TreeNode parent = stack.Peek().node;
                    if (parent.left == null)
                        parent.left = newNode;
                    else
                        parent.right = newNode;
                }

                stack.Push((newNode, depth));
            }

            return stack.Count > 0 ? stack.ToArray()[0].node : null;
        }

        public string SolveExample()
        {
            var root = RecoverFromPreorder("1-2--3--4-5--6--7");
            return InOrderTraversal(root).Trim();
        }

        private string InOrderTraversal(TreeNode node)
        {
            if (node == null) return "";
            return InOrderTraversal(node.left) + node.val + " " + InOrderTraversal(node.right);
        }
    }
}
