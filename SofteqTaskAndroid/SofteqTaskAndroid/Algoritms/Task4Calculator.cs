using System;
using System.Text.RegularExpressions;
/*
* Created by LiseGit at 31.12.2020.
* 
* */
namespace SofteqTaskAndroid.Algoritms
{
    class Task4Calculator:ITaskCalculator
    {
        private const string Pattern = @"^\s*([1-9]\d{0,2}|1000)\s+([1-9]\d{0,2}|1000)\s*$";
        private int _a;
        private int _b;

        public bool CheckInput(string input)
        {
            if (Regex.IsMatch(input, Pattern))
            {
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                _a = Convert.ToInt16(words[0]);
                _b = Convert.ToInt16(words[1]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCalculatedResult(string input)
        {
            return CheckInput(input)? CalculateResult().ToString(): "Incorrect input.";
        }

        private int CalculateResult()
        {
            return _a * _b + _a + _b;
        }
    }
}
