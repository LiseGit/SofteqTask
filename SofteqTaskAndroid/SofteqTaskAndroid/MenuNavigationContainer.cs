using FreshMvvm;
using SofteqTaskAndroid.PageModels;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Created by LiseGit at 28.12.2020.
 * 
 * */
namespace SofteqTaskAndroid
{
    class MenuNavigationContainer : FreshMasterDetailNavigationContainer
    {
        public MenuNavigationContainer(string naserviceName) : base(naserviceName)
        {
            Init("menu");
            AddPage<Task1PageModel>("Task №1");
            AddPage<Task2PageModel>("Task №2");
            AddPage<Task3PageModel>("Task №3");
            AddPage<Task4PageModel>("Task №4");
        }
    }
}
