<!--
# Name: Anh Bui
# email: buivh@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations:https://chat.openai.com/, https://leetcode.com/problems/n-queens-ii/description/
# Anything else that's relevant:
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Group9_FinalProjects.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>N-Queens Solver</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://assets.leetcode.com/uploads/2020/11/13/queens.jpg" Width="400px" Height="200px" />
            <hr />

            Enter the size of the board (n): <asp:TextBox ID="txtN" runat="server" Width="50"></asp:TextBox>
            <asp:Button ID="btnSolve" runat="server" Text="Solve N-Queens" OnClick="SolveButton_Click" />
            <hr />
            Number of solutions: <asp:Label ID="lblSolutions" runat="server" />
        </div>
    </form>
</body>
</html>
