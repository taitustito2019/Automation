// <copyright file="AddEmployee.cs" company="PlaceholderCompany">
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
    using ScreenPlay.UI;

    /// <summary>
    /// Add Employe.
    /// </summary>
    public class AddEmployee
    {
        /// <summary>
        /// With data.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        public static void WithTheData(IWebDriver driver, string name, string email, string address, string phone)
        {
            Enter.Text(driver, EmployeeUI.GetNameInput(), name);
            Enter.Text(driver, EmployeeUI.GetEmailInput(), email);
            Enter.Text(driver, EmployeeUI.GetAddressTextArea(), address);
            Enter.Text(driver, EmployeeUI.GetPhoneInput(), phone);
            Click.On(driver, EmployeeUI.GetAddButton());
        }
    }
}
