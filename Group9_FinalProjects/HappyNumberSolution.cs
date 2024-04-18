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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group9_FinalProjects.Properties
{
    public class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {

            List<int> used = new List<int>();

            while (n > 0)
            {
                int tmp = 0;
                while (n > 0)
                {
                    int i = n % 10;

                    tmp += i * i;
                    n = n / 10;
                }

                if (used.Contains(tmp))
                {
                    return false;
                }
                else
                {
                    used.Add(tmp);
                }


                if (tmp == 1)
                {
                    return true;
                }

                n = tmp;

            }

            return false;
        }
    }

}
