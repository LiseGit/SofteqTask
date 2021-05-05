using SofteqTaskAndroid.Algoritms;

/*
* Created by LiseGit at 28.12.2020.
* 
* */

namespace SofteqTaskAndroid.PageModels
{
    class Task2PageModel : BasePageModel<Task2Calculator>
    {
        public override void Calculate()
        {
            base.Calculate();
            Result = Calculator.GetCalculatedResult(Input);
        }
    }
}
