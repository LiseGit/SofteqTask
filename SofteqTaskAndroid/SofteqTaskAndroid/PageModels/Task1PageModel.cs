using SofteqTaskAndroid.Algoritms;
using SofteqTaskAndroid.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
/*
* Created by LiseGit at 28.12.2020.
* 
* */
namespace SofteqTaskAndroid.PageModels
{
    class Task1PageModel : ChangebleBasePageModel
    {
        private ObservableCollection<string> _result = new ObservableCollection<string>();
        public string Input { get; set; }
        public ObservableCollection<string> ResultList
        {
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
            Task1Calculator calculator = new Task1Calculator();
            ResultList = calculator.getCalculatedResult(Input);
        }
    }
}
