using FreshMvvm;
using SofteqTaskAndroid.Algoritms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
/*
* Created by LiseGit at 28.12.2020.
* 
* */
namespace SofteqTaskAndroid.PageModels
{
    class Task3PageModel : FreshBasePageModel, INotifyPropertyChanged
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
