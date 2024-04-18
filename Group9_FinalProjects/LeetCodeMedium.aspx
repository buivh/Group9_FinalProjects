<!--
# Name: Duyen Huynh
# email: huynhd2@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations: https://chat.openai.com/,https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
# Anything else that's relevant:
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeMedium.aspx.cs" Inherits="Group9_FinalProjects.LeetCodeMedium" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Letter Combinations of a Phone Number</h1>
            <div class="form-group">
                <label for="txtDigits">Enter Digits:</label>
                <div class="input-group">
                    <asp:TextBox ID="txtDigits" runat="server" placeholder="Enter digits"></asp:TextBox>
                    <asp:Button ID="btnGetCombinations" runat="server" Text="Get Combinations" OnClick="GetCombinations_Click" />
                </div>
            </div>
            Letter Combinations:
            <asp:Label ID="lblSolutions" runat="server" />
        </div>
    </form>
</body>
</html>
