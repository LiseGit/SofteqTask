using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
/*
* Created by LiseGit at 31.12.2020.
* 
* */
namespace SofteqTaskAndroid.Algoritms
{
    class Task4Calculator
    {
        private int a, b;
        private bool CheckInput(string input)
        {
            string pattern = @"^\s*([1-9]\d{0,2}|1000)\s+([1-9]\d{0,2}|1000)\s*$";
            if (Regex.IsMatch(input, pattern))
            {
                String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                a = Convert.ToInt16(words[0]);
                b = Convert.ToInt16(words[1]);
                return true;
            }
            else
            {
                return false;
            }
        }
        int calculateResult()
        {
            return a * b + a + b;
        }
        public string getCalculatedResult(string input)
        {
            if (CheckInput(input) == false)
            {
                return "Incorrect input.";
            }
            else
            {
                return calculateResult().ToString();
            }
        }
    }
}
