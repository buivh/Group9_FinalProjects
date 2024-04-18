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
