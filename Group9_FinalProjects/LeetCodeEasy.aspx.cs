/*
# Name: Quynh Doan
# email: doanqb
# Assignment Title: Final Project 
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year: Senior
# Brief Description: This project is about collaborating using GitHub
# Citations: https://chat.openai.com/, https://leetcode.com/problems/happy-number/solutions/2912200/happy-number-c-beats-96-fastest/
# Anything else that's relevant: N/A
*/
using Group9_FinalProjects.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group9_FinalProjects
{
    public partial class LeetCodeEasy : System.Web.UI.Page
    {

        protected void cmdRun_Click(object sender, EventArgs e)
        {

            int n;
            if (int.TryParse(txtHappyNumber.Text, out n))
            {
                HappyNumberSolution solver = new HappyNumberSolution();
                bool solutions = solver.IsHappy(n);
                String solutionString;
                if (solutions) solutionString = n.ToString() + " is a happy number";
                else solutionString = n.ToString() + " is not a happy number";
                lblSolution.Text = solutionString;
            }
            else
            {
                lblSolution.Text = "Invalid input. Please enter a valid integer.";
            }

        }

       
    }
}