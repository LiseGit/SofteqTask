using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

/*
* Created by LiseGit at 30.12.2020.
* 
* */

namespace SofteqTaskAndroid.Algoritms
{
    class Task1Calculator: ITaskCalculator
    {
        private string pattern = @"^\s*((((-?\d+)(.\d+)))|(-?[1-9]\d*)|0)\s*$";
        public bool CheckInput(string input)
        {
            return Regex.IsMatch(input, pattern);
        }

        public ObservableCollection<string> GetCalculatedResult(string input)
        {
            ObservableCollection<string> result = new ObservableCollection<string>();
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in words)
            {
                result.Add(CheckInput(word)?"f(" + word + ")=" + Function(Convert.ToDouble(word)) : "Incorrect input: " + word);
            }
            return result;
        }

        private double Function(double x)
        {
            return Math.Round((x * x * x * x) + 4 * (x * x * x) - 20 * (x * x) + 13.44, 3);
        }
    }
}
