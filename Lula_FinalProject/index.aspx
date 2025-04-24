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
    </form>
</body>
</html>