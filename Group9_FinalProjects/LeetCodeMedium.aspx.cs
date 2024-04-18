using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group9_FinalProjects
{
    public partial class LeetCodeMedium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void GetCombinations_Click(object sender, EventArgs e)
        {
            var generator = new LetterCombinations();

            // Get the digits from the TextBox
            string digits = txtDigits.Text.Trim();

            // Validate the input to ensure it contains only valid characters (digits 2-9)
            if (!System.Text.RegularExpressions.Regex.IsMatch(digits, "^[2-9]*$"))
            {
                lblSolutions.Text = "Please enter digits between 2 and 9.";
                return;
            }

            // Call the method to get combinations
            IList<string> combinations = generator.letterCombinations(digits);

            // Format and display the results
            if (combinations.Count > 0)
            {
                lblSolutions.Text = String.Join(", ", combinations);
            }
            else
            {
                lblSolutions.Text = "No combinations available.";
            }
        }
    }
}