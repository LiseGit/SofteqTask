using FreshMvvm;
using SofteqTaskAndroid.Algoritms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

/*
* Created by LiseGit at 28.12.2020.
* 
* */

namespace SofteqTaskAndroid.PageModels
{
    class BasePageModel<TCalculator> : FreshBasePageModel where TCalculator : ITaskCalculator
    {
        public TCalculator Calculator;

        private string _result;
        private ObservableCollection<string> _resultList = new ObservableCollection<string>();

        public string Input { get; set; }

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<string> ResultList
        {
            get { return _resultList; }
            set
            {
                _resultList = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CalculateCommand => new Command(Calculate);

        public virtual void Calculate()
        {
            Calculator = IocContainer.IocContainer.Instance.Resolve<TCalculator>();
        }
    }
}
