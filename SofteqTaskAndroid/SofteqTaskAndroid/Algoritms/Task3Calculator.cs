using System;
using System.Text.RegularExpressions;

/*
* Created by LiseGit at 30.12.2020.
* 
* */

namespace SofteqTaskAndroid.Algoritms
{
    class Task3Calculator : ITaskCalculator
    {
        private int _a;
        private int _b;
        private int _n;
        private int _min;
        private int _max;
        private int _smin;
        private int _smax = 0;
        private int _o;

        public bool CheckInput(string input)
        {
            string pattern = @"^\s*([2-9]\s+){2}([2-9][0-9]|1[1-9]\s*)$";
            if (Regex.IsMatch(input, pattern))
            {
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                _a = Convert.ToInt16(words[0]);
                _b = Convert.ToInt16(words[1]);
                _n = Convert.ToInt16(words[2]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCalculatedResult(string input)
        {
            if (CheckInput(input) == false)
            {
                return "Incorrect input.";
            }
            if (_a < _b)
            {
                SetMaxAndMin(_a, _b);
            }
            else
            {
                SetMaxAndMin(_b, _a);
            }
            while (true)
            {
                if (_o == 0)
                {
                    return CalculateResult().ToString();
                }
                else
                {
                    if (_smin == 0)
                    {
                        return "0";
                    }
                    else
                    {
                        _o += _min;
                        _smin--;
                        if (_o % _max == 0)
                        {
                            _smax = _o / _max;
                            _o = 0;
                        }
                    }
                }
            }
        }

        private void SetMaxAndMin(int x1, int x2)
        {
            _smin = _n / x1;
            _o = _n % x1;
            _min = x1;
            _max = x2;
        }

        private long CalculateResult()
        {
            return Convert.ToInt64(Math.Pow(_min, _smin) * Math.Pow(_max, _smax));
        }
    }
}
