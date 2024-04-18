/*
# Name: Anh Bui
# email: buivh@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations:https://chat.openai.com/, https://leetcode.com/problems/n-queens-ii/description/
# Anything else that's relevant:
*/
using System;
using System.Web.UI;

namespace Group9_FinalProjects
{
    public partial class Default : Page
    {
        protected void SolveButton_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n))
            {
                NQueensSolver solver = new NQueensSolver(n);
                int solutions = solver.TotalNQueens();
                lblSolutions.Text = solutions.ToString();
            }
            else
            {
                lblSolutions.Text = "Invalid input. Please enter a valid integer.";
            }
        }
    }
}
