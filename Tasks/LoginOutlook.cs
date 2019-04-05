using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Tasks
{
    public class LoginOutlook
    {
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Enter.Text(driver, LoginOutlookUI.UserInput, user);
            Click.On(driver, LoginOutlookUI.LoginButton);

            System.Threading.Thread.Sleep(4000);

            Enter.Text(driver, LoginOutlookUI.PassWordInput, passWord);
            Click.On(driver, LoginOutlookUI.LoginButton);
            Click.On(driver, LoginOutlookUI.OptionNo); 
        }
    }
}
