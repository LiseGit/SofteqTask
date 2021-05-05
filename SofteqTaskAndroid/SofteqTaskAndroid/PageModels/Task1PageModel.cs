using SofteqTaskAndroid.Algoritms;

/*
* Created by LiseGit at 28.12.2020.
* 
* */

namespace SofteqTaskAndroid.PageModels
{
    class Task1PageModel : BasePageModel<Task1Calculator>
    {
        public override void Calculate()
        {
            base.Calculate();
            ResultList = Calculator.GetCalculatedResult(Input);
        }
    }
}
