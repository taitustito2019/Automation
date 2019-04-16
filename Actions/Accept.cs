// <copyright file="Accept.cs" company="PlaceholderCompany">
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
    /// Accept ventain.
    /// </summary>
    public class Accept
    {
        /// <summary>
        /// Alert accept.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <returns>Boolean.</returns>
        public static bool Alert(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException)
            {
            }

            return false;
        }
    }
}
