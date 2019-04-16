// <copyright file="IsEmployeePresent.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using ScreenPlay.Actions;
    using ScreenPlay.UI;

    /// <summary>
    /// Is employe present.
    /// </summary>
    public class IsEmployeePresent
    {
        /// <summary>
        /// Form.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <returns>boolean.</returns>
        public static bool Form(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, EmployeeUI.GetForm());
        }
    }
}