using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    class AssertWait
    {
        public void Wait(IWebDriver Driver,By Locator)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            try
            {
                while ( Assert.Equals(Driver.FindElement(Locator).Displayed, true))
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Esperar más... " + ex.Message);
                System.Threading.Thread.Sleep(2000);
            }
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
    }
}
