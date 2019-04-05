using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.UI
{
    class LoginOutlookUI
    {
        public static By UserInput = By.CssSelector("input[name='loginfmt']");
        public static By PassWordInput = By.CssSelector("input[name='passwd']");
        public static By LoginButton = By.CssSelector("input[type='submit']");
        public static By OptionNo = By.CssSelector("input[value = 'No']");
    }
}
