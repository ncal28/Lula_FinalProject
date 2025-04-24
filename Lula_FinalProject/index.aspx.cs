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
            /* Ethan's problem 42 below */
        protected void btnShowSolution_Click(object sender, EventArgs e)
        {
            var problem = new LeetsCodeProblem42();

            int[] test1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int[] test2 = { 4, 2, 0, 3, 2, 5 };

            lblDescription.Text = problem.GetDescription();
            lblTestCase1.Text = "Test Case 1: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]";
            lblResult1.Text = "Output: " + problem.Solve(test1);
            lblTestCase2.Text = "Test Case 2: [4, 2, 0, 3, 2, 5]";
            lblResult2.Text = "Output: " + problem.Solve(test2);
        }
    }
    }
}