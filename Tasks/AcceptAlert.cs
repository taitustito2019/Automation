// <copyright file="AcceptAlert.cs" company="PlaceholderCompany">
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
    using ScreenPlay.Actions;

    /// <summary>
    /// Accept Alert.
    /// </summary>
    public class AcceptAlert
    {
        /// <summary>
        /// Success.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <returns>boolean.</returns>
        public static bool Success(IWebDriver driver)
        {
            return Accept.Alert(driver);
        }
    }
}
