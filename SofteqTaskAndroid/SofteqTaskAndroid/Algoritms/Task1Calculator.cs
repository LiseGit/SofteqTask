using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
/*
* Created by LiseGit at 30.12.2020.
* 
* */
namespace SofteqTaskAndroid.Algoritms
{
    class Task1Calculator
    {
        private bool CheckInput(string input)
        {
            string pattern = @"^((((-?\d+)(.\d{1,3})))|([1-9]\d*)|0)$";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        double function(double x)
        {
            return Math.Round((x * x * x * x) + 4 * (x * x * x) - 20 * (x * x) + 13.44, 3);
        }
        public ObservableCollection<string> getCalculatedResult(string input)
        {
            ObservableCollection<string> result = new ObservableCollection<string>();
            String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in words)
            {
                if (CheckInput(word))
                {
                    result.Add("f(" + word + ")=" + function(Convert.ToDouble(word)));
                }
                else
                {
                    result.Add("Incorrect input: " + word);
                }
            }
            return result;
        }
    }
}
