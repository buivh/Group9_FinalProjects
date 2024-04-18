/*
# Name: Duyen Huynh
# email: huynhd2@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations:https://chat.openai.com/,https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
# Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group9_FinalProjects
{
    public class LetterCombinations
    {
        public IList<string> letterCombinations(string digits)
        {
            Dictionary<char, string> phone = new Dictionary<char, string> {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

            List<string> result = new List<string>();
            if (digits.Length == 0) return result;
            Search("", digits, 0, phone, result);
            return result;
        }

        private void Search(string combination, string digits, int index, Dictionary<char, string> phone, List<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(combination);
                return;
            }
            string letters = phone[digits[index]];
            foreach (char letter in letters)
            {
                Search(combination + letter, digits, index + 1, phone, result);
            }
        }
    }
}