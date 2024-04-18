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
public class NQueensSolver
{
    private int count;
    private bool[] rows;
    private bool[] diag1;
    private bool[] diag2;
    private int n;

    public NQueensSolver(int size)
    {
        n = size;
        count = 0;
        rows = new bool[n];
        diag1 = new bool[2 * n];
        diag2 = new bool[2 * n];
    }

    public int TotalNQueens()
    {
        Helper(0);
        return count;
    }

    private void Helper(int col)
    {
        if (col == n)
        {
            count++;
            return;
        }

        for (int row = 0; row < n; row++)
        {
            int a = row + col;
            int b = row - col + n;

            if (rows[row] || diag1[a] || diag2[b]) continue;

            rows[row] = diag1[a] = diag2[b] = true;
            Helper(col + 1);
            rows[row] = diag1[a] = diag2[b] = false;
        }
    }
}
