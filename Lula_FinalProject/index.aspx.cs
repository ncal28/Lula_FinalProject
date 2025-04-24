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
    }
}