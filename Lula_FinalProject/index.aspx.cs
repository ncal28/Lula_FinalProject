//File Name: Index.aspx.cs
//Name: Gabe Guyler, Andrea Forero, Ethan Chaney, Nolan Callahan
//email:  guylergm@mail.uc.edu, @mail.uc.edu, @mail.uc.edu, @mail.uc.edu
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
using System.Web.UI;
using System.Web.UI.WebControls;
using leetcode_problem_04;

namespace Lula_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int[] nums1 = txtNums1.Text.Split(',').Select(int.Parse).ToArray();
                int[] nums2 = txtNums2.Text.Split(',').Select(int.Parse).ToArray();

                Problem4 solver = new Problem4();
                double median = solver.FindMedianSortedArrays(nums1, nums2);

                lblResult.Text = "Median is: " + median;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
            }
        }
        /* Gabe's problem 1028 below */
        protected void btnShowSolution1028_Click(object sender, EventArgs e)
        {
            var problem = new Lula_FinalProject.LeetCodeProblem1028();

            lblDescription1028.Text = "LeetCode 1028 - Recover a Tree From Preorder Traversal";
            lblTestCase1028.Text = "Test Case: \"1-2--3--4-5--6--7\"";
            lblResult1028.Text = "Output (In-Order Traversal): " + problem.SolveExample();
        }
    }
}