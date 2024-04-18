/*
# Name: Anh Bui
# email: buivh@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations:Github, chatGPT
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group9_FinalProjects
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdLeetCodeEasy_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeEasy.aspx");
        }

        protected void cmdLeetCodeMedium_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeMedium.aspx");
        }

        protected void cmdLeetCodeHard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}