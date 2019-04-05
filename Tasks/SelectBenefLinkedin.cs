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
    class SelectBenefLinkedin
    {
        public static void SelectBenef(IWebDriver driver)
        { 
            Click.On(driver, BenefitsMicrosoft.LinkLinkedin);
        }
    }

}
