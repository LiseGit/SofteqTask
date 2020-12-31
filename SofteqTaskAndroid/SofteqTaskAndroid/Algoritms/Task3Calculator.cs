using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
/*
* Created by LiseGit at 30.12.2020.
* 
* */
namespace SofteqTaskAndroid.Algoritms
{
    class Task3Calculator
    {
        private int a, b, n, min, max, smin, smax = 0, o;
        private bool CheckInput(string input)
        {
            string pattern = @"^\s*([2-9]\s+){2}([2-9][0-9]|1[1-9]\s*)$";
            if (Regex.IsMatch(input, pattern))
            {
                String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                a = Convert.ToInt16(words[0]);
                b = Convert.ToInt16(words[1]);
                n = Convert.ToInt16(words[2]);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void setMaxAndMin(int x1, int x2)
        {
            smin = n / x1;
            o = n % x1;
            min = x1;
            max = x2;
        }
        private long calculateResult()
        {
            return  Convert.ToInt64(Math.Pow(min,smin) * Math.Pow(max, smax));
        }
        public string getCalculatedResult(string input)
        {
            if (CheckInput(input) == false)
            {
                return "Incorrect input.";
            }
            if (a < b)
            {
                setMaxAndMin(a, b);
            }
            else
            {
                setMaxAndMin(b, a);
            }
                while (true)
                {
                    if (o == 0)
                    {
                        return calculateResult().ToString();
                    }
                    else
                    {
                        if (smin == 0)
                        {
                            return "0";
                        }
                        else
                        {
                            o += min;
                            smin--;
                            if (o % max == 0)
                            {
                                smax = o / max;
                                o = 0;
                            }
                        }
                    }
                }
            }
        }
    }
