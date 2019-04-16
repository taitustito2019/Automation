// <copyright file="WaitUntil.cs" company="PlaceholderCompany">
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
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Wait Until.
    /// </summary>
    public class WaitUntil
    {
        /// <summary>
        /// Element is present.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="locator">locator.</param>
        /// <returns>boolean.</returns>
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch
            {
            }

            return false;
        }
    }
}
