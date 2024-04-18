<!--
# Name: Quynh Doan
# email: doanqb
# Assignment Title: Final Project 
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year: Senior
# Brief Description: This project is about collaborating using GitHub
# Citations: https://chat.openai.com/, https://leetcode.com/problems/happy-number/solutions/2912200/happy-number-c-beats-96-fastest/
# Anything else that's relevant: N/A
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeEasy.aspx.cs" Inherits="Group9_FinalProjects.LeetCodeEasy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h1>Write an algorithm to determine if a number <code>n</code> is happy.</h1>
            <div>
              <h2>A happy number is a number defined by the following process:</h2>
              <ul>
                <li>Starting with any positive integer, replace the number by the sum of the squares of its digits.</li>
                <li>Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.</li>
                <li>Those numbers for which this process ends in 1 are happy.</li>
              </ul>
              <p>Return <code>true</code> if <code>n</code> is a happy number, and <code>false</code> if not.</p>
            </div>
            <div>
              <h2>Example 1:</h2>
              <p><strong>Input:</strong> <code>n = 19</code></p>
              <p><strong>Output:</strong> <code>true</code></p>
              <p><strong>Explanation:</strong></p>
              <p>1<sup>2</sup> + 9<sup>2</sup> = 82</p>
              <p>8<sup>2</sup> + 2<sup>2</sup> = 68</p>
              <p>6<sup>2</sup> + 8<sup>2</sup> = 100</p>
              <p>1<sup>2</sup> + 0<sup>2</sup> + 0<sup>2</sup> = 1</p>
            </div>
            <div>
              <h2>Example 2:</h2>
              <p><strong>Input:</strong> <code>n = 2</code></p>
              <p><strong>Output:</strong> <code>false</code></p>
            </div>
          </div>
      
            <asp:Label ID="lblHappyNumber" runat="server" Text="Enter a Number"></asp:Label>
            <asp:TextBox ID="txtHappyNumber" runat="server"></asp:TextBox> 
            <asp:Button ID="cmdRun" OnClick="cmdRun_Click" runat="server" Text="Run" />
             <hr />
            Solution: <asp:Label ID="lblSolution" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
