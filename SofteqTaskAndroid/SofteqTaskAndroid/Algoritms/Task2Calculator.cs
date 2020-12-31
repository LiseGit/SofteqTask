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
    class Task2Calculator
    {
        private int w, t;
        private List<int> runOut = new List<int>();

        bool CheckInput(string input)
        {
            string pattern = @"^(\s*(4|6|8|10)\s+([4-9]|1[0-9]|20)\s*\n+)((\s*(([1-9](\d){0,2})|([1-2](\d){3})|3000)\s*\n+))+(\s*(([1-9](\d){0,2})|([1-2](\d){3})|3000)\s*\n*)\s*";
            if (Regex.IsMatch(input, pattern))
            {
                string[] words = input.Split(new char[] { ' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                w = Convert.ToInt16(words[0]);
                t = Convert.ToInt16(words[1]);
                if (t < w)
                {
                    return false;
                }
                else
                {
                    if(words.Length-2 != w)
                    {
                        return false;
                    }
                    else
                    {
                        for(int i=2; i<words.Length; i++)
                        {
                            runOut.Add(Convert.ToInt16(words[i]));
                        }
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        double calculateResult()
        {
            double result=0;
            foreach (int run in runOut)
            {
                result += (double) 1 / run;
            }
            return Math.Round(t / result, 3);
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
