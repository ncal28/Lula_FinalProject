<!-- 
* File Name: Guylergm_Lula_FinalProject

* Name: Gabe Guyler
* email:  guylergm@mail.uc.edu
* Assignment Number: Assignment Final
* Due Date:   2025/04/29
* Course #/Section:   2251-1_22 IS3050 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  FinalProject

* Brief Description of what this module does. Solves LeetCode 1028, "Recover a Tree From Preorder Traversal," 
  takes a specially formatted string that represents a binary tree in preorder with dashes indicating depth, 
  and reconstructs the original binary tree. The solution parses the string and rebuilds the tree structure node by node.
* Citations: https://chatgpt.com/c/6807be4a-3250-800c-9c0f-b8847d2a8543 https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/description/
* Anything else that's relevant: Project compled in junction with 3 other partners
 -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lula_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>Find Median of Two Sorted Arrays</h2>

            <label>Array 1 (comma separated):</label><br />
            <asp:TextBox ID="txtNums1" runat="server" Width="300px" /><br /><br />

            <label>Array 2 (comma separated):</label><br />
            <asp:TextBox ID="txtNums2" runat="server" Width="300px" /><br /><br />

            <asp:Button ID="btnCalculate" runat="server" Text="Calculate Median" OnClick="btnCalculate_Click" /><br /><br />

            <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
        </div>
        <div>
        <!-- Gabe's Problem 1028 Section -->
        <asp:Button ID="btnShowSolution1028" runat="server" Text="Problem 1028" OnClick="btnShowSolution1028_Click" />
        <br />
        <asp:Label ID="lblDescription1028" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTestCase1028" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult1028" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>