// <copyright file="AssertWait.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;

    /// <summary>
    /// Wait time.
    /// </summary>
    public class AssertWait
    {
        /// <summary>
        /// Implicit wait.
        /// </summary>
        /// <param name="driver">Driver.</param>
        /// <param name="locator">Locator.</param>
        public void Wait(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            try
            {
                while (Assert.Equals(driver.FindElement(locator).Displayed, true))
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Esperar más... " + ex.Message);
                System.Threading.Thread.Sleep(2000);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
    }
}
