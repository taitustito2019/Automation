// <copyright file="Enter.cs" company="PlaceholderCompany">
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
    /// Senkey text.
    /// </summary>
    public class Enter
    {
        /// <summary>
        /// Sendkey.
        /// </summary>
        /// <param name="driver">Driver.</param>
        /// <param name="locator">Locator.</param>
        /// <param name="text">Text.</param>
        public static void Text(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
    }
}
