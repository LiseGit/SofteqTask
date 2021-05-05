using SofteqTaskAndroid.Algoritms;

/*
* Created by LiseGit at 28.12.2020.
* 
* */

namespace SofteqTaskAndroid.PageModels
{
    class Task4PageModel : BasePageModel<Task4Calculator>
    {
        public override void Calculate()
        {
            base.Calculate();
            Result = Calculator.GetCalculatedResult(Input);
        }
    }
}
