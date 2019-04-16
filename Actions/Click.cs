// <copyright file="Click.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;

    /// <summary>
    /// Click element.
    /// </summary>
    public class Click
    {
        /// <summary>
        /// Function on for click.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="locator">locator.</param>
        public static void On(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(locator).Click();
        }
    }
}
