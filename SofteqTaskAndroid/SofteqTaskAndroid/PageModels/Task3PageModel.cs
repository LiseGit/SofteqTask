using SofteqTaskAndroid.Algoritms;
using SofteqTaskAndroid.Models;
using System.Windows.Input;
using Xamarin.Forms;
/*
* Created by LiseGit at 28.12.2020.
* 
* */
namespace SofteqTaskAndroid.PageModels
{
    class Task3PageModel : ChangebleBasePageModel
    {
        private string _result;
        public string Input { get; set; }
        public string Result {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        public ICommand CalculateCommand => new Command(Calculate);
        private void Calculate()
        {
            Task3Calculator calculator = new Task3Calculator();
            Result = calculator.getCalculatedResult(Input);
        }
    }
}
