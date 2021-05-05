using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
* Created by LiseGit at 31.12.2020.
* 
* */

namespace SofteqTaskAndroid.Algoritms
{
    class Task2Calculator : ITaskCalculator
    {
        private const string Pattern = @"^(\s*(4|6|8|10)\s+([4-9]|1[0-9]|20)\s*\n+)"
                + @"((\s*(([1-9](\d){0,2})|([1-2](\d){3})|3000)\s*\n+))+"
                + @"(\s*(([1-9](\d){0,2})|([1-2](\d){3})|3000)\s*\n*)\s*";

        private int _w;
        private int _t;
        private List<int> _runOut = new List<int>();

        public bool CheckInput(string input)
        {
            if (Regex.IsMatch(input, Pattern))
            {
                string[] words = input.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                _w = Convert.ToInt16(words[0]);
                _t = Convert.ToInt16(words[1]);
                if (_t < _w)
                {
                    return false;
                }
                else
                {
                    if (words.Length - 2 != _w)
                    {
                        return false;
                    }
                    else
                    {
                        for (int i = 2; i < words.Length; i++)
                        {
                            _runOut.Add(Convert.ToInt16(words[i]));
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

        public string GetCalculatedResult(string input)
        {
            return CheckInput(input) ? CalculateResult().ToString() : "Incorrect input.";
        }

        private double CalculateResult()
        {
            double result = 0;
            foreach (int run in _runOut)
            {
                result += (double)1 / run;
            }
            return Math.Round(_t / result, 3);
        }
    }
}